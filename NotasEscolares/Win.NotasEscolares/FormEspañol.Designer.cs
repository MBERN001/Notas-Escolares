namespace Win.NotasEscolares
{
    partial class FormEspañol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEspañol));
            System.Windows.Forms.Label examenLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label notaFinalLabel;
            System.Windows.Forms.Label notaTotalLabel;
            System.Windows.Forms.Label tareaLabel;
            this.listaEspañolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaEspañolBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaEspañolBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.examenTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.notaFinalTextBox = new System.Windows.Forms.TextBox();
            this.notaTotalTextBox = new System.Windows.Forms.TextBox();
            this.tareaTextBox = new System.Windows.Forms.TextBox();
            this.españolDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            examenLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            notaFinalLabel = new System.Windows.Forms.Label();
            notaTotalLabel = new System.Windows.Forms.Label();
            tareaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaEspañolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEspañolBindingNavigator)).BeginInit();
            this.listaEspañolBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.españolDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listaEspañolBindingSource
            // 
            this.listaEspañolBindingSource.DataSource = typeof(BL.Notas.Español);
            // 
            // listaEspañolBindingNavigator
            // 
            this.listaEspañolBindingNavigator.AddNewItem = null;
            this.listaEspañolBindingNavigator.BindingSource = this.listaEspañolBindingSource;
            this.listaEspañolBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaEspañolBindingNavigator.DeleteItem = null;
            this.listaEspañolBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaEspañolBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaEspañolBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaEspañolBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaEspañolBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaEspañolBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaEspañolBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaEspañolBindingNavigator.Name = "listaEspañolBindingNavigator";
            this.listaEspañolBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaEspañolBindingNavigator.Size = new System.Drawing.Size(706, 25);
            this.listaEspañolBindingNavigator.TabIndex = 0;
            this.listaEspañolBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listaEspañolBindingNavigatorSaveItem
            // 
            this.listaEspañolBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaEspañolBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaEspañolBindingNavigatorSaveItem.Image")));
            this.listaEspañolBindingNavigatorSaveItem.Name = "listaEspañolBindingNavigatorSaveItem";
            this.listaEspañolBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaEspañolBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaEspañolBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaEspañolBindingNavigatorSaveItem_Click);
            // 
            // examenLabel
            // 
            examenLabel.AutoSize = true;
            examenLabel.Location = new System.Drawing.Point(51, 124);
            examenLabel.Name = "examenLabel";
            examenLabel.Size = new System.Drawing.Size(48, 13);
            examenLabel.TabIndex = 1;
            examenLabel.Text = "Examen:";
            // 
            // examenTextBox
            // 
            this.examenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEspañolBindingSource, "Examen", true));
            this.examenTextBox.Location = new System.Drawing.Point(117, 121);
            this.examenTextBox.Name = "examenTextBox";
            this.examenTextBox.Size = new System.Drawing.Size(433, 20);
            this.examenTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(51, 63);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(39, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Parcial";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEspañolBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(117, 60);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(433, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // notaFinalLabel
            // 
            notaFinalLabel.AutoSize = true;
            notaFinalLabel.Location = new System.Drawing.Point(51, 156);
            notaFinalLabel.Name = "notaFinalLabel";
            notaFinalLabel.Size = new System.Drawing.Size(58, 13);
            notaFinalLabel.TabIndex = 5;
            notaFinalLabel.Text = "Nota Final:";
            // 
            // notaFinalTextBox
            // 
            this.notaFinalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEspañolBindingSource, "NotaFinal", true));
            this.notaFinalTextBox.Location = new System.Drawing.Point(117, 153);
            this.notaFinalTextBox.Name = "notaFinalTextBox";
            this.notaFinalTextBox.Size = new System.Drawing.Size(433, 20);
            this.notaFinalTextBox.TabIndex = 6;
            // 
            // notaTotalLabel
            // 
            notaTotalLabel.AutoSize = true;
            notaTotalLabel.Location = new System.Drawing.Point(51, 182);
            notaTotalLabel.Name = "notaTotalLabel";
            notaTotalLabel.Size = new System.Drawing.Size(60, 13);
            notaTotalLabel.TabIndex = 7;
            notaTotalLabel.Text = "Nota Total:";
            // 
            // notaTotalTextBox
            // 
            this.notaTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEspañolBindingSource, "NotaTotal", true));
            this.notaTotalTextBox.Location = new System.Drawing.Point(117, 179);
            this.notaTotalTextBox.Name = "notaTotalTextBox";
            this.notaTotalTextBox.Size = new System.Drawing.Size(433, 20);
            this.notaTotalTextBox.TabIndex = 8;
            // 
            // tareaLabel
            // 
            tareaLabel.AutoSize = true;
            tareaLabel.Location = new System.Drawing.Point(51, 98);
            tareaLabel.Name = "tareaLabel";
            tareaLabel.Size = new System.Drawing.Size(38, 13);
            tareaLabel.TabIndex = 9;
            tareaLabel.Text = "Tarea:";
            // 
            // tareaTextBox
            // 
            this.tareaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaEspañolBindingSource, "Tarea", true));
            this.tareaTextBox.Location = new System.Drawing.Point(117, 95);
            this.tareaTextBox.Name = "tareaTextBox";
            this.tareaTextBox.Size = new System.Drawing.Size(433, 20);
            this.tareaTextBox.TabIndex = 10;
            // 
            // españolDataGridView
            // 
            this.españolDataGridView.AutoGenerateColumns = false;
            this.españolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.españolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.españolDataGridView.DataSource = this.listaEspañolBindingSource;
            this.españolDataGridView.Location = new System.Drawing.Point(74, 216);
            this.españolDataGridView.Name = "españolDataGridView";
            this.españolDataGridView.Size = new System.Drawing.Size(552, 195);
            this.españolDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tarea";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tarea";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Examen";
            this.dataGridViewTextBoxColumn3.HeaderText = "Examen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NotaFinal";
            this.dataGridViewTextBoxColumn4.HeaderText = "NotaFinal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NotaTotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "NotaTotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // FormEspañol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 505);
            this.Controls.Add(this.españolDataGridView);
            this.Controls.Add(examenLabel);
            this.Controls.Add(this.examenTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(notaFinalLabel);
            this.Controls.Add(this.notaFinalTextBox);
            this.Controls.Add(notaTotalLabel);
            this.Controls.Add(this.notaTotalTextBox);
            this.Controls.Add(tareaLabel);
            this.Controls.Add(this.tareaTextBox);
            this.Controls.Add(this.listaEspañolBindingNavigator);
            this.Name = "FormEspañol";
            this.Text = "Español";
            ((System.ComponentModel.ISupportInitialize)(this.listaEspañolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEspañolBindingNavigator)).EndInit();
            this.listaEspañolBindingNavigator.ResumeLayout(false);
            this.listaEspañolBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.españolDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaEspañolBindingSource;
        private System.Windows.Forms.BindingNavigator listaEspañolBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaEspañolBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox examenTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox notaFinalTextBox;
        private System.Windows.Forms.TextBox notaTotalTextBox;
        private System.Windows.Forms.TextBox tareaTextBox;
        private System.Windows.Forms.DataGridView españolDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}