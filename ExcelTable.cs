using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTable
{
    public class ExcelTable
    {


    }

    public class ExcelLine
    {
        public int Id { get; set; }

        public ExcelLine()
        {
            ExcelCells = new List<ExcelCell>();
        }

        public List<ExcelCell> ExcelCells { get; set; }

    }

    public class ExcelCell
    {
        public int Id { get; set; }

        public int Name { get; set; }

    }
}
