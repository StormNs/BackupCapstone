﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataService.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_Finance_AcademicEntities : DbContext
    {
        public DB_Finance_AcademicEntities()
            : base("name=DB_Finance_AcademicEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Curriculum> Curricula { get; set; }
        public virtual DbSet<Document_Student> Document_Student { get; set; }
        public virtual DbSet<MarkComponent> MarkComponents { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<RealSemester> RealSemesters { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Subject_Curriculum> Subject_Curriculum { get; set; }
        public virtual DbSet<Subject_MarkComponent> Subject_MarkComponent { get; set; }
    }
}
