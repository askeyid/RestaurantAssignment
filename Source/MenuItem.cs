namespace RestaurantAssignment.Source
{
    public enum MenuItemType
    {
        Starter,
        Main,
        Drink
    }

    public class MenuItem
    {
        public MenuItemType Name { get; }
        public decimal Price { get; }

        public MenuItem(MenuItemType name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
