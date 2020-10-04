using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LongLH9Shop.Model.Abstract;

namespace LongLH9Shop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : AuditTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Post> Posts { set; get; }
        public override DateTime? CretedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string MetaKeyword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string MetaDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}