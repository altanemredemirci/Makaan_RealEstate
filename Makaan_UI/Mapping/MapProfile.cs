using AutoMapper;
using Makaan_BLL.DTOs.AgencyDTO;
using Makaan_BLL.DTOs.ClientDTO;
using Makaan_BLL.DTOs.ContactDTO;
using Makaan_BLL.DTOs.ProductDTO;
using Makaan_BLL.DTOs.ProductTypeDTO;
using Makaan_BLL.DTOs.SliderDTO;
using Makaan_BLL.DTOs.WhoWeAreDTO;
using Makaan_Entity;

namespace Makaan_UI.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ResultProductDTO>().ReverseMap();

            CreateMap<ProductType, ResultProductTypeDTO>().ReverseMap();
            CreateMap<ProductType, CreateProductTypeDTO>().ReverseMap();
            CreateMap<ProductType, UpdateProductTypeDTO>().ReverseMap();

            CreateMap<Slider, ResultSliderDTO>().ReverseMap();

            CreateMap<WhoWeAre, ResultWhoWeAreDTO>().ReverseMap();

            CreateMap<Agency, ResultAgencyDTO>().ReverseMap();

            CreateMap<Client, ResultClientDTO>().ReverseMap();

            CreateMap<Contact, ResultContactDTO>().ReverseMap();
        }
    }
}
