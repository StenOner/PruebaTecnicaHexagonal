using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnicaHexagonal.DTOs.ReportDTOs;
using PruebaTecnicaHexagonal.UseCasesPorts.ReportUseCasesPorts;

namespace PruebaTecnicaHexagonal.Presenters.ReportPresenters
{
    internal class CategoriesReportPresenter : ICategoriesReportOutputPort, IPresenter<IEnumerable<CategoryReportDTO>>
    {
        public IEnumerable<CategoryReportDTO> Content { get; private set; }

        public Task Handle(IEnumerable<CategoryReportDTO> categories)
        {
            Content = categories;
            return Task.CompletedTask;
        }
    }
}
