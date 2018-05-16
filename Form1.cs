using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBGen
{
    public partial class frmMain : Form
    {
        private IDBHelper dbHelper = null;
        public frmMain()
        {
            InitializeComponent();
            cbTables.Enabled = false;
            chkEFMapping.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            bool isValid = validate(out message);
            try
            {
                if (isValid)
                {
                    DBGen.DBType dbType;
                    DBFactory factory = new DBFactory();
                    if (rbSqlite.Checked) dbType = DBType.Sqlite;
                    else if (rbMySQL.Checked) dbType = DBType.MySQL;
                    else if (rbOracle.Checked) dbType = DBType.Oracle;
                    else dbType = DBType.SqlServer;
                    dbHelper = factory.GetDBInstance(txtConnectString.Text, dbType);
                    DataTable dtTables = dbHelper.GetTables();
                    grdTables.DataSource = dtTables;
                    SetTableNames();
                }
                else
                {
                    MessageBox.Show(message, "Validaton Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetTableNames()
        {
            DataRowCollection drCollection = dbHelper.GetTableNames().Rows;
            cbTables.Items.Clear();
            foreach (DataRow dr in drCollection)
            {
                cbTables.Items.Add(dr["Name"]);
            }
        }

        private bool validate(out String message)
        {
            bool isValid = true;
            message = string.Empty;
            if (String.IsNullOrEmpty(txtConnectString.Text))
            {
                message = "Connection String cannot be null";
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;

        }




        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tbSchema.SelectedTab.Name.Equals(tbColumns.Name))
            {
                cbTables.Enabled = true;
                chkEFMapping.Enabled = false;
                DataTable dtColumns = dbHelper.GetColumns(cbTables.SelectedItem.ToString());
                grdColumns.DataSource = dtColumns;

            }
            else if (tbSchema.SelectedTab.Name.Equals(tbData.Name))
            {
                cbTables.Enabled = true;
                chkEFMapping.Enabled = false;
                DataTable dtData = dbHelper.GetData(cbTables.SelectedItem.ToString());
                grdData.DataSource = dtData;
            }
            else if (tbSchema.SelectedTab.Name.Equals(tbCSharp.Name))
            {
                cbTables.Enabled = true;
                chkEFMapping.Enabled = true;
                DataTable dtColumns = dbHelper.GetColumns(cbTables.SelectedItem.ToString());
                ICodeHelper helper = new CSharpCodeHelper();
                txtCSharpCode.Text = helper.GetCode(cbTables.SelectedItem.ToString(), dtColumns, chkEFMapping.Checked);
            }
            else if (tbSchema.SelectedTab.Name.Equals(tbTypeScript.Name))
            {
                cbTables.Enabled = true;
                chkEFMapping.Enabled = false;
                DataTable dtColumns = dbHelper.GetColumns(cbTables.SelectedItem.ToString());
                ICodeHelper helper = new TypScriptCodeHelper();
                txtTypeScript.Text = helper.GetCode(cbTables.SelectedItem.ToString(), dtColumns, chkEFMapping.Checked);
            }
        }

        private void tbSchema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbSchema.SelectedTab.Name.Equals(tbtables.Name))
            {
                cbTables.Enabled = false;
                chkEFMapping.Enabled = false;
            }
            else if (tbSchema.SelectedTab.Name.Equals(tbData.Name))
            {
                cbTables.Enabled = true;
                chkEFMapping.Enabled = true;
            }
            else if (tbSchema.SelectedTab.Name.Equals(tbCSharp.Name))
            {
                cbTables.Enabled = true;
                chkEFMapping.Enabled = true;
            }
            else if (tbSchema.SelectedTab.Name.Equals(tbTypeScript.Name))
            {
                cbTables.Enabled = true;
                chkEFMapping.Enabled = false;
            }
        }
    }
    enum DBType
    {
      Sqlite ,
       Oracle ,
       MySQL,
       SqlServer
    }

}
