using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.DeleteCategory;

namespace PruebaTecnicaHexagonal.Controllers.CategoryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteCategoryController
    {
        readonly IDeleteCategoryInputPort _inputPort;
        readonly IDeleteCategoryOutputPort _outputPort;

        public DeleteCategoryController(IDeleteCategoryInputPort inputPort, IDeleteCategoryOutputPort outputPort)
            => (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpDelete]
        public async Task Delete(Guid id)
        {
            await _inputPort.Handle(id);
        }
    }
}
