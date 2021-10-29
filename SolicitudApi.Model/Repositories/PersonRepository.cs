using SolicitudApi.Model.DataContext;
using SolicitudApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Model.Repositories
{
	public interface IPersonRepository : IBaseRepository<Person> { }
	public class PersonRepository : BaseRepository<Person>, IPersonRepository
	{
		public PersonRepository(SolicitudDbContext context) : base(context)
		{
		}

	}
}
