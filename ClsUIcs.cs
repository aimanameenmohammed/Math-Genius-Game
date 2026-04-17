using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMathGame
{
    internal class ClsUIcs
    {
        public void ApplyQuestionAreaStyle(Control ctrl, int radius)
        {
            // 1. إعداد الألوان (خلفية داكنة جداً)
            ctrl.BackColor = Color.FromArgb(25, 25, 25);
            ctrl.ForeColor = Color.White;

            // 2. قص الحواف لتصبح دائرية
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            ctrl.Region = new Region(path);

            // 3. رسم الإطار النحيف والتدرج اللوني (مثل الصورة)
            ctrl.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // رسم تدرج لوني خفيف للخلفية (إضاءة من الأعلى)
                //using (LinearGradientBrush lgb = new LinearGradientBrush(ctrl.ClientRectangle,
                //       Color.FromArgb(40, 40, 40), Color.FromArgb(20, 20, 20), LinearGradientMode.Vertical))
                //{
                //    e.Graphics.FillPath(lgb, path);
                //}

                // رسم الإطار (Border) لونه فضي شفاف خفيف جداً
                using (Pen pen = new Pen(Color.FromArgb(50, 200, 200, 200), 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }
        public void SetRoundedRegion(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            // رسم الأركان الأربعة
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        public void CustomizeProgressBar(ProgressBar pBar)
        {
            // تفعيل الرسم اليدوي للشريط
            pBar.Style = ProgressBarStyle.Continuous;

            // ضبط حواف الشريط لتكون دائرية قليلاً
            int radius = pBar.Height / 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(pBar.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pBar.Width - radius, pBar.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pBar.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pBar.Region = new Region(path);

            // إضافة تأثير الرسم المخصص (اللون الذهبي المتوهج)
            pBar.Paint += (s, e) =>
            {
                float percent = (float)pBar.Value / pBar.Maximum;
                int width = (int)(pBar.Width * percent);

                if (width > 0)
                {
                    // إنشاء تدرج لوني ذهبي (مثل الصورة)
                    using (LinearGradientBrush brush = new LinearGradientBrush(
                        new Rectangle(0, 0, width, pBar.Height),
                        Color.FromArgb(255, 215, 100), // ذهبي فاتح
                        Color.FromArgb(190, 155, 85),  // ذهبي داكن
                        LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillRectangle(brush, 0, 0, width, pBar.Height);
                    }

                    // إضافة لمعة خفيفة (توهج)
                    using (Pen glowPen = new Pen(Color.FromArgb(100, 255, 255, 255), 1))
                    {
                        e.Graphics.DrawLine(glowPen, 0, 1, width, 1);
                    }
                }
            };
        }
        public void ApplyNumericStyle(NumericUpDown nm)
        {
            // 1. الألوان الأساسية
            nm.BackColor = Color.FromArgb(25, 25, 25); // خلفية داكنة جداً
            nm.ForeColor = Color.Gainsboro;           // لون الرقم
            nm.BorderStyle = BorderStyle.None;        // إخفاء الإطار القديم

            // 2. انحناء الحواف
            int radius = 15;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(nm.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(nm.Width - radius, nm.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, nm.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            nm.Region = new Region(path);

            // 3. رسم الإطار الفضي النحيف حولها
            nm.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.FromArgb(70, 200, 200, 200), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }


        public void ApplyContainerStyle(Panel pnl,bool noresult=true)
        {
            // 1. إعدادات الألوان (الأسود العميق)
            int radius = 25; // درجة الانحناء

            // 2. قص الحواف لتكون دائرية
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 170, 90);
            path.AddArc(pnl.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(pnl.Width - radius, pnl.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, pnl.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnl.Region = new Region(path);

            // 3. رسم الإطار الاحترافي (Border)
            pnl.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // رسم إطار نحيف جداً بلون رمادي شفاف (يعطي مظهر الـ Premium)
                using (Pen pen = new Pen(Color.FromArgb(20, 20, 200, 200), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
                if (noresult)
                {
                    pnl.BackColor = Color.FromArgb(15, 15, 15);

                    // إضافة لمعة علوية خفيفة جداً لتشبه الزجاج
                    using (LinearGradientBrush lgb = new LinearGradientBrush(
                        new Rectangle(0, 0, pnl.Width, 20),
                        Color.FromArgb(10, 255, 255, 255),
                        Color.Transparent,
                        LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillPath(lgb, path);
                    }
                }
            };
        }
    }
}
