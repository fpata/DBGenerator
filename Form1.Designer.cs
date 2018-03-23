namespace DBGen
{
    partial class frmMain
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
            this.pnlDBConfig = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtConnectString = new System.Windows.Forms.TextBox();
            this.grbDBSelect = new System.Windows.Forms.GroupBox();
            this.rbMySQL = new System.Windows.Forms.RadioButton();
            this.rbSQLServer = new System.Windows.Forms.RadioButton();
            this.rbOracle = new System.Windows.Forms.RadioButton();
            this.rbSqlite = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSchema = new System.Windows.Forms.TabControl();
            this.tbtables = new System.Windows.Forms.TabPage();
            this.grdTables = new System.Windows.Forms.DataGridView();
            this.tbColumns = new System.Windows.Forms.TabPage();
            this.grdColumns = new System.Windows.Forms.DataGridView();
            this.tbData = new System.Windows.Forms.TabPage();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.tbCSharp = new System.Windows.Forms.TabPage();
            this.txtCSharpCode = new System.Windows.Forms.RichTextBox();
            this.tbTypeScript = new System.Windows.Forms.TabPage();
            this.txtTypeScript = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.chkEFMapping = new System.Windows.Forms.CheckBox();
            this.pnlDBConfig.SuspendLayout();
            this.grbDBSelect.SuspendLayout();
            this.tbSchema.SuspendLayout();
            this.tbtables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTables)).BeginInit();
            this.tbColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdColumns)).BeginInit();
            this.tbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.tbCSharp.SuspendLayout();
            this.tbTypeScript.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDBConfig
            // 
            this.pnlDBConfig.AutoSize = true;
            this.pnlDBConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDBConfig.Controls.Add(this.btnClear);
            this.pnlDBConfig.Controls.Add(this.btnConnect);
            this.pnlDBConfig.Controls.Add(this.txtConnectString);
            this.pnlDBConfig.Controls.Add(this.grbDBSelect);
            this.pnlDBConfig.Controls.Add(this.label2);
            this.pnlDBConfig.Controls.Add(this.label1);
            this.pnlDBConfig.Location = new System.Drawing.Point(10, 16);
            this.pnlDBConfig.Name = "pnlDBConfig";
            this.pnlDBConfig.Size = new System.Drawing.Size(805, 96);
            this.pnlDBConfig.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(682, 70);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 21);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(610, 70);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(66, 21);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtConnectString
            // 
            this.txtConnectString.Location = new System.Drawing.Point(118, 45);
            this.txtConnectString.Name = "txtConnectString";
            this.txtConnectString.Size = new System.Drawing.Size(652, 20);
            this.txtConnectString.TabIndex = 7;
            // 
            // grbDBSelect
            // 
            this.grbDBSelect.Controls.Add(this.rbMySQL);
            this.grbDBSelect.Controls.Add(this.rbSQLServer);
            this.grbDBSelect.Controls.Add(this.rbOracle);
            this.grbDBSelect.Controls.Add(this.rbSqlite);
            this.grbDBSelect.Location = new System.Drawing.Point(116, -1);
            this.grbDBSelect.Name = "grbDBSelect";
            this.grbDBSelect.Size = new System.Drawing.Size(684, 36);
            this.grbDBSelect.TabIndex = 6;
            this.grbDBSelect.TabStop = false;
            // 
            // rbMySQL
            // 
            this.rbMySQL.AutoSize = true;
            this.rbMySQL.Location = new System.Drawing.Point(427, 13);
            this.rbMySQL.Name = "rbMySQL";
            this.rbMySQL.Size = new System.Drawing.Size(63, 17);
            this.rbMySQL.TabIndex = 4;
            this.rbMySQL.Text = "My SQL";
            this.rbMySQL.UseVisualStyleBackColor = true;
            // 
            // rbSQLServer
            // 
            this.rbSQLServer.AutoSize = true;
            this.rbSQLServer.Location = new System.Drawing.Point(275, 13);
            this.rbSQLServer.Name = "rbSQLServer";
            this.rbSQLServer.Size = new System.Drawing.Size(80, 17);
            this.rbSQLServer.TabIndex = 3;
            this.rbSQLServer.Text = "SQL Server";
            this.rbSQLServer.UseVisualStyleBackColor = true;
            // 
            // rbOracle
            // 
            this.rbOracle.AutoSize = true;
            this.rbOracle.Location = new System.Drawing.Point(145, 13);
            this.rbOracle.Name = "rbOracle";
            this.rbOracle.Size = new System.Drawing.Size(56, 17);
            this.rbOracle.TabIndex = 2;
            this.rbOracle.Text = "Oracle";
            this.rbOracle.UseVisualStyleBackColor = true;
            // 
            // rbSqlite
            // 
            this.rbSqlite.AutoSize = true;
            this.rbSqlite.Checked = true;
            this.rbSqlite.Location = new System.Drawing.Point(19, 13);
            this.rbSqlite.Name = "rbSqlite";
            this.rbSqlite.Size = new System.Drawing.Size(51, 17);
            this.rbSqlite.TabIndex = 1;
            this.rbSqlite.TabStop = true;
            this.rbSqlite.Text = "Sqlite";
            this.rbSqlite.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Connection String";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DB Type";
            // 
            // tbSchema
            // 
            this.tbSchema.CausesValidation = false;
            this.tbSchema.Controls.Add(this.tbtables);
            this.tbSchema.Controls.Add(this.tbColumns);
            this.tbSchema.Controls.Add(this.tbData);
            this.tbSchema.Controls.Add(this.tbCSharp);
            this.tbSchema.Controls.Add(this.tbTypeScript);
            this.tbSchema.Location = new System.Drawing.Point(14, 147);
            this.tbSchema.Name = "tbSchema";
            this.tbSchema.SelectedIndex = 0;
            this.tbSchema.Size = new System.Drawing.Size(801, 338);
            this.tbSchema.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbSchema.TabIndex = 1;
            this.tbSchema.SelectedIndexChanged += new System.EventHandler(this.tbSchema_SelectedIndexChanged);
            // 
            // tbtables
            // 
            this.tbtables.Controls.Add(this.grdTables);
            this.tbtables.Location = new System.Drawing.Point(4, 22);
            this.tbtables.Name = "tbtables";
            this.tbtables.Padding = new System.Windows.Forms.Padding(3);
            this.tbtables.Size = new System.Drawing.Size(793, 312);
            this.tbtables.TabIndex = 0;
            this.tbtables.Text = "Tables";
            this.tbtables.UseVisualStyleBackColor = true;
            // 
            // grdTables
            // 
            this.grdTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTables.Location = new System.Drawing.Point(7, 4);
            this.grdTables.Name = "grdTables";
            this.grdTables.Size = new System.Drawing.Size(780, 305);
            this.grdTables.TabIndex = 0;
            // 
            // tbColumns
            // 
            this.tbColumns.Controls.Add(this.grdColumns);
            this.tbColumns.Location = new System.Drawing.Point(4, 22);
            this.tbColumns.Name = "tbColumns";
            this.tbColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tbColumns.Size = new System.Drawing.Size(793, 312);
            this.tbColumns.TabIndex = 1;
            this.tbColumns.Text = "Columns";
            this.tbColumns.UseVisualStyleBackColor = true;
            // 
            // grdColumns
            // 
            this.grdColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdColumns.Location = new System.Drawing.Point(16, 6);
            this.grdColumns.Name = "grdColumns";
            this.grdColumns.Size = new System.Drawing.Size(758, 300);
            this.grdColumns.TabIndex = 2;
            // 
            // tbData
            // 
            this.tbData.Controls.Add(this.grdData);
            this.tbData.Location = new System.Drawing.Point(4, 22);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(793, 312);
            this.tbData.TabIndex = 2;
            this.tbData.Text = "Data";
            this.tbData.UseVisualStyleBackColor = true;
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(4, 14);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(770, 295);
            this.grdData.TabIndex = 3;
            // 
            // tbCSharp
            // 
            this.tbCSharp.Controls.Add(this.txtCSharpCode);
            this.tbCSharp.Location = new System.Drawing.Point(4, 22);
            this.tbCSharp.Name = "tbCSharp";
            this.tbCSharp.Size = new System.Drawing.Size(793, 312);
            this.tbCSharp.TabIndex = 3;
            this.tbCSharp.Text = "CSharp Class";
            this.tbCSharp.UseVisualStyleBackColor = true;
            // 
            // txtCSharpCode
            // 
            this.txtCSharpCode.Location = new System.Drawing.Point(12, 10);
            this.txtCSharpCode.Name = "txtCSharpCode";
            this.txtCSharpCode.Size = new System.Drawing.Size(764, 299);
            this.txtCSharpCode.TabIndex = 5;
            this.txtCSharpCode.Text = "";
            // 
            // tbTypeScript
            // 
            this.tbTypeScript.Controls.Add(this.txtTypeScript);
            this.tbTypeScript.Location = new System.Drawing.Point(4, 22);
            this.tbTypeScript.Name = "tbTypeScript";
            this.tbTypeScript.Size = new System.Drawing.Size(793, 312);
            this.tbTypeScript.TabIndex = 4;
            this.tbTypeScript.Text = "TypeScript Class";
            this.tbTypeScript.UseVisualStyleBackColor = true;
            // 
            // txtTypeScript
            // 
            this.txtTypeScript.Location = new System.Drawing.Point(4, 4);
            this.txtTypeScript.Name = "txtTypeScript";
            this.txtTypeScript.Size = new System.Drawing.Size(786, 305);
            this.txtTypeScript.TabIndex = 0;
            this.txtTypeScript.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Table";
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(88, 115);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(596, 21);
            this.cbTables.TabIndex = 3;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // chkEFMapping
            // 
            this.chkEFMapping.AutoSize = true;
            this.chkEFMapping.Location = new System.Drawing.Point(698, 117);
            this.chkEFMapping.Name = "chkEFMapping";
            this.chkEFMapping.Size = new System.Drawing.Size(83, 17);
            this.chkEFMapping.TabIndex = 6;
            this.chkEFMapping.Text = "EF Mapping";
            this.chkEFMapping.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(837, 502);
            this.Controls.Add(this.chkEFMapping);
            this.Controls.Add(this.tbSchema);
            this.Controls.Add(this.pnlDBConfig);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.label5);
            this.Name = "frmMain";
            this.Text = "Db Generator";
            this.pnlDBConfig.ResumeLayout(false);
            this.pnlDBConfig.PerformLayout();
            this.grbDBSelect.ResumeLayout(false);
            this.grbDBSelect.PerformLayout();
            this.tbSchema.ResumeLayout(false);
            this.tbtables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTables)).EndInit();
            this.tbColumns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdColumns)).EndInit();
            this.tbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.tbCSharp.ResumeLayout(false);
            this.tbTypeScript.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDBConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbMySQL;
        private System.Windows.Forms.RadioButton rbSQLServer;
        private System.Windows.Forms.RadioButton rbOracle;
        private System.Windows.Forms.RadioButton rbSqlite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDBSelect;
        private System.Windows.Forms.TextBox txtConnectString;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TabControl tbSchema;
        private System.Windows.Forms.TabPage tbtables;
        private System.Windows.Forms.TabPage tbColumns;
        private System.Windows.Forms.TabPage tbData;
        private System.Windows.Forms.TabPage tbCSharp;
        private System.Windows.Forms.TabPage tbTypeScript;
        private System.Windows.Forms.DataGridView grdTables;
        private System.Windows.Forms.DataGridView grdColumns;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.RichTextBox txtCSharpCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.CheckBox chkEFMapping;
        private System.Windows.Forms.RichTextBox txtTypeScript;
    }
}

