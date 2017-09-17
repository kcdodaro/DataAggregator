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
    }
}
