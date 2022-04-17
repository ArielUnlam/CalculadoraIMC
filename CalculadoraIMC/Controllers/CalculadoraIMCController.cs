using CalculadoraIMC.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraIMC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraIMCController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CalculadoraIMCController> _logger;
        private readonly ICalculadoraIMCService _calcualdoraIMCService;

        public CalculadoraIMCController(ILogger<CalculadoraIMCController> logger, ICalculadoraIMCService calculadoraIMCService)
        {
            _logger = logger;
            _calcualdoraIMCService = calculadoraIMCService;
        }

        [HttpGet]
        public double Get(double peso, double altura)
        {
            return _calcualdoraIMCService.CalcularImc(peso, altura);
        }
    }
}
