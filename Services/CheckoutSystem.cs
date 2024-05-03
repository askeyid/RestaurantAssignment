namespace RestaurantAssignment.Services
{
    public class CheckoutSystem
    {
        private Menu _menu;
        private OrderManager _orderManager;

        public CheckoutSystem(Menu menu, OrderManager orderManager)
        {
            _menu = menu;
            _orderManager = orderManager;
        }

        // Calculating the total bill for the order.
        public decimal CalculateTotalBill()
        {
            return _orderManager.CalculateTotalBill();
        }

        // Adding an item to the order.
        public void AddItemToOrder(MenuItemType itemType)
        {
            _orderManager.AddItemToOrder(itemType, _menu);
        }
    }
}
