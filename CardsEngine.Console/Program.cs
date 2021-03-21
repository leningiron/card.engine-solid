﻿using CardsEngine.Console.Core;
using CardsEngine.Console.Core.Cards;
using CardsEngine.Console.Core.Model;
using System;
using System.Text.Json;

namespace CardsEngine.Consoles
{
    public class Program
    {
        static void Main(string[] args)
        {

            var engine = new CardEngine(null, new ProcessCardFactory(null), new Policy { Brand = "Visa", Amount = 500, 
                DeferPayment = Console.Core.Enums.DeferPaymentType.ThreeMonths });
            try
            {
                var response =  engine.CreatePayment();
                System.Console.WriteLine(JsonSerializer.Serialize(response));
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);

            }
            System.Console.ReadLine();
        }
    }
}