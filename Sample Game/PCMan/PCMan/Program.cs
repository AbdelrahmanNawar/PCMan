using Json.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
//using System.Text.Json;
//using System.Text.Json.Serialization;

namespace PCMan
{
    class Program
    {
        static void Main(string[] args)
        {

            Enemy enemy = new Enemy() { Weapon = 50 };
            GoldBox goldBox = new GoldBox();
            GoldKey goldKey = new GoldKey();
            SilverKey silverKey = new SilverKey();
            BronzKey bronzKey = new BronzKey();

            Cell cell1 = new Cell(enemy); 
            Cell cell2 = new Cell(goldKey); 
            Cell cell3 = new Cell(goldBox); 
            Cell cell4 = new Cell();
            Cell[,] cells = new Cell[,] {
                { cell4, cell1, cell3 },
                { cell2, cell4, cell2 },
                
            };

            Player player = new Player();
            player.Keys.Add(silverKey);
            player.Keys.Add(goldKey);
            player.Keys.Add(bronzKey);

            Board board = new Board(cells);
            board.Player = player;
            GameDirector gameDirector = new GameDirector(board);
            Console.WriteLine("hhhhhhhhhhh");


            JsonSerializer serializer = new JsonSerializer();

            var petJson = JsonNet.Serialize(gameDirector);
            Console.WriteLine(petJson);
        
            File.WriteAllText(@"P:\Intro Work Shop\Sample Game\PCMan\PCMan\json.json", petJson);
            var jsonString = File.ReadAllText(@"P:\Intro Work Shop\Sample Game\PCMan\PCMan\json.json");

            Console.WriteLine($"Read From File:\n{jsonString}");
            var pet = JsonNet.Deserialize<GameDirector>(jsonString);
            Console.WriteLine($"after Deserialization:\n{pet}");
            //JsonSerializer.Deserialize<GameDirector>(jsonString);
            //IOcupant ocupant = new Enemy() { Weapon = 100 };

            //Cell[,] cells = new Cell[,] { 
            //    { new Cell(ocupant), new Cell(ocupant), new Cell(ocupant) }, 
            //    { new Cell(ocupant), new Cell(ocupant), new Cell(ocupant) }
            //};
            //Board board = new Board(cells);
            //foreach (var item in cells)
            //{
            //    if (item._ocupant is Enemy e)
            //    {
            //        Console.WriteLine($"----{ e.Weapon.ToString()}");
            //    }
            //}
            Console.WriteLine("Hello World!");
        }



        //public async void WriteToFile(Game game)
        //{
        //    using (FileStream fs = File.Create("GameLevels"))
        //    {
        //        await JsonSerializer.SerializeAsync<Game>(fs,game);
        //    }
        //}
    }

    /// <summary>
    /// Abstract Strategy 
    /// </summary>
   

}
