﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PizzaBox.Storing;

namespace PizzaBox.Storing.Migrations
{
    [DbContext(typeof(PizzaBoxContext))]
    [Migration("20210512130214_latest migration")]
    partial class latestmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ACrust", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<bool>("Vegan")
                        .HasColumnType("boolean");

                    b.Property<bool>("Veget")
                        .HasColumnType("boolean");

                    b.HasKey("EntityId");

                    b.ToTable("Crusts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ACrust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizzaType", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("isCustom")
                        .HasColumnType("boolean");

                    b.HasKey("EntityId");

                    b.ToTable("PizzaTypes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("APizzaType");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ASauce", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<bool>("Vegan")
                        .HasColumnType("boolean");

                    b.Property<bool>("Veget")
                        .HasColumnType("boolean");

                    b.HasKey("EntityId");

                    b.ToTable("Sauces");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ASauce");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.AStore", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("Stores");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AStore");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ATopping", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long?>("PizzaEntityId")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<bool>("Vegan")
                        .HasColumnType("boolean");

                    b.Property<bool>("Veget")
                        .HasColumnType("boolean");

                    b.Property<long?>("pizzaEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("PizzaEntityId");

                    b.HasIndex("pizzaEntityId");

                    b.ToTable("Toppings");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ATopping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Orders.Customer", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("EntityId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Orders.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("CustomerEntityId")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<long?>("StoreEntityId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Time")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("EntityId");

                    b.HasIndex("CustomerEntityId");

                    b.HasIndex("StoreEntityId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("CrustEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("OrderEntityId")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<long?>("SauceEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("orderEntityId")
                        .HasColumnType("bigint");

                    b.Property<long?>("pizzaTypeEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("CrustEntityId");

                    b.HasIndex("OrderEntityId");

                    b.HasIndex("SauceEntityId");

                    b.HasIndex("orderEntityId");

                    b.HasIndex("pizzaTypeEntityId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crusts.LargeCrust", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ACrust");

                    b.HasDiscriminator().HasValue("LargeCrust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crusts.MediumCrust", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ACrust");

                    b.HasDiscriminator().HasValue("MediumCrust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crusts.SmallCrust", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ACrust");

                    b.HasDiscriminator().HasValue("SmallCrust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crusts.XLargeCrust", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ACrust");

                    b.HasDiscriminator().HasValue("XLargeCrust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PizzaTypes.CustomPizza", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.APizzaType");

                    b.HasDiscriminator().HasValue("CustomPizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Sauces.Alfredo", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ASauce");

                    b.HasDiscriminator().HasValue("Alfredo");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Sauces.Bbq", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ASauce");

                    b.HasDiscriminator().HasValue("Bbq");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Sauces.Marinara", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ASauce");

                    b.HasDiscriminator().HasValue("Marinara");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Stores.ChicagoStore", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.AStore");

                    b.HasDiscriminator().HasValue("ChicagoStore");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Stores.NewYorkStore", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.AStore");

                    b.HasDiscriminator().HasValue("NewYorkStore");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Chedder", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Chedder");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.GrilledChicken", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("GrilledChicken");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Mozzerella", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Mozzerella");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Parmesan", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Parmesan");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Pineapple", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Pineapple");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Sausage", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Sausage");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Spinach", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Spinach");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ATopping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Pizza", null)
                        .WithMany("Toppings")
                        .HasForeignKey("PizzaEntityId");

                    b.HasOne("PizzaBox.Domain.Models.Pizza", "pizza")
                        .WithMany()
                        .HasForeignKey("pizzaEntityId");

                    b.Navigation("pizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Orders.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Orders.Customer", "Customer")
                        .WithMany("orders")
                        .HasForeignKey("CustomerEntityId");

                    b.HasOne("PizzaBox.Domain.Abstracts.AStore", "Store")
                        .WithMany("orders")
                        .HasForeignKey("StoreEntityId");

                    b.Navigation("Customer");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Abstracts.ACrust", "Crust")
                        .WithMany()
                        .HasForeignKey("CrustEntityId");

                    b.HasOne("PizzaBox.Domain.Models.Orders.Order", null)
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderEntityId");

                    b.HasOne("PizzaBox.Domain.Abstracts.ASauce", "Sauce")
                        .WithMany()
                        .HasForeignKey("SauceEntityId");

                    b.HasOne("PizzaBox.Domain.Models.Orders.Order", "order")
                        .WithMany()
                        .HasForeignKey("orderEntityId");

                    b.HasOne("PizzaBox.Domain.Abstracts.APizzaType", "pizzaType")
                        .WithMany()
                        .HasForeignKey("pizzaTypeEntityId");

                    b.Navigation("Crust");

                    b.Navigation("order");

                    b.Navigation("pizzaType");

                    b.Navigation("Sauce");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.AStore", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Orders.Customer", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Orders.Order", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.Navigation("Toppings");
                });
#pragma warning restore 612, 618
        }
    }
}
