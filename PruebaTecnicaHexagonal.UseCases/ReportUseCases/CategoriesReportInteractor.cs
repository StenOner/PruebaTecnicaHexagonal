using PruebaTecnicaHexagonal.DTOs.ReportDTOs;
using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.Entities.POCOs;
using PruebaTecnicaHexagonal.UseCasesPorts.ReportUseCasesPorts;

namespace PruebaTecnicaHexagonal.UseCases.ReportUseCases
{
    public class CategoriesReportInteractor : ICategoriesReportInputPort
    {
        readonly ICategoryRepository _repository;
        readonly ICategoriesReportOutputPort _outputPort;

        public CategoriesReportInteractor(ICategoryRepository repository, ICategoriesReportOutputPort outputPort) =>
            (_repository, _outputPort) = (repository, outputPort);

        public Task Handle()
        {
            IEnumerable<Category> categories = _repository.GetAll();
            _outputPort.Handle(categories.Select(c => new CategoryReportDTO
            {
                Nombre = c.Nombre,
                CantidadProductos = c.Productos.Count
            }));

            return Task.CompletedTask;
        }
    }
}
