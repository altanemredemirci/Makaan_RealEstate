using AutoMapper;
using Makaan_BLL;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.ProductTypeDTO;
using Makaan_Entity;
using Makaan_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Makaan_UI.Controllers
{
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeService _productTypeService;
        private readonly IMapper _mapper;

        public ProductTypeController(IProductTypeService productTypeService,IMapper mapper)
        {
            _productTypeService=productTypeService;
            _mapper=mapper;
        }

        public IActionResult Index()
        {
            var productTypes = _productTypeService.GetAll();
            var models = _mapper.Map<List<ResultProductTypeDTO>>(productTypes);
            return View(models);
        }

        public IActionResult Create()
        {
            return View(new CreateProductTypeDTO());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateProductTypeDTO dto, IFormFile file)
        {
            ModelState.Remove("Icon");
            ModelState.Remove("file");
            if(ModelState.IsValid)
            {
                var productType = _productTypeService.GetAll(i => i.Name == dto.Name);

                if (productType.Count>0)
                {
                    ErrorViewModel error = new ErrorViewModel()
                    {
                        Code = 101,
                        Title = "Kayıt Hatası",
                        Description = "Aynı isimde kayıtlı bir ilan kategorisi vardır.Lütfen farklı isim girişi yapınız.",
                        ReturnUrl = "/ProductType/Index",
                        Css = "text-warning"

                    };

                    return View("Error", error);
                }

                if (file == null)
                {
                    ModelState.AddModelError("", "Ikon için dosya yüklenmedi");
                    return View(dto);
                }

                if(file.ContentType=="image/png" || file.ContentType == "image/jpg" || file.ContentType == "image/jpeg")
                {
                    dto.Icon = await ImageMethods.UploadImage(file);

                    _productTypeService.Create(_mapper.Map<ProductType>(dto));

                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Ikon için dosya tipi png,jpg veya jpeg olmalıdır.");
                    return View(dto);
                }
             
            }

            return View(dto);
        }

        public IActionResult Edit(int id)
        {
            var productType = _productTypeService.GetById(id);

            if (productType == null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    Code = 404,
                    Title = "İlan Kategorisi Bulunamadı",
                    Description = "Lütfen seçtiğiniz yapıyı tekrar kontrol ediniz",
                    ReturnUrl = "/ProductType/Index",
                    Css = "text-danger"

                };

                return View("Error", error);
            }

            return View(_mapper.Map<UpdateProductTypeDTO>(productType));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateProductTypeDTO dto,IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    ImageMethods.DeleteImage(dto.Icon);

                    dto.Icon = await ImageMethods.UploadImage(file);
                }

                _productTypeService.Update(_mapper.Map<ProductType>(dto));
                return RedirectToAction("Index");
            }

            return View(dto);
        }

        public IActionResult Delete(int id)
        {
            var productType = _productTypeService.GetById(id);

            if (productType == null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    Code = 404,
                    Title = "İlan Kategorisi Bulunamadı",
                    Description = "Lütfen seçtiğiniz yapıyı tekrar kontrol ediniz",
                    ReturnUrl = "/ProductType/Index",
                    Css = "text-danger"

                };

                return View("Error", error);
            }

            _productTypeService.Delete(productType);
            return RedirectToAction("Index");
        }

       

    }
}
