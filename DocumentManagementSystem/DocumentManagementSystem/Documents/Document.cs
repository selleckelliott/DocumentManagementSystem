using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Documents
{
  public abstract class Document
  {
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public Document(string title, string content, string author)
    {
      Title = title;
      Content = content;
      Author = author;
    }
    public abstract Document Clone();
    public virtual void DisplayInfo()
    {
      Console.WriteLine($"Title: {Title}");
      Console.WriteLine($"Content: {Content}");
      Console.WriteLine($"Author: {Author}");
    }
  }
}
