using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movina
{
    internal class Movie
    {
        private int id;
        private string name;
        private string description;
        private DateTime production;
        private int ageRate;
        private string genre;
        private int starRate;

        public int ID
        {
            get;
            private set;
        }
        public string Name
        {
            get;
            private set;
        }
        public string Description
        {
            get;
            private set;
        }
        public DateTime Production
        {
            get;
            private set;
        }
        public int AgeRate
        {
            get;
            private set;
        }
        public string Genre
        {
            get;
            private set;
        }
        public int StarRate
        {
            get;
            private set;
        }

        public Movie(int id, string name, string description, DateTime production, int ageRate, string genre, int starRate) { 
           
            ID = id;
            Name = name;
            Description = description;
            Production = production;
            AgeRate = ageRate;
            Genre = genre;
            StarRate = starRate;
        }
    }
}
