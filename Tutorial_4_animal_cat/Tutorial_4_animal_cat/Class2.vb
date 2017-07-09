Public Class Cat
    ' With this line we inherit all properties and methods
    ' from the Animal super class
    Inherits Animal

    ' Create a function for cleaning
    Public Function Clean() As String
        Return GetName & " Cleans Itself"
    End Function

    ' To override a Function just create one with the same name
    ' and add Overrides
    Public Overrides Function Run() As String

        ' Generate Random 1 or 2
        Dim randomValue = CInt(Math.Floor((2) * Rnd())) + 1

        ' Cats don't always want to run
        If randomValue = 1 Then
            Return GetName & " Runs " & Speed & " MPH"
        Else
            Return GetName & " Prefers to Sleep"
        End If

    End Function

End Class