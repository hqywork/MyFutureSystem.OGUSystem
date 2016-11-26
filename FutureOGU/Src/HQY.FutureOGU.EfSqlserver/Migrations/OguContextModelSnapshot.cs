using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HQY.FutureOGU.EfSqlserver;

namespace HQY.FutureOGU.EfSqlserver.Migrations
{
    [DbContext(typeof(OguContext))]
    partial class OguContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HQY.FutureOGU.DomainModel.DataDictionary.DDCategoryModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(32)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ColumnType", "datetime")
                        .HasAnnotation("SqlServer:DefaultValueSql", "GETDATE()");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<DateTime>("ModifyTime")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ColumnType", "datetime")
                        .HasAnnotation("SqlServer:DefaultValueSql", "GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("State");

                    b.Property<string>("Value")
                        .HasMaxLength(255);

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true)
                        .HasAnnotation("SqlServer:Name", "PK_DDCategory_Id");

                    b.ToTable("DDCategory");
                });

            modelBuilder.Entity("HQY.FutureOGU.DomainModel.DataDictionary.DDItemModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CategoryId");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(32)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ColumnType", "datetime")
                        .HasAnnotation("SqlServer:DefaultValueSql", "GETDATE()");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<DateTime>("ModifyTime")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ColumnType", "datetime")
                        .HasAnnotation("SqlServer:DefaultValueSql", "GETDATE()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("Sort");

                    b.Property<string>("Value")
                        .HasMaxLength(255);

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", true)
                        .HasAnnotation("SqlServer:Name", "PK_DDItem_Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("DDItem");
                });

            modelBuilder.Entity("HQY.FutureOGU.DomainModel.DataDictionary.DDItemModel", b =>
                {
                    b.HasOne("HQY.FutureOGU.DomainModel.DataDictionary.DDCategoryModel", "ParaCategory")
                        .WithMany("ParaItems")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_DDItem_CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
