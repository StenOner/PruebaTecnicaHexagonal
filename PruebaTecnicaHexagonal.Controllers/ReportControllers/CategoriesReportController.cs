using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.ReportDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.ReportUseCasesPorts;

namespace PruebaTecnicaHexagonal.Controllers.ReportControllers
{
    [Route("api/reportes")]
    [ApiController]
    public class CategoriesReportController : ControllerBase
    {
        readonly ICategoriesReportInputPort _inputPort;
        readonly ICategoriesReportOutputPort _outputPort;

        public CategoriesReportController(ICategoriesReportInputPort inputPort, ICategoriesReportOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet("categorias")]
        public async Task<IActionResult> GetCategoriesReport()
        {
            await _inputPort.Handle();
            var content = ((IPresenter<IEnumerable<CategoryReportDTO>>)_outputPort).Content;
            return Ok(content);
        }
    }
}
