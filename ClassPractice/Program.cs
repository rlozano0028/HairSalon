using System;
using System.Drawing;
using System.Security.Cryptography;

namespace ClassPractice
{
    class Program
    {
        class Person
        {
            string Name;
            string HairColor;
            string HairStyle;
            int HairLength;


            public Person(string Name, string HairColor, string HairStyle, int HairLength)
            {
                this.Name = Name;
                this.HairColor = HairColor;
                this.HairStyle = HairStyle;
                this.HairLength = HairLength;
            }
            public string GetName()
            {
                return Name;
            }

            public string GetColor()
            {
                return HairColor;
            }

            public string GetStyle()
            {
                return HairStyle;
            }
            public int GetHairLength()
            {
                return HairLength;
            }

            public override string ToString()
            {
                return $"{Name}, HairColor:{HairColor}, HairStyle{HairStyle}, HairLength{HairLength}";
            }


        }





        static void Main(string[] args)
        {


            //create an Account class with a username and password
            //inside of the class create a function called CheckLogin that takes in two strings and checks if they match the username and password or not

            //in main:
            //create an array of 3 accounts
            //ask the user to enter a username and password
            //check if they logged in using the CheckLogin function in each account
            //Account[] Accounts = new Account[3];
            //Accounts[0] = new Account("epic","gamer" );
            //Accounts[1] = new Account("super", "star");
            //Accounts[2] = new Account("mine", "craft");

            //bool login = true;
            //while(login == true)
            //{
            //    Console.WriteLine("enter in the Username for your account");
            //    string UserCheck = Console.ReadLine();
            //    Console.WriteLine($"eneter in the pass word for {UserCheck}");
            //    string PassCheck = Console.ReadLine();
            //    for (int i = 0; i < Accounts.Length; i++)
            //    {
            //        if (Accounts[i].checkLogin(UserCheck, PassCheck) == true)
            //        {
            //            Console.WriteLine($"You logged into {UserCheck}");
            //            login = false;
            //        }

            //    }
            //        if(login == true)
            //        {
            //            Console.WriteLine("Username or Password was wrong.");
            //        }

            //}



            //Hair Salon:
            //Have a class for the person.
            //The class should have a Name, Hair Color, Hair Style, Hair Length
            //Get functions and Set functions

            //in main:
            //Create an array of 5 people
            //Ask the user which person they want to change
            //Display all the information about person
            //Ask the user what they want to change and what they will change it to
            //Keep repeating until the user doesn't want to change anyone and display all the information when you exit

            bool removePerson = false;
            bool changing = true; 
            string change = "";
            string ColorChange = "";
            int LengthChange = 0;
            string StyleChange = "";
            int ask = 0;
            Person[] People = new Person[5];
            People[0] = new Person("Alan", " Black ", " Bowl ", 4);
            People[1] = new Person("Zach", " Blond ", " rough ", 3);
            People[2] = new Person("Isabella", " Brown ", " wavy ", 6);
            People[3] = new Person("Hannah", " Brown ", " strait ", 5);
            People[4] = new Person("Juan", " Brown ", " flat ", 3);

            
                for (int a = 0; a < 5 ; a++)
                {


                    
                
                for (int l = 0; l < People.Length; l++)
                {
                    Console.WriteLine($"{l+1}.) {People[l]}");
                }
                Console.WriteLine();
                
                ask = 0;
                changing = true;
                Console.WriteLine("Who would you like to work with?");
                int user = int.Parse(Console.ReadLine()) - 1;
                while(user < 0 || user > People.Length)
                {
                    Console.WriteLine("please enter a valid user");
                    user = int.Parse(Console.ReadLine());
                }    
                while (changing == true)
                {
                    
                            if (ask == 0)
                            {
                                Console.WriteLine($"what would you like to change about {People[user].GetName()} ");
                                
                                Console.WriteLine("");
                                Console.WriteLine(People[user].ToString());
                                change = Console.ReadLine();
                            }
                            else if (ask >= 1)
                            {
                                Console.WriteLine($"Would you like to move on to the next customer or continue with {People[user].GetName()}");
                                string answer = Console.ReadLine();
                                if (answer == "next customer")
                                {
                                    changing = false;
                                    answer = "";
                                    removePerson = true;
                            if (removePerson == true)
                            {
                                Person[] RemovePeople = new Person[People.Length - 1];

                                int count = 0;
                                for (int i = 0; i < People.Length; i++)
                                {
                                    if (i != user)
                                    {
                                        RemovePeople[count] = People[i];
                                        count++;
                                    }
                                }

                                People = RemovePeople;
                                removePerson = false;
                            }
                            
                    
                                    break;


                                }
                                else if (answer == "continue")
                                {
                                    answer = "";
                                    ask = 0;
                                }
                            }



                            if (change == "Hair Color")
                            {
                                Console.WriteLine("what color would you like to change it to?");
                                ColorChange = Console.ReadLine();
                                People[user] = new Person(People[user].GetName(), ColorChange, People[user].GetStyle(), People[user].GetHairLength());
                                Console.WriteLine($"{People[user].GetName()} now has {ColorChange} hair.");
                                Console.WriteLine();
                                ask++;
                                change = "";



                            }
                            else if (change == "Hair Length")
                            {
                                Console.WriteLine("How long do you want their hair to be?");
                                LengthChange = int.Parse(Console.ReadLine());
                                People[user] = new Person(People[user].GetName(), People[user].GetColor(), People[user].GetStyle(), LengthChange);
                                Console.WriteLine($"{People[user].GetName()}'s Hair has a Length of {LengthChange}");
                                Console.WriteLine();
                                ask++;
                                change = "";
                            }
                            else if (change == "Hair Style")
                            {
                                Console.WriteLine("What stlye would you like them to have?");
                                StyleChange = Console.ReadLine();
                                People[user] = new Person(People[user].GetName(), People[user].GetColor(), StyleChange, People[user].GetHairLength());
                                Console.WriteLine($"{People[user].GetName()} now has a {StyleChange} Style of hair");
                                Console.WriteLine();
                                ask++;
                                change = "";
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("You can change the Hair Length, Hair Color, or HairLength change one of them");
                                Console.WriteLine();
                                change = "";
                                
                            }
                            Console.WriteLine($"This is what {People[user].GetName()} looks like now");
                            Console.WriteLine(People[user].ToString());

                        


                       
                    }

                }
            Console.WriteLine("You have no more customers.");
            Console.WriteLine("You can now go home.");

            }
        }
    }


