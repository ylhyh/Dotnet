using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSolution.VEntity
{
    public class User : BaseEntity
    {
        [Key]
        public int Id
        {
            get;
            set;
        }

        [System.ComponentModel.DataAnnotations.MaxLength(20), Required]
        public string UserId
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
        [System.ComponentModel.DataAnnotations.DataType(DataType.Text)]
        public string Nickname
        {
            get;
            set;
        }

        [EmailAddress]
        public string Email
        {
            get;
            set;
        }

        [Phone]
        public string MobilePhone
        {
            get;
            set;
        }
    }
}
