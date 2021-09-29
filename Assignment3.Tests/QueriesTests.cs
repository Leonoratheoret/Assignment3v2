using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Assignment3.Tests
{
    public class QueriesTests
    {
    
    
        [Fact]
        public void Sith_Lords_Year()
        {
            Queries q = new Queries();
            Assert.Equal(1977, q.Sith_Lords_Year());
        }

         [Fact]
        public void Sith_Lords_Year2()
        {
            Queries q = new Queries();
            Assert.Equal(1977, q.Sith_Lords_Year2());
        }

    
        [Fact]
        public void Unique_HarryPotter_Wizards_List()
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
        public void Unique_HarryPotter_Wizards_List2()
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

        [Fact]
        public void List_Of_Wizards_By_Rowling()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            Queries q = new Queries();
            q.Wizards_By_Rowling();
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Harry James Potter\nHermione Jean Granger\nRonald Bilius Weasley\n"+
            "Draco Lucius Malfoy\nAlbus Percival Wulfric Brian Dumbledore\nTom Marvolo Riddle\nSeverus Snape\n"+
            "Rubeus Hagrid\nGinevra Molly Weasley\nMolly Weasley\nArthur Weasley\nFredrick Gideon Weasley\n"+
            "George Fabian Weasley\nNeville Longbottom\nMinerva McGonagall\nHedwig\nJames Potter\nLily Evans\n"+
            "Vernon Dursley\nPetunia Dursley\nDudley Dursley\nGarrick Ollivander\nLucius malfoy\nDobby\n"+
            "Sirius Black\nRemus John Lupin\nPeter Pettigrew\nLuna Lovegood\nDolores Jane Umbridge", output);

        }


         [Fact]
        public void List_Of_Wizards_By_Rowling2()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            Queries q = new Queries();
            q.Wizards_By_Rowling2();
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Harry James Potter\nHermione Jean Granger\nRonald Bilius Weasley\n"+
            "Draco Lucius Malfoy\nAlbus Percival Wulfric Brian Dumbledore\nTom Marvolo Riddle\nSeverus Snape\n"+
            "Rubeus Hagrid\nGinevra Molly Weasley\nMolly Weasley\nArthur Weasley\nFredrick Gideon Weasley\n"+
            "George Fabian Weasley\nNeville Longbottom\nMinerva McGonagall\nHedwig\nJames Potter\nLily Evans\n"+
            "Vernon Dursley\nPetunia Dursley\nDudley Dursley\nGarrick Ollivander\nLucius malfoy\nDobby\n"+
            "Sirius Black\nRemus John Lupin\nPeter Pettigrew\nLuna Lovegood\nDolores Jane Umbridge", output);

        }

        [Fact]
        public void List_Of_Order_Wizards_List()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            Queries q = new Queries();
            foreach (var list in q.Order_Wizards_List())
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Thomas Ward\nMother Malkin\nKratch\nJohn Gregory\nBony Lizzie\nAlice Deane\nSauron\n"+
                        "Sam\nPippin\nMerry\nLegolas\nGollum\nGimli\nGandalf\nFrodo\nBoromir\nAragorn\nVernon Dursley\n"+
                        "Tom Marvolo Riddle\nSirius Black\nSeverus Snape\nRubeus Hagrid\nRonald Bilius Weasley\n"+
                        "Remus John Lupin\nPetunia Dursley\nPeter Pettigrew\nNeville Longbottom\nMolly Weasley\n"+
                        "Minerva McGonagall\nLuna Lovegood\nLucius malfoy\nLily Evans\nJames Potter\nHermione Jean Granger\n"+
                        "Hedwig\nHarry James Potter\nGinevra Molly Weasley\nGeorge Fabian Weasley\nGarrick Ollivander\n"+
                        "Fredrick Gideon Weasley\nDudley Dursley\nDraco Lucius Malfoy\nDolores Jane Umbridge\nDobby\nArthur Weasley\n"+
                        "Albus Percival Wulfric Brian Dumbledore\nDarth Vader\nSusan\nReepicheep\nPrince Caspian\n"+
                        "Peter\nLucy\nHr. Tumnus\nEdmund\nAslan", output);
        }


        [Fact]
        public void List_Of_Order_Wizards_List2()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            Queries q = new Queries();

            foreach (var item in  q.Order_Wizards_List2())
                {
                    Console.WriteLine(item);
                }

            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("Thomas Ward\nMother Malkin\nKratch\nJohn Gregory\nBony Lizzie\nAlice Deane\nSauron\n"+
                        "Sam\nPippin\nMerry\nLegolas\nGollum\nGimli\nGandalf\nFrodo\nBoromir\nAragorn\nVernon Dursley\n"+
                        "Tom Marvolo Riddle\nSirius Black\nSeverus Snape\nRubeus Hagrid\nRonald Bilius Weasley\n"+
                        "Remus John Lupin\nPetunia Dursley\nPeter Pettigrew\nNeville Longbottom\nMolly Weasley\n"+
                        "Minerva McGonagall\nLuna Lovegood\nLucius malfoy\nLily Evans\nJames Potter\nHermione Jean Granger\n"+
                        "Hedwig\nHarry James Potter\nGinevra Molly Weasley\nGeorge Fabian Weasley\nGarrick Ollivander\n"+
                        "Fredrick Gideon Weasley\nDudley Dursley\nDraco Lucius Malfoy\nDolores Jane Umbridge\nDobby\nArthur Weasley\n"+
                        "Albus Percival Wulfric Brian Dumbledore\nDarth Vader\nSusan\nReepicheep\nPrince Caspian\n"+
                        "Peter\nLucy\nHr. Tumnus\nEdmund\nAslan", output);
        }
       
    }
}
