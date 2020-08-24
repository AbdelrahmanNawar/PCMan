namespace PCMan
{
    public class GoldKey : IKey, IOcupant
    {
        public void EditPlayer(Player player)
        {
            player.Keys.Add(this);
        }
    }
}