using CustomerProject.Model;
using CustomerProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly IGetMethods clsGetMethods = new ClassGetMethods();
        private readonly IPostMethods clsPostMethods = new ClassPostMethods();
        private string GetGender()
        {
            var errRes = string.Empty;
            try
            {
                (var dt, var err) = clsGetMethods.GetGender();
                errRes = err;
                if (string.IsNullOrWhiteSpace(errRes))
                {
                    cmbGender.ValueMember = dt.Columns["ID"].ToString(); //ID
                    cmbGender.DisplayMember = dt.Columns["NAME"].ToString(); //Name
                    cmbGender.DataSource = dt;
                    cmbGender.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                errRes = ex.Message;
            }
            return errRes;
        }
        private void GridFill(DataTable dt)
        {
            dgvCustomers.DataSource = dt;
            dgvCustomers.ClearSelection();
            dgvCustomers.Columns["IDN"].HeaderText = "Qeydiyyat";
            dgvCustomers.Columns["IDN"].Width = 80;
            dgvCustomers.Columns["NAME"].HeaderText = "Ad";
            dgvCustomers.Columns["SURNAME"].HeaderText = "Soyad";
            dgvCustomers.Columns["BIRTH_PLACE"].HeaderText = "Doğum yeri";
            dgvCustomers.Columns["BIRTH_DATE"].HeaderText = "Doğum tarixi";
            dgvCustomers.Columns["BIRTH_DATE"].DefaultCellStyle.Format = "dd.MM.yyyy";
            dgvCustomers.Columns["GENDER_NAME"].HeaderText = "Cins";
            dgvCustomers.Columns["DOC_NO"].HeaderText = "Seriya nömrəsi";
            dgvCustomers.Columns["FIN_CODE"].HeaderText = "Finkod";
            dgvCustomers.Columns["PHONE_NUMBER"].HeaderText = "Telefon";
            dgvCustomers.Columns["EMAIL"].HeaderText = "Email";
            dgvCustomers.Columns["GENDER"].Visible = false;
        }
        private string GetCustomer()
        {
            var errRes = string.Empty;
            try
            {
                (var dt, var err) = clsGetMethods.GetCustomer();
                errRes = err;
                if (string.IsNullOrWhiteSpace(errRes))
                    GridFill(dt);
            }
            catch (Exception ex)
            {
                errRes = ex.Message;
            }
            return errRes;
        }

        private string GetCustomer(ClassControls cls)
        {
            var errRes = string.Empty;
            try
            {
                (var dt, var err) = clsGetMethods.GetCustomer(cls);
                errRes = err;
                if (string.IsNullOrWhiteSpace(errRes))
                    GridFill(dt);
            }
            catch (Exception ex)
            {
                errRes = ex.Message;
            }
            return errRes;
        }
        private (string res, string err) GetCustomerFullNameById(int custId)
        {
            var errRes = string.Empty;
            var resOut = string.Empty;
            try
            {
                (var dt, var err) = clsGetMethods.GetCustomerFullNameById(custId);
                errRes = err;
                if (string.IsNullOrWhiteSpace(errRes))
                    resOut = dt;
            }
            catch (Exception ex)
            {
                errRes = ex.Message;
            }
            return (resOut, errRes);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (maskedBirthDate.Culture.Name == "en-US")
                maskedBirthDate.Culture = CultureInfo.GetCultureInfo("en-GB");
            else
                maskedBirthDate.Culture = CultureInfo.GetCultureInfo("en-US");
            var err = GetGender();
            if (!string.IsNullOrWhiteSpace(err))
            {
                MessageBox.Show(err);
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var err = GetCustomer();
            if (!string.IsNullOrWhiteSpace(err))
            {
                MessageBox.Show(err);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dg = MessageBox.Show("Məlumatin daxil edilməsinə əminsinizmi?", "Diqqət!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
                return;
            Cursor.Current = Cursors.WaitCursor;
            var clsControls = new ClassControls
            {
                name = txtName.Text,
                surname = txtSurname.Text.Trim(),
                birthPlace = txtBirthPlace.Text.Trim(),
                birthDate = maskedBirthDate.Text.Replace(",", "."),
                gender = cmbGender.SelectedIndex != -1 ? int.Parse(cmbGender.SelectedValue.ToString()) : cmbGender.SelectedIndex,
                docNo = txtDocNo.Text.Trim(),
                finCode = txtFinCode.Text.Trim(),
                phoneNumber = txtPhoneNumber.Text.Trim(),
                email = txtEmail.Text.Trim()
            };
            (var res, var custIdn, var err) = clsPostMethods.FileOper(clsControls);
            if (!string.IsNullOrWhiteSpace(err))
            {
                MessageBox.Show(err, "Diqqət!");
                return;
            }
            if (res != "4")
            {
                MessageBox.Show(res, "Diqqət!");
                return;
            }
            err = GetCustomer();
            if (!string.IsNullOrWhiteSpace(err))
            {
                MessageBox.Show(err);
                return;
            }
            MessageBox.Show($"Əməliyyat yerinə yetirildi.{(char)13}{(char)10}{custIdn} qeydiyyatlı müştəri əlavə edildi.", "Diqqət!");
            btnClear_Click(sender, e);
            Cursor.Current = Cursors.Default;
        }
        private void ControlClear(Control[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] is TextBox)
                    ((TextBox)array[i]).Clear();
                if (array[i] is MaskedTextBox)
                    ((MaskedTextBox)array[i]).Clear();
                if (array[i] is ComboBox)
                    ((ComboBox)array[i]).SelectedIndex = -1;
            }
        }
        private bool CheckControlsEmpty(Control[] cl)
        {
            var res = false;
            for (int i = 0; i < cl.Length; i++)
            {
                if (cl[i] is TextBox && !string.IsNullOrWhiteSpace(((TextBox)cl[i]).Text))
                {
                    res = true;
                    break;
                }
                if (cl[i] is MaskedTextBox && ((MaskedTextBox)cl[i]).Text != "  .  .")
                {
                    res = true;
                    break;
                }
                if (cl[i] is ComboBox && ((ComboBox)cl[i]).SelectedIndex != -1)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ControlClear(new Control[] { txtCustIdn, txtName, txtSurname, txtBirthPlace, maskedBirthDate, cmbGender, txtDocNo, txtFinCode, txtPhoneNumber, txtEmail });
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçim edilməyib", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var dg = MessageBox.Show("Məlumatin yenilənməsinə əminsinizmi?", "Diqqət!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
                return;
            Cursor.Current = Cursors.WaitCursor;
            var clsControls = new ClassControls
            {
                custIdn = int.Parse(dgvCustomers.Rows[dgvCustomers.CurrentRow.Index].Cells["IDN"].Value.ToString()),
                name = txtName.Text,
                surname = txtSurname.Text.Trim(),
                birthPlace = txtBirthPlace.Text.Trim(),
                birthDate = maskedBirthDate.Text.Replace(",", "."),
                gender = cmbGender.SelectedIndex != -1 ? int.Parse(cmbGender.SelectedValue.ToString()) : cmbGender.SelectedIndex,
                docNo = txtDocNo.Text.Trim(),
                finCode = txtFinCode.Text.Trim(),
                phoneNumber = txtPhoneNumber.Text.Trim(),
                email = txtEmail.Text.Trim()
            };
            (var res, var custIdn, var err) = clsPostMethods.FileOper(clsControls);
            if (!string.IsNullOrWhiteSpace(err))
            {
                MessageBox.Show(err, "Diqqət!");
                return;
            }
            if (res != "4")
            {
                MessageBox.Show(res, "Diqqət!");
                return;
            }
            err = GetCustomer();
            if (!string.IsNullOrWhiteSpace(err))
            {
                MessageBox.Show(err);
                return;
            }
            MessageBox.Show($"Əməliyyat yerinə yetirildi.{(char)13}{(char)10}{custIdn} qeydiyyatlı müştəri məlumatları yeniləndi.", "Diqqət!");
            btnClear_Click(sender, e);
            Cursor.Current = Cursors.Default;
        }

        private void dgvCustomers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCustomers.Rows.Count == 0)
                return;
            txtName.Text = dgvCustomers.Rows[dgvCustomers.CurrentRow.Index].Cells["NAME"].Value.ToString();
            txtSurname.Text = dgvCustomers.Rows[dgvCustomers.CurrentRow.Index].Cells["SURNAME"].Value.ToString();
            txtBirthPlace.Text = dgvCustomers.Rows[dgvCustomers.CurrentRow.Index].Cells["BIRTH_PLACE"].Value.ToString();
            maskedBirthDate.Text = dgvCustomers.Rows[dgvCustomers.CurrentRow.Index].Cells["BIRTH_DATE"].Value.ToString();
            cmbGender.SelectedValue = dgvCustomers.Rows[dgvCustomers.CurrentRow.Index].Cells["GENDER"].Value.ToString();
            txtDocNo.Text = dgvCustomers.Rows[dgvCustomers.CurrentRow.Index].Cells["DOC_NO"].Value.ToString();
            txtFinCode.Text = dgvCustomers.Rows[dgvCustomers.CurrentRow.Index].Cells["FIN_CODE"].Value.ToString();
            txtPhoneNumber.Text = dgvCustomers.Rows[dgvCustomers.CurrentRow.Index].Cells["PHONE_NUMBER"].Value.ToString();
            txtEmail.Text = dgvCustomers.Rows[dgvCustomers.CurrentRow.Index].Cells["EMAIL"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seçim edilməyib", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var dg = MessageBox.Show("Məlumatin silinməsinə əminsinizmi?", "Diqqət!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
                return;
            Cursor.Current = Cursors.WaitCursor;
            var idn = int.Parse(dgvCustomers.Rows[dgvCustomers.CurrentRow.Index].Cells["IDN"].Value.ToString());

            (var res, var err) = clsPostMethods.FileDelete(idn);
            if (!string.IsNullOrWhiteSpace(err))
            {
                MessageBox.Show(err, "Diqqət!");
                return;
            }
            if (res != "4")
            {
                MessageBox.Show(res, "Diqqət!");
                return;
            }
            err = GetCustomer();
            if (!string.IsNullOrWhiteSpace(err))
            {
                MessageBox.Show(err);
                return;
            }
            MessageBox.Show($"Əməliyyat yerinə yetirildi.{(char)13}{(char)10}{idn} qeydiyyatlı müştəri məlumatları silindi.", "Diqqət!");
            btnClear_Click(sender, e);
            Cursor.Current = Cursors.Default;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!CheckControlsEmpty(new Control[] { txtCustIdn, txtName, txtSurname, txtBirthPlace, maskedBirthDate, cmbGender, txtDocNo, txtFinCode, txtPhoneNumber, txtEmail }))
            {
                MessageBox.Show("Axtarış üçün parametr daxil edilməlidir.", "Diqqət!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var clsControls = new ClassControls
            {
                custIdn = !string.IsNullOrWhiteSpace(txtCustIdn.Text) ? int.Parse(txtCustIdn.Text.Trim()) : 0,
                name = txtName.Text,
                surname = txtSurname.Text.Trim(),
                birthPlace = txtBirthPlace.Text.Trim(),
                birthDate = maskedBirthDate.Text.Replace(",", "."),
                gender = cmbGender.SelectedIndex != -1 ? int.Parse(cmbGender.SelectedValue.ToString()) : cmbGender.SelectedIndex,
                docNo = txtDocNo.Text.Trim(),
                finCode = txtFinCode.Text.Trim(),
                phoneNumber = txtPhoneNumber.Text.Trim(),
                email = txtEmail.Text.Trim()
            };
            var err = GetCustomer(clsControls);
            if (!string.IsNullOrWhiteSpace(err))
            {
                MessageBox.Show(err);
                return;
            }
        }

        private void txtCustIdn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //Yalniz reqem daxil edilir
        }

        private void btnCustomerFullNameById_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustIdn.Text))
            {
                MessageBox.Show("Müştəri qeydiyyatını daxil edin", "Diqqət!");
                txtCustIdn.Focus();
                return;
            }
            var custId = int.Parse(txtCustIdn.Text.Trim());
            (var res, var err) = GetCustomerFullNameById(custId);
            if (!string.IsNullOrWhiteSpace(err))
                return;
            lblCustFullNameById.Text = $"Müştəri tam ad: {res}";
        }
    }
}
