using Shopping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetshoppingList();

        void AddItemToShoppingList(ShoppingListViewModel model);
        void RemoveItem(string name);
    }
}
