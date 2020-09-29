'Purpose: Array Demo
'Author: Mark McFadden
'Date: Today

Option Strict On

Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Process()
    End Sub
    Public Sub Process()

        Dim numbers As Integer() = GetNumbers()
        ShowNumbers(numbers)

        Dim words As String() = GetWords()
        ShowWords(words)

        lstOutput.Items.Add("numbers array size is: " & numbers.Length)
        ReDimNumberArray(numbers, 6)
        lstOutput.Items.Add("After ReDim numbers array size is: " & numbers.Length)

        Dim intArray() As Integer = {2, 7, 10, 9, 4}
        For Each intItem In intArray
            lstOutput.Items.Add(intItem)
        Next

        Array.Sort(intArray)

        For Each intItem In intArray
            lstOutput.Items.Add(intItem)
        Next
    End Sub
    'return an array
    Private Function GetNumbers() As Integer()
        Dim numbers = {10, 20, 30} 'Inferred as integer
        Return numbers
    End Function

    Private Function GetWords() As String()
        Dim words As String() = {"you", "me", "them"}
        ReDim Preserve words(3)
        words(3) = "Us"
        Return words
    End Function
    'pass an array into a procedure as an input parameter
    Private Sub ShowNumbers(numbers As Integer())
        For index = 0 To numbers.GetUpperBound(0)
            lstOutput.Items.Add(numbers(index) & " ")
        Next
        lstOutput.Items.Add("") 'Add a new line
    End Sub
    Private Sub ShowWords(words As String())
        For index = 0 To words.Length - 1
            lstOutput.Items.Add(words(index).ToString)
        Next
        lstOutput.Items.Add("") 'Add a new line
    End Sub

    Private Sub ReDimNumberArray(ByRef numbers As Integer(), ByVal size As Integer)
        ReDim Preserve numbers(size)
    End Sub

    Private Sub btnObjectArray_Click(sender As Object, e As EventArgs) Handles btnObjectArray.Click
        Dim employeeArr(5) As Object
        employeeArr(0) = "Alex Hankin"
        employeeArr(1) = 250.45D
        employeeArr(2) = 48
        employeeArr(3) = "James Dean"
        employeeArr(4) = 334.24D
        employeeArr(5) = 22

        For Each employeeData In employeeArr
            lstOutput.Items.Add(employeeData.ToString() & " is a " & employeeData.GetType().ToString())
        Next

    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstOutput.Items.Clear()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()

    End Sub
End Class
