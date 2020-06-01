using System.Windows;
using System.Windows.Controls;

namespace SPdf.Controls
{
    /// <summary>
    /// Interaction logic for MainButton.xaml
    /// </summary>
    public partial class MainButton : UserControl
    {
        public static readonly DependencyProperty imageSvgProperty =
            DependencyProperty.Register("ImageSvg", typeof(string), typeof(UserControl), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty backgroundColorProperty =
            DependencyProperty.Register("BackgroundColor", typeof(string), typeof(UserControl), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty titleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(UserControl), new FrameworkPropertyMetadata(null));

        public static readonly DependencyProperty descriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(UserControl), new FrameworkPropertyMetadata(null));
        
        public MainButton()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string Title
        {
            get { return (string)GetValue(titleProperty); }
            set { SetValue(titleProperty, value); }
        }

        public string Description
        {
            get { return (string)GetValue(descriptionProperty); }
            set { SetValue(descriptionProperty, value); }
        }

        public string ImageSvg
        {
            get { return (string)GetValue(imageSvgProperty); }
            set { SetValue(imageSvgProperty, value); }
        }

        public string BackgroundColor
        {
            get { return (string)GetValue(backgroundColorProperty); }
            set { SetValue(backgroundColorProperty, value); }
        }
    }
}
