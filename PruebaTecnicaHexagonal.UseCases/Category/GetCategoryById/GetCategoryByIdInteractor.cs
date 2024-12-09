﻿using PruebaTecnicaHexagonal.DTOs.Category;
using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.GetCategoryById;

namespace PruebaTecnicaHexagonal.UseCases.Category.GetCategoryById
{
    public class GetCategoryByIdInteractor : IGetCategoryByIdInputPort
    {
        readonly ICategoryRepository _repository;
        readonly IGetCategoryByIdOutputPort _outputPort;

        public GetCategoryByIdInteractor(ICategoryRepository repository, IGetCategoryByIdOutputPort outputPort) =>
            (_repository, _outputPort) = (repository, outputPort);

        public Task Handle(Guid id)
        {
            Entities.POCOs.Category category = _repository.GetById(id);
            _outputPort.Handle(new CategoryDTO
            {
                Id = category.Id,
                Nombre = category.Nombre,
                Descripcion = category.Descripcion
            });

            return Task.CompletedTask;
        }
    }
}