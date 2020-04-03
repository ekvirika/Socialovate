using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDB
{
    public abstract class TableDB<T>
    {
        public abstract void Create(T obj);
        public abstract List<T> Read();
        public abstract void Update(T obj);
        public abstract void Delete(T obj);
    }
}
