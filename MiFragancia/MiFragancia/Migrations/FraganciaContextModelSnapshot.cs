﻿// <auto-generated />
using MiFragancia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MiFragancia.Migrations
{
    [DbContext(typeof(FraganciaContext))]
    partial class FraganciaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MiFragancia.Models.Carrito", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<float>("Precio");

                    b.Property<int>("ProductoId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("ID");

                    b.HasIndex("ProductoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Carrito");
                });

            modelBuilder.Entity("MiFragancia.Models.Imagens", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo");

                    b.Property<string>("Nombre");

                    b.Property<string>("Ruta");

                    b.HasKey("ID");

                    b.ToTable("Imagen");
                });

            modelBuilder.Entity("MiFragancia.Models.Producto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo");

                    b.Property<int>("Cantidad");

                    b.Property<string>("Descripcion");

                    b.Property<int>("ImagenId");

                    b.Property<string>("Nombre");

                    b.Property<double>("Precio");

                    b.Property<int>("TipoProductoId");

                    b.HasKey("ID");

                    b.HasIndex("ImagenId");

                    b.HasIndex("TipoProductoId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("MiFragancia.Models.TipoProducto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo");

                    b.Property<string>("Tipo");

                    b.HasKey("ID");

                    b.ToTable("TipoProducto");
                });

            modelBuilder.Entity("MiFragancia.Models.UsuarioModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activo");

                    b.Property<bool>("Admin");

                    b.Property<string>("Contrasenna");

                    b.Property<string>("Correo");

                    b.Property<string>("Nombre");

                    b.Property<string>("Usuario");

                    b.HasKey("ID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("MiFragancia.Models.Carrito", b =>
                {
                    b.HasOne("MiFragancia.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MiFragancia.Models.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MiFragancia.Models.Producto", b =>
                {
                    b.HasOne("MiFragancia.Models.Imagens", "Imagen")
                        .WithMany()
                        .HasForeignKey("ImagenId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MiFragancia.Models.TipoProducto", "Tipo")
                        .WithMany()
                        .HasForeignKey("TipoProductoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
