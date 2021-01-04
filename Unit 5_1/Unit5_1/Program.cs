using System;

namespace Unit5_1 {
    class Program {
        static int Cost(int[] freq, int x, int y) {
            if (y < x)
                return 0;
            if (y == x)
                return freq[x];

            int fsum = total(freq, x, y);
            int min = int.MaxValue;

            for (int r = x; r <= y; ++r) {
                int cost = Cost(freq, x, r - 1) + Cost(freq, r + 1, y);
                if (cost < min)
                    min = cost;
            }
            return min + fsum;
        }

        static int OST(int[] keys, int[] freq, int n) {
            return Cost(freq, 0, n - 1);
        }

        static int total(int[] freq, int i, int j) {
            int s = 0;
            for (int k = i; k <= j; k++)
                s += freq[k];
            return s;
        }
        static void Main(string[] args) {
            int[] keys = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] freq = { 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int n = keys.Length;
            Console.Write("Optimal BST Cost: " + OST(keys, freq, n));
        }
    }
}
