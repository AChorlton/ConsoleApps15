using System;
using System.Collections.Generic;
using System.Text;

    /// <author>
    /// Alex Chorlton
    /// 100174372
    /// </author>

namespace ConsoleAppProject.App05
{
    public class GameView
    {
        private Game game;

        /// <summary>
        /// Controls the events in eacj round of
        /// the game, and repeats until the game is ended by the player
        /// </summary>
        public void Play()
        {
            bool wantToQuit = true;

            do
            {
                StartGame();
                
                GetPlayerChoice();
                DisplayChoice(game.Human.Choice);
                
                game.MakeComputerChoice();
                DisplayChoice(GameChoices.Scissors);

                game.ScoreRound();

                if(game.Round == game.LastRound)
                {
                    Console.WriteLine();

                }

            } while (!wantToQuit);
        }

        public void StartGame()
        {
            SetupConsole();

            ConsoleHelper.OutputHeading("  Rock-Paper-Scissors ");

            if(game == null)
            {
                Console.Write(" Please enter your name > ");
                string name = Console.ReadLine();

                game = new Game("Alex");
            }

            game.Start();
        }

        private void DisplayChoice(GameChoices choice)
        {
            if(choice == GameChoices.Scissors)
            {
                GameImages.DrawScissors(10, 10);
            }
        }

        private void GetPlayerChoice()
        {
        }
           
        private void SetupConsole()
        {
            Console.SetWindowSize(100, 40);
            Console.SetBufferSize(100, 40);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Clear();
        }
    }
}


        


