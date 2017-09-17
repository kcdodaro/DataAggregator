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
            txtAge.Text = null;
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
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(intAmountStudents, cboGender.Text, cboEthnicity.Text, int.Parse(txtAge.Text), cboEco.Text, cboDiplo.Text, cboCivil.Text, cboSocietal.Text, cboOverall.Text, double.Parse(txtEquality.Text), double.Parse(txtNation.Text), double.Parse(txtLiberty.Text), double.Parse(txtTradition.Text), double.Parse(txtMarkets.Text), double.Parse(txtWorld.Text), double.Parse(txtAuthority.Text), double.Parse(txtProgress.Text));
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
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
                dblTemp += lstStudents[i].dblEquality;
            }
            dblAverageStudentEquality = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i].dblNation;
            }
            dblAverageStudentNation = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i].dblLiberty;
            }
            dblAverageStudentLiberty = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i].dblTradition;
            }
            dblAverageStudentTradition = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i].dblMarkets;
            }
            dblAverageStudentMarkets = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i].dblWorld;
            }
            dblAverageStudentWorld = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i].dblAuthority;
            }
            dblAverageStudentAuthority = dblTemp / intAmountStudents;

            dblTemp = 0;
            for (int i = 1; i < intAmountStudents; i++)
            {
                dblTemp += lstStudents[i].dblProgress;
            }
            dblAverageStudentProgress = dblTemp / intAmountStudents;
        }
    }
}
