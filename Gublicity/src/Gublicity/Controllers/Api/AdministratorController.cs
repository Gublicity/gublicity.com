using AutoMapper;
using Gublicity.Models;
using Gublicity.ViewModels;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Gublicity.Controllers.Api
{
    [Route("api/administrators")]
    public class AdministratorController : Controller
    {
        private IGublicityRepository _repository;

        public AdministratorController(IGublicityRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("")]
        public JsonResult Get()
        {
            var results = Mapper.Map<IEnumerable<AdministratorViewModel>>(_repository.getAllAdministrators());

            return Json(results);
        }

        [HttpGet("")]
        public JsonResult GetByName(string username)
        {
            var results = Mapper.Map<AdministratorViewModel>(_repository.getAdministratorByName(username));

            return Json(results);
        }

        [HttpPost("")]
        public JsonResult Post([FromBody]AdministratorViewModel vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newAdmin = Mapper.Map<Administrator>(vm);

                    //Save to the DB
                    _repository.AddAdministrator(newAdmin);

                    if (_repository.SaveAll())
                    {
                        Response.StatusCode = (int)HttpStatusCode.Created;
                        return Json(Mapper.Map<AdministratorViewModel>(newAdmin));
                    }
                }

            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json(new { Message = ex.Message });
            }

            Response.StatusCode = (int)HttpStatusCode.BadRequest;
            return Json(new { Message = "Failed", ModelState = ModelState });


        }
    }
}
