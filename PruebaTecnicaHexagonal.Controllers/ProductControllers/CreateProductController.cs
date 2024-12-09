using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.CreateProduct;

namespace PruebaTecnicaHexagonal.Controllers.ProductControllers
{
    [Route("api/productos")]
    [ApiController]
    public class CreateProductController : ControllerBase
    {
        readonly ICreateProductInputPort _inputPort;
        readonly ICreateProductOutputPort _outputPort;

        public CreateProductController(ICreateProductInputPort inputPort, ICreateProductOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDTO product)
        {
            try
            {
                await _inputPort.Handle(product);
                var content = ((IPresenter<ProductDTO>)_outputPort).Content;
                return Ok(content);
            }
            catch(Exception ex)
            {
                return UnprocessableEntity(new { ex.Message });
            }
        }
    }
}
