using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Lector_Bascula
{
    public class ConvertEPC
    {
        public string epc = String.Empty;
        public String Epc
        {
            set
            {
                this.epc = value;
            }
            get
            {
                return this.epc;
            }
        }

        public ConvertEPC()
        {
        }

        public ConvertEPC(String epc)
        {
            this.epc = epc;
        }

        private String checkDigit(String upc)
        {
            string[] digits = upc.Select(c => c.ToString()).ToArray();
            int sum1 = 0;
            int sum3 = 0;
            int cnt = 1;
            for (int i = 0; i < digits.Length; i++)
            {
                if (cnt % 2 != 0)
                {
                    sum3 += Int16.Parse(digits[i]);
                }
                else
                {
                    sum1 += Int16.Parse(digits[i]);
                }
                cnt++;
            }
            double sum = sum1 + (sum3 * 3);
            //decimal nextHighest = Math.Round(sum / 10, MidpointRounding.AwayFromZero) * 10;
            double nextHighest = Math.Ceiling(sum / 10) * 10;
            return upc + (nextHighest - sum).ToString();
        }

        public String getUpc()
        {
            String bin = String.Empty;
            String hexstring = this.epc;
            if (hexstring.Length == 24)
            {
                bin = String.Join(String.Empty, hexstring.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')).ToArray<string>());
                String header = bin.Substring(0, 8);
                String filter = bin.Substring(8, 3);//String filter = bin.Substring(Filter.Init, Filter.End);
                String partition = bin.Substring(11, 3);
                String companyPrefix = bin.Substring(14, 24);
                String itemReferenceNumber = bin.Substring(38, 20);
                String serialNumber = bin.Substring(58, 38);

                String companyPrefixDec = Convert.ToInt64((companyPrefix), 2).ToString();
                String itemReferenceNumberDec = Convert.ToInt64((itemReferenceNumber), 2).ToString();

                String upc = companyPrefixDec + itemReferenceNumberDec;
                upc = this.checkDigit(upc);
                return upc;
            }
            else
            {
                return "Invalid EPC";
            }
        }

        public String getNewEPC(int headerDec, int filterDec, int partitionDec, string upc, int sequence)
        {
            string epc = String.Empty;
            string partialupc = upc.Substring(0, 11);

            if (checkDigit(partialupc) != upc)
                return "Invalid UPC";

            var companyPrefixDec = Convert.ToInt64(partialupc.Substring(0, 6));
            var itemReferenceNumberDec = Convert.ToInt64(partialupc.Substring(6, 5));

            String companyPrefix = Convert.ToString(companyPrefixDec, 2).PadLeft(24, '0');
            String itemReferenceNumber = Convert.ToString(itemReferenceNumberDec, 2).PadLeft(20, '0');
            String serialNumber = Convert.ToString(sequence, 2).PadLeft(38, '0');
            String header = Convert.ToString(headerDec, 2).PadLeft(8, '0');
            String filter = Convert.ToString(filterDec, 2).PadLeft(3, '0');
            String partition = Convert.ToString(partitionDec, 2).PadLeft(3, '0');
            //"00000000000000000000000000000000001011"
            epc = BinaryStringToHexString("00110000001101" + companyPrefix + itemReferenceNumber + serialNumber);


            return epc;
        }
        public static string BinaryStringToHexString(string binary)
        {
            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            // TODO: check all 1's or 0's... Will throw otherwise

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                // pad to length multiple of 8
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }
    }
}