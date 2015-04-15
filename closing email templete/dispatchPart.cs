using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace closing_email_templete
{
    public partial class dispatchPart : Form
    {
        public dispatchPart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string displayMessage = "*** Disp Notification - CRU Parts Only ***\n\nOrder Part #: " + txtPartNumber.Text + "\nQuantity: " + txtQuantity.Text + "\nDefective SN: " + txtSerialNumber.Text + "\n\nDELIVER TO CUSTOMER ADDRESS BELOW:\n\nShip to Customer Name: " + txtCustomerName.Text + "\nShip to Street Address: " + txtAddress.Text + "\nCity: " + txtCity.Text + "\nState: " + txtState.Text + "\nZip: " + txtZip.Text + " \nCountry: " + txtCountry.Text + "\n\nCustomer/Attention To Contact Name: " + txtCustomerName.Text + "\nCustomer/Attention To Contact Phone: " + txtPhoneNumber.Text + "\nContact email : " + txtEmail.Text + "\nPriority (NBD / ASAP or 4 hours): " + txtPriority.Text;

            Clipboard.SetText(displayMessage);

            MessageBox.Show("Copied template to clip board\n\n" + displayMessage);

            txtPartNumber.Text = " ";
            txtCustomerName.Text = " ";
            txtAddress.Text = " ";
            txtCity.Text = " ";
            txtCountry.Text = " ";
            txtEmail.Text = " ";
            txtPhoneNumber.Text = " ";
            txtPriority.Text = " ";
            txtQuantity.Text = " ";
            txtSerialNumber.Text = " ";
            txtState.Text = " ";
            txtZip.Text = " ";
           


        }
    }
}
