using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClassRepo
    {
        private List<Class> _classes = new List<Class>();

        public SchoolClassRepo(List<Class> classes)
        {
            _classes = classes;
        }

        public List<Class> FindAll() => _classes;
    }
}
