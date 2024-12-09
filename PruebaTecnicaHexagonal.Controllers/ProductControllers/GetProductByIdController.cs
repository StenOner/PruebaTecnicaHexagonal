using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetProductById;

namespace PruebaTecnicaHexagonal.Controllers.ProductControllers
{
    [Route("api/productos")]
    [ApiController]
    public class GetProductByIdController : ControllerBase
    {
        readonly IGetProductByIdInputPort _inputPort;
        readonly IGetProductByIdOutputPort _outputPort;

        public GetProductByIdController(IGetProductByIdInputPort inputPort, IGetProductByIdOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            await _inputPort.Handle(id);
            var content = ((IPresenter<ProductDTO>)_outputPort).Content;
            return Ok(content);
        }
    }
}
