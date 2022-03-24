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
    public class MenuDentista : BaseForm
    {
        ButtonForm btnDentista;
        ButtonForm btnPaciente;
        ButtonForm btnProcedimento;
        ButtonForm btnEspecialidade;
        ButtonForm btnSala;
        ButtonForm btnAgendamento;
        ButtonForm btnCancelar;

        public MenuDentista() : base("Menu Dentista",SizeScreen.Small)
        {
            btnDentista = new ButtonForm("Dentista", 30, 70, this.Dentista);
            btnPaciente = new ButtonForm("Paciente", 30, 120, this.Paciente);
            btnProcedimento = new ButtonForm("Procedimento", 170, 70, this.Procedimento);
            btnEspecialidade = new ButtonForm("Especialidade", 170, 120, this.Especialidade);
            btnSala = new ButtonForm("Sala", 30, 170, this.Sala);
            btnAgendamento = new ButtonForm("Agendamento", 170, 170, this.Agendamento);
            btnCancelar = new ButtonForm("Cancelar", 100, 230, this.handleCancel);

            this.Controls.Add(btnDentista);
            this.Controls.Add(btnPaciente);
            this.Controls.Add(btnProcedimento);
            this.Controls.Add(btnEspecialidade);
            this.Controls.Add(btnSala);
            this.Controls.Add(btnAgendamento);
            this.Controls.Add(btnCancelar);

        }

        private void Dentista(object sender, EventArgs e)
        {
            (new CrudDentista()).Show();

        }
        private void Paciente(object sender, EventArgs e)
        {
            (new CrudPaciente()).Show();

        }
        private void Procedimento(object sender, EventArgs e)
        {
            (new CrudProcedimento()).Show();

        }
        private void Especialidade(object sender, EventArgs e)
        {
            (new CrudEspecilidade()).Show();

        }
        private void Sala(object sender, EventArgs e)
        {
            (new CrudSala()).Show();

        }
        private void Agendamento(object sender, EventArgs e)
        {
            (new CrudAgendamento()).Show();

        }
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}