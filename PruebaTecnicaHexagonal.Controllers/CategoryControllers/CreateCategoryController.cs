using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.CreateCategory;

namespace PruebaTecnicaHexagonal.Controllers.CategoryControllers
{
    [Route("api/categorias")]
    [ApiController]
    public class CreateCategoryController : ControllerBase
    {
        readonly ICreateCategoryInputPort _inputPort;
        readonly ICreateCategoryOutputPort _outputPort;

        public CreateCategoryController(ICreateCategoryInputPort inputPort, ICreateCategoryOutputPort outputPort)
            => (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDTO category)
        {
            await _inputPort.Handle(category);
            var content = ((IPresenter<CategoryDTO>)_outputPort).Content;
            return Ok(content);
        }
    }
}
