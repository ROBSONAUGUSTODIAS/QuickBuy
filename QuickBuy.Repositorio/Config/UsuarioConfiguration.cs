﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //Builder utiliza o padrão Fluent

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email).IsRequired().HasMaxLength(50);

            builder.Property(u => u.Senha).IsRequired().HasMaxLength(400);

            builder.Property(u => u.Nome).IsRequired().HasMaxLength(50);

            builder.Property(u => u.SobreNome).IsRequired().HasMaxLength(60);

            builder.HasMany(u => u.Pedidos).WithOne(p => p.Usuario);
           
        }
    }
}
