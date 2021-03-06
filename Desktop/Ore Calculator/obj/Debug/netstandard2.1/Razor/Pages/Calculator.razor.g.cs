#pragma checksum "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ffc1d255b436dfbcf09aaa81e069d5e13efa40a"
// <auto-generated/>
#pragma warning disable 1591
namespace Ore_Calculator.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\_Imports.razor"
using Ore_Calculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\_Imports.razor"
using Ore_Calculator.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calculator")]
    public partial class Calculator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Calculator</h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
 if (ores == null)
{
    // Loading

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 10 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
}
else
{
    // Content

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                  ores

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.AddMarkupContent(7, "<p>Reprocessing Efficiency (%): </p> ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputNumber<int>>(8);
                __builder2.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 15 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                                                                                 reprocessingEfficiency

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reprocessingEfficiency = __value, reprocessingEfficiency))));
                __builder2.AddAttribute(11, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => reprocessingEfficiency));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenElement(13, "table");
                __builder2.AddAttribute(14, "class", "table");
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.AddMarkupContent(16, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Amount</th>\r\n            </tr>\r\n        </thead>\r\n        ");
                __builder2.OpenElement(17, "tbody");
                __builder2.AddMarkupContent(18, "\r\n");
#nullable restore
#line 24 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
             foreach (string oreName in ORE_STRINGS)
            {
                int number = getMineralNumber(oreName);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(19, "                ");
                __builder2.OpenElement(20, "tr");
                __builder2.AddMarkupContent(21, "\r\n                    ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 28 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                         oreName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenElement(25, "td");
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputNumber<int>>(27);
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 30 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                                                                minerals[number].Amount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => minerals[number].Amount = __value, minerals[number].Amount))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => minerals[number].Amount));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n");
#nullable restore
#line 33 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(34, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenElement(37, "button");
                __builder2.AddAttribute(38, "class", "btn btn-primary");
                __builder2.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                                              OnClick

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(40, "Calculate");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 38 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
     if (buttonClicked)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "id", "result-div");
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 41 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
             if (!calculationFinished)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                ");
            __builder.AddMarkupContent(48, "<p><em>Calculating...</em></p>\r\n");
#nullable restore
#line 44 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                ");
            __builder.AddMarkupContent(50, "<h2>Minerals acquired:</h2>\r\n");
#nullable restore
#line 48 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                 foreach(Mineral min in workingMinerals)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                    ");
            __builder.OpenElement(52, "p");
            __builder.AddContent(53, 
#nullable restore
#line 50 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                        min.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(54, ": ");
            __builder.AddContent(55, 
#nullable restore
#line 50 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                                   min.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 51 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "                ");
            __builder.AddMarkupContent(58, "<h2>Ores to buy:</h2>\r\n");
#nullable restore
#line 54 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                 foreach(Ore ore in ores)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "                    ");
            __builder.OpenElement(60, "p");
            __builder.AddContent(61, 
#nullable restore
#line 56 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                        ore.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, ": ");
            __builder.AddContent(63, 
#nullable restore
#line 56 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                                   ore.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 57 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 60 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Bruger\Documents\GitHub\EvE-Ore-Import-Calculator\Desktop\Ore Calculator\Pages\Calculator.razor"
       
    // Field Variables
    private List<Ore> ores, workingOres;
    private List<Mineral> minerals, workingMinerals;
    private bool buttonClicked = false, calculationFinished = false;
    private int reprocessingEfficiency = 80;

    // Variables for ease of use
    public static string TRITANIUM_STRING = "Tritanium",
        PYERITE_STRING = "Pyerite",
        MEXALLON_STRING = "Mexallon",
        ISOGEN_STRING = "Isogen",
        NOCXIUM_STRING = "Nocxium",
        ZYDRINE_STRING = "Zydrine",
        MEGACYTE_STRING = "Megacyte";

    public static string[] ORE_STRINGS = new string[]
    {
        TRITANIUM_STRING,
        PYERITE_STRING,
        MEXALLON_STRING,
        ISOGEN_STRING,
        NOCXIUM_STRING,
        ZYDRINE_STRING,
        MEGACYTE_STRING
                                        };

    public int getMineralNumber(String mineralName)
    {
        for (int i = 0; i < ORE_STRINGS.Length; i++)
        {
            if (ORE_STRINGS[i].Equals(mineralName))
                return i;
        }
        return -1;
    }

    // Initialize
    protected override async Task OnInitializedAsync()
    {
        // Initialize Mineral List
        minerals = new List<Mineral>();

        for (int i = 0; i < ORE_STRINGS.Length; i++)
        {
            minerals.Add(new Mineral(ORE_STRINGS[i], 0));
        }

        HttpResponseMessage json = await Http.GetAsync("sample-data/OreToMineral.json");
        string jsonString = await json.Content.ReadAsStringAsync();
        ores = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Ore>>(jsonString);
    }

    // Calculate Button click handler
    private void OnClick()
    {
        calculationFinished = false;
        buttonClicked = true;

        Console.WriteLine("Minerales requested, showing or");
        foreach (Mineral m in minerals)
        {
            Console.WriteLine("Name: " + m.Name + ", amount: " + m.Amount);
        }
        Console.WriteLine();

        // Initialize Mineral List
        workingMinerals = new List<Mineral>();

        for (int i = 0; i < ORE_STRINGS.Length; i++)
        {
            workingMinerals.Add(new Mineral(ORE_STRINGS[i], 0));
        }

        workingOres = ores;

        CalculateMinerals(75);
        CalculateMinerals(100);
        calculationFinished = true;
    }

    private void CalculateMinerals(int targetProcent)
    {
        for (int i = ores.Count - 1; i >= 0; i--)
        {
            Ore o = workingOres[i];
            int n = getMineralNumber(o.KeyMineral);
            double r = (double) reprocessingEfficiency / 100;

            Mineral m = null;
            foreach(Mineral min in o.Minerals)
            {
                if (min.Name.Equals(o.KeyMineral))
                {
                    m = min;
                    break;
                }
            }

            if (workingMinerals[n].Amount >= minerals[n].Amount)
                continue;

            o.Amount += (int) Math.Ceiling((double) ((((minerals[n].Amount / r * targetProcent) / 100) - workingMinerals[n].Amount) / m.Amount));

            foreach(Mineral min in o.Minerals)
            {
                workingMinerals[getMineralNumber(min.Name)].Amount = (int) Math.Floor(o.Amount * (m.Amount * r));
            }

            workingOres[i] = o;
        }
    }

    // Inner classes for Data storage
    public class Ore
    {
        [Newtonsoft.Json.JsonProperty("Name")]
        public string Name { get; set; }
        [Newtonsoft.Json.JsonProperty("Volume")]
        public float Volume { get; set; }
        [Newtonsoft.Json.JsonProperty("Minerals")]
        public List<Mineral> Minerals { get; set; }
        [Newtonsoft.Json.JsonProperty("KeyMineral")]
        public string KeyMineral { get; set; }

        public int Amount { get; set; }
    }

    public class Mineral
    {
        [Newtonsoft.Json.JsonProperty("Name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("Amount")]
        public int Amount { get; set; }

        public Mineral(string Name, int Amount)
        {
            this.Name = Name;
            this.Amount = Amount;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
