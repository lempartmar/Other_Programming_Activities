    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class PalindromeTest
    {
        public void Palindrom(string text)
        {

            char[] str = text.ToCharArray();
            List<char> listChar = str.ToList().OrderBy(o => o).ToList();
            List<char> listUnique = listChar.ToHashSet().ToList();
            List<int> number = new List<int>();
            for (int i = 0; i < listUnique.Count; i++)
            {
                number.Add(listChar.Where(x => x == listUnique.ElementAt(i)).Count());
            }
            int count = number.Where(x => x % 2 != 0).Count();
            System.Console.WriteLine("Check if characters of a given string can be rearranged to form a palindrome: ");
            System.Console.WriteLine(text);
            if (count > 1) { System.Console.WriteLine("No"); }
            else { System.Console.WriteLine("Yes"); }



        }
    }
}
