﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC.Spreadsheet
{
    class Program
    {
        static void LoadFromConsole(Spreadsheet spreadsheet)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter data:   [|] = cell separator   [;] = end of data   [Enter] = next line");
            Console.ResetColor();
            string line;
            byte lineId = 0;
            do
            {
                line = Console.ReadLine();
                spreadsheet.LoadLine(lineId++, line);
            } while (!line.Contains(Spreadsheet.terminator));
            Console.Clear();
        }

        static void Main(string[] args)
        {   
            Spreadsheet spreadsheet = new Spreadsheet();

            LoadFromConsole(spreadsheet);
                  
            /*spreadsheet.LoadLine(0, " 1 | 3 | 45 | 3.4 |");
            spreadsheet.LoadLine(1, " 2 | 2 | -213 | 12;");
            spreadsheet.LoadLine(2, " 1 | 3 | 45 |");
            spreadsheet.LoadLine(3, " A1 + A2 + 4 | 1 | B1 + 3;");*/

            spreadsheet.print();

            Console.WriteLine();
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
