using System.Security.Cryptography;

namespace Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            
            int rzahl = rnd.Next(1,100);
            int Rateversuche = 0;
            bool zGefunden = false;
            int ezahl;
            zurück:
           
            



            while (!zGefunden) 
            {
                Console.Write("Zahl zwischen 1 und 100 eingeben: ");
                ezahl = Convert.ToInt32(Console.ReadLine());



                try
                    {
                        ezahl = Convert.ToInt32(Console.ReadLine());
                    
                    }

                    catch
                    {
                        Console.WriteLine("Ich habe das nicht verstanden. Bitte eine Zahl eingeben.");//Keine Fehlangaben(z.B Buschstaben)
                    
                    }



                    if (ezahl > 100)
                    {
                        Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 100 ein.");//Keine Fehlangaben(zwischen 1 und 100)
                    goto zurück;

                    }

                    else if (ezahl < 1)
                    {
                        Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 100 ein.");//Keine Fehlangaben(zwischen 1 und 100)
                    goto zurück;
                    }
                    
                

              

                
               
                
                if (ezahl < rzahl)
                {
                    Console.WriteLine("Deine Zahl ist zu niedrig.\n");
                    Rateversuche++;
                }
                else if (rzahl < ezahl)
                    {
                        Console.WriteLine("Deine Zahl ist zu hoch.\n");//Zahl grösser oder kleiner als die randomzahl ?
                        Rateversuche++;
                    }

                    else if (ezahl == rzahl)
                    {
                        Rateversuche++;
                        Console.WriteLine("Du hast die richtige Zahl erraten! (" + rzahl + ")\n");//ezahl ist gleich wie rzahl und Rateversuche werden angezeigt.
                        Console.WriteLine("Du hast "  + Rateversuche +  " Versuche gebraucht");
                        zGefunden = true;
                    }
                }
                 
                
                

            }

             




        }
    }
