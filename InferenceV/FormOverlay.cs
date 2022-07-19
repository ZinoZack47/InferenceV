using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yolov5Net.Scorer;

namespace InferenceV
{
    public partial class FormOverlay : Form
    {
        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
       /* [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRectangle);
        public struct RECT
        {
            public int left, top, right, buttom;
        }
        RECT rect;
        public const string WinName = "";
        IntPtr hWnd = FindWindow(null, WinName);
*/
        public FormOverlay()
        {
            InitializeComponent();
        }

        private void FormOverlay_Load(object sender, EventArgs a)
        {
            BackColor = Color.WhiteSmoke;
            TransparencyKey = Color.WhiteSmoke;
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
            var initialStyle = GetWindowLong(Handle, -20);
            SetWindowLong(Handle, -20, initialStyle | 0x80000 | 0x20);

            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(RefreshPredictions);
            timer.Start();
            /*GetWindowRect(hWnd, out rect);
            Size = new Size(rect.right - rect.left, rect.buttom - rect.top);
            Top = rect.top;
            Left = rect.left;*/
        }

        public void RefreshPredictions(object sender, EventArgs e)
        {
            Refresh();
        }
        private void FormOverlay_Paint(object sender, PaintEventArgs e)
        {
            var predictions = Predictor.GetPredictions();
            var graphics = e.Graphics;
            foreach (var prediction in predictions)
            {
                double score = Math.Round(prediction.Score, 2);

                graphics.DrawRectangles(new Pen(prediction.Label.Color, 3),
                    new[] { prediction.Rectangle });

                var (x, y) = (prediction.Rectangle.X - 3, prediction.Rectangle.Y - 23);

                graphics.DrawString($"{prediction.Label.Name} ({score})",
                    new Font("Arial", 16, GraphicsUnit.Pixel), new SolidBrush(prediction.Label.Color),
                    new PointF(x, y));
            }
        }
    }
}
