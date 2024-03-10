using Guna.UI.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Project_Pulse.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Project_Pulse.UI.UserControls
{
    public partial class UC_manage_Report : UserControl
    {
        string report_1 = "SELECT SP.RegistrationNo,SP.[Student Name],p.Title,MA.[Main Advisor],CA.[Co Advisor],IA.[Industry Advisor] FROM Project p INNER JOIN(SELECT Pr.FirstName + ' ' + PR.LastName as [Main Advisor], ProjectId from ProjectAdvisor PA INNER JOIN Person Pr ON PA.AdvisorId = Pr.Id WHERE PA.AdvisorRole in (SELECT Id from lookup where value = 'Main Advisor')) as MA ON p.Id = MA.ProjectId INNER JOIN(SELECT Pr.FirstName+' ' + PR.LastName as [Co Advisor],ProjectId from ProjectAdvisor PA INNER JOIN Person Pr ON PA.AdvisorId = Pr.Id WHERE PA.AdvisorRole in (SELECT Id from lookup where value = 'Co-Advisor')) as CA ON p.Id = CA.ProjectId INNER JOIN(SELECT Pr.FirstName+' ' + PR.LastName as [Industry Advisor],ProjectId from ProjectAdvisor PA INNER JOIN Person Pr ON PA.AdvisorId = Pr.Id WHERE PA.AdvisorRole in (SELECT Id from lookup where value = 'Industry Advisor')) as IA ON IA.ProjectId = p.Id INNER JOIN(SELECT Pr.FirstName+' ' + PR.LastName as [Student Name],S.RegistrationNo,ProjectId from GroupProject GP INNER JOIN GroupStudent GS ON GS.GroupId = GP.GroupId INNER JOIN Student S ON GS.StudentId = S.Id INNER JOIN Person Pr ON S.Id = Pr.Id WHERE GS.Status = (SELECT Id FROM Lookup WHERE Value = 'Active')) as SP ON SP.ProjectId = p.Id ORDER BY p.Title,RegistrationNo";
        string report_2 = "SELECT P.Title as [Project Title],Student.RegistrationNo,Student.[Student Name],Eval.Name as [Evaluation],Eval.TotalMarks as [Total Marks],Eval.ObtainedMarks as [Obtained Marks] FROM(SELECT Pr.FirstName+' ' + PR.LastName as [Student Name],S.RegistrationNo,ProjectId,GS.GroupId from GroupProject GP INNER JOIN GroupStudent GS ON GS.GroupId = GP.GroupId INNER JOIN Student S ON GS.StudentId = S.Id INNER JOIN Person Pr ON S.Id = Pr.Id WHERE GS.Status = (SELECT Id FROM Lookup WHERE Value = 'Active')) as Student INNER JOIN(SELECT GP.ProjectId, E.Name, E.TotalMarks, GE.ObtainedMarks, GE.GroupId FROM GroupEvaluation GE INNER JOIN GroupProject GP ON GE.GroupId = GP.GroupId INNER JOIN Evaluation E ON E.Id = GE.EvaluationId) as Eval ON Student.GroupId = Eval.GroupId AND Student.ProjectId = Eval.ProjectId INNER JOIN Project P ON P.Id = Eval.ProjectId ORDER BY eval.Name";
        string report_5 = "SELECT S.RegistrationNo,GS.GroupId,P.Title FROM Student S LEFT OUTER JOIN GroupStudent GS ON S.Id = GS.StudentId LEFT OUTER JOIN GroupProject GP ON GP.GroupId = GS.GroupId LEFT OUTER JOIN Project P ON P.Id = GP.ProjectId order by GS.GroupId,S.RegistrationNo";

        List<GunaMediumRadioButton> radioButtons = new List<GunaMediumRadioButton>();
        public UC_manage_Report()
        {
            InitializeComponent();
            radioButtons.Add(rbtn_report_1);
            radioButtons.Add(rbtn_2);
            radioButtons.Add(rbtn3);
            radioButtons.Add(rbtn4);
            radioButtons.Add(rbtn5);







        }

        private void label_report_1_Click(object sender, EventArgs e)
        {
            selectRadio(rbtn_report_1);
        }
        void selectRadio(GunaMediumRadioButton radio)
        {
            for (int i = 0; i < radioButtons.Count; i++)
            {
                if (radioButtons[i] == radio)
                {
                    radio.Checked = true;
                }
                else
                {
                    radioButtons[i].Checked = false;
                }
            }
        }






        public DataGridView PopulateDataGrid(string query)
        {
            // Create a DataGridView
            var dataGridView = new DataGridView();

            // Use a DataTable to hold the query results
            DataTable dataTable = new DataTable();

            try
            {
                // Establish connection using the connection string
                using (SqlConnection connection = new SqlConnection(Essentials.SqlConnectionString))
                {
                    connection.Open();

                    // Create a SqlCommand object with the provided query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use a SqlDataAdapter to execute the query and fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }

                // Set the DataGridView's DataSource to the DataTable
                dataGridView.DataSource = dataTable;

                // Optionally, configure columns (headers, data types) here
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    dataGridView.Columns[i].HeaderText = dataTable.Columns[i].ColumnName;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., display error message)
                MessageBox.Show("Error: " + ex.Message);
            }

            return dataGridView;
        }


        void reportGenerate(DataGridView table)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (.pdf)|.pdf";
            saveFileDialog.Title = "Export to PDF";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);


                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                document.Open();
                //string specificDate = AllTime_box.SelectedItem.ToString();

                //Paragraph dateParagraph = new Paragraph();
                //document.Add(dateParagraph);

                PdfPTable pdfTable = new PdfPTable(table.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                foreach (DataGridViewColumn column in table.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in table.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        object cellValue = cell.Value;
                        string cellText = cellValue != null ? cellValue.ToString() : "";
                        pdfTable.AddCell(cellText);
                    }
                }

                document.Add(pdfTable);



                document.Close();

                MessageBox.Show("PDF file has been created!");

            }
        }



        private void btn_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var report in radioButtons)
            {
                if (report.Checked)
                {
                    if (count == 0)
                    {
                        DataGridView datagridView = PopulateDataGrid(report_1);
                        reportGenerate(datagridView);
                        return;
                    }
                    else if (count == 1)
                    {
                        DataGridView datagridView = PopulateDataGrid(report_2);
                        reportGenerate(datagridView);
                        return;
                    }
                    else if (count == 2)
                    {

                    }
                    else if (count == 3)
                    {

                    }
                    else if (count == 4)
                    {
                        DataGridView datagridView = PopulateDataGrid(report_5);
                        reportGenerate(datagridView);
                        return;
                    }

                }
                count++;
            }
        }

        private void label_report_2_Click(object sender, EventArgs e)
        {
            selectRadio(rbtn_2);
        }


        private void label_report_3_Click(object sender, EventArgs e)
        {
            selectRadio(rbtn3);

        }

        private void label_report_4_Click(object sender, EventArgs e)
        {
            selectRadio(rbtn4);

        }

        private void label_report_5_Click(object sender, EventArgs e)
        {
            selectRadio(rbtn5);
        }
    }
}
