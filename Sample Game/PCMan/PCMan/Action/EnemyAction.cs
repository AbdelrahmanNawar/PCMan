using System;

namespace PCMan
{
    public class EnemyAction : IAction
    {
        public void Act(Player player, IOcupant ocupant)
        {
            if (ocupant is Enemy)
            {
                ocupant.EditPlayer(player);
            }
            else
            {
                throw new Exception("Not Enemy Object");
            }
        }
    }

}
