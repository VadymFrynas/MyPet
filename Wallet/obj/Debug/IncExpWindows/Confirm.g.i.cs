﻿#pragma checksum "..\..\..\IncExpWindows\Confirm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "99B74C97C8A347A66C4D3A7AF8A738D8A8692E573A03CC0E3E71FE796DD27E9D"
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


namespace Wallet {
    
    
    /// <summary>
    /// Confirm
    /// </summary>
    public partial class Confirm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\IncExpWindows\Confirm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Pas_box;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\IncExpWindows\Confirm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfirmPass;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\IncExpWindows\Confirm.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Wallet;component/incexpwindows/confirm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\IncExpWindows\Confirm.xaml"
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
            this.Pas_box = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 11 "..\..\..\IncExpWindows\Confirm.xaml"
            this.Pas_box.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Pas_box_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ConfirmPass = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\IncExpWindows\Confirm.xaml"
            this.ConfirmPass.Click += new System.Windows.RoutedEventHandler(this.Confirm_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\IncExpWindows\Confirm.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

