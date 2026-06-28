using AutoMapper;
using Makaan_BLL.DTOs.ProductDTO;
using Makaan_BLL.DTOs.ProductTypeDTO;
using Makaan_BLL.DTOs.SliderDTO;
using Makaan_Entity;

namespace Makaan_UI.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ResultProductDTO>().ReverseMap();
            CreateMap<ProductType, ResultProductTypeDTO>().ReverseMap();
            CreateMap<Slider, ResultSliderDTO>().ReverseMap();            
        }
    }
}
