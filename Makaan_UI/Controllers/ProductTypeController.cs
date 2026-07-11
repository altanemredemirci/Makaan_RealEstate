using AutoMapper;
using Makaan_BLL.Abstract;
using Makaan_BLL.DTOs.ProductTypeDTO;
using Makaan_Entity;
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
        public async Task<IActionResult> Create(CreateProductTypeDTO dto, IFormFile file)
        {
            ModelState.Remove("Icon");
            ModelState.Remove("file");
            if(ModelState.IsValid)
            {
                if (file == null)
                {
                    ModelState.AddModelError("", "Ikon için dosya yüklenmedi");
                    return View(dto);
                }

                if(file.ContentType=="image/png" || file.ContentType == "image/jpg" || file.ContentType == "image/jpeg")
                {
                    string newFileName = GenerateUniqueFileName();
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", newFileName);

                    using(var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    dto.Icon = newFileName;

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

        private static string GenerateUniqueFileName(string fileExtension = ".png")
        {
            var timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            var uniqeuName = $"{timeStamp}{fileExtension}";

            return uniqeuName;
        }

    }
}
