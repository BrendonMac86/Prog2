//C8045
//Cis-200-01
//Due date: 11/1/2016
//AddressForm is a modal dialogbox that creates new Address objects
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class AddressForm : Form
    {
        //Precondition: None
        //Postcondition: The AddressForm is initialized
        public AddressForm()
        {
            InitializeComponent();
        }

        //Property that stores the nameTextBox1 text value
        internal string NewName
        {
            //Precondition: None
            //Postcondition: The text of nameTextBox1 is returned
            get { return nameTextBox1.Text; }
            //Precondition: None
            //Postcondition: The text of nameTextBox1 is set to specified value
            set { nameTextBox1.Text = value; }
        }
        //Precondition: Attempting to change focus from nameTextBox1
        //Postcondition: If a value is entered and it's a valid int, focus will change,
        //  else focus will remain and error provider message set 
        private void NewName_Validating(object sender, CancelEventArgs e)
        {
            int number;                                                                                 //stores the value for number

            if (nameTextBox1.Text == string.Empty || int.TryParse(nameTextBox1.Text, out number))       //if statement that determines if the value will be stored in number
            {
                e.Cancel = true;                                                                        //Cancels the focus change
                errorProvider1.SetError(nameTextBox1, "Enter a valid name!");                           //displays the Error Provider
                nameTextBox1.SelectAll();                                                               //selects the contents of the textbox
            }
         }
        //Precondition: NewName_Validating succeeded
        //Postcondition: Any error message set for nameTextBox1 is cleared
        //  Focus is allowed to change
        private void NewName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTextBox1, "");                                                  //clears the Error Provider
        }

        //Property that stores the addressTextBox1 text value
        internal string NewAddress1
        {
            //Precondition: None
            //Postcondition: The text of addressTextBox1 is returned
            get { return addressTextBox1.Text; }
            //Precondition: None
            //Postcondition: The text of addressTextBox1 is set to specified value
            set { addressTextBox1.Text = value; }
        }
        //Precondition: Attempting to change focus from addressTextBox1
        //Postcondition: If a value is entered, focus will change, else
        //  focus will remain and error provider message set 
        private void NewAddress1_Validating(object sender, CancelEventArgs e)
        {
            if (addressTextBox1.Text == string.Empty)                                           //if statement that determines if there is a value
            {
                e.Cancel = true;                                                                //Cancels the focus change
                errorProvider1.SetError(addressTextBox1, "Enter an address!");                  //displays the Error Provider
                addressTextBox1.SelectAll();                                                    //selects the contents of the textbox
            }
        }
        //Precondition: NewAddress1_Validating succeeded
        //Postcondition: Any error message set for addressTextBox1 is cleared
        //  Focus is allowed to change
        private void NewAddress1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(addressTextBox1, "");                                       //clears the Error Provider
        }

        //Property that stores the addressTextBox2 text value
        internal string NewAddress2
        {
            get { return addressTextBox2.Text; }
            set { addressTextBox2.Text = value; }
        }

        //Property that stores the cityTextBox1 text value
        internal string NewCity
        {
            //Precondition: None
            //Postcondition: The text of cityTextBox1 is returned
            get { return cityTextBox1.Text; }
            //Precondition: None
            //Postcondition: The text of cityTextBox1 is set to specified value
            set { cityTextBox1.Text = value; }
        }
        //Precondition: Attempting to change focus from cityTextBox1
        //Postcondition: If a value is entered and it's a valid int, focus will change, 
        //  else focus will remain and error provider message set 
        private void NewCity_Validating(object sender, CancelEventArgs e)
        {
            int number;                                                                                     //stores the value for number

            if (cityTextBox1.Text == string.Empty || int.TryParse(cityTextBox1.Text, out number))           //if statement that determines if the value will be stored in number
            {
                e.Cancel = true;                                                                            //Cancels the focus change
                errorProvider1.SetError(cityTextBox1, "Enter a valid City!");                               //displays the Error Provider
                cityTextBox1.SelectAll();                                                                   //selects the contents of the textbox
            }
        }
        //Precondition: NewCity_Validating succeeded
        //Postcondition: Any error message set for cityTextBox1 is cleared
        //  Focus is allowed to change
        private void NewCity_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cityTextBox1, "");                                                      //clears the Error Provider
        }

        //Property that stores the stateComboBox1 text value
        internal string NewState
        {
            //Precondition: stateComboBox1 selection made
            //Postcondition: The text of stateComboBox1 is returned
            get { return stateComboBox1.Text; }
            //Precondition: stateComboBox1 selection made
            //Postcondition: The text of stateComboBox1 is set to specified value
            set { stateComboBox1.Text = value; }
        }
        //Precondition: Attempting to change focus from stateComboBox1
        //Postcondition: If stateComboBox1 has a valid index, focus will change, 
        //  else focus will remain and error provider message set 
        private void NewState_Validating(object sender, CancelEventArgs e)
        {
            if (stateComboBox1.SelectedIndex==-1)                                           //if statment that determines the combobox activity
            {
                e.Cancel = true;                                                            //Cancels the focus change
                errorProvider1.SetError(stateComboBox1, "Select a State!");                 //displays the Error Provider
            }
        }
        //Precondition: NewState_Validating succeeded
        //Postcondition: Any error message set for stateComboBox1 is cleared
        //  Focus is allowed to change
        private void NewState_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(stateComboBox1, "");                                    //clears the Error Provider
        }
        
        //Property that stores the zipTextBox1 text as an int
        internal int NewZip
        {
            //Precondition: None
            //Postcondition: The text of the zipTextBox1 is returned as an int
            get { return int.Parse(zipTextBox1.Text); }
            //Precondition: None
            //Postcondition: The text, as an int, of zipTextBox1 is set to specified value
            set { value = int.Parse(zipTextBox1.Text); }
        }
        //Precondition: Attempting to change focus from zipTextBox1
        //Postcondition: If a value is entered and it's a valid int, focus will change,
        //  else focus will remain and error provider message set 
        private void NewZip_Validating(object sender, CancelEventArgs e)
        {
            int number;                                                                                     //stores the value for number

            if (zipTextBox1.Text == string.Empty || !int.TryParse(zipTextBox1.Text, out number))            //if statement that determines if the value will be stored in number
            {
                e.Cancel = true;                                                                            //Cancels the focus change
                errorProvider1.SetError(zipTextBox1, "Must enter a Zip!");                                  //displays the Error Provider
                zipTextBox1.SelectAll();                                                                    //selects the contents of the textbox
            }
            else
            {
                if (number < 0 || number > 99999)                                                           //if statement that determines if the value is within constraints
                    e.Cancel = true;                                                                        //Cancels the focus change
                errorProvider1.SetError(zipTextBox1, "Enter a valid Zip!");                                 //displays the Error Provider
                zipTextBox1.SelectAll();                                                                    //selects the contents of the textbox
            }
        }
        //Precondition: NewZip_Validating succeeded
        //Postcondition: Any error message set for zipTextBox1 is cleared
        //  Focus is allowed to change
        private void NewZip_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(zipTextBox1, "");                                                       //clears the Error Provider
        }

        //Precondition: okButton1 activated
        //Postcondition: If all controls on form validate, AddressForm is dismissed with OK result
        private void okButton1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())                                                    //validates all controls
                this.DialogResult = DialogResult.OK;
        }

        //Precondition: cancelButton1 activated
        //Postcondition: AddressForm is dismissed with Cancel result
        private void cancelButton1_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            
        }
    }
}
