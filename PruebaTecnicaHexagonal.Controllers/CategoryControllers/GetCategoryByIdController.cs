using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetCategoryById;

namespace PruebaTecnicaHexagonal.Controllers.CategoryControllers
{
    [Route("api/categorias")]
    [ApiController]
    public class GetCategoryByIdController : ControllerBase
    {
        readonly IGetCategoryByIdInputPort _inputPort;
        readonly IGetCategoryByIdOutputPort _outputPort;

        public GetCategoryByIdController(IGetCategoryByIdInputPort inputPort, IGetCategoryByIdOutputPort outputPort)
            => (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            await _inputPort.Handle(id);
            var content = ((IPresenter<CategoryDTO>)_outputPort).Content;
            return Ok(content);
        }
    }
}
