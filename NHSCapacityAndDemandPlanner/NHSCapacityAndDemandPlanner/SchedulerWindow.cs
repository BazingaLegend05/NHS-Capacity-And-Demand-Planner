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
        public SchedulerWindow()
        {
            InitializeComponent();
        }
        private void SchedulerWindow_Load(object sender, EventArgs e)
        {
            WriteTable writeTable = new WriteTable();
            ReadJSON readJSON = new ReadJSON();
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSONData", "ClinicianTimeTableWeek1.json");

            writeTable.WriteToTable(DynamicTable, readJSON.JsonTo2DArray(fullPath));
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
    }
    /// <summary>
    /// Universal class to write to the table using the json files provided.
    /// </summary>
    public class WriteTable
    {
        public void WriteToTable(DataGridView table, string[,] data)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            // Clear existing columns and rows
            table.Columns.Clear();
            table.Rows.Clear();
            // Add columns
            for (int c = 0; c < cols; c++)
            {
                table.Columns.Add($"Column{c}", $"Column {c + 1}");
            }
            // Add rows
            for (int r = 0; r < rows; r++)
            {
                string[] rowData = new string[cols];
                for (int c = 0; c < cols; c++)
                {
                    rowData[c] = data[r, c];
                }
                table.Rows.Add(rowData);
            }
        }
    }
    /// <summary>
    /// Retreives data from the json files and converts it into a 2D array that can be used to write to the table.
    /// </summary>
    public class ReadJSON
    {
        public string[,] JsonTo2DArray(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);

            using (JsonDocument doc = JsonDocument.Parse(fileContent))
            {
                JsonElement root = doc.RootElement.GetProperty("clinitianTimeTableWeek1");
                int rowCount = root.GetArrayLength();

                int colCount = root[0].EnumerateObject().Count();

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
                return data;

            }
        }
    }
}
