using ExcelDataReader;
using masterdata_integration.models.customer;
using MetroFramework.Forms;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using masterdata_integration.models;

namespace masterdata_integration
{
    public partial class frmMain : MetroForm
    {
        DataTableCollection dataTableCollection;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
        public void FillGrid()
        {
            DataTable table = dataTableCollection[cboSheet.SelectedItem.ToString()];
            dataGrid.DataSource = table;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            LoadExcel();
        }
        public void LoadExcel()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx;*.xlsm" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        txtFileName.Text = openFileDialog.FileName;
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                dataTableCollection = result.Tables;
                                cboSheet.Items.Clear();
                                foreach (DataTable table in dataTableCollection)
                                    cboSheet.Items.Add(table.TableName);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Yüklemek istedğiniz excel dosyası açıktır. Lütfen kapatıp tekrar deneyin ...", "Excel Yüklenmeme Sorunu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }
        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (cboSheet.SelectedItem != null && txtFileName.Text != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                string selecteditem = cboSheet.SelectedItem.ToString();
                if (selecteditem == ExcelSheetType.Customer)
                {
                    FiilCustomers();
                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                MessageBox.Show("Dosya ya da Excel türü seçiniz", "Bilgilendirme Mesajı", MessageBoxButtons.OK);
            }           
        }
        public void FiilCustomers()
        {
            List<Customer> customers = new List<Customer>();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Index > 0)
                {
                    Customer customer = new Customer();
                    customer.Code = row.Cells[CustomerCellNumber.Code].Value.ToString();
                    customer.Name = row.Cells[CustomerCellNumber.Name].Value.ToString();
                    customer.Address = row.Cells[CustomerCellNumber.Address].Value.ToString();
                    customer.CityId = Convert.ToInt32(row.Cells[CustomerCellNumber.CityId].Value);
                    customer.DistrictId = Convert.ToInt32(row.Cells[CustomerCellNumber.DistrictId].Value);
                    customer.PostCode = row.Cells[CustomerCellNumber.PostCode].Value.ToString();
                    customer.PhoneNumber = row.Cells[CustomerCellNumber.PhoneNumber].Value.ToString();
                    customer.PhoneNumber2 = row.Cells[CustomerCellNumber.PhoneNumber2].Value.ToString();
                    customer.Fax = row.Cells[CustomerCellNumber.Fax].Value.ToString();
                    customer.Website = row.Cells[CustomerCellNumber.WebSite].Value.ToString();
                    customer.Email = row.Cells[CustomerCellNumber.Email].Value.ToString();
                    customer.ContactPerson = row.Cells[CustomerCellNumber.ContactPerson].Value.ToString();
                    customer.ContactPersonPhoneNumber = row.Cells[CustomerCellNumber.ContactPersonPhoneNumber].Value.ToString();
                    customer.TaxOffice = row.Cells[CustomerCellNumber.TaxOffice].Value.ToString();
                    customer.TaxNumber_IdentificationNumber = row.Cells[CustomerCellNumber.TaxNumber_IdentificationNumber].Value.ToString();
                    customer.DistributorBranchId = Convert.ToInt32(row.Cells[CustomerCellNumber.DistributorBranchId].Value);
                    customer.WarehouseId = Convert.ToInt32(row.Cells[CustomerCellNumber.WarehouseId].Value);
                    customer.TradingGroupId = Convert.ToInt32(row.Cells[CustomerCellNumber.TradingGroupId].Value);
                    customer.PaymentTypeId = Convert.ToInt32(row.Cells[CustomerCellNumber.PaymentTypeId].Value);
                    customer.CustomerChannelId = Convert.ToInt32(row.Cells[CustomerCellNumber.CustomerChannelId].Value);
                    customer.CustomerTypeId = Convert.ToInt32(row.Cells[CustomerCellNumber.CustomerTypeId].Value);
                    customer.IsbillCustomer = Convert.ToBoolean(row.Cells[CustomerCellNumber.IsbillCustomer].Value);
                    customer.IsWayCustomer = Convert.ToBoolean(row.Cells[CustomerCellNumber.IsWayCustomer].Value);
                    customer.SalesmanId = Convert.ToInt32(row.Cells[CustomerCellNumber.SalesmanId].Value);
                    customer.CustomerBussinessType = Convert.ToBoolean(row.Cells[CustomerCellNumber.CustomerBussinessType].Value);
                    customers.Add(customer);
                }
            }
            var test = customers;
        }
    }
}
