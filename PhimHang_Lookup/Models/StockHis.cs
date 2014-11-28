using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PhimHang_Lookup.Models
{
    // luu gia hang ngay de ve bieu do CK
    public class StockHis
    {
        public StockHis() { }
        public StockHis(string name) { }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StockHisID { get; set; }

        [Required]
        [StringLength(16)]
        [Display(Name = "Mã chứng khoán")]
        public string Ticker { get; set; }

        public decimal Open { get; set; } // gia mo cua

        [Required]
        public decimal Close { get; set; } // dong cua

        public decimal High { get; set; } // cao

        public decimal Low { get; set; } // thap

        [Required]
        public decimal Ceiling { get; set; } // gia tran

        [Required]
        public decimal Floor { get; set; } // gia san

        [Required]
        public decimal Diff { get; set; } // giá tham chieu


    }
}