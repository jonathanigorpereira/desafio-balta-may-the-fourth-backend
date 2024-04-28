﻿namespace Staris.Application.Shared.Requests;

public sealed record VehicleCreateRequest
(
	string Name,
	string Model,
	string Manufacturer,
	decimal Cost,
	decimal Lenght,
	decimal MaxSpeed,
	int Crew,
	int Passengers,
	decimal CargoCapacity,
	int Consumables,
	string Class
);
