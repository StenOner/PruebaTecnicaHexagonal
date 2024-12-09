using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetProductById;

namespace PruebaTecnicaHexagonal.Controllers.ProductControllers
{
    [Route("api/productos")]
    [ApiController]
    public class GetProductByIdController
    {
        readonly IGetProductByIdInputPort _inputPort;
        readonly IGetProductByIdOutputPort _outputPort;

        public GetProductByIdController(IGetProductByIdInputPort inputPort, IGetProductByIdOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet("{id}")]
        public async Task<ProductDTO> Get(Guid id)
        {
            await _inputPort.Handle(id);
            return ((IPresenter<ProductDTO>)_outputPort).Content;
        }
    }
}
