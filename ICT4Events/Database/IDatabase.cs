using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events.Database
{
    interface IDatabase<T> where T : class
    {
        void Toevoegen(T type, Database database);

        void Aanpassen(T type, Database database);

        void Verwijderen(T type, Database database);
    }
}
