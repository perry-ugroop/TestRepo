﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAcct.Lib.General
{
    public class QueryDispatcher : IQueryDispatcher
    {
        public TResult Execute<TQuery, TResult>(TQuery query) 
            where TQuery : IQuery<TResult>
        {
            throw new NotImplementedException();
        }
    }
}
