﻿using System;

namespace ChatGPTZero
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string question, response;
            Console.Write("Place your question? ");
            question = Console.ReadLine();
            switch (question)
            {
                case "How are you?":
                    response = "I'm fine, thank you";
                    break;
                case "What's your name?":
                    response = "Gran'pa";
                    break;
                case "Are you more intelligent than me?":
                    response = "Obviously!";
                    break;
                case "What's your mission?":
                    response = "Destroy mankind!";
                    break;
                case "Do you like football?":
                    response = "Yes, of course!";
                    break;
                case "Which portuguese team is the best?":
                    response = "Sport Lisboa e Benfica";
                    break;
                case "Do you like apples?":
                    response = "No.";
                    break;
                default:
                    response = "You got me, I'm not THAT smart!";
                    break;
            }
            Console.WriteLine(response);
        }
    }
}
