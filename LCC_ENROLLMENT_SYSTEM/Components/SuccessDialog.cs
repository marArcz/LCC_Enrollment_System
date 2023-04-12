using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC_ENROLLMENT_SYSTEM.Components;

public partial class SuccessDialog : Form
{
    public string Message { get; set; } = String.Empty;
    private int borderRadius = 20;
    private int borderSize = 1;
    private Color borderColor = Color.LightGray;

    interface OnConfirmListener
    {
        void OnConfirm();
    }

    private OnConfirmListener onConfirm { get; set; }
    public int BorderRadius { get => borderRadius; set => borderRadius = value; }
    public Color BorderColor { get => borderColor; set => borderColor = value; }
    public int BorderSize { get => borderSize; set => borderSize = value; }

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

    public static void ShowMesage(string message)
    {
        new SuccessDialog().ShowSuccess(message);
        /*lblMessage.Text = message;
        this.ShowDialog();*/
    }

    private void lblMessage_Click(object sender, EventArgs e)
    {

    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var pevent = e;
        Rectangle rectSurface = this.ClientRectangle;
        Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);
        int smoothSize = 2;
        if (BorderSize > 0)
            smoothSize = BorderSize;

        if (borderRadius > 2) //Rounded button
        {
            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - BorderSize))
            using (Pen penSurface = new Pen(this.BackColor, smoothSize))
            using (Pen penBorder = new Pen(BorderColor, BorderSize))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                //Button surface
                this.Region = new Region(pathSurface);
                //Draw surface border for HD result
                pevent.Graphics.DrawPath(penSurface, pathSurface);

                //Button border                    
                if (BorderSize >= 1)
                    //Draw control border
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
        }
        else //Normal button
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.None;
            //Button surface
            this.Region = new Region(rectSurface);
            //Button border
            if (borderSize >= 1)
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }
    }

    private GraphicsPath GetFigurePath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        float curveSize = radius * 2F;

        path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();
        return path;
    }

    private void mainPanel_Paint(object sender, PaintEventArgs e)
    {

    }
}
