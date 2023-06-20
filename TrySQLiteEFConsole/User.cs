﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrySQLiteEFConsole
{
    public class User
    {
        [Column("Id")]
        // 自動付番を行わないようにできる
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}
