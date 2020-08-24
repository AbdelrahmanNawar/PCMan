using System.Collections.Generic;
using System.Threading;

namespace PCMan
{
    public class Player
    {
        public int Health { get; set; }
        public int Weapon { get; set; }

        public List<IKey> Keys { get; set; }

        private Player _Instance { get; set; }


        public Player GetInstance()
        {
            if (_Instance == null)
                _Instance = new Player();
            return _Instance;
        }


        private Player()
        {
            Keys = new List<IKey>();
            Health = 100;
            Weapon = 100; 
        }
    }


}
