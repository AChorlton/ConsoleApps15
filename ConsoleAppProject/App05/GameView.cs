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

