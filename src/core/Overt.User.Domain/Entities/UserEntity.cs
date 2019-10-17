﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Overt.User.Domain.Entities
{
    [Table("User")]
    public class UserEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string RealName { get; set; }
        public string Password { get; set; }
        public DateTime AddTime { get; set; }
        public bool IsSex { get; set; }
        [Column("other_info")]
        public string OtherInfo { get; set; }
    }

}
