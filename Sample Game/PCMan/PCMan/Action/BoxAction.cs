using System;

namespace PCMan
{
    public class BoxAction : IAction
    {
        public void Act(Player player, IOcupant ocupant)
        {
            if (ocupant is Treasure)
            {
                ocupant.EditPlayer(player);
            }
            else
            {
                throw new Exception("Not Treasure Object");
            }
        }
    }

}
