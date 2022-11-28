using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hades.ServiceModel
{
    public class DataResponse<T>
    {
        public T? Data { get; set;  }
        public int Status { get; set; }

    }
}
