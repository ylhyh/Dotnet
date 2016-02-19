using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Demo.CodeFirst.Entities
{
    public class User
    {
        [Key]
        public int Id
        {
            get;
            set;
        }

        [MaxLength(20), Required]
        public string UserId
        {
            get;
            set;
        }

        [Required,StringLength(32)]
        public string Password
        {
            get;
            set;
        }
        [DataType(DataType.Text)]
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

        public virtual Group UserGroup
        {
            get; set;
        }
    }
}
