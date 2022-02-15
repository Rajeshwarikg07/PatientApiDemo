using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        public static ArrayList PatientData = new ArrayList()
        {
            "Tom"
        };
        

        [HttpGet]
        [Route("GetAllPatients")]
        public ArrayList GetAllPatients()
        {
            return PatientData;
        }

        [HttpGet]
        [Route("GetPatientById")]

        public string GetPatient(int id)
        {
            return PatientData[id].ToString();
        }

        [HttpPost]
        [Route("SaveNewPatient")]
        public ArrayList SaveNewUser([FromQuery] string patient)
        {
            PatientData.Add(patient);
            return PatientData;
        }

        [HttpPut]
        [Route("UpdatePatient")]
        public ArrayList UpdatePatient(int id, string patient)
        {
            PatientData[id] = patient;
            return PatientData;
        }

        [HttpDelete]
        [Route("DeletePatient")]
        public ArrayList DeletePatient(int id)
        {
            PatientData.RemoveAt(id);
            return PatientData;
        }
    }
}
