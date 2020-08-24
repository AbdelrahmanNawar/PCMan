namespace PCMan
{
    class GameDirector
    {
        public Board Board { get; set; }
        private GameDirector _Instance { get; set; }


        public GameDirector GetInstance(Board board)
        {
            if (_Instance == null)
                _Instance = new GameDirector(board);
            return _Instance;
        }


        private GameDirector(Board board)
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
