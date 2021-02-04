<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btn_addemployee = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_payroll = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_dtr = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_report = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeAndDate = New System.Windows.Forms.Label()
        Me.datagrid_box = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Datagrid_inventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.datagrid_box.SuspendLayout()
        CType(Me.Datagrid_inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_report)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_dtr)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_payroll)
        Me.Guna2GradientPanel1.Controls.Add(Me.btn_addemployee)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(273, 900)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.TimeAndDate)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(273, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(1127, 73)
        Me.Guna2GradientPanel2.TabIndex = 2
        '
        'btn_addemployee
        '
        Me.btn_addemployee.BackColor = System.Drawing.Color.Transparent
        Me.btn_addemployee.BorderRadius = 5
        Me.btn_addemployee.BorderThickness = 2
        Me.btn_addemployee.CheckedState.Parent = Me.btn_addemployee
        Me.btn_addemployee.CustomImages.Parent = Me.btn_addemployee
        Me.btn_addemployee.FillColor = System.Drawing.Color.Transparent
        Me.btn_addemployee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addemployee.ForeColor = System.Drawing.Color.White
        Me.btn_addemployee.HoverState.Parent = Me.btn_addemployee
        Me.btn_addemployee.Image = Global.DTR.My.Resources.Resources._004_employee
        Me.btn_addemployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_addemployee.ImageOffset = New System.Drawing.Point(0, 25)
        Me.btn_addemployee.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_addemployee.Location = New System.Drawing.Point(1, 262)
        Me.btn_addemployee.Name = "btn_addemployee"
        Me.btn_addemployee.ShadowDecoration.Parent = Me.btn_addemployee
        Me.btn_addemployee.Size = New System.Drawing.Size(268, 57)
        Me.btn_addemployee.TabIndex = 0
        Me.btn_addemployee.Text = "Add Employee"
        Me.btn_addemployee.TextOffset = New System.Drawing.Point(20, -25)
        '
        'btn_payroll
        '
        Me.btn_payroll.BackColor = System.Drawing.Color.Transparent
        Me.btn_payroll.BorderRadius = 5
        Me.btn_payroll.BorderThickness = 2
        Me.btn_payroll.CheckedState.Parent = Me.btn_payroll
        Me.btn_payroll.CustomImages.Parent = Me.btn_payroll
        Me.btn_payroll.FillColor = System.Drawing.Color.Transparent
        Me.btn_payroll.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_payroll.ForeColor = System.Drawing.Color.White
        Me.btn_payroll.HoverState.Parent = Me.btn_payroll
        Me.btn_payroll.Image = Global.DTR.My.Resources.Resources._003_calendar
        Me.btn_payroll.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_payroll.ImageOffset = New System.Drawing.Point(0, 25)
        Me.btn_payroll.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_payroll.Location = New System.Drawing.Point(1, 324)
        Me.btn_payroll.Name = "btn_payroll"
        Me.btn_payroll.ShadowDecoration.Parent = Me.btn_payroll
        Me.btn_payroll.Size = New System.Drawing.Size(268, 57)
        Me.btn_payroll.TabIndex = 1
        Me.btn_payroll.Text = "Payroll"
        Me.btn_payroll.TextOffset = New System.Drawing.Point(20, -25)
        '
        'btn_dtr
        '
        Me.btn_dtr.BackColor = System.Drawing.Color.Transparent
        Me.btn_dtr.BorderRadius = 5
        Me.btn_dtr.BorderThickness = 2
        Me.btn_dtr.CheckedState.Parent = Me.btn_dtr
        Me.btn_dtr.CustomImages.Parent = Me.btn_dtr
        Me.btn_dtr.FillColor = System.Drawing.Color.Transparent
        Me.btn_dtr.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dtr.ForeColor = System.Drawing.Color.White
        Me.btn_dtr.HoverState.Parent = Me.btn_dtr
        Me.btn_dtr.Image = Global.DTR.My.Resources.Resources._005_delivery_time
        Me.btn_dtr.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_dtr.ImageOffset = New System.Drawing.Point(0, 25)
        Me.btn_dtr.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_dtr.Location = New System.Drawing.Point(1, 387)
        Me.btn_dtr.Name = "btn_dtr"
        Me.btn_dtr.ShadowDecoration.Parent = Me.btn_dtr
        Me.btn_dtr.Size = New System.Drawing.Size(268, 57)
        Me.btn_dtr.TabIndex = 2
        Me.btn_dtr.Text = "Daily Time Record"
        Me.btn_dtr.TextOffset = New System.Drawing.Point(20, -25)
        '
        'btn_report
        '
        Me.btn_report.BackColor = System.Drawing.Color.Transparent
        Me.btn_report.BorderRadius = 5
        Me.btn_report.BorderThickness = 2
        Me.btn_report.CheckedState.Parent = Me.btn_report
        Me.btn_report.CustomImages.Parent = Me.btn_report
        Me.btn_report.FillColor = System.Drawing.Color.Transparent
        Me.btn_report.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_report.ForeColor = System.Drawing.Color.White
        Me.btn_report.HoverState.Parent = Me.btn_report
        Me.btn_report.Image = Global.DTR.My.Resources.Resources._002_report
        Me.btn_report.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_report.ImageOffset = New System.Drawing.Point(0, 25)
        Me.btn_report.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_report.Location = New System.Drawing.Point(1, 451)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.ShadowDecoration.Parent = Me.btn_report
        Me.btn_report.Size = New System.Drawing.Size(268, 57)
        Me.btn_report.TabIndex = 3
        Me.btn_report.Text = "Report"
        Me.btn_report.TextOffset = New System.Drawing.Point(20, -25)
        '
        'Timer1
        '
        '
        'TimeAndDate
        '
        Me.TimeAndDate.AutoSize = True
        Me.TimeAndDate.BackColor = System.Drawing.Color.Transparent
        Me.TimeAndDate.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeAndDate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TimeAndDate.Location = New System.Drawing.Point(770, 10)
        Me.TimeAndDate.Name = "TimeAndDate"
        Me.TimeAndDate.Size = New System.Drawing.Size(99, 45)
        Me.TimeAndDate.TabIndex = 6
        Me.TimeAndDate.Text = "Timer"
        '
        'datagrid_box
        '
        Me.datagrid_box.Controls.Add(Me.Datagrid_inventory)
        Me.datagrid_box.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.datagrid_box.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid_box.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.datagrid_box.Location = New System.Drawing.Point(279, 140)
        Me.datagrid_box.Name = "datagrid_box"
        Me.datagrid_box.ShadowDecoration.Parent = Me.datagrid_box
        Me.datagrid_box.Size = New System.Drawing.Size(1109, 713)
        Me.datagrid_box.TabIndex = 3
        Me.datagrid_box.Text = "Employees"
        '
        'Datagrid_inventory
        '
        Me.Datagrid_inventory.AllowUserToAddRows = False
        Me.Datagrid_inventory.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.Datagrid_inventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.Datagrid_inventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datagrid_inventory.BackgroundColor = System.Drawing.Color.Silver
        Me.Datagrid_inventory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagrid_inventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datagrid_inventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagrid_inventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.Datagrid_inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagrid_inventory.DefaultCellStyle = DataGridViewCellStyle15
        Me.Datagrid_inventory.EnableHeadersVisualStyles = False
        Me.Datagrid_inventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_inventory.Location = New System.Drawing.Point(3, 50)
        Me.Datagrid_inventory.Name = "Datagrid_inventory"
        Me.Datagrid_inventory.ReadOnly = True
        Me.Datagrid_inventory.RowHeadersVisible = False
        Me.Datagrid_inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagrid_inventory.Size = New System.Drawing.Size(1103, 660)
        Me.Datagrid_inventory.TabIndex = 7
        Me.Datagrid_inventory.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Datagrid_inventory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Datagrid_inventory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Datagrid_inventory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Datagrid_inventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Datagrid_inventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Datagrid_inventory.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.Datagrid_inventory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Datagrid_inventory.ThemeStyle.HeaderStyle.Height = 23
        Me.Datagrid_inventory.ThemeStyle.ReadOnly = True
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.Height = 22
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_inventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 900)
        Me.Controls.Add(Me.datagrid_box)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.datagrid_box.ResumeLayout(False)
        CType(Me.Datagrid_inventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btn_addemployee As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_report As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_dtr As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_payroll As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimeAndDate As Label
    Friend WithEvents datagrid_box As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Datagrid_inventory As Guna.UI2.WinForms.Guna2DataGridView
End Class
