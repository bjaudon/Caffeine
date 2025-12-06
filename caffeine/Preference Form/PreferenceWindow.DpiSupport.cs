using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Caffeine
{
    public partial class PreferenceWindow : Form
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            // Ensure the form uses DPI autoscaling even if Designer hasn't set it.
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        protected override void OnDpiChanged(DpiChangedEventArgs e)
        {
            base.OnDpiChanged(e);

            // Compute relative scale factor between old and new DPI.
            float factor = e.DeviceDpiNew / (float)Math.Max(1, e.DeviceDpiOld);
            if (Math.Abs(factor - 1f) < 0.01f) return;

            // Let WinForms scale layout first
            this.Scale(new SizeF(factor, factor));

            // Then adjust fonts explicitly to keep sizes consistent
            ScaleFontsRecursive(this, factor);

            // Update ToolStrip image sizes and fonts found inside the form
            foreach (var ts in CollectToolStrips(this))
            {
                ts.ImageScalingSize = new Size(
                    Math.Max(1, (int)Math.Round(ts.ImageScalingSize.Width * factor)),
                    Math.Max(1, (int)Math.Round(ts.ImageScalingSize.Height * factor))
                );
                ts.Font = new Font(ts.Font.FontFamily, ts.Font.Size * factor, ts.Font.Style);
            }
        }

        private void ScaleFontsRecursive(Control parent, float factor)
        {
            if (parent.Font != null)
            {
                parent.Font = new Font(parent.Font.FontFamily, parent.Font.Size * factor, parent.Font.Style);
            }

            foreach (Control child in parent.Controls)
            {
                ScaleFontsRecursive(child, factor);
            }
        }

        private static IEnumerable<ToolStrip> CollectToolStrips(Control root)
        {
            var list = new List<ToolStrip>();
            if (root is ToolStrip tsRoot) list.Add(tsRoot);

            foreach (Control c in root.Controls)
            {
                list.AddRange(CollectToolStrips(c));
            }

            return list.Distinct();
        }
    }
}