using PruebaTecnicaHexagonal.DTOs.ReportDTOs;

namespace PruebaTecnicaHexagonal.UseCasesPorts.ReportUseCasesPorts
{
    public interface ICategoriesReportOutputPort
    {
        Task Handle(IEnumerable<CategoryReportDTO> categories);
    }
}
