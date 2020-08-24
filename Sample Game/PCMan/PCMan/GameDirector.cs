namespace PCMan
{
    class GameDirector
    {
        public Board Board { get; set; }

        public GameDirector()
        {
            Board = new Board();
        }
        public GameDirector(Board board)
        {
            Board = board; 
        }

        public void MovePlayer()
        {

        }


    }

    /// <summary>
    /// Abstract Strategy 
    /// </summary>
   

}
