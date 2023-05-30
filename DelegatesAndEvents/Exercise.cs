using System;

namespace DelegatesAndEvents
{
    public static class Exercise
    {
        public static void Run()
        {
            var trainStation = new TrainStation();
            trainStation.CreateTrain();
        }
    }

    class TrainStation 
    { 
        delegate int Train();
        
        int Wagon1() 
        { 
            Console.WriteLine("wagon1 is running"); 
            return 1; 
        } 
        int Wagon2() 
        { 
            Console.WriteLine("wagon2 is running"); 
            return 2; 
        } 
        public void CreateTrain() 
        { 
            Train train = Wagon1; 
            train += Wagon2;
            train += () => 
            { 
                Console.WriteLine("wagon3 is running"); 
                return 3; 
            }; 
            Console.WriteLine("WagonNumber:" + train()); 
        }
    }
}