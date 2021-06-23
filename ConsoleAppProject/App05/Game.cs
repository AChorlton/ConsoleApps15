using System;
using System.Collections.Generic;
using System.Text;

/// <author>
/// Alex Chorlton
/// 100174372
/// </author>

namespace ConsoleAppProject.App05
{

    public class Game
    {
        public const int MAXIMUM_ROUND = 10;

        public int Round { get; set; }

        public int LastRound { get; set; }

        public Player Human { get; }

        public Player Computer { get; }

        public Player CurrentPlayer { get; set; }

        public Player Winner { get; set; }

        private Random generator = new Random(55);
