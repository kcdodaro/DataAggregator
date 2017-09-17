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
        public double dblEquality { get; set; }
        public double dblNation { get; set; }
        public double dblLiberty { get; set; }
        public double dblTradition { get; set; }
        public double dblMarkets { get; set; }
        public double dblWorld { get; set; }
        public double dblAuthority { get; set; }
        public double dblProgress { get; set; }

        //Constructors
        public Student() { }
        public Student(int id, string gender, string ethnicity, int age, string eco, string diplo, string civil, string societal, string overall, double equality, double nation, double liberty, double tradition, double markets, double world, double authority, double progress)
        {
            intID = id;

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
            dblEquality = equality;
            dblNation = nation;
            dblLiberty = liberty;
            dblTradition = tradition;
            dblMarkets = markets;
            dblWorld = world;
            dblAuthority = authority;
            dblProgress = progress;
        }
    }
}
