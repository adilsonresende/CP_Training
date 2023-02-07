using System;
using System.Collections;
using System.Text;

namespace CP_Training.Business
{
    public class ManiputateBits
    {
        public long FlippingBits(long n)
        {
            string bitString = Convert.ToString(n, 2).PadLeft(32, '0');
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 0; i < bitString.Length; i++)
            {
               if(bitString[i] == '0')
                {
                    stringBuilder.Append("1");
                }
                else
                {
                    stringBuilder.Append("0");
                }
            }

            ulong result = Convert.ToUInt64(stringBuilder.ToString(), 2);
            
            return (long)result;
        }
    }
}
