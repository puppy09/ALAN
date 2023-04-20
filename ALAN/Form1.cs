using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] id_Subred = new string[4];
        public int id_Subred_int = 0;
        public string mascara = "";
        public byte[] mascara_byte=new byte[4];
        public string[] mascara_bit = new string[4];
        public string[] mascara_str = new string[4];
        public string clase = "";
        public int subredes = 0, subredes_prac = 0, subredes_teo = 0, host = 0, host_prac=0, host_teo=0;
        private void btnCal_Click(object sender, EventArgs e)
        {
            id_Subred=tbxID.Text.Split('.');
            id_Subred_int = Convert.ToInt32(id_Subred[0]);
            if (id_Subred_int >= 0 && id_Subred_int<=127)
            {
                mascara="255.0.0.0";
                clase = "A";
            }
            else if(id_Subred_int >= 128 && id_Subred_int <= 191)
            {
                mascara = "255.255.0.0";
                clase = "B";
            }
            else if(id_Subred_int >= 192 && id_Subred_int <= 223)
            {
                mascara = "255.255.255.0";
                clase= "C";
            }
            mascara_str = mascara.Split('.');
            for(int i = 0; i <= 3; i++)
            {
                mascara_byte[i] = Convert.ToByte(mascara_str[i]);
                mascara_bit[i] = Convert.ToString(mascara_byte[i],2);
                mascara_bit[i]=convert(mascara_bit[i]);
            }
            if (rbnSubredes.Checked)
            {
                subredes = Convert.ToInt32(tbxSubredes.Text);
                double aux = 0; 
                int i=0;
                while (aux < subredes)
                {
                    aux = Math.Pow(2, i);
                    if(aux < subredes)
                    {
                        i++;
                    }
                }
                
            }

            
        }

        //Añade los bits para acompletar 8
        public string convert(string str)
        {
            int a = 8 - str.Length;
            string b = "";

            if (str.Length < 8)
            {
                for (int i = 1; i <= a; i++)
                {
                    b = b + "0";
                }
            }
            string nuevoStr3 = str.Insert(0, b);
            return nuevoStr3;
        }

        private void rbnSubredes_CheckedChanged(object sender, EventArgs e)
        {
            tbxSubredes.Enabled = true;
        }

        private void rbnHost_CheckedChanged(object sender, EventArgs e)
        {
            tbxHost.Enabled= true;
        }
    }
}
