//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Report
    {
        public int ReportID { get; set; }
        public int ReporterID { get; set; }
        public int ProductID { get; set; }
        public int ReportTypeID { get; set; }
        public string Reason { get; set; }
        public byte[] ReportPic { get; set; }
        public int ReportStatusID { get; set; }
    
        public virtual MemberAccount MemberAccount { get; set; }
        public virtual Product Product { get; set; }
        public virtual ReportStatu ReportStatu { get; set; }
        public virtual ReportType ReportType { get; set; }
    }
}