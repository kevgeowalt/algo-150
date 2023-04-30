using System;

namespace Arrays_Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupAnagramsClass @class = new GroupAnagramsClass();
            string[] array = new string[] { "bdddddddddd", "bbbbbbbbbbc" };
            var result = @class.GroupAnagrams(array);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
