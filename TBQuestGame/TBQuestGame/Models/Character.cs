using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    public abstract class Character
    {

        public enum Gender
        {
            Man, Woman
        }

        public string _name;

        public string GetName
        {
            get { return _name; }
            set { _name = value; }
        }
        public int _id;

        public int GetID
        {
            get { return _id; }
            set { _id = value; }
        }

        public int _locationId;

        public int GetLocation
        {
            get { return _locationId; }
            set { _locationId = value; }
        }

        public Gender _gender;

        public Gender Sex
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public virtual string Greeting()
        {
            return $"*Silence*";
        }


        public Character()
        {

        }

        public Character(string Name, int ID, int Location)
        {
            _name = Name;
            _id = ID;
            _locationId = Location;
            
        }
    }
}
