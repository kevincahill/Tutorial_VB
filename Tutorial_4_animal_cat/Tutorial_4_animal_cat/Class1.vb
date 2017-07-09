Public Class Animal
    ' Define the properties for your object
    Public Height As Decimal = 0.0
    Public Weight As Decimal = 0.0
    Public Speed As Decimal = 0.0

    ' Add a Private property to protect the data
    Private Name As String

    ' Returns the name, but could return a special value
    Public ReadOnly Property GetName() As String
        Get
            Return Name
        End Get
    End Property

    ' Protects the name from getting bad data
    Public Sub SetName(value As String)
        If IsNumeric(value) Then
            MessageBox.Show("Name Can't Contain Numbers",
                            "ERROR")
        Else
            Name = value
        End If
    End Sub

    ' The Constructor is called when the user creates an object
    ' We define that attributes are optional and provide defaults
    Public Sub New(Optional ht As Decimal = 0.0,
                   Optional wt As Decimal = 0.0,
                   Optional spd As Decimal = 0.0,
                   Optional nam As String = "Unknown")
        Height = ht
        Weight = wt
        Speed = spd
        SetName(nam)

    End Sub

    ' Create a function that simulates running
    ' Mark it as overridable so subclasses can override it
    Public Overridable Function Run() As String
        ' You don't have to use GetName in the class
        Return Name & " Runs " & Speed & " MPH"
    End Function


End Class
