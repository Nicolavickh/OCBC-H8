// <auto-generated />
using System;
using Bank_PaymentDetails.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bank_PaymentDetails.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20211024153013_Initial Migrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Bank_PaymentDetails.Models.ItemData", b =>
                {
                    b.Property<int>("paymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cardNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("cardOwnerName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("expirationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("securityCode")
                        .HasColumnType("TEXT");

                    b.HasKey("paymentDetailId");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
