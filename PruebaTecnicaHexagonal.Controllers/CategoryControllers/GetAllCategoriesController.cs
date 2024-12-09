using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaHexagonal.DTOs.CategoryDTOs;
using PruebaTecnicaHexagonal.Presenters;
using PruebaTecnicaHexagonal.UseCasesPorts.CategoryUseCasesPorts.GetAllCategories;

namespace PruebaTecnicaHexagonal.Controllers.CategoryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllCategoriesController
    {
        readonly IGetAllCategoriesInputPort _inputPort;
        readonly IGetAllCategoriesOutputPort _outputPort;

        public GetAllCategoriesController(IGetAllCategoriesInputPort inputPort, IGetAllCategoriesOutputPort outputPort)
            => (_inputPort, _outputPort) = (inputPort, outputPort);

        [HttpGet]
        public async Task<IEnumerable<CategoryDTO>> GetAll()
        {
            await _inputPort.Handle();
            return ((IPresenter<IEnumerable<CategoryDTO>>)_outputPort).Content;
        }
    }
}
