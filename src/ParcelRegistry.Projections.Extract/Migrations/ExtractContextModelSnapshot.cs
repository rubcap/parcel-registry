﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParcelRegistry.Projections.Extract;

namespace ParcelRegistry.Projections.Extract.Migrations
{
    [DbContext(typeof(ExtractContext))]
    partial class ExtractContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Be.Vlaanderen.Basisregisters.ProjectionHandling.Runner.ProjectionStates.ProjectionStateItem", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Position");

                    b.HasKey("Name")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("ProjectionStates","ParcelRegistryExtract");
                });

            modelBuilder.Entity("ParcelRegistry.Projections.Extract.ParcelExtract.ParcelExtractItem", b =>
                {
                    b.Property<Guid?>("ParcelId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CaPaKey");

                    b.Property<byte[]>("DbaseRecord");

                    b.HasKey("ParcelId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("CaPaKey")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("Parcel","ParcelRegistryExtract");
                });
#pragma warning restore 612, 618
        }
    }
}
