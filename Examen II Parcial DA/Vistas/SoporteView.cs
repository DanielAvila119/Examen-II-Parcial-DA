using Examen_II_Parcial_DA.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_II_Parcial_DA.Vistas
{
    public partial class SoporteView : Form
    {
        public SoporteView()
        {
            InitializeComponent();
            ServicioController controlador = new ServicioController(this);
        }
    }
}
