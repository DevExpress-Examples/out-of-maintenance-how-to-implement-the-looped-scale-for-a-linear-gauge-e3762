Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Private Const ValueViewSize As Integer = 30

		Public Sub New()
			InitializeComponent()
			linearScaleComponent1.BeginUpdate()
			linearScaleComponent1.MinValue = trackBar1.Value - ValueViewSize
			linearScaleComponent1.MaxValue = trackBar1.Value + ValueViewSize
			linearScaleComponent1.AutoRescaling = True
			linearScaleComponent1.RescalingBestValues = False
			linearScaleComponent1.RescalingThresholdMin = 0.5f
			linearScaleComponent1.RescalingThresholdMax = 0.5f
			linearScaleComponent1.Value = trackBar1.Value
			AddHandler linearScaleComponent1.CustomRescaling, AddressOf linearScaleComponent1_CustomRescaling
			AddHandler linearScaleComponent1.CustomTickmarkText, AddressOf linearScaleComponent1_CustomTickmarkText
			linearScaleComponent1.EndUpdate()
		End Sub
		Private Sub linearScaleComponent1_CustomTickmarkText(ByVal ea As DevExpress.XtraGauges.Core.Model.CustomTickmarkTextEventArgs)
			Dim overhead As Integer = (CInt(Fix(ea.Value))) Mod (trackBar1.Maximum - trackBar1.Minimum)
			If overhead >= 0 Then
				ea.Result = (trackBar1.Minimum + overhead).ToString()
			Else
				ea.Result = (trackBar1.Maximum + overhead).ToString()
			End If
		End Sub
		Private Sub linearScaleComponent1_CustomRescaling(ByVal ea As DevExpress.XtraGauges.Core.Model.CustomRescalingEventArgs)
			ea.MinValue = ea.Value - ValueViewSize
			ea.MaxValue = ea.Value + ValueViewSize
		End Sub
		Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.ValueChanged
			linearScaleComponent1.Value = trackBar1.Value
		End Sub
	End Class
End Namespace
