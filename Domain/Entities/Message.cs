﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("messages")]
    public class Message
    {
        [Key, Column("Id")]
        public int Id { get; set; }

        [Column("idsender")]
        public int IdSender { get; set; }

        [Column("isread")]
        public string IsRead { get; set; }

        [Column("text")]
        public string Text { get; set; }

        [Column("idfiles")]
        public int IdFiles { get; set; }

        [Column("time")]
        public DateTime Time { get; set; }

        [Column("idgroup")]
        public int IdGroup { get; set; }


        public ICollection<MessageFile> Files { get; set; }

        public Group Group { get; set; }

        public User User { get; set; }
    }
}