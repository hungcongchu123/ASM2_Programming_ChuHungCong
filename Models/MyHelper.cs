using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterBill.Models
{
    public static class MyHelper
    {
        // Hash 256
        public static string Hash256(string input)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        // Sort Array Descending
        public static int[] SortArrayDescending(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            return arr;
        }
    }
}