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
    public class Agendamento : BaseForm
    {
        FieldForm fieldPacienteId;
        FieldForm fieldDentistaId;
        FieldForm fieldSalaId;
        FieldForm fieldData;
		ButtonForm btnConfirmar;
        ButtonForm btnCancelar;
        
        public Agendamento() : base("Agendamento",SizeScreen.Small)
        {
            fieldPacienteId = new FieldForm("ID Paciente",20,20,120,20);
            fieldDentistaId = new FieldForm("ID Dentista",20,80,120,60);
            fieldSalaId = new FieldForm("ID Sala",20,140,120,60);
            fieldData = new FieldForm("Data",20,200,120,60);

			btnConfirmar = new ButtonForm("Confirmar", 180, 220, this.handleConfirm);
            btnCancelar = new ButtonForm("Cancelar", 180, 260, this.handleCancel);

            this.Controls.Add(fieldPacienteId.lblField);
            this.Controls.Add(fieldPacienteId.txtField);
            this.Controls.Add(fieldDentistaId.lblField);
            this.Controls.Add(fieldDentistaId.txtField);
            this.Controls.Add(fieldSalaId.lblField);
            this.Controls.Add(fieldSalaId.txtField);
            this.Controls.Add(fieldData.lblField);
            this.Controls.Add(fieldData.txtField);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
        }

       
        private void handleConfirm(object sender, EventArgs e)
        {
            string title = "Atenção"; 
            string message = "Agendamento Cadastrado";  
            MessageBox.Show(message, title);
            this.Close();

        }

        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }

}