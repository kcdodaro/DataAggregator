using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAggregation
{
    public class Output
    {
        //averages
        public double dblEqualityAverage { get; set; }
        public double dblNationAverage { get; set; }
        public double dblLibertyAverage { get; set; }
        public double dblTraditionAverage { get; set; }
        public double dblMarketsAverage { get; set; }
        public double dblWorldAverage { get; set; }
        public double dblAuthorityAverage { get; set; }
        public double dblProgressAverage { get; set; }

        //extremes
        public double dblEqualityExtreme { get; set; }
        public double dblNationExtreme { get; set; }
        public double dblLibertyExtreme { get; set; }
        public double dblTraditionExtreme { get; set; }
        public double dblMarketsExtreme { get; set; }
        public double dblWorldExtreme { get; set; }
        public double dblAuthorityExtreme { get; set; }
        public double dblProgressExtreme { get; set; }

        //constructors
        public Output() { }

        public Output(double equalityAverage, double nationAverage, double libertyAverage, double traditionAverage, double marketsAverage, double worldAverage, double authorityAverage, double progressAverage, double equalityExtreme, double nationExtreme, double libertyExtreme, double traditionExtreme, double marketsExtreme, double worldExtreme, double authorityExtreme, double progressExtreme)
        {
            dblEqualityAverage = equalityAverage;
            dblNationAverage = nationAverage;
            dblLibertyAverage = libertyAverage;
            dblTraditionAverage = traditionAverage;
            dblMarketsAverage = marketsAverage;
            dblWorldAverage = worldAverage;
            dblAuthorityAverage = authorityAverage;
            dblProgressAverage = progressAverage;

            dblEqualityExtreme = equalityExtreme;
            dblNationExtreme = nationExtreme;
            dblLibertyExtreme = libertyExtreme;
            dblTraditionExtreme = traditionExtreme;
            dblMarketsExtreme = marketsExtreme;
            dblWorldExtreme = worldExtreme;
            dblAuthorityExtreme = authorityExtreme;
            dblProgressExtreme = progressExtreme;
        }
    }
}
