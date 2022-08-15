using System.ComponentModel.DataAnnotations;
using WalletPlus.Web.Data.Entities;

namespace WalletPlus.Web.WebData.Entities
{
    public class Country : BaseEntities<Guid>
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(5)]
        public string continent { set; get; }

        [Required]
        [MaxLength(4)]
        public string zipCode { set; get; }
    }
    }

