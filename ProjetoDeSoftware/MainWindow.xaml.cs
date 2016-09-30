using System;
using System.Collections.Generic;
using System.Linq;
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
using Xceed.Wpf.Toolkit;
using System.Windows.Controls.DataVisualization.Charting;


namespace ProjetoDeSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        //Bairro selecionado no combobox
        Classe.Territorio bairro_selecionado = new Bairro();

        public MainWindow()
        {
            InitializeComponent();
            cb_bairros.ItemsSource = bairro_selecionado.getNomes();
            grid_graficos.Visibility = Visibility.Hidden;
        }

        private void bt_pesquisar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nome_selecionado = cb_bairros.SelectedItem.ToString();
                
                bairro_selecionado = bairro_selecionado.getByNome(nome_selecionado);

                double pop, alf, ren;

                if (rd_sexo.IsChecked == true)
                {
                    Classe.Grafico g_populacao = new Classe.Grafico();
                    g_populacao.setDados("Homens", bairro_selecionado.getPopulacaoH());
                    g_populacao.setDados("Mulheres", bairro_selecionado.getPopulacaoM());
                    grafico_pop.DataContext = g_populacao.getGrafico();

                    Classe.Grafico g_alf = new Classe.Grafico();
                    g_alf.setDados("Homens", bairro_selecionado.getAlfabetizadosH());
                    g_alf.setDados("Mulheres", bairro_selecionado.getAlfabetizadosM());
                    grafico_alf.DataContext = g_alf.getGrafico();

                    Classe.Grafico g_renda = new Classe.Grafico();
                    g_renda.setDados("Homens", bairro_selecionado.getRendaMediaH());
                    g_renda.setDados("Mulheres", bairro_selecionado.getRendaMediaM());
                    grafico_renda.DataContext = g_renda.getGrafico();

                    lb_grafico1.Content = "População total";
                    lb_grafico2.Content = "Número de alfabetizados";
                    lb_grafico3.Content = "Renda média mensal";

                    grid_graficos.Visibility = Visibility.Visible;

                }
                else if (rd_alf.IsChecked == true)
                {
                    Classe.Grafico g1 = new Classe.Grafico();
                    g1.setDados("Alfabetizados", bairro_selecionado.getAlfabetizadosTotal());
                    g1.setDados("Não Alfabetizados", bairro_selecionado.getNaoAlfabetizadosTotal());
                    grafico_pop.DataContext = g1.getGrafico();

                    lb_grafico1.Content = "Alfabetizados x Não alfabetizados";

                    Classe.Grafico g_alf = new Classe.Grafico();
                    g_alf.setDados("Homens", bairro_selecionado.getAlfabetizadosH());
                    g_alf.setDados("Mulheres", bairro_selecionado.getAlfabetizadosM());
                    grafico_alf.DataContext = g_alf.getGrafico();
                    lb_grafico2.Content = "Homens alfabetizados x Mulheres alfabetizadas";

                    lb_grafico3.Visibility = Visibility.Hidden;
                    grafico_renda.Visibility = Visibility.Hidden;


                    //Numero de alfabetizados x Nao alfabetizados
                    //Renda dos alfabetizados x Nao alfabetizados
                    //Homem alfabetizado x Mulher alfabetizado

                    grid_graficos.Visibility = Visibility.Visible;


                }


            }
              catch 
              {
                System.Windows.MessageBox.Show("Preencha/Marque todos os campos!");
              }
        }

        private void rd_sexo_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rd_alf_Checked(object sender, RoutedEventArgs e)
        {

        }


    }
}
