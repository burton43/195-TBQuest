using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame.Models;

namespace TBQuestGame.DataLayer
{
    public static class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                GetID = 1,
                GetName = "Jessie",
                GetLocation = 1,
                Sex = Player.Gender.Man,
                GetScared = false
            };
        }

        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "You awaken with a throbbing headache."
            };
        }
    }
}
