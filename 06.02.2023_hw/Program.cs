using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _06._02._2023_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 8
            {
                Console.WriteLine("enter text");
                string str = Console.ReadLine();
                Console.WriteLine("enter index");
                int index = Convert.ToInt32(Console.ReadLine());
                str = str.Remove(index, 1);
                Console.WriteLine(str);
            }
            #endregion
            #region task 9
            {
                Console.WriteLine("enter text");
                StringBuilder str = new StringBuilder(Console.ReadLine());
                Console.WriteLine("enter char");
                char ch = Console.ReadKey().KeyChar;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ch) str = str.Remove(i--, 1);
                }
                Console.WriteLine($"\n{str}");
            }
            #endregion
            #region task 10
            {
                Console.WriteLine("enter text");
                string str = Console.ReadLine();
                Console.WriteLine("enter char");
                string ch = Console.ReadLine();
                Console.WriteLine("enter index");
                int index = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < str.Length; i++)
                {
                    if (i == index)
                    {
                        str = str.Insert(index, ch);
                        break;
                    }
                }
                Console.WriteLine(str);

            }
            #endregion
            #region task 11
            {
                Console.WriteLine("enter text");
                string str = Console.ReadLine();
                bool flag = false;
                for (int i = 0; i < str.Length / 2; i++)
                {
                    flag = str[i] == str[str.Length - 1 - i];
                }
                if (flag == true) Console.WriteLine("Str is a palindrome");
                else Console.WriteLine("Str is not a palindrome");
            }
            #endregion
            #region task 12
            {
                Console.WriteLine("enter text");
                string str = Console.ReadLine();
                string[] str_arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int counter = str_arr.Length;
                Console.WriteLine("Words counter value:{0}", counter);
            }
            #endregion
            #region task 13
            {
                Console.WriteLine("enter text");
                string mainStr = Console.ReadLine();
                Console.WriteLine("enter target text");
                string targetStr = Console.ReadLine();
                Console.WriteLine("enter new text");
                string newStr = Console.ReadLine();
                mainStr = mainStr.Replace(targetStr, newStr);
                Console.WriteLine(mainStr);
            }
            #endregion
            #region tesk 14
            {
                Console.WriteLine("enter text");
                StringBuilder mainStr = new StringBuilder(Console.ReadLine());
                string[] words = mainStr.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                mainStr.Clear();
                for (int i = 0; i < words.Length - 1; i += 2)
                {
                    (words[i], words[i + 1]) = (words[i + 1], words[i]);
                    //words[i] = words[i].Remove(words[i].IndexOf('\n'),1);
                    //words[i+1] = words[i+1].Remove(words[i+1].IndexOf('\n'), 1);
                    mainStr.Append(words[i] + ' ');
                    mainStr.Append(words[i + 1] + ' ');
                }
                Console.WriteLine(mainStr);
            }
            #endregion
            #region task 15
            {
                Console.WriteLine("enter text");
                string mainStr = Console.ReadLine();
                string[] words= mainStr.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
                int counter = 0;
                char[] vowels = new char[] { 'у', 'ы', 'а', 'о', 'и', 'э' };
                foreach (string word in words)
                {
                    foreach (char vowel in vowels) {
                        if (word[word.Length - 1] == vowel)
                        {
                            counter++;
                            break;
                        }
                    }
                }
                Console.WriteLine(counter);
            }
            #endregion
            Console.ReadKey();

        }
    }
}
