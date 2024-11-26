using Lab2.Models;

namespace Lab2.Repositories
{
    public interface IRepository
    {
        IEnumerable<Item> GetItems();
        Item GetItemById(int id);
        void UpdateItem(Item item);
    }
}
