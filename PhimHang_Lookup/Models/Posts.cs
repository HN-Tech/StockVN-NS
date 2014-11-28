using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PhimHang_Lookup.Models
{
    public class Posts
    {

        public Posts()
        {
            this.PostComments = new HashSet<PostComments>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PostsId { get; set; }

        [Required]
        [MaxLength(256)]
        public string Message { get; set; }

        public string IdentityUserId { get; set; } // khoa ngoai vs ApplicationUser

        public DateTime PostedDate { get; set; }

        public string ChartImage { get; set; }

        public Sentiment? Sentiment { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<PostComments> PostComments { get; set; }
    }

    public enum Sentiment
    {
        Norm, Bear, Bull

        // binh thuong, tang, giam
    }
            
}