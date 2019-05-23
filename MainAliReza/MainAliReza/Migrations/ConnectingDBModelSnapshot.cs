﻿// <auto-generated />
using MainAliReza.BackEnd;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MainAliReza.Migrations
{
    [DbContext(typeof(ConnectingDB))]
    partial class ConnectingDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MainAliReza.BackEnd.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Birthday_Day");

                    b.Property<string>("Birthday_Month");

                    b.Property<string>("Birthday_Year");

                    b.Property<string>("E_Mail");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("Mobil");

                    b.Property<string>("PassWord");

                    b.Property<string>("Picture");

                    b.Property<string>("Sath_E_Dastresy");

                    b.Property<string>("Telephon");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("person1");
                });

            modelBuilder.Entity("MainAliReza.BackEnd.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Category");

                    b.Property<string>("General_Explanation");

                    b.Property<string>("Mojody_Anbar");

                    b.Property<string>("Name");

                    b.Property<string>("Picture");

                    b.Property<string>("Price");

                    b.Property<string>("Weight");

                    b.HasKey("ID");

                    b.ToTable("product1");
                });
#pragma warning restore 612, 618
        }
    }
}
