using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace game_spa.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int Score { get; set; }
        [ForeignKey("User")]
        public int FkUser { get; set; }

        [DisplayName("Games played")]
        public int GamesPlayed { get; set; }
        public virtual User User { get; set; }

    }
}
