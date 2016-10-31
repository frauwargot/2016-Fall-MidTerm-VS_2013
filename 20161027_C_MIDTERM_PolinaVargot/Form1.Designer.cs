namespace _20161027_C_MIDTERM_PolinaVargot
{
    partial class CarsForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDisplayAllCars = new System.Windows.Forms.Button();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDisplayMostExpensiveCar = new System.Windows.Forms.Button();
            this.txtMadeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetCarsByMade = new System.Windows.Forms.Button();
            this.btnGetCarsByCustomerID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInputCustomerID = new System.Windows.Forms.TextBox();
            this.cboInputCarType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetCarsByType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(998, 460);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Make";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mileage";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "EngineSize";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "AverageMpg";
            this.columnHeader7.Width = 120;
            // 
            // btnDisplayAllCars
            // 
            this.btnDisplayAllCars.Location = new System.Drawing.Point(12, 478);
            this.btnDisplayAllCars.Name = "btnDisplayAllCars";
            this.btnDisplayAllCars.Size = new System.Drawing.Size(172, 36);
            this.btnDisplayAllCars.TabIndex = 1;
            this.btnDisplayAllCars.Text = "Display all cars";
            this.btnDisplayAllCars.UseVisualStyleBackColor = true;
            this.btnDisplayAllCars.Click += new System.EventHandler(this.btnDisplayAllCars_Click);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CustomerID";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "0to60";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "MaxTowing";
            this.columnHeader10.Width = 120;
            // 
            // btnDisplayMostExpensiveCar
            // 
            this.btnDisplayMostExpensiveCar.Location = new System.Drawing.Point(200, 478);
            this.btnDisplayMostExpensiveCar.Name = "btnDisplayMostExpensiveCar";
            this.btnDisplayMostExpensiveCar.Size = new System.Drawing.Size(278, 36);
            this.btnDisplayMostExpensiveCar.TabIndex = 2;
            this.btnDisplayMostExpensiveCar.Text = "Display most expensive car";
            this.btnDisplayMostExpensiveCar.UseVisualStyleBackColor = true;
            this.btnDisplayMostExpensiveCar.Click += new System.EventHandler(this.btnDisplayMostExpensiveCar_Click);
            // 
            // txtMadeInput
            // 
            this.txtMadeInput.Location = new System.Drawing.Point(668, 481);
            this.txtMadeInput.Name = "txtMadeInput";
            this.txtMadeInput.Size = new System.Drawing.Size(127, 30);
            this.txtMadeInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Get Cars By Make:";
            // 
            // btnGetCarsByMade
            // 
            this.btnGetCarsByMade.Location = new System.Drawing.Point(801, 481);
            this.btnGetCarsByMade.Name = "btnGetCarsByMade";
            this.btnGetCarsByMade.Size = new System.Drawing.Size(75, 30);
            this.btnGetCarsByMade.TabIndex = 5;
            this.btnGetCarsByMade.Text = "Get!";
            this.btnGetCarsByMade.UseVisualStyleBackColor = true;
            this.btnGetCarsByMade.Click += new System.EventHandler(this.btnGetCarsByMade_Click);
            // 
            // btnGetCarsByCustomerID
            // 
            this.btnGetCarsByCustomerID.Location = new System.Drawing.Point(801, 517);
            this.btnGetCarsByCustomerID.Name = "btnGetCarsByCustomerID";
            this.btnGetCarsByCustomerID.Size = new System.Drawing.Size(75, 30);
            this.btnGetCarsByCustomerID.TabIndex = 8;
            this.btnGetCarsByCustomerID.Text = "Get!";
            this.btnGetCarsByCustomerID.UseVisualStyleBackColor = true;
            this.btnGetCarsByCustomerID.Click += new System.EventHandler(this.btnGetCarsByCustomerID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Get Cars By CustomerID:";
            // 
            // txtInputCustomerID
            // 
            this.txtInputCustomerID.Location = new System.Drawing.Point(668, 517);
            this.txtInputCustomerID.Name = "txtInputCustomerID";
            this.txtInputCustomerID.Size = new System.Drawing.Size(127, 30);
            this.txtInputCustomerID.TabIndex = 6;
            // 
            // cboInputCarType
            // 
            this.cboInputCarType.FormattingEnabled = true;
            this.cboInputCarType.Items.AddRange(new object[] {
            "Car",
            "Sport Car",
            "Truck"});
            this.cboInputCarType.Location = new System.Drawing.Point(192, 520);
            this.cboInputCarType.Name = "cboInputCarType";
            this.cboInputCarType.Size = new System.Drawing.Size(142, 33);
            this.cboInputCarType.TabIndex = 9;
            this.cboInputCarType.Text = "Select type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Get Cars By Type:";
            // 
            // btnGetCarsByType
            // 
            this.btnGetCarsByType.Location = new System.Drawing.Point(340, 520);
            this.btnGetCarsByType.Name = "btnGetCarsByType";
            this.btnGetCarsByType.Size = new System.Drawing.Size(75, 33);
            this.btnGetCarsByType.TabIndex = 11;
            this.btnGetCarsByType.Text = "Get!";
            this.btnGetCarsByType.UseVisualStyleBackColor = true;
            this.btnGetCarsByType.Click += new System.EventHandler(this.btnGetCarsByType_Click);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 609);
            this.Controls.Add(this.btnGetCarsByType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboInputCarType);
            this.Controls.Add(this.btnGetCarsByCustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInputCustomerID);
            this.Controls.Add(this.btnGetCarsByMade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMadeInput);
            this.Controls.Add(this.btnDisplayMostExpensiveCar);
            this.Controls.Add(this.btnDisplayAllCars);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CarsForm";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnDisplayAllCars;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnDisplayMostExpensiveCar;
        private System.Windows.Forms.TextBox txtMadeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetCarsByMade;
        private System.Windows.Forms.Button btnGetCarsByCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInputCustomerID;
        private System.Windows.Forms.ComboBox cboInputCarType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetCarsByType;
    }
}

