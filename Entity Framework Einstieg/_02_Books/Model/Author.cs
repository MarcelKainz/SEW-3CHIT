using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _02_Books.Model;

public class Author
{
    public int Id { get; set; }
    [MaxLength(20)]
    public string FirstName { get; set; } = string.Empty;

    [MaxLength(20)]
    public string LastName { get; set; } = string.Empty;
    
    [MaxLength(5)]
    public string? MiddleInitial { get; set; } = string.Empty;
    
    public List<Book> Books { get; set; }
}