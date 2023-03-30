using System;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero>? GetAllHeroes();

        SuperHero? GetSuperHeroById(int id);

        List<SuperHero> AddSuperHero(SuperHero hero);

        List<SuperHero>? UpdateHeroById(int id, SuperHero request);

        List<SuperHero>? DeleteHeroById(int id);
    }
}

