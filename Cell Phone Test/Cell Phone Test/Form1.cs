/** =========================================================
 Name: Omar Ahmad
 Operating System (Windows 10)
 Microsoft Visual Studio 2017
 CIS 169 C# 
M09: CellPhone Tutorial 9-2.
This program manages the company's inventory of cell phones. It allows the user to enter cell phone data into text boxes.
And then click the create object button. it craetes an object of the cell phone class and assign the data from text boxes
to the object's properties then displays the values of the object's properties in model, prices, brand's labels.
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The GetPhoneData method accepts the  acellphone object as an argument.
        // It assigns the data entered by the user to the object's properities.
        private void GetPhoneData(CellPhone phone)
        {
            decimal price;// temporary veraible to hold the price.
            phone.Brand = brandTextBox.Text;// this gets the phon's brand.
            phone.Model = modelTextBox.Text;
            if (decimal.TryParse(priceTextBox.Text, out price))// this gets the phone's price
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("Invalid price");// shows an error message.
            }
        }
        private void createObjectButton_Click(object sender, EventArgs e)// click event handler.
        {
            CellPhone myphone = new CellPhone();// Create a cellphone object.
            GetPhoneData(myphone);// this gets the phone data.
            // Displays the phone data.
            brandLabel.Text = myphone.Brand;
            modelLabel.Text = myphone.Model;
            priceLabel.Text = myphone.Price.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)// click event handler.
        {
            this.Close();// this close the form.
        }
    }
}

        
    
        
    

