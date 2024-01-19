using BookStore.Core.Domain.Common;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BookStore.Core.Domain.Entities
{
        public class Shop : Entity<Guid>
        {
            public Shop(string name, string location) : base()
            {
                Name = name;
                Location = location;
                Books =      new Collection<Book>();
                Purchasers = new Collection<Purchaser>();
            }

            public string Name { get; private set; }
            public string Location { get; private set; }
            public Collection<Purchaser> Purchasers { get; private set; }
            public Collection<Book> Books { get; private set; }

            public void AddBook(Book book)
            {
                if (book != null && !Books.Contains(book))
                {
                    Books.Add(book);
                }
            }

            public void AddPurchaser(Purchaser purchaser)
            {
            // Implement logic to add a purchaser to the shop
                if (purchaser != null && ! Purchasers.Contains(purchaser))
                {
                    Purchasers.Add(purchaser);
                }
        }

            
        }
    

}
