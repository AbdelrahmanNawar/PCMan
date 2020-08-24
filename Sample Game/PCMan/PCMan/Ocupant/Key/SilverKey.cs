namespace PCMan
{
    public class SilverKey : IKey, IOcupant
    {

        public void EditPlayer(Player player)
        {
            player.Keys.Add(this); 
        }
    }
}