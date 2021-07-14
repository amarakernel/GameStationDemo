using System;
using System.Collections.Generic;
using System.Text;

namespace GameStationDemo.Entities
{
    class Campaign
    {
        public int CampaignNo { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }
        public double OriginalPrice { get; set; }
        public double getNewPriceAfterDiscount()
        {
            return this.OriginalPrice - (this.OriginalPrice * this.DiscountRate / 100);
        }
    }
}
