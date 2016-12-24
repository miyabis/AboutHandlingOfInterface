
''' <summary>
''' 計算する為のインタフェース
''' </summary>
Public Interface ICompute

    ''' <summary>
    ''' 計算する
    ''' </summary>
    ''' <param name="value1"></param>
    ''' <param name="value2"></param>
    ''' <returns></returns>
    Function Execute(ByVal value1 As Long, ByVal value2 As Long) As Long

End Interface
