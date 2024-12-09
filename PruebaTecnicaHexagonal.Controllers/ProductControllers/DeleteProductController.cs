using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.DeleteProduct;

namespace PruebaTecnicaHexagonal.Controllers.ProductControllers
{
    [Route("api/productos")]
    [ApiController]
    public class DeleteProductController
    {
        readonly IDeleteProductInputPort _inputPort;
        readonly IDeleteProductOutputPort _outputPort;

        public DeleteProductController(IDeleteProductInputPort inputPort, IDeleteProductOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _inputPort.Handle(id);
        }
    }
}
