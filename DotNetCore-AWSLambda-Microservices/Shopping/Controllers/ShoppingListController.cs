using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Model;
using Shopping.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListSvc)
        {
            _shoppingListService = shoppingListSvc;
        }

        [HttpGet]
        public IActionResult GetShoppingList()
        {
            return Ok(_shoppingListService.GetshoppingList());
        }

        [HttpPost]
        public IActionResult addItem([FromBody] ShoppingListViewModel model)
        {
            _shoppingListService.AddItemToShoppingList(model);
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveItem([FromBody] ShoppingListViewModel model)
        {
            _shoppingListService.RemoveItem(model.Name);
            return Ok();
        }
    }
}