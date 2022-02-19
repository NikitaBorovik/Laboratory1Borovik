using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Laboratory1.ViewModels;

namespace Laboratory1.Views
{
    /// <summary>
    /// Interaction logic for DateActivityView.xaml
    /// </summary>
    public partial class DatePickerView : UserControl
    {
        private DatePickerViewModel dateViewModel;
        public DatePickerView()
        {
            InitializeComponent();
            DataContext = dateViewModel = new DatePickerViewModel();
        }
    }
}
