<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Sample/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Sample/Controllers/HomeController.vb))
* [About.cshtml](./CS/Sample/Views/Home/About.cshtml)
* [GridViewPartial.cshtml](./CS/Sample/Views/Home/GridViewPartial.cshtml)
* **[Index.cshtml](./CS/Sample/Views/Home/Index.cshtml)**
<!-- default file list end -->
# How to call an Action method via a custom button and pass a row's key as a parameter
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4827/)**
<!-- run online end -->


<p>- Define a custom button via the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewGridViewCommandColumn_CustomButtonstopic"><u>GridViewSettings.CommandColumn.CustomButtons</u></a> collection;<br />
- Customize the client-side CustomButtonClick event handler via the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_CustomButtonClicktopic"><u>GridViewSettings.ClientSideEvents.CustomButtonClick</u></a> property: pass the destination Url/Address (generated via the <strong>Url.Action</strong> helper method) as a parameter;<br />
- Handle the client-side <strong>ASPxClientGridView.CustomButtonClick</strong> event;<br />
- Retrieve the clicked row's keyValue via the client-side <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_GetRowKeytopic"><u>ASPxClientGridView.GetRowKey</u></a> method. Use the EventArgs <strong>e.visibleIndex</strong> property as a parameter;<br />
- Add the retrieved keyValue parameter to the specified destination Url;<br />
- Navigate to the specified Url by changing the <strong>window.location.href</strong> property;<br />
- Retrieve the passed keyValue via an argument of the invoked Action's parameter.</p>

<br/>


