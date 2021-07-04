using System;
using System.Collections.Generic;

namespace ConsoleTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print(10, 10, 10);
            ExcelCellPrint();

            ExcelLinePrint();
        }


        static int id = 1;
        static int idL = 1;
        static Random r = new Random();

        static void ExcelCellPrint()
        {
            var excelCell = new ExcelCell();
            excelCell.Id = id++;
            excelCell.Name = r.Next(1000);
            Console.Write($"{excelCell.Id} - {excelCell.Name}  ");
        }

        static void ExcelLinePrint()
        {
            var excelLine = new ExcelLine();
            excelLine.Id = idL++;

            excelLine.ExcelCells = new List<ExcelCell>()
            {
                new ExcelCell(){ Id=id++, Name=r.Next(100)},
                new ExcelCell(){ Id=id++, Name=r.Next(100)},
                new ExcelCell(){ Id=id++, Name=r.Next(100)},
                new ExcelCell(){ Id=id++, Name=r.Next(100)}
            };
            


            Console.Write($"{excelLine} -*- {excelLine.ExcelCells}  ");


        }




        static void Print(int table,int line, int cell)
        {
            Random random = new Random();

            for (int i = 0; i < table; i++)
            {
                Console.WriteLine();
                Console.WriteLine();

                for (int j = 0; j < line; j++)
                {
                    for (int k = 0; k < cell; k++)
                    {
                        Console.Write($"{random.Next(100)}  ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
