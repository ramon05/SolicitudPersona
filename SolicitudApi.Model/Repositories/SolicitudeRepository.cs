using SolicitudApi.Model.DataContext;
using SolicitudApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Model.Repositories
{
	public interface ISolicitudeRepository : IBaseRepository<Solicitude> { }
	public class SolicitudeRepository : BaseRepository<Solicitude>, ISolicitudeRepository
	{
		public SolicitudeRepository(SolicitudDbContext context) : base(context)
		{
		}

	}
}
