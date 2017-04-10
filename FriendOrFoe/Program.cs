using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrFoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArr = new string[6] { "John", "Chris", "Ruthe", "Daniel", "Craig", "Liam" };

            FriendOrFoe(testArr);
        }
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> friends = new List<string>();
            for (var i = 0; i < names.Length; i++)
                if (names[i].Length == 5)
                    friends.Add(names[i]);

            //Print out result for the purpose of testing method
            foreach (var item in friends)
                Console.WriteLine(item);
            

            return friends;
        }
    }
}
