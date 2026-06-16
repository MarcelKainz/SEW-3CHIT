using System.ComponentModel.DataAnnotations.Schema;

namespace _02_Books.Model;

public class Book
{
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(50)")]
    public string Title { get; set; }
    
    //Navigation Property
    public List<Author> Authors { get; set; }
}