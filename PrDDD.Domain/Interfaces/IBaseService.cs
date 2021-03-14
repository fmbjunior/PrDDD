using FluentValidation;
using PrDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrDDD.Domain.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;

        void Delete(TEntity entity);

        TEntity Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;
    }
}
