namespace WinFormsContainersApp
{
    partial class FormMain
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
            grpControls = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button5 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            table = new TableLayoutPanel();
            grpControls.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // grpControls
            // 
            grpControls.Controls.Add(textBox1);
            grpControls.Controls.Add(label1);
            grpControls.Controls.Add(button1);
            grpControls.Font = new Font("Segoe UI", 16F);
            grpControls.Location = new Point(12, 12);
            grpControls.Name = "grpControls";
            grpControls.Size = new Size(358, 367);
            grpControls.TabIndex = 0;
            grpControls.TabStop = false;
            grpControls.Text = "Controls for WinForms";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 36);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 53);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(119, 248);
            button1.Name = "button1";
            button1.Size = new Size(127, 84);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Location = new Point(391, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 172);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(4, 3);
            button4.Name = "button4";
            button4.Size = new Size(195, 66);
            button4.TabIndex = 0;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(205, 3);
            button5.Name = "button5";
            button5.Size = new Size(101, 58);
            button5.TabIndex = 1;
            button5.Text = "button3";
            button5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Location = new Point(391, 212);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(655, 167);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(195, 58);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(204, 3);
            button3.Name = "button3";
            button3.Size = new Size(101, 58);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            table.ColumnCount = 3;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            table.Location = new Point(12, 403);
            table.Name = "table";
            table.RowCount = 3;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            table.Size = new Size(394, 263);
            table.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 691);
            Controls.Add(table);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(grpControls);
            Name = "FormMain";
            Text = "Containers";
            grpControls.ResumeLayout(false);
            grpControls.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpControls;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button4;
        private Button button5;
        private Button button2;
        private Button button3;
        private TableLayoutPanel table;
    }
}
