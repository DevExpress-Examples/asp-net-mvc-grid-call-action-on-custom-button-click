Imports Microsoft.VisualBasic
Imports System
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports Sample.Models

Namespace Sample.Controllers
	Public Class HomeController
		Inherits Controller
		Private list As New PersonsList()

		Public Function Index() As ActionResult
			Return View(list.GetPersons())
		End Function

		Public Function GridViewPartial() As ActionResult
			Return PartialView(list.GetPersons())
		End Function

		Public Function About(ByVal id As Integer) As ActionResult
			ViewData("Key") = id
			Return View()
		End Function
	End Class
End Namespace