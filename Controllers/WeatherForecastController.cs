using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace ProjectWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public PolicyData ClientInformation(string policyNumber)
    {
        using (StreamReader r = new StreamReader("ClientData.json"))
        {
            string json = r.ReadToEnd();
            List<PolicyData> items = JsonConvert.DeserializeObject<List<PolicyData>>(json);
            var a = items.Where(s=>s.PolicyNumber == policyNumber).FirstOrDefault();
            Console.WriteLine(a);
            return a;
        }
    }

     [HttpGet]
     [Route("{communicationPolicyNumber}")]
    public CommunicationData GetCommunication([FromRoute] string communicationPolicyNumber)
    {
        using (StreamReader r = new StreamReader("CommunicationData.json"))
        {
            string json = r.ReadToEnd();
            Console.WriteLine(json);
            List<CommunicationData> items = JsonConvert.DeserializeObject<List<CommunicationData>>(json);
            var a = items.Where(s=>s.PolicyNumber == communicationPolicyNumber).FirstOrDefault();
            return a;
        }
    }

    [HttpGet]
     [Route("GetVehicleDetails")]
    public VehicleData GetVehicleDetails(string vehiclePolicyNumber)
    {
        using (StreamReader r = new StreamReader("VehicleData.json"))
        {
            string json = r.ReadToEnd();
            Console.WriteLine(json);
            List<VehicleData> items = JsonConvert.DeserializeObject<List<VehicleData>>(json);
            var a = items.Where(s=>s.PolicyNumber == vehiclePolicyNumber).FirstOrDefault();
            return a;
        }
    }

    [HttpGet]
     [Route("GetVehicleSimulation")]
    public SimulationData GetVehicleSimulation(string vehiclePolicyNumber)
    {
        using (StreamReader r = new StreamReader("SimulationData.json"))
        {
            string json = r.ReadToEnd();
            Console.WriteLine(json);
            List<SimulationData> items = JsonConvert.DeserializeObject<List<SimulationData>>(json);
            var a = items.Where(s=>s.PolicyNumber == vehiclePolicyNumber).FirstOrDefault();
            return a;
        }
    }

    
}
