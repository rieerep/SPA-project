using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace game_spa.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public int Score { get; set; }
        
        [ForeignKey("UserModel")]
        public int UserId { get; set; }

        [DisplayName("Games played")]
        public int GamesPlayed { get; set; }

        public virtual IEnumerable<UserModel> User { get; set; }

    }
}
