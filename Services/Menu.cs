namespace RestaurantAssignment.Services
{
    public class Menu
    {
        private readonly List<MenuItem> _items;

        // Assumes fixed prices for menu items
        private const decimal _starterPrice = 4.00m;
        private const decimal _mainPrice = 7.00m;
        private const decimal _drinkPrice = 2.50m;

        public Menu()
        {
            _items = new List<MenuItem>();
            InitializeMenu();
        }

        // Assumes a predetermined set of menu items: starters, mains, and drinks
        private void InitializeMenu()
        {
            _items.Add(new MenuItem(MenuItemType.Starter, _starterPrice));
            _items.Add(new MenuItem(MenuItemType.Main, _mainPrice));
            _items.Add(new MenuItem(MenuItemType.Drink, _drinkPrice));
        }

        public List<MenuItem> GetMenuItems()
        {
            return _items;
        }
    }
}
