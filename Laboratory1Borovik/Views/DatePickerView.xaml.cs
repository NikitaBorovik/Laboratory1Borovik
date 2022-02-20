using System.Windows.Controls;
using Laboratory1.ViewModels;

namespace Laboratory1.Views
{
    /// <summary>
    /// Interaction logic for DateActivityView.xaml
    /// </summary>
    public partial class DatePickerView : UserControl
    {
        public DatePickerView()
        {
            InitializeComponent();
            DataContext = new DatePickerViewModel();
        }
    }
}
