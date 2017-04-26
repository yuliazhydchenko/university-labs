namespace Laboratorna1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mydbDataSet = new Laboratorna1.mydbDataSet();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new Laboratorna1.mydbDataSetTableAdapters.countryTableAdapter();
            this.tableAdapterManager = new Laboratorna1.mydbDataSetTableAdapters.TableAdapterManager();
            this.venuesTableAdapter = new Laboratorna1.mydbDataSetTableAdapters.venuesTableAdapter();
            this.countryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.countryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.countryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фаилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сооружениеСобытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.событиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.venuesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingNavigator)).BeginInit();
            this.countryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venuesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "country";
            this.countryBindingSource.DataSource = this.mydbDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.countryTableAdapter = this.countryTableAdapter;
            this.tableAdapterManager.eventsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Laboratorna1.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.venuesTableAdapter = this.venuesTableAdapter;
            // 
            // venuesTableAdapter
            // 
            this.venuesTableAdapter.ClearBeforeFill = true;
            // 
            // countryBindingNavigator
            // 
            this.countryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.countryBindingNavigator.BindingSource = this.countryBindingSource;
            this.countryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.countryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.countryBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.countryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.countryBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.countryBindingNavigator.Location = new System.Drawing.Point(0, 264);
            this.countryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.countryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.countryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.countryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.countryBindingNavigator.Name = "countryBindingNavigator";
            this.countryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.countryBindingNavigator.Size = new System.Drawing.Size(899, 25);
            this.countryBindingNavigator.TabIndex = 0;
            this.countryBindingNavigator.Text = "bindingNavigator1";
            this.countryBindingNavigator.MouseHover += new System.EventHandler(this.countryBindingNavigator_MouseHover);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // countryBindingNavigatorSaveItem
            // 
            this.countryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("countryBindingNavigatorSaveItem.Image")));
            this.countryBindingNavigatorSaveItem.Name = "countryBindingNavigatorSaveItem";
            this.countryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.countryBindingNavigatorSaveItem.Text = "Save Data";
            this.countryBindingNavigatorSaveItem.Click += new System.EventHandler(this.countryBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // countryDataGridView
            // 
            this.countryDataGridView.AutoGenerateColumns = false;
            this.countryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1});
            this.countryDataGridView.DataSource = this.countryBindingSource;
            this.countryDataGridView.Location = new System.Drawing.Point(0, 37);
            this.countryDataGridView.Name = "countryDataGridView";
            this.countryDataGridView.Size = new System.Drawing.Size(445, 220);
            this.countryDataGridView.TabIndex = 1;
            this.countryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.countryDataGridView_CellContentClick);
            this.countryDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.countryDataGridView_KeyDown);
            this.countryDataGridView.MouseHover += new System.EventHandler(this.countryDataGridView_MouseHover);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idcountry";
            this.dataGridViewTextBoxColumn1.HeaderText = "idcountry";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ToolTipText = "ИДДД";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "capital";
            this.dataGridViewTextBoxColumn3.HeaderText = "capital";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "flag";
            this.dataGridViewImageColumn1.HeaderText = "flag";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фаилToolStripMenuItem,
            this.таблицыToolStripMenuItem,
            this.помощьToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menuStrip1_KeyDown);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // фаилToolStripMenuItem
            // 
            this.фаилToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.фаилToolStripMenuItem.Name = "фаилToolStripMenuItem";
            this.фаилToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.фаилToolStripMenuItem.Text = "Фаил";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сооружениеСобытиеToolStripMenuItem,
            this.событиеToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // сооружениеСобытиеToolStripMenuItem
            // 
            this.сооружениеСобытиеToolStripMenuItem.Name = "сооружениеСобытиеToolStripMenuItem";
            this.сооружениеСобытиеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.сооружениеСобытиеToolStripMenuItem.Text = "Сооружение-Событие";
            this.сооружениеСобытиеToolStripMenuItem.Click += new System.EventHandler(this.сооружениеСобытиеToolStripMenuItem_Click);
            // 
            // событиеToolStripMenuItem
            // 
            this.событиеToolStripMenuItem.Name = "событиеToolStripMenuItem";
            this.событиеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.событиеToolStripMenuItem.Text = "Событие";
            this.событиеToolStripMenuItem.Click += new System.EventHandler(this.событиеToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem1
            // 
            this.помощьToolStripMenuItem1.Name = "помощьToolStripMenuItem1";
            this.помощьToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem1.Text = "Помощь";
            this.помощьToolStripMenuItem1.Click += new System.EventHandler(this.помощьToolStripMenuItem1_Click);
            // 
            // venuesDataGridView
            // 
            this.venuesDataGridView.AutoGenerateColumns = false;
            this.venuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venuesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.venuesDataGridView.DataSource = this.venuesBindingSource;
            this.venuesDataGridView.Location = new System.Drawing.Point(451, 37);
            this.venuesDataGridView.Name = "venuesDataGridView";
            this.venuesDataGridView.Size = new System.Drawing.Size(446, 220);
            this.venuesDataGridView.TabIndex = 3;
            this.venuesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.venuesDataGridView_KeyDown);
            this.venuesDataGridView.MouseHover += new System.EventHandler(this.venuesDataGridView_MouseHover);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idvenues";
            this.dataGridViewTextBoxColumn4.HeaderText = "idvenues";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn5.HeaderText = "name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "place";
            this.dataGridViewTextBoxColumn6.HeaderText = "place";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "country_idcountry";
            this.dataGridViewTextBoxColumn7.HeaderText = "country_idcountry";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // venuesBindingSource
            // 
            this.venuesBindingSource.DataMember = "fk_venues_country1";
            this.venuesBindingSource.DataSource = this.countryBindingSource;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "D:\\Разработка ПО\\Lab1_PT\\SportEvents\\Laboratorna1\\My.chm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 289);
            this.Controls.Add(this.venuesDataGridView);
            this.Controls.Add(this.countryDataGridView);
            this.Controls.Add(this.countryBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingNavigator)).EndInit();
            this.countryBindingNavigator.ResumeLayout(false);
            this.countryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venuesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venuesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private mydbDataSetTableAdapters.countryTableAdapter countryTableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator countryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton countryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView countryDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фаилToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private mydbDataSetTableAdapters.venuesTableAdapter venuesTableAdapter;
        private System.Windows.Forms.BindingSource venuesBindingSource;
        private System.Windows.Forms.DataGridView venuesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сооружениеСобытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem событиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

