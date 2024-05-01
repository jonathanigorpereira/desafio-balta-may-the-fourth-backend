﻿using Staris.Domain.Common;
using Staris.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staris.Domain.Interfaces.Repositories
{
	public interface IFilmRepository : IRepository<Film>
	{
		Task<IEnumerable<Film>> GetAllWithDataAsync();

		Task<Film?> GetByIdWithDataAsync(int Id);
	}

}