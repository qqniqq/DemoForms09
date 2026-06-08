namespace DemoLib.Helpers
{
    public static class ProductHelper
    {
        public static decimal GetFinalPrice(
            decimal price,
            decimal discount)
        {
            return price -
                (price * discount / 100);
        }
    }
}