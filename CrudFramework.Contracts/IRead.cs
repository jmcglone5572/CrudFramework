﻿using System;
using System.Collections.Generic;

namespace CrudFramework.Contracts
{
    public interface IRead<TEntity>
    {
        TEntity ReadOne(Guid identity);
        IEnumerable<TEntity> ReadAll();

    }
}
