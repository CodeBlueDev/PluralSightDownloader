namespace CodeBlueDev.PluralSightDownloader.WinForms.Controls
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class FlowLayoutLabel : Label
    {
        public event EventHandler<CancelEventArgs> BeforeMouseClick;

        private bool isSelected;

        public FlowLayoutLabel()
        {
            this.BackColor = Color.Transparent;
            this.UnselectedBackColor = Color.Transparent;
            this.UnselectedBorderColor = Color.Transparent;
            this.UnselectedFont = new Font(this.Font, FontStyle.Regular);
            this.SelectedBackColor = Color.LightSteelBlue;
            this.SelectedBorderColor = Color.SteelBlue;
            this.SelectedFont = new Font(this.Font, FontStyle.Bold);
        }

        private new Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
            }
        }

        private new Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
            }
        }

        public Color UnselectedBackColor { get; set; }

        public Color UnselectedBorderColor { get; set; }

        public Font UnselectedFont { get; set; }

        public Color SelectedBackColor { get; set; }

        public Color SelectedBorderColor { get; set; }

        public Font SelectedFont { get; set; }

        public bool IsSelected {
            get
            {
                return this.isSelected;
            }
            set
            {
                this.isSelected = value;

                if (value)
                {
                    this.BackColor = this.SelectedBackColor;
                    this.Font = this.SelectedFont;
                }
                else
                {
                    this.BackColor = this.UnselectedBackColor;
                    this.Font = this.UnselectedFont;
                }

                this.Invalidate();
            }
        }

        protected override void OnMouseEnter(EventArgs eventArgs)
        {
            this.Cursor = Cursors.Hand;

            this.Invalidate();

            base.OnMouseEnter(eventArgs);
        }

        protected override void OnMouseLeave(EventArgs eventArgs)
        {
            this.Cursor = Cursors.Arrow;

            this.Invalidate();

            base.OnMouseLeave(eventArgs);
        }

        protected override void OnClick(EventArgs eventArgs)
        {
            EventHandler<CancelEventArgs> beforeMouseClickEventHandler = 
                this.BeforeMouseClick;

            if (beforeMouseClickEventHandler != null)
            {
                CancelEventArgs cancelEventArgs = new CancelEventArgs();
                beforeMouseClickEventHandler(this, cancelEventArgs);

                if (cancelEventArgs.Cancel)
                {
                    return;
                }
            }

            base.OnClick(eventArgs);
        }

        protected override void OnPaint(PaintEventArgs paintEventArgs)
        {
            base.OnPaint(paintEventArgs);
            ControlPaint.DrawBorder(
                paintEventArgs.Graphics,
                this.DisplayRectangle,
                this.isSelected 
                    ? this.SelectedBorderColor 
                    : this.UnselectedBorderColor,
                ButtonBorderStyle.Solid);
        }

        public new void Select()
        {
            if (this.IsSelected)
            {
                return;
            }

            base.Select();
            this.IsSelected = true;
        }

        public void Deselect()
        {
            this.IsSelected = false;
        }
    }
}
