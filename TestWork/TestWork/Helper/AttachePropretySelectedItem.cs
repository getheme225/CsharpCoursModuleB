using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TestWork.Helper
{
    public class AttachePropretySelectedItem
    {
        public static readonly DependencyProperty TreeViewSelectedItemProprety =
            DependencyProperty.RegisterAttached("TreeViewSelectedItem", typeof(Object),
                typeof(AttachePropretySelectedItem), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
            TreeViewSelectedItemChanged));

        public static Object GetTreeViewSelectedItem(DependencyObject dependencyObject)
        {
            return (object) dependencyObject.GetValue(TreeViewSelectedItemProprety);
        }

        public static void SetTreeViewSelectedItem(DependencyObject dependencyObject, object value)
        {
            dependencyObject.SetValue(TreeViewSelectedItemProprety, value);
        }

        private static void TreeViewSelectedItemChanged(DependencyObject dependencyObject,
            DependencyPropertyChangedEventArgs e)
        {
            var tv = dependencyObject as TreeView;
            if (e.NewValue == null && e.OldValue != null)
            {
                tv.SelectedItemChanged -=
                new RoutedPropertyChangedEventHandler<object>(tv_SelectedItemChanged);
            }
            else if (e.NewValue != null && e.OldValue == null)
            {
                tv.SelectedItemChanged +=
                new RoutedPropertyChangedEventHandler<object>(tv_SelectedItemChanged);
            }

        }
        static void tv_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            SetTreeViewSelectedItem((DependencyObject)sender, e.NewValue);
        }
    }
}
