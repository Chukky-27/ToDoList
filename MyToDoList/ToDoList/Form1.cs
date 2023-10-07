//using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace ToDoList
{
    public partial class toDoList : Form
    {
        //Variables
        DataAccessDb db = new DataAccessDb();

        //usp_todoapp
        public toDoList()
        {
            InitializeComponent();
        }

        private void toDoList_Load(object sender, EventArgs e)
        {
            completedcomboBox.SelectedIndex = 0;
            vloadData();
        }
        DataGridViewCheckBoxColumn chk;
        DataGridViewButtonColumn col_update;
        private void vloadData()
        {
            chk = new DataGridViewCheckBoxColumn();
            chk.Name = "Chk"; chk.HeaderText = "Check";

            col_update = new DataGridViewButtonColumn();
            col_update.Name = "edit";
            col_update.HeaderText = "Edit";
            col_update.Text = "Edit";
            col_update.UseColumnTextForButtonValue = true;
            //DataGridViewButtonColumn col_Delete = new DataGridViewButtonColumn(); col_Delete.Name = "Delete"; col_Delete.Text = "Delete"; col_Delete.HeaderText = "Delete"; col_Delete.UseColumnTextForButtonValue = true;

            string strsql = "usp_todoap '','','','','','VIEW'";
            DataSet ds = db.vFilldataset(strsql);
            dvg.Columns.Clear();
            dvg.Columns.Add(chk);
            dvg.DataSource = ds.Tables[0];
            dvg.Columns.Add(col_update);

        }
        List<string> checkedIn = new List<string>();

        private void vUPDATEData()
        {
            string strsql = "usp_todoap '','','','','','UPDATE'";
            DataSet ds = db.vFilldataset(strsql);

        }

        private void vDELETEData()
        {
            foreach (string id in checkedIn)
            {
                string strsql = "usp_todoap '" + id + "','','','','','DELETE'";
                db.vFilldataset(strsql);
            }


        }


        private void vADDData()
        {
            string strsql = "usp_todoap '','" + txtTitle.Text + "','" + DateTime.Parse(dtpDate.Value.ToString()) + "','NO','" + txtDescription.Text + "','ADD'";
            DataSet ds = db.vFilldataset(strsql);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.vADDData();
            this.vloadData();
        }

        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dvg.EndEdit();
            try
            {
                if (e.ColumnIndex == 0)
                {
                    string? check = dvg["Chk", e.RowIndex].Value.ToString();
                    string? id = dvg["Id", e.RowIndex].Value.ToString();
                    if (check == "True")
                    {
                        checkedIn.Add(id);
                    }
                    else
                    {
                        if (checkedIn.Contains(id))
                        {
                            checkedIn.Remove(id);
                        }
                    }
                }
                if (e.ColumnIndex == col_update.Index)
                {
                    string? id = dvg["Id", e.RowIndex].Value.ToString();
                    string? title = dvg["Title", e.RowIndex].Value.ToString();
                    string? descr = dvg["Description", e.RowIndex].Value.ToString();
                    string? date = dvg["Date", e.RowIndex].Value.ToString();
                    string? comp = dvg["Completed", e.RowIndex].Value.ToString();

                    txtId.Text = id;
                    txtTitle.Text = title;
                    txtDescription.Text = descr;
                    dtpDate.Value = DateTime.Parse(date);
                    completedcomboBox.SelectedItem = comp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            vDELETEData();
            vloadData();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txtDescription.Text = "";
            txtId.Text = "";
            txtTitle.Text = "";
            dtpDate.Value = DateTime.UtcNow;
            vloadData();
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            string search = searchtextBox.Text;
            if (search == "")
            {
                vloadData();
            }
            else
            {
                string? search_criteria = searchcomboBox.SelectedIndex == 0 ? "TITLE" : "DATE";

                string sql = "usp_todoap '','','','','" + search + "','" + search_criteria + "'";
                DataSet ds = db.vFilldataset(sql);
                dvg.DataSource = ds.Tables[0];
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a row to update");
                return;
            }
            //MessageBox.Show(txtId.Text);
            //MessageBox.Show(txtTitle.Text);
            //MessageBox.Show(dtpDate.Value.ToString());
            //MessageBox.Show(completedcomboBox.SelectedItem.ToString());
            //MessageBox.Show(txtDescription.Text);
            string strsql = "usp_todoap '" + txtId.Text + "','" + txtTitle.Text + "','" + DateTime.Parse(dtpDate.Value.ToString()) + "','" + completedcomboBox.SelectedItem.ToString() + "','" + txtDescription.Text + "','UPDATE'";
            DataSet ds = db.vFilldataset(strsql);
            vloadData();
        }

        private void searchcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class DataAccessDb
    {
        public DataSet vFilldataset(string strsql)
        {

            DataSet ds = new DataSet();
            SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-79E72PP;database=To_Do_List;Trusted_Connection=True");
            SqlCommand cmd = new SqlCommand(strsql, sqlConnection);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            adp.Fill(ds);

            return ds;
        }
    }
}