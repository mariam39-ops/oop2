using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentTwoOop
{
    internal class ExpressShipment:Shipment
    {
      //part1 q2
        private decimal extrafee { get; set; }
        public ExpressShipment(string t,string d ,decimal w,decimal de,DeliveryAddress del,decimal Exr):base(t,d,w,de,del)
        {
            Extrafee = extrafee;
        }
        public decimal Extrafee
        {
            set
            {
                if (value >= 0)
                {
                    extrafee = value;
                }
            }
            get
            {
                return extrafee;
            }
        }public override decimal EstimatedCost
        {
         
           
            get
            {
                return base.EstimatedCost+Extrafee;
            }
            



        }
    }
}
