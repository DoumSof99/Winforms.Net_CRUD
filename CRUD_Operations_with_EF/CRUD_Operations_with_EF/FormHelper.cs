using CRUD_Operations_with_EF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operations_with_EF
{
    public  class FormHelper
    {
        public static void Review(DataGridView grv)
        {
            Repository repository = new Repository();
            grv.DataSource = repository.Read();
        }

        public static void Remove(Label id, TextBox firstName, TextBox lastName, TextBox age)
        {
            id.Text = firstName.Text = lastName.Text = age.Text = string.Empty;
        }

        public static void Enabled(TextBox firstName, TextBox lastName, TextBox age, Button save)
        {
            firstName.Enabled = lastName.Enabled = age.Enabled = save.Enabled = true;
        }

        public static void Unenabled(TextBox firstName, TextBox lastName, TextBox age, Button save)
        {
            firstName.Enabled = lastName.Enabled = age.Enabled = save.Enabled = false;
        }
    }
}
