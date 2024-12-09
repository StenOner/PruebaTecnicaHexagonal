using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.ProductDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.ProductUseCasesPorts.GetAllProducts;

namespace PruebaTecnicaHexagonal.Controllers.ProductControllers
{
    [Route("api/productos")]
    [ApiController]
    public class GetAllProductsController
    {
        readonly IGetAllProductsInputPort _inputPort;
        readonly IGetAllProductsOutputPort _outputPort;

        public GetAllProductsController(IGetAllProductsInputPort inputPort, IGetAllProductsOutputPort outputPort) =>
            (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> GetAll(Guid? categoryId)
        {
            await _inputPort.Handle(categoryId);
            return ((IPresenter<IEnumerable<ProductDTO>>)_outputPort).Content;
        }
    }
}
