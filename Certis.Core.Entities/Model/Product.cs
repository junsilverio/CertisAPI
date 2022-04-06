using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Product
    {
        public Product()
        {
            BankOrderDetails = new HashSet<BankOrderDetail>();
            CollectionBoxDenos = new HashSet<CollectionBoxDeno>();
            CollectionOrderDetails = new HashSet<CollectionOrderDetail>();
            CustomerProducts = new HashSet<CustomerProduct>();
            MasdepositOrderDetails = new HashSet<MasdepositOrderDetail>();
            MasdepositOrders = new HashSet<MasdepositOrder>();
            MasformsSettings = new HashSet<MasformsSetting>();
            OrderDetailFromMas = new HashSet<OrderDetailFromMa>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductAttributeValues = new HashSet<ProductAttributeValue>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductType { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public decimal? Value { get; set; }

        public virtual ICollection<BankOrderDetail> BankOrderDetails { get; set; }
        public virtual ICollection<CollectionBoxDeno> CollectionBoxDenos { get; set; }
        public virtual ICollection<CollectionOrderDetail> CollectionOrderDetails { get; set; }
        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; }
        public virtual ICollection<MasdepositOrderDetail> MasdepositOrderDetails { get; set; }
        public virtual ICollection<MasdepositOrder> MasdepositOrders { get; set; }
        public virtual ICollection<MasformsSetting> MasformsSettings { get; set; }
        public virtual ICollection<OrderDetailFromMa> OrderDetailFromMas { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }
    }
}
