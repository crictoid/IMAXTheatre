<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIMAX
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboShowing = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTicketCost = New System.Windows.Forms.Button()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lblTitle.Font = New System.Drawing.Font("Myanmar Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(44, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(314, 51)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "IMAX Theatre Tickets"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboShowing
        '
        Me.cboShowing.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShowing.FormattingEnabled = True
        Me.cboShowing.Items.AddRange(New Object() {"Matinee $16", "Evening $27"})
        Me.cboShowing.Location = New System.Drawing.Point(127, 83)
        Me.cboShowing.Name = "cboShowing"
        Me.cboShowing.Size = New System.Drawing.Size(149, 32)
        Me.cboShowing.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnTicketCost)
        Me.Panel1.Controls.Add(Me.txtTickets)
        Me.Panel1.Controls.Add(Me.lblTickets)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.cboShowing)
        Me.Panel1.Location = New System.Drawing.Point(396, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 464)
        Me.Panel1.TabIndex = 4
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lblCost.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.White
        Me.lblCost.Location = New System.Drawing.Point(96, 361)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(211, 43)
        Me.lblCost.TabIndex = 9
        Me.lblCost.Text = "XXXXXXXXXXXX"
        Me.lblCost.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(114, 273)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(174, 56)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnTicketCost
        '
        Me.btnTicketCost.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnTicketCost.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTicketCost.ForeColor = System.Drawing.Color.White
        Me.btnTicketCost.Location = New System.Drawing.Point(114, 202)
        Me.btnTicketCost.Name = "btnTicketCost"
        Me.btnTicketCost.Size = New System.Drawing.Size(174, 56)
        Me.btnTicketCost.TabIndex = 6
        Me.btnTicketCost.Text = "Ticket Cost"
        Me.btnTicketCost.UseVisualStyleBackColor = False
        Me.btnTicketCost.Visible = False
        '
        'txtTickets
        '
        Me.txtTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTickets.Location = New System.Drawing.Point(170, 165)
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(63, 31)
        Me.txtTickets.TabIndex = 4
        Me.txtTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTickets.Visible = False
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.Location = New System.Drawing.Point(105, 118)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(192, 25)
        Me.lblTickets.TabIndex = 3
        Me.lblTickets.Text = "Number of Tickets:"
        Me.lblTickets.Visible = False
        '
        'frmIMAX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BulmerCh7CPA1.My.Resources.Resources.imax
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmIMAX"
        Me.Text = "Purchase IMAX Theatre Tickets"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboShowing As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCost As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnTicketCost As Button
    Friend WithEvents txtTickets As TextBox
    Friend WithEvents lblTickets As Label
End Class
