using System.Drawing;
using System.Windows.Forms;
using System;

namespace Proiect_POO
{
    partial class GrupePanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblDesiredGroupCount;
        private TextBox txtDesiredGroupCount;
        private Button btnGenerateGroups;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrupePanel));
            this.lblDesiredGroupCount = new System.Windows.Forms.Label();
            this.txtDesiredGroupCount = new System.Windows.Forms.TextBox();
            this.btnGenerateGroups = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBoxPrograms = new System.Windows.Forms.ComboBox();
            this.comboBoxDegrees = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.projectDBDataSet1 = new Proiect_POO.ProjectDBDataSet1();
            this.grupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupeTableAdapter = new Proiect_POO.ProjectDBDataSet1TableAdapters.GrupeTableAdapter();
            this.tableAdapterManager = new Proiect_POO.ProjectDBDataSet1TableAdapters.TableAdapterManager();
            this.grupeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.grupeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.grupeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupeStudentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupeStudentiTableAdapter = new Proiect_POO.ProjectDBDataSet1TableAdapters.GrupeStudentiTableAdapter();
            this.projectDBDataSet2 = new Proiect_POO.ProjectDBDataSet2();
            this.grupeStudentiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grupeStudentiTableAdapter1 = new Proiect_POO.ProjectDBDataSet2TableAdapters.GrupeStudentiTableAdapter();
            this.tableAdapterManager1 = new Proiect_POO.ProjectDBDataSet2TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupeBindingNavigator)).BeginInit();
            this.grupeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupeStudentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupeStudentiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesiredGroupCount
            // 
            this.lblDesiredGroupCount.Location = new System.Drawing.Point(12, 122);
            this.lblDesiredGroupCount.Name = "lblDesiredGroupCount";
            this.lblDesiredGroupCount.Size = new System.Drawing.Size(100, 20);
            this.lblDesiredGroupCount.TabIndex = 0;
            this.lblDesiredGroupCount.Text = "Nr Grupe";
            // 
            // txtDesiredGroupCount
            // 
            this.txtDesiredGroupCount.Location = new System.Drawing.Point(118, 119);
            this.txtDesiredGroupCount.Name = "txtDesiredGroupCount";
            this.txtDesiredGroupCount.Size = new System.Drawing.Size(100, 20);
            this.txtDesiredGroupCount.TabIndex = 1;
            // 
            // btnGenerateGroups
            // 
            this.btnGenerateGroups.Location = new System.Drawing.Point(12, 148);
            this.btnGenerateGroups.Name = "btnGenerateGroups";
            this.btnGenerateGroups.Size = new System.Drawing.Size(150, 30);
            this.btnGenerateGroups.TabIndex = 2;
            this.btnGenerateGroups.Text = "Genereaza Grupe";
            this.btnGenerateGroups.Click += new System.EventHandler(this.btnGenerateGroups_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ciclu";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Programul de studii";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Anul";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // comboBoxPrograms
            // 
            this.comboBoxPrograms.FormattingEnabled = true;
            this.comboBoxPrograms.Location = new System.Drawing.Point(118, 64);
            this.comboBoxPrograms.Name = "comboBoxPrograms";
            this.comboBoxPrograms.Size = new System.Drawing.Size(198, 21);
            this.comboBoxPrograms.TabIndex = 14;
            // 
            // comboBoxDegrees
            // 
            this.comboBoxDegrees.FormattingEnabled = true;
            this.comboBoxDegrees.Location = new System.Drawing.Point(118, 33);
            this.comboBoxDegrees.Name = "comboBoxDegrees";
            this.comboBoxDegrees.Size = new System.Drawing.Size(198, 21);
            this.comboBoxDegrees.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Repartizeaza Studenti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectDBDataSet1
            // 
            this.projectDBDataSet1.DataSetName = "ProjectDBDataSet1";
            this.projectDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grupeBindingSource
            // 
            this.grupeBindingSource.DataMember = "Grupe";
            this.grupeBindingSource.DataSource = this.projectDBDataSet1;
            // 
            // grupeTableAdapter
            // 
            this.grupeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DegreesTableAdapter = null;
            this.tableAdapterManager.DisciplineTableAdapter = null;
            this.tableAdapterManager.GrupeStudentiTableAdapter = null;
            this.tableAdapterManager.GrupeTableAdapter = this.grupeTableAdapter;
            this.tableAdapterManager.PlanInvatamantTableAdapter = null;
            this.tableAdapterManager.ProgrameDeStudiiTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Proiect_POO.ProjectDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // grupeBindingNavigator
            // 
            this.grupeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.grupeBindingNavigator.BindingSource = this.grupeBindingSource;
            this.grupeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.grupeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.grupeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.grupeBindingNavigatorSaveItem});
            this.grupeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.grupeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.grupeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.grupeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.grupeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.grupeBindingNavigator.Name = "grupeBindingNavigator";
            this.grupeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.grupeBindingNavigator.Size = new System.Drawing.Size(857, 25);
            this.grupeBindingNavigator.TabIndex = 17;
            this.grupeBindingNavigator.Text = "bindingNavigator1";
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
            // grupeBindingNavigatorSaveItem
            // 
            this.grupeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.grupeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("grupeBindingNavigatorSaveItem.Image")));
            this.grupeBindingNavigatorSaveItem.Name = "grupeBindingNavigatorSaveItem";
            this.grupeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.grupeBindingNavigatorSaveItem.Text = "Save Data";
            this.grupeBindingNavigatorSaveItem.Click += new System.EventHandler(this.grupeBindingNavigatorSaveItem_Click);
            // 
            // grupeDataGridView
            // 
            this.grupeDataGridView.AutoGenerateColumns = false;
            this.grupeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grupeDataGridView.DataSource = this.grupeBindingSource;
            this.grupeDataGridView.Location = new System.Drawing.Point(438, 12);
            this.grupeDataGridView.Name = "grupeDataGridView";
            this.grupeDataGridView.Size = new System.Drawing.Size(399, 201);
            this.grupeDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cod";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cod";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // grupeStudentiBindingSource
            // 
            this.grupeStudentiBindingSource.DataMember = "GrupeStudenti";
            this.grupeStudentiBindingSource.DataSource = this.projectDBDataSet1;
            // 
            // grupeStudentiTableAdapter
            // 
            this.grupeStudentiTableAdapter.ClearBeforeFill = true;
            // 
            // projectDBDataSet2
            // 
            this.projectDBDataSet2.DataSetName = "ProjectDBDataSet2";
            this.projectDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grupeStudentiBindingSource1
            // 
            this.grupeStudentiBindingSource1.DataMember = "GrupeStudenti";
            this.grupeStudentiBindingSource1.DataSource = this.projectDBDataSet2;
            // 
            // grupeStudentiTableAdapter1
            // 
            this.grupeStudentiTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DegreesTableAdapter = null;
            this.tableAdapterManager1.DisciplineTableAdapter = null;
            this.tableAdapterManager1.GrupeStudentiTableAdapter = this.grupeStudentiTableAdapter1;
            this.tableAdapterManager1.GrupeTableAdapter = null;
            this.tableAdapterManager1.PlanInvatamantTableAdapter = null;
            this.tableAdapterManager1.ProgrameDeStudiiTableAdapter = null;
            this.tableAdapterManager1.StaffTableAdapter = null;
            this.tableAdapterManager1.StudentsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Proiect_POO.ProjectDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // GrupePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 605);
            this.Controls.Add(this.grupeDataGridView);
            this.Controls.Add(this.grupeBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxDegrees);
            this.Controls.Add(this.comboBoxPrograms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDesiredGroupCount);
            this.Controls.Add(this.txtDesiredGroupCount);
            this.Controls.Add(this.btnGenerateGroups);
            this.Name = "GrupePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group Management";
            this.Load += new System.EventHandler(this.GrupePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupeBindingNavigator)).EndInit();
            this.grupeBindingNavigator.ResumeLayout(false);
            this.grupeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupeStudentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupeStudentiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private ComboBox comboBoxPrograms;
        private ComboBox comboBoxDegrees;
        private Button button1;
        private ProjectDBDataSet1 projectDBDataSet1;
        private BindingSource grupeBindingSource;
        private ProjectDBDataSet1TableAdapters.GrupeTableAdapter grupeTableAdapter;
        private ProjectDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private BindingNavigator grupeBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton grupeBindingNavigatorSaveItem;
        private DataGridView grupeDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource grupeStudentiBindingSource;
        private ProjectDBDataSet1TableAdapters.GrupeStudentiTableAdapter grupeStudentiTableAdapter;
        private ProjectDBDataSet2 projectDBDataSet2;
        private BindingSource grupeStudentiBindingSource1;
        private ProjectDBDataSet2TableAdapters.GrupeStudentiTableAdapter grupeStudentiTableAdapter1;
        private ProjectDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
    }

        #endregion
  }
