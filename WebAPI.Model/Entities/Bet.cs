using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Model.Entities
{
    public class Bet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Score { get; set; }
        public int GameID { get; set; }
        public Game Game { get; set; }
    }
}
