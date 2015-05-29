using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events.Database
{
    interface IDatabase<T> where T : class
    {
        void Add(T type, Database database);

        void Edit(T type, Database database);

        void Remove(T type, Database database);
    }
}
