<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IdLabel As System.Windows.Forms.Label
        Dim HolaLabel As System.Windows.Forms.Label
        Me.OlaDataSet = New operacionesBDdefinitive.olaDataSet()
        Me.TablaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablaTableAdapter = New operacionesBDdefinitive.olaDataSetTableAdapters.tablaTableAdapter()
        Me.TableAdapterManager = New operacionesBDdefinitive.olaDataSetTableAdapters.TableAdapterManager()
        Me.TablaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TablaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TablaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.HolaTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        HolaLabel = New System.Windows.Forms.Label()
        CType(Me.OlaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TablaBindingNavigator.SuspendLayout()
        CType(Me.TablaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OlaDataSet
        '
        Me.OlaDataSet.DataSetName = "olaDataSet"
        Me.OlaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TablaBindingSource
        '
        Me.TablaBindingSource.DataMember = "tabla"
        Me.TablaBindingSource.DataSource = Me.OlaDataSet
        '
        'TablaTableAdapter
        '
        Me.TablaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tablaTableAdapter = Me.TablaTableAdapter
        Me.TableAdapterManager.UpdateOrder = operacionesBDdefinitive.olaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TablaBindingNavigator
        '
        Me.TablaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TablaBindingNavigator.BindingSource = Me.TablaBindingSource
        Me.TablaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TablaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TablaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TablaBindingNavigatorSaveItem})
        Me.TablaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TablaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TablaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TablaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TablaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TablaBindingNavigator.Name = "TablaBindingNavigator"
        Me.TablaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TablaBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TablaBindingNavigator.TabIndex = 0
        Me.TablaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'TablaBindingNavigatorSaveItem
        '
        Me.TablaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TablaBindingNavigatorSaveItem.Image = CType(resources.GetObject("TablaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TablaBindingNavigatorSaveItem.Name = "TablaBindingNavigatorSaveItem"
        Me.TablaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TablaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TablaDataGridView
        '
        Me.TablaDataGridView.AutoGenerateColumns = False
        Me.TablaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TablaDataGridView.DataSource = Me.TablaBindingSource
        Me.TablaDataGridView.Location = New System.Drawing.Point(402, 82)
        Me.TablaDataGridView.Name = "TablaDataGridView"
        Me.TablaDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TablaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "hola"
        Me.DataGridViewTextBoxColumn2.HeaderText = "hola"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(205, 128)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 2
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablaBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(241, 125)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 3
        '
        'HolaLabel
        '
        HolaLabel.AutoSize = True
        HolaLabel.Location = New System.Drawing.Point(205, 154)
        HolaLabel.Name = "HolaLabel"
        HolaLabel.Size = New System.Drawing.Size(30, 13)
        HolaLabel.TabIndex = 4
        HolaLabel.Text = "hola:"
        '
        'HolaTextBox
        '
        Me.HolaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablaBindingSource, "hola", True))
        Me.HolaTextBox.Location = New System.Drawing.Point(241, 151)
        Me.HolaTextBox.Name = "HolaTextBox"
        Me.HolaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HolaTextBox.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(HolaLabel)
        Me.Controls.Add(Me.HolaTextBox)
        Me.Controls.Add(Me.TablaDataGridView)
        Me.Controls.Add(Me.TablaBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.OlaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TablaBindingNavigator.ResumeLayout(False)
        Me.TablaBindingNavigator.PerformLayout()
        CType(Me.TablaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OlaDataSet As olaDataSet
    Friend WithEvents TablaBindingSource As BindingSource
    Friend WithEvents TablaTableAdapter As olaDataSetTableAdapters.tablaTableAdapter
    Friend WithEvents TableAdapterManager As olaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TablaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TablaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TablaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents HolaTextBox As TextBox
End Class
