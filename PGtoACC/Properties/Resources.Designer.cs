﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WindowsFormsApplication1.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;Функция распределения таблиц в Access
        ///Sub export(ByRef Schemes() As String, Tables() As String, Server As String, Port As String, Uid As String, Pwd As String)
        ///
        ///Dim db As Database &apos; объявление переменной типа БД
        ///Set db = CurrentDb() &apos;привязка к объектной переменной текущей базы данных
        ///
        ///Dim serverConn As String
        ///
        ///DoCmd.SetWarnings False
        ///
        ///&apos;Строка связи
        ///serverConn = &quot;DATABASE=getdb;&quot; &amp; _
        ///&quot;SERVER=&quot; &amp; Server &amp; &quot;;PORT=&quot; &amp; Port &amp; &quot;;Uid=&quot; &amp; Uid &amp; &quot;;&quot; &amp; _
        ///&quot;Pwd=&quot; &amp; Pwd &amp; &quot;;&quot;
        ///
        ///
        ///For i = 0 To UBound(Sche [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Macro {
            get {
                return ResourceManager.GetString("Macro", resourceCulture);
            }
        }
    }
}
