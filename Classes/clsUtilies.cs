using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace POCS
{
    public class clsUtilies
    {
        public clsUtilies()
        {
        }
        // Single-digit and small number names
       public static char[] charsToTrim = { '\r', '\n', ' ' };
        private string[] _smallNumbers = new string[]
    {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
     "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
      "Sixteen", "Seventeen", "Eighteen", "Nineteen"};

        // Tens number names from twenty upwards
        private string[] _tens = new string[]
    {"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty",
     "Ninety"};

        // Scale number names for use during recombination
        private string[] _scaleNumbers = new string[] { "", "Thousand", "Million", "Billion" };
        public static string NumToWords(decimal nNumber)
        {
            string cWords = "";
            decimal nFrac = 0;
            decimal nDigit;
            //decimal nTrillions;
            decimal nRest;
            decimal nBillions;
            decimal nMillions;
            decimal nThousands;
            decimal nHundredsPlace;
            decimal nOnesPlace;
            decimal nTensPlace;
            string cDigitWord;

            if (nNumber < 0)
            {
                cWords = "Negative " + NumToWords(-1 * nNumber);
            }
            else if (nNumber != Convert.ToDecimal(nNumber))
            {
                cWords = NumToWords(Convert.ToDecimal(nNumber));
                cWords = cWords + " and";
                nFrac = nNumber - Convert.ToDecimal(nNumber);
                do
                {
                    nFrac = nFrac * 10;
                    nDigit = Convert.ToDecimal(nFrac);
                    nFrac = nFrac - nDigit;
                    cDigitWord = NumToWords(nDigit);
                    cWords = cWords + " " + cDigitWord;
                } while (nDigit > 0);

            }
            else if (nNumber < 20)
            {
                if (nNumber == 0)
                {
                    cWords = "Zero";
                }
                else if (nNumber == 1)
                {
                    cWords = "One";
                }
                else if (nNumber == 2)
                {
                    cWords = "Two";
                }
                else if (nNumber == 3)
                {
                    cWords = "Three";
                }
                else if (nNumber == 4)
                {
                    cWords = "Four";
                }
                else if (nNumber == 5)
                {
                    cWords = "Five";
                }
                else if (nNumber == 6)
                {
                    cWords = "Six";
                }
                else if (nNumber == 7)
                {
                    cWords = "Seven";
                }
                else if (nNumber == 8)
                {
                    cWords = "Eight";
                }
                else if (nNumber == 9)
                {
                    cWords = "Nine";
                }
                else if (nNumber == 10)
                {
                    cWords = "Ten";
                }
                else if (nNumber == 11)
                {
                    cWords = "Eleven";
                }
                else if (nNumber == 12)
                {
                    cWords = "Twelve";
                }
                else if (nNumber == 13)
                {
                    cWords = "Thirteen";
                }
                else if (nNumber == 14)
                {
                    cWords = "Fourteen";
                }
                else if (nNumber == 15)
                {
                    cWords = "Fifteen";
                }
                else if (nNumber == 16)
                {
                    cWords = "Sixteen";
                }
                else if (nNumber == 17)
                {
                    cWords = "Seventeen";
                }
                else if (nNumber == 18)
                {
                    cWords = "Eighteen";
                }
                else if (nNumber == 19)
                {
                    cWords = "Ninteen";
                }
            }
            else if (nNumber < 100)
            {
                nTensPlace = Convert.ToDecimal(nNumber / 10);
                nOnesPlace = nNumber % 10;
                if (nTensPlace * 10 == 20)
                {
                    cWords = "Twenty";
                }
                else if (nTensPlace * 10 == 30)
                {
                    cWords = "Thirty";
                }
                else if (nTensPlace * 10 == 40)
                {
                    cWords = "Forty";
                }
                else if (nTensPlace * 10 == 50)
                {
                    cWords = "Fifty";
                }
                else if (nTensPlace * 10 == 60)
                {
                    cWords = "Sixty";
                }
                else if (nTensPlace * 10 == 70)
                {
                    cWords = "Seventy";
                }
                else if (nTensPlace * 10 == 80)
                {
                    cWords = "Eighty";
                }
                else if (nTensPlace * 10 == 90)
                {
                    cWords = "Ninty";
                }
                if (nOnesPlace > 0)
                {
                    cWords = cWords + " " + NumToWords(nOnesPlace);
                }
            }
            else if (nNumber < 1000)
            {
                nHundredsPlace = Convert.ToDecimal(nNumber / 100);
                nRest = nNumber % 100;
                cWords = NumToWords(nHundredsPlace);
                cWords = cWords + " Hundred";
                if (nRest > 0)
                {
                    cWords = cWords + " " + NumToWords(nRest);
                }
            }
            else if (nNumber < 1000000)
            {
                nThousands = Convert.ToDecimal(nNumber / 1000);
                nRest = nNumber % 1000;
                cWords = NumToWords(nThousands);
                cWords = cWords + " Thousand";
                if (nRest > 0)
                {
                    cWords = cWords + " " + NumToWords(nRest);
                }
            }
            else if (nNumber < 1000000000)
            {
                nMillions = Convert.ToDecimal(nNumber / 1000000);
                nRest = Convert.ToDecimal(nNumber % 1000000);
                cWords = NumToWords(nMillions);
                cWords = cWords + " Million";
                if (nRest > 0)
                {
                    cWords = cWords + " " + NumToWords(nRest);
                }
            }
            else if (nNumber < 1000000000000)
            {
                nBillions = Convert.ToDecimal(nNumber / 1000000000);
                nRest = Convert.ToDecimal(nNumber % 1000000000);
                cWords = NumToWords(nBillions);
                cWords = cWords + " Billion";
                if (nRest > 0)
                {
                    cWords = cWords + " " + NumToWords(nRest);
                }
            }
            /* else if (nNumber < 1E+15)
             {
                 nTrillions = Convert.ToDecimal(nNumber / 1000000000000);
                 nRest = Convert.ToDecimal(nNumber % 1000000000000);
                 cWords = NumToWords(nTrillions);
                 cWords = cWords + " Trillion";
                 if (nRest > 0)
                 {
                     cWords = cWords + " " + NumToWords(nRest);
                 }
             }
             */
            return cWords;
        }
        // Converts an integer value into English words
      
    }
}
