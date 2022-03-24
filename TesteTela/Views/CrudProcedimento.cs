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
    public class CrudProcedimento : BaseForm
    {
        ListView listView;
        ButtonForm btnCadastrar;
        ButtonForm btnEditar;
        ButtonForm btnExcluir;
        ButtonForm btnCancelar;
       
        public CrudProcedimento() : base("Lista de Procedimentos",SizeScreen.Small)
        {
            listView = new ListView();
			listView.Location = new Point(10, 20);
			listView.Size = new Size(230,180);
            listView.View = View.Details;
            ListViewItem Procedimento1 = new ListViewItem("Restauração");
			Procedimento1.SubItems.Add("R$ 150,00");
            listView.Items.AddRange(new ListViewItem[]{Procedimento1});
			listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Preço", -2, HorizontalAlignment.Left);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;
			
            btnCadastrar = new ButtonForm("Cadastrar", 10, 220, this.CadastrarProcedimento);
            btnEditar = new ButtonForm("Editar", 10, 260, this.EditarProcedimento);
            btnExcluir = new ButtonForm("Excluir", 120, 220, this.ExcluirProcedimento);
            btnCancelar = new ButtonForm("Cancelar", 120, 260, this.handleCancel);

            this.Controls.Add(listView);
            this.Controls.Add(btnCadastrar);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnExcluir);
            this.Controls.Add(btnCancelar);

        }
  
        private void CadastrarProcedimento(object sender, EventArgs e)
        {
            (new Procedimento()).Show();

        }
        private void EditarProcedimento(object sender, EventArgs e)
        {
            (new CrudSala()).Show();

        }
        private void ExcluirProcedimento(object sender, EventArgs e)
        {
            (new CrudSala()).Show();

        }
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}