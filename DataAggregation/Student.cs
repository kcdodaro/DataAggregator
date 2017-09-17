using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAggregation
{
    class Student
    {
        public int intID { get; set; }

        //Demographics
        public string strGender { get; set; }
        public string strEthnicity { get; set; }
        public int intAge { get; set; }

        //Classifiers
        public string strEco { get; set; }
        public string strDiplo { get; set; }
        public string strCivil { get; set; }
        public string strSocietal { get; set; }
        public string strOverall { get; set; }

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
        public Student() { }
        public Student(string gender, string ethnicity, int age, string eco, string diplo, string civil, string societal, string overall, int equality, int nation, int liberty, int tradition, int markets, int world, int authority, int progress)
        {
            //demographics
            strGender = gender;
            strEthnicity = ethnicity;
            intAge = age;
            //classifiers
            strEco = eco;
            strDiplo = diplo;
            strCivil = civil;
            strSocietal = societal;
            strOverall = overall;
            //values
            intEquality = equality;
            intNation = nation;
            intLiberty = liberty;
            intTradition = tradition;
            intMarkets = markets;
            intWorld = world;
            intAuthority = authority;
            intProgress = progress;
        }
    }
}
