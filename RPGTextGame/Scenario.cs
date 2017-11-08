using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGTextGame
{
    //ToDo: Decide between Scenario and Zone/Area
    class Scenario //a place of the world 
    {
        Scenario[,] scenario;
        //ToDo: An idea: When a scenario creates the constructor makes a Array of itself
        public Scenario(int x, int y)//The constructor should initialize the scenario matrix with the desired components NOTE:: x are rows , y are columns
        {
            this.scenario = new Scenario[x, y];
        }
        //What components should a scenario have?
    }
}
