﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Persistance.Entities;

namespace Persistance;

public partial class ReceiptsContext : DbContext
{
    public ReceiptsContext()
    {
    }

    public ReceiptsContext(DbContextOptions<ReceiptsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ReceiptEntity> Receipts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\MSSQLSERVER01;Database=Receipts;Trusted_Connection=True;TrustServerCertificate=True;User ID=sa;Password=Test123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}