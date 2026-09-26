using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigmentoop4
{
    internal class standeredshipment:Shipment
    {
        public standeredshipment(string Trackingcode, string Description, decimal Weight, decimal Delevaryfee, Delevaryadress Destiontion) : base(Trackingcode, Description, Weight, Delevaryfee, Destiontion)
        {

        }
        public override void printshipment()
        {
            Console.WriteLine($"trackingcode{trackingcode},description{description},wieght{weight},delevaryfee{delevaryfee},estimatedcost{estimatedcost}");
        }
    }
}
    

