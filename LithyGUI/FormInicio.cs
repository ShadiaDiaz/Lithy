using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using BLL;

namespace LithyGUI
{
    public partial class Inicio : Form
    {
        PersonaServiceBD paciente;

        public Inicio()
        {
            InitializeComponent();
        }
        SpeechRecognitionEngine Escucha = new SpeechRecognitionEngine();
        private void PictureBox1_Click(object sender, EventArgs e)
        {
           
                FormPrincipal principal = new FormPrincipal();
                principal.Show();
            pictureBox1.Dispose();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }
        
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BotonMaximizar.Visible = true;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Escucha.SetInputToDefaultAudioDevice();
                Escucha.LoadGrammar(new DictationGrammar());
                Escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>( Detection);
                Escucha.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch(InvalidOperationException){

                MessageBox.Show("No se abre");

            }


        }
        private void Detection(object sender, SpeechRecognizedEventArgs e) {

            foreach (RecognizedWordUnit palabra in e.Result.Words) {
                label1.Text = palabra.Pronunciation;

                if (palabra.Pronunciation== "Abrir") {

                    FormPrincipal principal = new FormPrincipal();
                    principal.Show();

                }

            }
        }
    }
}
