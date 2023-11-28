namespace BatteriesConditionTrackerUI
{
    partial class BatteriesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteriesListForm));
            menuStrip1 = new MenuStrip();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            панельАдминистратораToolStripMenuItem = new ToolStripMenuItem();
            batteryModelsToolStripMenuItem = new ToolStripMenuItem();
            staffToolStripMenuItem = new ToolStripMenuItem();
            positionsToolStripMenuItem = new ToolStripMenuItem();
            structuresToolStripMenuItem = new ToolStripMenuItem();
            structureTypesToolStripMenuItem = new ToolStripMenuItem();
            batterySpecsToolStripMenuItem = new ToolStripMenuItem();
            batterySubsystemsToolStripMenuItem = new ToolStripMenuItem();
            batteryClampTypesToolStripMenuItem = new ToolStripMenuItem();
            batteryTechnologyToolStripMenuItem = new ToolStripMenuItem();
            отчётToolStripMenuItem = new ToolStripMenuItem();
            аккумуляторыТребующиеЗаменыToolStripMenuItem = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();
            dataGridView = new DataGridView();
            deleteBatteryButton = new Button();
            editBatteryButton = new Button();
            addBatteryButton = new Button();
            groupBoxFilters = new GroupBox();
            resetAllFiltersLinkLabel = new LinkLabel();
            replacementStatusComboBox = new ComboBox();
            exploitationStatusComboBox = new ComboBox();
            subsystemLabel = new Label();
            subsystemCheckedListBox = new CheckedListBox();
            structureLabel = new Label();
            structuresCheckedListBox = new CheckedListBox();
            capacityLabel = new Label();
            capacitiesCheckedListBox = new CheckedListBox();
            brandLabel = new Label();
            brandsCheckedListBox = new CheckedListBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBoxFilters.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { настройкиToolStripMenuItem, панельАдминистратораToolStripMenuItem, отчётToolStripMenuItem, aboutMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1466, 46);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(96, 42);
            настройкиToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(188, 42);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // панельАдминистратораToolStripMenuItem
            // 
            панельАдминистратораToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { batteryModelsToolStripMenuItem, staffToolStripMenuItem, positionsToolStripMenuItem, structuresToolStripMenuItem, structureTypesToolStripMenuItem, batterySpecsToolStripMenuItem });
            панельАдминистратораToolStripMenuItem.Name = "панельАдминистратораToolStripMenuItem";
            панельАдминистратораToolStripMenuItem.Size = new Size(131, 42);
            панельАдминистратораToolStripMenuItem.Text = "Данные";
            // 
            // batteryModelsToolStripMenuItem
            // 
            batteryModelsToolStripMenuItem.Name = "batteryModelsToolStripMenuItem";
            batteryModelsToolStripMenuItem.Size = new Size(512, 42);
            batteryModelsToolStripMenuItem.Text = "Модели аккумуляторов";
            batteryModelsToolStripMenuItem.Click += batteryModelsToolStripMenuItem_Click;
            // 
            // staffToolStripMenuItem
            // 
            staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            staffToolStripMenuItem.Size = new Size(512, 42);
            staffToolStripMenuItem.Text = "Сотрудники";
            staffToolStripMenuItem.Click += staffToolStripMenuItem_Click;
            // 
            // positionsToolStripMenuItem
            // 
            positionsToolStripMenuItem.Name = "positionsToolStripMenuItem";
            positionsToolStripMenuItem.Size = new Size(512, 42);
            positionsToolStripMenuItem.Text = "Должности";
            positionsToolStripMenuItem.Click += positionsToolStripMenuItem_Click;
            // 
            // structuresToolStripMenuItem
            // 
            structuresToolStripMenuItem.Name = "structuresToolStripMenuItem";
            structuresToolStripMenuItem.Size = new Size(512, 42);
            structuresToolStripMenuItem.Text = "Объекты";
            structuresToolStripMenuItem.Click += structuresToolStripMenuItem_Click;
            // 
            // structureTypesToolStripMenuItem
            // 
            structureTypesToolStripMenuItem.Name = "structureTypesToolStripMenuItem";
            structureTypesToolStripMenuItem.Size = new Size(512, 42);
            structureTypesToolStripMenuItem.Text = "Типы объектов";
            structureTypesToolStripMenuItem.Click += structureTypesToolStripMenuItem_Click;
            // 
            // batterySpecsToolStripMenuItem
            // 
            batterySpecsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { batterySubsystemsToolStripMenuItem, batteryClampTypesToolStripMenuItem, batteryTechnologyToolStripMenuItem });
            batterySpecsToolStripMenuItem.Name = "batterySpecsToolStripMenuItem";
            batterySpecsToolStripMenuItem.Size = new Size(512, 42);
            batterySpecsToolStripMenuItem.Text = "Характеристики аккумуляторов";
            // 
            // batterySubsystemsToolStripMenuItem
            // 
            batterySubsystemsToolStripMenuItem.Name = "batterySubsystemsToolStripMenuItem";
            batterySubsystemsToolStripMenuItem.Size = new Size(275, 42);
            batterySubsystemsToolStripMenuItem.Text = "Подсистемы";
            batterySubsystemsToolStripMenuItem.Click += batterySubsystemsToolStripMenuItem_Click;
            // 
            // batteryClampTypesToolStripMenuItem
            // 
            batteryClampTypesToolStripMenuItem.Name = "batteryClampTypesToolStripMenuItem";
            batteryClampTypesToolStripMenuItem.Size = new Size(275, 42);
            batteryClampTypesToolStripMenuItem.Text = "Типы клемм ";
            batteryClampTypesToolStripMenuItem.Click += batteryClampTypesToolStripMenuItem_Click;
            // 
            // batteryTechnologyToolStripMenuItem
            // 
            batteryTechnologyToolStripMenuItem.Name = "batteryTechnologyToolStripMenuItem";
            batteryTechnologyToolStripMenuItem.Size = new Size(275, 42);
            batteryTechnologyToolStripMenuItem.Text = "Технологии";
            batteryTechnologyToolStripMenuItem.Click += batteryTechnologyToolStripMenuItem_Click;
            // 
            // отчётToolStripMenuItem
            // 
            отчётToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { аккумуляторыТребующиеЗаменыToolStripMenuItem });
            отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            отчётToolStripMenuItem.Size = new Size(113, 42);
            отчётToolStripMenuItem.Text = "Отчёт ";
            // 
            // аккумуляторыТребующиеЗаменыToolStripMenuItem
            // 
            аккумуляторыТребующиеЗаменыToolStripMenuItem.Name = "аккумуляторыТребующиеЗаменыToolStripMenuItem";
            аккумуляторыТребующиеЗаменыToolStripMenuItem.Size = new Size(562, 42);
            аккумуляторыТребующиеЗаменыToolStripMenuItem.Text = "Аккумуляторы, требующие замены";
            аккумуляторыТребующиеЗаменыToolStripMenuItem.Click += аккумуляторыТребующиеЗаменыToolStripMenuItem_Click;
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new Size(44, 42);
            aboutMenuItem.Text = "?";
            aboutMenuItem.Click += aboutMenuItem_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView.BackgroundColor = Color.Gainsboro;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(11, 64);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(809, 632);
            dataGridView.TabIndex = 10;
            dataGridView.CellMouseDoubleClick += dataGridView_CellMouseDoubleClick;
            // 
            // deleteBatteryButton
            // 
            deleteBatteryButton.FlatAppearance.BorderColor = Color.Silver;
            deleteBatteryButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            deleteBatteryButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            deleteBatteryButton.FlatStyle = FlatStyle.Flat;
            deleteBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteBatteryButton.Location = new Point(677, 702);
            deleteBatteryButton.Name = "deleteBatteryButton";
            deleteBatteryButton.Size = new Size(143, 52);
            deleteBatteryButton.TabIndex = 15;
            deleteBatteryButton.Text = "Удалить";
            deleteBatteryButton.UseVisualStyleBackColor = true;
            deleteBatteryButton.Click += deleteBatteryButton_Click;
            // 
            // editBatteryButton
            // 
            editBatteryButton.FlatAppearance.BorderColor = Color.Silver;
            editBatteryButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            editBatteryButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            editBatteryButton.FlatStyle = FlatStyle.Flat;
            editBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            editBatteryButton.Location = new Point(170, 702);
            editBatteryButton.Name = "editBatteryButton";
            editBatteryButton.Size = new Size(222, 52);
            editBatteryButton.TabIndex = 14;
            editBatteryButton.Text = "Редактировать";
            editBatteryButton.UseVisualStyleBackColor = true;
            editBatteryButton.Click += editBatteryButton_Click;
            // 
            // addBatteryButton
            // 
            addBatteryButton.FlatAppearance.BorderColor = Color.Silver;
            addBatteryButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            addBatteryButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            addBatteryButton.FlatStyle = FlatStyle.Flat;
            addBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            addBatteryButton.Location = new Point(11, 702);
            addBatteryButton.Name = "addBatteryButton";
            addBatteryButton.Size = new Size(153, 52);
            addBatteryButton.TabIndex = 13;
            addBatteryButton.Text = "Добавить";
            addBatteryButton.UseVisualStyleBackColor = true;
            addBatteryButton.Click += addBatteryButton_Click;
            // 
            // groupBoxFilters
            // 
            groupBoxFilters.BackColor = Color.White;
            groupBoxFilters.Controls.Add(resetAllFiltersLinkLabel);
            groupBoxFilters.Controls.Add(replacementStatusComboBox);
            groupBoxFilters.Controls.Add(exploitationStatusComboBox);
            groupBoxFilters.Controls.Add(subsystemLabel);
            groupBoxFilters.Controls.Add(subsystemCheckedListBox);
            groupBoxFilters.Controls.Add(structureLabel);
            groupBoxFilters.Controls.Add(structuresCheckedListBox);
            groupBoxFilters.Controls.Add(capacityLabel);
            groupBoxFilters.Controls.Add(capacitiesCheckedListBox);
            groupBoxFilters.Controls.Add(brandLabel);
            groupBoxFilters.Controls.Add(brandsCheckedListBox);
            groupBoxFilters.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxFilters.ForeColor = Color.FromArgb(0, 121, 194);
            groupBoxFilters.Location = new Point(826, 46);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Size = new Size(633, 708);
            groupBoxFilters.TabIndex = 12;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Фильтрация";
            // 
            // resetAllFiltersLinkLabel
            // 
            resetAllFiltersLinkLabel.AutoSize = true;
            resetAllFiltersLinkLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            resetAllFiltersLinkLabel.Location = new Point(376, 104);
            resetAllFiltersLinkLabel.Name = "resetAllFiltersLinkLabel";
            resetAllFiltersLinkLabel.Size = new Size(252, 31);
            resetAllFiltersLinkLabel.TabIndex = 36;
            resetAllFiltersLinkLabel.TabStop = true;
            resetAllFiltersLinkLabel.Text = "Сбросить все фильтры";
            resetAllFiltersLinkLabel.LinkClicked += resetAllFiltersLinkLabel_LinkClicked;
            // 
            // replacementStatusComboBox
            // 
            replacementStatusComboBox.ForeColor = Color.Gray;
            replacementStatusComboBox.FormattingEnabled = true;
            replacementStatusComboBox.Location = new Point(6, 90);
            replacementStatusComboBox.Name = "replacementStatusComboBox";
            replacementStatusComboBox.Size = new Size(288, 45);
            replacementStatusComboBox.TabIndex = 35;
            replacementStatusComboBox.Text = "Статус замены";
            replacementStatusComboBox.SelectedIndexChanged += replacementStatusComboBox_SelectedIndexChanged;
            // 
            // exploitationStatusComboBox
            // 
            exploitationStatusComboBox.ForeColor = Color.Gray;
            exploitationStatusComboBox.FormattingEnabled = true;
            exploitationStatusComboBox.Location = new Point(6, 39);
            exploitationStatusComboBox.Name = "exploitationStatusComboBox";
            exploitationStatusComboBox.Size = new Size(421, 45);
            exploitationStatusComboBox.TabIndex = 34;
            exploitationStatusComboBox.Text = "Статус эксплуатации";
            exploitationStatusComboBox.SelectedIndexChanged += exploitationStatusComboBox_SelectedIndexChanged;
            // 
            // subsystemLabel
            // 
            subsystemLabel.AutoSize = true;
            subsystemLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            subsystemLabel.Location = new Point(6, 462);
            subsystemLabel.Name = "subsystemLabel";
            subsystemLabel.Size = new Size(176, 38);
            subsystemLabel.TabIndex = 31;
            subsystemLabel.Text = "Подсистема:";
            // 
            // subsystemCheckedListBox
            // 
            subsystemCheckedListBox.CheckOnClick = true;
            subsystemCheckedListBox.FormattingEnabled = true;
            subsystemCheckedListBox.Location = new Point(6, 503);
            subsystemCheckedListBox.Name = "subsystemCheckedListBox";
            subsystemCheckedListBox.Size = new Size(256, 194);
            subsystemCheckedListBox.TabIndex = 30;
            subsystemCheckedListBox.SelectedIndexChanged += subsystemCheckedListBox_SelectedIndexChanged;
            // 
            // structureLabel
            // 
            structureLabel.AutoSize = true;
            structureLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            structureLabel.Location = new Point(291, 138);
            structureLabel.Name = "structureLabel";
            structureLabel.Size = new Size(117, 38);
            structureLabel.TabIndex = 29;
            structureLabel.Text = "Объект:";
            // 
            // structuresCheckedListBox
            // 
            structuresCheckedListBox.CheckOnClick = true;
            structuresCheckedListBox.FormattingEnabled = true;
            structuresCheckedListBox.Location = new Point(291, 179);
            structuresCheckedListBox.Name = "structuresCheckedListBox";
            structuresCheckedListBox.Size = new Size(329, 498);
            structuresCheckedListBox.TabIndex = 28;
            structuresCheckedListBox.SelectedIndexChanged += structuresCheckedListBox_SelectedIndexChanged;
            // 
            // capacityLabel
            // 
            capacityLabel.AutoSize = true;
            capacityLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            capacityLabel.Location = new Point(6, 300);
            capacityLabel.Name = "capacityLabel";
            capacityLabel.Size = new Size(125, 38);
            capacityLabel.TabIndex = 27;
            capacityLabel.Text = "Емкость:";
            // 
            // capacitiesCheckedListBox
            // 
            capacitiesCheckedListBox.CheckOnClick = true;
            capacitiesCheckedListBox.FormattingEnabled = true;
            capacitiesCheckedListBox.Location = new Point(6, 341);
            capacitiesCheckedListBox.Name = "capacitiesCheckedListBox";
            capacitiesCheckedListBox.Size = new Size(256, 118);
            capacitiesCheckedListBox.TabIndex = 26;
            capacitiesCheckedListBox.SelectedIndexChanged += capacitiesCheckedListBox_SelectedIndexChanged;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            brandLabel.Location = new Point(6, 138);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(101, 38);
            brandLabel.TabIndex = 25;
            brandLabel.Text = "Бренд:";
            // 
            // brandsCheckedListBox
            // 
            brandsCheckedListBox.CheckOnClick = true;
            brandsCheckedListBox.FormattingEnabled = true;
            brandsCheckedListBox.Location = new Point(6, 179);
            brandsCheckedListBox.Name = "brandsCheckedListBox";
            brandsCheckedListBox.Size = new Size(256, 118);
            brandsCheckedListBox.TabIndex = 24;
            brandsCheckedListBox.SelectedIndexChanged += brandsCheckedListBox_SelectedIndexChanged;
            // 
            // BatteriesListForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1466, 766);
            Controls.Add(deleteBatteryButton);
            Controls.Add(groupBoxFilters);
            Controls.Add(editBatteryButton);
            Controls.Add(addBatteryButton);
            Controls.Add(dataGridView);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "BatteriesListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список аккумуляторов";
            Load += BatteriesListForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBoxFilters.ResumeLayout(false);
            groupBoxFilters.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem панельАдминистратораToolStripMenuItem;
        private ToolStripMenuItem batteryModelsToolStripMenuItem;
        private ToolStripMenuItem staffToolStripMenuItem;
        private ToolStripMenuItem structuresToolStripMenuItem;
        private DataGridView dataGridView;
        private GroupBox groupBoxFilters;
        private Button deleteBatteryButton;
        private Button editBatteryButton;
        private Button addBatteryButton;
        private Label structureLabel;
        private CheckedListBox structuresCheckedListBox;
        private Label capacityLabel;
        private CheckedListBox capacitiesCheckedListBox;
        private Label brandLabel;
        private CheckedListBox brandsCheckedListBox;
        private Label subsystemLabel;
        private CheckedListBox subsystemCheckedListBox;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ComboBox exploitationStatusComboBox;
        private ComboBox replacementStatusComboBox;
        private ToolStripMenuItem отчётToolStripMenuItem;
        private ToolStripMenuItem аккумуляторыТребующиеЗаменыToolStripMenuItem;
        private ToolStripMenuItem structureTypesToolStripMenuItem;
        private ToolStripMenuItem batterySpecsToolStripMenuItem;
        private ToolStripMenuItem batterySubsystemsToolStripMenuItem;
        private ToolStripMenuItem batteryClampTypesToolStripMenuItem;
        private ToolStripMenuItem batteryTechnologyToolStripMenuItem;
        private ToolStripMenuItem positionsToolStripMenuItem;
        private LinkLabel resetAllFiltersLinkLabel;
        private ToolStripMenuItem aboutMenuItem;
    }
}