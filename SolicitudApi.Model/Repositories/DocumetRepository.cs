using SolicitudApi.Model.DataContext;
using SolicitudApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Model.Repositories
{
	public interface IDocumentRepository : IBaseRepository<Document> { }
	public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
	{
		public DocumentRepository(SolicitudDbContext context) : base(context)
		{
		}

	}
}
