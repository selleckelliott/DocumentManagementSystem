using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Documents
{
  public class Invoice : Document
  {
    public decimal Amount { get; set; }
    public Invoice(string title, string content, string author, decimal amount) : base(title, content, author)
    {
      Amount = amount;
    }
    public override Document Clone()
    {
      return new Invoice(Title, Content, Author, Amount);
    }
    public override void DisplayInfo()
    {
      base.DisplayInfo();
      Console.WriteLine($"Amount: {Amount:C}");
    }
  }
}
