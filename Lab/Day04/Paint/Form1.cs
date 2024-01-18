using TransFlower.Drawing;

namespace Paint;

public partial class Form1 : Form
{
    TransFlower.Drawing.Point startpoint;
    TransFlower.Drawing.Point endpoint;

    public Form1()
    {
        InitializeComponent();
        //Connect with the paint event of the Picture box with the  Picture Handler Event;
        Paint += new System.Windows.Forms.PaintEventHandler(OnPaint);
        MouseUp += new System.Windows.Forms.MouseEventHandler(OnMouseUp);
        MouseDown += new System.Windows.Forms.MouseEventHandler(OnMouseDown);
    }

    //Event Handlers

    public void OnPaint(Object sender, PaintEventArgs e)
    {

    }
    public void OnMouseUp(Object sender, MouseEventArgs e)
    {
        endpoint = new TransFlower.Drawing.Point(e.X, e.Y);
        Line l = new Line(startpoint, endpoint, "red", 4);
        Pen pen = new Pen(Color.FromArgb(255, 255, 0, 0));
        Graphics g = this.CreateGraphics();
        g.DrawLine(pen, l.StartPoint.X, l.StartPoint.Y, l.EndPoint.X, l.EndPoint.Y);
    }
    public void OnMouseDown(Object sender, MouseEventArgs e)
    {
        startpoint = new TransFlower.Drawing.Point(e.X, e.Y);
    }
}
