using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.CreateCategory;

namespace PruebaTecnicaHexagonal.Controllers.CategoryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateCategoryController
    {
        readonly ICreateCategoryInputPort _inputPort;
        readonly ICreateCategoryOutputPort _outputPort;

        public CreateCategoryController(ICreateCategoryInputPort inputPort, ICreateCategoryOutputPort outputPort)
            => (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<CategoryDTO> Create(CreateCategoryDTO category)
        {
            await _inputPort.Handle(category);
            return ((IPresenter<CategoryDTO>)_outputPort).Content;
        }
    }
}
