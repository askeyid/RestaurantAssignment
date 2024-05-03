namespace RestaurantAssignment.Services
{
    // Assumes a fixed set of menu item types: starter, main, and drink.
    public enum MenuItemType
    {
        Starter,
        Main,
        Drink
    }

    public class MenuItem
    {
        // Assumes each menu item has a name and price.
        public MenuItemType Name { get; }
        public decimal Price { get; }

        public MenuItem(MenuItemType name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
