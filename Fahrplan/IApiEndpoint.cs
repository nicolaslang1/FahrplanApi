﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrplan
{
    interface IApiEndpoint<T> where T : class
    {
        Authentication ApiAuthentication { get;}

        T Get();



    }
}