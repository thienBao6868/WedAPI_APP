using System.ComponentModel.DataAnnotations;

namespace WedAPI_APP.Data
{
    public class Merchandise
    {
        [Key]   
        public virtual Guid MerchandiseCode { get; set; }

        [Required]
        [MaxLength(100)]
        public virtual string MerchandiseName { get; set; } = String.Empty;

        public virtual string MerchandiseDescription { get; set; } = String.Empty;

        [Range(0,double.MaxValue)]
        public virtual double MerchandisePrice { get; set; }

        public virtual byte MerchandiseDiscuss { get; set; }

    }
}
