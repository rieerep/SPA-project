using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace game_spa.Models
{
    public class GameModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserModel")]    //Try if this is even necessary
        public Guid UserId { get; set; }

        public int Score { get; set; }

        public bool Win { get; set; }

        public bool Draw { get; set; }

        public bool Lose { get; set; }

        [DisplayName("Games played")]
        public int GamesPlayed { get; set; }

        public virtual IEnumerable<UserModel> User { get; set; }

    }
}
