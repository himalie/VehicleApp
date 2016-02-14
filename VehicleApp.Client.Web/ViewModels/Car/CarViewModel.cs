using VehicleApp.Domain.Models;

namespace VehicleApp.Client.Web.ViewModels.Car
{
    public class CarViewModel
    {
        #region Constants 
        private const string DriveAwayPrice = "Drive Away Price";
        private const string PriceExcludingGovermentCharges = "Price Excluding Government Charges";
        private const string PriceOnAsking = "Price On Asking";
        private const string SellerTypePrivate = "Private Seller";
        private const string SellerTypeDealer = "Dealer";
        #endregion

        #region Model Properties
        // We don't use UI to save cars, 
        // so I don't apply Model Validations here. :)
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public CarPriceType PriceType { get; set; }
        public decimal Price { get; set; }

        public string Email { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string ABN { get; set; }

        #endregion

        #region Calculated properties
        public string PriceTypeLabel
        {
            get
            {
                switch(PriceType)
                {
                    case CarPriceType.DriveAwayPrice:
                        return DriveAwayPrice;
                    case CarPriceType.ExcludingGovernmentCharges:
                        return PriceExcludingGovermentCharges;
                    case CarPriceType.PriceOnAsking:
                        return PriceOnAsking;
                    default:
                        return string.Empty;
                }
            }
        }

        public string SellerTypeLabel
        {
            get
            {
                if (IsPrivateSeller)
                    return SellerTypePrivate;
                else
                    return SellerTypeDealer;
            }
        }

        public bool IsPrivateSeller
        {
            get
            {
                return string.IsNullOrEmpty(ABN);
            }
        }
        #endregion
    }
}