using ClothingShopApi.Abstract.Interfaces;
using ClothingShopApi.Abstract.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClothingShopApi.Web
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController: ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            return _unitOfWork.CategoryRepository.GetAll();
        }
    }
}
