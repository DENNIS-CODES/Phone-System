<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Details"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(636, 495)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(132, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back to Form1"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(186, 182)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(123, 20)
        Me.txtMobileNo.TabIndex = 16
        Me.txtMobileNo.Text = "071234-456789"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Mobile Number"
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(184, 144)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(60, 20)
        Me.txtPostCode.TabIndex = 14
        Me.txtPostCode.Text = "KT1 2AQ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "PostCode"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(184, 98)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(268, 20)
        Me.txtAddress.TabIndex = 12
        Me.txtAddress.Text = "Kingston College"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Addresss"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(184, 61)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(204, 20)
        Me.txtName.TabIndex = 10
        Me.txtName.Text = "Abrar Hamid"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Customer Name"
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(69, 254)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(636, 170)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer Name"
        Me.ColumnHeader1.Width = 168
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Address"
        Me.ColumnHeader2.Width = 239
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PostCode"
        Me.ColumnHeader3.Width = 95
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mobile Number"
        Me.ColumnHeader4.Width = 144
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(391, 182)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(149, 23)
        Me.btnAddCustomer.TabIndex = 18
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(94, 441)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(129, 23)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete Customer"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(245, 441)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(143, 23)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "Edit Customer"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(457, 441)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 23)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save to File"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtMobileNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPostCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
End Class
