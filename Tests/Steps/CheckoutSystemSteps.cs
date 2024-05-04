using RestaurantAssignment.Services;

namespace RestaurantAssignment.Tests.Steps
{
    [Binding]
    public class CheckoutSystemSteps
    {
        private readonly CheckoutSystem _checkoutSystem;
        private decimal _totalBill;

        public CheckoutSystemSteps()
        {
            _checkoutSystem = new CheckoutSystem(new OrderManager());
        }

        [When(@"Order (\d+) starters?, (\d+) mains? and (\d+) drinks? ?(before 19:00|)?")]
        public void WhenOrderStartersMainsAndDrinks(int startersCount, int mainsCount, int drinksCount, string orderTime = "")
        {
            for (int i = 0; i < startersCount; i++)
            {
                _checkoutSystem.AddItemToOrder(MenuItemType.Starter, orderTime);
            }

            for (int i = 0; i < mainsCount; i++)
            {
                _checkoutSystem.AddItemToOrder(MenuItemType.Main, orderTime);
            }

            for (int i = 0; i < drinksCount; i++)
            {
                _checkoutSystem.AddItemToOrder(MenuItemType.Drink, orderTime);
            }

            _totalBill = _checkoutSystem.CalculateTotalBill();
        }

        [Then(@"The endpoint returns a correctly calculated bill of (\d+\.\d+)")]
        public void ThenEndpointReturnsCorrectlyCalculatedBill(decimal totalBill)
        {
            // Assuming total bill calculation logic is correct
            _totalBill.Should().Be(totalBill);
        }

        [When(@"Cancel (.*) starters?, (.*) mains? and (.*) drinks? ?(before 19:00|)?")]
        public void WhenCancelStartersMainsAndDrinks(int startersCount, int mainsCount, int drinksCount, string orderTime = "")
        {
            for (int i = 0; i < startersCount; i++)
            {
                _checkoutSystem.RemoveItemFromOrder(MenuItemType.Starter, orderTime);
            }

            for (int i = 0; i < mainsCount; i++)
            {
                _checkoutSystem.RemoveItemFromOrder(MenuItemType.Main, orderTime);
            }

            for (int i = 0; i < drinksCount; i++)
            {
                _checkoutSystem.RemoveItemFromOrder(MenuItemType.Drink, orderTime);
            }

            _totalBill = _checkoutSystem.CalculateTotalBill();
        }
    }
}
