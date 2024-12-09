﻿using PruebaTecnicaHexagonal.DTOs.Category;
using PruebaTecnicaHexagonal.Entities.Interfaces;
using PruebaTecnicaHexagonal.UseCasesPorts.Category.UpdateCategory;

namespace PruebaTecnicaHexagonal.UseCases.Category.UpdateCategory
{
    public class UpdateCategoryInteractor : IUpdateCategoryInputPort
    {
        readonly ICategoryRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        readonly IUpdateCategoryOutputPort _outputPort;

        public UpdateCategoryInteractor(ICategoryRepository repository, IUnitOfWork unitOfWork, IUpdateCategoryOutputPort outputPort) =>
            (_repository, _unitOfWork, _outputPort) = (repository, unitOfWork, outputPort);

        public async Task Handle(Guid id, UpdateCategoryDTO category)
        {
            Entities.POCOs.Category categoryToUpdate = _repository.GetById(id);

            if (category.Nombre is not null)
            {
                categoryToUpdate.Nombre = category.Nombre;
            }

            if (category.Descripcion is not null)
            {
                categoryToUpdate.Descripcion = category.Descripcion;
            }

            _repository.Update(categoryToUpdate);
            await _unitOfWork.SaveChanges();
            await _outputPort.Handle(new CategoryDTO
            {
                Id = categoryToUpdate.Id,
                Nombre = categoryToUpdate.Nombre,
                Descripcion = categoryToUpdate.Descripcion
            });
        }
    }
}