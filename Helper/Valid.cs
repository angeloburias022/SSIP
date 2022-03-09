using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.Helper
{
    public class Valid
    {
        public static bool ValidateFields(Object obj)
        {
            var detailsValidCon = new ValidationContext(obj, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(obj, detailsValidCon, errors, true))
            {
                foreach (ValidationResult val in errors)
                {
                    MessageBox.Show(val.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

    }
}
