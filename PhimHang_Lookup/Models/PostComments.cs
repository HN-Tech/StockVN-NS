using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PhimHang_Lookup.Models
{
    public class PostComments
    {

        public PostComments() // contructor
        {

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long PostCommentsId { get; set; }

        [Required]
        public long PostsId { get; set; } // khoa ngoai vs posts

        [Required]
        [MaxLength(256)]
        public string Message { get; set; }

        [Required]
        public int CommentedBy { get; set; } // khoa ngoai vs ApplicationUser

        [Required]
        public DateTime CommentedDate { get; set; }


        public virtual Posts Post { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}