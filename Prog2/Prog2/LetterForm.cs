// Program 2
// CIS 200-01
// Fall 2017
// Due: 10/23/2017
// By: C5503

// File: LetterForm.cs
// This form is used to insert the origin address and destination address of a letter 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class LetterForm : Form
    {
        List<Address> addresses = new List<Address>();       
        
        ErrorProvider errorProvider1 = new ErrorProvider(); // Created errorprovider to be used for validation of LetterForm inputs

        public LetterForm()
        {
            InitializeComponent();
        }

        //Preconditions:None
        //Postconditions:LetterForm is loaded and addresses are added
        private void LetterForm_Load(object sender, EventArgs e)
        {
            foreach (Address address in addresses)
                cbOriginAddress.Items.Add(address.Name);

            foreach (Address address in addresses)
                cbDestinationAddress.Items.Add(address.Name);
        }

        //Preconditions: Origin address must be selected from combobox
        //Postconditions: Origin address is returned
        public int OriginAddress
        {
            get
            {
                return cbOriginAddress.SelectedIndex;
            }
        }

        //Preconditions: Destination address must be selected from combobox
        //Postconditions: Destination address is returned
        public int DestinationAddress
        {
            get
            {
                return cbDestinationAddress.SelectedIndex;
            }
        }

        

        //Preconditions: None
        //Postconditions: Origin address combobox is tested for proper validation
        private void CbOriginAddress_Validating(object sender, CancelEventArgs e)
        {
            if (cbOriginAddress.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(cbOriginAddress, "Origin Address must be selected");
            }
        }
        //Preconditions: origin address must be selected
        //Postconditions: After validation, error will not show
        private void CbOriginAddress_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbOriginAddress, "");
        }

        //Preconditions: None
        //Postconditions: Destination address combobox is tested for proper validation
        private void CbDestinationAddress_Validating(object sender, CancelEventArgs e)
        {
            if (cbDestinationAddress.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(cbDestinationAddress, "Destination Address must be selected");
            }
        }
        //Preconditions: origin address must be selected
        //Postconditions: After validation, error will not show
        private void CbDestinationAddress_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbDestinationAddress, "");
        }

        //Preconditions: OK button needs to be pressed
        //Postconditions: All input is validated on button press
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
        //Preconditions: Cancel button needs to be pressed
        //Postconditions: LetterForm closes
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
