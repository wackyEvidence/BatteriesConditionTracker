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
            menuStrip1 = new MenuStrip();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            экспортToolStripMenuItem1 = new ToolStripMenuItem();
            cSVToolStripMenuItem1 = new ToolStripMenuItem();
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
            dataGridView1 = new DataGridView();
            deleteBatteryButton = new Button();
            editBatteryButton = new Button();
            addBatteryButton = new Button();
            groupBoxFilters = new GroupBox();
            linkLabel1 = new LinkLabel();
            comboBox1 = new ComboBox();
            batterStatusComboBox = new ComboBox();
            batteryPlannedReplacementDateLabel = new Label();
            plannedReplacementDateCheckedListBox = new CheckedListBox();
            batterySubsystemLabel = new Label();
            subsystemCheckedListBox = new CheckedListBox();
            batteryStructureLabel = new Label();
            structureCheckedListBox = new CheckedListBox();
            batteryCapacityLabel = new Label();
            capacityCheckedListBox = new CheckedListBox();
            batteryManufacturerLabel = new Label();
            manufacturerCheckedListBox = new CheckedListBox();
            deleteUserFilterButton = new Button();
            addUserFilterButton = new Button();
            userFiltersLabel = new Label();
            userFiltersListBox = new ListBox();
            removeSortButton = new Button();
            sortSettingsButton = new Button();
            highlightButton = new Button();
            groupBoxSort = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxFilters.SuspendLayout();
            groupBoxSort.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { настройкиToolStripMenuItem, панельАдминистратораToolStripMenuItem, отчётToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1466, 46);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { печатьToolStripMenuItem, экспортToolStripMenuItem1, выходToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(96, 42);
            настройкиToolStripMenuItem.Text = "Файл";
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            печатьToolStripMenuItem.Size = new Size(211, 42);
            печатьToolStripMenuItem.Text = "Печать";
            // 
            // экспортToolStripMenuItem1
            // 
            экспортToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cSVToolStripMenuItem1 });
            экспортToolStripMenuItem1.Name = "экспортToolStripMenuItem1";
            экспортToolStripMenuItem1.Size = new Size(211, 42);
            экспортToolStripMenuItem1.Text = "Экспорт";
            // 
            // cSVToolStripMenuItem1
            // 
            cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            cSVToolStripMenuItem1.Size = new Size(157, 42);
            cSVToolStripMenuItem1.Text = "CSV";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(211, 42);
            выходToolStripMenuItem.Text = "Выход";
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(809, 808);
            dataGridView1.TabIndex = 10;
            // 
            // deleteBatteryButton
            // 
            deleteBatteryButton.FlatAppearance.BorderColor = Color.Silver;
            deleteBatteryButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            deleteBatteryButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            deleteBatteryButton.FlatStyle = FlatStyle.Flat;
            deleteBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteBatteryButton.Location = new Point(677, 878);
            deleteBatteryButton.Name = "deleteBatteryButton";
            deleteBatteryButton.Size = new Size(143, 52);
            deleteBatteryButton.TabIndex = 15;
            deleteBatteryButton.Text = "Удалить";
            deleteBatteryButton.UseVisualStyleBackColor = true;
            // 
            // editBatteryButton
            // 
            editBatteryButton.FlatAppearance.BorderColor = Color.Silver;
            editBatteryButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            editBatteryButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            editBatteryButton.FlatStyle = FlatStyle.Flat;
            editBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            editBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            editBatteryButton.Location = new Point(170, 878);
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
            addBatteryButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            addBatteryButton.FlatStyle = FlatStyle.Flat;
            addBatteryButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addBatteryButton.ForeColor = Color.FromArgb(0, 121, 194);
            addBatteryButton.Location = new Point(11, 878);
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
            groupBoxFilters.Controls.Add(linkLabel1);
            groupBoxFilters.Controls.Add(comboBox1);
            groupBoxFilters.Controls.Add(batterStatusComboBox);
            groupBoxFilters.Controls.Add(batteryPlannedReplacementDateLabel);
            groupBoxFilters.Controls.Add(plannedReplacementDateCheckedListBox);
            groupBoxFilters.Controls.Add(batterySubsystemLabel);
            groupBoxFilters.Controls.Add(subsystemCheckedListBox);
            groupBoxFilters.Controls.Add(batteryStructureLabel);
            groupBoxFilters.Controls.Add(structureCheckedListBox);
            groupBoxFilters.Controls.Add(batteryCapacityLabel);
            groupBoxFilters.Controls.Add(capacityCheckedListBox);
            groupBoxFilters.Controls.Add(batteryManufacturerLabel);
            groupBoxFilters.Controls.Add(manufacturerCheckedListBox);
            groupBoxFilters.Controls.Add(deleteUserFilterButton);
            groupBoxFilters.Controls.Add(addUserFilterButton);
            groupBoxFilters.Controls.Add(userFiltersLabel);
            groupBoxFilters.Controls.Add(userFiltersListBox);
            groupBoxFilters.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxFilters.ForeColor = Color.FromArgb(0, 121, 194);
            groupBoxFilters.Location = new Point(826, 46);
            groupBoxFilters.Name = "groupBoxFilters";
            groupBoxFilters.Size = new Size(633, 781);
            groupBoxFilters.TabIndex = 12;
            groupBoxFilters.TabStop = false;
            groupBoxFilters.Text = "Фильтрация";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(376, 104);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(252, 31);
            linkLabel1.TabIndex = 36;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Сбросить все фильтры";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "требует замены", "не требует замены ", "заменен", "все" });
            comboBox1.Location = new Point(6, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(288, 45);
            comboBox1.TabIndex = 35;
            comboBox1.Text = "Статус замены";
            // 
            // batterStatusComboBox
            // 
            batterStatusComboBox.ForeColor = Color.Gray;
            batterStatusComboBox.FormattingEnabled = true;
            batterStatusComboBox.Items.AddRange(new object[] { "эксплуатируемые", "выведенные из эксплуатации ", "все" });
            batterStatusComboBox.Location = new Point(6, 39);
            batterStatusComboBox.Name = "batterStatusComboBox";
            batterStatusComboBox.Size = new Size(421, 45);
            batterStatusComboBox.TabIndex = 34;
            batterStatusComboBox.Text = "Статус эксплуатации";
            // 
            // batteryPlannedReplacementDateLabel
            // 
            batteryPlannedReplacementDateLabel.AutoSize = true;
            batteryPlannedReplacementDateLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            batteryPlannedReplacementDateLabel.Location = new Point(291, 462);
            batteryPlannedReplacementDateLabel.Name = "batteryPlannedReplacementDateLabel";
            batteryPlannedReplacementDateLabel.Size = new Size(320, 38);
            batteryPlannedReplacementDateLabel.TabIndex = 33;
            batteryPlannedReplacementDateLabel.Text = "Требует замены через: ";
            // 
            // plannedReplacementDateCheckedListBox
            // 
            plannedReplacementDateCheckedListBox.FormattingEnabled = true;
            plannedReplacementDateCheckedListBox.Location = new Point(291, 503);
            plannedReplacementDateCheckedListBox.Name = "plannedReplacementDateCheckedListBox";
            plannedReplacementDateCheckedListBox.Size = new Size(333, 118);
            plannedReplacementDateCheckedListBox.TabIndex = 32;
            // 
            // batterySubsystemLabel
            // 
            batterySubsystemLabel.AutoSize = true;
            batterySubsystemLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            batterySubsystemLabel.Location = new Point(6, 462);
            batterySubsystemLabel.Name = "batterySubsystemLabel";
            batterySubsystemLabel.Size = new Size(176, 38);
            batterySubsystemLabel.TabIndex = 31;
            batterySubsystemLabel.Text = "Подсистема:";
            // 
            // subsystemCheckedListBox
            // 
            subsystemCheckedListBox.FormattingEnabled = true;
            subsystemCheckedListBox.Location = new Point(6, 503);
            subsystemCheckedListBox.Name = "subsystemCheckedListBox";
            subsystemCheckedListBox.Size = new Size(256, 118);
            subsystemCheckedListBox.TabIndex = 30;
            // 
            // batteryStructureLabel
            // 
            batteryStructureLabel.AutoSize = true;
            batteryStructureLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            batteryStructureLabel.Location = new Point(291, 138);
            batteryStructureLabel.Name = "batteryStructureLabel";
            batteryStructureLabel.Size = new Size(117, 38);
            batteryStructureLabel.TabIndex = 29;
            batteryStructureLabel.Text = "Объект:";
            // 
            // structureCheckedListBox
            // 
            structureCheckedListBox.FormattingEnabled = true;
            structureCheckedListBox.Location = new Point(291, 179);
            structureCheckedListBox.Name = "structureCheckedListBox";
            structureCheckedListBox.Size = new Size(329, 270);
            structureCheckedListBox.TabIndex = 28;
            // 
            // batteryCapacityLabel
            // 
            batteryCapacityLabel.AutoSize = true;
            batteryCapacityLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            batteryCapacityLabel.Location = new Point(6, 300);
            batteryCapacityLabel.Name = "batteryCapacityLabel";
            batteryCapacityLabel.Size = new Size(125, 38);
            batteryCapacityLabel.TabIndex = 27;
            batteryCapacityLabel.Text = "Емкость:";
            // 
            // capacityCheckedListBox
            // 
            capacityCheckedListBox.FormattingEnabled = true;
            capacityCheckedListBox.Location = new Point(6, 341);
            capacityCheckedListBox.Name = "capacityCheckedListBox";
            capacityCheckedListBox.Size = new Size(256, 118);
            capacityCheckedListBox.TabIndex = 26;
            // 
            // batteryManufacturerLabel
            // 
            batteryManufacturerLabel.AutoSize = true;
            batteryManufacturerLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            batteryManufacturerLabel.Location = new Point(6, 138);
            batteryManufacturerLabel.Name = "batteryManufacturerLabel";
            batteryManufacturerLabel.Size = new Size(220, 38);
            batteryManufacturerLabel.TabIndex = 25;
            batteryManufacturerLabel.Text = "Производитель:";
            // 
            // manufacturerCheckedListBox
            // 
            manufacturerCheckedListBox.FormattingEnabled = true;
            manufacturerCheckedListBox.Location = new Point(6, 179);
            manufacturerCheckedListBox.Name = "manufacturerCheckedListBox";
            manufacturerCheckedListBox.Size = new Size(256, 118);
            manufacturerCheckedListBox.TabIndex = 24;
            // 
            // deleteUserFilterButton
            // 
            deleteUserFilterButton.FlatAppearance.BorderColor = Color.Silver;
            deleteUserFilterButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            deleteUserFilterButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            deleteUserFilterButton.FlatStyle = FlatStyle.Flat;
            deleteUserFilterButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            deleteUserFilterButton.ForeColor = Color.FromArgb(0, 121, 194);
            deleteUserFilterButton.Location = new Point(376, 720);
            deleteUserFilterButton.Name = "deleteUserFilterButton";
            deleteUserFilterButton.Size = new Size(248, 55);
            deleteUserFilterButton.TabIndex = 23;
            deleteUserFilterButton.Text = "Удалить фильтр";
            deleteUserFilterButton.UseVisualStyleBackColor = true;
            // 
            // addUserFilterButton
            // 
            addUserFilterButton.FlatAppearance.BorderColor = Color.Silver;
            addUserFilterButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            addUserFilterButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            addUserFilterButton.FlatStyle = FlatStyle.Flat;
            addUserFilterButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            addUserFilterButton.ForeColor = Color.FromArgb(0, 121, 194);
            addUserFilterButton.Location = new Point(376, 661);
            addUserFilterButton.Name = "addUserFilterButton";
            addUserFilterButton.Size = new Size(248, 55);
            addUserFilterButton.TabIndex = 22;
            addUserFilterButton.Text = "Добавить фильтр";
            addUserFilterButton.UseVisualStyleBackColor = true;
            addUserFilterButton.Click += addUserFilterButton_Click;
            // 
            // userFiltersLabel
            // 
            userFiltersLabel.AutoSize = true;
            userFiltersLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            userFiltersLabel.Location = new Point(6, 620);
            userFiltersLabel.Name = "userFiltersLabel";
            userFiltersLabel.Size = new Size(377, 38);
            userFiltersLabel.TabIndex = 1;
            userFiltersLabel.Text = "Пользовательские фильтры:";
            // 
            // userFiltersListBox
            // 
            userFiltersListBox.FormattingEnabled = true;
            userFiltersListBox.ItemHeight = 37;
            userFiltersListBox.Location = new Point(6, 661);
            userFiltersListBox.Name = "userFiltersListBox";
            userFiltersListBox.Size = new Size(364, 115);
            userFiltersListBox.TabIndex = 0;
            // 
            // removeSortButton
            // 
            removeSortButton.FlatAppearance.BorderColor = Color.Silver;
            removeSortButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            removeSortButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            removeSortButton.FlatStyle = FlatStyle.Flat;
            removeSortButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            removeSortButton.ForeColor = Color.FromArgb(0, 121, 194);
            removeSortButton.Location = new Point(330, 42);
            removeSortButton.Name = "removeSortButton";
            removeSortButton.Size = new Size(290, 55);
            removeSortButton.TabIndex = 20;
            removeSortButton.Text = "Убрать сортировку";
            removeSortButton.UseVisualStyleBackColor = true;
            // 
            // sortSettingsButton
            // 
            sortSettingsButton.FlatAppearance.BorderColor = Color.Silver;
            sortSettingsButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            sortSettingsButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            sortSettingsButton.FlatStyle = FlatStyle.Flat;
            sortSettingsButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            sortSettingsButton.ForeColor = Color.FromArgb(0, 121, 194);
            sortSettingsButton.Location = new Point(6, 42);
            sortSettingsButton.Name = "sortSettingsButton";
            sortSettingsButton.Size = new Size(318, 55);
            sortSettingsButton.TabIndex = 21;
            sortSettingsButton.Text = "Настройка сортировки ";
            sortSettingsButton.UseVisualStyleBackColor = true;
            sortSettingsButton.Click += sortSettingsButton_Click;
            // 
            // highlightButton
            // 
            highlightButton.FlatAppearance.BorderColor = Color.Silver;
            highlightButton.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            highlightButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            highlightButton.FlatStyle = FlatStyle.Flat;
            highlightButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            highlightButton.ForeColor = Color.FromArgb(0, 121, 194);
            highlightButton.Location = new Point(398, 878);
            highlightButton.Name = "highlightButton";
            highlightButton.Size = new Size(273, 52);
            highlightButton.TabIndex = 16;
            highlightButton.Text = "Выделить цветом...";
            highlightButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxSort
            // 
            groupBoxSort.BackColor = Color.White;
            groupBoxSort.Controls.Add(removeSortButton);
            groupBoxSort.Controls.Add(sortSettingsButton);
            groupBoxSort.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxSort.ForeColor = Color.FromArgb(0, 121, 194);
            groupBoxSort.Location = new Point(826, 833);
            groupBoxSort.Name = "groupBoxSort";
            groupBoxSort.Size = new Size(633, 104);
            groupBoxSort.TabIndex = 22;
            groupBoxSort.TabStop = false;
            groupBoxSort.Text = "Сортировка";
            // 
            // BatteriesListForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1466, 943);
            Controls.Add(groupBoxSort);
            Controls.Add(highlightButton);
            Controls.Add(deleteBatteryButton);
            Controls.Add(groupBoxFilters);
            Controls.Add(editBatteryButton);
            Controls.Add(addBatteryButton);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 121, 194);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "BatteriesListForm";
            Text = "Таблица";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxFilters.ResumeLayout(false);
            groupBoxFilters.PerformLayout();
            groupBoxSort.ResumeLayout(false);
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
        private DataGridView dataGridView1;
        private GroupBox groupBoxFilters;
        private Button deleteBatteryButton;
        private Button editBatteryButton;
        private Button addBatteryButton;
        private Label userFiltersLabel;
        private ListBox userFiltersListBox;
        private Button highlightButton;
        private Button sortSettingsButton;
        private Button removeSortButton;
        private Button deleteUserFilterButton;
        private Button addUserFilterButton;
        private Label batteryStructureLabel;
        private CheckedListBox structureCheckedListBox;
        private Label batteryCapacityLabel;
        private CheckedListBox capacityCheckedListBox;
        private Label batteryManufacturerLabel;
        private CheckedListBox manufacturerCheckedListBox;
        private Label batterySubsystemLabel;
        private CheckedListBox subsystemCheckedListBox;
        private Label batteryPlannedReplacementDateLabel;
        private CheckedListBox plannedReplacementDateCheckedListBox;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem экспортToolStripMenuItem1;
        private ToolStripMenuItem cSVToolStripMenuItem1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ComboBox batterStatusComboBox;
        private GroupBox groupBoxSort;
        private ComboBox comboBox1;
        private ToolStripMenuItem отчётToolStripMenuItem;
        private ToolStripMenuItem аккумуляторыТребующиеЗаменыToolStripMenuItem;
        private ToolStripMenuItem structureTypesToolStripMenuItem;
        private ToolStripMenuItem batterySpecsToolStripMenuItem;
        private ToolStripMenuItem batterySubsystemsToolStripMenuItem;
        private ToolStripMenuItem batteryClampTypesToolStripMenuItem;
        private ToolStripMenuItem batteryTechnologyToolStripMenuItem;
        private ToolStripMenuItem positionsToolStripMenuItem;
        private LinkLabel linkLabel1;
    }
}