﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PADomain.WorkerFiles
{
    public interface IFileRepo : IRepository<Filess>
    {
       // IEnumerable<File> GetWorkerFile { get; }
    }
   
}
