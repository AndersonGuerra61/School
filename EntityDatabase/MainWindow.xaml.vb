Imports Modules.Courses.ViewModels
Imports Modules.Departments.ViewModels
Imports Modules.OnlineCourses.ViewModels
Imports Modules.OnsiteCourses.ViewModels
Class MainWindow
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Departments
        'Me.DepartamentsUserControl.MainGrid.DataContext = New DepartmentsViewModel

        'Courses
        'Me.CoursesUserControl.MainGrid.DataContext = New CoursesViewModel

        'OnlineCourses
        'Me.OnlineCoursesUserControl.MainGrid.DataContext = New OnlineCoursesViewModel

        'OnsiteCourses
        Me.OnsiteCoursesUserControl.MainGrid.DataContext = New OnsiteCoursesViewModel

    End Sub
End Class
