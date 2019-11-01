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
using System.Collections.ObjectModel;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLista = new ObservableCollection<int>();
        ObservableCollection<Alumno> alumnos = new ObservableCollection<Alumno>();

        public MainWindow()
        {
            InitializeComponent();
            miLista.Add(58);
            miLista.Add(35);
            miLista.Add(20);
            miLista.Add(16);
            miLista.Add(14);
            miLista.Add(12);
            miLista.Add(60);
            miLista.Add(4);

            alumnos.Add(new Alumno("Jose", 9.1f, 2));
            alumnos.Add(new Alumno("Maria", 9.0f, 0));
            alumnos.Add(new Alumno("Pedro", 6.4f, 14));
            alumnos.Add(new Alumno("Ana", 8.5f, 4));

            lstNumeros.ItemsSource = alumnos;
            

            //lstNumeros.ItemsSource = miLista;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*var temp = miLista[0];
            miLista[0] = miLista[3];
            miLista[3] = temp;*/

            int gap, i, j;
            gap = alumnos.Count / 2;

            while(gap > 0)
            {
                for(i=0; i<alumnos.Count; i++)
                {
                    if(gap + i <alumnos.Count && alumnos[i].Promedio > alumnos[gap + i].Promedio)
                    {
                        var temp = alumnos[i];
                        miLista[i] = miLista[gap + i];
                        alumnos[gap + i] = temp;
                    }
                }

                gap--;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i<miLista.Count - 1; i++)
                {
                    if (miLista[i]>miLista[i + 1])
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                }

            } while (intercambio);
        }
    }
}
