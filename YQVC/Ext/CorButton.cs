using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace YQVC.Ext
{
    public class CorButton : Button
    {
        static CorButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CorButton), new FrameworkPropertyMetadata(typeof(CorButton)));
        }
        public static readonly DependencyProperty CorProperty = DependencyProperty.Register("Cor", typeof(CornerRadius), typeof(CorButton));
        public static readonly DependencyProperty HoverProperty = DependencyProperty.Register("Hover", typeof(Brush), typeof(CorButton));
        public CornerRadius Cor
        {
            get { return (CornerRadius)GetValue(CorProperty); }
            set { SetValue(CorProperty, value); }
        }
        public Brush Hover
        {
            get { return (Brush)GetValue(HoverProperty); }
            set { SetValue(HoverProperty, value); }
        }
    }
}
