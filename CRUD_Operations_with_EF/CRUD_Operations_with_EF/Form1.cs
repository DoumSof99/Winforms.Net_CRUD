using CRUD_Operations_with_EF.Services;

namespace CRUD_Operations_with_EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FormHelper.Review(grvPerson);
            FormHelper.Remove(ctrlIdTxt, ctrlFirstNameTxt, ctrlLastNameTxt, ctrlAgeTxt);
            FormHelper.Unenabled(ctrlFirstNameTxt, ctrlLastNameTxt, ctrlAgeTxt, ctrlSave);
        }

        private void grvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ctrlIdTxt.Text = grvPerson.CurrentRow.Cells[0].Value.ToString();
            ctrlFirstNameTxt.Text = grvPerson.CurrentRow.Cells[1].Value.ToString();
            ctrlLastNameTxt.Text = grvPerson.CurrentRow.Cells[2].Value.ToString();
            ctrlAgeTxt.Text = grvPerson.CurrentRow.Cells[3].Value.ToString();
        }

        private void ctrlAdd_Click(object sender, EventArgs e)
        {
            FormHelper.Remove(ctrlIdTxt, ctrlFirstNameTxt, ctrlLastNameTxt, ctrlAgeTxt);
            FormHelper.Enabled(ctrlFirstNameTxt, ctrlLastNameTxt, ctrlAgeTxt, ctrlSave);
        }

        private void ctrlEdit_Click(object sender, EventArgs e)
        {
            FormHelper.Enabled(ctrlFirstNameTxt, ctrlLastNameTxt, ctrlAgeTxt, ctrlSave);
        }

        private void ctrlDelete_Click(object sender, EventArgs e)
        {
            Repository repository = new Repository();
            repository.Delete(Convert.ToInt32(grvPerson.CurrentRow.Cells[0].Value));
            FormHelper.Review(grvPerson);
        }

        private void ctrlSave_Click(object sender, EventArgs e)
        {
            Repository repository = new Repository();
            try
            {
                if (ctrlIdTxt.Text == string.Empty)
                {
                    repository.Create(ctrlFirstNameTxt.Text, ctrlLastNameTxt.Text, Convert.ToInt16(ctrlAgeTxt.Text));
                }
                else
                {
                    repository.Update(Convert.ToInt32(ctrlIdTxt.Text), ctrlFirstNameTxt.Text, ctrlLastNameTxt.Text, Convert.ToInt32(ctrlAgeTxt.Text));
                }

                FormHelper.Review(grvPerson);
                FormHelper.Remove(ctrlIdTxt, ctrlFirstNameTxt, ctrlLastNameTxt, ctrlAgeTxt);
                FormHelper.Unenabled(ctrlFirstNameTxt, ctrlLastNameTxt, ctrlAgeTxt, ctrlSave);
            }
            catch(FormatException)
            {
                MessageBox.Show("The age should be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormHelper.Remove(ctrlIdTxt, ctrlFirstNameTxt, ctrlLastNameTxt, ctrlAgeTxt);
                FormHelper.Unenabled(ctrlFirstNameTxt, ctrlLastNameTxt, ctrlAgeTxt, ctrlSave);
            }
        }
    }
}