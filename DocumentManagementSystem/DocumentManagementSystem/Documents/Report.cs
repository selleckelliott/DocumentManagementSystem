using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Documents
{
  public class Report : Document
  {
    public string ReportType { get; set; }

    public Report(string title, string content, string author, string reportType) : base(title, content, author)
    {
      ReportType = reportType;
    }
    public override Document Clone()
    {
      return new Report(Title, Content, Author, ReportType);
    }
    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Report Type: {ReportType}");
    }
  }
}
