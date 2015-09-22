Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel

Namespace Modules.OfficeAssignments.ViewModels
    Public Class OfficeAssignmentsViewModel
        Inherits ViewModelBase

        Private _officeassignments As ObservableCollection(Of OfficeAssignment)
        Private dataAccess As IOfficeAssignmentService

        Public Property OfficeAssignments As ObservableCollection(Of OfficeAssignment)
            Get
                Return Me._officeassignments
            End Get
            Set(value As ObservableCollection(Of OfficeAssignment))
                Me._officeassignments = value
                OnPropertyChanged("OfficeAssignments")
            End Set
        End Property

        ' Function to get all departments from service
        Private Function GetAllOfficeAssignments() As IQueryable(Of OfficeAssignment)
            Return Me.dataAccess.GetAllOfficeAssignments
        End Function

        Sub New()
            'Initialize property variable of departments
            Me._officeassignments = New ObservableCollection(Of OfficeAssignment)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IOfficeAssignmentService)(New OfficeAssignmentService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IOfficeAssignmentService)()
            ' Populate departments property variable 
            For Each element In Me.GetAllOfficeAssignments
                Me._officeassignments.Add(element)
            Next
        End Sub
    End Class
End Namespace

