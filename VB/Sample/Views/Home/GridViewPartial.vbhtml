@ModelType List(Of Sample.Models.Person)
@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "grid"
            settings.KeyFieldName = "PersonID"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}

            settings.CommandColumn.Visible = True
            settings.CommandColumn.CustomButtons.Add(New GridViewCommandColumnCustomButton() With {.ID = "btnGetKey", .Text = "Get Row Key"})
            settings.ClientSideEvents.CustomButtonClick = String.Format("function(s, e) {{ CustomButtonClick(s, e, '{0}'); }}", Url.Action("About", "Home"))

            settings.Columns.Add("FirstName")
            settings.Columns.Add("MiddleName")
            settings.Columns.Add("LastName")
    End Sub).Bind(Model).GetHtml()
