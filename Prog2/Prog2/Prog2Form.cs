// Program 2
// CIS 200-01
// Fall 2017
// Due: 10/23/2017
// By: C5503

// File: Prog2Form.cs
// This form is the bulk of the application, which is operated by using the menu toolbar at the top of the form, and is used to input information about shipping.
using Prog2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv; // Declare upv variable to be used on shipping

        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView(); // upv assigned as userparcelview method

            upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                 "  Louisville   ", "  KY   ", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210); // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            upv.AddAddress("John Doe", "111 Market St.",
                "Jeffersonville", "IN", 47130); // Test Address 5
            upv.AddAddress("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",
                "Los Angeles", "CA", 90212); // Test Address 6
            upv.AddAddress("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",
                "Bethesda", "MD", 20810); // Test Address 7
            upv.AddAddress("Vlad Dracula", "6543 Vampire Way", "Apt. 1",
                "Bloodsucker City", "TN", 37210); // Test Address 8

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 3.95M);  // Add letter using upv
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(3), 4.25M); // Add letter using upv
            upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(5), 14, 10, 5, 12.5); // Add groundpackage using upv
            upv.AddGroundPackage(upv.AddressAt(6), upv.AddressAt(7), 8.5, 9.5, 6.5, 2.5); // Add groundpackage using upv
            upv.AddNextDayAirPackage(upv.AddressAt(0), upv.AddressAt(2), 25, 15, 15, 85, 7.50M); // Add nextdayairpackage using upv
            upv.AddNextDayAirPackage(upv.AddressAt(2), upv.AddressAt(4), 9.5, 6.0, 5.5, 5.25, 5.25M); // Add nextdayairpackage using upv
            upv.AddNextDayAirPackage(upv.AddressAt(1), upv.AddressAt(6), 10.5, 6.5, 9.5, 15.5, 5.00M); // Add nextdayairpackage using upv
            upv.AddTwoDayAirPackage(upv.AddressAt(4), upv.AddressAt(6), 46.5, 39.5, 28.0, 80.5, TwoDayAirPackage.Delivery.Saver); // Add twodayairpackage using upv
            upv.AddTwoDayAirPackage(upv.AddressAt(7), upv.AddressAt(0), 15.0, 9.5, 6.5, 75.5, TwoDayAirPackage.Delivery.Early); // Add twodayairpackage using upv
            upv.AddTwoDayAirPackage(upv.AddressAt(5), upv.AddressAt(3), 12.0, 12.0, 6.0, 5.5, TwoDayAirPackage.Delivery.Saver); // Add twodayairpackage using upv

        }

        List<Address> addresses = new List<Address>();    // List of test address

        List<Parcel> parcels = new List<Parcel>();         // List of test parcels


        //Preconditions: About menu button must be clicked
        //Postconditions: MessageBox appears with assignment information
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grading ID: C5503" + Environment.NewLine + "CIS 200-01" + Environment.NewLine +
                "Program 2" + Environment.NewLine + "Due: 10/23/2017");
        }

        //Preconditions: Exit menu must be clicked
        //Postconditions: The application is closed
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Preconditions: Address menu button must be clicked
        //Postconditions: AddressForm appears for data input
        private void AddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();

            DialogResult addressResult;
           
            addressResult = addressForm.ShowDialog();
        }

        //Preconditions: Letter menu button must be clicked
        //Postconditions: LetterForm appears for data input
        private void LetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm();

            DialogResult letterResult;

            letterResult = letterForm.ShowDialog();
        }

        //Preconditions: The List Address menu button must be clicked
        //Postconditions: List of addresses is displayed in the primary text box
        private void ListAddressToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            
            foreach (Address address in addresses)
            {
                result.Append(address.ToString());
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
            }

            primaryTextBox.Text = result.ToString();

            
        }
        //Preconditions: The List Parcels menu button must be clicked
        //Postconditions: List of parcels is displayed in the primary text box
        private void ListParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            foreach (Parcel parcel in parcels)
            {
                result.Append(parcel.ToString());
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);
            }

            primaryTextBox.Text = result.ToString();


        }
    }
}
