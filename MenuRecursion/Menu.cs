using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuRecursion
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
        public int OrderIndex { get; set; }
        public Boolean Status { get; set; }
        public List<Menu> SubMenu { get; set; }

    }
}
