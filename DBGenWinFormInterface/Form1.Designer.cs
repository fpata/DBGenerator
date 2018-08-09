namespace DBGenWinFormInterface
{
    partial class txtConnectStr
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectStr = new System.Windows.Forms.TextBox();
            this.dbType = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTables = new System.Windows.Forms.TabPage();
            this.tabColumns = new System.Windows.Forms.TabPage();
            this.tabCSharp = new System.Windows.Forms.TabPage();
            this.tabTypeScript = new System.Windows.Forms.TabPage();
            this.dvTables = new System.Windows.Forms.DataGridView();
            this.dvColumns = new System.Windows.Forms.DataGridView();
            this.txtCSharp = new System.Windows.Forms.RichTextBox();
            this.txtTypeScript = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTables.SuspendLayout();
            this.tabColumns.SuspendLayout();
            this.tabCSharp.SuspendLayout();
            this.tabTypeScript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.dbType);
            this.panel1.Controls.Add(this.ConnectStr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 80);
            this.panel1.TabIndex = 1;
            // 
            // ConnectStr
            // 
            this.ConnectStr.Location = new System.Drawing.Point(119, 16);
            this.ConnectStr.Name = "ConnectStr";
            this.ConnectStr.Size = new System.Drawing.Size(644, 20);
            this.ConnectStr.TabIndex = 1;
            // 
            // dbType
            // 
            this.dbType.AutoSize = true;
            this.dbType.Location = new System.Drawing.Point(16, 54);
            this.dbType.Name = "dbType";
            this.dbType.Size = new System.Drawing.Size(57, 17);
            this.dbType.TabIndex = 2;
            this.dbType.TabStop = true;
            this.dbType.Text = "SQLite";
            this.dbType.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(119, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Oracle";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(199, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SQLServer";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(302, 54);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "MySQL";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(427, 43);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(132, 28);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(587, 43);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 28);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.cbTables);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 347);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tables";
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(69, 10);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(695, 21);
            this.cbTables.TabIndex = 1;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTables);
            this.tabControl1.Controls.Add(this.tabColumns);
            this.tabControl1.Controls.Add(this.tabCSharp);
            this.tabControl1.Controls.Add(this.tabTypeScript);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(751, 288);
            this.tabControl1.TabIndex = 2;
            // 
            // tabTables
            // 
            this.tabTables.Controls.Add(this.dvTables);
            this.tabTables.Location = new System.Drawing.Point(4, 22);
            this.tabTables.Name = "tabTables";
            this.tabTables.Padding = new System.Windows.Forms.Padding(3);
            this.tabTables.Size = new System.Drawing.Size(743, 262);
            this.tabTables.TabIndex = 0;
            this.tabTables.Text = "Tables";
            this.tabTables.UseVisualStyleBackColor = true;
            // 
            // tabColumns
            // 
            this.tabColumns.Controls.Add(this.dvColumns);
            this.tabColumns.Location = new System.Drawing.Point(4, 22);
            this.tabColumns.Name = "tabColumns";
            this.tabColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tabColumns.Size = new System.Drawing.Size(743, 262);
            this.tabColumns.TabIndex = 1;
            this.tabColumns.Text = "Columns";
            this.tabColumns.UseVisualStyleBackColor = true;
            // 
            // tabCSharp
            // 
            this.tabCSharp.Controls.Add(this.txtCSharp);
            this.tabCSharp.Location = new System.Drawing.Point(4, 22);
            this.tabCSharp.Name = "tabCSharp";
            this.tabCSharp.Size = new System.Drawing.Size(743, 262);
            this.tabCSharp.TabIndex = 2;
            this.tabCSharp.Text = "CSharp Code";
            this.tabCSharp.UseVisualStyleBackColor = true;
            // 
            // tabTypeScript
            // 
            this.tabTypeScript.Controls.Add(this.txtTypeScript);
            this.tabTypeScript.Location = new System.Drawing.Point(4, 22);
            this.tabTypeScript.Name = "tabTypeScript";
            this.tabTypeScript.Size = new System.Drawing.Size(743, 262);
            this.tabTypeScript.TabIndex = 3;
            this.tabTypeScript.Text = "TypeScript Code";
            this.tabTypeScript.UseVisualStyleBackColor = true;
            // 
            // dvTables
            // 
            this.dvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTables.Location = new System.Drawing.Point(7, 13);
            this.dvTables.Name = "dvTables";
            this.dvTables.Size = new System.Drawing.Size(726, 237);
            this.dvTables.TabIndex = 0;
            // 
            // dvColumns
            // 
            this.dvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvColumns.Location = new System.Drawing.Point(8, 13);
            this.dvColumns.Name = "dvColumns";
            this.dvColumns.Size = new System.Drawing.Size(726, 237);
            this.dvColumns.TabIndex = 1;
            // 
            // txtCSharp
            // 
            this.txtCSharp.Location = new System.Drawing.Point(6, 9);
            this.txtCSharp.Name = "txtCSharp";
            this.txtCSharp.Size = new System.Drawing.Size(724, 252);
            this.txtCSharp.TabIndex = 0;
            this.txtCSharp.Text = "";
            // 
            // txtTypeScript
            // 
            this.txtTypeScript.Location = new System.Drawing.Point(9, 5);
            this.txtTypeScript.Name = "txtTypeScript";
            this.txtTypeScript.Size = new System.Drawing.Size(724, 252);
            this.txtTypeScript.TabIndex = 1;
            this.txtTypeScript.Text = "";
            // 
            // txtConnectStr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "txtConnectStr";
            this.Text = "SQLite";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTables.ResumeLayout(false);
            this.tabColumns.ResumeLayout(false);
            this.tabCSharp.ResumeLayout(false);
            this.tabTypeScript.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvColumns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ConnectStr;
        private System.Windows.Forms.RadioButton dbType;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTables;
        private System.Windows.Forms.DataGridView dvTables;
        private System.Windows.Forms.TabPage tabColumns;
        private System.Windows.Forms.DataGridView dvColumns;
        private System.Windows.Forms.TabPage tabCSharp;
        private System.Windows.Forms.RichTextBox txtCSharp;
        private System.Windows.Forms.TabPage tabTypeScript;
        private System.Windows.Forms.RichTextBox txtTypeScript;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Label label2;
    }
}

