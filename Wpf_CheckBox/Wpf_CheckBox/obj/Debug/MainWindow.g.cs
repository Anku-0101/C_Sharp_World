﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "88793B3657339A4DAAA9A2D1544A9B88A0291697B9F1ACFEAB4D14CB0DB661BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Wpf_CheckBox;


namespace Wpf_CheckBox {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbAllToppings;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbSalami;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbMushroom;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbMozzarella;
        
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
            System.Uri resourceLocater = new System.Uri("/Wpf_CheckBox;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.cbAllToppings = ((System.Windows.Controls.CheckBox)(target));
            
            #line 11 "..\..\MainWindow.xaml"
            this.cbAllToppings.Checked += new System.Windows.RoutedEventHandler(this.cbAllToppings_Checked);
            
            #line default
            #line hidden
            
            #line 11 "..\..\MainWindow.xaml"
            this.cbAllToppings.Unchecked += new System.Windows.RoutedEventHandler(this.cbAllToppings_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbSalami = ((System.Windows.Controls.CheckBox)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.cbSalami.Checked += new System.Windows.RoutedEventHandler(this.cbSingle_Checked);
            
            #line default
            #line hidden
            
            #line 13 "..\..\MainWindow.xaml"
            this.cbSalami.Unchecked += new System.Windows.RoutedEventHandler(this.cbSingle_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbMushroom = ((System.Windows.Controls.CheckBox)(target));
            
            #line 19 "..\..\MainWindow.xaml"
            this.cbMushroom.Checked += new System.Windows.RoutedEventHandler(this.cbSingle_Checked);
            
            #line default
            #line hidden
            
            #line 19 "..\..\MainWindow.xaml"
            this.cbMushroom.Unchecked += new System.Windows.RoutedEventHandler(this.cbSingle_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbMozzarella = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\MainWindow.xaml"
            this.cbMozzarella.Checked += new System.Windows.RoutedEventHandler(this.cbSingle_Checked);
            
            #line default
            #line hidden
            
            #line 20 "..\..\MainWindow.xaml"
            this.cbMozzarella.Unchecked += new System.Windows.RoutedEventHandler(this.cbSingle_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

