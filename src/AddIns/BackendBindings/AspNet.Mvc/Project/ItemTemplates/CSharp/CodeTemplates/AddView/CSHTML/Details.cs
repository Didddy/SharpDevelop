﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICSharpCode.AspNet.Mvc.CSHtml {
    using ICSharpCode.AspNet.Mvc;
    using System;
    
    
    public partial class Details : DetailsBase {
        
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        
        
        #line 47 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"

	MvcTextTemplateHost MvcHost {
		get { return (MvcTextTemplateHost)Host; }
	}
	
	public string GetModelDirective()
	{
		string viewDataTypeName = MvcHost.ViewDataTypeName;
		if (!String.IsNullOrEmpty(viewDataTypeName)) {
			return String.Format("@model {0}", viewDataTypeName);
		}
		return String.Empty;
	}

        #line default
        #line hidden
        
        
        public global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host {
            get {
                return this.hostValue;
            }
            set {
                this.hostValue = value;
            }
        }
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( GetModelDirective() ));
            
            #line default
            #line hidden
            
            #line 4 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write("\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 6 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
 
	if (MvcHost.IsPartialView) {
		// Do nothing.
	} else if (MvcHost.IsContentPage) {

            
            #line default
            #line hidden
            
            #line 11 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write("@{\r\n\tViewBag.Title = \"");
            
            #line default
            #line hidden
            
            #line 12 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MvcHost.ViewName ));
            
            #line default
            #line hidden
            
            #line 12 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write("\";\r\n\tLayout = \"");
            
            #line default
            #line hidden
            
            #line 13 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MvcHost.MasterPageFile ));
            
            #line default
            #line hidden
            
            #line 13 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write("\";\r\n}\r\n\r\n<h2>");
            
            #line default
            #line hidden
            
            #line 16 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MvcHost.ViewName ));
            
            #line default
            #line hidden
            
            #line 16 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write("</h2>\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 18 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"

	} else {

            
            #line default
            #line hidden
            
            #line 21 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write("<!DOCTYPE html>\r\n<html>\r\n\t<head runat=\"server\">\r\n\t\t<title>");
            
            #line default
            #line hidden
            
            #line 24 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MvcHost.ViewName ));
            
            #line default
            #line hidden
            
            #line 24 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write("</title>\r\n\t</head>\r\n\t<body>\r\n");
            
            #line default
            #line hidden
            
            #line 27 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"

		PushIndent("\t\t");
	}

            
            #line default
            #line hidden
            
            #line 31 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write("<fieldset>\r\n\t<legend>");
            
            #line default
            #line hidden
            
            #line 32 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( MvcHost.ViewDataType.Name ));
            
            #line default
            #line hidden
            
            #line 32 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write("</legend>\r\n</fieldset>\r\n<p>\r\n\t@Html.ActionLink(\"Edit\", \"Edit\") |\r\n\t@Html.ActionLi" +
                    "nk(\"Back\", \"Index\")\r\n</p>\r\n");
            
            #line default
            #line hidden
            
            #line 38 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
 
	if (MvcHost.IsPartialView) {
		// Do nothing.
	} else if (!MvcHost.IsContentPage) {
		PopIndent();

            
            #line default
            #line hidden
            
            #line 44 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
            this.Write("\t</body>\r\n</html>\r\n");
            
            #line default
            #line hidden
            
            #line 46 "D:\projects\dotnet\SharpDevelop.AspNetMvc\src\AddIns\BackendBindings\AspNet.Mvc\Project\ItemTemplates\CSharp\CodeTemplates\AddView\CSHTML\Details.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        protected virtual void Initialize() {
        }
    }
    
    public class DetailsBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private bool endsWithNewline;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            if (string.IsNullOrEmpty(textToAppend)) {
                return;
            }
            if ((((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline) 
                        && (this.CurrentIndent.Length > 0))) {
                this.GenerationEnvironment.Append(this.CurrentIndent);
            }
            this.endsWithNewline = false;
            char last = textToAppend[(textToAppend.Length - 1)];
            if (((last == '\n') 
                        || (last == '\r'))) {
                this.endsWithNewline = true;
            }
            if ((this.CurrentIndent.Length == 0)) {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            int lastNewline = 0;
            for (int i = 0; (i 
                        < (textToAppend.Length - 1)); i = (i + 1)) {
                char c = textToAppend[i];
                if ((c == '\r')) {
                    if ((textToAppend[(i + 1)] == '\n')) {
                        i = (i + 1);
                        if ((i 
                                    == (textToAppend.Length - 1))) {
                            goto breakLoop;
                        }
                    }
                }
                else {
                    if ((c != '\n')) {
                        goto continueLoop;
                    }
                }
                i = (i + 1);
                int len = (i - lastNewline);
                if ((len > 0)) {
                    this.GenerationEnvironment.Append(textToAppend, lastNewline, (i - lastNewline));
                }
                this.GenerationEnvironment.Append(this.CurrentIndent);
                lastNewline = i;
            continueLoop:
                ;
            }
        breakLoop:
            if ((lastNewline > 0)) {
                this.GenerationEnvironment.Append(textToAppend, lastNewline, (textToAppend.Length - lastNewline));
            }
            else {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        
        public void Write(string format, params object[] args) {
            this.Write(string.Format(format, args));
        }
        
        public void WriteLine(string textToAppend) {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        
        public void WriteLine(string format, params object[] args) {
            this.WriteLine(string.Format(format, args));
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((this.formatProvider == null)) {
                        throw new global::System.ArgumentNullException("formatProvider");
                    }
                    this.formatProvider = value;
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
