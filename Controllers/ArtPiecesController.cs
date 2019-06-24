using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using Dtos;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace ArtAdvisorBackEnd.Controllers {
  [Route ("api/[controller]")]
  public class ArtPiecesController : ControllerBase {
    private IRepositoryWrapper _repoWrapper;
    private IMapper _mapper;

    public ArtPiecesController (IRepositoryWrapper _repoWrapper, IMapper _mapper) {
      this._repoWrapper = _repoWrapper;
      this._mapper = _mapper;
    }

    [HttpGet ("")]
    public ActionResult<IEnumerable<ArtPieceDto>> Gets () {
      var a = _repoWrapper.ArtPieces.FindAll ();
      return _mapper.Map<ArtPieceDto[]> (_repoWrapper.ArtPieces.FindAll());
    }

    // GET api/artpieces/5
    [HttpGet ("{id}")]
    public ActionResult<ArtPieceDto> GetById (Guid id) {
      var artPieceToReturn = _repoWrapper.ArtPieces.FindByCondition (x => x.Id.Equals (id)).FirstOrDefault ();
      if (artPieceToReturn == null) {
        return NotFound ();
      }
      return _mapper.Map<ArtPieceDto> (artPieceToReturn);
    }

    // POST api/artpieces
    [HttpPost ("")]
    public ActionResult<ArtPieceDto> Post ([FromBody] ArtPieceDto artPieceDto) {
      var artPieceToSave = _mapper.Map<ArtPiece> (artPieceDto);
      _repoWrapper.ArtPieces.Create (artPieceToSave);
      _repoWrapper.Save ();
      return CreatedAtAction ("GetById", new ArtPiece { Id = artPieceToSave.Id }, artPieceToSave);
    }

    // PUT api/artpieces/5
    [HttpPut ("{id}")]
    public void Put (int id, [FromBody] string value) { }

    // DELETE api/artpieces/5
    [HttpDelete ("{id}")]
    public void DeleteById (int id) { }
  }
}