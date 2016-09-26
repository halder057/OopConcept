using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
      
        private GridViewSearchRowInfo searchRow;
        public Form1()
        {
            InitializeComponent();

            this.radGridView1.SelectionMode = Telerik.WinControls.UI.GridViewSelectionMode.CellSelect;
            this.radGridView1.MultiSelect = true;

            BindingSource source = new BindingSource();
            List<string> firstName = new List<string> { "John Holder", "Jim", "Jason", "Barbara", "Ben", "Thomas", "Antonio" };
            List<string> lastName = new List<string> { "Baumer", "Davidson", "Jones", "Jolie", "Pitt", "Ashword", "Moreno" };
            for (int i = 0; i < 7; i++)
            {
                source.Add(new Employee(i, firstName[i], lastName[i], i + 1));
            }

            radGridView1.DataSource = source;
       
            this.radGridView1.AllowSearchRow = true;         
            searchRow = this.radGridView1.MasterView.TableSearchRow;
            searchRow.HighlightResults = true;
            searchRow.IsVisible = false;

            this.radGridView1.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
            this.radGridView1.MasterTemplate.ShowFilteringRow = false;
        }

        public class Employee
        {
            public Employee(int id, string fn, string ln, int age)
            {
                this.EmployeeId = id;
                this.FirstName = fn;
                this.LastName = ln;
                this.Age = age;
            }
            //the next attribute prevents the EmployeeId column from showing
            [Browsable(false)]
            public int EmployeeId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (searchRow.IsVisible == false)
            //{
            //    searchRow.IsVisible = true;
                
            //    Application.DoEvents();
            //    GridSearchCellElement searchCell = radGridView1.TableElement.GetCellElement(searchRow, null) as GridSearchCellElement;
            //    if (searchCell != null)
            //    {
            //        searchCell.SearchTextBox.Focus();
            //    }
            //}
            //else
            //{
            //    searchRow.IsVisible = false;
                
            //}
            this.radGridView1.Focus();
            this.radGridView1.Rows[2].Cells[2].IsSelected = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridSearchCellElement searchCell = radGridView1.TableElement.GetCellElement(radGridView1.MasterView.TableSearchRow, null) as GridSearchCellElement;
            if (searchCell != null)
            {
                searchCell.SearchTextBox.Focus();
            }
            var cells = radGridView1.SelectedCells.ToList();
        }
    }
}
