using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appointment
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Server=localhost;Database=reservations;Uid=root;Pwd=;";
        private DataTable reservationsTable;

        public Form1()
        {
            InitializeComponent();
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;

            LoadReservations();
        }

        private void LoadReservations()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT Patient, Owner, ReservationDate, ReservationTime, ContactEmail FROM Reservations";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        reservationsTable = new DataTable();
                        adapter.Fill(reservationsTable);

                        if (!reservationsTable.Columns.Contains("Status"))
                        {
                            reservationsTable.Columns.Add("Status", typeof(string));
                        }

                        foreach (DataRow row in reservationsTable.Rows)
                        {
                            DateTime appointmentDate = DateTime.Parse(row["ReservationDate"].ToString());
                            string status = CalculateStatus(appointmentDate);
                            row["Status"] = status;
                        }

                        dgvReservations.DataSource = reservationsTable;
                    }
                }
            }
        }

        private string CalculateStatus(DateTime appointmentDate)
        {
            DateTime currentDate = DateTime.Now;

            if (appointmentDate > currentDate)
            {
                return "Pending";
            }
            else if (appointmentDate < currentDate)
            {
                return "Completed";
            }
            else
            {
                return "Cancelled";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string patient = txtPatient.Text;
            string owner = txtOwner.Text;
            string contactEmail = txtContactEmail.Text;
            DateTime reservationDate = monthCalendar.SelectionStart;
            string selectedTimeSlot = cmbTimeSlots.SelectedItem.ToString();

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Reservations (Patient, Owner, ReservationDate, ReservationTime, ContactEmail) " + "VALUES (@Patient, @Owner, @ReservationDate, @ReservationTime, @ContactEmail)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Patient", patient);
                    command.Parameters.AddWithValue("@Owner", owner);
                    command.Parameters.AddWithValue("@ReservationDate", reservationDate);
                    command.Parameters.AddWithValue("@ReservationTime", selectedTimeSlot);
                    command.Parameters.AddWithValue("@ContactEmail", contactEmail);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Appointment submitted successfully");
            LoadReservations();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] timeSlots = { "9:00 AM", "10:00 AM", "11:00 AM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM" };
            cmbTimeSlots.Items.AddRange(timeSlots);
            cmbTimeSlots.SelectedIndex = 0;

            LoadReservations();
            
                cmbStatusFilter.Items.Add("All");
                cmbStatusFilter.Items.Add("Pending");
                cmbStatusFilter.Items.Add("Completed");
                cmbStatusFilter.Items.Add("Cancelled");

                cmbStatusFilter.SelectedItem = "All";
            

        }

        private void dgvReservations_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
                if (e.ColumnIndex == dgvReservations.Columns["Status"].Index && e.Value != null)
                {
                    string status = e.Value.ToString();
                    if (status == "Pending")
                    {
                        e.CellStyle.ForeColor = Color.Orange;
                    }
                    else if (status == "Completed")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else if (status == "Cancelled")
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cmbStatusFilter.SelectedItem.ToString();

            if (selectedStatus == "All")
            {

                dgvReservations.DataSource = reservationsTable; 
            }
            else
            {

                DataView dv = new DataView(reservationsTable);
                dv.RowFilter = $"Status = '{selectedStatus}'";
                dgvReservations.DataSource = dv.ToTable();
            }
        }
    }
}
