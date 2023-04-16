using ClothingShopApi.Abstract.Interfaces;
using ClothingShopApi.Abstract.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClothingShopApi.Web
{
    [ApiController]
    [Route("[controller]")]
    public class ClothingController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClothingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<Clothing>> GetClothings()
        {
            return _unitOfWork.ClothingRepository.GetAll();
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<ClothingSize>> GetClothingSizes(int clotingId)
        {
            return _unitOfWork.ClothingRepository.GetClothingSizes(clotingId);
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<Clothing>> GetClothingsByBrandId(int brandId)
        {
            return _unitOfWork.ClothingRepository.GetClothingsByBrandId(brandId);
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<IEnumerable<Clothing>> GetClothingsByCategoryId(int categoryId)
        {
            return _unitOfWork.ClothingRepository.GetClothingsByCategoryId(categoryId);
        }
    }
}
