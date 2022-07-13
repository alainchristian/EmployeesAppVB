Module Module1
    Dim empList As List(Of Employee) = New List(Of Employee)
    Sub Main()
        Dim choice As String
        'choice = ""
        Do
            Console.Write("1.Add Employee " & vbNewLine & "2.Display Employee" & vbNewLine & vbNewLine & "Choose an option: ")
            choice = Console.ReadLine()
            Select Case choice
                Case "1"
                    AddEmployees()
                Case "2"
                    DisplayEmployees()
                Case Else
                    Console.Write("Invalid choice")

            End Select
        Loop While choice <> "n"
        Console.ReadLine()
    End Sub
    Sub AddEmployees()
        Dim id, name, address As String
        Dim june, july As Decimal
        id = ""
        Do
            Console.Write("Employee Id:")
            id = Console.ReadLine()
            If id = "" Then
                Exit Sub
            End If
            Console.Write("Employee Name:")
            name = Console.ReadLine()
            Console.Write("Employee Address:")
            address = Console.ReadLine()
            Console.Write("Salary June:")
            june = Console.ReadLine()
            Console.Write("Salary July:")
            july = Console.ReadLine()

            empList.Add(New Employee(id, name, address, june, july))

        Loop While id <> ""
    End Sub
    Sub DisplayEmployees()
        Dim totJune, totJuly As Decimal
        totJune = 0
        totJuly = 0
        For Each emp In empList
            totJune = totJune + emp.SalaryJune
            totJuly = totJune + emp.SalaryJuly
            Console.WriteLine(emp)

        Next
        Console.WriteLine("Total Salary in June: " & totJune)
        Console.WriteLine("Total Salary in July: " & totJuly)
        Console.ReadLine()
    End Sub

End Module
