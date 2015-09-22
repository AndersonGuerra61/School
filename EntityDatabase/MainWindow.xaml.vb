Imports Modules.Courses.ViewModels
Imports Modules.Departments.ViewModels
Class MainWindow
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Departments
        'Me.DepartamentsUserControl.MainGrid.DataContext = New DepartmentsViewModel

        'Courses
        Me.CoursesUserControl.MainGrid.DataContext = New CoursesViewModel

    End Sub
End Class
