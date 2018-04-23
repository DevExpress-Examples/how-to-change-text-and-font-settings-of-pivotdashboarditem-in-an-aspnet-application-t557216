﻿Namespace WebApplication1
    Partial Public Class Dashboard1
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

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim calculatedField1 As New DevExpress.DashboardCommon.CalculatedField()
            Dim calculatedField2 As New DevExpress.DashboardCommon.CalculatedField()
            Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
            Dim measure1 As New DevExpress.DashboardCommon.Measure()
            Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.dashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
            Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
            CType(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' dashboardObjectDataSource1
            ' 
            calculatedField1.Expression = "GetMonth([Date])"
            calculatedField1.Name = "Calculated Field 1"
            calculatedField2.Expression = "GetDateMonthYear([Date])"
            calculatedField2.Name = "Calculated Field 2"
            Me.dashboardObjectDataSource1.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() { calculatedField1, calculatedField2})
            Me.dashboardObjectDataSource1.ComponentName = "dashboardObjectDataSource1"
            Me.dashboardObjectDataSource1.DataSource = GetType(NewProject.MyClass)
            Me.dashboardObjectDataSource1.Name = "Object Data Source 1"
            ' 
            ' pivotDashboardItem1
            ' 
            Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
            dimension1.DataMember = "Date"
            dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.MonthYear
            measure1.DataMember = "Sales"
            Me.pivotDashboardItem1.DataItemRepository.Clear()
            Me.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
            Me.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
            Me.pivotDashboardItem1.DataSource = Me.dashboardObjectDataSource1
            Me.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact
            Me.pivotDashboardItem1.Name = "Pivot 1"
            Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
            Me.pivotDashboardItem1.ShowCaption = True
            Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1})
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardObjectDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.pivotDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.pivotDashboardItem1
            dashboardLayoutItem1.Weight = 0.25R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1})
            dashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region
        Private dashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
        Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
    End Class
End Namespace
