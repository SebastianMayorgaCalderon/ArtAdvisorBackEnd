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
  public class CategoriesController : Controller {
    private IRepositoryWrapper _repoWrapper;
    private IMapper _mapper;

    public CategoriesController (IRepositoryWrapper _repoWrapper, IMapper _mapper) {
      this._repoWrapper = _repoWrapper;
      this._mapper = _mapper;
    }

    // GET api/categories
    [HttpGet ("")]
    public ActionResult<IEnumerable<CategoryDto>> Gets () {
      return _mapper.Map<CategoryDto[]> (_repoWrapper.Categories.FindAll ());
    }

    // GET api/categories/5
    [HttpGet ("{id}")]
    public ActionResult<CategoryDto> GetById (Guid id) {
      var category = _repoWrapper.Categories.FindByCondition (c => c.Id.Equals (id)).First ();
      return _mapper.Map<CategoryDto> (category);
    }

    // POST api/categories
    [HttpPost ("")]
    public ActionResult<CategoryDto> Post ([FromBody] CategoryDto value) {
      var category = _mapper.Map<Category> (value);
      _repoWrapper.Categories.Create (category);
      _repoWrapper.Save ();
      return CreatedAtAction ("GetById", new Category (category.Id), category);

    }

    // PUT api/categories/5
    [HttpPut ("{id}")]
    public void Put (int id, [FromBody] string value) { }

    // DELETE api/categories/5
    [HttpDelete ("{id}")]
    public ActionResult<CategoryDto> DeleteById (Guid id) {
      var category = _repoWrapper.Categories.FindByCondition (c => c.Id.Equals (id)).First ();
      if (category == null) {
        return NotFound ();
      }
      _repoWrapper.Categories.Delete (category);
      _repoWrapper.Save ();
      return _mapper.Map<CategoryDto> (category);
    }
  }
}