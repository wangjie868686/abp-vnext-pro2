﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CompanyName.ProjectName.DataDictionaryManagement.DataDictionaries.Dtos
{
    public class SetDataDictinaryDetailInput
    {
        [Required]
        public Guid DataDictionaryId { get; set; }

        [Required]
        public Guid DataDictionayDetailId { get; set; }

        [Required]
        public bool IsEnabled { get; set; }
    }
}