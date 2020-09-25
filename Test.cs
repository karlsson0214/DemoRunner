using System;

namespace DemoRunner
{
    class Test
    {
        public void Run()
        {
            Database db = new Database();

            Runner myRunner = new Runner();
            myRunner.name = "Ada";
            myRunner.distance = 100;
            myRunner.time = 15.3;

            db.AddRunner(myRunner);
            
            Runner myRunnerTwo = new Runner();
            myRunnerTwo.name = "Babbage";
            myRunnerTwo.distance = 400;
            myRunnerTwo.time = 73.9;

            db.AddRunner(myRunnerTwo);

            db.PrintRunners();
        }
    }
}