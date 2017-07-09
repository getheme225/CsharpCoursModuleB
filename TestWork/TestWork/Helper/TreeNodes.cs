using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Work1_Car;

namespace TestWork.Helper
{
   public  class TreeNodes
    {
        public  object Item { get; set; }

        public string Name { get; set; }
       

        public List<TreeNodes> Childreens
        {
            get
            {
                var list = new List<TreeNodes>();
                if (Item is Car)
                {
                    list.Add(new TreeNodes() {Item = ((Car) Item).Details , Name= "Детали"});
                }
                if (Item is ICollection<Detail>)
                {
                    list.AddRange((Item as ICollection<Detail>).Select(item => new TreeNodes() {Item = item,Name=item.Name}));
                }
                if (Item is Wheel)
                {
                    list.AddRange((Item as Wheel).Nuts.Select(item => new TreeNodes() {Item = item, Name= item.Name}));
                }
                return list;
            }
        }
    }
}
