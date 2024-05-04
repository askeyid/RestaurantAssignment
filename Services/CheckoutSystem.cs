namespace RestaurantAssignment.Services
{
    public class CheckoutSystem
    {
        private OrderManager _orderManager;

        public CheckoutSystem(OrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        // Calculating the total bill for the order
        public decimal CalculateTotalBill()
        {
            return _orderManager.CalculateTotalBill();
        }

        // Adding an item to the order
        public void AddItemToOrder(MenuItemType itemType, string orderTime)
        {
            _orderManager.AddItemToOrder(itemType, orderTime);
        }

        // Removing an item from the order
        public void RemoveItemFromOrder(MenuItemType menuItemType, string orderTime)
        {

            _orderManager.RemoveItemFromOrder(menuItemType, orderTime);
        }
    }
}
