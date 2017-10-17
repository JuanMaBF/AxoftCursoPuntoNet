using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric.TiposGenericos
{
    public class Domain<T>
    {
        public T Id { get; }

        public Domain(T id)
        {
            Id = id;
        }
    }
}
