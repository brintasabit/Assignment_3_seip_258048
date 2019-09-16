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
        const int size = 5;
        //int index = 0;
        string[] array = new string[size];
        int[] array2 = new int[size];
        public HomeCoffeeShop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            array[0] = customerNameTextBox.Text;
            array[1] = contactNumberTextBox.Text;
            array[2] = AddressTextBox.Text;
            array[3] = orderComboBox.Text;
            array2[0] = Convert.ToInt32(quantityTextBox.Text);
            int totalPrice = 0;
            if (array[3] == "Black")
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
            }
            purchaseInformationRichTextBox.AppendText("\n\nName: " + array[0] + "\nContact: " 
                + array[1] + "\nAddress: " + array[2] + "\nOrder: " + array[3] + "\nQuantity: " 
                + array2[0]+"\nTotal Price " +totalPrice);
            customerNameTextBox.Text = " ";
            contactNumberTextBox.Text = " ";
            AddressTextBox.Text = " ";
            orderComboBox.Text = "Select An Item";
            quantityTextBox.Text = " ";




        }
    }
}
