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

    }
}