namespace PCMan
{
    internal class GoldBox : Treasure
    {
        public IKey key = new GoldKey();
        public int Health = 50;
        public int Weapon = 10;

        public override void EditPlayer(Player player)
        {
            Health+= player.Health; 
        }

    }
}
