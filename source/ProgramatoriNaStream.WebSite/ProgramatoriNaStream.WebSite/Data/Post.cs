using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProgramatoriNaStream.WebSite.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Post
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string BodyHtml { get; set; }

        public DateTime DateCreated { get; set; }

        public string YoutubeVideoLink { get; set; }

        public ApplicationUser UserCreated { get; set; }

        //public Guid UserCreatedId { get; set; }
    }
}
