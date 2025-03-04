﻿namespace MassEffect.Engine.Commands
{
    using System;

    using MassEffect.Interfaces;
    using System.Linq;
    using MassEffect.Exceptions;

    public abstract class Command
    {
        protected Command(IGameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        public IGameEngine GameEngine { get; set; }

        public abstract void Execute(string[] commandArgs);

        public IStarship GetStarshipByName(string name)
        {
            return this.GameEngine.Starships.First(x => x.Name == name);
        }

        protected void ValidateAlive(IStarship ship)
        {
            if (ship.Health <= 0)
            {
                throw new ShipException(Messages.ShipDestroyed);
            }
        }
        
    }
}
