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
    public class CrudEspecilidade : BaseForm
    {
        ListView listView;
        ButtonForm btnCadastrar;
        ButtonForm btnEditar;
        ButtonForm btnExcluir;
        ButtonForm btnCancelar;
       
        public CrudEspecilidade() : base("Lista de Especialidade",SizeScreen.Small)
        {
            listView = new ListView();
			listView.Location = new Point(10, 20);
			listView.Size = new Size(280,180);
            listView.View = View.Details;
            ListViewItem Especialidade1 = new ListViewItem("Clínico Geral");
			Especialidade1.SubItems.Add("Avaliação e procedimentos básicos");
            listView.Items.AddRange(new ListViewItem[]{Especialidade1});
			listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Detalhamento", -2, HorizontalAlignment.Left);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;
			
            btnCadastrar = new ButtonForm("Cadastrar", 10, 220, this.CadastrarEspecialidade);
            btnEditar = new ButtonForm("Editar", 10, 260, this.EditarEspecialidade);
            btnExcluir = new ButtonForm("Excluir", 120, 220, this.ExcluirEspecialidade);
            btnCancelar = new ButtonForm("Cancelar", 120, 260, this.handleCancel);

            this.Controls.Add(listView);
            this.Controls.Add(btnCadastrar);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnExcluir);
            this.Controls.Add(btnCancelar);

        }
  
        private void CadastrarEspecialidade(object sender, EventArgs e)
        {
            (new Especialidade()).Show();

        }
        private void EditarEspecialidade(object sender, EventArgs e)
        {
            (new CrudSala()).Show();

        }
        private void ExcluirEspecialidade(object sender, EventArgs e)
        {
            (new CrudSala()).Show();

        }
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}