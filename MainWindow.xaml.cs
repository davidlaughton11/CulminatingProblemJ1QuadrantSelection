/*David Laughton
*may 20th 2019
*Sees what quadrant (x,y) are in
*/
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CulminatingProblemJ1QuadrantSelection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, RoutedEventArgs e)
        {
            //int x and y inputs
            int x;
            int y;
            int.TryParse(yValueInput.Text, out y);
            int.TryParse(xValueInput.Text, out x);
            
            //inputs for all the possible places
            if (x == 0 || y == 0)
            {
                lblOutput.Content = "input can not be 0";
            }
            else if (x > 0 && y > 0)
            {
                lblOutput.Content = "1";
            }
            else if (x < 0 && y > 0)
            {
                lblOutput.Content = "2";
            }
            else if (x < 0 && y < 0)
            {
                lblOutput.Content = "3";
            }
            else if (x > 0 && y < 0)
            {
                lblOutput.Content = "4";
            }
        }
    }
}
