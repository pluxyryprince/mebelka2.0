
namespace mebelka2._0
{
    partial class add_contract
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
            this.label5 = new System.Windows.Forms.Label();
            this.add_contract_button = new System.Windows.Forms.Button();
            this.enter_id_client = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furniture_storeDataSet = new mebelka2._0.furniture_storeDataSet();
            this.clientTableAdapter = new mebelka2._0.furniture_storeDataSetTableAdapters.clientTableAdapter();
            this.enter_id_furniture = new System.Windows.Forms.ComboBox();
            this.furnturemodelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.furnture_modelTableAdapter = new mebelka2._0.furniture_storeDataSetTableAdapters.furnture_modelTableAdapter();
            this.enter_name_furniture = new System.Windows.Forms.ComboBox();
            this.enter_model_furniture = new System.Windows.Forms.ComboBox();
            this.count = new System.Windows.Forms.TextBox();
            this.registration_date = new System.Windows.Forms.MonthCalendar();
            this.realization_date = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reg_date = new System.Windows.Forms.Label();
            this.release_date = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furniture_storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnturemodelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(259, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Добавление договора";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // add_contract_button
            // 
            this.add_contract_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_contract_button.Location = new System.Drawing.Point(263, 635);
            this.add_contract_button.Name = "add_contract_button";
            this.add_contract_button.Size = new System.Drawing.Size(221, 66);
            this.add_contract_button.TabIndex = 27;
            this.add_contract_button.Text = "Добавить";
            this.add_contract_button.UseVisualStyleBackColor = true;
            this.add_contract_button.Click += new System.EventHandler(this.add_contract_button_Click);
            // 
            // enter_id_client
            // 
            this.enter_id_client.DataSource = this.clientBindingSource;
            this.enter_id_client.DisplayMember = "id";
            this.enter_id_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_id_client.FormattingEnabled = true;
            this.enter_id_client.Location = new System.Drawing.Point(300, 87);
            this.enter_id_client.Name = "enter_id_client";
            this.enter_id_client.Size = new System.Drawing.Size(414, 28);
            this.enter_id_client.TabIndex = 28;
            this.enter_id_client.SelectedIndexChanged += new System.EventHandler(this.enter_id_client_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.furniture_storeDataSet;
            // 
            // furniture_storeDataSet
            // 
            this.furniture_storeDataSet.DataSetName = "furniture_storeDataSet";
            this.furniture_storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // enter_id_furniture
            // 
            this.enter_id_furniture.DataSource = this.furnturemodelBindingSource;
            this.enter_id_furniture.DisplayMember = "id";
            this.enter_id_furniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_id_furniture.FormattingEnabled = true;
            this.enter_id_furniture.Location = new System.Drawing.Point(300, 132);
            this.enter_id_furniture.Name = "enter_id_furniture";
            this.enter_id_furniture.Size = new System.Drawing.Size(414, 28);
            this.enter_id_furniture.TabIndex = 29;
            this.enter_id_furniture.SelectedIndexChanged += new System.EventHandler(this.enter_id_furniture_SelectedIndexChanged);
            // 
            // furnturemodelBindingSource
            // 
            this.furnturemodelBindingSource.DataMember = "furnture_model";
            this.furnturemodelBindingSource.DataSource = this.furniture_storeDataSet;
            // 
            // furnture_modelTableAdapter
            // 
            this.furnture_modelTableAdapter.ClearBeforeFill = true;
            // 
            // enter_name_furniture
            // 
            this.enter_name_furniture.DataSource = this.furnturemodelBindingSource;
            this.enter_name_furniture.DisplayMember = "name";
            this.enter_name_furniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_name_furniture.FormattingEnabled = true;
            this.enter_name_furniture.Location = new System.Drawing.Point(300, 177);
            this.enter_name_furniture.Name = "enter_name_furniture";
            this.enter_name_furniture.Size = new System.Drawing.Size(414, 28);
            this.enter_name_furniture.TabIndex = 30;
            this.enter_name_furniture.SelectedIndexChanged += new System.EventHandler(this.enter_name_furniture_SelectedIndexChanged);
            // 
            // enter_model_furniture
            // 
            this.enter_model_furniture.DataSource = this.furnturemodelBindingSource;
            this.enter_model_furniture.DisplayMember = "model";
            this.enter_model_furniture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_model_furniture.FormattingEnabled = true;
            this.enter_model_furniture.Location = new System.Drawing.Point(300, 222);
            this.enter_model_furniture.Name = "enter_model_furniture";
            this.enter_model_furniture.Size = new System.Drawing.Size(414, 28);
            this.enter_model_furniture.TabIndex = 31;
            this.enter_model_furniture.SelectedIndexChanged += new System.EventHandler(this.enter_model_furniture_SelectedIndexChanged);
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(300, 267);
            this.count.Multiline = true;
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(414, 28);
            this.count.TabIndex = 32;
            // 
            // registration_date
            // 
            this.registration_date.Location = new System.Drawing.Point(66, 394);
            this.registration_date.Name = "registration_date";
            this.registration_date.TabIndex = 33;
            this.registration_date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.registration_date_DateChanged);
            // 
            // realization_date
            // 
            this.realization_date.Location = new System.Drawing.Point(501, 394);
            this.realization_date.Name = "realization_date";
            this.realization_date.TabIndex = 34;
            this.realization_date.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.realization_date_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(133, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Код клиента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(133, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Код мебели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(71, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Название мебели";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(90, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Модель мебели";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(51, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "Количество мебели";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Сумма договора (руб.)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Дата оформления договора";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(438, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 22);
            this.label9.TabIndex = 43;
            this.label9.Text = "Дата реализации договора";
            // 
            // reg_date
            // 
            this.reg_date.AutoSize = true;
            this.reg_date.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_date.Location = new System.Drawing.Point(13, 580);
            this.reg_date.Name = "reg_date";
            this.reg_date.Size = new System.Drawing.Size(0, 24);
            this.reg_date.TabIndex = 44;
            // 
            // release_date
            // 
            this.release_date.AutoSize = true;
            this.release_date.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.release_date.Location = new System.Drawing.Point(438, 580);
            this.release_date.Name = "release_date";
            this.release_date.Size = new System.Drawing.Size(0, 24);
            this.release_date.TabIndex = 45;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(300, 312);
            this.sum.Multiline = true;
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(414, 28);
            this.sum.TabIndex = 35;
            // 
            // add_contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 713);
            this.Controls.Add(this.release_date);
            this.Controls.Add(this.reg_date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.realization_date);
            this.Controls.Add(this.registration_date);
            this.Controls.Add(this.count);
            this.Controls.Add(this.enter_model_furniture);
            this.Controls.Add(this.enter_name_furniture);
            this.Controls.Add(this.enter_id_furniture);
            this.Controls.Add(this.enter_id_client);
            this.Controls.Add(this.add_contract_button);
            this.Controls.Add(this.label5);
            this.Name = "add_contract";
            this.Text = "Мебельная фабрика \"BTS\"";
            this.Load += new System.EventHandler(this.add_contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furniture_storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnturemodelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_contract_button;
        private System.Windows.Forms.ComboBox enter_id_client;
        private furniture_storeDataSet furniture_storeDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private furniture_storeDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox enter_id_furniture;
        private System.Windows.Forms.BindingSource furnturemodelBindingSource;
        private furniture_storeDataSetTableAdapters.furnture_modelTableAdapter furnture_modelTableAdapter;
        private System.Windows.Forms.ComboBox enter_name_furniture;
        private System.Windows.Forms.ComboBox enter_model_furniture;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.MonthCalendar registration_date;
        private System.Windows.Forms.MonthCalendar realization_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label reg_date;
        private System.Windows.Forms.Label release_date;
        private System.Windows.Forms.TextBox sum;
    }
}