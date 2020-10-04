using System;

namespace LongLH9Shop.Model.Abstract
{
    public interface IAuditTable
    {
        DateTime? CretedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}