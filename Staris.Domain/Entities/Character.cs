﻿using Staris.Domain.Common;
using System.Collections;

namespace Staris.Domain.Entities;

public sealed class Character : Entity
{
    public string Name { get; set; } = string.Empty;
    public decimal BirthYear { get; set; }
    public string BirthYearPeriod { get; set; } = string.Empty;
    public short Gender { get; set; }
    public string Mass { get; set; } = string.Empty;
    public string Height { get; set; } = string.Empty;
    public string EyeColor { get; set; } = string.Empty;
    public string SkinColor { get; set; } = string.Empty;
    public string HairColor { get; set; } = string.Empty;
    public int HomeWorldId { get; set; }


    //EF Relation
    public Planet? HomeWorld { get; init; }

    public List<CharacterFilm>? Movies{ get; init; }

}
