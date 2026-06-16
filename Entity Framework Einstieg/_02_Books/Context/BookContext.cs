using _02_Books.Model;
using Microsoft.EntityFrameworkCore;

namespace _02_Books.Context;

public class BookContext:DbContext
{
    public BookContext()
    {
        
    }


    public BookContext(DbContextOptions<BookContext> options) : base(options)
    {
        
    }
    
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<Author> Authors { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySQL("Server=localhost;Database=bookstore;Uid=root;Pwd=root;");
    #warning //
}