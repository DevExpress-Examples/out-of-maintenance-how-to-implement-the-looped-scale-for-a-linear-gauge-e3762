Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
			Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
			Me.linearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
			Me.trackBar1 = New System.Windows.Forms.TrackBar()
			Me.linearScaleMarkerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent()
			Me.gaugeControl1.SuspendLayout()
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linearScaleMarkerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.Controls.Add(Me.trackBar1)
			Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.linearGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(642, 562)
			Me.gaugeControl1.TabIndex = 0
			' 
			' linearGauge1
			' 
			Me.linearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() { Me.linearScaleBackgroundLayerComponent1})
			Me.linearGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 630, 550)
			Me.linearGauge1.Markers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent() { Me.linearScaleMarkerComponent1})
			Me.linearGauge1.Name = "linearGauge1"
			Me.linearGauge1.OptionsToolTip.TooltipTitleFormat = "{0}"
			Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() { Me.linearScaleComponent1})
			' 
			' linearScaleComponent1
			' 
			Me.linearScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8F)
			Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F)
			Me.linearScaleComponent1.MajorTickCount = 7
			Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.linearScaleComponent1.MajorTickmark.ShapeOffset = -6F
			Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_1
			Me.linearScaleComponent1.MajorTickmark.TextOffset = -20F
			Me.linearScaleComponent1.MaxValue = 360F
			Me.linearScaleComponent1.MinorTickCount = 4
			Me.linearScaleComponent1.MinorTickmark.ShapeOffset = -3F
			Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style25_2
			Me.linearScaleComponent1.Name = "scale1"
			Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F)
			Me.linearScaleComponent1.Value = 50F
			' 
			' linearScaleBackgroundLayerComponent1
			' 
			Me.linearScaleBackgroundLayerComponent1.LinearScale = Me.linearScaleComponent1
			Me.linearScaleBackgroundLayerComponent1.Name = "bg1"
			Me.linearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F)
			Me.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style25
			Me.linearScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' trackBar1
			' 
			Me.trackBar1.Location = New System.Drawing.Point(468, 494)
			Me.trackBar1.Maximum = 360
			Me.trackBar1.Name = "trackBar1"
			Me.trackBar1.Size = New System.Drawing.Size(162, 56)
			Me.trackBar1.TabIndex = 0
			Me.trackBar1.TickFrequency = 20
'			Me.trackBar1.ValueChanged += New System.EventHandler(Me.trackBar1_ValueChanged);
			' 
			' linearScaleMarkerComponent1
			' 
			Me.linearScaleMarkerComponent1.LinearScale = Me.linearScaleComponent1
			Me.linearScaleMarkerComponent1.Name = "linearGauge1_Marker1"
			Me.linearScaleMarkerComponent1.ShapeOffset = 15F
			Me.linearScaleMarkerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.MarkerPointerShapeType.SliderLeft
			Me.linearScaleMarkerComponent1.ZOrder = -150
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(642, 562)
			Me.Controls.Add(Me.gaugeControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.gaugeControl1.ResumeLayout(False)
			Me.gaugeControl1.PerformLayout()
			CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linearScaleMarkerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
		Private linearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
		Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
		Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
		Private linearScaleMarkerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent
	End Class
End Namespace

