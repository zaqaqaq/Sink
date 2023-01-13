
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
            this.FilterSinkYLabel = new System.Windows.Forms.Label();
            this.FilterSinkXLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.filterSinkY = new System.Windows.Forms.TextBox();
            this.filterSinkX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RadTapLabel = new System.Windows.Forms.Label();
            this.RadLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.BuildingButton = new System.Windows.Forms.Button();
            this.radTapSink = new System.Windows.Forms.TextBox();
            this.radSink = new System.Windows.Forms.TextBox();
            this.heightSink = new System.Windows.Forms.TextBox();
            this.lengthSink = new System.Windows.Forms.TextBox();
            this.widthSink = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FilterSinkYLabel);
            this.splitContainer1.Panel1.Controls.Add(this.FilterSinkXLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.filterSinkY);
            this.splitContainer1.Panel1.Controls.Add(this.filterSinkX);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.RadTapLabel);
            this.splitContainer1.Panel1.Controls.Add(this.RadLabel);
            this.splitContainer1.Panel1.Controls.Add(this.HeightLabel);
            this.splitContainer1.Panel1.Controls.Add(this.LengthLabel);
            this.splitContainer1.Panel1.Controls.Add(this.WidthLabel);
            this.splitContainer1.Panel1.Controls.Add(this.BuildingButton);
            this.splitContainer1.Panel1.Controls.Add(this.radTapSink);
            this.splitContainer1.Panel1.Controls.Add(this.radSink);
            this.splitContainer1.Panel1.Controls.Add(this.heightSink);
            this.splitContainer1.Panel1.Controls.Add(this.lengthSink);
            this.splitContainer1.Panel1.Controls.Add(this.widthSink);
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 407;
            this.splitContainer1.TabIndex = 0;
            // 
            // FilterSinkYLabel
            // 
            this.FilterSinkYLabel.AutoSize = true;
            this.FilterSinkYLabel.Location = new System.Drawing.Point(188, 274);
            this.FilterSinkYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilterSinkYLabel.Name = "FilterSinkYLabel";
            this.FilterSinkYLabel.Size = new System.Drawing.Size(209, 13);
            this.FilterSinkYLabel.TabIndex = 29;
            this.FilterSinkYLabel.Text = "мин - | D/2-105 | мм, макс - | D/2-25 | мм";
            // 
            // FilterSinkXLabel
            // 
            this.FilterSinkXLabel.AutoSize = true;
            this.FilterSinkXLabel.Location = new System.Drawing.Point(188, 235);
            this.FilterSinkXLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FilterSinkXLabel.Name = "FilterSinkXLabel";
            this.FilterSinkXLabel.Size = new System.Drawing.Size(215, 13);
            this.FilterSinkXLabel.TabIndex = 28;
            this.FilterSinkXLabel.Text = "мин - | R1/2+15 | мм, макс - | W/2-25 | мм";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Координата Y отверстия под фильтр C2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Координата X отверстия под фильтр C1:";
            // 
            // filterSinkY
            // 
            this.filterSinkY.Location = new System.Drawing.Point(23, 271);
            this.filterSinkY.Name = "filterSinkY";
            this.filterSinkY.Size = new System.Drawing.Size(100, 20);
            this.filterSinkY.TabIndex = 25;
            this.filterSinkY.TextChanged += new System.EventHandler(this.TextBoxValidator_TextChanged);
            this.filterSinkY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckForCommasAndNumbers_KeyPress);
            // 
            // filterSinkX
            // 
            this.filterSinkX.Location = new System.Drawing.Point(23, 232);
            this.filterSinkX.Name = "filterSinkX";
            this.filterSinkX.Size = new System.Drawing.Size(100, 20);
            this.filterSinkX.TabIndex = 24;
            this.filterSinkX.TextChanged += new System.EventHandler(this.TextBoxValidator_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ширина зависит от глубины как 1:3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ширина зависит от длины раковины 1:1";
            // 
            // RadTapLabel
            // 
            this.RadTapLabel.AutoSize = true;
            this.RadTapLabel.Location = new System.Drawing.Point(188, 197);
            this.RadTapLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RadTapLabel.Name = "RadTapLabel";
            this.RadTapLabel.Size = new System.Drawing.Size(139, 13);
            this.RadTapLabel.TabIndex = 21;
            this.RadTapLabel.Text = "мин - 20 мм, макс - 30 мм";
            // 
            // RadLabel
            // 
            this.RadLabel.AutoSize = true;
            this.RadLabel.Location = new System.Drawing.Point(188, 159);
            this.RadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RadLabel.Name = "RadLabel";
            this.RadLabel.Size = new System.Drawing.Size(139, 13);
            this.RadLabel.TabIndex = 20;
            this.RadLabel.Text = "мин - 50 мм, макс - 70 мм";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(188, 120);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(151, 13);
            this.HeightLabel.TabIndex = 19;
            this.HeightLabel.Text = "мин - 150 мм, макс - 210 мм";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(188, 81);
            this.LengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(151, 13);
            this.LengthLabel.TabIndex = 18;
            this.LengthLabel.Text = "мин - 450 мм, макс - 630 мм";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(188, 42);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(151, 13);
            this.WidthLabel.TabIndex = 13;
            this.WidthLabel.Text = "мин - 450 мм, макс - 630 мм";
            // 
            // BuildingButton
            // 
            this.BuildingButton.Location = new System.Drawing.Point(134, 370);
            this.BuildingButton.Name = "BuildingButton";
            this.BuildingButton.Size = new System.Drawing.Size(114, 52);
            this.BuildingButton.TabIndex = 12;
            this.BuildingButton.Text = "Построить";
            this.BuildingButton.UseVisualStyleBackColor = true;
            this.BuildingButton.Click += new System.EventHandler(this.BuildingButton_Click);
            // 
            // radTapSink
            // 
            this.radTapSink.Location = new System.Drawing.Point(23, 194);
            this.radTapSink.Name = "radTapSink";
            this.radTapSink.Size = new System.Drawing.Size(100, 20);
            this.radTapSink.TabIndex = 11;
            this.radTapSink.TextChanged += new System.EventHandler(this.TextBoxValidator_TextChanged);
            this.radTapSink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckForCommasAndNumbers_KeyPress);
            // 
            // radSink
            // 
            this.radSink.Location = new System.Drawing.Point(23, 156);
            this.radSink.Name = "radSink";
            this.radSink.Size = new System.Drawing.Size(100, 20);
            this.radSink.TabIndex = 10;
            this.radSink.TextChanged += new System.EventHandler(this.TextBoxValidator_TextChanged);
            this.radSink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckForCommasAndNumbers_KeyPress);
            // 
            // heightSink
            // 
            this.heightSink.Location = new System.Drawing.Point(23, 117);
            this.heightSink.Name = "heightSink";
            this.heightSink.Size = new System.Drawing.Size(100, 20);
            this.heightSink.TabIndex = 9;
            this.heightSink.TextChanged += new System.EventHandler(this.TextBoxValidator_TextChanged);
            this.heightSink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckForCommasAndNumbers_KeyPress);
            // 
            // lengthSink
            // 
            this.lengthSink.Location = new System.Drawing.Point(23, 39);
            this.lengthSink.Name = "lengthSink";
            this.lengthSink.Size = new System.Drawing.Size(100, 20);
            this.lengthSink.TabIndex = 8;
            this.lengthSink.TextChanged += new System.EventHandler(this.TextBoxValidator_TextChanged);
            this.lengthSink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckForCommasAndNumbers_KeyPress);
            // 
            // widthSink
            // 
            this.widthSink.Location = new System.Drawing.Point(23, 78);
            this.widthSink.Name = "widthSink";
            this.widthSink.Size = new System.Drawing.Size(100, 20);
            this.widthSink.TabIndex = 7;
            this.widthSink.TextChanged += new System.EventHandler(this.TextBoxValidator_TextChanged);
            this.widthSink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckForCommasAndNumbers_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Примечание: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ширина раковины W:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Длина раковины D:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Глубина раковины H:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Диаметр сливного отверстия R:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Диаметр отверстия под кран R1:";
            // 
            // SinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SinkForm";
            this.Text = "SinkForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BuildingButton;
        private System.Windows.Forms.TextBox radTapSink;
        private System.Windows.Forms.TextBox radSink;
        private System.Windows.Forms.TextBox heightSink;
        private System.Windows.Forms.TextBox lengthSink;
        private System.Windows.Forms.TextBox widthSink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label RadTapLabel;
        private System.Windows.Forms.Label RadLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label FilterSinkYLabel;
        private System.Windows.Forms.Label FilterSinkXLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox filterSinkY;
        private System.Windows.Forms.TextBox filterSinkX;
    }
}

