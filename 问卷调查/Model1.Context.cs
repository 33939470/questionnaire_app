﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 问卷调查
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class paper_QuestionnaireEntities : DbContext
    {
        public paper_QuestionnaireEntities()
            : base("name=paper_QuestionnaireEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MenuInfo> MenuInfo { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserInfo> UserInfoSet { get; set; }
        public virtual DbSet<QuestionnaireInfo> QuestionnaireInfo { get; set; }
        public virtual DbSet<QuestionType> QuestionType { get; set; }
        public virtual DbSet<QuestionUrl> QuestionUrl { get; set; }
        public virtual DbSet<QuestionnaireDetailInfo> QuestionnaireDetailInfo { get; set; }
        public virtual DbSet<QuestionnaireTypeInfo> QuestionnaireTypeInfo { get; set; }
    }
}
