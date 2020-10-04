using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LongLH9Shop.Model.Abstract;

namespace LongLH9Shop.Model.Models
{
    [Table("Pages")]
    public class Page : AuditTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { set; get; }
        public override DateTime? CretedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}