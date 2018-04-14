using AttendanceAPI.Models;
using AttendanceAPI.Models.Banner;
using AttendanceAPI.Models.DTO;
using AutoMapper;
using System;
using System.Linq;
using System.Web.Http;

namespace AttendanceAPI.Controllers
{
    //[Authorize(Roles = "Lecturer")]
    //[RoutePrefix("api/attendance")]
    public class ModulesController : ApiController
    {
        private AttendanceDB _attendanceDb;

        public ModulesController()
        {
            _attendanceDb = new AttendanceDB();
        }

        // GET /Modules
        [HttpGet]
        [Route("Modules")]
        public IHttpActionResult GetAllModules()
        {
            var moduleQuery = _attendanceDb.Modules;

            var studentDto = moduleQuery
                .ToList()
                .Select(Mapper.Map<Module, ModuleDTO>);

            return Ok(studentDto);
        }

        // GET /Module/id
        [HttpGet]
        [Route("Module/{id}")]
        public IHttpActionResult GetModuleById(int id)
        {
            var module = _attendanceDb.Modules.SingleOrDefault(s => s.id == id);

            if (module == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Module, ModuleDTO>(module));
        }

        // POST /Module
        [HttpPost]
        [Route("Module")]
        public IHttpActionResult CreateModule(ModuleDTO moduleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var module = Mapper.Map<ModuleDTO, Module>(moduleDto);
            _attendanceDb.Modules.Add(module);
            _attendanceDb.SaveChanges();

            moduleDto.id = module.id;

            return Created(new Uri(Request.RequestUri + "/" + module.id), moduleDto);
        }

        // PUT /Module
        [HttpPut]
        [Route("Module/{id}")]
        public IHttpActionResult UpdateModule(int id, ModuleDTO moduleDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var moduleInDb = _attendanceDb.Modules.SingleOrDefault(m => m.id == id);

            if (moduleInDb == null)
                return NotFound();

            Mapper.Map(moduleDto, moduleInDb);

            _attendanceDb.SaveChanges();

            return Ok();
        }

        // DELETE /Module
        [HttpDelete]
        [Route("Module/{id}")]
        public IHttpActionResult DeleteModule(int id)
        {
            var moduleInDb = _attendanceDb.Modules.SingleOrDefault(m => m.id == id);

            if (moduleInDb == null)
                return NotFound();

            _attendanceDb.Modules.Remove(moduleInDb);
            _attendanceDb.SaveChanges();

            return Ok();
        }
    }
}