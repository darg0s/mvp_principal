#pragma checksum "D:\Git\Aplicação-mvc-Principal\Views\Candidato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fb9716640130aec2b7d5ab3d7423e363ad5f67f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidato_Index), @"mvc.1.0.view", @"/Views/Candidato/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Git\Aplicação-mvc-Principal\Views\_ViewImports.cshtml"
using Aplicação_mvc_Principal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git\Aplicação-mvc-Principal\Views\_ViewImports.cshtml"
using Aplicação_mvc_Principal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fb9716640130aec2b7d5ab3d7423e363ad5f67f", @"/Views/Candidato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf316b4a3298786c34a840f1ecb6a28214ad00c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formularioCandidato"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Git\Aplicação-mvc-Principal\Views\Candidato\Index.cshtml"
  
    ViewData["Title"] = "Dados Pessoais";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "D:\Git\Aplicação-mvc-Principal\Views\Candidato\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fb9716640130aec2b7d5ab3d7423e363ad5f67f3947", async() => {
                WriteLiteral(@"
  <div class=""form-row"">
    <div class=""form-group col-md-7"">
      <label for=""nome"">Nome Completo</label>
      <input type=""text"" class=""form-control"" id=""nome"" placeholder=""Andre Carlos Souza e Silva"">
      <small class=""form-tex text-muted"">* Campo obrigadotrio. </small>
    </div>

    <div class=""form-group col-md-5"">
      <label for=""vaga"">Vaga Selecionada</label>
      <input type=""text"" class=""form-control"" id=""vaga"">      
    </div> 

  </div>

    


  <div class=""form-row"">
    <div class=""form-group col-md-4"">
      <label for=""dataNascimento"">Data de nascimento</label>
      <input type=""text"" class=""form-control"" id=""dataNascimento"" placeholder=""__/__/____"">
    </div>

     <div class=""form-group col-md-4"">
      <label for=""estadoCivil"">Estado Civil</label>
      <input type=""text"" class=""form-control"" id=""estadoCivil"" placeholder=""Casado"">
    </div>

    <div class=""form-group col-md-4"">
      <label for=""sexo"">Sexo</label>
      <input type=""text"" class");
                WriteLiteral(@"=""form-control"" id=""sexo"" placeholder=""Feminino"">
    </div>




  </div>


<h1></h1>
<h1></h1>
<h1></h1>
<h1></h1>

<h1> Endereço</h1>

  <div class=""form-row"">
    <div class=""form-group col-md-2"">
      <label for=""cep"">CEP</label>
      <input type=""text"" class=""form-control"" id=""cep"">
    </div>

  </div>

 

<div class=""form-row"">
   <div class=""form-group col-md-7"">
    <label for=""endereco"">Endereço</label>
    <input type=""text"" class=""form-control"" id=""endereco"" placeholder=""Rua paraiso"">
  </div>

  <div class=""form-group col-md-2"">
    <label for=""numero"">Numero</label>
    <input type=""text"" class=""form-control"" id=""numero"" placeholder=""101"">
  </div>

  <div class=""form-group col-md-3"">
    <label for=""complemento"">Complemento</label>
    <input type=""text"" class=""form-control"" id=""complemento"" placeholder=""Apt, Sala"">
  </div>

</div>

  <div class=""form-row"">
    <div class=""form-group col-md-4"">
      <label for=""bairro"">Bairro</label>
      <inp");
                WriteLiteral(@"ut type=""text"" class=""form-control"" id=""bairro"" placeholder=""Centro"">
    </div>

    <div class=""form-group col-md-6"">
      <label for=""cidade"">Cidade</label>
      <input type=""text"" class=""form-control"" id=""cidade"" placeholder=""Belo Horizonte"">
    </div>

    <div class=""form-group col-md-2"">
     <label for=""estado"">Estado</label>
      <input type=""text"" class=""form-control"" id=""estado"" placeholder=""MG"">
    </div>
    
  </div>

  <h1></h1>
<h1></h1>
<h1></h1>
<h1></h1>

<h1> Documentos</h1>

<div class=""form-row"">
    <div class=""form-group col-md-4"">
      <label for=""cpf"">CPF</label>
      <input type=""text"" class=""form-control"" id=""cpf"" placeholder=""000.000.000-00"">
    </div>


    <div class=""form-group col-md-4"">
      <label for=""rg"">Identidade</label>
      <input type=""text"" class=""form-control"" id=""rg"" placeholder=""9654725"">
    </div>
    
    <div class=""form-group col-md-2"">
     <label for=""veiculo"">Possui Veículo</label>
      <input type=""text"" clas");
                WriteLiteral(@"s=""form-control"" id=""veiculo"" placeholder=""Carro"">

    </div><div class=""form-group col-md-2"">
     <label for=""habilitacao"">Tipo da Habilitação</label>
      <input type=""text"" class=""form-control"" id=""habilitacao"" placeholder=""C"">
    </div>
    
  </div>

<h1></h1>
<h1></h1>
<h1></h1>
<h1></h1>

<h1> Contatos</h1>

<div class=""form-row"">
    <div class=""form-group col-md-3"">
      <label for=""telCelular"">Telefone Celular</label>
      <input type=""text"" class=""form-control"" id=""telCelular""");
                BeginWriteAttribute("placeholder", " placeholder=", 3701, "", 3714, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group col-md-3\">\r\n      <label for=\"telFixo\">Telefone Fixo</label>\r\n      <input type=\"text\" class=\"form-control\" id=\"telFixo\"");
                BeginWriteAttribute("placeholder", " placeholder=", 3880, "", 3893, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    </div>
    
    <div class=""form-group col-md-6"">
      <label for=""email"">Email</label>
      <input type=""email"" class=""form-control"" id=""email"" placeholder=""exemplo@gmail.com"">
    </div>
    
  </div>



  
  <button type=""submit "" class=""btn btn-primary"">Cadastrar</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"












<table class=""table"">
    <thead>
        <tr>
            <th>
                candidato id
            </th>
            <th>
                nome do candidato
            </th>
            <th>
                estado civil
            </th>
            <th>
                genero
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 190 "D:\Git\Aplicação-mvc-Principal\Views\Candidato\Index.cshtml"
         foreach (var candidato in (List<Candidato>)ViewBag.Candidatos) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 193 "D:\Git\Aplicação-mvc-Principal\Views\Candidato\Index.cshtml"
           Write(candidato.CandidatoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 196 "D:\Git\Aplicação-mvc-Principal\Views\Candidato\Index.cshtml"
           Write(candidato.NomeCandidato);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 199 "D:\Git\Aplicação-mvc-Principal\Views\Candidato\Index.cshtml"
           Write(candidato.estado_civil);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 202 "D:\Git\Aplicação-mvc-Principal\Views\Candidato\Index.cshtml"
           Write(candidato.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 205 "D:\Git\Aplicação-mvc-Principal\Views\Candidato\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
