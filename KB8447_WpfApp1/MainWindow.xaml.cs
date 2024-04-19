using Infragistics.Windows.DataPresenter;
using KB8447_WpfApp1.Model;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KB8447_WpfApp1;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;

        var dataRecord = button.DataContext as DataRecord;
        if (dataRecord == null) return;

        var clickedPerson = (Person)dataRecord.DataItem;
        MessageBox.Show($"ID={clickedPerson.ID} の {clickedPerson.FamilyName} さんがクリックされました");
    }
}