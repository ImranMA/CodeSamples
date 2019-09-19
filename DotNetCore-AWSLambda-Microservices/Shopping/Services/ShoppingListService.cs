using Shopping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly Dictionary<string, int> _shoppingListStorage = 
            new Dictionary<string, int>();

        public Dictionary<string, int> GetshoppingList() {
            return _shoppingListStorage;
        }

        public void AddItemToShoppingList(ShoppingListViewModel model)
        {
            _shoppingListStorage.Add(model.Name, model.Qty);
        }

        public void RemoveItem(string name)
        {
            _shoppingListStorage.Remove(name);
        }
    }
}
