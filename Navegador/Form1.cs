using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Navegador
{
    public partial class Form1 : Form
    {
        //Dim int As Integer = 0
        public Form1()
        {
            InitializeComponent();
            var tt = new System.Windows.Forms.ToolTip();
            tt.SetToolTip(cbBuscador, "Barra de busqueda");
            tt.SetToolTip(btnAtras, "Hacer clic para volver atras");
            tt.SetToolTip(btnRefresh, "Actualizar la pagina");
            tt.SetToolTip(btnAdelante, "Hacer clic para volver adelante");
            tt.SetToolTip(btnHome, "Ir al inicio");
            tt.SetToolTip(btnBuscar, "Buscar la web");
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          webBrowser1.Navigate(cbBuscador.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
