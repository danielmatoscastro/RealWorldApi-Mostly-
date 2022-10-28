﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealWorld.Api.Data;

#nullable disable

namespace RealWorldApi.Migrations
{
    [DbContext(typeof(RealWorldDataContext))]
    [Migration("20221027213823_addTagSeed")]
    partial class addTagSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ARTICLES_TAGS", b =>
                {
                    b.Property<string>("ArticleSlug")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("TagName")
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("ArticleSlug", "TagName");

                    b.HasIndex("TagName");

                    b.ToTable("ARTICLES_TAGS");
                });

            modelBuilder.Entity("FAVORITES", b =>
                {
                    b.Property<string>("ArticleSlug")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("FavoritedBy")
                        .HasColumnType("INT");

                    b.HasKey("ArticleSlug", "FavoritedBy");

                    b.HasIndex("FavoritedBy");

                    b.ToTable("FAVORITES");
                });

            modelBuilder.Entity("FOLLOWERS", b =>
                {
                    b.Property<int>("Follow")
                        .HasColumnType("INT");

                    b.Property<int>("FollowedBy")
                        .HasColumnType("INT");

                    b.HasKey("Follow", "FollowedBy");

                    b.HasIndex("FollowedBy");

                    b.ToTable("FOLLOWERS");
                });

            modelBuilder.Entity("RealWorld.Api.Models.ArticleModel", b =>
                {
                    b.Property<string>("Slug")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INT");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("DATETIMEOFFSET");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("DATETIMEOFFSET");

                    b.HasKey("Slug");

                    b.HasIndex("AuthorId");

                    b.ToTable("ARTICLE", (string)null);
                });

            modelBuilder.Entity("RealWorld.Api.Models.CommentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ArticleSlug")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INT");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("DATETIMEOFFSET");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("DATETIMEOFFSET");

                    b.HasKey("Id");

                    b.HasIndex("ArticleSlug");

                    b.HasIndex("AuthorId");

                    b.ToTable("COMMENTS", (string)null);
                });

            modelBuilder.Entity("RealWorld.Api.Models.TagModel", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("Name");

                    b.ToTable("TAGS", (string)null);

                    b.HasData(
                        new
                        {
                            Name = "est"
                        },
                        new
                        {
                            Name = "illum"
                        },
                        new
                        {
                            Name = "assumenda"
                        },
                        new
                        {
                            Name = "iste"
                        },
                        new
                        {
                            Name = "quia"
                        },
                        new
                        {
                            Name = "natus"
                        },
                        new
                        {
                            Name = "et"
                        },
                        new
                        {
                            Name = "dignissimos"
                        },
                        new
                        {
                            Name = "reiciendis"
                        },
                        new
                        {
                            Name = "ad"
                        });
                });

            modelBuilder.Entity("RealWorld.Api.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bio")
                        .HasColumnType("VARCHAR(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Image")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("USERS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Illum assumenda iste quia natus et dignissimos reiciendis.\nNostrum totam harum totam voluptatibus.\nEos asperiores cum.",
                            Email = "Reagan.Stanton69@gmail.com",
                            Image = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/657.jpg",
                            PasswordHash = "10000.kyzLAFcvW4NZRW/aD1XQmA==.A0HkLh1f2Cj7gsLw1BVuylvgXXTuJthwnGDAnd7/Xh0=",
                            Username = "Trace Pfeffer"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "Vitae amet qui exercitationem doloribus facilis omnis.\nVel nisi a.\nPorro sed ad et autem suscipit blanditiis.",
                            Email = "Dallin_Jast48@gmail.com",
                            Image = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/243.jpg",
                            PasswordHash = "10000.dR8AYSEzXCWh3AImE5M4oA==.05tRvRM8TgnNyGvWPpctPR9FVQRL3kLLV/yiy5+XAoM=",
                            Username = "Shad Shanahan"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "Vero soluta fuga eius saepe eveniet dicta quo.\nFacilis dolorem eius repellat.\nEt quisquam consequatur aut qui porro.",
                            Email = "Susan_Dickens@gmail.com",
                            Image = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/406.jpg",
                            PasswordHash = "10000.2NeL+r/Tk45Hn8JxACCBZQ==.zxhyEIgrb0PJafhJY8QD7AFduGUHmKYtsM6zskic0ic=",
                            Username = "Marcos Koss"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "Consequatur autem voluptas itaque exercitationem cupiditate nam sit quis.\nModi amet quasi fuga eligendi et molestiae modi non.\nUt cum explicabo.",
                            Email = "Benny.Monahan14@gmail.com",
                            Image = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/847.jpg",
                            PasswordHash = "10000.M5pG+QmkxFBjrKTHTVbufg==./B2Hac0H5kZLXhamXfwd1wl2/2Uqq3pui6cXVDD+pmw=",
                            Username = "Kevin Fahey"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "Consequatur ea pariatur veritatis veniam nihil a.\nIure cupiditate minima molestias provident inventore minima dolores nulla laborum.\nQuod ea recusandae.",
                            Email = "Maximo_Morissette56@gmail.com",
                            Image = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/215.jpg",
                            PasswordHash = "10000.LnHOXVnfESvSER7aaMeyZg==.qb0fLj5xeD6U371ihtHVwg9UH3E6s4/kCeQRA7cdL70=",
                            Username = "Christina Monahan"
                        },
                        new
                        {
                            Id = 6,
                            Bio = "Repellat similique veritatis voluptatem voluptas.\nFacilis sint ut beatae excepturi sequi vel.\nIn omnis tempore asperiores corporis et laudantium atque.",
                            Email = "Antonia44@gmail.com",
                            Image = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/563.jpg",
                            PasswordHash = "10000.DwNDFnhTyMwCr9inIpw+9A==.GvozCb/XOivN+pDuhs7gNeVFkqlPWkgLbNYWNYYNzEw=",
                            Username = "Aisha Howell"
                        },
                        new
                        {
                            Id = 7,
                            Bio = "Sed repudiandae doloremque molestias sapiente asperiores sit et minima.\nOfficia est quia quam aut rerum aut aliquam magni eveniet.\nAut perspiciatis repellendus excepturi.",
                            Email = "Zachariah.Bartoletti19@yahoo.com",
                            Image = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/620.jpg",
                            PasswordHash = "10000.nI6jTcePHOxnEduxlKY7JQ==.t0DaVsVc8f+dRlrjRNeNeZz8aVmJ5SrUdLhq9ONRRk0=",
                            Username = "Krista Gibson"
                        },
                        new
                        {
                            Id = 8,
                            Bio = "Et repellendus dolores laborum natus.\nLaboriosam voluptatem aspernatur debitis quo saepe et aliquam.\nVoluptatum adipisci necessitatibus quos quidem.",
                            Email = "Frida_Frami0@gmail.com",
                            Image = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1229.jpg",
                            PasswordHash = "10000.wXOVJ9rxwW4ReGZmrFNx0Q==.CXE+wAmrnDVyMyyW2aIlg8i+d1sbISnZ/yUovhgkDBg=",
                            Username = "Vidal Crona"
                        },
                        new
                        {
                            Id = 9,
                            Bio = "Sunt consectetur veritatis aut minus aut voluptas facilis sunt.\nQuo eos ducimus et.\nPraesentium laboriosam omnis molestiae est repellat est sunt fuga.",
                            Email = "Scarlett0@hotmail.com",
                            Image = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/696.jpg",
                            PasswordHash = "10000.Aq54hQzmEKQSg1sZ9puOOQ==.S5AH6pwF3ne+QAN7roP5cRvW+T+vY8ARpfpwTMAhxNQ=",
                            Username = "Margarett Hoeger"
                        },
                        new
                        {
                            Id = 10,
                            Bio = "Quia repellendus occaecati eum ut cupiditate neque harum omnis.\nMagnam et praesentium et laboriosam.\nVoluptatem distinctio quia sed.",
                            Email = "Oma43@yahoo.com",
                            Image = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/149.jpg",
                            PasswordHash = "10000.Nxk3P5QEwse5SkDfOEGpew==.Rt+HfKNk9USCuKpI5FOYIVN81PuFrr1dsrSb1CO8hQQ=",
                            Username = "Rylee Maggio"
                        });
                });

            modelBuilder.Entity("ARTICLES_TAGS", b =>
                {
                    b.HasOne("RealWorld.Api.Models.ArticleModel", null)
                        .WithMany()
                        .HasForeignKey("ArticleSlug")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RealWorld.Api.Models.TagModel", null)
                        .WithMany()
                        .HasForeignKey("TagName")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("FAVORITES", b =>
                {
                    b.HasOne("RealWorld.Api.Models.ArticleModel", null)
                        .WithMany()
                        .HasForeignKey("ArticleSlug")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RealWorld.Api.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("FavoritedBy")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("FOLLOWERS", b =>
                {
                    b.HasOne("RealWorld.Api.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("Follow")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RealWorld.Api.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("FollowedBy")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("RealWorld.Api.Models.ArticleModel", b =>
                {
                    b.HasOne("RealWorld.Api.Models.UserModel", "Author")
                        .WithMany("Articles")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("RealWorld.Api.Models.CommentModel", b =>
                {
                    b.HasOne("RealWorld.Api.Models.ArticleModel", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleSlug")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RealWorld.Api.Models.UserModel", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("RealWorld.Api.Models.ArticleModel", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("RealWorld.Api.Models.UserModel", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}