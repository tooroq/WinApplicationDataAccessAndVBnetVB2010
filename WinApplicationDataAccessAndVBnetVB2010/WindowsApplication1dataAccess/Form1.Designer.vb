<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim FullnameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim DateRegesterLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_stockDataSet = New WindowsApplication1dataAccess.data_stockDataSet()
        Me.Table1TableAdapter = New WindowsApplication1dataAccess.data_stockDataSetTableAdapters.Table1TableAdapter()
        Me.Table1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New WindowsApplication1dataAccess.data_stockDataSetTableAdapters.TableAdapterManager()
        Me.Table1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.QuantTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.checkTextBox = New System.Windows.Forms.TextBox()
        Me.Table1BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateRegesterTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ImgTextBox2 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.nullimg = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.delete = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        FullnameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        DateRegesterLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_stockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(65, 13)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(45, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "المعرف:"
        AddHandler IdLabel.Click, AddressOf Me.IdLabel_Click
        '
        'FullnameLabel
        '
        FullnameLabel.AutoSize = True
        FullnameLabel.Location = New System.Drawing.Point(65, 39)
        FullnameLabel.Name = "FullnameLabel"
        FullnameLabel.Size = New System.Drawing.Size(40, 13)
        FullnameLabel.TabIndex = 3
        FullnameLabel.Text = "الكمية:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(65, 65)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(40, 13)
        EmailLabel.TabIndex = 5
        EmailLabel.Text = "الإسم:"
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.Location = New System.Drawing.Point(65, 91)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(40, 13)
        TelLabel.TabIndex = 7
        TelLabel.Text = "السعر:"
        AddHandler TelLabel.Click, AddressOf Me.TelLabel_Click
        '
        'DateRegesterLabel
        '
        DateRegesterLabel.AutoSize = True
        DateRegesterLabel.Location = New System.Drawing.Point(65, 117)
        DateRegesterLabel.Name = "DateRegesterLabel"
        DateRegesterLabel.Size = New System.Drawing.Size(39, 13)
        DateRegesterLabel.TabIndex = 9
        DateRegesterLabel.Text = "التـوفر:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(65, 184)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(39, 13)
        Label1.TabIndex = 21
        Label1.Text = "التاريخ:"
        AddHandler Label1.Click, AddressOf Me.Label1_Click
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(65, 146)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(40, 13)
        Label2.TabIndex = 24
        Label2.Text = "الصورة:"
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Data_stockDataSet
        '
        'Data_stockDataSet
        '
        Me.Data_stockDataSet.DataSetName = "data_stockDataSet"
        Me.Data_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Table1BindingSource1
        '
        Me.Table1BindingSource1.DataMember = "Table1"
        Me.Table1BindingSource1.DataSource = Me.Data_stockDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1dataAccess.data_stockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table1BindingSource2
        '
        Me.Table1BindingSource2.DataMember = "Table1"
        Me.Table1BindingSource2.DataSource = Me.Data_stockDataSet
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource2, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(112, 10)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(431, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'QuantTextBox
        '
        Me.QuantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource2, "fullname", True))
        Me.QuantTextBox.Location = New System.Drawing.Point(112, 36)
        Me.QuantTextBox.Name = "QuantTextBox"
        Me.QuantTextBox.Size = New System.Drawing.Size(431, 20)
        Me.QuantTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource2, "email", True))
        Me.NameTextBox.Location = New System.Drawing.Point(112, 62)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(431, 20)
        Me.NameTextBox.TabIndex = 6
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource2, "tel", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(112, 88)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(431, 20)
        Me.PriceTextBox.TabIndex = 8
        '
        'checkTextBox
        '
        Me.checkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource2, "dateRegester", True))
        Me.checkTextBox.Location = New System.Drawing.Point(112, 114)
        Me.checkTextBox.Name = "checkTextBox"
        Me.checkTextBox.Size = New System.Drawing.Size(431, 20)
        Me.checkTextBox.TabIndex = 10
        '
        'Table1BindingSource3
        '
        Me.Table1BindingSource3.DataMember = "Table1"
        Me.Table1BindingSource3.DataSource = Me.Data_stockDataSet
        '
        'Table1BindingSource4
        '
        Me.Table1BindingSource4.DataMember = "Table1"
        Me.Table1BindingSource4.DataSource = Me.Data_stockDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 281)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(845, 342)
        Me.DataGridView1.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.search)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 624)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 59)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 20)
        Me.TextBox1.TabIndex = 17
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.Yellow
        Me.search.ForeColor = System.Drawing.Color.Black

        Me.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.search.Location = New System.Drawing.Point(182, 11)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(73, 43)
        Me.search.TabIndex = 16
        Me.search.Text = "       بحث"
        Me.search.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(290, 629)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 54)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Blue
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(343, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 30)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(229, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(4, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(115, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateRegesterTextBox
        '
        Me.DateRegesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource2, "dateRegester", True))
        Me.DateRegesterTextBox.Location = New System.Drawing.Point(112, 181)
        Me.DateRegesterTextBox.Name = "DateRegesterTextBox"
        Me.DateRegesterTextBox.Size = New System.Drawing.Size(431, 20)
        Me.DateRegesterTextBox.TabIndex = 20
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Brown
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(801, 635)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 43)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "خروج"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ImgTextBox2
        '
        Me.ImgTextBox2.Location = New System.Drawing.Point(112, 147)
        Me.ImgTextBox2.Name = "ImgTextBox2"
        Me.ImgTextBox2.Size = New System.Drawing.Size(299, 20)
        Me.ImgTextBox2.TabIndex = 23
        '
        'Button6
        '
        Me.Button6.Image = Global.WindowsApplication1dataAccess.My.Resources.Resources.img241
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(417, 138)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(126, 36)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "إضافة صورة"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'nullimg
        '
        Me.nullimg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nullimg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nullimg.Location = New System.Drawing.Point(569, 222)
        Me.nullimg.Name = "nullimg"
        Me.nullimg.Size = New System.Drawing.Size(289, 44)
        Me.nullimg.TabIndex = 17
        Me.nullimg.Text = "لا توجد صورة"
        Me.nullimg.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1dataAccess.My.Resources.Resources.nullimg1
        Me.PictureBox1.Location = New System.Drawing.Point(569, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(288, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Yellow
        Me.delete.Image = Global.WindowsApplication1dataAccess.My.Resources.Resources.delete32
        Me.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.delete.Location = New System.Drawing.Point(389, 223)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(154, 43)
        Me.delete.TabIndex = 13
        Me.delete.Text = "      حدف"
        Me.delete.UseVisualStyleBackColor = False
        '
        'update
        '
        Me.update.BackColor = System.Drawing.Color.Yellow
        Me.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.update.Image = Global.WindowsApplication1dataAccess.My.Resources.Resources.edit32
        Me.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.update.Location = New System.Drawing.Point(225, 222)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(154, 44)
        Me.update.TabIndex = 12
        Me.update.Text = "     تعديل"
        Me.update.UseVisualStyleBackColor = False
        '
        'add
        '
        Me.add.BackColor = System.Drawing.Color.Yellow
        Me.add.Image = Global.WindowsApplication1dataAccess.My.Resources.Resources.save32
        Me.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.add.Location = New System.Drawing.Point(60, 222)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(154, 44)
        Me.add.TabIndex = 11
        Me.add.Text = "          حفظ"
        Me.add.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(869, 691)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ImgTextBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.DateRegesterTextBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.nullimg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(FullnameLabel)
        Me.Controls.Add(Me.QuantTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(TelLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(DateRegesterLabel)
        Me.Controls.Add(Me.checkTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إدارة المخزون"
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_stockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Data_stockDataSet As WindowsApplication1dataAccess.data_stockDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As WindowsApplication1dataAccess.data_stockDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents Table1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As WindowsApplication1dataAccess.data_stockDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table1BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents checkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents add As System.Windows.Forms.Button
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents Table1BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Table1BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents nullimg As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateRegesterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ImgTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class
