using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    #region snippet1
    public class Contact
    {
        public int ContactId { get; set; }

        // user ID from AspNetUser table.
        public string? OwnerID { get; set; }

        [DisplayName("Имя")]
        public string? Name { get; set; }
        [DisplayName("Адрес")]
        public string? Address { get; set; }
        [DisplayName("Город")]
        public string? City { get; set; }
        [DisplayName("Улица")]
        public string? State { get; set; }
        [DisplayName("Почтовый индекс")]
        public string? Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        [DisplayName("Майл")]
        public string? Email { get; set; }
        [DisplayName("Статус")]
        public ContactStatus Status { get; set; }
    }

    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
    #endregion
}
