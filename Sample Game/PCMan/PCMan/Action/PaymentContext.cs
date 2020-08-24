namespace PCMan
{
    public class PaymentContext
    {
        private IAction Action;
        // The user will set the PaymentStrategy by 
        // calling this method at runtime
        public void SetAction(IAction action)
        {
            this.Action = action;
        }
        public void Pay(Player player, IOcupant ocupant)
        {
            Action.Act(player, ocupant);
        }
    }

}
