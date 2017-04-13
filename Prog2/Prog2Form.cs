//C8045
//Cis-200-01
//Due date: 11/1/2016
//Prog2form acts as a user interface for interacting with the Parcel system by allowing
//  addresses to be added to an address list, letters to a parcel list, and displaying
//  the data within the gui itself.
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
    public partial class Prog2Form : Form
    {
        UserParcelView testa = new UserParcelView();            //UPV object
        
        //Precondition: None
        //Postcondition: The Prog2Form is initialized with test data
        public Prog2Form()
        {            
            InitializeComponent();
            testa.AddAddress("John Jacob", "112 Oakland Ave", "", "Louisville", "KY", 40204);
            testa.AddAddress("Jingle Hymersmith", "555 Rhinehard Ln", "Apt. 9", "Aville", "WV", 12345);
            testa.AddAddress("Aberdee Z", "12 Baxter", "Unit 100", "Aplace", "NY", 67895);
            testa.AddAddress("Aye Person", "Pirate Cove", "", "Dangertown", "CA", 55555);
            testa.AddAddress("Luke Elwalker", "Rebelscum St", "", "Dagoba", "VA", 22553);
            testa.AddAddress("Grown Man", "2234 Hisown Pl", "Apt. 9 3/4", "Avillage", "KY", 05551);
            testa.AddLetter(testa.AddressAt(0), testa.AddressAt(1), 12.95M);
            testa.AddLetter(testa.AddressAt(2), testa.AddressAt(3), 2.99M);
            testa.AddLetter(testa.AddressAt(4), testa.AddressAt(5), 55.98M);
            testa.AddGroundPackage(testa.AddressAt(2), testa.AddressAt(3), 12, 23, 12, 100);
            testa.AddNextDayAirPackage(testa.AddressAt(4), testa.AddressAt(2), 19, 23, 5, 23, 22.01M);
        }

        //Precondition: Insert, Address menu item activated
        //Postcondition: Displays the AddressForm and passes desired Address data into the affiliated UPV addresses list
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            DialogResult result = addressForm.ShowDialog();         //Pulls the dialog result

               //Variables assigned to the AddressForm properties
               string newName = addressForm.NewName;                
               string newAddress1 = addressForm.NewAddress1;
               string newAddress2 = addressForm.NewAddress2;
               string newCity = addressForm.NewCity;
               string newState = addressForm.NewState;
               int newZip = addressForm.NewZip;
            
            //If statement that takes the inputs made on the AddressForm
            //  and passes it to the UPV AddAddress method
            if (result == DialogResult.OK)
            {
                testa.AddAddress(newName, newAddress1, newAddress2, newCity, newState, newZip);
            }
           
        }

        //Precondition: File, Exit menu item activated
        //Postcondition: Prog2 form closes
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Precondition: File, About menu item activated
        //Postcondition: A message box displays with pertinent data
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Brendon McNamara\nProject 2\nCis-200-01");
        }

        //Precondition: Insert, Letter menu item activated
        //Postcondition: Displays the LetterForm and passes the desired origin/destination Addresses into the affiliated UPV parcels list
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm(testa.AddressList);

            DialogResult result = letterForm.ShowDialog();          //Pulls the dialog result
            decimal fixedCost = letterForm.NewCost;                 //Variable for the fixed cost
            
            //If statement that takes the inputs made on the LetterForm
            //  and passes it to the UPV AddLetter method
            if (result==DialogResult.OK)
            {
                testa.AddLetter(testa.AddressAt(letterForm.FromAddress), testa.AddressAt(letterForm.ToAddress), fixedCost);
            }

        }

        //Precondition: Report, List Addresses menu item activated
        //Postcondition: The current addresses stored for the user are displayed
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guiTextBox1.Clear();                                    //Clears the textbox
            guiTextBox1.Show();                                     //Shows the fresh textbox

            //Foreach loop that displays each address in the AddressList
            foreach (Address a in testa.AddressList)
             guiTextBox1.Text += a.ToString()+"\r\n\r\n";
        }

        //Precondition: Report, List Parcels menu item activated
        //Postcondition: The current parcels stored for the user are displayed, as well as the total cost for all shipments
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guiTextBox1.Clear();
            guiTextBox1.Show();

            StringBuilder parcelList = new StringBuilder("---Current Parcels---");  //String builder that holds the ParcelList results
            string NL = Environment.NewLine;                                        //Newline  
            decimal grandTotal = 0;                                                 //Running total of costs

            foreach (Parcel p in testa.ParcelList)
                grandTotal += p.CalcCost();                                         //Loop for Total Cost
            foreach (Parcel p in testa.ParcelList)
                parcelList.AppendLine(NL + p.ToString());                           //Loop for Parcels list

            parcelList.AppendLine(NL+$"Total Cost: {grandTotal:C}");                //Adding Total Cost to the end of the report
            guiTextBox1.Text = parcelList.ToString();                               //Passing the string builder object to the textbox

        }

    }
}
