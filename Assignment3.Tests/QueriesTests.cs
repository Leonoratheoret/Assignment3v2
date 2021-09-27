using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3.Tests
{
    public class QueriesTests
    {
    
    
        [Fact]
        public void test_Sith_Lords_Year()
        {
            Queries q = new Queries();
            Assert.Equal(1977, q.Sith_Lords_Year());
        }

         [Fact]
        public void test_Sith_Lords_Year2()
        {
            Queries q = new Queries();
            Assert.Equal(1977, q.Sith_Lords_Year2());
        }

    
        [Fact]
        public void test_Unique_HarryPotter_Wizards_List()
        {
            Queries q = new Queries();
            var harryPotterList = new List<(string, int?)>(){
                ("Harry James Potter", 1997), ("Hermione Jean Granger",1997),
                ("Ronald Bilius Weasley",1997), ("Draco Lucius Malfoy", 1997),
                ("Albus Percival Wulfric Brian Dumbledore", 1997),
                ("Tom Marvolo Riddle", 1997), ("Severus Snape", 1997),
                ("Rubeus Hagrid", 1997), ("Ginevra Molly Weasley", 1997),
                ("Molly Weasley", 1997),("Arthur Weasley", 1997),
                ("Fredrick Gideon Weasley", 1997), ("George Fabian Weasley", 1997),
                ("Neville Longbottom",1997), ("Minerva McGonagall", 1997),
                ("Hedwig", 1997),("James Potter", 1997), ("Lily Evans", 1997),
                ("Vernon Dursley", 1997), ("Petunia Dursley", 1997),
                ("Dudley Dursley", 1997), ("Garrick Ollivander", 1997),
                ("Lucius malfoy", 1998), ("Dobby", 1998), ("Sirius Black", 1999),
                ("Remus John Lupin", 1999), ("Peter Pettigrew", 1999),
                ("Luna Lovegood", 2003), ("Dolores Jane Umbridge", 2003)
            };

            Assert.Equal(harryPotterList,q.Unique_HarryPotter_Wizards_List());

        }

        [Fact]
        public void test_Unique_HarryPotter_Wizards_List2()
        {
            Queries q = new Queries();
            var harryPotterList = new List<(string, int?)>(){
                ("Harry James Potter", 1997), ("Hermione Jean Granger",1997),
                ("Ronald Bilius Weasley",1997), ("Draco Lucius Malfoy", 1997),
                ("Albus Percival Wulfric Brian Dumbledore", 1997),
                ("Tom Marvolo Riddle", 1997), ("Severus Snape", 1997),
                ("Rubeus Hagrid", 1997), ("Ginevra Molly Weasley", 1997),
                ("Molly Weasley", 1997),("Arthur Weasley", 1997),
                ("Fredrick Gideon Weasley", 1997), ("George Fabian Weasley", 1997),
                ("Neville Longbottom",1997), ("Minerva McGonagall", 1997),
                ("Hedwig", 1997),("James Potter", 1997), ("Lily Evans", 1997),
                ("Vernon Dursley", 1997), ("Petunia Dursley", 1997),
                ("Dudley Dursley", 1997), ("Garrick Ollivander", 1997),
                ("Lucius malfoy", 1998), ("Dobby", 1998), ("Sirius Black", 1999),
                ("Remus John Lupin", 1999), ("Peter Pettigrew", 1999),
                ("Luna Lovegood", 2003), ("Dolores Jane Umbridge", 2003)
            };

            Assert.Equal(harryPotterList,q.Unique_HarryPotter_Wizards_List2());

        }
       
    }
}
