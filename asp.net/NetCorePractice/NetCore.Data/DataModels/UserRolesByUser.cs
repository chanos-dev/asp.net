using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NetCore.Data.DataModels
{
    public class UserRolesByUser
    {
        [Key, StringLength(12), Column(TypeName = "varchar(12)")]
        public string UserId { get; set; }

        [Key, StringLength(50), Column(TypeName = "varchar(50)")]
        public string RoleId { get; set; }

        [Required]
        public DateTime OwnedUtcDate { get; set; }

        public User User { get; set; }
        public UserRole UserRole { get; set; }
    }
}
