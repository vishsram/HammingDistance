using System;

namespace HammingDistance
{
    static class Program
    {
        public static int FindHammingDistance (String str1, String str2) {
            if (String.IsNullOrEmpty(str1) && String.IsNullOrEmpty(str2)) {
                return 0;
            }

            if (String.IsNullOrEmpty(str1)) {
                return str2.Length;
            }

            if (String.IsNullOrEmpty(str2)) {
                return str1.Length;
            }

            if (str2.Length != str1.Length) {
                throw new ArgumentException("The strings must be of equal length.");
            }

            int hammingDistance = 0;
            for (int i = 0; i < str1.Length; i++) {
                if (str1[i] != str2[i]) {
                    hammingDistance++;
                }
            }

            return hammingDistance;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int hammingDistance = Program.FindHammingDistance("10011", "10100");
            Console.WriteLine(hammingDistance);
        }
    }
}
