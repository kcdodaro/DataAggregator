using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAggregation
{
    class Student
    {
        //Demographics
        public string strGender { get; set; }
        public string strEthnicity { get; set; }

        //Classifiers
        public int intAge { get; set; }
        public int strEco { get; set; }
        public int strDiplo { get; set; }
        public int strCivil { get; set; }
        public int strSocietal { get; set; }

        //Values
        public int intEquality { get; set; }
        public int intNation { get; set; }
        public int intLiberty { get; set; }
        public int intTradition { get; set; }
        public int intMarkets { get; set; }
        public int intWorld { get; set; }
        public int intAuthority { get; set; }
        public int intProgress { get; set; }

        //Constructors
        public Student()
        {

        }
    }
}
