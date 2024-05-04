namespace RestaurantAssignment.Services
{
    public class OrderManager
    {
        private readonly List<OrderItem> _orderItems;
        private readonly Menu _menu;

        public OrderManager()
        {
            _orderItems = new List<OrderItem>();
            _menu = new Menu();
        }

        // Adding an item to the order
        public void AddItemToOrder(MenuItemType itemType, string orderTime)
        {
            MenuItem menuItem = _menu.GetMenuItems().FirstOrDefault(item => item.Type == itemType);

            if (menuItem == null)
            {
                throw new Exception($"{menuItem} is absent in Menu");
            }

            OrderItem itemToAdd = new(menuItem, orderTime);
            
            _orderItems.Add(itemToAdd);
        }

        // Calculating the total bill for the order
        public decimal CalculateTotalBill()
        {
            decimal totalBill = 0;

            foreach (var item in _orderItems)
            {
                // Assumes Drinks have a 30% discount when ordered before 19:00
                if (item.MenuItem.Type == MenuItemType.Drink && item.OrderTime == "before 19:00")
                {
                    totalBill += item.MenuItem.Price * 0.7m;
                }
                else
                {
                    totalBill += item.MenuItem.Price;
                }
            }

            return totalBill;
        }

        // Removing an item from the order
        public void RemoveItemFromOrder(MenuItemType menuItemType, string orderTime)
        {
            OrderItem orderItem = _orderItems.FirstOrDefault(item => item.MenuItem.Type == menuItemType && item.OrderTime == orderTime);

            if (orderItem == null)
            {
                throw new Exception($"{menuItemType} is absent in Order or was not ordered at pointed time");
            }

            _orderItems.Remove(orderItem);
        }
    }
}
