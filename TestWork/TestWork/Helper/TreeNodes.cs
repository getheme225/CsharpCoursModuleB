using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using Work1_Car;

namespace TestWork.Helper
{
    [AddINotifyPropertyChangedInterface]
    public  class TreeNodes
    {
        /// <summary>
        /// Элемент дерево
        /// </summary>
        public  object Item { get; set; }

        /// <summary>
        ///  Называние Элемент дерева
        /// </summary>
        public string Name { get; set; }
       
        /// <summary>
        ///  Список дочерные элементов
        /// </summary>
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
        /// <summary>
        /// Флаг выбранный элемент 
        /// </summary>
        public bool IsSelected { get; set; }

        public static Object SelectecNodes(IEnumerable<TreeNodes> nodes)
        {
            return (from node in nodes where node.IsSelected select node.Item).FirstOrDefault();
        }

    }
}
