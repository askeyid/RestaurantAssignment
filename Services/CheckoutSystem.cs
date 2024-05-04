namespace RestaurantAssignment.Services
{
    public class CheckoutSystem
    {
        private readonly OrderManager _orderManager;
        private const decimal _serviceCharge = 0.1m;

        public CheckoutSystem(OrderManager orderManager)
        {
            _orderManager = orderManager;
        }

        // Calculating the total bill for the order including service charge
        public decimal CalculateTotalBill()
        {
            decimal totalBill = _orderManager.CalculateTotalBill();
            decimal serviceCharge = totalBill * _serviceCharge;

            totalBill += serviceCharge;

            return totalBill;
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
