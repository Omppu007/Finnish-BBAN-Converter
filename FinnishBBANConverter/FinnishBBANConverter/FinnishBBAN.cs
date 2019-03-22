using System;

namespace FinnishBBANConverter
{
    class FinnishBBAN
    {
        // Correct short format validation
        public bool IsShortFormat(string shortFormat)
        {
            // Setting variables
            bool isShortFormat = false;
            int inputLength = 0;
            int firstPart = 0;  // e.g. 123456
            int secondPart = 0; // e.g. 785
            int secondPartLength = 0;
            bool isNumeric1 = false;
            bool isNumeric2 = false;

            inputLength = shortFormat.Length;

            // Verifies input length
            if (inputLength >= 9)
            {
                // TryParsing
                isNumeric1 = int.TryParse(shortFormat.Substring(0, 6), out firstPart);
                isNumeric2 = int.TryParse(shortFormat.Substring(7), out secondPart);
                secondPartLength = shortFormat.Substring(7).Length;

                // Verifies inputed number
                if (isNumeric1 == true && isNumeric2 == true && shortFormat[6] == '-' && firstPart >= 100000 && secondPartLength >= 2)
                {
                    isShortFormat = true;
                }
            }

            return isShortFormat;
        }

        // Get long format
        public long GetLongFormat(string shortFormat)
        {
            // Setting variables
            string newString = "";
            long longFormat = 0;    // e.g. 12345600000785, 42345670000081

            // Verifies the correct format
            if (IsShortFormat(shortFormat))
            {
                // Checks the bank and converts the short format account number into long format

                if (shortFormat[0] == '4' || shortFormat[0] == '5') // Savings banks, POPs and Aktia, Credit unions, OKO and Okopankki
                {
                    newString = shortFormat.Substring(0, 6) + shortFormat[7] + shortFormat.Substring(8).PadLeft(7, '0');
                    longFormat = Convert.ToInt64(newString);    // Needs to be 64 bit integer otherwise overflow error
                }
                else // Other banks
                {
                    newString = shortFormat.Substring(0, 6) + shortFormat.Substring(7).PadLeft(8, '0');
                    longFormat = Convert.ToInt64(newString);    // Needs to be 64 bit integer otherwise overflow error
                }
            }

            return longFormat;
        }

        // Get inputted checksum
        public int GetInputChecksum(string shortFormat)
        {
            // Setting variables
            int inputChecksum = 0;

            // Verifies the correct format and returns the last number aka inputted checksum
            if (IsShortFormat(shortFormat))
            {
                inputChecksum = Convert.ToInt32(shortFormat.Substring(shortFormat.Length - 1));
            }

            return inputChecksum;
        }

        // Get calculated checksum
        public int GetCalculatedChecksum(string shortFormat)
        {
            // Setting variables
            int calculatedChecksum = 0;
            string longFormat = "";
            int[] arr1 = new int[13];
            int[] longFormatArray = new int[13];
            int sum = 0;
            int roundUp = 0;

            // Verifies correct format
            if (IsShortFormat(shortFormat))
            {
                // Getting Long Format and cast it into an array
                longFormat = GetLongFormat(shortFormat).ToString();

                // Long Format string to array
                for (int i = 0; i < 13; i++)
                {
                    long tempLong = Convert.ToInt64(longFormat[i].ToString());
                    int tempInt = (int)tempLong;
                    longFormatArray[i] = tempInt;
                }

                // Calculating sum
                for (int i = 0; i < 13; i++)
                {
                    // Even digits
                    if (i % 2 != 0 && i != 0)
                    {
                        arr1[i] = longFormatArray[i];
                    }
                    // Odd digits
                    else
                    {
                        int tempInt = longFormatArray[i] * 2;
                        if (tempInt >= 10) // Two digit number
                        {
                            string tempString = tempInt.ToString();
                            arr1[i] = Convert.ToInt32(tempString[0].ToString()) + Convert.ToInt32(tempString[1].ToString());
                        }
                        else // Single digit number
                        {
                            arr1[i] = tempInt;
                        }

                    }

                    sum = sum + arr1[i]; // Adds number to sum
                }

                roundUp = (int)Math.Ceiling((decimal)sum / 10) * 10; // Create a round up number to nearest 10 from the sum

                calculatedChecksum = roundUp - sum; // Checksum
            }

            return calculatedChecksum;
        }

        // Verifies inputted checksum to calculated one
        public bool IsChecksum(string shortFormat)
        {
            // Setting variables
            bool isChecksum = false;

            // Verifies correct format
            if (IsShortFormat(shortFormat))
            {
                // Getting inputed and calculated checksums
                int inputChecksum = GetInputChecksum(shortFormat);
                int calculatedChecksum = GetCalculatedChecksum(shortFormat);

                // Compares the inputed last number to the calculated checksum
                if (inputChecksum == calculatedChecksum)
                {
                    isChecksum = true;
                }
            }

            return isChecksum;
        }
    }
}
