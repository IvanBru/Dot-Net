using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace lab3_book.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Назва 1", Author = "Автор 1", Price = 250 });
            db.Books.Add(new Book { Name = "Назва 2", Author = "Автор 2", Price = 200 });
            db.Books.Add(new Book { Name = "Назва 3", Author = "Автор 3", Price = 150 });

            base.Seed(db);
        }
    }
}
