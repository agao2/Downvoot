﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using core_server.Infrastructure;

namespace core_server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190528175851_IdNamingConvetions")]
    partial class IdNamingConvetions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("core_server.Domain.Chatroom", b =>
                {
                    b.Property<int>("ChatroomId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ChatroomId");

                    b.ToTable("Chatrooms");
                });

            modelBuilder.Entity("core_server.Domain.ChatroomMemberships", b =>
                {
                    b.Property<int>("ChatroomMembershipId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ChatroomId");

                    b.Property<int?>("UserId");

                    b.HasKey("ChatroomMembershipId");

                    b.HasIndex("ChatroomId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatroomMemberships");
                });

            modelBuilder.Entity("core_server.Domain.User", b =>
                {
                    b.Property<int>("UserId")
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

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            DateCreated = "3/17/2019",
                            EmailAddress = "alex@fake.com",
                            Password = "password",
                            PasswordSalt = "password_salt",
                            Username = "alex"
                        },
                        new
                        {
                            UserId = 2,
                            DateCreated = "3/17/2019",
                            EmailAddress = "rob@ss.com",
                            Password = "password",
                            PasswordSalt = "password_salt",
                            Username = "rob"
                        },
                        new
                        {
                            UserId = 3,
                            DateCreated = "3/17/2019",
                            EmailAddress = "ll@fake.com",
                            Password = "password",
                            PasswordSalt = "password_salt",
                            Username = "lisa"
                        });
                });

            modelBuilder.Entity("core_server.Domain.ChatroomMemberships", b =>
                {
                    b.HasOne("core_server.Domain.Chatroom", "Chatroom")
                        .WithMany()
                        .HasForeignKey("ChatroomId");

                    b.HasOne("core_server.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
