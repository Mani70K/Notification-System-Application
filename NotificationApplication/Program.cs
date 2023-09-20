using NotificationApplication.FacadePattern.Facade_Implementation;
using NotificationApplication.FacadePattern.Facade_Interface;
using System;

namespace NotificationApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" ---------------- Welcome To Notification Application -------------- ");
            Console.WriteLine();
            String Channel;
            String Subject;
            String Message;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Select Your Channel Type:-");
                Console.WriteLine();
                Console.WriteLine(" 1. Email \n 2. SMS \n 3. Exit");
                Console.WriteLine();
                Console.Write(" ");
                Channel = Console.ReadLine();
                Channel = Channel.ToLower().Trim();

                switch (Channel)
                {
                    case "1": case "email": case "2": case "sms":
                        while (true)
                        {
                            Console.Write("Enter Your Subject:-  ");
                            Subject = Console.ReadLine();
                            Subject = Subject.Trim();
                            if (Subject == "")
                            {
                                Console.WriteLine("Subject Must Not Be Blank. Try Again!!");
                                Console.WriteLine();
                            }
                            else
                            {
                                break;
                            }
                        }
                        while (true)
                        {
                            Console.Write("Enter Your Message:-  ");
                            Message = Console.ReadLine();
                            Message = Message.Trim();
                            if (Message == "")
                            {
                                Console.WriteLine("Message Must Not Be Blank. Try Again!!");
                                Console.WriteLine();
                            }
                            else
                            {
                                break;
                            }
                        }

                        Console.WriteLine();


                        //Singleton Pattern
                        IUserNotificationSystem userNotificationSystem =UserNotificationSystem.GetInstance();
                        userNotificationSystem.SendNotification(Channel,Subject,Message);




                        Console.WriteLine();
                        System.Environment.Exit(1);
                        break;

                    case "3": case "exit":
                        Console.WriteLine();
                        Console.WriteLine(" Thank You For Using This App ");
                        Console.WriteLine(" Hope You Like It! ");
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Please Select A Valid Channel");
                        break;

                }
            }
            
        }
    }
}
