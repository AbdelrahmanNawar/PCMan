﻿namespace PCMan
{
    public class BronzKey : IKey, IOcupant
    {
        public void EditPlayer(Player player)
        {
            player.Keys.Add(this);
        }
    }
}