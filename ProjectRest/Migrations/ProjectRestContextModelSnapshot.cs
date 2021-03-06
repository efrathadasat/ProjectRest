﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProjectRest.Models;
using System;

namespace ProjectRest.Migrations
{
    [DbContext(typeof(ProjectRestContext))]
    partial class ProjectRestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectRest.Models.City", b =>
                {
                    b.Property<int>("IdCity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NameCity");

                    b.HasKey("IdCity");

                    b.ToTable("City");
                });

            modelBuilder.Entity("ProjectRest.Models.Menu", b =>
                {
                    b.Property<int>("IdMenu")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Categorya");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUri");

                    b.Property<string>("NameDose");

                    b.Property<int>("Price");

                    b.HasKey("IdMenu");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("ProjectRest.Models.Order", b =>
                {
                    b.Property<int>("IdOrder")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<DateTime>("DateForDay");

                    b.Property<int>("IdClub");

                    b.Property<int>("IdMenu");

                    b.HasKey("IdOrder");

                    b.HasIndex("IdMenu");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ProjectRest.Models.Order", b =>
                {
                    b.HasOne("ProjectRest.Models.Menu", "Menus")
                        .WithMany("Orders")
                        .HasForeignKey("IdMenu")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
