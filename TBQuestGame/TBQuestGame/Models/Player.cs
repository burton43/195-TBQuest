using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public class Player : Character
    {
        public bool _scared;

        public bool GetScared
        {
            get { return _scared; }
            set { _scared = value; }
        }



        public override string Greeting()
        {
            

            return $"My name is {_name} and I don't remember how I got here.";
        }
    }
}
