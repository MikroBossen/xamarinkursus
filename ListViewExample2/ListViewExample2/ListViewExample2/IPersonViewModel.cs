using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewExample2
{
    public interface IPersonViewModel
    {
        List<Person> AllPersons { get; }
    }
}
