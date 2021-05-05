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
using System.Net.Mail;
using System.Net;

namespace masterdata_integration
{
    public partial class frmMain : MetroForm
    {
        DataTableCollection dataTableCollection;
        public frmMain()
        {
            InitializeComponent();
            //SendMail("mesutkaya2000@gmail.com","Ahmet Akan","060418","Samet Gıda");

        }

        public static void SendMail(string personelMail,string salesmanName, string routeCode, string customerName)
        {
            try
            {
                string mailbody;

                mailbody = "<table style='background-color:#fff;padding:10px;width:620px;text-align:left;border-top:10px solid #155ca9;border-bottom:10px solid #155ca9;border-left:10px solid #155ca9;border-right:10px solid #155ca9' width='630' cellspacing='0' cellpadding='0'><tbody><tr><td><table style='background-color:#ffffff;' width='100%' cellspacing='0' cellpadding = '0'>  <tbody><tr>" +
                    "<td style = 'padding: 10px;'><a href = 'https://www.salesart.io/' target = '_blank'  > " +
                    "<img src = 'https://www.salesart.io/images/logo.png' alt = '' width = '220' height = '50' border = '0' /></a></td>" +
                    "<td style = 'color: #1a2640; font-family: Arial; font-size: 13px;margin-left:50px;' align = 'right' > (0530) 915 9055 <span style = 'color: #a5b9c5; font-size: 24px;' >|</span> <a style = 'text-decoration: none; color: #1a2640;' href = '#' target = '_blank' data - saferedirecturl = '#'>www.salesart.io </a> &nbsp; &nbsp; &nbsp;</td></tr><tr><td colspan = '2' ><hr style='border: 1px dashed black;'/> </td></tr>" +
                    "<tr><td style = 'padding: 10px; font-size: 12px; font-family: Arial;' colspan = '2' ><p style = 'margin: 0 0 10px 0;'> " +
                    "Sayın <strong> Hedef Gıda </strong>,</p><p style = 'margin: 0 0 10px 0;' > " +
                    "<p> Satış Temsilcisi : <strong>" + salesmanName + "</strong> </p> " +
                    "<p> Rota Kodu : <strong>" + routeCode + "</strong> </p> " +
                    "<p> Müşteri Adı : <strong>" + customerName + "</strong> </p>" +
                    "olan rota planında <strong>" + routeCode + "</strong> olan  Rota Kodu yanlış girilmiştir. Düzeltmenizi rica ederiz." +
                    " <p style = 'margin: 0 0 0 0;' >" +
                    "Her türlü sorunuzda bize <a style = 'color: #000000;' href = 'mailto:destek@bil-gel.com.tr' target = '_blank'> destek@bil-gel.com.tr </a> adresinden ulaşabilir veya" +
                    "<a href = 'tel:0530 915 9055' target = '_blank' > (0530) 915 9055 </a> nolu telefondan Destek Birimi ile görüşebilirsiniz.</p><p style = 'margin: 20px 0 0 0;' > Saygılarımızla,</p><p style = 'margin: 5px 0 0 0;' > Bil-Gel Destek Birimi</p></td></tr><tr><td colspan = '2' ><hr style='border: 1px dashed black;'/></td></tr><tr><td style = 'padding: 10px; color: #808080; font-size: 12px;' colspan = '2'><p style = 'margin: 0 0 0 0; font-family: Arial;' > Copyright &copy; 2021 Bil-Gel  | Tüm hakları saklıdır.</p></td></tr></tbody></table></td></tr></tbody></table> ";
                MailMessage mesaj = new MailMessage();
                mesaj.From = new MailAddress("mesutkaya@bil-gel.com.tr", "Bildirim");                
                if (personelMail != null)
                {
                    mesaj.To.Add(personelMail);                    
                }
                mesaj.CC.Add("mucahitceviz@bil-gel.com.tr");
                mesaj.Subject = "Bil-Gel Destek | Bildirim";
                mesaj.Body = mailbody;
                mesaj.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("mesutkaya@bil-gel.com.tr", "Mesut1905");
                client.EnableSsl = true;
                client.Send(mesaj);
            }
            catch (Exception ex)
            {


            }
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
