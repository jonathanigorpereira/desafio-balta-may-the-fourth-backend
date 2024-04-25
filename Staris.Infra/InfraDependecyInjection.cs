﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Staris.Application.Data;
using Staris.Domain.Interfaces.Repositories;
using Staris.Infra.Data;
using Staris.Infra.Repositories;

namespace Staris.Infra;

public static class InfraDependecyInjection
{
    /// <summary>
    /// Responsável por adicionar as dependências a serem resolvidas no projeto de infra
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddInfraDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddSqlite<ApplicationDbContext>(configuration.GetConnectionString("StarisDB"),null, Opt => Opt.UseSqlite(connectionString: "StarisDB"));
        SQLitePCL.Batteries.Init();

        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

		services.AddScoped<ICharacterFilmRepository, CharacterFilmRepository>();
		services.AddScoped<ICharacterRepository, CharacterRepository>();
		services.AddScoped<IFilmRepository, FilmRepository>();
		services.AddScoped<IFilmVehicleRepository, FilmVehicleRepository>();
		services.AddScoped<IPlanetCharacterRepository, PlanetCharacterRepository>();
		services.AddScoped<IPlanetFilmRepository, PlanetFilmRepository>();
		services.AddScoped<IPlanetRepository, PlanetRepository>();
		services.AddScoped<IStarshipRepository, StarshipRepository>();
		services.AddScoped<IVehicleRepository, VehicleRepository>();

		return services;
    }

}
