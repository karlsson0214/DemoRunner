using System;

namespace DemoRunner
{
    class Runner
    {
        public String name;
        // time in seconds
        public double time;
        // distance in meter
        public int distance; 


        public void Print()
        {
            Console.WriteLine(name + " " + time + " sekunder, " 
            + distance + "meter");
        }
        
    }
}