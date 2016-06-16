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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Query q; 
        public MainWindow()
        {
            InitializeComponent();
            q = new Query();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void login_Click(object sender, RoutedEventArgs e)
        {
            string id = ident.Text;
            string password = pass.Password;

            MessageBox.Show(password);
        }

        //-------------------------------------- INTERFACE TAREFA ------------------------------------------

        // Quando clica em confimar insere tarefa
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string idt = id.Text;
            string tf = tarefa.Text;
            q.insertTarefas(Int32.Parse(idt), tf);
        }

        // ao cancelar Tarefa mete os campos em branco

        private void cancela_Click(object sender, RoutedEventArgs e)
        {
            id.Text = "";
            tarefa.Text = "";
        }


        //-------------------------------------- INTERFACE UTILIZADOR ------------------------------------------


        private void confirUser_Click(object sender, RoutedEventArgs e)
        {
            string ident = idU.Text;
            string name = nomeU.Text;
            string dataNasc = dataN.SelectedDate.Value.ToString("MM / dd / yyyy");
            string dataIns = dataI.SelectedDate.Value.ToString("MM / dd / yyyy");
            string var = postos.Text;
            q.insereUtilizador(Int32.Parse(ident),name,dataNasc,dataIns,1);


        }

        private void cancelaU_Click(object sender, RoutedEventArgs e)
        {
            idU.Text = "";
            nomeU.Text = "";
            dataN.SelectedDate.Value.ToString("");
            dataI.SelectedDate.Value.ToString("");
            postos.Text = "";
        }
    }
}
