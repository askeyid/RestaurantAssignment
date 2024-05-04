namespace RestaurantAssignment.Services
{
    // Assumes a fixed set of menu item types
    public enum MenuItemType
    {
        Starter,
        Main,
        Drink
    }

    public class MenuItem
    {
        public MenuItemType Type { get; }
        public MenuItemType Name { get; }
        public decimal Price { get; }

        public MenuItem(MenuItemType name, decimal price)
        {
            Type = name;
            Name = name;
            Price = price;
        }
    }
}
