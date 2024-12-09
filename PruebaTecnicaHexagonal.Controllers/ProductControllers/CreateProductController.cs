using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.CreateProduct;

namespace PruebaTecnicaHexagonal.Controllers.ProductControllers
{
    [Route("api/productos")]
    [ApiController]
    public class CreateProductController
    {
        readonly ICreateProductInputPort _inputPort;
        readonly ICreateProductOutputPort _outputPort;

        public CreateProductController(ICreateProductInputPort inputPort, ICreateProductOutputPort outputPort)
            => (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<ProductDTO> Create(CreateProductDTO product)
        {
            await _inputPort.Handle(product);
            return ((IPresenter<ProductDTO>)_outputPort).Content;
        }
    }
}
