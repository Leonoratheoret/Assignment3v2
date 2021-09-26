using System;
using System.Linq;

namespace Assignment3
{
    public class Queries
    {
        public void Wizards_By_Rowling()
        {
            var wizards = Wizard.Wizards.Value;
            var byRowling = wizards.Where(c => c.Creator.Equals("J.K.Rowling"));

            foreach (var w in byRowling)
            {
                Console.WriteLine(w.Name);
            }
        }
        
        public void Wizards_By_Rowling2()
        {
            var wizards = Wizard.Wizards.Value;
            var byRowling =
                from Wiz in wizards
                where Wiz.Creator.Equals("J.K.Rowling")
                select Wiz.Name;

            foreach (var w in byRowling)
            {
                Console.WriteLine(w);
            }
        }

    }
}
