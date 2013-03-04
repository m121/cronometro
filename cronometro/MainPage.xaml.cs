using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace cronometro
{ 

    
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            temporizador = new System.Windows.Threading.DispatcherTimer();
            temporizador.Interval = new TimeSpan(0, 0, 0, 1);
            temporizador.Tick += new EventHandler(temporizador_tick);
        }

        System.Windows.Threading.DispatcherTimer temporizador;

        // variables
        int i = 1;
        int u = 0;
        int segundo = 0;
        int minuto = 0;
        int hora = 0;
        int numero = 2;
        
        public void temporizador_tick(object sender, EventArgs e)
        {
            i++;
       
            
             segundo = i;
            if (segundo == 60)
            {
                 minuto ++;
                 i = 0;
                 segundo = 0;
            }
            if (minuto == 60)
            {

                hora++;
                minuto = 0;
                segundo = 0;
                i = 0;
                
            }
            textBlock1.Text = hora.ToString("00") + ":" + minuto.ToString("00") + ":" + segundo.ToString("00");
           
             
                    
                }
                

        // empezar / pausar
        private void button1_Click(object sender, RoutedEventArgs e)
        {

            temporizador.Start();
            u++;

            if (u == numero)
            {
                temporizador.Stop();
                numero = numero + 2;
            }
                
            

      
        }
        // detener
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
            if (temporizador.IsEnabled)
            {
                temporizador.Stop();
                segundo = 0;
                minuto = 0;
                hora = 0;
                i = 0;
                textBlock1.Text = hora.ToString("00") + ":" + minuto.ToString("00") + ":" + segundo.ToString("00");


                


            }
        }


        

    }
}