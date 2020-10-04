using System;
using System.ComponentModel.DataAnnotations;

namespace LongLH9Shop.Model.Abstract
{
    public abstract class AuditTable : IAuditTable
    {
        public abstract DateTime? CretedDate { get; set; }

        [MaxLength(256)]
        public abstract string CreatedBy { get; set; }

        public abstract DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public abstract string UpdatedBy { get; set; }

        [MaxLength(256)]
        public abstract string MetaKeyword { get; set; }

        [MaxLength(256)]
        public abstract string MetaDescription { get; set; }

        public abstract bool Status { get; set; }
    }
}