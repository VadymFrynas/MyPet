﻿#pragma checksum "..\..\..\Search\SearchIncOutByPeriod.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "99939122FED6A09D6C55274F44B97C18B3CF7BFF4CD33194A374C46BFA1A4E5A"
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
    /// SearchIncOutByPeriod
    /// </summary>
    public partial class SearchIncOutByPeriod : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Search\SearchIncOutByPeriod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox IncExp;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Search\SearchIncOutByPeriod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker PickerStart;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Search\SearchIncOutByPeriod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker PickerEnd;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Search\SearchIncOutByPeriod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Search\SearchIncOutByPeriod.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Wallet;component/search/searchincoutbyperiod.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Search\SearchIncOutByPeriod.xaml"
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
            this.IncExp = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\Search\SearchIncOutByPeriod.xaml"
            this.IncExp.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.IncExp_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\Search\SearchIncOutByPeriod.xaml"
            this.IncExp.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.IncExp_PreviewMouseLeftButtonUp_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PickerStart = ((System.Windows.Controls.DatePicker)(target));
            
            #line 21 "..\..\..\Search\SearchIncOutByPeriod.xaml"
            this.PickerStart.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.PickerStart_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PickerEnd = ((System.Windows.Controls.DatePicker)(target));
            
            #line 22 "..\..\..\Search\SearchIncOutByPeriod.xaml"
            this.PickerEnd.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.PickerEnd_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Search = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Search\SearchIncOutByPeriod.xaml"
            this.Search.Click += new System.Windows.RoutedEventHandler(this.Search_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Search\SearchIncOutByPeriod.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

