using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGitADeux.src
{
    public interface IPersonContainer<T>
    {
        public List<T> SortByLastName();
        public List<T> SortByFirstName();
    }
}
