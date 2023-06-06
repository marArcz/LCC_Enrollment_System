using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCC_ENROLLMENT_SYSTEM
{
    internal static class AsyncDialog
    {
        public static async Task<DialogResult> ShowDialogAsync(this Form @this)
        {
            await Task.Yield();
            if (@this.IsDisposed)
                return DialogResult.Cancel;
            return @this.ShowDialog();
        }
    }
}
