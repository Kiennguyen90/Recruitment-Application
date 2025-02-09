using Microsoft.AspNetCore.Mvc;
using Recruitment.Application.Interfaces;
using Recruitment.Application.Mappers.DTOs;
using Microsoft.AspNetCore.Cors;

namespace RecruitmentCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class JobController : ControllerBase
    {
        private readonly IJobServices _jobServices;
        public JobController(IJobServices jobServices) { 
            _jobServices = jobServices;
        }
        [HttpGet]
        public async Task <IActionResult> GetJobsAsync()
        {
            var respone = await _jobServices.GetAllJobsAsync();
            return Ok(respone);
        }

        [HttpGet("{Id:Guid}")]
        public async Task<IActionResult> GetJobsByIdAsync(Guid Id)
        {
            var respone = await _jobServices.GetJobByIdAsync(Id);
            return Ok(respone);
        }

        [HttpPost]
        public async Task<IActionResult> CreateJobsAsync(JobRequest jobRequest)
        {
            var respone = await _jobServices.AddJobAsync(jobRequest);
            return Ok(respone);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateJobAsync(JobRequest jobRequest)
        {
            var respone = await _jobServices.UpdateJobAsync(jobRequest);
            return Ok(respone);
        }

        [HttpDelete("{Id:Guid}")]
        public async Task<IActionResult> JobAsync(Guid Id)
        {
            var respone = await _jobServices.DeleteJobAsync(Id);
            return Ok(respone);
        }

    }
}
