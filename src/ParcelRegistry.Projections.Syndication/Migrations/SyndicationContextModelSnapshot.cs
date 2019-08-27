﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParcelRegistry.Projections.Syndication;

namespace ParcelRegistry.Projections.Syndication.Migrations
{
    [DbContext(typeof(SyndicationContext))]
    partial class SyndicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Be.Vlaanderen.Basisregisters.ProjectionHandling.Runner.ProjectionStates.ProjectionStateItem", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DesiredState");

                    b.Property<DateTimeOffset?>("DesiredStateChangedAt");

                    b.Property<long>("Position");

                    b.HasKey("Name")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("ProjectionStates","ParcelRegistrySyndication");
                });

            modelBuilder.Entity("ParcelRegistry.Projections.Syndication.Address.AddressPersistentLocalIdItem", b =>
                {
                    b.Property<Guid>("AddressId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsComplete");

                    b.Property<bool>("IsRemoved");

                    b.Property<string>("PersistentLocalId");

                    b.Property<long>("Position");

                    b.Property<DateTimeOffset?>("Version");

                    b.HasKey("AddressId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("IsComplete", "IsRemoved");

                    b.ToTable("AddressPersistentLocalIdSyndication","ParcelRegistrySyndication");
                });
#pragma warning restore 612, 618
        }
    }
}
