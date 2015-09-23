Imports Modules.Courses.ViewModels
Imports Modules.Departments.ViewModels
Imports Modules.OnlineCourses.ViewModels
Imports Modules.OnsiteCourses.ViewModels
Imports Modules.OfficeAssignments.ViewModels
Imports Modules.StudentGrades.ViewModels
Imports Modules.Persons.ViewModels
Class MainWindow
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Departments
        Me.DepartamentsUserControl.MainGrid.DataContext = New DepartmentsViewModel

        'Courses
        Me.CoursesUserControl.MainGrid.DataContext = New CoursesViewModel

        'OfficeAssignments
        Me.OfficeAssignmentsUserControl.MainGrid.DataContext = New OfficeAssignmentsViewModel

        'OnlineCourses
        Me.OnlineCoursesUserControl.MainGrid.DataContext = New OnlineCoursesViewModel

        'OnsiteCourses
        Me.OnsiteCoursesUserControl.MainGrid.DataContext = New OnsiteCoursesViewModel

        'StudentGrade
        Me.StudentGradesUserControl.MainGrid.DataContext = New StudentGradesViewModel

        'Persons
        Me.PersonsUserControl.MainGrid.DataContext = New PersonsViewModel

    End Sub
End Class
