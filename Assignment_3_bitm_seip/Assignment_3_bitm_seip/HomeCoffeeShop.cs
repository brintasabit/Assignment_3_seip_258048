using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3_bitm_seip
{
    public partial class HomeCoffeeShop : Form
    {
        const int size = 10;
        int index = 0;
        //  string[] array = new string[size];
        //string[] array2 = new string[size];
        string[] customerName = new string[size];
        string[] contactNumber = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];

        int[] quantity = new int[size];
        public HomeCoffeeShop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int totalPrice=0;
            /*array[0] = customerNameTextBox.Text;
            array[1] = contactNumberTextBox.Text;
            array[2] = AddressTextBox.Text;
            array[3] = orderComboBox.Text;
            array2[0] = Convert.ToInt32(quantityTextBox.Text);*/
            if (size>index)
            {
                customerName[index] = customerNameTextBox.Text;
                contactNumber[index] = contactNumberTextBox.Text;
                address[index] = AddressTextBox.Text;
                order[index] = orderComboBox.Text;
                quantity[index] = Convert.ToInt32(quantityTextBox.Text);
                //index++;
            }
            
            if (order[index] == "Black")
            {
                totalPrice = quantity[index] * 120;
            }
            else if (order[index] == "Cold")
            {
                totalPrice = quantity[index] * 100;
            }
            else if (order[index] == "Hot")
            {
                totalPrice = quantity[index] * 90;
            }
            else if (order[index] == "Regular")
            {
                totalPrice = quantity[index] * 80;
            }
            /* if (array[3] == "Black")
             {
                  totalPrice = array2[0] * 120;
             }
             else if (array[3] == "Cold")
             {
                 totalPrice = array2[0] * 100;
             }
             else if (array[3] == "Hot")
             {
                 totalPrice = array2[0] * 90;
             }
             else if (array[3] == "Regular")
             {
                 totalPrice = array2[0] * 80;
             }
             else
             {
                 MessageBox.Show("Please Select An Item");
             }*/
            
                purchaseInformationRichTextBox.AppendText("\n\nName: " + customerName[index]
                    + "\nContact: " + contactNumber[index] + "\nAddress: " + address[index]
                    + "\nOrder: " + order[index] + "\nQuantity: " + quantity[index]
                    + "\nTotal Price " + totalPrice);
            
            customerNameTextBox.Text = " ";
            contactNumberTextBox.Text = " ";
            AddressTextBox.Text = " ";
            orderComboBox.Text = "Select An Item";
            quantityTextBox.Text = " ";




        }

        
    }
}
