namespace RaceLog;

partial class Form1
{
    /// <summary>
    ///  Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    ///  Требуемый метод для поддержки конструктора — не изменяйте 
    ///  содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
        lblDriver = new Label();
        txtDriver = new TextBox();
        lblCar = new Label();
        cmbCar = new ComboBox();
        lblTrack = new Label();
        cmbTrack = new ComboBox();
        lblTime = new Label();
        txtTime = new TextBox();
        lblResults = new Label();
        lstResults = new ListBox();
        btnAdd = new Button();
        btnClear = new Button();
        btnDelete = new Button();
        lblStatus = new Label();
        SuspendLayout();
        // 
        // lblDriver
        // 
        lblDriver.AutoSize = true;
        lblDriver.Location = new Point(24, 28);
        lblDriver.Name = "lblDriver";
        lblDriver.Size = new Size(50, 19);
        lblDriver.TabIndex = 9;
        lblDriver.Text = "Пилот:";
        // 
        // txtDriver
        // 
        txtDriver.Location = new Point(24, 54);
        txtDriver.Name = "txtDriver";
        txtDriver.Size = new Size(250, 28);
        txtDriver.TabIndex = 0;
        // 
        // lblCar
        // 
        lblCar.AutoSize = true;
        lblCar.Location = new Point(24, 98);
        lblCar.Name = "lblCar";
        lblCar.Size = new Size(90, 19);
        lblCar.TabIndex = 10;
        lblCar.Text = "Автомобиль:";
        // 
        // cmbCar
        // 
        cmbCar.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCar.FormattingEnabled = true;
        cmbCar.Items.AddRange(new object[] {
            "Street",
            "Sport",
            "Prototype"});
        cmbCar.Location = new Point(24, 124);
        cmbCar.Name = "cmbCar";
        cmbCar.Size = new Size(250, 28);
        cmbCar.TabIndex = 1;
        // 
        // lblTrack
        // 
        lblTrack.AutoSize = true;
        lblTrack.Location = new Point(24, 168);
        lblTrack.Name = "lblTrack";
        lblTrack.Size = new Size(54, 19);
        lblTrack.TabIndex = 11;
        lblTrack.Text = "Трасса:";
        // 
        // cmbTrack
        // 
        cmbTrack.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTrack.FormattingEnabled = true;
        cmbTrack.Items.AddRange(new object[] {
            "Учебный овал",
            "Городское кольцо",
            "Спринт"});
        cmbTrack.Location = new Point(24, 194);
        cmbTrack.Name = "cmbTrack";
        cmbTrack.Size = new Size(250, 28);
        cmbTrack.TabIndex = 2;
        // 
        // lblTime
        // 
        lblTime.AutoSize = true;
        lblTime.Location = new Point(24, 238);
        lblTime.Name = "lblTime";
        lblTime.Size = new Size(106, 19);
        lblTime.TabIndex = 12;
        lblTime.Text = "Время круга, с:";
        // 
        // txtTime
        // 
        txtTime.Location = new Point(24, 264);
        txtTime.Name = "txtTime";
        txtTime.Size = new Size(250, 28);
        txtTime.TabIndex = 3;
        // 
        // lblResults
        // 
        lblResults.AutoSize = true;
        lblResults.Location = new Point(304, 28);
        lblResults.Name = "lblResults";
        lblResults.Size = new Size(129, 19);
        lblResults.TabIndex = 13;
        lblResults.Text = "Результаты заездов";
        // 
        // lstResults
        // 
        lstResults.HorizontalScrollbar = true;
        lstResults.ItemHeight = 17;
        lstResults.Location = new Point(304, 54);
        lstResults.Name = "lstResults";
        lstResults.SelectionMode = SelectionMode.One;
        lstResults.Size = new Size(652, 296);
        lstResults.TabIndex = 6;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(24, 310);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(120, 32);
        btnAdd.TabIndex = 4;
        btnAdd.Text = "Добавить";
        btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        // 
        // btnClear
        // 
        btnClear.Location = new Point(154, 310);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(120, 32);
        btnClear.TabIndex = 5;
        btnClear.Text = "Очистить поля";
        btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(304, 360);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(160, 32);
        btnDelete.TabIndex = 7;
        btnDelete.Text = "Удалить выбранную";
        btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        // 
        // lblStatus
        // 
        lblStatus.AutoSize = false;
        lblStatus.Location = new Point(24, 434);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(932, 48);
        lblStatus.TabIndex = 8;
        lblStatus.Text = "Введите имя пилота";
        // 
        // Form1
        // 
        AcceptButton = btnAdd;
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(980, 500);
        Controls.Add(lblStatus);
        Controls.Add(btnDelete);
        Controls.Add(btnClear);
        Controls.Add(btnAdd);
        Controls.Add(lstResults);
        Controls.Add(lblResults);
        Controls.Add(txtTime);
        Controls.Add(lblTime);
        Controls.Add(cmbTrack);
        Controls.Add(lblTrack);
        Controls.Add(cmbCar);
        Controls.Add(lblCar);
        Controls.Add(txtDriver);
        Controls.Add(lblDriver);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Журнал заездов";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblDriver;
    private TextBox txtDriver;
    private Label lblCar;
    private ComboBox cmbCar;
    private Label lblTrack;
    private ComboBox cmbTrack;
    private Label lblTime;
    private TextBox txtTime;
    private Label lblResults;
    private ListBox lstResults;
    private Button btnAdd;
    private Button btnClear;
    private Button btnDelete;
    private Label lblStatus;
}
