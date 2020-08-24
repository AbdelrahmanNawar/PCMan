namespace PCMan
{
    public class Enemy : IOcupant
    {
        public int Weapon { get; set; }


        public void EditPlayer(Player player)
        {
            _ = player.Health - Weapon;
        }
    }

}
