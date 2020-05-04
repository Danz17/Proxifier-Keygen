using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxifierKeygen
{
    public class Keygen
    {
        static uint CompileString(string str)
        {
            uint result = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result *= 32;
                int c = str[i];
                if (c == 'W')
                {
                    continue;
                }
                if (c == 'X')
                {
                    result += 24;
                }
                else if (c == 'Y')
                {
                    result += 1;
                }
                else if (c == 'Z')
                {
                    result += 18;
                }
                else if (c <= 57) // '0' to '9'
                {
                    result += (uint)c - 48;
                }
                else // 'A' to 'V'
                {
                    result += (uint)c - 55;
                }
            }
            return result;
        }

        static string DecompileString(uint value, int length)
        {
            string result = null;
            for (int i = 0; i < length; i++)
            {
                uint tmp = value % 32;
                value /= 32;

                if (tmp == 0)
                {
                    result += 'W';
                }
                else if (tmp == 24)
                {
                    result += 'X';
                }
                else if (tmp == 1)
                {
                    result += 'Y';
                }
                else if (tmp == 18)
                {
                    result += 'Z';
                }
                else if (tmp <= 9)
                {
                    result += (char)(tmp + 48);
                }
                else
                {
                    result += (char)(tmp + 55);
                }
            }
            return result;
        }

        static int CRC32LikeThingy(byte[] data)
        {
            int result = -1;
            for (int i = 0; i < 12; i++)
            {
                result ^= data[i] << 24;
                for (int j = 0; j < 8; j++)
                {
                    if (result < 0)
                    {
                        result <<= 1;
                        result ^= 0x4C11DB7;
                    }
                    else
                    {
                        result <<= 1;
                    }
                }
            }
            return result;
        }

        internal static string GenerateKey(int product = 0, string fourthKeyPart = null, int expirationDate = 0)
        {
            string charset = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random rnd = new Random();
            int param1 = rnd.Next(0x2580, 0xFFFF) /* < 0x2580 ==> outdated key message */ + (product << 21);
            int param2 = rnd.Next(0xFFFF) + (expirationDate << 16) /* 0 ==> no expiration */;
            if (fourthKeyPart == null)
                for (int i = 0; i < 5; i++)
                    fourthKeyPart += charset[rnd.Next((charset.Length - 1))];
            int param3 = (int)CompileString(fourthKeyPart);
            byte[] data = new byte[12];
            Buffer.BlockCopy(new int[] { param1, param2, param3 }, 0, data, 0, data.Length);
            var value1 = CRC32LikeThingy(data) & 0x1FFFFFF;
            var value2 = value1 ^ (value1 << 7);
            var value3 = param1 ^ value2 ^ 0x12345678;
            var value4 = param2 ^ value2 ^ 0x87654321;
            string key = DecompileString((uint)value3, 7);
            key += DecompileString((uint)value4, 7);
            key += key[2]; // 15th char becomes 3rd
            key += fourthKeyPart;
            key += DecompileString((uint)value1, 5);
            // 3rd char doesn't affect the key check, as long as it's not a 'Y' ==> Proxifier v2 key (outdated)
            char rndChar = charset[rnd.Next((charset.Length - 1))];
            if (rndChar == 'Y')
                rndChar++;
            key.Remove(2);
            key.Insert(2, rndChar.ToString());
            key = key.Insert(20, "-").Insert(15, "-").Insert(10, "-").Insert(5, "-");
            return key;
        }
    }
}
