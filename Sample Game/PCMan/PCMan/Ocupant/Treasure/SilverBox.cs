namespace PCMan
{
    class SilverBox : Treasure
    {
        public IKey key = new SilverKey();
        public int Health = 10;
        public int Weapon = 40;
        public override void EditPlayer(Player player)
        {
            Health += player.Health;
            Weapon += player.Weapon;
        }
    }
}
