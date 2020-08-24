using System;

namespace PCMan
{
    public class KeyAction : IAction
    {
        public void Act(Player player, IOcupant ocupant)
        {
            if (ocupant is Enemy)
            {
                ocupant.EditPlayer(player);
            }
            else
            {
                throw new Exception("Not Key Object");
            }
        }
    }

}
