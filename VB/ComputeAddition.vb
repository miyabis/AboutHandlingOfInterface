
''' <summary>
''' 加算する
''' </summary>
Public Class ComputeAddition
    Implements ICompute

    Public Function Execute(value1 As Long, value2 As Long) As Long Implements ICompute.Execute
        Return value1 + value2
    End Function

End Class
