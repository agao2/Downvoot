﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using core_server.Models;

namespace core_server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("core_server.Models.Chatroom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Chatrooms");
                });

            modelBuilder.Entity("core_server.Models.ChatroomMemberships", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ChatroomID");

                    b.Property<int?>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("ChatroomID");

                    b.HasIndex("UserID");

                    b.ToTable("ChatroomMemberships");
                });

            modelBuilder.Entity("core_server.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateCreated")
                        .IsRequired();

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PasswordSalt")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DateCreated = "3/17/2019",
                            EmailAddress = "alex@fake.com",
                            Password = "password",
                            PasswordSalt = "password_salt",
                            Username = "alex"
                        },
                        new
                        {
                            ID = 2,
                            DateCreated = "3/17/2019",
                            EmailAddress = "rob@ss.com",
                            Password = "password",
                            PasswordSalt = "password_salt",
                            Username = "rob"
                        },
                        new
                        {
                            ID = 3,
                            DateCreated = "3/17/2019",
                            EmailAddress = "ll@fake.com",
                            Password = "password",
                            PasswordSalt = "password_salt",
                            Username = "lisa"
                        });
                });

            modelBuilder.Entity("core_server.Models.ChatroomMemberships", b =>
                {
                    b.HasOne("core_server.Models.Chatroom", "Chatroom")
                        .WithMany()
                        .HasForeignKey("ChatroomID");

                    b.HasOne("core_server.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}