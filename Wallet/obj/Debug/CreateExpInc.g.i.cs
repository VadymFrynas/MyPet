﻿#pragma checksum "..\..\CreateExpInc.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7CB207CCA2E212DC9BB55A04FC6DE8461929F3CD77CFE9ED035879F7FFD7A339"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Wallet;


namespace Wallet {
    
    
    /// <summary>
    /// CreateExpInc
    /// </summary>
    public partial class CreateExpInc : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\CreateExpInc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeView;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\CreateExpInc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox IncExp;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CreateExpInc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AccountName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\CreateExpInc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CategoryName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CreateExpInc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IncExpName;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CreateExpInc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Create;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CreateExpInc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
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
            System.Uri resourceLocater = new System.Uri("/Wallet;component/createexpinc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateExpInc.xaml"
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
            this.treeView = ((System.Windows.Controls.TreeView)(target));
            return;
            case 2:
            this.IncExp = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\CreateExpInc.xaml"
            this.IncExp.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.IncExp_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AccountName = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\CreateExpInc.xaml"
            this.AccountName.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.AccountName_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CategoryName = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\CreateExpInc.xaml"
            this.CategoryName.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.CategoryName_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.IncExpName = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\CreateExpInc.xaml"
            this.IncExpName.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.IncExpName_PreviewMouseLeftButtonUp_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Create = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\CreateExpInc.xaml"
            this.Create.Click += new System.Windows.RoutedEventHandler(this.Create_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\CreateExpInc.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
