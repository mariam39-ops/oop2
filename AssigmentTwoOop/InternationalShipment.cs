using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentTwoOop
{
    internal class InternationalShipment:Shipment
    {
        private string destinationCountry;
        private decimal customsFee;
        public InternationalShipment(string t, string de, decimal W, decimal df ,DeliveryAddress d,string desCoun,decimal Custom) : base(t, de, W, df, d) 
        {
            DestinationCountry = desCoun;
            CustomsFee = Custom;

        }
         public  string DestinationCountry{
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;

                }
            }
            get
            {
                return destinationCountry;
            }
        }
        public override decimal EstimatedCost
        { 
            get{ return base.EstimatedCost + CustomsFee;}
          
        }
        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }

    }
}
