using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class LAM_Lab2Context : DbContext
    {
        public string connectionString;
        public LAM_Lab2Context() : base()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json", optional: false);

            var configuration = configurationBuilder.Build();
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public LAM_Lab2Context(DbContextOptions<LAM_Lab2Context> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)             //TODO Classes kod har inte if-sats
            //{
            //    optionsBuilder.UseSqlServer(connectionString);
            //}

            optionsBuilder.UseSqlServer(connectionString);
        }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<AuthorsBook> AuthorsBooks { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookStore> BookStores { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<PostalCode> PostalCodes { get; set; }
        public virtual DbSet<RegularCustomer> RegularCustomers { get; set; }
        public virtual DbSet<StockBalance> StockBalances { get; set; }
        public virtual DbSet<TitlesPerAuthor> TitlesPerAuthors { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Box).HasMaxLength(10);

                entity.Property(e => e.PostalCodeId).HasColumnName("PostalCodeID");

                entity.Property(e => e.Street).HasMaxLength(50);

                entity.HasOne(d => d.PostalCode)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.PostalCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Addresses_PostalCode");
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AFirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("A_FirstName");

                entity.Property(e => e.ALastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("A_LastName");

                entity.Property(e => e.BirthDate).HasColumnType("date");
            });

            modelBuilder.Entity<AuthorsBook>(entity =>
            {
                //entity.HasNoKey();
                entity.HasKey(e => new { e.AuthorsId, e.BooksIsbn13 });

                entity.Property(e => e.AuthorsId).HasColumnName("AuthorsID");

                entity.Property(e => e.BooksIsbn13)
                    .IsRequired()
                    .HasMaxLength(17)
                    .HasColumnName("BooksISBN13");

                entity.HasOne(d => d.Authors)
                    .WithMany()
                    .HasForeignKey(d => d.AuthorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorsBooks_Authors");

                entity.HasOne(d => d.BooksIsbn13Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.BooksIsbn13)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthorsBooks_Books");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Isbn13);

                entity.Property(e => e.Isbn13)
                    .HasMaxLength(17)
                    .HasColumnName("ISBN13");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Published).HasColumnType("date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BookStore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressesId).HasColumnName("AddressesID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Addresses)
                    .WithMany(p => p.BookStores)
                    .HasForeignKey(d => d.AddressesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookStores_Addresses");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressesId).HasColumnName("AddressesID");

                entity.Property(e => e.CFirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("C_FirstName");

                entity.Property(e => e.CLastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("C_LastName");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Addresses)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AddressesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customers_Addresses1");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BookStoresId).HasColumnName("BookStoresID");

                entity.Property(e => e.CustomersId).HasColumnName("CustomersID");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.HasOne(d => d.BookStores)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.BookStoresId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_BookStores");

                entity.HasOne(d => d.Customers)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Customers");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BooksIsbn13)
                    .IsRequired()
                    .HasMaxLength(17)
                    .HasColumnName("BooksISBN13");

                entity.Property(e => e.OrdersOrderId).HasColumnName("OrdersOrderID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.BooksIsbn13Navigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.BooksIsbn13)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_Books");

                entity.HasOne(d => d.OrdersOrder)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrdersOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderDetails_Orders");
            });

            modelBuilder.Entity<PostalCode>(entity =>
            {
                entity.ToTable("PostalCode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PostalCode");
            });

            modelBuilder.Entity<RegularCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RegularCustomers");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasMaxLength(101);

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .HasColumnName("Customer address");

                entity.Property(e => e.CustomerCity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Customer city");

                entity.Property(e => e.CustomerCountry)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Customer country");

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Customer email");

                entity.Property(e => e.CustomerPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Customer phone");

                entity.Property(e => e.CustomerPostbox)
                    .HasMaxLength(10)
                    .HasColumnName("Customer postbox");

                entity.Property(e => e.CustomerZipcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Customer Zipcode");

                entity.Property(e => e.CustomersId).HasColumnName("CustomersID");

                entity.Property(e => e.NoOfOrders).HasColumnName("No of Orders");
            });

            modelBuilder.Entity<StockBalance>(entity =>
            {
                
                entity.HasKey(e => new { e.BookStoresId, e.BooksIsbn13 });

                entity.Property(e => e.BookStoresId).HasColumnName("BookStoresID");

                entity.Property(e => e.BooksIsbn13)
                    .IsRequired()
                    .HasMaxLength(17)
                    .HasColumnName("BooksISBN13");

                entity.HasOne(d => d.BookStores)
                    .WithMany()
                    .HasForeignKey(d => d.BookStoresId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockBalances_BookStores");

                entity.HasOne(d => d.BooksIsbn13Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.BooksIsbn13)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockBalances_Books");
            });

            modelBuilder.Entity<TitlesPerAuthor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TitlesPerAuthor");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(101);

                entity.Property(e => e.NoOfTitles).HasColumnName("No. of titles");

                entity.Property(e => e.StockValue).HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
