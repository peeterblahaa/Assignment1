#pragma checksum "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0620d033e38c4ab42b778803c680c478719d6498"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
using FileData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adultslist")]
    public partial class AdultsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults List</h3>\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\n    Filter by Age: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                                                    (arg) => FilterByAge(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading...</em></p>");
#nullable restore
#line 25 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p><em>No Adults exist. Please add some.</em></p>");
#nullable restore
#line 31 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, @"<thead><tr><th>ID</th>
            <th>FName</th>
            <th>LName</th>
            <th>HC</th>
            <th>EC</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th>
            <th>JT</th>
            <th>Remove</th>
            <th>Edit</th></tr></thead>
        ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 52 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
         foreach (var item in adultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 55 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 56 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 57 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 58 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 59 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 60 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 61 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 62 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 63 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n\n                ");
            __builder.OpenElement(41, "td");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                                        () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n                ");
            __builder.OpenElement(46, "td");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
                                        () => Edit(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(49, "<i class=\"oi oi-pencil\" style=\"color:#1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 79 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "/Users/peterblasko/RiderProjects/Assignment1/Assignment1/Pages/AdultsList.razor"
       


    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;

    private int? filterByAge;
    

    private void FilterByAge(ChangeEventArgs changeEventArgs)
    {
        filterByAge = null;
        try
        {
            filterByAge = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }
    

   

    private void ExecuteFilter()
    {
        adultsToShow = allAdults.Where(t => (filterByAge != null && t.Age == filterByAge || filterByAge == null)).ToList();
    }


    protected override async Task OnInitializedAsync()
    {
        allAdults = AdultsData.GetAdults();
        adultsToShow = allAdults;
    }

    private void RemoveAdult(int Id)
   {
       Adult adultToRemove = allAdults.First(t => t.Id == Id);
        AdultsData.RemoveAdult(Id);
        allAdults.Remove(adultToRemove);
      adultsToShow.Remove(adultToRemove);
    }

    


    private void Filter(ChangeEventArgs changeEventArgs)
    {
        int? filterByAge = null;
        try
        {
            filterByAge = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        if (filterByAge != null)
        {
            adultsToShow = allAdults.Where(t => t.Age == filterByAge).ToList();
        }
        else
        {
            adultsToShow = allAdults;
        }
    }
    

    private void Edit(int id)
    {
        NavMgr.NavigateTo($"Edit/{id}");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AdultsData AdultsData { get; set; }
    }
}
#pragma warning restore 1591
