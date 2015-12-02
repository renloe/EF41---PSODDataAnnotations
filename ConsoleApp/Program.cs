using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new TweetInitializer());

            using (var context = new TwitterContext())
            {
                var alias = context.Aliases.Find(1);
            }

            // Adding a comment
        }
    }
}
