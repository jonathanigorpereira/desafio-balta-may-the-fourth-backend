﻿using Staris.Domain.Common;

namespace Staris.Domain.Entities;

public sealed class Film : Entity
{
    public string Title { get; set; } = string.Empty;
    public int Episode { get; set; }
    public string OpeningCrawl { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public string Producer { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }


    //EF Relation
	public List<CharacterFilm>? Characters { get; init; }
    public List<PlanetFilm>? Planets { get; init; }
    public List<FilmVehicle>? Vehicles { get; init; } //Filtrar somento os Vehicle.Type == Vehicle
	public List<FilmVehicle>? Starships { get; init; } //Filtrar somento os Vehicle.Type == Starthip

}
