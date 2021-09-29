using Sept28FBClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept28FBChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile facebookProfile = new Profile("Rex", "Meyer", new DateTime(1998, 03, 04), Relationship.Single, "Front Office Supervisor");

            Console.WriteLine(facebookProfile.FullName);
            Console.WriteLine(facebookProfile.Age);
            Console.WriteLine(facebookProfile.Status);
            Console.WriteLine(facebookProfile.Occupation);
            Console.ReadKey();
        }
    }
}
