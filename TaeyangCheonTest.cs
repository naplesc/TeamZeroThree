// Test Commit File by Taeyang Cheon

using System;
using System.Collections.Generic;

namespace TeamZeroThree
{
	public class TaeyangCheonTest
    {
        public const string teamName = "TeamZeroThree";
        public List<string> teamMemberNames = new List<string>() { "Chase Naples", "Madison Woy", "Christopher Vu", "Christopher Hollis", "Taeyang Cheon" };
        
        public void Run()
        {
            PrintTeamMemberNames();

            Console.WriteLine("Enter any key to exit the program.");
            //Console.ReadKey();
            return;
        }

        public void PrintTeamMemberNames()
        {
            Console.Write(string.Format("-----{0}-----\n\nMembers:\n"));
            teamMemberNames.ForEach(teamMemberName => Console.Write(string.Format("#{0}: {1}\n", teamMemberNames.IndexOf(teamMemberName), teamMemberName)));
        }

        public static void Main()
        {
            TaeyangCheonTest taeyangCheonTest = new TaeyangCheonTest();
            taeyangCheonTest.Run();
        }
    }
}
