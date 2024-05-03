namespace RestaurantAssignment.Services
{
    public class OrderManager
    {
        private List<MenuItem> _orderItems;

        public OrderManager()
        {
            _orderItems = new List<MenuItem>();
        }

        // Adding an item to the order.
        public void AddItemToOrder(MenuItemType itemType, Menu menu)
        {
            MenuItem itemToAdd = menu.GetMenuItems().FirstOrDefault(item => item.Type == itemType);

            if (itemToAdd != null)
            {
                _orderItems.Add(itemToAdd);
            }
            else
            {
                throw new Exception($"{itemType} is absent in Menu");
            }
        }

        // Calculating the total bill for the order.
        public decimal CalculateTotalBill()
        {
            decimal totalBill = 0;

            foreach (var item in _orderItems)
            {
                totalBill += item.Price;
            }

            return totalBill;
        }
    }
}
