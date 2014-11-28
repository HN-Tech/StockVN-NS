using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PhimHang_Lookup.Models
{
    public class Settings
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SettingsID { get; set; }

        [Required]
        [MaxLength(50)]
        public string SettingName { get; set; }

        [Required]
        [MaxLength(256)]
        public string SettingValue { get; set; }

    }
}