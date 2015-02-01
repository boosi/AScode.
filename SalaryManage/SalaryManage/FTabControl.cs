using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryManage
{
    public class FTabControl : TabControl
    {
        private System.ComponentModel.Container components = null;
        private static Color BackColor = Color.FromArgb(227, 237, 251);
        private static Color ButtonColor;
        private static Color ButtonHighlightColor;
        private static Color BorderColor = Color.Black;
        public bool UserChangeTab = true;

        public FTabControl()
        {
            InitializeComponent();
            SetDafaultStyle();
            SetStyle(ControlStyles.UserPaint, true);
        }

        #region Component Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion

        public void SetDafaultStyle()
        {
            Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            ButtonColor = Color.FromArgb(184, 210, 250);
            ButtonHighlightColor = Color.FromArgb(144, 187, 252);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(BackColor), e.ClipRectangle);
            for (int i = 0; i < this.TabCount; i++)
            {
                DrawItem(e.Graphics, i);
            }
        }

        protected void DrawItem(Graphics g, int index)
        {
            Rectangle r = GetTabRect(index);
            r.Inflate(-2, -2);
            if (SelectedIndex == index)
                g.FillRectangle(new SolidBrush(ButtonHighlightColor), r);
            else
                g.FillRectangle(new SolidBrush(ButtonColor), r);
            g.DrawRectangle(new Pen(new SolidBrush(BorderColor)), r);
            r.Inflate(-3, -3);
            g.DrawString(TabPages[index].Text, Font, new SolidBrush(BorderColor), r);
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == 513 && !this.UserChangeTab)
            {
                return; //trap WM_LBUTTONDOWN 
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == System.Windows.Forms.Keys.Tab && !this.UserChangeTab)
            {
                return; //trap CTRL+TAB and CTRL+SHIFT+TAB 
            }
            else
            {
                base.OnKeyDown(e);
            }
        }
    }
}
