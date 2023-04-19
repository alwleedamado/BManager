﻿using BManager.Utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace BManager.Persons.Commands
{
    public class AddTelephoneCommand
    {
        [Required]
        public string TelephoneNumber { get; set; }
        public Guid PersonId { get; set; }
        [Required]
        public PhoneType PhoneType { get; set; }
    }
}
