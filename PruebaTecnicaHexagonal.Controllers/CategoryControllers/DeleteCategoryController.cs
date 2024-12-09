using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.DeleteCategory;

namespace PruebaTecnicaHexagonal.Controllers.CategoryControllers
{
    [Route("api/categorias")]
    [ApiController]
    public class DeleteCategoryController : ControllerBase
    {
        readonly IDeleteCategoryInputPort _inputPort;
        readonly IDeleteCategoryOutputPort _outputPort;

        public DeleteCategoryController(IDeleteCategoryInputPort inputPort, IDeleteCategoryOutputPort outputPort)
            => (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _inputPort.Handle(id);
            return NoContent();
        }
    }
}
