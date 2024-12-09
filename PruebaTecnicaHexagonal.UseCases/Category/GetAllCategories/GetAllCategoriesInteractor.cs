﻿using PruebaTecnicaHexagonal.DTOs.Category;
using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.GetAllCategories;

namespace PruebaTecnicaHexagonal.UseCases.Category.GetAllCategories
{
    public class GetAllCategoriesInteractor : IGetAllCategoriesInputPort
    {
        readonly ICategoryRepository _repository;
        readonly IGetAllCategoriesOutputPort _outputPort;

        public GetAllCategoriesInteractor(ICategoryRepository repository, IGetAllCategoriesOutputPort outputPort) =>
            (_repository, _outputPort) = (repository, outputPort);

        public Task Handle()
        {
            IEnumerable<Entities.POCOs.Category> categories = _repository.GetAll();
            _outputPort.Handle(categories.Select(c => new CategoryDTO
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Descripcion = c.Descripcion
            }));

            return Task.CompletedTask;
        }
    }
}
