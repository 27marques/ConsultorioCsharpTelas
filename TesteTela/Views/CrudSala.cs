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
    public class CrudSala : BaseForm
    {
        ListView listView;
        ButtonForm btnCadastrar;
        ButtonForm btnEditar;
        ButtonForm btnExcluir;
        ButtonForm btnCancelar;
       
        public CrudSala() : base("Lista de Salas",SizeScreen.Small)
        {
            listView = new ListView();
			listView.Location = new Point(10, 20);
			listView.Size = new Size(230,180);
            listView.View = View.Details;
            ListViewItem Sala1 = new ListViewItem("Sala 01-A");
			Sala1.SubItems.Add("Raio-X");
            listView.Items.AddRange(new ListViewItem[]{Sala1});
			listView.Columns.Add("Numero", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Equipamento", -2, HorizontalAlignment.Left);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;
			
            btnCadastrar = new ButtonForm("Cadastrar", 10, 220, this.CadastrarSala);
            btnEditar = new ButtonForm("Editar", 10, 260, this.EditarSala);
            btnExcluir = new ButtonForm("Excluir", 120, 220, this.ExcluirSala);
            btnCancelar = new ButtonForm("Cancelar", 120, 260, this.handleCancel);

            this.Controls.Add(listView);
            this.Controls.Add(btnCadastrar);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnExcluir);
            this.Controls.Add(btnCancelar);

        }
  
        private void CadastrarSala(object sender, EventArgs e)
        {
            (new Sala()).Show();

        }
        private void EditarSala(object sender, EventArgs e)
        {
            (new CrudSala()).Show();

        }
        private void ExcluirSala(object sender, EventArgs e)
        {
            (new CrudSala()).Show();

        }
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}