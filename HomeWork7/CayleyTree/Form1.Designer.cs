
namespace CayleyTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ThRight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ThLeft = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.perRight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.perLeft = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.Color);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.ThRight);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.ThLeft);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.perRight);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.perLeft);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.Length);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.depth);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Size = new System.Drawing.Size(1105, 696);
            this.splitContainer1.SplitterDistance = 334;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(251, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Color
            // 
            this.Color.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Color.BackColor = System.Drawing.Color.Aqua;
            this.Color.Location = new System.Drawing.Point(117, 441);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(128, 32);
            this.Color.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.Location = new System.Drawing.Point(44, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "画笔颜色";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(225, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "绘制";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThRight
            // 
            this.ThRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ThRight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ThRight.Location = new System.Drawing.Point(120, 340);
            this.ThRight.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.ThRight.Name = "ThRight";
            this.ThRight.Size = new System.Drawing.Size(180, 25);
            this.ThRight.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.Location = new System.Drawing.Point(12, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "右角度";
            // 
            // ThLeft
            // 
            this.ThLeft.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ThLeft.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ThLeft.Location = new System.Drawing.Point(120, 290);
            this.ThLeft.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.ThLeft.Name = "ThLeft";
            this.ThLeft.Size = new System.Drawing.Size(180, 25);
            this.ThLeft.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Location = new System.Drawing.Point(12, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "左角度";
            // 
            // perRight
            // 
            this.perRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.perRight.DecimalPlaces = 2;
            this.perRight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.perRight.Location = new System.Drawing.Point(120, 240);
            this.perRight.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.perRight.Name = "perRight";
            this.perRight.Size = new System.Drawing.Size(180, 25);
            this.perRight.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "右长度比";
            // 
            // perLeft
            // 
            this.perLeft.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.perLeft.DecimalPlaces = 2;
            this.perLeft.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.perLeft.Location = new System.Drawing.Point(120, 190);
            this.perLeft.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.perLeft.Name = "perLeft";
            this.perLeft.Size = new System.Drawing.Size(180, 25);
            this.perLeft.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "左长度比";
            // 
            // Length
            // 
            this.Length.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Length.Location = new System.Drawing.Point(120, 140);
            this.Length.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(180, 25);
            this.Length.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "主干长度";
            // 
            // depth
            // 
            this.depth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.depth.Location = new System.Drawing.Point(120, 85);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(180, 25);
            this.depth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "递归深度";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Aqua;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1105, 696);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown ThRight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ThLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown perRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown perLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label label7;
    }
}

