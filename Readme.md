<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128551267/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4827)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Grid View for ASP.NET MVC - How to call an Action method via a custom button and pass a row's key as a parameter
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4827/)**
<!-- run online end -->

This come sample demonstrates how to add a custom button to the grid and .

![Grid](grid.png)

1. Add a custom button to the [CustomButtons](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewCommandColumn.CustomButtons) collection.

    ```cs
    settings.CommandColumn.CustomButtons.Add(new GridViewCommandColumnCustomButton() { ID = "btnGetKey", Text = "Get Row Key" });
    ```

1. Subscribe to the client CustomButtonClick event handler via the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_CustomButtonClicktopic"><u>GridViewSettings.ClientSideEvents.CustomButtonClick</u></a> property: pass the destination Url/Address (generated via the <strong>Url.Action</strong> helper method) as a parameter;

    ```cs
    settings.ClientSideEvents.CustomButtonClick =
        string.Format("function(s, e) {{ CustomButtonClick(s, e, '{0}'); }}", Url.Action("About", "Home"));
    ```

1. In the [CustomButtonClick](https://docs.devexpress.com/AspNet/js-ASPxClientGridView.CustomButtonClick) event handler, use the [GetRowKey](https://docs.devexpress.com/AspNet/js-ASPxClientGridView.GetRowKey(visibleIndex)) method to retrieve the clicked row's key value. 


1. Implement the `CustomButtonClick` event handler. the client [CustomButtonClick](https://docs.devexpress.com/AspNet/js-ASPxClientGridView.CustomButtonClick) event. In the event handler, pass the destination Url/Address (generated via the [Url.Action](https://learn.microsoft.com/ru-ru/dotnet/api/system.web.mvc.urlhelper.action) helper method) as a parameter;

    ```js
        function CustomButtonClick(s, e, url) {
            var key = s.GetRowKey(e.visibleIndex);
            alert("Key Value is " + key);
            if (e.buttonID === "btnGetKey") {
                var destUrl = url + "/" + key;
                alert("Destination Url is: " + destUrl);
                window.location.href = destUrl;
            }
        }
    ```

1. Add the retrieved keyValue parameter to the specified destination Url.  

https://github.com/DevExpress-Examples/how-to-call-an-action-method-via-a-custom-button-and-pass-a-rows-key-as-a-parameter-e4827/blob/832d1141d4af920ef7fbf16a04cb6cdb0c7c4937/CS/Sample/Views/Home/Index.cshtml#L8-L9

    https://github.com/LanaDX/how-to-call-an-action-method-via-a-custom-button-and-pass-a-rows-key-as-a-parameter-e4827/blob/56a4c46c4993d6aa518063990564fce137adc1c9/CS/Sample/Views/Home/Index.cshtml#L8

1. Set the `window.location.href` property to navigate to the destination URL.

https://github.com/DevExpress-Examples/how-to-call-an-action-method-via-a-custom-button-and-pass-a-rows-key-as-a-parameter-e4827/blob/832d1141d4af920ef7fbf16a04cb6cdb0c7c4937/CS/Sample/Views/Home/Index.cshtml#L11

https://github.com/LanaDX/how-to-call-an-action-method-via-a-custom-button-and-pass-a-rows-key-as-a-parameter-e4827/blob/56a4c46c4993d6aa518063990564fce137adc1c9/CS/Sample/Views/Home/Index.cshtml#L11

1. Use the Action's parameter to retrieve the passed key value.  

https://github.com/LanaDX/how-to-call-an-action-method-via-a-custom-button-and-pass-a-rows-key-as-a-parameter-e4827/blob/56a4c46c4993d6aa518063990564fce137adc1c9/CS/Sample/Controllers/HomeController.cs#L18-L21

https://github.com/DevExpress-Examples/how-to-call-an-action-method-via-a-custom-button-and-pass-a-rows-key-as-a-parameter-e4827/blob/832d1141d4af920ef7fbf16a04cb6cdb0c7c4937/CS/Sample/Controllers/HomeController.cs#L18-L21

## Files to Review

* [GridViewPartial.cshtml](./CS/Sample/Views/Home/GridViewPartial.cshtml) (VB: [GridViewPartial.vbhtml](./VB/Sample/Views/Home/GridViewPartial.vbhtml))
* [Index.cshtml](./CS/Sample/Views/Home/Index.cshtml) (VB: [Index.vbhtml](./VB/Sample/Views/Home/Index.vbhtml))
* [HomeController.cs](./CS/Sample/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Sample/Controllers/HomeController.vb))
* [About.cshtml](./CS/Sample/Views/Home/About.cshtml) (VB: [About.vbhtml](./VB/Sample/Views/Home/About.vbhtml))



