/*
 * Property of Kyle Dodaro
 * Date of creation: September 17, 2017
 * Open sourced, but do not distribute without permission
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace DataAggregation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //globals
        List<Student> lstStudents = new List<Student>();
        int intAmountStudents = 0;

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            intAmountStudents++;
            //demographics
            cboEthnicity.Text = null;
            cboGender.Text = null;

            //classifiers
            cboEco.Text = null;
            cboDiplo.Text = null;
            cboCivil.Text = null;
            cboSocietal.Text = null;
            cboOverall.Text = null;

            //values
            txtEquality.Text = null;
            txtNation.Text = null;
            txtLiberty.Text = null;
            txtTradition.Text = null;
            txtMarkets.Text = null;
            txtWorld.Text = null;
            txtAuthority.Text = null;
            txtProgress.Text = null;

            lblStudent.Text = "Student: " + intAmountStudents;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(intAmountStudents, cboGender.Text, cboEthnicity.Text, cboEco.Text, cboDiplo.Text, cboCivil.Text, cboSocietal.Text, cboOverall.Text, double.Parse(txtEquality.Text), double.Parse(txtNation.Text), double.Parse(txtLiberty.Text), double.Parse(txtTradition.Text), double.Parse(txtMarkets.Text), double.Parse(txtWorld.Text), double.Parse(txtAuthority.Text), double.Parse(txtProgress.Text));
            lstStudents.Add(newStudent);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            #region Averages
            double dblAverageStudentEquality = 0;
            double dblAverageStudentNation = 0;
            double dblAverageStudentLiberty = 0;
            double dblAverageStudentTradition = 0;
            double dblAverageStudentMarkets = 0;
            double dblAverageStudentWorld = 0;
            double dblAverageStudentAuthority = 0;
            double dblAverageStudentProgress = 0;

            double dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i - 1].dblEquality;
            }
            dblAverageStudentEquality = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i - 1].dblNation;
            }
            dblAverageStudentNation = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i - 1].dblLiberty;
            }
            dblAverageStudentLiberty = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i - 1].dblTradition;
            }
            dblAverageStudentTradition = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i - 1].dblMarkets;
            }
            dblAverageStudentMarkets = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i - 1].dblWorld;
            }
            dblAverageStudentWorld = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i - 1].dblAuthority;
            }
            dblAverageStudentAuthority = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i - 1].dblProgress;
            }
            dblAverageStudentProgress = dblTemp / intAmountStudents;
            #endregion

            #region Extremes
            List<double> lstEquality = new List<double>();
            double dblEqualityExtreme = 0;
            for (int i = 0; i < lstStudents.Count; i++)
            {
                lstEquality.Add(lstStudents[i].dblEquality);
            }
            lstEquality.Sort();
            dblEqualityExtreme = lstEquality[lstEquality.Count - 1];

            List<double> lstNation = new List<double>();
            double dblNationExtreme = 0;
            for (int i = 0; i < lstStudents.Count; i++)
            {
                lstNation.Add(lstStudents[i].dblNation);
            }
            lstNation.Sort();
            dblNationExtreme = lstNation[lstNation.Count - 1];

            List<double> lstLiberty = new List<double>();
            double dblLibertyExtreme = 0;
            for (int i = 0; i < lstStudents.Count; i++)
            {
                lstLiberty.Add(lstStudents[i].dblLiberty);
            }
            lstLiberty.Sort();
            dblLibertyExtreme = lstLiberty[lstLiberty.Count - 1];

            List<double> lstTradition = new List<double>();
            double dblTraditionExtreme = 0;
            for (int i = 0; i < lstStudents.Count; i++)
            {
                lstTradition.Add(lstStudents[i].dblTradition);
            }
            lstTradition.Sort();
            dblTraditionExtreme = lstTradition[lstTradition.Count - 1];

            List<double> lstMarkets = new List<double>();
            double dblMarketsExtreme = 0;
            for (int i = 0; i < lstStudents.Count; i++)
            {
                lstMarkets.Add(lstStudents[i].dblMarkets);
            }
            lstMarkets.Sort();
            dblMarketsExtreme = lstMarkets[lstMarkets.Count - 1];

            List<double> lstWorld = new List<double>();
            double dblWorldExtreme = 0;
            for (int i = 0; i < lstStudents.Count; i++)
            {
                lstWorld.Add(lstStudents[i].dblWorld);
            }
            lstWorld.Sort();
            dblWorldExtreme = lstWorld[lstWorld.Count - 1];

            List<double> lstAuthority = new List<double>();
            double dblAuthorityExtreme = 0;
            for (int i = 0; i < lstStudents.Count; i++)
            {
                lstAuthority.Add(lstStudents[i].dblAuthority);
            }
            lstAuthority.Sort();
            dblAuthorityExtreme = lstAuthority[lstAuthority.Count - 1];

            List<double> lstProgress = new List<double>();
            double dblProgressExtreme = 0;
            for (int i = 0; i < lstStudents.Count; i++)
            {
                lstProgress.Add(lstStudents[i].dblProgress);
            }
            lstProgress.Sort();
            dblProgressExtreme = lstProgress[lstProgress.Count - 1];

            #endregion

            #region Outputs
            string strOutput = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "//dataAggregate.xml";
            Output output = new Output(dblAverageStudentEquality, dblAverageStudentNation, dblAverageStudentLiberty, dblAverageStudentTradition, dblAverageStudentMarkets, dblAverageStudentWorld, dblAverageStudentAuthority, dblAverageStudentProgress, dblEqualityExtreme, dblNationExtreme, dblLibertyExtreme, dblTraditionExtreme, dblMarketsExtreme, dblWorldExtreme, dblAuthorityExtreme, dblProgressExtreme);

            XmlSerializer sz = new XmlSerializer(typeof(Output));
            using (TextWriter tw = new StreamWriter(strOutput))
            {
                sz.Serialize(tw, output);
            }

            for(int i = 0; i < lstStudents.Count; i++)
            {
                string strOutput2 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "//Ouput//" + lstStudents[i].intID + ".xml";

                XmlSerializer sz2 = new XmlSerializer(typeof(Student));
                using (TextWriter tw = new StreamWriter(strOutput2))
                {
                    sz2.Serialize(tw, lstStudents[i]);
                }
            }
            #endregion
        }
    }
}
