using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {

                var inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                AddTrainers(trainers, inputArgs);
            }


            while ((input = Console.ReadLine()) != "End")
            {
                CheckPokemonElement(trainers, input);

            }

            trainers = trainers.OrderByDescending(t => t.Value.Badges).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in trainers)
            {

                Console.WriteLine($"{kvp.Key} {kvp.Value.Badges} {kvp.Value.Pokemons.Count}");
            }
        }

        private static void CheckPokemonElement(Dictionary<string, Trainer> trainers, string input)
        {
            foreach ((string name, Trainer trainer) in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == input))
                {
                    trainer.Badges++;
                }
                else
                {
                    trainer.Pokemons.ForEach(x => x.Health -= 10);
                    trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                }
            }
        }

        private static void AddTrainers(Dictionary<string, Trainer> trainers, string[] inputArgs)
        {
            var trainerName = inputArgs[0];
            var pokemonName = inputArgs[1];
            var pokemonElement = inputArgs[2];
            var pokemonHealth = int.Parse(inputArgs[3]);
            var currPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            if (!trainers.ContainsKey(trainerName))
            {

                var trainer = new Trainer(trainerName);
                trainers.Add(trainerName, trainer);
            }
            trainers[trainerName].Pokemons.Add(currPokemon);
        }
    }
}
