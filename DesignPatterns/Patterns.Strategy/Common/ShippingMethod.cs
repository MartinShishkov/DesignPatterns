namespace Patterns.Strategy.Common
{
    public enum ShippingMethod
    {
        // These were the shipping companies
        // that the business initially worked with
        FedEx,
        Ups,
        Speedy,

        // The business has decided to add a 
        // new shipping method to their logic!
        Dhl
    }
}