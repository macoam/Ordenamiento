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

            miLista.Add(1);
            miLista.Add(3);
            miLista.Add(2);
            miLista.Add(4);
            miLista.Add(5);
            miLista.Add(9);
            miLista.Add(8);
            miLista.Add(7);

            alumnos.Add(new Alumno("Jose", 9.1f, 2));
            alumnos.Add(new Alumno("Mario", 8.1f, 1));
            alumnos.Add(new Alumno("Perro", 9.5f, 4));
            alumnos.Add(new Alumno("Gato", 7f, 0));
            alumnos.Add(new Alumno("Liebre", 7f, 1));
            alumnos.Add(new Alumno("Wombat", 9f, 2));
            alumnos.Add(new Alumno("Tiburon",10f, 3));
            alumnos.Add(new Alumno("Serpiente Piton", 6f, 4));


            lstNumeros.ItemsSource = alumnos;

        }

        private void BtnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            /*var temp = miLista[0];
              miLista[0] = miLista[3];
              miLista[3] = temp; 

            //SHELL
            int gap, temp, i, j;
            gap = miLista.Count / 2;

            while( gap > 0){

                for(i = 0; i<miLista.Count; i++)
                {
                    if(gap + i < miLista.Count && miLista[i] > miLista[gap + i])
                    {
                        temp = miLista[i];
                        miLista[i] = miLista[gap + i];
                        miLista[gap + i] = temp;
                    }
                }

                gap--;
            }
            */

            //SHELL 2
            int gap, i;
            gap = alumnos.Count / 2;
            

            while (gap > 0)
            {

                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count && alumnos[i].Promedio > alumnos[gap + i].Promedio)
                    {
                        
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;
                    }
                }

                gap--;
            }

        }

        private void BtnBubble_Click(object sender, RoutedEventArgs e)
        {
            /* int i, j;
            int temp = 0;
            for(i =1; i < miLista.Count; i++)
            {
                for (j = 0; j < miLista.Count - i; j++)
                {
                    if (miLista[j] > miLista[j + 1])
                    {
                        temp = miLista[j];
                        miLista[j] = miLista[j + 1];
                        miLista[j + 1] = temp;
                    }
                }
            } */

            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++)
                {
                    if (alumnos[i].Promedio > alumnos[i + 1].Promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }

        private void BtnFaltasShell_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = alumnos.Count / 2;


            while (gap > 0)
            {

                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count && alumnos[i].Faltas > alumnos[gap + i].Faltas)
                    {

                       var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;
                    }
                }

                gap--;
            }

        }

        private void BtnFaltasBubble_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++)
                {
                    if (alumnos[i].Faltas > alumnos[i + 1].Faltas)
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

        
    

