using System.Drawing;
using System.Windows.Forms;

namespace PluralSightDownloader.WinForms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(new Pen(Color.Black), 0, Height / 2, Width, Height / 2);
        }
    }
}
