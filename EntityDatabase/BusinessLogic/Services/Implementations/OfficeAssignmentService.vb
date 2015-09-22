Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class OfficeAssignmentService
        Implements IOfficeAssignmentService

        Public Function GetAllOfficeAssignments() As IQueryable(Of OfficeAssignment) Implements IOfficeAssignmentService.GetAllOfficeAssignments
            Return DataContext.DBEntities.OfficeAssignments
        End Function
    End Class
End Namespace