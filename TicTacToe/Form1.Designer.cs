
namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCell11 = new System.Windows.Forms.Button();
            this.btnCell12 = new System.Windows.Forms.Button();
            this.btnCell13 = new System.Windows.Forms.Button();
            this.btnCell21 = new System.Windows.Forms.Button();
            this.btnCell22 = new System.Windows.Forms.Button();
            this.btnCell23 = new System.Windows.Forms.Button();
            this.btnCell31 = new System.Windows.Forms.Button();
            this.btnCell32 = new System.Windows.Forms.Button();
            this.btnCell33 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = global::TicTacToe.Properties.Resources.асфальт;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1626, 1161);
            this.splitContainer1.SplitterDistance = 542;
            this.splitContainer1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 803);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(262, 120);
            this.button4.TabIndex = 4;
            this.button4.Text = "Статистика";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 581);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 120);
            this.button3.TabIndex = 3;
            this.button3.Text = "Игра со студентом";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 120);
            this.button2.TabIndex = 2;
            this.button2.Text = "Игра со стражем";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 120);
            this.button1.TabIndex = 1;
            this.button1.Text = "Одиночная игра";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.51794F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.48206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel1.Controls.Add(this.btnCell11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCell12, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCell13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCell21, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCell22, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCell23, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCell31, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCell32, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCell33, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(73, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 313F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 950);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            // 
            // btnCell11
            // 
            this.btnCell11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCell11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCell11.Enabled = false;
            this.btnCell11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell11.ForeColor = System.Drawing.Color.Red;
            this.btnCell11.Location = new System.Drawing.Point(3, 3);
            this.btnCell11.Name = "btnCell11";
            this.btnCell11.Size = new System.Drawing.Size(305, 306);
            this.btnCell11.TabIndex = 0;
            this.btnCell11.UseVisualStyleBackColor = false;
            this.btnCell11.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell12
            // 
            this.btnCell12.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCell12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCell12.Enabled = false;
            this.btnCell12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell12.Location = new System.Drawing.Point(314, 3);
            this.btnCell12.Name = "btnCell12";
            this.btnCell12.Size = new System.Drawing.Size(324, 306);
            this.btnCell12.TabIndex = 1;
            this.btnCell12.UseVisualStyleBackColor = false;
            this.btnCell12.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell13
            // 
            this.btnCell13.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCell13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCell13.Enabled = false;
            this.btnCell13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell13.Location = new System.Drawing.Point(644, 3);
            this.btnCell13.Name = "btnCell13";
            this.btnCell13.Size = new System.Drawing.Size(303, 306);
            this.btnCell13.TabIndex = 2;
            this.btnCell13.UseVisualStyleBackColor = false;
            this.btnCell13.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell21
            // 
            this.btnCell21.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCell21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCell21.Enabled = false;
            this.btnCell21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell21.Location = new System.Drawing.Point(3, 315);
            this.btnCell21.Name = "btnCell21";
            this.btnCell21.Size = new System.Drawing.Size(305, 318);
            this.btnCell21.TabIndex = 3;
            this.btnCell21.UseVisualStyleBackColor = false;
            this.btnCell21.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell22
            // 
            this.btnCell22.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCell22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCell22.Enabled = false;
            this.btnCell22.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell22.Location = new System.Drawing.Point(314, 315);
            this.btnCell22.Name = "btnCell22";
            this.btnCell22.Size = new System.Drawing.Size(324, 318);
            this.btnCell22.TabIndex = 4;
            this.btnCell22.UseVisualStyleBackColor = false;
            this.btnCell22.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell23
            // 
            this.btnCell23.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCell23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCell23.Enabled = false;
            this.btnCell23.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell23.Location = new System.Drawing.Point(644, 315);
            this.btnCell23.Name = "btnCell23";
            this.btnCell23.Size = new System.Drawing.Size(303, 318);
            this.btnCell23.TabIndex = 5;
            this.btnCell23.UseVisualStyleBackColor = false;
            this.btnCell23.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell31
            // 
            this.btnCell31.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCell31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCell31.Enabled = false;
            this.btnCell31.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell31.Location = new System.Drawing.Point(3, 639);
            this.btnCell31.Name = "btnCell31";
            this.btnCell31.Size = new System.Drawing.Size(305, 308);
            this.btnCell31.TabIndex = 6;
            this.btnCell31.UseVisualStyleBackColor = false;
            this.btnCell31.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell32
            // 
            this.btnCell32.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCell32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCell32.Enabled = false;
            this.btnCell32.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell32.Location = new System.Drawing.Point(314, 639);
            this.btnCell32.Name = "btnCell32";
            this.btnCell32.Size = new System.Drawing.Size(324, 308);
            this.btnCell32.TabIndex = 7;
            this.btnCell32.UseVisualStyleBackColor = false;
            this.btnCell32.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell33
            // 
            this.btnCell33.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCell33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCell33.Enabled = false;
            this.btnCell33.Font = new System.Drawing.Font("Arial Rounded MT Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCell33.Location = new System.Drawing.Point(644, 639);
            this.btnCell33.Name = "btnCell33";
            this.btnCell33.Size = new System.Drawing.Size(303, 308);
            this.btnCell33.TabIndex = 8;
            this.btnCell33.UseVisualStyleBackColor = false;
            this.btnCell33.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.асфальт;
            this.ClientSize = new System.Drawing.Size(1626, 1161);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCell11;
        private System.Windows.Forms.Button btnCell12;
        private System.Windows.Forms.Button btnCell13;
        private System.Windows.Forms.Button btnCell21;
        private System.Windows.Forms.Button btnCell22;
        private System.Windows.Forms.Button btnCell23;
        private System.Windows.Forms.Button btnCell31;
        private System.Windows.Forms.Button btnCell32;
        private System.Windows.Forms.Button btnCell33;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

