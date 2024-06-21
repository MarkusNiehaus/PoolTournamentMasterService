using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Models
{
    public class Match
    {
        public Guid Id { get; set; }
        public Guid Player1Id { get; set; }
        public Guid Player2Id { get; set; }
        public DateTime MatchDate { get; set; }
        public string Result { get; set; }

        [ForeignKey("Player1Id")]
        public Player Player1 { get; set; }

        [ForeignKey("Player2Id")]
        public Player Player2 { get; set; }
    }
}
