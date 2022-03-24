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
    public class Dentista : Pessoa
    {
        FieldForm fieldCro;
        FieldForm fieldSalario;
        FieldForm fieldEspecialidade;
        ButtonForm btnConfirmar;
        ButtonForm btnCancelar;

        public Dentista() 
        {
            fieldCro = new FieldForm("C.R.O.",20,320,120,20);
            fieldEspecialidade = new FieldForm("Especialidade",20,380,120,20);
            fieldSalario = new FieldForm("Salário",20,440,100,20);
           		
            btnConfirmar = new ButtonForm("Confirmar", 200, 520, this.handleConfirm);
            btnCancelar = new ButtonForm("Cancelar", 300, 520, this.handleCancel);

            this.Controls.Add(fieldCro.lblField);
            this.Controls.Add(fieldCro.txtField);
            this.Controls.Add(fieldEspecialidade.lblField);
            this.Controls.Add(fieldEspecialidade.txtField);
            this.Controls.Add(fieldSalario.lblField);
            this.Controls.Add(fieldSalario.txtField);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
        }

        private void handleConfirm(object sender, EventArgs e)
        {
            string title = "Atenção"; 
            string message = "Dentista Cadastrado";  
            MessageBox.Show(message, title);
            this.Close();

        }

        
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }

}