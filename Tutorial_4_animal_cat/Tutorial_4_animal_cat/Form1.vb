Public Class Form1

    ' Declare a Constant thats value can't change
    Private Const PI As Decimal = 3.141592653

    ' ----- ENUMERATIONS -----
    ' With Enumerations you can create custom types like
    ' how Booleans can only except the values True or False
    ' Create an Enum that tracks seasons
    Private Enum Season As Integer
        Spring = 0
        Summer = 1
        Fall = 2
        Winter = 3
    End Enum

    ' ----- STRUCTURES -----
    ' Used to store multiple pieces of data with different data types
    ' Public means you can refer to variables outside of the structure
    Public Structure Employee
        Public name As String
        Public position As String
        Public salary As Decimal

        ' You can add a property with all the info
        ' ReadOnly won't allow the property to be changed
        Public ReadOnly Property FullInfo() As String
            Get
                Return name & " is a " & position & " and makes $" & salary
            End Get
        End Property
    End Structure

    ' ----- OBJECT ORIENTED PROGRAMMING -----
    ' With OOP we model real world objects be defining their
    ' properties (Attributes) and methods (Capabilities)
    ' We define the properties and methods in a class which
    ' is a blueprint for creating objects

    ' Create a class by right clicking your project and then
    ' click Add -> Class and name it Animal.vb

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        Dim txtOutput As String = ""

        ' ----- ARRAYLISTS -----
        ' ArrayLists allow you to create resizable arrays

        Dim customers As New ArrayList

        ' Add items
        customers.Add("Bob Smith")
        customers.Add("Sally Roberts")

        ' Number of items in the list
        txtOutput &= "Count : " & customers.Count &
            Environment.NewLine

        ' Number of items the array list can contain
        txtOutput &= "Capacity : " & customers.Capacity &
            Environment.NewLine

        ' Insert an element into defined index
        customers.Insert(0, "Paul Marx")

        ' Remove matching object
        customers.Remove("Sally Roberts")

        ' Sort the list
        customers.Sort()

        ' Reverse the list
        customers.Reverse()

        ' Returns True or False if array list contains value
        txtOutput &= "Contains Bob Smith : " &
            customers.Contains("Bob Smith") &
            Environment.NewLine

        txtOutput &= "Index of Bob Smith : " &
            customers.IndexOf("Bob Smith") &
            Environment.NewLine

        ' Copy to an array
        Dim arrCustomers(2) As String
        customers.CopyTo(arrCustomers)

        For Each customer As String In arrCustomers
            txtOutput &= customer &
            Environment.NewLine
        Next

        ' Clear the list
        customers.Clear()

        ' ----- ENUMERATION -----
        ' Define a variable as Season type
        Dim currentSeason As Season = Season.Spring

        ' Output the set value
        txtOutput &= "It is " & currentSeason.ToString &
            Environment.NewLine

        ' ----- STRUCTURES -----

        Dim bobSmith As Employee
        bobSmith.name = "Bob Smith"
        bobSmith.position = "Manager"
        bobSmith.salary = 50000

        txtOutput &= bobSmith.name & " is a " &
            bobSmith.position & " and makes $" &
            bobSmith.salary & Environment.NewLine

        txtOutput &= bobSmith.FullInfo & Environment.NewLine

        ' ----- OBJECT ORIENTED PROGRAMMING -----
        ' Create a Animal object and assign property values
        Dim dog As New Animal With {
            .Weight = 77.5,
            .Height = 25.5,
            .Speed = 30.0
        }

        dog.SetName("10")

        txtOutput &= "The Dog is Named " & dog.GetName &
            Environment.NewLine

        txtOutput &= dog.Run() &
            Environment.NewLine

        ' Using a constructor
        Dim cat As New Animal(9, 9, 30, "Fluffy")

        txtOutput &= cat.Run() &
            Environment.NewLine

        ' With Inheritance subclasses inherit all the properties and
        ' methods of the super class
        Dim kitty As New Cat With {
            .Weight = 9.5,
            .Height = 9.5,
            .Speed = 30.0
        }

        kitty.SetName("Kitty")

        txtOutput &= kitty.Run() &
            Environment.NewLine

        ' Polymorphism is when you can refer to a subclass as if 
        ' it was of the super class type and still execute 
        ' overridden methods

        txtOutput &= ShowInfo(cat) &
            Environment.NewLine
        txtOutput &= ShowInfo(kitty) &
            Environment.NewLine

        TextBox1.Text = txtOutput

    End Sub

    Function ShowInfo(theAnimal As Animal) As String
        Return theAnimal.GetName & " weighs " &
            theAnimal.Weight & " lbs " &
            " and is " & theAnimal.Height &
            " inches tall " & theAnimal.Run()
    End Function

End Class
