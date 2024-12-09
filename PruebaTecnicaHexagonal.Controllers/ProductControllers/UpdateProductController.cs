using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.UpdateProduct;

namespace PruebaTecnicaHexagonal.Controllers.ProductControllers
{
    [Route("api/productos")]
    [ApiController]
    public class UpdateProductController : ControllerBase
    {
        readonly IUpdateProductInputPort _inputPort;
        readonly IUpdateProductOutputPort _outputPort;

        public UpdateProductController(IUpdateProductInputPort inputPort, IUpdateProductOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateProductDTO productDTO)
        {
            try 
            {
                await _inputPort.Handle(id, productDTO);
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
