using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao50dias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Notas de Inglês
        public double notaIG1 = 0;
        public double notaIG2 = 0;
        public double notaIG3 = 0;
        public double notaIG4 = 0;
        //Nota de I.P
        public double notaIP1 = 0;
        public double notaIP2 = 0;
        public double notaIP3 = 0;
        public double notaIP4 = 0;
        //Nota de D.S
        public double notaDS1 = 0;
        public double notaDS2 = 0;
        public double notaDS3 = 0;
        public double notaDS4 = 0;
        //Nota de PAM
        public double notaPAM1 = 0;
        public double notaPAM2 = 0;
        public double notaPAM3 = 0;
        public double notaPAM4 = 0;
        //Nota BD
        public double notaBD1 = 0;
        public double notaBD2 = 0;
        public double notaBD3 = 0;
        public double notaBD4 = 0;
        //Médias
        public double M1B = 0;
        public double M2B = 0;
        public double M3B = 0;
        public double M4B = 0;
        public double MFG = 0;
                                             
        //Nome
        public string nomeAluno;
        

        private void lbl_Bim2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        Class_CalculosBim calculaBimestre = new Class_CalculosBim();
        Class_MediaFinal calculaMediaFinal = new Class_MediaFinal();

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //verificar se textbox vazio

            if (txt_Ingles1.Text=="")
            {
                txt_Ingles1.Text = Convert.ToString(0);
            }

            if (txt_Ip1.Text == "")
            {
                txt_Ip1.Text = Convert.ToString(0);
            }

            if (txt_Ds1.Text == "")
            {
                txt_Ds1.Text = Convert.ToString(0);
            }

            if (txt_Pam1.Text == "")
            {
                txt_Pam1.Text = Convert.ToString(0);
            }

            if (txt_Bd1.Text == "")
            {
                txt_Bd1.Text = Convert.ToString(0);
            }

            //

            if (txt_Ingles2.Text == "")
            {
                txt_Ingles2.Text = Convert.ToString(0);
            }

            if (txt_Ip2.Text == "")
            {
                txt_Ip2.Text = Convert.ToString(0);
            }

            if (txt_Ds2.Text == "")
            {
                txt_Ds2.Text = Convert.ToString(0);
            }

            if (txt_Pam2.Text == "")
            {
                txt_Pam2.Text = Convert.ToString(0);
            }

            if (txt_Bd2.Text == "")
            {
                txt_Bd2.Text = Convert.ToString(0);
            }

            //

            if (txt_Ingles3.Text == "")
            {
                txt_Ingles3.Text = Convert.ToString(0);
            }

            if (txt_Ip3.Text == "")
            {
                txt_Ip3.Text = Convert.ToString(0);
            }

            if (txt_Ds3.Text == "")
            {
                txt_Ds3.Text = Convert.ToString(0);
            }

            if (txt_Pam3.Text == "")
            {
                txt_Pam3.Text = Convert.ToString(0);
            }

            if (txt_Bd3.Text == "")
            {
                txt_Bd3.Text = Convert.ToString(0);
            }

            //

            if (txt_Ingles4.Text == "")
            {
                txt_Ingles4.Text = Convert.ToString(0);
            }

            if (txt_Ip4.Text == "")
            {
                txt_Ip4.Text = Convert.ToString(0);
            }

            if (txt_Ds4.Text == "")
            {
                txt_Ds4.Text = Convert.ToString(0);
            }

            if (txt_Pam4.Text == "")
            {
                txt_Pam4.Text = Convert.ToString(0);
            }

            if (txt_Bd4.Text == "")
            {
                txt_Bd4.Text = Convert.ToString(0);
            }

            //

            notaIG1 = Convert.ToDouble(txt_Ingles1.Text);           
            notaIP1 = Convert.ToDouble(txt_Ip1.Text);
            notaDS1 = Convert.ToDouble(txt_Ds1.Text);
            notaPAM1 = Convert.ToDouble(txt_Pam1.Text);
            notaBD1 = Convert.ToDouble(txt_Bd1.Text);

            notaIG2 = Convert.ToDouble(txt_Ingles2.Text);
            notaIP2 = Convert.ToDouble(txt_Ip2.Text);
            notaDS2 = Convert.ToDouble(txt_Ds2.Text);
            notaPAM2 = Convert.ToDouble(txt_Pam2.Text);
            notaBD2 = Convert.ToDouble(txt_Bd2.Text);

            notaIG3 = Convert.ToDouble(txt_Ingles3.Text);
            notaIP3 = Convert.ToDouble(txt_Ip3.Text);
            notaDS3 = Convert.ToDouble(txt_Ds3.Text);
            notaPAM3 = Convert.ToDouble(txt_Pam3.Text);
            notaBD3 = Convert.ToDouble(txt_Bd3.Text);

            notaIG4 = Convert.ToDouble(txt_Ingles4.Text);
            notaIP4 = Convert.ToDouble(txt_Ip4.Text);
            notaDS4 = Convert.ToDouble(txt_Ds4.Text);
            notaPAM4 = Convert.ToDouble(txt_Pam4.Text);
            notaBD4 = Convert.ToDouble(txt_Bd4.Text);

            M1B = calculaBimestre.MB1(notaIG1, notaIP1, notaDS1, notaPAM1, notaBD1);
            lbl_MB1.Text = Convert.ToString(M1B);

            M2B = calculaBimestre.MB2(notaIG2, notaIP2, notaDS2, notaPAM2, notaBD2);
            lbl_MB2.Text = Convert.ToString(M2B);

            M3B = calculaBimestre.MB3(notaIG3, notaIP3, notaDS3, notaPAM3, notaBD3);
            lbl_MB3.Text = Convert.ToString(M3B);
            
            M4B = calculaBimestre.MB4(notaIG4, notaIP4, notaDS4, notaPAM4, notaBD4);
            lbl_MB4.Text = Convert.ToString(M4B);

            MFG = calculaMediaFinal.MediaGFinal(M1B, M2B, M3B, M4B);
            lbl_MediaFinal.Text = Convert.ToString(MFG);


            nomeAluno=Convert.ToString(txt_Aluno.Text);

            if (txt_Aluno.Text == "")
            {
                MessageBox.Show("Digite o nome do Aluno!!!");
                txt_Aluno.Focus();
            }
            
            if ((MFG >= 0) && (MFG <= 4.99))
            {
                lbl_Status.Text = nomeAluno+ " está REPROVADO!";
            }
            
            else if ((MFG >= 5) && (MFG <= 6.99))
            {
                lbl_Status.Text = nomeAluno+ " está Recuperação!";
            }

            else if (MFG >= 7)
            {
                lbl_Status.Text = nomeAluno+ " está Aprovado!";
            }

            /* sem OPP
            result1 = (notaIG1 + notaIP1 + notaDS1 + notaPAM1 + notaBD1) / 5;
            lbl_MB1.Text = Convert.ToString(result1);
            result2 = (notaIG2 + notaIP2 + notaDS2 + notaPAM2 + notaBD2) / 5;
            lbl_MB2.Text = Convert.ToString(result2);
            result3 = (notaIG3 + notaIP3 + notaDS3 + notaPAM3 + notaBD3) / 5;
            lbl_MB3.Text = Convert.ToString(result3);
            result4 = (notaIG4 + notaIP4 + notaDS4 + notaPAM4 + notaBD4) / 5;
            lbl_MB4.Text = Convert.ToString(result4);

            resultfinal = 
            resultfinal = (M1B + M2B + M3B + M4B) / 4;
            lbl_MediaFinal.Text = Convert.ToString(resultfinal);
            */

        }
        
        
        private void btn_Limpar_Click_1(object sender, EventArgs e)
        {
            notaIG1 = 0;
            notaIP1 = 0;
            notaDS1 = 0;
            notaPAM1 = 0;
            notaBD1 = 0;

            notaIG2 = 0;
            notaIP2 = 0;
            notaDS2 = 0;
            notaPAM2 = 0;
            notaBD2 = 0;

            notaIG3 = 0;
            notaIP3 = 0;
            notaDS3 = 0;
            notaPAM3 = 0;
            notaBD3 = 0;

            notaIG4 = 0;
            notaIP4 = 0;
            notaDS4 = 0;
            notaPAM4 = 0;
            notaBD4 = 0;

            M1B = 0;
            M2B = 0;
            M3B = 0;
            M4B = 0;
            MFG = 0;

            txt_Ingles1.Clear();
            txt_Ip1.Clear();
            txt_Ds1.Clear();
            txt_Pam1.Clear();
            txt_Bd1.Clear();

            txt_Ingles2.Clear();
            txt_Ip2.Clear();
            txt_Ds2.Clear();
            txt_Pam2.Clear();
            txt_Bd2.Clear();

            txt_Ingles3.Clear();
            txt_Ip3.Clear();
            txt_Ds3.Clear();
            txt_Pam3.Clear();
            txt_Bd3.Clear();

            txt_Ingles4.Clear();
            txt_Ip4.Clear();
            txt_Ds4.Clear();
            txt_Pam4.Clear();
            txt_Bd4.Clear();

            txt_Aluno.Clear();
            txt_Aluno.Focus();

            lbl_MediaFinal.Text = "0";
            lbl_MB1.Text = "0";
            lbl_MB2.Text = "0";
            lbl_MB3.Text = "0";
            lbl_MB4.Text = "0";
            lbl_Status.Text = "...";
            
        }
       
    }
}