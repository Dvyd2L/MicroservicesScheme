﻿namespace Interfaces;
public interface IDbService<TModel, TPrimaryKey>
    where TModel : class
{
    #region GET
    Task<IEnumerable<TModel>?> Read(bool tracking = false);
    Task<TModel?> Read(TPrimaryKey pk, bool tracking = false);
    #endregion GET

    #region POST
    Task Create(TModel data);
    Task Create(IEnumerable<TModel> data);
    #endregion POST

    #region PUT
    Task Update(TModel data);
    Task Update(IEnumerable<TModel> data);
    #endregion PUT

    #region DELETE
    Task Delete(TPrimaryKey pk);
    Task Delete(IEnumerable<TPrimaryKey> pk);
    #endregion DELETE
}
