namespace _08._12._19_Cars_serialization
{
    partial class mainForm
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
            this.lblAddANewCar = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.btnPickAColor = new System.Windows.Forms.Button();
            this.cmbAllTheCars = new System.Windows.Forms.ComboBox();
            this.btnCreateANewCar = new System.Windows.Forms.Button();
            this.lblCodan = new System.Windows.Forms.Label();
            this.lblNumberOfSeats = new System.Windows.Forms.Label();
            this.numCodan = new System.Windows.Forms.NumericUpDown();
            this.numNumberOfSeats = new System.Windows.Forms.NumericUpDown();
            this.lblCurrentCar = new System.Windows.Forms.Label();
            this.btnDrserializeACarByCtor = new System.Windows.Forms.Button();
            this.btnDeserializeACar = new System.Windows.Forms.Button();
            this.btnDrserializeACarByCtor_ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCodan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddANewCar
            // 
            this.lblAddANewCar.AutoSize = true;
            this.lblAddANewCar.Location = new System.Drawing.Point(13, 13);
            this.lblAddANewCar.Name = "lblAddANewCar";
            this.lblAddANewCar.Size = new System.Drawing.Size(76, 13);
            this.lblAddANewCar.TabIndex = 0;
            this.lblAddANewCar.Text = "Add a new car";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(16, 44);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(16, 72);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(16, 235);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(16, 264);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(61, 41);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(176, 20);
            this.txtModel.TabIndex = 5;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(61, 69);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(176, 20);
            this.txtBrand.TabIndex = 6;
            // 
            // dtpYear
            // 
            this.dtpYear.Location = new System.Drawing.Point(61, 229);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(100, 20);
            this.dtpYear.TabIndex = 7;
            // 
            // btnPickAColor
            // 
            this.btnPickAColor.Location = new System.Drawing.Point(61, 259);
            this.btnPickAColor.Name = "btnPickAColor";
            this.btnPickAColor.Size = new System.Drawing.Size(100, 23);
            this.btnPickAColor.TabIndex = 8;
            this.btnPickAColor.Text = "PickAColor";
            this.btnPickAColor.UseVisualStyleBackColor = true;
            // 
            // cmbAllTheCars
            // 
            this.cmbAllTheCars.FormattingEnabled = true;
            this.cmbAllTheCars.Location = new System.Drawing.Point(362, 36);
            this.cmbAllTheCars.Name = "cmbAllTheCars";
            this.cmbAllTheCars.Size = new System.Drawing.Size(229, 21);
            this.cmbAllTheCars.TabIndex = 9;
            this.cmbAllTheCars.SelectedIndexChanged += new System.EventHandler(this.cmbAllTheCars_SelectedIndexChanged);
            // 
            // btnCreateANewCar
            // 
            this.btnCreateANewCar.AutoSize = true;
            this.btnCreateANewCar.Location = new System.Drawing.Point(19, 304);
            this.btnCreateANewCar.Name = "btnCreateANewCar";
            this.btnCreateANewCar.Size = new System.Drawing.Size(105, 23);
            this.btnCreateANewCar.TabIndex = 10;
            this.btnCreateANewCar.Text = "Create a new car";
            this.btnCreateANewCar.UseVisualStyleBackColor = true;
            this.btnCreateANewCar.Click += new System.EventHandler(this.btnCreateANewCar_Click);
            // 
            // lblCodan
            // 
            this.lblCodan.AutoSize = true;
            this.lblCodan.Location = new System.Drawing.Point(16, 106);
            this.lblCodan.Name = "lblCodan";
            this.lblCodan.Size = new System.Drawing.Size(41, 13);
            this.lblCodan.TabIndex = 11;
            this.lblCodan.Text = "Codan:";
            // 
            // lblNumberOfSeats
            // 
            this.lblNumberOfSeats.AutoSize = true;
            this.lblNumberOfSeats.Location = new System.Drawing.Point(19, 140);
            this.lblNumberOfSeats.Name = "lblNumberOfSeats";
            this.lblNumberOfSeats.Size = new System.Drawing.Size(72, 13);
            this.lblNumberOfSeats.TabIndex = 13;
            this.lblNumberOfSeats.Text = "Seat Number:";
            // 
            // numCodan
            // 
            this.numCodan.Location = new System.Drawing.Point(146, 99);
            this.numCodan.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numCodan.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCodan.Name = "numCodan";
            this.numCodan.Size = new System.Drawing.Size(91, 20);
            this.numCodan.TabIndex = 14;
            this.numCodan.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numNumberOfSeats
            // 
            this.numNumberOfSeats.Location = new System.Drawing.Point(146, 133);
            this.numNumberOfSeats.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numNumberOfSeats.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numNumberOfSeats.Name = "numNumberOfSeats";
            this.numNumberOfSeats.Size = new System.Drawing.Size(91, 20);
            this.numNumberOfSeats.TabIndex = 15;
            this.numNumberOfSeats.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblCurrentCar
            // 
            this.lblCurrentCar.AutoSize = true;
            this.lblCurrentCar.Location = new System.Drawing.Point(362, 72);
            this.lblCurrentCar.Name = "lblCurrentCar";
            this.lblCurrentCar.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentCar.TabIndex = 16;
            // 
            // btnDrserializeACarByCtor
            // 
            this.btnDrserializeACarByCtor.Location = new System.Drawing.Point(365, 196);
            this.btnDrserializeACarByCtor.Name = "btnDrserializeACarByCtor";
            this.btnDrserializeACarByCtor.Size = new System.Drawing.Size(105, 23);
            this.btnDrserializeACarByCtor.TabIndex = 17;
            this.btnDrserializeACarByCtor.Text = "Serialize the car";
            this.btnDrserializeACarByCtor.UseVisualStyleBackColor = true;
            this.btnDrserializeACarByCtor.Click += new System.EventHandler(this.btnSerializeTheCar_Click);
            // 
            // btnDeserializeACar
            // 
            this.btnDeserializeACar.Location = new System.Drawing.Point(19, 333);
            this.btnDeserializeACar.Name = "btnDeserializeACar";
            this.btnDeserializeACar.Size = new System.Drawing.Size(105, 23);
            this.btnDeserializeACar.TabIndex = 18;
            this.btnDeserializeACar.Text = "Deserialize a car";
            this.btnDeserializeACar.UseVisualStyleBackColor = true;
            this.btnDeserializeACar.Click += new System.EventHandler(this.btnDeserializeACar_Click);
            // 
            // btnDrserializeACarByCtor_
            // 
            this.btnDrserializeACarByCtor_.Location = new System.Drawing.Point(19, 362);
            this.btnDrserializeACarByCtor_.Name = "btnDrserializeACarByCtor_";
            this.btnDrserializeACarByCtor_.Size = new System.Drawing.Size(105, 23);
            this.btnDrserializeACarByCtor_.TabIndex = 19;
            this.btnDrserializeACarByCtor_.Text = "Deserialize by Ctor";
            this.btnDrserializeACarByCtor_.UseVisualStyleBackColor = true;
            this.btnDrserializeACarByCtor_.Click += new System.EventHandler(this.btnDrserializeACarByCtor__Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 404);
            this.Controls.Add(this.btnDrserializeACarByCtor_);
            this.Controls.Add(this.btnDeserializeACar);
            this.Controls.Add(this.btnDrserializeACarByCtor);
            this.Controls.Add(this.lblCurrentCar);
            this.Controls.Add(this.numNumberOfSeats);
            this.Controls.Add(this.numCodan);
            this.Controls.Add(this.lblNumberOfSeats);
            this.Controls.Add(this.lblCodan);
            this.Controls.Add(this.btnCreateANewCar);
            this.Controls.Add(this.cmbAllTheCars);
            this.Controls.Add(this.btnPickAColor);
            this.Controls.Add(this.dtpYear);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblAddANewCar);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCodan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddANewCar;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.Button btnPickAColor;
        private System.Windows.Forms.ComboBox cmbAllTheCars;
        private System.Windows.Forms.Button btnCreateANewCar;
        private System.Windows.Forms.Label lblCodan;
        private System.Windows.Forms.Label lblNumberOfSeats;
        private System.Windows.Forms.NumericUpDown numCodan;
        private System.Windows.Forms.NumericUpDown numNumberOfSeats;
        private System.Windows.Forms.Label lblCurrentCar;
        private System.Windows.Forms.Button btnDrserializeACarByCtor;
        private System.Windows.Forms.Button btnDeserializeACar;
        private System.Windows.Forms.Button btnDrserializeACarByCtor_;
    }
}

