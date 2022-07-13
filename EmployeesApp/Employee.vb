Public Class Employee
    Public EmpId As String
    Public EmpName As String
    Public EmpAddress As String
    Public SalaryJune As Decimal
    Public SalaryJuly As Decimal
    Public Function TotSal() As Decimal
        Return SalaryJuly + SalaryJune
    End Function

    Public Overrides Function ToString() As String
        Return EmpId & vbTab & EmpName & vbTab & EmpAddress & vbTab & SalaryJune & vbTab & SalaryJuly & vbTab & TotSal()
    End Function
    Public Sub New(EmpId As String, EmpName As String, EmpAddress As String, SalaryJune As Decimal, SalaryJuly As Decimal)
        Me.EmpId = EmpId
        Me.EmpName = EmpName
        Me.EmpAddress = EmpAddress
        Me.SalaryJune = SalaryJune
        Me.SalaryJuly = SalaryJuly
    End Sub
    Public Sub New()

    End Sub


End Class
