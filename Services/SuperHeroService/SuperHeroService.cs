using System;
using SuperHeroAPI.Models;
using SuperHeroAPI.Services.SuperHeroService;

namespace SuperHeroAPI.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero { Id = 1, Name = "Spider-Man", FirstName = "Peter", LastName = "Parker", Place = "New York City"},
                new SuperHero { Id = 2, Name = "Iron Man", FirstName = "Tony", LastName = "Stark", Place = "Malibu"}
            };

        public SuperHeroService()
        {
        }

        public List<SuperHero> AddSuperHero(SuperHero hero)
        {
            superHeroes.Add(hero);

            return superHeroes;
        }

        public List<SuperHero>? DeleteHeroById(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null)
                return null;

            superHeroes.Remove(hero);

            return superHeroes;
        }

        public List<SuperHero>? GetAllHeroes()
        {
            return superHeroes;
        }

        public SuperHero? GetSuperHeroById(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null)
                return null;

            return hero;
        }

        public List<SuperHero>? UpdateHeroById(int id, SuperHero request)
        {
            var hero = superHeroes.Find(x => x.Id == request.Id);
            if (hero == null)
                return null;

            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            hero.Name = request.Name;

            return superHeroes;
        }
    }
}

