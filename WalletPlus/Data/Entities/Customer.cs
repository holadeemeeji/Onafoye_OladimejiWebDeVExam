using WalletPlus.Data.Entities;
using WalletPlus.Web.Data.Entities;

namespace WalletPlus.Web.WebData.Entities
{
    public class Customer : BaseEntities<Guid>
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string MiddleName { set; get; }
        public Enum Gender { set; get; }
        public MaritalStatus MaritalStatus { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Country { set; get; }
        public string State { set; get; }
        public string City { set; get; }
        public bool Active { set; get; }
    }
}
