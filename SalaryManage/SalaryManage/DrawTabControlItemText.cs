using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SalaryManage
{
    /// <summary>
    /// 自定义 TabControl 的文字显示、注意:只实用于TabControl.Alignment = Right/Left.
    /// </summary>
    /// <remarks>注意：只实用于TabControl.Alignment = Right/Left.</remarks>
    class DrawTabControlItemText
    {
        static Graphics g;
        static StringFormat strFormat;
        static Font font;
        static SolidBrush brush;
        static RectangleF tabTextArea;

        public enum TabItemType
        {
            Horizontal, //  横
            Vertical,   //  竖
        }

        /// <summary>
        /// 绘画Tab控件的文字.
        /// </summary>
        public static void OwnerDrawTabItem(System.Windows.Forms.TabControl tab)
        {
            tab.DrawMode = TabDrawMode.OwnerDrawFixed;
            tab.DrawItem += new DrawItemEventHandler(tab_DrawItem);
        }

        /// <summary>
        /// 具体绘画方法.
        /// </summary>
        private static void tab_DrawItem(object sender, DrawItemEventArgs e)
        {
            g = e.Graphics;
            font = ((System.Windows.Forms.TabControl)sender).Font;
            brush = new SolidBrush(((System.Windows.Forms.TabControl)(sender)).TabPages[e.Index].ForeColor);
            strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;
            tabTextArea = ((System.Windows.Forms.TabControl)sender).GetTabRect(e.Index);

            g.DrawString(((System.Windows.Forms.TabControl)(sender)).TabPages[e.Index].Text, font, brush, tabTextArea, strFormat);
        }


        //调用：DrawTabControlItemText.OwnerDrawTabItem(TabControl);
    }
}
