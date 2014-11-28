using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PhimHang_Lookup.Models
{
    public class StockCode
    {
        public StockCode()
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StockCodeID { get; set; }

        [StringLength(16, MinimumLength = 3)]
        [Display(Name = "Mã chứng khoán")]
        public String Ticker { get; set; }

        [StringLength(500)]
        [Display(Name = "Tên dài")]
        public string ShortName { get; set; }

        [StringLength(500)]
        [Display(Name = "Tên ngắn")]
        public string Name { get; set; }

        [Display(Name = "Sàn")]
        public ExchangeID? ExchangeID { get; set; }

    }

    public enum ExchangeID
    {
        HOSE,HNX
    }
}