﻿#pragma checksum "..\..\..\..\Views\InvoiceView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67861D8504D3933B212CCCD8D2C8CB66FAA93F98"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjP.ViewModels;
using ProjP.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ProjP.Views {
    
    
    /// <summary>
    /// InvoiceView
    /// </summary>
    public partial class InvoiceView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Views\InvoiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid4;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\InvoiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertBtn4;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\InvoiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBtn4;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Views\InvoiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn4;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\InvoiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearDataBtn4;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\InvoiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fakturaid_txt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Views\InvoiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nip_txt;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\InvoiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nazwa_txt;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\InvoiceView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox datawystawienia_txt;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjP;component/views/invoiceview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\InvoiceView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.datagrid4 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.InsertBtn4 = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Views\InvoiceView.xaml"
            this.InsertBtn4.Click += new System.Windows.RoutedEventHandler(this.InsertBtn4_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UpdateBtn4 = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Views\InvoiceView.xaml"
            this.UpdateBtn4.Click += new System.Windows.RoutedEventHandler(this.UpdateBtn4_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteBtn4 = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Views\InvoiceView.xaml"
            this.DeleteBtn4.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn4_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ClearDataBtn4 = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Views\InvoiceView.xaml"
            this.ClearDataBtn4.Click += new System.Windows.RoutedEventHandler(this.ClearDataBtn4_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.fakturaid_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.nip_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.nazwa_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.datawystawienia_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

