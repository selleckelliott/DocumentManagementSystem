using DocumentManagementSystem.Documents;
using DocumentManagementSystem.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
  static void Main()
  {
    Report report = new Report("Annual Report", "Summary of annual performance.", "Alice", "Financial");
    Invoice invoice = new Invoice("Invoice #123", "Payment for services rendered.", "Bob", 1500.75m);

    DocumentManager manager = new DocumentManager();
    manager.AddDocument(report);
    manager.AddDocument(invoice);

    Console.WriteLine("Original Documents:");
    manager.DisplayAllDocuments();

    Document clonedReport = manager.CloneDocument(0);
    clonedReport.Title = "Cloned Annual Report";
    clonedReport.Content = "This is a cloned version of the annual report.";

    Document clonedInvoice = manager.CloneDocument(1);
    clonedInvoice.Author = "Charlie";

    Console.WriteLine("Cloned Documents:");
    clonedReport.DisplayInfo();
    Console.WriteLine();
    Console.WriteLine();
    clonedInvoice.DisplayInfo();
  }
}