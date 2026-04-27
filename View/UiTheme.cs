using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Calendar.View
{
    internal static class UiTheme
    {
        private static readonly Font ModernFont = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
        private static readonly Color PrimaryButtonColor = Color.FromArgb(85, 155, 230);
        private static readonly Color DangerButtonColor = Color.FromArgb(232, 125, 112);
        private static readonly Color NeutralButtonColor = Color.FromArgb(132, 152, 178);
        private static readonly Color HeaderColor = Color.FromArgb(126, 191, 247);

        public static void ApplyFormTheme(Form form)
        {
            form.BackColor = Color.FromArgb(248, 250, 252);
            form.Font = ModernFont;
            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                var button = control as Button;
                if (button != null)
                {
                    StyleButton(button);
                }

                var label = control as Label;
                if (label != null)
                {
                    label.Font = new Font(label.Font, FontStyle.Bold);
                }

                var grid = control as DataGridView;
                if (grid != null)
                {
                    StyleGrid(grid);
                }

                var list = control as ListView;
                if (list != null)
                {
                    StyleListView(list);
                }

                if (control.HasChildren)
                {
                    StyleControls(control.Controls);
                }
            }
        }

        private static void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.ForeColor = Color.White;
            button.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button.UseVisualStyleBackColor = false;

            var text = (button.Text ?? string.Empty).ToLowerInvariant();
            if (text.Contains("thoát") || text.Contains("đóng") || text.Contains("hủy") || text.Contains("huỷ"))
            {
                ApplyRoundedButton(button, NeutralButtonColor);
                return;
            }

            if (text.Contains("xóa") || text.Contains("xoá") || text.Contains("xóa"))
            {
                ApplyRoundedButton(button, DangerButtonColor);
                return;
            }

            ApplyRoundedButton(button, PrimaryButtonColor);
        }

        private static void ApplyRoundedButton(Button button, Color backColor)
        {
            button.BackColor = backColor;
            button.FlatAppearance.MouseOverBackColor = ControlPaint.Light(backColor, 0.08f);
            button.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(backColor, 0.06f);

            button.Paint -= Button_Paint;
            button.Paint += Button_Paint;
            button.Resize -= Button_Resize;
            button.Resize += Button_Resize;
        }

        private static void Button_Resize(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.Invalidate();
            }
        }

        private static void Button_Paint(object sender, PaintEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            var surfaceRect = button.ClientRectangle;
            var faceRect = new Rectangle(0, 0, button.Width - 1, button.Height - 1);

            using (var backBrush = new SolidBrush(button.Parent != null ? button.Parent.BackColor : Color.White))
            {
                e.Graphics.FillRectangle(backBrush, surfaceRect);
            }

            using (var facePath = CreateRoundedRectPath(faceRect, 12))
            using (var faceBrush = new SolidBrush(button.BackColor))
            {
                e.Graphics.FillPath(faceBrush, facePath);
            }

            TextRenderer.DrawText(e.Graphics, button.Text, button.Font, faceRect, button.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private static GraphicsPath CreateRoundedRectPath(Rectangle rectangle, int radius)
        {
            var path = new GraphicsPath();
            var diameter = radius * 2;
            var arc = new Rectangle(rectangle.Location, new Size(diameter, diameter));

            path.AddArc(arc, 180, 90);
            arc.X = rectangle.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rectangle.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rectangle.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }

        private static void StyleGrid(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = HeaderColor;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(17, 24, 39);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = HeaderColor;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(17, 24, 39);
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.DefaultCellStyle.Font = ModernFont;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 247, 255);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 41, 55);
            grid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 247, 255);
            grid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(31, 41, 55);
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;

            grid.DataBindingComplete -= Grid_DataBindingComplete;
            grid.DataBindingComplete += Grid_DataBindingComplete;
        }

        private static void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid == null || grid.Columns.Count == 0)
            {
                return;
            }

            grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private static void StyleListView(ListView listView)
        {
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView.Font = ModernFont;

            listView.SizeChanged -= ListView_SizeChanged;
            listView.SizeChanged += ListView_SizeChanged;

            if (listView.View == global::System.Windows.Forms.View.Details)
            {
                listView.OwnerDraw = true;
                listView.DrawColumnHeader -= ListView_DrawColumnHeader;
                listView.DrawColumnHeader += ListView_DrawColumnHeader;
                listView.DrawItem -= ListView_DrawItem;
                listView.DrawItem += ListView_DrawItem;
                listView.DrawSubItem -= ListView_DrawSubItem;
                listView.DrawSubItem += ListView_DrawSubItem;
            }

            ResizeSingleColumnListView(listView);
        }

        private static void ListView_SizeChanged(object sender, EventArgs e)
        {
            var listView = sender as ListView;
            if (listView == null)
            {
                return;
            }

            ResizeSingleColumnListView(listView);
        }

        private static void ResizeSingleColumnListView(ListView listView)
        {
            if (listView.Columns.Count != 1)
            {
                return;
            }

            var width = listView.ClientSize.Width - 4;
            if (width > 0)
            {
                listView.Columns[0].Width = width;
            }
        }

        private static void ListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var backBrush = new SolidBrush(HeaderColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            TextRenderer.DrawText(e.Graphics, e.Header.Text, new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point), e.Bounds, Color.FromArgb(17, 24, 39), TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }

        private static void ListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            var listView = sender as ListView;
            if (listView != null && listView.View != global::System.Windows.Forms.View.Details)
            {
                e.DrawDefault = true;
            }
        }

        private static void ListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            var backColor = (e.ItemState & ListViewItemStates.Selected) != 0
                ? Color.FromArgb(225, 240, 252)
                : Color.White;

            using (var backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            TextRenderer.DrawText(e.Graphics, e.SubItem.Text, e.SubItem.Font, e.Bounds, Color.Black, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }
    }
}
