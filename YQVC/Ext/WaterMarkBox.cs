using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace YQVC.Ext
{
    public class WaterMarkBox : TextBox
    {
        static WaterMarkBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WaterMarkBox), new FrameworkPropertyMetadata(typeof(WaterMarkBox)));
        }
        public static readonly DependencyProperty MaskProperty = DependencyProperty.Register("Mask", typeof(string), typeof(WaterMarkBox), new PropertyMetadata("请输入文本"));
        public string Mask
        {
            get { return (string)GetValue(MaskProperty); }
            set { SetValue(MaskProperty, value); }
        }
    }
}
