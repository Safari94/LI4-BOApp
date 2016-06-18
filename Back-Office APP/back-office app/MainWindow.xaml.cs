﻿using System;
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
        String password;


        public MainWindow()

        {
            InitializeComponent();
            q = new Query();
            password = "password";

            //fazer disable de todas as tabs exceto login
            
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
            string passw = pass.Password;

            if (password == passw)
            {
                //fazer enable do resto das tabs e fazer disable da tab login
            }
            
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
            string[] aux= var.Split('-');

            q.insereUtilizador(Int32.Parse(ident), name, dataNasc, dataIns, Int32.Parse(aux[0]));

        }

        private void cancelaU_Click(object sender, RoutedEventArgs e)
        {
            idU.Text = "";
            nomeU.Text = "";
            dataN.DataContext = null;
            dataI.DataContext = null;
            postos.Text = "";
        }

        //-------------------------------------- INTERFACE PontoInteresse ------------------------------------------

        private void confirmaPI_Click(Object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idPI.Text);
            float latitude = float.Parse(laPI.Text);
            float longitude = float.Parse(loPI.Text);
            String image = l1PI.ToString();
            String audio = L2PI.ToString();
            String txt = txtPI.Text;
            q.inserePontoInteresse(id,latitude,longitude, image, audio,txt);

            idPI.Text = "";
            laPI.Text = "";
            loPI.Text = "";
            l1PI.BeginInit();
            L2PI.BeginInit();
            txtPI.Text = "";

        }

        private void cancelaPI_Click(Object sender, RoutedEventArgs e)
        {
            idPI.Text = "";
            laPI.Text = "";
            loPI.Text = "";
            l1PI.BeginInit();
            L2PI.BeginInit();
            txtPI.Text = "";
        }


        private void logout1_Click(Object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logout2_Click(Object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logout3_Click(Object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logout4_Click(Object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logout5_Click(Object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logout6_Click(Object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logout7_Click(Object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logout8_Click(Object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logout9_Click(Object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logout10_Click(Object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }

   
}
