using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.UpdateProduct;

namespace PruebaTecnicaHexagonal.Controllers.ProductControllers
{
    [Route("api/productos")]
    [ApiController]
    public class UpdateProductController
    {
        readonly IUpdateProductInputPort _inputPort;
        readonly IUpdateProductOutputPort _outputPort;

        public UpdateProductController(IUpdateProductInputPort inputPort, IUpdateProductOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPut("{id}")]
        public async Task<ProductDTO> Update(Guid id, UpdateProductDTO productDTO)
        {
            await _inputPort.Handle(id, productDTO);
            return ((IPresenter<ProductDTO>)_outputPort).Content;
        }
    }
}
