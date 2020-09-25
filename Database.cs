using System;
using System.Collections.Generic;


namespace DemoRunner
{
    class Database
    {
        List<Runner> runners = new List<Runner>();
        public void AddRunner(Runner myRunner)
        {
            runners.Add(myRunner);
        }

        public void PrintRunners()
        {
            foreach(Runner myRunner in runners)
            {
                myRunner.Print();
            }
        }
    }

    
}