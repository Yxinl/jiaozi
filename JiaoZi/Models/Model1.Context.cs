﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JiaoZi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class jiaoziEntities : DbContext
    {
        public jiaoziEntities()
            : base("name=jiaoziEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Advice> Advice { get; set; }
        public virtual DbSet<Attention> Attention { get; set; }
        public virtual DbSet<BookComment> BookComment { get; set; }
        public virtual DbSet<BookReply> BookReply { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Carts> Carts { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<RemarkComments> RemarkComments { get; set; }
        public virtual DbSet<RemarkReply> RemarkReply { get; set; }
        public virtual DbSet<Remarks> Remarks { get; set; }
        public virtual DbSet<Shuoshuo> Shuoshuo { get; set; }
        public virtual DbSet<ShuoshuoComment> ShuoshuoComment { get; set; }
        public virtual DbSet<ShuoshuoComment_Reply> ShuoshuoComment_Reply { get; set; }
        public virtual DbSet<Text> Text { get; set; }
        public virtual DbSet<TextResource> TextResource { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Video> Video { get; set; }
        public virtual DbSet<VideoResource> VideoResource { get; set; }
        public virtual DbSet<Remark_User_Comments_Reply> Remark_User_Comments_Reply { get; set; }
        public virtual DbSet<salestop3> salestop3 { get; set; }
    }
}
