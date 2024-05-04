namespace RestaurantAssignment.Services
{
    public class OrderItem
    {
        public MenuItem MenuItem { get; }
        public string OrderTime { get; }

        public OrderItem(MenuItem menuItem, string orderTime)
        {
            MenuItem = menuItem;
            OrderTime = orderTime;
        }
    }
}
