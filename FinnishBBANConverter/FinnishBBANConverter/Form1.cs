using System;
using System.Windows.Forms;

namespace FinnishBBANConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Conversion button
        private void buttonConvert1_Click(object sender, EventArgs e)
        {
            // Setting variables
            string convertedNumber = "";
            string calculatedChecksum = "";
            bool isShortFormat = false;
            bool isChecksum = false;
            FinnishBBAN sourceAccountNumber = new FinnishBBAN();

            // Validating correct format for the input
            isShortFormat = sourceAccountNumber.IsShortFormat(textBoxInput1.Text);

            if (isShortFormat == true)
            {
                // Get converted and calculated numbers
                convertedNumber = sourceAccountNumber.GetLongFormat(textBoxInput1.Text).ToString();
                calculatedChecksum = sourceAccountNumber.GetCalculatedChecksum(textBoxInput1.Text).ToString();
                isChecksum = sourceAccountNumber.IsChecksum(textBoxInput1.Text);

                // Change textbox values
                textBoxResponse1.Text = convertedNumber;
                textBoxCheck1.Text = calculatedChecksum;
                if (isChecksum == true)
                {
                    textBoxChecksumValidity1.Text = "Valid checksum";
                }
                else
                {
                    textBoxChecksumValidity1.Text = "Invalid checksum";
                }
            }
            else // Invalid input
            {
                textBoxResponse1.Text = "Invalid input";
                textBoxCheck1.Text = "";
                textBoxChecksumValidity1.Text = "";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelVersion.Text = Application.ProductVersion;
        }
    }
}
