//C8045
//Cis-200-01
//Due date: 11/1/2016
//LetterForm is a modal dialogbox that creates new Letter parcels
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

    public partial class LetterForm : Form
    {
        //local address list field
        private List<Address> aList;      
                              
        //Precondition: a List of Addresses
        //Postcondition: The Letterform is initialized with a List of Addresses loaded
        public LetterForm(List<Address> letters)
        {
            InitializeComponent();
            aList=letters;                                      //transfering the list from Prog2Form
        }

        //Precondition: None
        //Postcondition: The letterform comboboxes are populated with items from the List of Addresses
        private void LetterForm_Load(object sender, EventArgs e)
        {
            //foreach loop that populates the comboboxes with names from the List of Addresses
            foreach (Address a in aList)
            {
                originComboBox1.Items.Add(a.Name);             
                destinationComboBox2.Items.Add(a.Name);        
            }

        }
        //Property that stores the originComboBox1 selected index value
        internal int FromAddress
        {
            //Precondition: originComboBox1 selection made
            //Postcondition: The index of the selected address is returned
            get { return originComboBox1.SelectedIndex; }
            //Precondition: originComboBox1 selection made
            //Postcondition: The index of the selected address is set to specified value
            set { value = originComboBox1.SelectedIndex; }
        }
        //Precondition: Attempting to change focus from originComboBox1
        //Postcondition: If originComboBox1 has a valid index, focus will change,
        //  else focus will remain and error provider message set
        private void FromAddress_Validating(object sender, CancelEventArgs e)
        {
            if (originComboBox1.SelectedIndex == -1)                                    //if statement that determines the combobox activity
            {
                e.Cancel = true;                                                        //Cancels the focus change
                errorProvider1.SetError(originComboBox1, "Select an Address!");         //Displays the Error Provider
            }
        }
        //Precondition: FromAddress_Validating succeeded
        //Postcondition: Any error message set for originCombobox1 is cleared
        //  Focus is allowed to change
        private void FromAddress_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(originComboBox1, "");                               //Clears the Error Provider
        }


        //Property that stores the destination address's index number
        internal int ToAddress
        {
            //Precondition: destinationComboBox2 selection made
            //Postcondition: The index of the selected address is returned
            get { return destinationComboBox2.SelectedIndex; }
            //Precondition: destinationComboBox2 selection made
            //Postcondition: The index of the selected address is set to specified value
            set { value = destinationComboBox2.SelectedIndex; }
        }
        //Precondition: Attempting to change focus from destinationComboBox2
        //Postcondition: If destinationComboBox2 has a valid index and it's not the same selection as 
        //  originComboBox1, focus will change, else focus will remain and error provider message set
        private void ToAddress_Validating(object sender, CancelEventArgs e)
        {
            if (destinationComboBox2.SelectedIndex == -1 || destinationComboBox2.SelectedIndex == originComboBox1.SelectedIndex)  //if statement that determines the combobox activity
            {
                e.Cancel = true;                                                                //Cancels the focus change
                errorProvider1.SetError(destinationComboBox2, "Select a unique Address!");      //Displays the Error Provider
            }
        }
        //Precondition: ToAddress_Validating succeeded
        //Postcondition: Any error message set for destinationComboBox2 is cleared
        //  Focus is allowed to change
        private void ToAddress_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(destinationComboBox2, "");                                  //Clears the Error Provider
        }


        //Property that stores the costTextBox1 value
        internal decimal NewCost
        {
            //Precondition: None
            //Postcondition: The text of the costTextBox1 is returned
            get { return decimal.Parse(costTextBox1.Text); }
            //Precondition: None
            //Postcondition: The text of the costTextBox1 is set to specified value
            set { value = decimal.Parse(costTextBox1.Text); }
        }
        //Precondition: Attempting to change focus from costTextBox1
        //Postcondition: If a value is entered and it's a valid decimal, focus will change,
        //  else focus will remain and error provider message set 
        private void NewCost_Validating(object sender, CancelEventArgs e)
        {
            decimal number;                                                                                     //value entered into costTextBox1

            if (costTextBox1.Text == string.Empty || !decimal.TryParse(costTextBox1.Text, out number))          //if statement that determines if the value will be stored in number
            {
                e.Cancel = true;
                errorProvider1.SetError(costTextBox1, "Must enter a number!");
                costTextBox1.SelectAll();                                                                       //selects the contents of the textbox
            }
            else
            {
                if (number < 0)                                                                                  //if statement that determines if the number is nonnegative
                    e.Cancel = true;
                errorProvider1.SetError(costTextBox1, "Enter a positive number!");
                costTextBox1.SelectAll();
            }
        }
        //Precondition: NewCost_Validating succeeded
        //Postcondition: Any error message set for costTextBox1 is cleared
        //  Focus is allowed to change
        private void NewCost_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(costTextBox1, "");                                          //Clears the Error Provider
        }

        //Precondition: okButton2 activated
        //Postcondition: If all controls on form validate, LetterForm is dismissed with OK result
        private void okButton2_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())                                                    //validates all controls
                this.DialogResult = DialogResult.OK;
        }

        //Precondition: cancelButton2 activated
        //Postcondition: LetterForm is dismissed with Cancel result
        private void cancelButton2_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
    
}
