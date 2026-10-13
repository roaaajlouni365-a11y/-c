using System;

namespace task5
{
  
        internal sealed class SchoolReport
        {
            public string ReportTitle { get; set; }

            public SchoolReport(string reportTitle)
            {
                ReportTitle = reportTitle;
            }

            public void DisplayReportTitle()
            {
                Console.WriteLine($"Report Title: {ReportTitle}");
            }
        }
    }
