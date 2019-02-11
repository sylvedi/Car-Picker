using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturePicker
{
    // Sylvanus Edi
    // this is my work
    // 02/10/2019

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            //startes the program with no list.
            InitializeComponent();
            gt.Visible = false;
            ferrari_1971.Visible = false;
            ford_1961.Visible = false;
            ford_69.Visible = false;
            ferrari_1981.Visible = false;
            bmw_1961.Visible = false;
            bmw_1971.Visible = false;
            bmw_1981.Visible = false;
            ford_1971.Visible = false;
            detail_input.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if start is cleck with out inputing details, start program with no response.
            gt.Visible = false;
            ferrari_1971.Visible = false;
            ford_1961.Visible = false;
            ford_69.Visible = false;
            ferrari_1981.Visible = false;
            bmw_1961.Visible = false;
            bmw_1971.Visible = false;
            bmw_1981.Visible = false;
            ford_1971.Visible = false;
            detail_input.Text = "";

            //display selected image and year
            if (car_list.GetSelected(0) && radio_1961.Checked)
            {

                bmw_1961.Visible = true;
            }
           else if  (car_list.GetSelected(1) && radio_1961.Checked)
            {
                ford_1961.Visible = true;
               
            }
            else if (car_list.GetSelected(2) && radio_1961.Checked)
            {
           
                gt.Visible = true;
            }
            else if (car_list.GetSelected(0) && radio_1971.Checked)
            {

                bmw_1971.Visible = true;
            }
            else if (car_list.GetSelected(1) && radio_1971.Checked)
            {

                ford_1971.Visible = true;
            }
            else if (car_list.GetSelected(2) && radio_1971.Checked)
            {

                ferrari_1971.Visible = true;
            }
            else if (car_list.GetSelected(0) && radio_1981.Checked)
            {

                bmw_1981.Visible = true;
            }
            else if (car_list.GetSelected(1) && radio_1981.Checked)
            {

                ford_69.Visible = true;
            }
            else if (car_list.GetSelected(2) && radio_1981.Checked)
            {

                ferrari_1981.Visible = true;
            }
            //display picture, year, and name
            if (car_list.GetSelected(0) && radio_1961.Checked && car_name.Checked)
            {
                detail_input.Text = "BMW 1500\n";
            }
            else if (car_list.GetSelected(0) && radio_1971.Checked && car_name.Checked)
            {
                detail_input.Text = "BMW 30\n";
            }
            else if (car_list.GetSelected(0) && radio_1981.Checked && car_name.Checked)
            {
                detail_input.Text = "BMW M1\n";
            }
            else if (car_list.GetSelected(1) && radio_1961.Checked && car_name.Checked)
            {
                detail_input.Text = "Ford Galaxy sunliner\n";
            }
            else if (car_list.GetSelected(1) && radio_1971.Checked && car_name.Checked)
            {
                detail_input.Text = "Ford Mustang\n";
            }
            else if (car_list.GetSelected(1) && radio_1981.Checked && car_name.Checked)
            {
                detail_input.Text = "Ford Thunderbird\n";
            }
            else if (car_list.GetSelected(2) && radio_1961.Checked && car_name.Checked)
            {
                detail_input.Text = "Ferrari 250GT Berlinetta Lusso\n";
            }
            else if (car_list.GetSelected(2) && radio_1971.Checked && car_name.Checked)
            {
                detail_input.Text = "Ferrari 365 GTB/4\n";
            }
            else if (car_list.GetSelected(2) && radio_1981.Checked && car_name.Checked)
            {
                detail_input.Text = "Ferrari 308\n";
            }
            //display picture, year, name, and manufactured date.
            if (car_list.GetSelected(0) && radio_1961.Checked && car_name.Checked && car_year.Checked)
            {
                detail_input.Text += "Manufactured in 1961";
            }
            else if (car_list.GetSelected(0) && radio_1971.Checked && car_name.Checked && car_year.Checked)
            {
                detail_input.Text += "Manufactured in 1971";
            }
            else if (car_list.GetSelected(0) && radio_1981.Checked && car_name.Checked && car_year.Checked)
            {
                detail_input.Text += "Manufactured in 1981";
            }
            else if (car_list.GetSelected(1) && radio_1961.Checked && car_name.Checked && car_year.Checked)
            {
                detail_input.Text += "Manufactured in 1961";
            }
            else if (car_list.GetSelected(1) && radio_1971.Checked && car_name.Checked && car_year.Checked)
            {
                detail_input.Text += "Manufactured in 1971";
            }
            else if (car_list.GetSelected(1) && radio_1981.Checked && car_name.Checked && car_year.Checked)
            {
                detail_input.Text += "Manufactured in 1981";
            }
            else if (car_list.GetSelected(2) && radio_1961.Checked && car_name.Checked && car_year.Checked)
            {
                detail_input.Text += "Manufactured in 1961";
            }
            else if (car_list.GetSelected(2) && radio_1971.Checked && car_name.Checked && car_year.Checked)
            {
                detail_input.Text += "Manufactured in 1971";
            }
            else if (car_list.GetSelected(2) && radio_1981.Checked && car_name.Checked && car_year.Checked)
            {
                detail_input.Text += "FManufactured in 1981";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset program.
            gt.Visible = false;
            ferrari_1971.Visible = false;
            ford_1961.Visible = false;
            ford_69.Visible = false;
            ferrari_1981.Visible = false;
            bmw_1961.Visible = false;
            bmw_1971.Visible = false;
            bmw_1981.Visible = false;
            ford_1971.Visible = false;
            detail_input.Text = "";
        }
    }
}
