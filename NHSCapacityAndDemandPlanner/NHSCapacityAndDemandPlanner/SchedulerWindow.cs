using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHSCapacityAndDemandPlanner
{
    public partial class SchedulerWindow : Form
    {
        public string SelectedTable { get; set; }
        public string DataRoute { get; set; }
        public SchedulerWindow()
        {
            InitializeComponent();
        }
        private void SchedulerWindow_Load(object sender, EventArgs e)
        {
            DropDown.SelectedIndex = 0;
            DataRoute = "ClinicianTimeTableWeek1.json";
            WriteTable writeTable = new WriteTable();
            ReadJSON readJSON = new ReadJSON();
            string fileRoot = readJSON.GetRoot(DataRoute);
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSONdata", "ClinicianTimeTableWeek1.json");
            var result = readJSON.JsonTo2DArray(fullPath, fileRoot);
            writeTable.WriteToTable(DynamicTable, result.headers, result.data);
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void DynamicTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTable = DropDown.SelectedItem.ToString();
            if(SelectedTable == "Clinitian Timetable") DataRoute = "ClinicianTimeTableWeek1.json";
            else if (SelectedTable == "Theatre Timetable") DataRoute = "TheatreTimeTableWeek1.json";

            if (DataRoute != null)
            {
                DynamicTable.DataSource = null;
                WriteTable writeTable = new WriteTable();
                ReadJSON readJSON = new ReadJSON();
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSONdata", DataRoute);
                string fileRoot = readJSON.GetRoot(DataRoute);
                var result = readJSON.JsonTo2DArray(fullPath, fileRoot);
                writeTable.WriteToTable(DynamicTable, result.headers, result.data);
            }
        }
    }
    /// <summary>
    /// Universal class to write to the table using the json files provided.
    /// </summary>
    public class WriteTable
    {
        public void WriteToTable(DataGridView table, string[] headers, string[,] data)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            // Clear existing columns and rows
            table.Columns.Clear();
            table.Rows.Clear();
            // Add columns
            for (int c = 0; c < cols; c++)
            {
                table.Columns.Add($"Column{c}", headers[c]);
            }
            // Add rows
            for (int r = 0; r < rows; r++)
            {

                string[] rowData = new string[cols];
                for (int c = 0; c < cols; c++)
                {
                    rowData[c] = data[r, c];
                }

                int rowIndex = table.Rows.Add(rowData);

                for (int c = 0; c<cols ; c++)
                {
                    string cellValue = rowData[c]?.ToLower() ?? "";

                    if (cellValue.Contains("annual leave"))
                    {
                        table.Rows[rowIndex].Cells[c].Style.BackColor = Color.Yellow;
                    }
                    else if (cellValue.Contains("study leave"))
                    {
                        table.Rows[rowIndex].Cells[c].Style.BackColor = Color.Red;
                    }
                    else if (cellValue.Contains("sick"))
                    {
                        table.Rows[rowIndex].Cells[c].Style.BackColor = Color.LightGreen;
                    }
                    else if (cellValue.Contains("theatre"))
                    {
                        table.Rows[rowIndex].Cells[c].Style.BackColor = Color.LightBlue;
                    }
                }
            }
        }
    }
    /// <summary>
    /// Retreives data from the json files and converts it into a 2D array that can be used to write to the table.
    /// </summary>
    public class ReadJSON
    {
        public string GetRoot(string DataRoute)
        {
            string root = "";
            if (DataRoute == "ClinicianTimeTableWeek1.json")
            {
                root = "clinicianTimeTableWeek1";
            }
            else if(DataRoute == "ClinicianTimeTableWeek2.json") { root = "clinitcianTimeTableWeek2";
            }
            else if (DataRoute == "TheatreTimeTableWeek1.json")
            {
                root = "theatreTimeTableWeek1";
            }
            else if (DataRoute == "TheatreTimeTableWeek2.json")
            {
                root = "theatreTimeTableWeek2";
            }

            return root;
        }
        public (string[] headers, string[,] data) JsonTo2DArray(string filePath, string fileRoot)
        {
            string fileContent = File.ReadAllText(filePath);

            using (JsonDocument doc = JsonDocument.Parse(fileContent))
            {
                JsonElement root = doc.RootElement.GetProperty(fileRoot);
                int rowCount = root.GetArrayLength();

                var firstObject = root[0];
                string[] headers = firstObject.EnumerateObject().Select(p => p.Name).ToArray();
                int colCount = headers.Length;

                string[,] data = new string[rowCount, colCount];

                for (int i = 0; i < rowCount; i++)
                {
                    int j = 0;
                    foreach (JsonProperty property in root[i].EnumerateObject())
                    {
                        data[i, j] = property.Value.ToString() ?? "";
                        j++;
                    }
                }
                return (headers, data);

            }
        }
    }
}
