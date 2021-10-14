using System;

namespace PragueParking1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] Spots = new string[100];
            for (int i = 0; i < Spots.Length; i++)
            {
                Spots[i] = "FREE";
            }
            bool valetParking = true;
            while (valetParking) 
            {
                Console.WriteLine(" What do you want to do?: ");
                Console.WriteLine(" [1] Park a vehicle: ");
                Console.WriteLine(" [2] Move a vehicle: ");
                Console.WriteLine(" [3] Search for a vehicle: ");
                Console.WriteLine(" [4] Remove a vehicle: ");
                Console.WriteLine(" [5] Quit the program: ");

                if (Int32.TryParse(Console.ReadLine(), out int menuChoice))
                {
                    int choice = Convert.ToInt32(menuChoice);

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(" Type of vehicle? ");
                            Console.WriteLine(" [1] CAR ");
                            Console.WriteLine(" [2] MC ");
                            string vehicle = Console.ReadLine();

                            switch (vehicle)
                            {
                                case "1":
                                    vehicle = "CAR";
                                    break;

                                case "2":
                                    vehicle = "MC";
                                    break;

                                default:
                                    Console.WriteLine("|ERROR| Pick a number of 1 or 2 ");
                                    break;
                            }
                            Console.WriteLine(" Registration number: ");
                            string registration = Console.ReadLine();
                            string NewCar = "";
                            string NewMC = "";
                            if (registration.Length > 10)
                            {
                                Console.WriteLine("|ERROR| Registration is to long try again ");
                                foreach (char CH in registration)
                                {
                                    if (!char.IsLetterOrDigit(CH))
                                    {
                                        Console.WriteLine(" ERROR please only use letters and numbers");
                                    }break;
                                }

                            }
                            
                                                        
                            if (vehicle == "CAR")
                            {
                                NewCar = vehicle + "  " + registration;
                                
                            }
                            else if (vehicle == "MC")
                            {
                                NewMC = vehicle + " " + registration;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("|ERROR|");
                                break;
                            }
                            string Onemc = "FREEMC";
                            
                            for (int v = 0; v < Spots.Length; v++)
                            {
                                if (Spots[v] == "FREE" && vehicle == "CAR")
                                {
                                    Spots[v] = NewCar;
                                    Console.WriteLine("Park the car at spot{0} ", v + 1);
                                    break;
                                }
                                else if (true == Spots[v].Contains(Onemc) && vehicle == "MC") 
                                {
                                    Console.WriteLine(" Park your vehicle at spot{0}", v +1);
                                    string[] StackMc = Spots[v].Split(Onemc, StringSplitOptions.RemoveEmptyEntries);
                                    foreach (string _mc in StackMc)
                                    {
                                        Spots[v] = _mc;
                                        break;
                                    }
                                    Spots[v] += "/" + NewMC;
                                    
                                    break;
                                }
                                else if (Spots[v] == "FREE" && vehicle == "MC")
                                {
                                    Spots[v] = NewMC + Onemc;
                                    Console.WriteLine("Park the bike at spot{0}", v + 1);
                                    break;
                                }
                            
                                
                                
                            }
                            break;


                    }
                        
                }          
                    
                        
                    
                
            }
            
        }
    }
}
