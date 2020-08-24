namespace PCMan
{
    class BronzeBox : Treasure
    {
        public IKey key = new BronzKey();
        public int Health = 20;
        public override void EditPlayer(Player player)
        {
            Health += player.Health;
        }
    }
}
