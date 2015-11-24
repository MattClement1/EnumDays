/*
* Created by: Matthew Clement
* Created on: 23-Nov-2015
* Created for: Unit #6-01
* This program uses an enum type to return the selected value
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

namespace EnumDays
{
    public partial class frmEnumDays : Form
    {
        enum DAYS
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public frmEnumDays()
        {
            InitializeComponent();
        }

        private void frmEnumDays_Load(object sender, EventArgs e)
        {

            foreach (DAYS singlePlanet in Enum.GetValues(typeof(DAYS)))
            {
                this.lstDays.Items.Add(singlePlanet);
            }

        }

        private void lstDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue;
            DAYS selectedDay;

            selectedValue = Convert.ToString(this.lstDays.SelectedItem);
            selectedDay = (DAYS)Enum.Parse(typeof(DAYS), selectedValue, true);
            MessageBox.Show("The current day is: " + selectedDay + ".");
        }
    }
}
