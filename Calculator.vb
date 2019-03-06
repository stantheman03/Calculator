Module Module1

    Sub Main()
        Math()

    End Sub
    Function add(num As Integer, num2 As Integer)
        Return num + num2


    End Function

    Function subtract(num As Integer, num2 As Integer)
        Return num - num2

    End Function

    Function divide(num As Integer, num2 As Integer)
        Return num / num2
    End Function
    Function modulus(num As Integer, num2 As Integer)
        Return num Mod num2
    End Function
    Function multiply(num As Integer, num2 As Integer)
        Return num * num2

    End Function
    Function all(num As Integer, num2 As Integer)
        Console.WriteLine("add: " & add(num, num2))
        Console.WriteLine("subtract: " & subtract(num, num2))
        Console.WriteLine("divide: " & divide(num, num2))
        Console.WriteLine("modulus: " & modulus(num, num2))
        Console.WriteLine("multiply: " & multiply(num, num2))
    End Function
    Sub userNumbers(operation As String)

        Dim num As Integer
        Dim num2 As Integer

        Console.WriteLine("please enter first number")
        num = Console.ReadLine

        Console.WriteLine("please enter second number")
        num2 = Console.ReadLine

        If operation = "add" Then
            Console.WriteLine(add(num, num2))
        ElseIf operation = "subtract" Then
            Console.WriteLine(subtract(num, num2))
        ElseIf operation = "divide" Then
            Console.WriteLine(divide(num, num2))
        ElseIf operation = "multiply" Then
            Console.WriteLine(multiply(num, num2))
        ElseIf operation = "modulus" Then
            Console.WriteLine(modulus(num, num2))
        ElseIf operation = "all" Then
            Console.WriteLine(all(num, num2))
        End If

        Console.ReadLine()
    End Sub

    Sub Math()

        Dim selection As Char
        Console.WriteLine("This is your personal calculator: ")
        Console.WriteLine()
        Console.WriteLine("a. add")
        Console.WriteLine("b. subtract")
        Console.WriteLine("c. divide")
        Console.WriteLine("d. modulus")
        Console.WriteLine("e multiply")
        Console.WriteLine("f all")

        selection = Console.ReadLine

        If selection = "a" Then
            userNumbers("add")
        ElseIf selection = "b" Then
            userNumbers("subtract")

        ElseIf selection = "c" Then
            userNumbers("divide")

        ElseIf selection = "d" Then
            userNumbers("modulus")

        ElseIf selection = "e" Then
            userNumbers("multiply")

        ElseIf selection = "f" Then
            userNumbers("all")






        End If

    End Sub

End Module
