﻿using API_consulta.Class;
using API_consulta.Management;
using API_consulta.Management.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_consulta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SymptomsController : ControllerBase
    {
        private readonly ISymptomsManagements _symptomsManagement;

        public SymptomsController(ISymptomsManagements simptomsManagement)
        {
            _symptomsManagement = simptomsManagement;
        }
        [HttpGet("symptoms_id")]
        public async Task<ActionResult<SymptomsModel>> SerchSymptomsId(int symptoms_id)
        {
            SymptomsModel symptoms = await _symptomsManagement.SerchSymptomsId(symptoms_id);
            return Ok(symptoms);
        }
        [HttpPost]
        public async Task<ActionResult<SymptomsModel>> AddSymptoms([FromBody] SymptomsModel symptomsModel)
        {
            SymptomsModel symptoms = await _symptomsManagement.AddSymptoms(symptomsModel);
            return Ok(symptoms);
        }
    }
}
