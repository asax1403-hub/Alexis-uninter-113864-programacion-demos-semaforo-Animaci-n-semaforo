namespace Semaforo
{
    public partial class Form1 : Form
    {
        int estado = 0;

        public Form1()
        {
            InitializeComponent();

            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Cuerpo del semáforo
            g.FillRectangle(Brushes.Black, 100, 50, 150, 350);

            // Luces apagadas
            Brush rojo = Brushes.Gray;
            Brush amarillo = Brushes.Gray;
            Brush verde = Brushes.Gray;

            // Determinar qué luz está encendida
            if (estado == 0)
            {
                rojo = Brushes.Red;
            }
            else if (estado == 1)
            {
                amarillo = Brushes.Yellow;
            }
            else if (estado == 2)
            {
                verde = Brushes.Green;
            }

            // Dibujar las luces
            g.FillEllipse(rojo, 140, 70, 70, 70);
            g.FillEllipse(amarillo, 140, 160, 70, 70);
            g.FillEllipse(verde, 140, 250, 70, 70);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            estado++;

            if (estado > 2)
            {
                estado = 0;
            }

            this.Invalidate();
        }
    }
}
