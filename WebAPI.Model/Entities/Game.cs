using System;
using System.Collections.Generic;

namespace WebAPI.Model.Entities
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BetStartDate { get; set; }
        public DateTime BetEndDate { get; set; }
        public string GameState { get; set; }
        public List<Bet> Bets { get; set; } = new List<Bet>();

    }
}
