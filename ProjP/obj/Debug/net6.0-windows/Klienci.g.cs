﻿#pragma checksum "..\..\..\Klienci.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F7ECDC1FBFDC78729CE3C003C728053FA0412E9F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjP;
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


namespace ProjP {
    
    
    /// <summary>
    /// Klienci
    /// </summary>
    public partial class Klienci : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Klienci.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pesel_txt2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Klienci.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nazwisko_txt2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Klienci.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox imię_txt2;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Klienci.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telefon_txt2;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Klienci.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid2;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Klienci.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertBtn2;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Klienci.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdateBtn2;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Klienci.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtn2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Klienci.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearDataBtn2;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Klienci.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_txt2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjP;component/klienci.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Klienci.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.pesel_txt2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.nazwisko_txt2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.imię_txt2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.telefon_txt2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.datagrid2 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.InsertBtn2 = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Klienci.xaml"
            this.InsertBtn2.Click += new System.Windows.RoutedEventHandler(this.InsertBtn2_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.UpdateBtn2 = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Klienci.xaml"
            this.UpdateBtn2.Click += new System.Windows.RoutedEventHandler(this.UpdateBtn2_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DeleteBtn2 = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Klienci.xaml"
            this.DeleteBtn2.Click += new System.Windows.RoutedEventHandler(this.DeleteBtn2_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ClearDataBtn2 = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Klienci.xaml"
            this.ClearDataBtn2.Click += new System.Windows.RoutedEventHandler(this.ClearDataBtn2_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.search_txt2 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

