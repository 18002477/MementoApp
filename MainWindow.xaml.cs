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

namespace miniTexteditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Caretaker caretaker = new Caretaker();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {


            Originator originator = new Originator();
            Memento temp = originator.createMemento(tb_text.Text);
            caretaker.addMemento(temp);

        }

        private void lstBox_memento_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lstBox_memento.Items.Clear();
            for (int i = 0; i < caretaker.count(); i++)
            {
                lstBox_memento.Items.Add(caretaker.getMemento(i).getSavedWord());
            }
        }
    }
}
