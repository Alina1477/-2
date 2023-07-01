namespace Калькулятор2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.vyvod = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.square = new System.Windows.Forms.Button();
            this.cleanEn = new System.Windows.Forms.Button();
            this.cleanAll = new System.Windows.Forms.Button();
            this.plMin = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.perc = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.partOf = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vyvod
            // 
            this.vyvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vyvod.Location = new System.Drawing.Point(12, 12);
            this.vyvod.Multiline = true;
            this.vyvod.Name = "vyvod";
            this.vyvod.Size = new System.Drawing.Size(274, 56);
            this.vyvod.TabIndex = 0;
            this.vyvod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.square.Location = new System.Drawing.Point(180, 74);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(50, 50);
            this.square.TabIndex = 2;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = false;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // cleanEn
            // 
            this.cleanEn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cleanEn.Location = new System.Drawing.Point(12, 74);
            this.cleanEn.Name = "cleanEn";
            this.cleanEn.Size = new System.Drawing.Size(50, 50);
            this.cleanEn.TabIndex = 3;
            this.cleanEn.Text = "CE";
            this.cleanEn.UseVisualStyleBackColor = false;
            this.cleanEn.Click += new System.EventHandler(this.cleanAll_Click);
            // 
            // cleanAll
            // 
            this.cleanAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cleanAll.Location = new System.Drawing.Point(68, 74);
            this.cleanAll.Name = "cleanAll";
            this.cleanAll.Size = new System.Drawing.Size(50, 50);
            this.cleanAll.TabIndex = 4;
            this.cleanAll.Text = "C";
            this.cleanAll.UseVisualStyleBackColor = false;
            this.cleanAll.Click += new System.EventHandler(this.cleanAll_Click);
            // 
            // plMin
            // 
            this.plMin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plMin.Location = new System.Drawing.Point(124, 74);
            this.plMin.Name = "plMin";
            this.plMin.Size = new System.Drawing.Size(50, 50);
            this.plMin.TabIndex = 5;
            this.plMin.Text = "+/-";
            this.plMin.UseVisualStyleBackColor = false;
            this.plMin.Click += new System.EventHandler(this.plMin_Click);
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.root.Location = new System.Drawing.Point(236, 74);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(50, 50);
            this.root.TabIndex = 6;
            this.root.Text = "V";
            this.root.UseVisualStyleBackColor = false;
            this.root.Click += new System.EventHandler(this.root_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.n7.Location = new System.Drawing.Point(12, 130);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(50, 50);
            this.n7.TabIndex = 7;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n0_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.n8.Location = new System.Drawing.Point(68, 130);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(50, 50);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n0_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.n9.Location = new System.Drawing.Point(124, 130);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(50, 50);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n0_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.div.Location = new System.Drawing.Point(180, 130);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(50, 50);
            this.div.TabIndex = 10;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.sum_Click);
            // 
            // perc
            // 
            this.perc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.perc.Location = new System.Drawing.Point(236, 130);
            this.perc.Name = "perc";
            this.perc.Size = new System.Drawing.Size(50, 50);
            this.perc.TabIndex = 11;
            this.perc.Text = "%";
            this.perc.UseVisualStyleBackColor = false;
            this.perc.Click += new System.EventHandler(this.sum_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.n4.Location = new System.Drawing.Point(12, 186);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(50, 50);
            this.n4.TabIndex = 12;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n0_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.n5.Location = new System.Drawing.Point(68, 186);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(50, 50);
            this.n5.TabIndex = 13;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n0_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.n6.Location = new System.Drawing.Point(124, 186);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(50, 50);
            this.n6.TabIndex = 14;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n0_Click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.n1.Location = new System.Drawing.Point(12, 242);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(50, 50);
            this.n1.TabIndex = 15;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n0_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.n2.Location = new System.Drawing.Point(68, 242);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(50, 50);
            this.n2.TabIndex = 16;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n0_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.n3.Location = new System.Drawing.Point(124, 242);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(50, 50);
            this.n3.TabIndex = 17;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n0_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mult.Location = new System.Drawing.Point(180, 186);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(50, 50);
            this.mult.TabIndex = 18;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.sum_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sub.Location = new System.Drawing.Point(180, 242);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(50, 50);
            this.sub.TabIndex = 19;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sum_Click);
            // 
            // partOf
            // 
            this.partOf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.partOf.Location = new System.Drawing.Point(236, 186);
            this.partOf.Name = "partOf";
            this.partOf.Size = new System.Drawing.Size(50, 50);
            this.partOf.TabIndex = 20;
            this.partOf.Text = "1/x";
            this.partOf.UseVisualStyleBackColor = false;
            this.partOf.Click += new System.EventHandler(this.partOf_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.n0.Location = new System.Drawing.Point(12, 298);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(106, 50);
            this.n0.TabIndex = 21;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comma.Location = new System.Drawing.Point(124, 298);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(50, 50);
            this.comma.TabIndex = 22;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = false;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sum.Location = new System.Drawing.Point(180, 298);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(50, 50);
            this.sum.TabIndex = 23;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equal.Location = new System.Drawing.Point(236, 242);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(50, 106);
            this.equal.TabIndex = 24;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 359);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.partOf);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.perc);
            this.Controls.Add(this.div);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.root);
            this.Controls.Add(this.plMin);
            this.Controls.Add(this.cleanAll);
            this.Controls.Add(this.cleanEn);
            this.Controls.Add(this.square);
            this.Controls.Add(this.vyvod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vyvod;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button cleanEn;
        private System.Windows.Forms.Button cleanAll;
        private System.Windows.Forms.Button plMin;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button perc;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button partOf;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button equal;
    }
}

