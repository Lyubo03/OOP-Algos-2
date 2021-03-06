﻿namespace MilitaryElite.Classes
{
    using Interfaces;

    public abstract class Soldier : ISoldier
    {
        public Soldier(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Id { get; private set; }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}";
        }
    }
}