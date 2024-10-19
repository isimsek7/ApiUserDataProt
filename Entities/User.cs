﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ApiUserDataProt.Entities
{
	public class User
	{
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

