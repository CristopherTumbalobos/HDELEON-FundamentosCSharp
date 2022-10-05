using FundamentosCSHARP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Linq;
using FundamentosCSHARP.Service;
using FundamentosCSHARP.Errors;

namespace FundamentosCSHARP
{
    static class Program
    {
        public class Beer
        {
            public string Name { get; set; }
            public int Alcohol { get; set; }
        }

        static void Main(string[] args)
        {
            //PREDICATE: Implementacion de los delegados, parecido a Func o Action. Sentencia que regresa TRUE o FALSE. Permite guardar condiciones, o la lógica.

            //var numbers = new List<int> { 1, 56, 2, 3, 3, 45, 6 };
            //var predicate = new Predicate<int>(x => x % 2 == 0);
            //Predicate<int> negativePredicate = x => !predicate(x);
            //var dividers2 = numbers.FindAll(negativePredicate);
            //dividers2.ForEach(d => { Console.WriteLine(d); });

            var beers = new List<Beer>()
            {
                new Beer() {Name = "Ipa", Alcohol = 7},
                new Beer() {Name = "Pale Ale", Alcohol = 8},
                new Beer() {Name = "Stout", Alcohol = 9},
                new Beer() {Name = "Tripel", Alcohol = 15}
            };

            beers.ShowBeerThatIGetDrunk(x => x.Alcohol >= 8 && x.Alcohol<15);
        }

        //THIS: Para realizar una extension, para esto el "Program" debe ser static porque el "Where" proviene de una clase static
        static void ShowBeerThatIGetDrunk(this List<Beer> beers, Predicate<Beer> condition)
        {
            var evilBeers = beers.FindAll(condition);
            //beers.Where<>();
            evilBeers.ForEach(d => Console.WriteLine(d.Name));
        }
    }
}
