Public Class TaskManager

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeViewTasks.CheckBoxes = True
    End Sub

    Private Sub ButtonDeleteChecked_Click(sender As Object, e As EventArgs) Handles ButtonDeleteChecked.Click
        DeleteCheckedNodes(TreeViewTasks.Nodes)
    End Sub

    Private Sub DeleteCheckedNodes(nodes As TreeNodeCollection)
        For i As Integer = nodes.Count - 1 To 0 Step -1
            Dim node As TreeNode = nodes(i)
            If node.Checked Then
                nodes.Remove(node)
            Else
                DeleteCheckedNodes(node.Nodes)
            End If
        Next
    End Sub

    Private Sub ButtonExportJson_Click(sender As Object, e As EventArgs) Handles ButtonExportJson.Click
        Dim tasks As New List(Of Object)
        BuildTaskList(TreeViewTasks.Nodes, tasks, Nothing)

        Dim json As String = Newtonsoft.Json.JsonConvert.SerializeObject(tasks, Newtonsoft.Json.Formatting.Indented)
        System.IO.File.WriteAllText("tasks.json", json)
        MessageBox.Show("Tâches exportées avec succès.")
    End Sub

    Private Sub BuildTaskList(nodes As TreeNodeCollection, tasks As List(Of Object), parentTask As Object)
        For Each node As TreeNode In nodes
            Dim task As New With {.Title = node.Text, .IsChecked = node.Checked, .Children = New List(Of Object)()}
            If parentTask Is Nothing Then
                tasks.Add(task)
            Else
                parentTask.Children.Add(task)
            End If
            If node.Nodes.Count > 0 Then BuildTaskList(node.Nodes, tasks, task)
        Next
    End Sub

    Private Sub TreeViewTasks_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TreeViewTasks.AfterCheck
        RemoveHandler TreeViewTasks.AfterCheck, AddressOf TreeViewTasks_AfterCheck
        CheckAllChildNodes(e.Node, e.Node.Checked)
        If e.Node.Parent IsNot Nothing Then CheckParentNode(e.Node.Parent)
        AddHandler TreeViewTasks.AfterCheck, AddressOf TreeViewTasks_AfterCheck
    End Sub

    Private Sub CheckAllChildNodes(treeNode As TreeNode, nodeChecked As Boolean)
        For Each node As TreeNode In treeNode.Nodes
            node.Checked = nodeChecked
            If node.Nodes.Count > 0 Then
                CheckAllChildNodes(node, nodeChecked)
            End If
        Next
    End Sub

    Private Sub CheckParentNode(treeNode As TreeNode)
        Dim allChecked As Boolean = True
        For Each node As TreeNode In treeNode.Nodes
            If Not node.Checked Then allChecked = False
        Next
        treeNode.Checked = allChecked
        If treeNode.Parent IsNot Nothing Then CheckParentNode(treeNode.Parent)
    End Sub

    Private Sub ButtonAddParent_Click(sender As Object, e As EventArgs) Handles ButtonAddParent.Click
        If Not String.IsNullOrWhiteSpace(TextBoxTaskName.Text) Then
            TreeViewTasks.Nodes.Add(TextBoxTaskName.Text)
            TextBoxTaskName.Clear()
        End If
    End Sub

    Private Sub ButtonAddChild_Click(sender As Object, e As EventArgs) Handles ButtonAddChild.Click
        If Not String.IsNullOrWhiteSpace(TextBoxTaskName.Text) AndAlso TreeViewTasks.SelectedNode IsNot Nothing Then
            TreeViewTasks.SelectedNode.Nodes.Add(TextBoxTaskName.Text)
            TreeViewTasks.SelectedNode.Expand()
            TextBoxTaskName.Clear()
        End If
    End Sub

    Private Sub AddNodes(tasks As IEnumerable(Of Object), nodes As TreeNodeCollection)
        For Each task In tasks
            Dim node As TreeNode = nodes.Add(task.Title)
            node.Checked = task.IsChecked
            If task.Children IsNot Nothing AndAlso DirectCast(task.Children, List(Of Object)).Count > 0 Then
                AddNodes(task.Children, node.Nodes)
            End If
        Next
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class