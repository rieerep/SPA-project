using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace game_spa.Models
{
    public class UserModel : IdentityUser
    {

        //[Key]
        //public int Id { get; set; }

        [Required, DisplayName("Name")]
        [MinLength(2, ErrorMessage = "The password must be minimum 4 characters long")]
        [MaxLength(25, ErrorMessage = "The password must be maximum 8 characters long")]
        public string Name { get; set; }

        public string Email { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "The password must be minimum 4 characters long")]
        [MaxLength(40, ErrorMessage = "The password must be maximum 8 characters long")]
        public string Password { get; set; }

        public int Wins { get; set; }

        public int Draws { get; set; }

        public int losses { get; set; }

        public int GamesPlayed { get; set; }

        public virtual GameModel Game { get; set; }
    }
}
