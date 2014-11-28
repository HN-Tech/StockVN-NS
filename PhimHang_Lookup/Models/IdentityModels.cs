using Microsoft.AspNet.Identity.EntityFramework;
//using System.Collections;
using System.Collections.Generic;

namespace PhimHang_Lookup.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() // contructor
        {
            this.PostComments = new HashSet<PostComments>();
            this.Posts = new HashSet<Posts>();

        }

        // extent property
        public string AvatarExt { get; set; } // avata image directory of ApplicationUser
        public virtual ICollection<Posts> Posts { get; set; }
        public virtual ICollection<PostComments> PostComments { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}