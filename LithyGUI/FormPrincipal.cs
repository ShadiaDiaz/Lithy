using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace LithyGUI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Width==210) {

                panel1.Width = 54;
            } else
            {
                panel1.Width = 210;
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            if (this.WindowState== FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;

            }
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AbrirFrmInpanel(object FrmHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = FrmHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Seleccion(button1);
            AbrirFrmInpanel(new FormRegistro());
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Seleccion(button2);
            AbrirFrmInpanel(new FormRegistroMedicamentos());
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Seleccion(button3);
            AbrirFrmInpanel(new FormDiagnostico());
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Seleccion(button4);
            AbrirFrmInpanel(new FormRecetario());
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Seleccion(button5);
           
            

        }

    

    private void button6_Click(object sender, EventArgs e)
    {
            Seleccion(button6);
            AbrirFrmInpanel(new FormReportes());
            
    }  
        private void button7_Click(object sender, EventArgs e)
        {
            Seleccion(button7);
            AbrirFrmInpanel(new FormEnvioCorreo());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            AbrirFrmInpanel(new FormConsultar());
            
        }

        private void Seleccion(Button boton)
        {
           
            button7.BackColor = Color.FromArgb(3, 97, 122);
            button6.BackColor = Color.FromArgb(3, 97, 122);
            button5.BackColor = Color.FromArgb(3, 97, 122);
            button4.BackColor = Color.FromArgb(3, 97, 122);
            button3.BackColor = Color.FromArgb(3, 97, 122);
            button2.BackColor = Color.FromArgb(3, 97, 122);
            button1.BackColor = Color.FromArgb(3, 97, 122);
            button9.BackColor = Color.FromArgb(3, 97, 122);
            boton.BackColor = Color.FromArgb(5, 60, 110);

        }

        private void ResizeUp(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Seleccion(button9);
            AbrirFrmInpanel(new FormModificarPaciente());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AbrirFrmInpanel(new CitaMedica());
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AbrirFrmInpanel(new FormEnvioCorreo());
        }
    }
}   
