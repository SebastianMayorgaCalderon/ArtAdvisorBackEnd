using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using Dtos;
using Microsoft.AspNetCore.Mvc;
using Repositories;
//using ArtAdvisorBackEnd.Models;

namespace ArtAdvisorBackEnd.Controllers
{
    [Route("api/[controller]")]
    public class ArtistsController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;
        private IMapper _mapper;

        public ArtistsController(IRepositoryWrapper _repoWrapper, IMapper _mapper)
        {
            this._repoWrapper = _repoWrapper;
            this._mapper = _mapper;
        }
        // GET api/artists
        [HttpGet("")]
        public ActionResult<IEnumerable<ArtistDto>> Gets()
        {
            return _mapper.Map<ArtistDto[]>(_repoWrapper.Artists.FindAll());
        }

        // GET api/artists/5
        [HttpGet("{id}")]
        public ActionResult<ArtistDto> GetById(Guid id)
        {
            var artist = _repoWrapper.Artists.FindByCondition(a => a.Id.Equals(id)).First();
            return _mapper.Map<ArtistDto>(artist);
        }

        // POST api/artists
        [HttpPost("")]
        public ActionResult<ArtistDto> Post([FromBody] ArtistDto artistDto)
        {
            var artist = _mapper.Map<Artist>(artistDto);
            _repoWrapper.Artists.Create(artist);
            _repoWrapper.Save();
            return CreatedAtAction("GetById", new Artist { Id = artist.Id }, artist);

        }

        // PUT api/artists/5
        [HttpPut("{id}")]
        public ActionResult<ArtistDto> Put(Guid id, [FromBody] ArtistDto artistDto)
        {
            if (!id.Equals(artistDto.Id))
            {
                return BadRequest();
            }
            var artistToSearch = _repoWrapper.Artists.FindByCondition(x => x.Id.Equals(id)).FirstOrDefault();
            if (artistToSearch == null)
            {
                return NotFound();
            }
            var artist = _mapper.Map<Artist>(artistDto);
            _repoWrapper.Artists.Update(artist);
            _repoWrapper.Save();
            return artistDto;
        }

        // DELETE api/artists/5
        [HttpDelete("{id}")]
        public ActionResult<ArtistDto> DeleteById(Guid id)
        {
            var artistToDel = _repoWrapper.Artists.FindByCondition(x => x.Id.Equals(id)).FirstOrDefault();
            if (artistToDel == null)
            {
                return NotFound();
            }
            _repoWrapper.Artists.Delete(artistToDel);
            return _mapper.Map<ArtistDto>(artistToDel);
        }
    }
}