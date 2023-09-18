using System;
using System.Data;
using System.Windows.Forms;

namespace new_project1
{
    public partial class listviewcontrol : UserControl
    {
        public DataTable InfoTable { get;set;}
        public   string gh { get; set; }
        public listviewcontrol()
        {
            InitializeComponent();
            listView1.Columns.Add("MemberID", 90);
            listView1.Columns.Add("MemberName", 190);
            listView1.Columns.Add("Phone", 130);
            listView1.Columns.Add("class", 120);
            listView1.Columns.Add("section", 120);
            listView1.Columns.Add("Barcode", 120);
            listView1.Columns.Add("Gender", 100);
            listView1.Columns.Add("Registeration date", 180);
        }

        public void fill()
        {
            string[] x = new string[InfoTable.Columns.Count];
            for (int i = 0; i < InfoTable.Rows.Count; i++)
            {
                for (int j = 0; j < InfoTable.Columns.Count; j++)
                {
                    x[j] = InfoTable.Rows[i][j].ToString();
                    if (j != 5)
                    {
                        x[j] = InfoTable.Rows[i][j].ToString();
                        // listView1.Items.Add(new ListViewItem(x));
                    }
                    else
                    {
                        x[j] = gh;
                        //listView1.Items.Add(new ListViewItem(x));
                    }
                }
                listView1.Items.Add(new ListViewItem(x));
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
