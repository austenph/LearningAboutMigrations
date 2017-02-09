﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LearningAboutMigrations.Models
{
    public class GameScore
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
    }
}