﻿#pragma checksum "..\..\StartWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FCC1968BCF4C33CBF8DF51CA8966E9FE11D7530EF3D28DB6C039204920D60AC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ErpSystem;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace ErpSystem {
    
    
    /// <summary>
    /// StartWindow
    /// </summary>
    public partial class StartWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\StartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button companiesbtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\StartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button companiesAdressbtn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\StartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button companiesTelephonbtn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\StartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button contactbtn;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\StartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button signOutbtn;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\StartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid myGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ErpSystem;component/startwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StartWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.companiesbtn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\StartWindow.xaml"
            this.companiesbtn.Click += new System.Windows.RoutedEventHandler(this.companiestn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.companiesAdressbtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\StartWindow.xaml"
            this.companiesAdressbtn.Click += new System.Windows.RoutedEventHandler(this.companiesAdressbtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.companiesTelephonbtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\StartWindow.xaml"
            this.companiesTelephonbtn.Click += new System.Windows.RoutedEventHandler(this.companiesTelephonbtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.contactbtn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\StartWindow.xaml"
            this.contactbtn.Click += new System.Windows.RoutedEventHandler(this.contactbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.signOutbtn = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\StartWindow.xaml"
            this.signOutbtn.Click += new System.Windows.RoutedEventHandler(this.signOutbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.myGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 75 "..\..\StartWindow.xaml"
            this.myGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.myGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
