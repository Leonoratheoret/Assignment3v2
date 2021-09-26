using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

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
        
        public int? Sith_Lords_Year()
        {
            var wizards = Wizard.Wizards.Value;
            var sithLord = wizards.Where(c => c.Name.Contains("Darth")).Min(w => w.Year);

            return sithLord;
        }
        
        public int? Sith_Lords_Year2()
        {
            var wizards = Wizard.Wizards.Value;
            var sithLord = (
                from Wiz in wizards
                where Wiz.Name.Contains("Darth")
                orderby Wiz.Year  
                select Wiz.Year).First();

            return sithLord;

        }

    }
}
