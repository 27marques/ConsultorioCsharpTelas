using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Views.Lib;

namespace Views
{
    public class Paciente : Pessoa
    {
        FieldForm fieldDataNascimento;
        ButtonForm btnConfirmar;
        ButtonForm btnCancelar;

        public Paciente() 
        {
            fieldDataNascimento = new FieldForm("Data de Nascimento",20,320,120,20);
                        
			btnConfirmar = new ButtonForm("Confirmar", 200, 520, this.handleConfirm);
            btnCancelar = new ButtonForm("Cancelar", 300, 520, this.handleCancel);

            this.Controls.Add(fieldDataNascimento.lblField);
            this.Controls.Add(fieldDataNascimento.txtField);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
        }

        private void handleConfirm(object sender, EventArgs e)
        {
            string title = "Atenção"; 
            string message = "Paciente Cadastrado";  
            MessageBox.Show(message, title);
            this.Close();

        }

        
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }

}