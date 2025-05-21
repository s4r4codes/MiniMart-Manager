<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        navbar = New Panel()
        Panel2 = New Panel()
        lgot_btn = New Button()
        rpt_btn = New Button()
        cstmr_btn = New Button()
        odr_btn = New Button()
        dshbrd_btn = New Button()
        splr_btn = New Button()
        prdct_btn = New Button()
        header = New Panel()
        DateTimePicker1 = New DateTimePicker()
        Title = New TextBox()
        navbar.SuspendLayout()
        header.SuspendLayout()
        SuspendLayout()
        ' 
        ' navbar
        ' 
        navbar.BackColor = Color.PaleTurquoise
        navbar.Controls.Add(Panel2)
        navbar.Controls.Add(lgot_btn)
        navbar.Controls.Add(rpt_btn)
        navbar.Controls.Add(cstmr_btn)
        navbar.Controls.Add(odr_btn)
        navbar.Controls.Add(dshbrd_btn)
        navbar.Controls.Add(splr_btn)
        navbar.Controls.Add(prdct_btn)
        navbar.Dock = DockStyle.Left
        navbar.Location = New Point(0, 0)
        navbar.Name = "navbar"
        navbar.Size = New Size(225, 552)
        navbar.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(224, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1020, 621)
        Panel2.TabIndex = 7
        ' 
        ' lgot_btn
        ' 
        lgot_btn.BackColor = Color.Transparent
        lgot_btn.Cursor = Cursors.Hand
        lgot_btn.FlatAppearance.BorderSize = 0
        lgot_btn.FlatStyle = FlatStyle.Flat
        lgot_btn.Font = New Font("Britannic Bold", 14F)
        lgot_btn.ForeColor = Color.MidnightBlue
        lgot_btn.Location = New Point(3, 401)
        lgot_btn.Name = "lgot_btn"
        lgot_btn.Size = New Size(186, 48)
        lgot_btn.TabIndex = 6
        lgot_btn.Text = "↪LOGOUT"
        lgot_btn.TextAlign = ContentAlignment.MiddleLeft
        lgot_btn.UseVisualStyleBackColor = False
        ' 
        ' rpt_btn
        ' 
        rpt_btn.BackColor = Color.Transparent
        rpt_btn.Cursor = Cursors.Hand
        rpt_btn.FlatAppearance.BorderSize = 0
        rpt_btn.FlatStyle = FlatStyle.Flat
        rpt_btn.Font = New Font("Britannic Bold", 14F)
        rpt_btn.ForeColor = Color.MidnightBlue
        rpt_btn.Location = New Point(3, 347)
        rpt_btn.Name = "rpt_btn"
        rpt_btn.Size = New Size(186, 48)
        rpt_btn.TabIndex = 5
        rpt_btn.Text = "📊REPORT"
        rpt_btn.TextAlign = ContentAlignment.MiddleLeft
        rpt_btn.UseVisualStyleBackColor = False
        ' 
        ' cstmr_btn
        ' 
        cstmr_btn.BackColor = Color.Transparent
        cstmr_btn.Cursor = Cursors.Hand
        cstmr_btn.FlatAppearance.BorderSize = 0
        cstmr_btn.FlatStyle = FlatStyle.Flat
        cstmr_btn.Font = New Font("Britannic Bold", 14F)
        cstmr_btn.ForeColor = Color.MidnightBlue
        cstmr_btn.Location = New Point(3, 293)
        cstmr_btn.Name = "cstmr_btn"
        cstmr_btn.Size = New Size(205, 48)
        cstmr_btn.TabIndex = 4
        cstmr_btn.Text = "👥CUSTOMERS"
        cstmr_btn.TextAlign = ContentAlignment.MiddleLeft
        cstmr_btn.UseVisualStyleBackColor = False
        ' 
        ' odr_btn
        ' 
        odr_btn.BackColor = Color.Transparent
        odr_btn.Cursor = Cursors.Hand
        odr_btn.FlatAppearance.BorderSize = 0
        odr_btn.FlatStyle = FlatStyle.Flat
        odr_btn.Font = New Font("Britannic Bold", 14F)
        odr_btn.ForeColor = Color.MidnightBlue
        odr_btn.Location = New Point(3, 239)
        odr_btn.Name = "odr_btn"
        odr_btn.Size = New Size(183, 48)
        odr_btn.TabIndex = 3
        odr_btn.Text = "📋ORDERS"
        odr_btn.TextAlign = ContentAlignment.MiddleLeft
        odr_btn.UseVisualStyleBackColor = False
        ' 
        ' dshbrd_btn
        ' 
        dshbrd_btn.BackColor = Color.Transparent
        dshbrd_btn.Cursor = Cursors.Hand
        dshbrd_btn.FlatAppearance.BorderSize = 0
        dshbrd_btn.FlatStyle = FlatStyle.Flat
        dshbrd_btn.Font = New Font("Britannic Bold", 14F)
        dshbrd_btn.ForeColor = Color.MidnightBlue
        dshbrd_btn.Location = New Point(3, 80)
        dshbrd_btn.Name = "dshbrd_btn"
        dshbrd_btn.Size = New Size(205, 48)
        dshbrd_btn.TabIndex = 2
        dshbrd_btn.Text = "🏠DASHBOARD"
        dshbrd_btn.TextAlign = ContentAlignment.MiddleLeft
        dshbrd_btn.UseVisualStyleBackColor = False
        ' 
        ' splr_btn
        ' 
        splr_btn.BackColor = Color.Transparent
        splr_btn.Cursor = Cursors.Hand
        splr_btn.FlatAppearance.BorderSize = 0
        splr_btn.FlatStyle = FlatStyle.Flat
        splr_btn.Font = New Font("Britannic Bold", 14F)
        splr_btn.ForeColor = Color.MidnightBlue
        splr_btn.Location = New Point(3, 185)
        splr_btn.Name = "splr_btn"
        splr_btn.Size = New Size(186, 48)
        splr_btn.TabIndex = 1
        splr_btn.Text = "🏭SUPPLIER"
        splr_btn.TextAlign = ContentAlignment.MiddleLeft
        splr_btn.UseVisualStyleBackColor = False
        ' 
        ' prdct_btn
        ' 
        prdct_btn.BackColor = Color.Transparent
        prdct_btn.Cursor = Cursors.Hand
        prdct_btn.FlatAppearance.BorderSize = 0
        prdct_btn.FlatStyle = FlatStyle.Flat
        prdct_btn.Font = New Font("Britannic Bold", 14F)
        prdct_btn.ForeColor = Color.MidnightBlue
        prdct_btn.Location = New Point(3, 134)
        prdct_btn.Name = "prdct_btn"
        prdct_btn.Size = New Size(186, 45)
        prdct_btn.TabIndex = 0
        prdct_btn.Text = "📦PRODUCTS"
        prdct_btn.TextAlign = ContentAlignment.MiddleLeft
        prdct_btn.UseVisualStyleBackColor = False
        ' 
        ' header
        ' 
        header.BackColor = Color.PaleTurquoise
        header.Controls.Add(DateTimePicker1)
        header.Controls.Add(Title)
        header.Dock = DockStyle.Top
        header.Location = New Point(225, 0)
        header.Name = "header"
        header.Size = New Size(970, 144)
        header.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarForeColor = Color.MidnightBlue
        DateTimePicker1.CalendarMonthBackground = Color.MistyRose
        DateTimePicker1.CalendarTitleForeColor = Color.WhiteSmoke
        DateTimePicker1.CalendarTrailingForeColor = Color.MistyRose
        DateTimePicker1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(761, 100)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(181, 36)
        DateTimePicker1.TabIndex = 2
        ' 
        ' Title
        ' 
        Title.BackColor = Color.PaleTurquoise
        Title.BorderStyle = BorderStyle.None
        Title.Font = New Font("Stencil", 27F)
        Title.ForeColor = Color.MidnightBlue
        Title.Location = New Point(13, 30)
        Title.Name = "Title"
        Title.Size = New Size(945, 64)
        Title.TabIndex = 2
        Title.Text = ChrW(55357) & ChrW(57042) & "INVENTORY MANAGEMENT SYSTEM"
        ' 
        ' main
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1195, 552)
        Controls.Add(header)
        Controls.Add(navbar)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "main"
        navbar.ResumeLayout(False)
        header.ResumeLayout(False)
        header.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents header As Panel
    Friend WithEvents prdct_btn As Button
    Friend WithEvents splr_btn As Button
    Friend WithEvents dshbrd_btn As Button
    Friend WithEvents odr_btn As Button
    Friend WithEvents rpt_btn As Button
    Friend WithEvents cstmr_btn As Button
    Friend WithEvents lgot_btn As Button
    Friend WithEvents main As Panel
    Friend WithEvents navbar As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Title As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker

End Class
