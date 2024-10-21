using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:Find Missing Numbers in Array");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:Sort Array by Parity");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:Two Sum");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:Find Maximum Product of Three Numbers");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:Decimal to Binary Conversion");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:Find Minimum in Rotated Sorted Array");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:Palindrome Number");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:Fibonacci Number");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Write your code here
                // Get the length of the array
                int len = nums.Length;
                // Initialize list to store the missing numbers
                List<int> missingNumbers = new List<int>();
                for (int i = 1; i <= len; i++)
                {
                    // If current number is not found in the input array, add to missing no list
                    if (!nums.Contains(i))
                    {
                        missingNumbers.Add(i);
                    }
                    else
                        continue;
                }
                return missingNumbers;  // Return the list of missing numbers
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                int left = 0; // Pointer to place even numbers
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0) // If the current number is even
                    {
                        // Swap the even number to the left index
                        int temp = nums[left];
                        nums[left] = nums[i];
                        nums[i] = temp;
                        left++; // Move the left pointer to the next position
                    }
                }
                return nums; // Return array sorted by parity
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Write your code here
                // Get the length of the input array
                int len = nums.Length;
                // List to store result
                List<int> res = new List<int>();
                for (int i = 0; i < len - 1; i++)
                {
                    for (int j = 1; j < len; j++)
                    {
                        // Check if the sum of nums[i] and nums[j] equals the target
                        if (nums[i] + nums[j] == target)
                        {
                            res.Add(i);
                            res.Add(j);
                        }
                    }
                }
                // Return the result as an array
                return res.ToArray();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Sort the array
                Array.Sort(nums);
                int n = nums.Length;
                // Max product of the three largest numbers
                int product1 = nums[n - 1] * nums[n - 2] * nums[n - 3];
                // max product of two smallest numbers
                int product2 = nums[0] * nums[1] * nums[n - 1];
                // Return the larger of the two product
                return Math.Max(product1, product2);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                if (decimalNumber == 0)
                {
                    // Special case for 0
                    return "0";
                }

                string binary = "";
                while (decimalNumber > 0)
                {
                    int rem = decimalNumber % 2;  // Get remainder (either 0 or 1)
                    binary = rem + binary;  // Add remainder to the front of the string
                    decimalNumber = decimalNumber / 2;  // Divide the number by 2
                }
                // Return the resulting binary string
                return binary;
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                int left = 0, right = nums.Length - 1;
                // Binary search approach
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    // If mid element is greater than the last element, minimum must be in the right half
                    if (nums[mid] > nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        // Otherwise, the minimum is in the left half (or it is mid)
                        right = mid;
                    }
                }
                // At the end of the binary search, left will point to the minimum element
                return nums[left];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                if (x < 0) return false;  // Negative numbers are not palindromes
                int original = x, reversed = 0;
                while (x > 0)
                {
                    int digit = x % 10;
                    reversed = reversed * 10 + digit;
                    x /= 10;
                }
                return original == reversed;  // Checking if the original number equals the reversed number
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                if (n == 0) return 0;  // Base case F(0) = 0
                if (n == 1) return 1;  // Base case F(1) = 1

                // Iteratively calculate Fibonacci numbers from F(2) to F(n)
                int a = 0, b = 1;  // Starting values F(0) = 0, F(1) = 1
                for (int i = 2; i <= n; i++)
                {
                    int next = a + b;  // F(n) = F(n-1) + F(n-2)
                    a = b;
                    b = next;
                }
                return b;  // Return the nth Fibonacci number
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}