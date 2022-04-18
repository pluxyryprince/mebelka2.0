
namespace mebelka2._0
{
    partial class add_furniture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_furniture));
            this.item = new System.Windows.Forms.TextBox();
            this.model_furniture = new System.Windows.Forms.TextBox();
            this.name_furniture = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.add_furniture_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // item
            // 
            this.item.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item.Location = new System.Drawing.Point(190, 216);
            this.item.Multiline = true;
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(407, 33);
            this.item.TabIndex = 11;
            // 
            // model_furniture
            // 
            this.model_furniture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.model_furniture.Location = new System.Drawing.Point(190, 148);
            this.model_furniture.Multiline = true;
            this.model_furniture.Name = "model_furniture";
            this.model_furniture.Size = new System.Drawing.Size(407, 33);
            this.model_furniture.TabIndex = 10;
            // 
            // name_furniture
            // 
            this.name_furniture.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_furniture.Location = new System.Drawing.Point(190, 80);
            this.name_furniture.Multiline = true;
            this.name_furniture.Name = "name_furniture";
            this.name_furniture.Size = new System.Drawing.Size(407, 33);
            this.name_furniture.TabIndex = 9;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(190, 284);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(407, 33);
            this.price.TabIndex = 12;
            // 
            // add_furniture_button
            // 
            this.add_furniture_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_furniture_button.Location = new System.Drawing.Point(190, 434);
            this.add_furniture_button.Name = "add_furniture_button";
            this.add_furniture_button.Size = new System.Drawing.Size(221, 66);
            this.add_furniture_button.TabIndex = 15;
            this.add_furniture_button.Text = "Добавить";
            this.add_furniture_button.UseVisualStyleBackColor = true;
            this.add_furniture_button.Click += new System.EventHandler(this.add_furniture_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Предмет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(90, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(90, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(470, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Добавить информацию о модели мебели";
            // 
            // add_furniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(609, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_furniture_button);
            this.Controls.Add(this.price);
            this.Controls.Add(this.item);
            this.Controls.Add(this.model_furniture);
            this.Controls.Add(this.name_furniture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_furniture";
            this.Text = "Мебельная фабрика \"BTS\"";
            this.Load += new System.EventHandler(this.add_furniture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.TextBox model_furniture;
        private System.Windows.Forms.TextBox name_furniture;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button add_furniture_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}