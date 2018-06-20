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

namespace Recipe4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Photos are linked to web sources and can be outdated
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void SetSelectedResource(string resource) => this.flowDocumentRecipe.Document = (FlowDocument)this.Resources[resource];

        private void Selected1(object sender, RoutedEventArgs e) 
            => SetSelectedResource("_1_Applesauce_French_Toast");

        private void Selected2(object sender, RoutedEventArgs e) 
            => SetSelectedResource("_2_Banana_Oatmeal_Muffins");


        private void Selected3(object sender, RoutedEventArgs e) 
            => SetSelectedResource("_3_ButtermilkScones");

        private void Selected4(object sender, RoutedEventArgs e)
            => SetSelectedResource("_4_FruitPizza");

        private void Selected5(object sender, RoutedEventArgs e)
       => SetSelectedResource("_5_MorningMuffins");

        private void Selected6(object sender, RoutedEventArgs e)
        => SetSelectedResource("_6_OvenFrenchToast");

        private void Selected7(object sender, RoutedEventArgs e)
        => SetSelectedResource("_7_RaspberryOatmealBars");

        private void Selected8(object sender, RoutedEventArgs e)
       => SetSelectedResource("_8_BakedTofu");

        private void Selected9(object sender, RoutedEventArgs e)
        => SetSelectedResource("_9_PastaSalad");

        private void Selected10(object sender, RoutedEventArgs e)
        => SetSelectedResource("_10_BulgurPilaf");
    }
}
