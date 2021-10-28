using SolicitudApi.Model.DataContext;
using SolicitudApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Model.Repositories
{
	public interface ITeamRepository : IBaseRepository<Team> { }
	public class TeamRepository : BaseRepository<Team>, ITeamRepository
	{
		public TeamRepository(SolicitudDbContext context) : base(context)
		{
		}

	}
}
