using System.Collections.Generic;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class ArtPiecesRepository : RepositoryBase<ArtPiece>, IArtPiecesRepository
    {
        public ArtPiecesRepository(ArtAdvisorContext artAdvisorContext) : base(artAdvisorContext)
        {
        }
        public new IEnumerable<ArtPiece> FindAll(){
          return this.artAdvisorcontext.ArtPieces
            .Include(x=>x.Type)
            .Include(x=>x.Author)
            .Include(x=>x.Museum);
        }
    }
}