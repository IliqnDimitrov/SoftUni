﻿namespace Battleships.Ships
{
    using System;

    public class Warship : Battleship
    {

        public Warship(string name, double lengthInMeters, double volume)
            :base(name,lengthInMeters,volume)
        {
            
        }

        public override string Attack(Ship target)
        {
            this.DestroyTarget(target);
            return "Victory is ours!";
        }
    }
}
