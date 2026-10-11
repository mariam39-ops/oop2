using System;
using System.Collections.Generic;
using System.Text;

namespace AssigmentTwoOop
{
    internal class StandaredShipment:Shipment
    {
        public StandaredShipment(string t,string dec,decimal w,decimal df,DeliveryAddress d) : base(t, dec, w, df, d)
        {

        }

    }
}
