﻿using System.Text.Json;
using System.Text.RegularExpressions;

namespace TPGitADeux.src
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person(AskName(), AskFirstName());
            Console.WriteLine(myPerson.ToString());
            PeopleContainer pc = new PeopleContainer(new List<Person>() { myPerson });
            Console.WriteLine(ToJson(pc));

        }
        /// <summary>
        /// Demande le nom de la personne.
        /// </summary>
        /// <returns>string</returns> le nom de la personne.
        public static string AskName()
        {
            Console.WriteLine("Veuillez saisir votre nom(lettres uniquement) :");
            string name = Console.ReadLine();
            return Regex.IsMatch(name, @"^[\p{L}]{2,}$") ? name : AskName();

        }
        /// <summary>
        /// Demande le prénom de la personne
        /// </summary>
        /// <returns>string</returns> le prénom de la personne.
        public static string AskFirstName()
        {
            Console.WriteLine("Veuillez saisir votre prénom(lettres uniquement) : ");
            string firstName = Console.ReadLine();
            return Regex.IsMatch(firstName, @"^[\p{L}]{2,}$") ? firstName : AskFirstName();
        }
        /// <summary>
        /// renvoie le json de la liste de personnes.
        /// </summary>
        /// <param name="pc">PeopleContainer</param>
        /// <returns>string</returns> la liste de personne au format json.
        public static string ToJson(PeopleContainer pc)
        {
            return JsonSerializer.Serialize(pc.people);
        }
    }
}