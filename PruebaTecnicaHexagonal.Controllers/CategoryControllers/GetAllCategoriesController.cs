using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetAllCategories;

namespace PruebaTecnicaHexagonal.Controllers.CategoryControllers
{
    [Route("api/categorias")]
    [ApiController]
    public class GetAllCategoriesController : ControllerBase
    {
        readonly IGetAllCategoriesInputPort _inputPort;
        readonly IGetAllCategoriesOutputPort _outputPort;

        public GetAllCategoriesController(IGetAllCategoriesInputPort inputPort, IGetAllCategoriesOutputPort outputPort)
            => (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await _inputPort.Handle();
            var content = ((IPresenter<IEnumerable<CategoryDTO>>)_outputPort).Content;
            return Ok(content);
        }
    }
}
