using Microsoft.AspNetCore.Mvc;
using Recruitment.Application.Interfaces;
using Recruitment.Application.Mappers.DTOs;

namespace Recruitment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidateController : ControllerBase
    {
        private readonly IJobServices _jobServices;
        public CandidateController(IJobServices jobServices)
        {
            _jobServices = jobServices;
        }
    }
}
