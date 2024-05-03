﻿namespace RestaurantAssignment.Source
{
    public class Menu
    {
        private List<MenuItem> _items;
        private const decimal starterPrice = 4.00m;
        private const decimal mainPrice = 7.00m;
        private const decimal drinkPrice = 2.50m;

        public Menu()
        {
            _items = new List<MenuItem>();
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            _items.Add(new MenuItem(MenuItemType.Starter, starterPrice));
            _items.Add(new MenuItem(MenuItemType.Main, mainPrice));
            _items.Add(new MenuItem(MenuItemType.Drink, drinkPrice));
        }

        public List<MenuItem> GetMenuItems()
        {
            return _items;
        }
    }
}