using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        const int ValueViewSize = 30;

        public Form1() {
            InitializeComponent();
            linearScaleComponent1.BeginUpdate();
            linearScaleComponent1.MinValue = trackBar1.Value - ValueViewSize;
            linearScaleComponent1.MaxValue = trackBar1.Value + ValueViewSize;
            linearScaleComponent1.AutoRescaling = true;
            linearScaleComponent1.RescalingBestValues = false;
            linearScaleComponent1.RescalingThresholdMin = 0.5f;
            linearScaleComponent1.RescalingThresholdMax = 0.5f;
            linearScaleComponent1.Value = trackBar1.Value;
            linearScaleComponent1.CustomRescaling += linearScaleComponent1_CustomRescaling;
            linearScaleComponent1.CustomTickmarkText += linearScaleComponent1_CustomTickmarkText;
            linearScaleComponent1.EndUpdate();
        }
        void linearScaleComponent1_CustomTickmarkText(DevExpress.XtraGauges.Core.Model.CustomTickmarkTextEventArgs ea) {
            int overhead = ((int)ea.Value) % (trackBar1.Maximum - trackBar1.Minimum);
            if(overhead >= 0)
                ea.Result = (trackBar1.Minimum + overhead).ToString();
            else {
                ea.Result = (trackBar1.Maximum + overhead).ToString();
            }
        }
        void linearScaleComponent1_CustomRescaling(DevExpress.XtraGauges.Core.Model.CustomRescalingEventArgs ea) {
            ea.MinValue = ea.Value - ValueViewSize;
            ea.MaxValue = ea.Value + ValueViewSize;
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e) {
            linearScaleComponent1.Value = trackBar1.Value;
        }
    }
}
