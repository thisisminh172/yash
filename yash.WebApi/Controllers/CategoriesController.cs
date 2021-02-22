using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yash.Application.Catalog.Categories;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Categories;

namespace yash.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.GetAll();
            return Ok(categories);
        }
        [HttpGet("{CategoryId}")]
        public async  Task<IActionResult> GetCategory(int CategoryId)
        {
            var category = await _categoryService.GetById(CategoryId);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryCreateRequest newCategory)
        {
            var categoryId = await _categoryService.Create(newCategory);

            return Ok(categoryId);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryUpdateRequest updateCagory)
        {
            var result = await _categoryService.Update(updateCagory);
            return Ok(result);
        }
        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            var result = await _categoryService.Delete(categoryId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
