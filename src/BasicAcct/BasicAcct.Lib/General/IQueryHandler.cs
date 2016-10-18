using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAcct.Lib.General
{
    public interface IQueryHandler<in TQuery, out TResult>
    {
        TResult Execute(TQuery query);
    }
}
