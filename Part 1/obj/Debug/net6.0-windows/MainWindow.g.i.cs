﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D006EC8034258EE6980012757380927327A6F642"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Part_1;
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


namespace Part_1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 67 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl Menu;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblHeading;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblInstructions;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReplace;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIdentify;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFind;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lsbOutput;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lsbResult;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHelp;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCheck;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Part 1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Menu = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.lblHeading = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblInstructions = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnReplace = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\MainWindow.xaml"
            this.btnReplace.Click += new System.Windows.RoutedEventHandler(this.btnReplace_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnIdentify = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\MainWindow.xaml"
            this.btnIdentify.Click += new System.Windows.RoutedEventHandler(this.btnIdentify_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnFind = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\MainWindow.xaml"
            this.btnFind.Click += new System.Windows.RoutedEventHandler(this.btnFind_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lsbOutput = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.lsbResult = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.btnHelp = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\MainWindow.xaml"
            this.btnHelp.Click += new System.Windows.RoutedEventHandler(this.btnHelp_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnCheck = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\MainWindow.xaml"
            this.btnCheck.Click += new System.Windows.RoutedEventHandler(this.btnCheck_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
