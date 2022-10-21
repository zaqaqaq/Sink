
namespace Sink
{
    partial class SinkForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BuildingButton = new System.Windows.Forms.Button();
            this.RadTapSink = new System.Windows.Forms.TextBox();
            this.RadSink = new System.Windows.Forms.TextBox();
            this.HeightSink = new System.Windows.Forms.TextBox();
            this.LengthSink = new System.Windows.Forms.TextBox();
            this.WidthSink = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.BuildingButton);
            this.splitContainer1.Panel1.Controls.Add(this.RadTapSink);
            this.splitContainer1.Panel1.Controls.Add(this.RadSink);
            this.splitContainer1.Panel1.Controls.Add(this.HeightSink);
            this.splitContainer1.Panel1.Controls.Add(this.LengthSink);
            this.splitContainer1.Panel1.Controls.Add(this.WidthSink);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::Sink.Properties.Resources._2;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Size = new System.Drawing.Size(1067, 554);
            this.splitContainer1.SplitterDistance = 526;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // BuildingButton
            // 
            this.BuildingButton.Location = new System.Drawing.Point(189, 422);
            this.BuildingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuildingButton.Name = "BuildingButton";
            this.BuildingButton.Size = new System.Drawing.Size(152, 64);
            this.BuildingButton.TabIndex = 12;
            this.BuildingButton.Text = "Построить";
            this.BuildingButton.UseVisualStyleBackColor = true;
            this.BuildingButton.Click += new System.EventHandler(this.BuildingButton_Click);
            // 
            // RadTapSink
            // 
            this.RadTapSink.Location = new System.Drawing.Point(31, 313);
            this.RadTapSink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadTapSink.Name = "RadTapSink";
            this.RadTapSink.Size = new System.Drawing.Size(132, 22);
            this.RadTapSink.TabIndex = 11;
            // 
            // RadSink
            // 
            this.RadSink.Location = new System.Drawing.Point(31, 242);
            this.RadSink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RadSink.Name = "RadSink";
            this.RadSink.Size = new System.Drawing.Size(132, 22);
            this.RadSink.TabIndex = 10;
            // 
            // HeightSink
            // 
            this.HeightSink.Location = new System.Drawing.Point(32, 184);
            this.HeightSink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeightSink.Name = "HeightSink";
            this.HeightSink.Size = new System.Drawing.Size(132, 22);
            this.HeightSink.TabIndex = 9;
            // 
            // LengthSink
            // 
            this.LengthSink.Location = new System.Drawing.Point(31, 118);
            this.LengthSink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LengthSink.Name = "LengthSink";
            this.LengthSink.Size = new System.Drawing.Size(132, 22);
            this.LengthSink.TabIndex = 8;
            // 
            // WidthSink
            // 
            this.WidthSink.Location = new System.Drawing.Point(31, 49);
            this.WidthSink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WidthSink.Name = "WidthSink";
            this.WidthSink.Size = new System.Drawing.Size(132, 22);
            this.WidthSink.TabIndex = 7;
            this.WidthSink.TextChanged += new System.EventHandler(this.WidthSink_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Примечание: все значения вводятся в мм!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ширина раковины W:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина раковины D:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Глубина раковины H:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Диаметр сливного отверстия R:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Диаметр отверстия под кран R1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "мин - 450 мм, макс - 630";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "мин - 450 мм, макс - 630";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "мин - 150 мм, макс - 210";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "мин - 50 мм, макс - 70";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "мин - 20 мм, макс - 30";
            // 
            // SinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SinkForm";
            this.Text = "SinkForm";
            this.Load += new System.EventHandler(this.SinkForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BuildingButton;
        private System.Windows.Forms.TextBox RadTapSink;
        private System.Windows.Forms.TextBox RadSink;
        private System.Windows.Forms.TextBox HeightSink;
        private System.Windows.Forms.TextBox LengthSink;
        private System.Windows.Forms.TextBox WidthSink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
    }
}

