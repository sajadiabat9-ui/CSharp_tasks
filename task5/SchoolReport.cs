using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal sealed class SchoolReport
    {
        // Public auto-implemented property
        public string ReportTitle { get; set; }

        // Constructor receives the report title
        public SchoolReport(string reportTitle)
        {
            ReportTitle = reportTitle;
        }

        // Displays report title
        public void DisplayReportTitle()
        {
            Console.WriteLine("Report Title: " + ReportTitle);
        }
    }
}

