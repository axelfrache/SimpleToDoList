<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TaskManager
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
        TextBoxTaskName = New TextBox()
        ButtonImportJson = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        GroupBox2 = New GroupBox()
        ButtonExportJson = New Button()
        TreeViewTasks = New TreeView()
        GroupBox1 = New GroupBox()
        ButtonAddChild = New Button()
        ButtonDeleteChecked = New Button()
        ButtonAddParent = New Button()
        TableLayoutPanel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBoxTaskName
        ' 
        TextBoxTaskName.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        TextBoxTaskName.BorderStyle = BorderStyle.FixedSingle
        TextBoxTaskName.Location = New Point(3, 22)
        TextBoxTaskName.Margin = New Padding(3, 3, 3, 25)
        TextBoxTaskName.Name = "TextBoxTaskName"
        TextBoxTaskName.Size = New Size(528, 39)
        TextBoxTaskName.TabIndex = 0
        ' 
        ' ButtonImportJson
        ' 
        ButtonImportJson.Location = New Point(6, 44)
        ButtonImportJson.Name = "ButtonImportJson"
        ButtonImportJson.Size = New Size(150, 44)
        ButtonImportJson.TabIndex = 3
        ButtonImportJson.Text = "Import"
        ButtonImportJson.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60.3960381F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 39.6039619F))
        TableLayoutPanel1.Controls.Add(GroupBox2, 0, 2)
        TableLayoutPanel1.Controls.Add(TextBoxTaskName, 0, 0)
        TableLayoutPanel1.Controls.Add(TreeViewTasks, 0, 1)
        TableLayoutPanel1.Controls.Add(GroupBox1, 1, 1)
        TableLayoutPanel1.Location = New Point(12, 12)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 17.1577129F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 82.8422852F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 114.0F))
        TableLayoutPanel1.Size = New Size(909, 616)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(ButtonExportJson)
        GroupBox2.Controls.Add(ButtonImportJson)
        GroupBox2.Location = New Point(3, 504)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(543, 109)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Tools"
        ' 
        ' ButtonExportJson
        ' 
        ButtonExportJson.Location = New Point(162, 42)
        ButtonExportJson.Name = "ButtonExportJson"
        ButtonExportJson.Size = New Size(150, 46)
        ButtonExportJson.TabIndex = 4
        ButtonExportJson.Text = "Export"
        ButtonExportJson.UseVisualStyleBackColor = True
        ' 
        ' TreeViewTasks
        ' 
        TreeViewTasks.Location = New Point(3, 89)
        TreeViewTasks.Name = "TreeViewTasks"
        TreeViewTasks.Size = New Size(528, 395)
        TreeViewTasks.TabIndex = 6
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ButtonAddChild)
        GroupBox1.Controls.Add(ButtonDeleteChecked)
        GroupBox1.Controls.Add(ButtonAddParent)
        GroupBox1.Location = New Point(552, 89)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(354, 239)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Commands"
        ' 
        ' ButtonAddChild
        ' 
        ButtonAddChild.Location = New Point(29, 104)
        ButtonAddChild.Name = "ButtonAddChild"
        ButtonAddChild.Size = New Size(253, 46)
        ButtonAddChild.TabIndex = 8
        ButtonAddChild.Text = "Add child item"
        ButtonAddChild.UseVisualStyleBackColor = True
        ' 
        ' ButtonDeleteChecked
        ' 
        ButtonDeleteChecked.Location = New Point(29, 156)
        ButtonDeleteChecked.Name = "ButtonDeleteChecked"
        ButtonDeleteChecked.Size = New Size(253, 44)
        ButtonDeleteChecked.TabIndex = 3
        ButtonDeleteChecked.Text = "Delete Item"
        ButtonDeleteChecked.UseVisualStyleBackColor = True
        ' 
        ' ButtonAddParent
        ' 
        ButtonAddParent.Location = New Point(29, 52)
        ButtonAddParent.Name = "ButtonAddParent"
        ButtonAddParent.Size = New Size(253, 46)
        ButtonAddParent.TabIndex = 7
        ButtonAddParent.Text = "Add parent item"
        ButtonAddParent.UseVisualStyleBackColor = True
        ' 
        ' TaskManager
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(956, 656)
        Controls.Add(TableLayoutPanel1)
        Name = "TaskManager"
        Text = "Task Manager"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TextBoxTaskName As TextBox
    Friend WithEvents ButtonImportJson As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonExportJson As Button
    Friend WithEvents TreeViewTasks As TreeView
    Friend WithEvents ButtonAddParent As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonAddChild As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonDeleteChecked As Button

End Class
