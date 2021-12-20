﻿using System;


namespace ticTac
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Player player1 = new Player();
            Player player2 = new Player();
            Game myGame = new Game(player1, player2);
            Player winner = myGame.Play();
            if (winner != null)
            {
                Console.WriteLine($"{winner.Name} is the Winner as {winner.Marker}");
            } else
            {
                Console.WriteLine("Draw!!!");
            }
            
        }
    }
}
