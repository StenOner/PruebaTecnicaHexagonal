using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.UpdateCategory;

namespace PruebaTecnicaHexagonal.Controllers.CategoryControllers
{
    [Route("api/categorias")]
    [ApiController]
    public class UpdateCategoryController
    {
        readonly IUpdateCategoryInputPort _inputPort;
        readonly IUpdateCategoryOutputPort _outputPort;

        public UpdateCategoryController(IUpdateCategoryInputPort inputPort, IUpdateCategoryOutputPort outputPort)
            => (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPut("{id}")]
        public async Task<CategoryDTO> Update(Guid id, UpdateCategoryDTO category)
        {
            await _inputPort.Handle(id, category);
            return ((IPresenter<CategoryDTO>)_outputPort).Content;
        }
    }
}
