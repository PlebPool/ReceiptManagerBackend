using Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Queries
{
    [ScopedService]
    public interface IQueryHandler<TQuery, TReturn> where TQuery : IQuery
    {
        TReturn Handle(TQuery query);
    }

    [ScopedService]
    public interface IQueryHandler<TReturn>
    {
        TReturn Handle();
    }
}
