﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjGetShopee_v2._0
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class iSpanProjectEntities1 : DbContext
    {
        public iSpanProjectEntities1()
            : base("name=iSpanProjectEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AD> ADs { get; set; }
        public virtual DbSet<ADToProduct> ADToProducts { get; set; }
        public virtual DbSet<ArguePic> ArguePics { get; set; }
        public virtual DbSet<Argument> Arguments { get; set; }
        public virtual DbSet<ArgumentReason> ArgumentReasons { get; set; }
        public virtual DbSet<ArgumentType> ArgumentTypes { get; set; }
        public virtual DbSet<BigType> BigTypes { get; set; }
        public virtual DbSet<ChatLog> ChatLogs { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentForCustomer> CommentForCustomers { get; set; }
        public virtual DbSet<CommentPic> CommentPics { get; set; }
        public virtual DbSet<CountryList> CountryLists { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<CouponWallet> CouponWallets { get; set; }
        public virtual DbSet<CustomizedCategory> CustomizedCategories { get; set; }
        public virtual DbSet<FAQ> FAQs { get; set; }
        public virtual DbSet<FAQType> FAQTypes { get; set; }
        public virtual DbSet<Follow> Follows { get; set; }
        public virtual DbSet<IconType> IconTypes { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<MemberAccount> MemberAccounts { get; set; }
        public virtual DbSet<MemStatu> MemStatus { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<OfficialEventList> OfficialEventLists { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentToProduct> PaymentToProducts { get; set; }
        public virtual DbSet<PaymentToSeller> PaymentToSellers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<ProductPic> ProductPics { get; set; }
        public virtual DbSet<ProductStatu> ProductStatus { get; set; }
        public virtual DbSet<ReceiveAdrList> ReceiveAdrLists { get; set; }
        public virtual DbSet<RegionList> RegionLists { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportStatu> ReportStatus { get; set; }
        public virtual DbSet<ReportType> ReportTypes { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<ShipperToProduct> ShipperToProducts { get; set; }
        public virtual DbSet<ShipperToSeller> ShipperToSellers { get; set; }
        public virtual DbSet<ShippingStatu> ShippingStatus { get; set; }
        public virtual DbSet<SmallType> SmallTypes { get; set; }
        public virtual DbSet<SubOfficialEventList> SubOfficialEventLists { get; set; }
        public virtual DbSet<SubOfficialEventToProduct> SubOfficialEventToProducts { get; set; }
    }
}
