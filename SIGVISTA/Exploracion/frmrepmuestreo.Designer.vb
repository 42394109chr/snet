﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrepmuestreo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmrepmuestreo))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txtcreadop = New System.Windows.Forms.TextBox()
        Me.cmbturno = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtprograma = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Userboton1 = New SIGVISTA.userboton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.grddetalle = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSearchLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grddetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Userboton1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.grddetalle, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1065, 448)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtestado)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.txtcreadop)
        Me.GroupBox1.Controls.Add(Me.cmbturno)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.txtprograma)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1059, 81)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Programa"
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(649, 30)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(89, 20)
        Me.txtestado.TabIndex = 13
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(497, 59)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(106, 20)
        Me.DateTimePicker2.TabIndex = 12
        '
        'txtcreadop
        '
        Me.txtcreadop.Location = New System.Drawing.Point(497, 30)
        Me.txtcreadop.Name = "txtcreadop"
        Me.txtcreadop.Size = New System.Drawing.Size(84, 20)
        Me.txtcreadop.TabIndex = 11
        '
        'cmbturno
        '
        Me.cmbturno.FormattingEnabled = True
        Me.cmbturno.Items.AddRange(New Object() {"DIA", "NOCHE"})
        Me.cmbturno.Location = New System.Drawing.Point(263, 59)
        Me.cmbturno.Name = "cmbturno"
        Me.cmbturno.Size = New System.Drawing.Size(106, 21)
        Me.cmbturno.TabIndex = 10
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(263, 27)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(115, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(91, 59)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(100, 20)
        Me.txtfecha.TabIndex = 8
        '
        'txtprograma
        '
        Me.txtprograma.Location = New System.Drawing.Point(91, 30)
        Me.txtprograma.Name = "txtprograma"
        Me.txtprograma.Size = New System.Drawing.Size(100, 20)
        Me.txtprograma.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(597, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(377, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de Creacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(422, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Creado por"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Turno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(205, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Inicia el"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Programa"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1059, 75)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proyecto"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(621, 48)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 9
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(621, 18)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(503, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Nro Muestras Real"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(494, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Muestras requeridas"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(313, 33)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(147, 20)
        Me.TextBox6.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(236, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Descripcion"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(118, 33)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Id Proyecto"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1059, 39)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar"
        Me.GroupBox3.Visible = False
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(91, 16)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker3.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(43, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Fecha"
        '
        'Userboton1
        '
        Me.Userboton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userboton1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Userboton1.Location = New System.Drawing.Point(3, 370)
        Me.Userboton1.Name = "Userboton1"
        Me.Userboton1.Size = New System.Drawing.Size(738, 69)
        Me.Userboton1.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnagregar)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 216)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1059, 44)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acciones"
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(31, 19)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 25
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'grddetalle
        '
        Me.grddetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.grddetalle.Location = New System.Drawing.Point(3, 266)
        Me.grddetalle.MainView = Me.GridView1
        Me.grddetalle.Name = "grddetalle"
        Me.grddetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchLookUpEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemGridLookUpEdit1})
        Me.grddetalle.Size = New System.Drawing.Size(1059, 98)
        Me.grddetalle.TabIndex = 7
        Me.grddetalle.UseEmbeddedNavigator = True
        Me.grddetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GridView1.Appearance.Preview.Options.UseFont = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.grddetalle
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "Web"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Nombre"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemSearchLookUpEdit1
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'RepositoryItemSearchLookUpEdit1
        '
        Me.RepositoryItemSearchLookUpEdit1.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit1.Name = "RepositoryItemSearchLookUpEdit1"
        Me.RepositoryItemSearchLookUpEdit1.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nro.Muestras"
        Me.GridColumn2.FieldName = "NUMERO_MUESTREROS"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Programado"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemComboBox1
        Me.GridColumn3.FieldName = "PROGRAMADO"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"SI", "NO"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Geologo Responsable"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.GridColumn4.FieldName = "GEOLOGO_RES"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'frmrepmuestreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 448)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmrepmuestreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROGRAMA DE MUESTREO - EXPLORACIONES"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.grddetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtestado As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcreadop As System.Windows.Forms.TextBox
    Friend WithEvents cmbturno As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents txtprograma As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Userboton1 As SIGVISTA.userboton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents grddetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSearchLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
End Class
