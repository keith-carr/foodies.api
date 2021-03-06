// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using foodies.Models;

#nullable disable

namespace foodies.Migrations
{
    [DbContext(typeof(foodiesdbContext))]
    [Migration("20220314033213_Fourth")]
    partial class Fourth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("foodies.Models.Account", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_on");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("email");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("username");

                    b.HasKey("UserId")
                        .HasName("accounts_pkey");

                    b.HasIndex(new[] { "Email" }, "accounts_email_key")
                        .IsUnique();

                    b.HasIndex(new[] { "Username" }, "accounts_username_key")
                        .IsUnique();

                    b.ToTable("accounts", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
