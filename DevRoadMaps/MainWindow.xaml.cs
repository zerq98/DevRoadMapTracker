using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DevRoadMaps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isMaximized=true;
        public MainWindow()
        {
            InitializeComponent();

            var screen = Screen.FromHandle(new WindowInteropHelper(this).Handle).WorkingArea;
            Height = screen.Height;
            Width = screen.Width;
            Top = 0;
            Left = 0;

            CloseBtn.Click += (s, e) => this.Close();
            MinimizeBtn.Click += (s, e) => this.WindowState = WindowState.Minimized;
            MaximizeBtn.Click += (s, e) =>
            {
                if (_isMaximized)
                {
                    _isMaximized = false;
                    Height = screen.Height / 2;
                    Width = screen.Width / 2;
                }
                else
                {
                    _isMaximized = true;
                    Height = screen.Height;
                    Width = screen.Width;
                }
                Top = 0;
                Left = 0;
            };
        }
    }
}
