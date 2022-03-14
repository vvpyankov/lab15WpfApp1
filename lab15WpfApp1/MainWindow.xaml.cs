using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace lab15WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            XpsDocument doc = new XpsDocument("1.xps", FileAccess.Write);
            XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(doc);
            writer.Write(documentViewer.Document as FixedDocument);
            doc.Close();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            XpsDocument doc = new XpsDocument("D:/ITMO/projects/lab15WpfApp1/lab15WpfApp1/Data/FixedDocument.xps", FileAccess.Read);
            documentViewer.Document = doc.GetFixedDocumentSequence();
            doc.Close();
        }
    }
}
