using System;

namespace Ejercicios_III
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        void Cuenta()
        {
            MessageBox.Show("Comienza la cuenta regresiva");

            for (int i = 10; i >= 0; i--)
            {
                ActualizarLabel(i); // Mostrar la cuenta regresiva en el Label
                Thread.Sleep(1000);
            }

            Lanzamiento();
        }

        void ActualizarLabel(int a)
        {
            if (lblCuentaRegresiva.InvokeRequired)
            {
                lblCuentaRegresiva.Invoke(new MethodInvoker(delegate
                {
                    lblCuentaRegresiva.Text = a.ToString();
                }));
            }
            else
            {
                lblCuentaRegresiva.Text = a.ToString();
            }
        }


        void Lanzamiento()
        {

            int x = pbNave.Location.X;
            int y = pbNave.Location.Y;
            while (y > -200)
            {
                if (pbNave.InvokeRequired)
                {
                    pbNave.Invoke(new MethodInvoker(delegate
                    {
                        pbNave.Location = new Point(x, y);
                    }));
                }
                else
                {
                    pbNave.Location = new Point(y, y);
                }
                y -= 10;
                Thread.Sleep(200);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnLanzamiento.InvokeRequired)
            {
                btnLanzamiento.Invoke(new MethodInvoker(delegate
                {
                    Thread Lanza = new Thread(Lanzamiento);
                    Lanza.Start();
                }));
            }
            else
            {
                Thread Lanza = new Thread(Lanzamiento);
                Lanza.Start();
            }
        }
    }
}