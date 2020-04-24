using Econtact.econtactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econtact
{
    public partial class Econtact : Form
    {
        public Econtact()
        {
            InitializeComponent();
        }

        ContactClass c = new ContactClass();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from input fields
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.ContactNo = textBoxContactNumber.Text;
            c.Address = textBoxAddress.Text;
            c.Gender = cmbGender.Text;

            //Inserting data into database using the method (contactClass)
            bool success = c.Insert(c);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("New contact Successfully inserted");
            }
            else
            {
                //Failed to add contact
                MessageBox.Show("Failed to add New contact, Try Again.");

            }
        }
    }
}
