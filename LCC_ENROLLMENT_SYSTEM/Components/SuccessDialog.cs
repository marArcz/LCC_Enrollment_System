using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC_ENROLLMENT_SYSTEM.Components;

public partial class SuccessDialog : Form
{
    public string Message { get; set; } = String.Empty;
    interface OnConfirmListener
    {
        void OnConfirm();
    }

    private OnConfirmListener onConfirm { get; set; }
    
    public SuccessDialog()
    {
        InitializeComponent();

    }

    private void SuccessDialog_Load(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
    public void ShowSuccess(string message, IWin32Window owner)
    {
        lblMessage.Text = message;
        this.ShowDialog(owner);
    }
    public void ShowSuccess(string message)
    {
        lblMessage.Text = message;
        this.ShowDialog();
    }
}
