using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab1
{
    public partial class Songs : Form
    {
        SqlConnection cs = new SqlConnection("data source=DESKTOP-IEQQ91K\\SQLEXPRESS; Initial Catalog=Songs DB; Integrated Security=true");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();

        public Songs()
        {

            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM Genre",cs);
            ds.Clear();
            da.Fill(ds);

            GenreGridView.DataSource = ds.Tables[0];
            bs.DataSource = ds.Tables[0];

            txtGenreId.DataBindings.Add("Text", bs, "GenreId");
            
        }


        


        //neterminat
        private void dataGridViewUpdate()
        {
            TracksGridView.ClearSelection();
            
        }


        //neterminat
        private void update_gridview(int id)
        {
            int x;
            da.UpdateCommand = new SqlCommand("UPDATE Track SET TRACKID=@t,NAME=@n,ALBUMID=@a,GENREID=@g,COMPOSER=@c,MILLISECONDS=@m,BYTES=@b",cs);
            da.UpdateCommand.Parameters.Add("@t", SqlDbType.Int).Value = txtTId.Text;
            da.UpdateCommand.Parameters.Add("@n", SqlDbType.VarChar).Value = txtTName.Text;
            da.UpdateCommand.Parameters.Add("@a", SqlDbType.Int).Value = txtAId.Text;
            da.UpdateCommand.Parameters.Add("@g", SqlDbType.Int).Value = txtGId.Text;
            da.UpdateCommand.Parameters.Add("@c", SqlDbType.VarChar).Value = txtComposer.Text;
            da.UpdateCommand.Parameters.Add("@m", SqlDbType.Int).Value = txtMilliseconds.Text;
            da.UpdateCommand.Parameters.Add("@b", SqlDbType.Int).Value = txtBytes.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new SqlCommand("INSERT INTO Track VALUES(@t,@n,@a,@g,@c,@m,@b)", cs);
            da.InsertCommand.Parameters.Add("@t", SqlDbType.Int).Value = txtTId.Text;
            da.InsertCommand.Parameters.Add("@n", SqlDbType.VarChar).Value = txtTName.Text;
            da.InsertCommand.Parameters.Add("@a", SqlDbType.Int).Value = txtAId.Text;
            da.InsertCommand.Parameters.Add("@g", SqlDbType.Int).Value = txtGenreId.Text;
            da.InsertCommand.Parameters.Add("@c", SqlDbType.VarChar).Value = txtComposer.Text;
            da.InsertCommand.Parameters.Add("@m", SqlDbType.Int).Value = txtMilliseconds.Text;
            da.InsertCommand.Parameters.Add("@b", SqlDbType.Int).Value = txtBytes.Text;

            cs.Open();
            da.InsertCommand.ExecuteNonQuery();
            cs.Close();
        }

        

        private void GenreGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            int.TryParse(this.GenreGridView.CurrentRow.Cells[0].Value.ToString(), out id);

            txtGenreId.Text = id.ToString();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cs;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Track WHERE GenreId = @g";
            cmd.Parameters.Add("@g", id);
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(ds2, "Track");
            TracksGridView.DataSource = ds2.Tables[0];

            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Are you sure?\n No undo after delete", "Confirm deletion", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                int id;
                int.TryParse(this.txtTId.Text, out id);

                DataSet ds2 = new DataSet();
                SqlDataAdapter da2 = new SqlDataAdapter();
                da2.DeleteCommand = new SqlCommand("Delete from Track where TrackID=@id", cs);
                da2.DeleteCommand.Parameters.Add("@id",SqlDbType.Int).Value=id;

                cs.Open();
                da2.DeleteCommand.ExecuteNonQuery();
                cs.Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DataSet ds2 = new DataSet();
            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.UpdateCommand = new SqlCommand("UPDATE Track SET NAME=@n,ALBUMID=@a,GENREID=@g,COMPOSER=@c,MILLISECONDS=@m,BYTES=@b WHERE TRACKID=@t", cs);
            da2.UpdateCommand.Parameters.Add("@t", SqlDbType.Int).Value = txtTId.Text;
            da2.UpdateCommand.Parameters.Add("@n", SqlDbType.VarChar).Value = txtTName.Text;
            da2.UpdateCommand.Parameters.Add("@a", SqlDbType.Int).Value = txtAId.Text;
            da2.UpdateCommand.Parameters.Add("@g", SqlDbType.Int).Value = txtGId.Text;
            da2.UpdateCommand.Parameters.Add("@c", SqlDbType.VarChar).Value = txtComposer.Text;
            da2.UpdateCommand.Parameters.Add("@m", SqlDbType.Int).Value = txtMilliseconds.Text;
            da2.UpdateCommand.Parameters.Add("@b", SqlDbType.Int).Value = txtBytes.Text;

            cs.Open();
            da2.UpdateCommand.ExecuteNonQuery();
            cs.Close();
        }
    }
}
