using AutoMapper;
using Makaan_BLL;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.ProductDetailDTO;
using Makaan_BLL.DTOs.ProductDTO;
using Makaan_Entity;
using Makaan_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly ICityService _cityService;
        private readonly IAgencyService _agencyService;
        private readonly IProductTypeService _productTypeService;
        private readonly IProductDetailService _productDetailService;

        public ProductController(IProductService productService,IMapper mapper, ICityService cityService, IAgencyService agencyService, IProductTypeService productTypeService,IProductDetailService productDetailService)
        {
            _productService = productService;
            _mapper = mapper;
            _cityService = cityService;
            _agencyService = agencyService;
            _productTypeService = productTypeService;
            _productDetailService= productDetailService;
        }

        public IActionResult Index()
        {
            var products = _mapper.Map<List<ResultProductDTO>>(_productService.GetAll());
            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Cities = _cityService.GetAll();
            ViewBag.ProductTypes = _productTypeService.GetAll();
            ViewBag.Agencies = _agencyService.GetAll();
            return View(new CreateProductDetailDTO());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProductDetailDTO dto, IFormFile file, IFormFile[] files)
        {
            ModelState.Remove("Product.CoverImage");
            ModelState.Remove("Product.ProductType");
            ModelState.Remove("Product.City");
            ModelState.Remove("Product.Agency");
            if (ModelState.IsValid)
            {
                if (file == null)
                {
                    ViewBag.Cities = _cityService.GetAll();
                    ViewBag.ProductTypes = _productTypeService.GetAll();
                    ViewBag.Agencies = _agencyService.GetAll();
                    ModelState.AddModelError("", "İkon için dosya yüklenmedi.");
                    return View(dto);
                }

                if (files.Length == 0)
                {
                    ViewBag.Cities = _cityService.GetAll();
                    ViewBag.ProductTypes = _productTypeService.GetAll();
                    ViewBag.Agencies = _agencyService.GetAll();
                    ModelState.AddModelError("", "İlan detay resimleri yüklenmedi.");
                    return View(dto);
                }

                dto.Product.CoverImage = await ImageMethods.UploadImage(file);

                foreach (var item in files) 
                {
                    Makaan_Entity.Image image = new Makaan_Entity.Image();
                    image.Url = await ImageMethods.UploadImage(item);
                    dto.Images.Add(image);
                }

                dto.Product.Status = true;
                dto.PublishDate = DateTime.Now;
                _productDetailService.Create(_mapper.Map<ProductDetail>(dto));

                return RedirectToAction("Index");
            }

            ViewBag.Cities = _cityService.GetAll();
            ViewBag.ProductTypes = _productTypeService.GetAll();
            ViewBag.Agencies = _agencyService.GetAll();
            return View(dto);
        }

        public IActionResult Edit(int id)
        {
            var product = _productService.GetById(id);

            if (product==null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    Code = 102,
                    Title = "İlan Bulunamadı",
                    Description = "Lüften varolan bir ilan seçiniz.",
                    ReturnUrl = "/Product/Index",
                    Css = "text-danger"
                };
                return View("Error", error);
            }

            var model = _mapper.Map<UpdateProductDTO>(product);

            ViewBag.Cities = _cityService.GetAll();
            ViewBag.Agencies = _agencyService.GetAll();
            ViewBag.ProductTypes = _productTypeService.GetAll();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateProductDTO dto, IFormFile file)
        {
            ModelState.Remove("file");
            if (ModelState.IsValid)
            {
                var product = _productService.GetById(dto.Id);

                if (product == null)
                {
                    ErrorViewModel error = new ErrorViewModel()
                    {
                        Code = 102,
                        Title = "İlan Bulunamadı",
                        Description = "Lüften varolan bir ilan seçiniz.",
                        ReturnUrl = "/Product/Index",
                        Css = "text-danger"
                    };
                    return View("Error", error);
                }

                if (file != null)
                {
                    ImageMethods.DeleteImage(product.CoverImage);
                    dto.CoverImage = await ImageMethods.UploadImage(file);
                }
                
                _productService.Update(_mapper.Map<Product>(dto));
                return RedirectToAction("Index");
            }

            ViewBag.Cities = _cityService.GetAll();
            ViewBag.Agencies = _agencyService.GetAll();
            ViewBag.ProductTypes = _productTypeService.GetAll();

            return View(dto);
        }
    }
}
