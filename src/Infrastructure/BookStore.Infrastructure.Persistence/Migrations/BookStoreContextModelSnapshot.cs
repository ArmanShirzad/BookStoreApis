﻿// <auto-generated />
using System;
using BookStore.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    partial class BookStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookStore.Core.Domain.Common.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LastModifedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.Basket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PurchaserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PurchaserId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid?>("BasketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PriceAtTime")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.RequestResponseLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponseData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RequestResponseLogs");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.Author", b =>
                {
                    b.HasBaseType("BookStore.Core.Domain.Common.Person");

                    b.HasDiscriminator().HasValue("Author");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.Purchaser", b =>
                {
                    b.HasBaseType("BookStore.Core.Domain.Common.Person");

                    b.HasDiscriminator().HasValue("Purchaser");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.Basket", b =>
                {
                    b.HasOne("BookStore.Core.Domain.Entities.Purchaser", "Purchaser")
                        .WithMany("Baskets")
                        .HasForeignKey("PurchaserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Purchaser");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.BasketItem", b =>
                {
                    b.HasOne("BookStore.Core.Domain.Entities.Basket", null)
                        .WithMany("Items")
                        .HasForeignKey("BasketId");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.Book", b =>
                {
                    b.HasOne("BookStore.Core.Domain.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.Basket", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookStore.Core.Domain.Entities.Purchaser", b =>
                {
                    b.Navigation("Baskets");
                });
#pragma warning restore 612, 618
        }
    }
}
