using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab8ControlNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> notastemporales = new List<int>();
        List<NotasAlumno>ListaNotas=new List<NotasAlumno>();

        private void GurdarNotas()
        {
            string json=JsonConvert.SerializeObject(ListaNotas);
            string archivo = "Datos.json";
            System.IO.File.WriteAllText(archivo, json);
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            int nota=Convert.ToInt16(textBoxNota.Text);
            notastemporales.Add(nota);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            NotasAlumno notasAlumno = new NotasAlumno();
            notasAlumno.Nombre = textBoxNombre.Text;
            notasAlumno.Notas = notastemporales.GetRange(0,notastemporales.Count);
            ListaNotas.Add(notasAlumno);
            GurdarNotas();
            notastemporales.Clear();


        }
    }
}
