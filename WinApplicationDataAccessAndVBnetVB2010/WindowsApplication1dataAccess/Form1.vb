
' www.tooroq.com - Mohamed Hirech - 212658691009
' www.tooroq.com - Mohamed Hirech - 212658691009
' www.tooroq.com - Mohamed Hirech - 212658691009

Imports System.Data.OleDb
Imports System.IO

Public Class Form1

    ' تعريف الاتصال
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:data_stock.accdb;"
    Dim connection As New OleDbConnection(connectionString)
    Dim currentDate As DateTime = DateTime.Today



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ' فتح الاتصال
            connection.Open()

            ' استعلام لعرض البيانات
            Dim query As String = "SELECT * FROM Table1"
            Dim command As New OleDbCommand(query, connection)

            ' إنشاء DataAdapter و DataTable
            Dim adapter As New OleDbDataAdapter(command)
            Dim dataTable As New DataTable()

            ' تعبئة البيانات في DataTable
            adapter.Fill(dataTable)

            ' عرض البيانات في DataGridView
            DataGridView1.DataSource = dataTable

            ' إعداد التنسيق لعرض الصورة في الـ DataGridView
            AddHandler DataGridView1.CellFormatting, AddressOf DataGridView1_CellFormatting


            IdTextBox.Text = DataGridView1.Rows.Count

            CustomizeDataGridView()

        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        Finally
            ' إغلاق الاتصال
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

    End Sub



    Private Sub CustomizeDataGridView()
        ' تمكين التفاف النص داخل الخلايا
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Next

        ' تخصيص ارتفاع الصفوف بناءً على محتوى الخلايا
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Height = 80 ' يمكنك تعديل هذا الرقم حسب حاجتك
        Next

        PictureBox1.Image = Image.FromFile("nullimg.png")

    End Sub



    ' معالج لتنسيق الخلايا وعرض الصورة بحجم ثابت
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs)
        Try
            ' التأكد من أن هذه الخلية تحتوي على صورة
            If e.RowIndex >= 0 AndAlso DataGridView1.Columns(e.ColumnIndex).Name = "imge" Then
                ' التحقق من أن الصورة موجودة في الخلية
                If e.Value IsNot Nothing Then
                    ' تحويل البيانات إلى صورة
                    Dim imageData As Byte() = CType(e.Value, Byte())
                    Using ms As New MemoryStream(imageData)
                        Dim img As Image = Image.FromStream(ms)

                        ' تحديد الحجم الثابت للصور التي ستعرض
                        Dim fixedWidth As Integer = 75
                        Dim fixedHeight As Integer = 75

                        ' تغيير حجم الصورة لتتناسب مع الحجم الثابت
                        e.Value = New Bitmap(img, New Size(fixedWidth, fixedHeight))
                    End Using
                End If
            End If

        Catch ex As Exception

        End Try


    End Sub



    Public Sub leadData()
        Try
            ' فتح الاتصال
            connection.Open()

            ' استعلام لعرض البيانات
            Dim query As String = "SELECT * FROM Table1"
            Dim command As New OleDbCommand(query, connection)

            ' إنشاء DataAdapter و DataTable
            Dim adapter As New OleDbDataAdapter(command)
            Dim dataTable As New DataTable()

            ' تعبئة البيانات في DataTable
            adapter.Fill(dataTable)

            ' عرض البيانات في DataGridView
            DataGridView1.DataSource = dataTable

            ' تحديد آخر صف وجلب قيمته
            If DataGridView1.Rows.Count > 0 Then
                ' الحصول على آخر صف في DataGridView
                Dim lastRow As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Count - 2)

                ' عرض قيم الأعمدة في TextBox
                IdTextBox.Text = lastRow.Cells("معرف").Value.ToString()
                QuantTextBox.Text = lastRow.Cells("الكمية").Value.ToString()
                NameTextBox.Text = lastRow.Cells("الاسم").Value.ToString()
                PriceTextBox.Text = lastRow.Cells("السعر").Value.ToString()
                checkTextBox.Text = lastRow.Cells("التوفر").Value.ToString()
            End If

            CustomizeDataGridView()

        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        Finally
            ' إغلاق الاتصال
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub DataGridView1_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            ' التحقق من أن الصف محدد
            If e.RowIndex >= 0 Then
                ' استخراج البيانات من الصف المحدد
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                ' عرض بيانات كل عمود في TextBox الخاص به
                IdTextBox.Text = selectedRow.Cells("معرف").Value.ToString()
                QuantTextBox.Text = selectedRow.Cells("الكمية").Value.ToString()
                NameTextBox.Text = selectedRow.Cells("الاسم").Value.ToString()
                PriceTextBox.Text = selectedRow.Cells("السعر").Value.ToString()
                checkTextBox.Text = selectedRow.Cells("التوفر").Value.ToString()
                ImgTextBox2.Text = "(image)"
                DateRegesterTextBox.Text = selectedRow.Cells("dateRegester").Value.ToString()

                ' الحصول على القيمة من الخلية (الصورة مخزنة في العمود كـ Byte())
                Dim imageData As Byte() = TryCast(DataGridView1.Rows(e.RowIndex).Cells("imge").Value, Byte())

                ' التحقق من وجود بيانات صورة
                If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                    ' تحويل البيانات إلى صورة وعرضها في PictureBox
                    Using ms As New MemoryStream(imageData)
                        PictureBox1.Image = Image.FromStream(ms)
                    End Using
                Else
                    ' إذا لم تكن هناك صورة، إزالة الصورة من PictureBox
                    PictureBox1.Image = Nothing
                    MessageBox.Show("No image found in the selected cell.")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
    End Sub



    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click

        ' التأكد من وجود صورة في PictureBox
        If PictureBox1.Image IsNot Nothing Then
            ' تحديد الحجم المطلوب للصورة
            Dim targetWidth As Integer = 200
            Dim targetHeight As Integer = 200

            ' تغيير حجم الصورة
            Dim resizedImage As Image = ResizeImage(PictureBox1.Image, targetWidth, targetHeight)

            ' تحويل الصورة إلى مصفوفة Byte()
            Dim imageBytes As Byte()
            Using ms As New MemoryStream()
                resizedImage.Save(ms, PictureBox1.Image.RawFormat)
                imageBytes = ms.ToArray()
            End Using


            Try
                ' فتح الاتصال
                connection.Open()

                ' استعلام إدخال البيانات
                Dim query As String = "INSERT INTO Table1 (معرف, الكمية, الاسم, السعر, التوفر, imge, dateRegester) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7)"
                Dim command As New OleDbCommand(query, connection)

                ' إضافة القيم من TextBoxes
                command.Parameters.AddWithValue("@Value1", IdTextBox.Text)
                command.Parameters.AddWithValue("@Value2", QuantTextBox.Text)
                command.Parameters.AddWithValue("@Value3", NameTextBox.Text)
                command.Parameters.AddWithValue("@Value4", PriceTextBox.Text)
                command.Parameters.AddWithValue("@Value5", checkTextBox.Text)
                command.Parameters.AddWithValue("@Value6", imageBytes)
                command.Parameters.AddWithValue("@Value7", currentDate.ToString("dd-MM-yyyy"))

                ' تنفيذ الأمر
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' رسالة نجاح
                If rowsAffected > 0 Then
                    MessageBox.Show("تمت إضافة البيانات بنجاح!")
                Else
                    MessageBox.Show("لم تتم إضافة أي بيانات.")
                End If
            Catch ex As Exception
                MessageBox.Show("حدث خطأ: " & ex.Message)
            Finally
                ' إغلاق الاتصال
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If

                leadData()
            End Try

        Else
            MessageBox.Show("No image in PictureBox.")
        End If

    End Sub


    Private Function ResizeImage(ByVal originalImage As Image, ByVal targetWidth As Integer, ByVal targetHeight As Integer) As Image
        ' إنشاء صورة جديدة بالحجم المطلوب
        Dim resizedImage As New Bitmap(targetWidth, targetHeight)

        ' رسم الصورة الأصلية على الصورة الجديدة بالحجم الجديد
        Using graphics As Graphics = Graphics.FromImage(resizedImage)
            graphics.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            graphics.DrawImage(originalImage, 0, 0, targetWidth, targetHeight)
        End Using

        Return resizedImage
    End Function







    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click


        ' التأكد من وجود صورة في PictureBox
        If PictureBox1.Image IsNot Nothing Then
            ' تحديد الحجم المطلوب للصورة
            Dim targetWidth As Integer = 200
            Dim targetHeight As Integer = 200

            ' تغيير حجم الصورة
            Dim resizedImage As Image = ResizeImage(PictureBox1.Image, targetWidth, targetHeight)

            ' تحويل الصورة إلى مصفوفة Byte()
            Dim imageBytes As Byte()
            Using ms As New MemoryStream()
                resizedImage.Save(ms, PictureBox1.Image.RawFormat)
                imageBytes = ms.ToArray()
            End Using


            Try
                ' فتح الاتصال
                connection.Open()

                ' استعلام تعديل البيانات
                Dim query As String = "UPDATE Table1 SET معرف = @Value1, الكمية = @Value2, الاسم = @Value3, السعر = @Value4, التوفر = @Value5, imge = @Value6, dateRegester = @Value7 WHERE معرف = @PrimaryKey"
                Dim command As New OleDbCommand(query, connection)

                ' ربط القيم المدخلة بالمعلمات
                command.Parameters.AddWithValue("@Value1", IdTextBox.Text)
                command.Parameters.AddWithValue("@Value2", QuantTextBox.Text)
                command.Parameters.AddWithValue("@Value3", NameTextBox.Text)
                command.Parameters.AddWithValue("@Value4", PriceTextBox.Text)
                command.Parameters.AddWithValue("@Value5", checkTextBox.Text)
                command.Parameters.AddWithValue("@Value6", imageBytes)
                command.Parameters.AddWithValue("@Value7", currentDate.ToString("dd-MM-yyyy"))
                command.Parameters.AddWithValue("@PrimaryKey", IdTextBox.Text) ' القيمة التي تحدد السجل

                ' تنفيذ الاستعلام
                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                ' رسالة تأكيد
                If rowsAffected > 0 Then
                    MessageBox.Show("تم تعديل البيانات بنجاح!")
                Else
                    MessageBox.Show("لم يتم تعديل أي سجل. تأكد من صحة البيانات.")
                End If
            Catch ex As Exception
                MessageBox.Show("حدث خطأ: " & ex.Message)
            Finally
                ' إغلاق الاتصال
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If

                leadData()
            End Try

        Else
            MessageBox.Show("No image in PictureBox.")
        End If


    End Sub







    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Try
            ' فتح الاتصال
            connection.Open()

            ' استعلام الحذف
            Dim query As String = "DELETE FROM Table1 WHERE معرف = @ID"
            Dim command As New OleDbCommand(query, connection)

            ' ربط القيمة بالمعامل
            command.Parameters.AddWithValue("@ID", IdTextBox.Text)

            ' تنفيذ الاستعلام
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            ' رسالة تأكيد
            If rowsAffected > 0 Then
                MessageBox.Show("تم حذف السجل بنجاح!")
            Else
                MessageBox.Show("لم يتم العثور على أي سجل بالمعرّف المدخل.")
            End If
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        Finally
            ' إغلاق الاتصال
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            leadData()
        End Try
    End Sub



    Private Sub nullimg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nullimg.Click
        PictureBox1.Image = Image.FromFile("nullimg.png")
    End Sub

    Private Sub IdLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TelLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    ' متغير لتعقب الصف الحالي
    Dim currentRowIndex As Integer = 0



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ' التحقق من وجود صفوف في DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("لا توجد بيانات في الجدول.")
            Return
        End If

        ' تحديد أول صف
        Dim firstRowIndex As Integer = 0

        ' إلغاء تحديد جميع الصفوف
        DataGridView1.ClearSelection()

        ' تحديد الصف الأول
        DataGridView1.Rows(firstRowIndex).Selected = True

        ' جعل الصف الأول مرئيًا
        DataGridView1.FirstDisplayedScrollingRowIndex = firstRowIndex

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' التحقق من وجود صفوف في DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("لا توجد بيانات في الجدول.")
            Return
        End If

        ' التحقق من أن الصف الحالي ضمن النطاق
        If currentRowIndex >= 0 AndAlso currentRowIndex < DataGridView1.Rows.Count Then
            ' إلغاء تحديد جميع الصفوف أولاً
            DataGridView1.ClearSelection()

            ' تحديد الصف الحالي بالكامل
            DataGridView1.Rows(currentRowIndex).Selected = True

            ' جعل الصف الحالي مرئيًا
            DataGridView1.FirstDisplayedScrollingRowIndex = currentRowIndex
        Else
            MessageBox.Show("الصف خارج النطاق.")
            Return
        End If

        ' الانتقال إلى الصف التالي
        currentRowIndex += 1

        ' إعادة التعيين إذا تجاوز الفهرس عدد الصفوف
        If currentRowIndex >= DataGridView1.Rows.Count Then
            currentRowIndex = 0 ' العودة إلى الصف الأول
        End If
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' التحقق من وجود صفوف في DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("لا توجد بيانات في الجدول.")
            Return
        End If

        ' الانتقال إلى الصف السابق
        currentRowIndex -= 1

        ' إذا كان الفهرس أقل من 0، الانتقال إلى آخر صف
        If currentRowIndex < 0 Then
            currentRowIndex = DataGridView1.Rows.Count - 1
        End If

        ' التحقق من أن الصف الحالي ضمن النطاق
        If currentRowIndex >= 0 AndAlso currentRowIndex < DataGridView1.Rows.Count Then
            ' إلغاء تحديد جميع الصفوف أولاً
            DataGridView1.ClearSelection()

            ' تحديد الصف الحالي بالكامل
            DataGridView1.Rows(currentRowIndex).Selected = True

            ' جعل الصف الحالي مرئيًا
            DataGridView1.FirstDisplayedScrollingRowIndex = currentRowIndex
        Else
            MessageBox.Show("الصف خارج النطاق.")
        End If
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' التحقق من وجود صفوف في DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("لا توجد بيانات في الجدول.")
            Return
        End If

        ' تحديد آخر صف
        Dim lastRowIndex As Integer = DataGridView1.Rows.Count - 2

        ' إلغاء تحديد جميع الصفوف
        DataGridView1.ClearSelection()

        ' تحديد الصف الأخير
        DataGridView1.Rows(lastRowIndex).Selected = True

        ' جعل الصف الأخير مرئيًا
        DataGridView1.FirstDisplayedScrollingRowIndex = lastRowIndex
    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ' عند تغيير النص في TextBox، نقوم بإجراء البحث
        SearchDatabase()
    End Sub



    Private Sub SearchDatabase()
        Try
            ' فتح الاتصال
            connection.Open()

            ' استعلام البحث
            Dim query As String = "SELECT * FROM Table1 WHERE الاسم LIKE @searchText"
            ' تعيين الاستعلام مع إضافة معلمة للبحث
            Dim command = New OleDbCommand(query, connection)

            Command.Parameters.AddWithValue("@searchText", "%" & TextBox1.Text & "%")

            ' إنشاء DataAdapter و DataTable
            Dim adapter As New OleDbDataAdapter(command)
            Dim dataTable As New DataTable()

            ' تنفيذ الاستعلام وتعبئة النتائج في DataTable
            adapter = New OleDbDataAdapter(command)
            dataTable.Clear() ' مسح البيانات القديمة
            adapter.Fill(dataTable)

            ' ربط النتائج بـ DataGridView
            DataGridView1.DataSource = dataTable

            ' غلق الاتصال
            connection.Close()

            CustomizeDataGridView()

        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try
    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ' إنشاء كائن OpenFileDialog
        Dim ofd As New OpenFileDialog()

        ' إعدادات مربع الحوار
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif" ' صيغ الصور المدعومة
        ofd.Title = "Select an Image"

        ' إذا اختار المستخدم ملفًا صحيحًا
        If ofd.ShowDialog() = DialogResult.OK Then
            ' تحميل الصورة في PictureBox
            PictureBox1.Image = Image.FromFile(ofd.FileName)
            ' إظهار المسار في TextBox
            ImgTextBox2.Text = ofd.FileName
        End If
    End Sub



    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ' إنشاء كائن OpenFileDialog
        Dim ofd As New OpenFileDialog()

        ' إعدادات مربع الحوار
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif" ' صيغ الصور المدعومة
        ofd.Title = "Select an Image"

        ' إذا اختار المستخدم ملفًا صحيحًا
        If ofd.ShowDialog() = DialogResult.OK Then
            ' تحميل الصورة في PictureBox
            PictureBox1.Image = Image.FromFile(ofd.FileName)
            ' إظهار المسار في TextBox
            ImgTextBox2.Text = ofd.FileName
        End If
    End Sub



End Class
