﻿#pragma checksum "..\..\..\AccountWindows\CreateAccount.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D18E674AB597569A618EE4F99C952BCE783BFF92641F50B9F76FE39B7BB2C313"
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
    /// CreateAccount
    /// </summary>
    public partial class CreateAccount : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\AccountWindows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\AccountWindows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\AccountWindows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CardNumber;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\AccountWindows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalSum;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\AccountWindows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Pas_box;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AccountWindows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Pas_confirm;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\AccountWindows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\AccountWindows\CreateAccount.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateAccount1;
        
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
            System.Uri resourceLocater = new System.Uri("/Wallet;component/accountwindows/createaccount.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AccountWindows\CreateAccount.xaml"
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
            this.LastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\AccountWindows\CreateAccount.xaml"
            this.LastName.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.LastName_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FirstName = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\AccountWindows\CreateAccount.xaml"
            this.FirstName.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.FirstName_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CardNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\AccountWindows\CreateAccount.xaml"
            this.CardNumber.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.CardNumber_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TotalSum = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\AccountWindows\CreateAccount.xaml"
            this.TotalSum.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TotalSum_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Pas_box = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 24 "..\..\..\AccountWindows\CreateAccount.xaml"
            this.Pas_box.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Pas_box_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Pas_confirm = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 25 "..\..\..\AccountWindows\CreateAccount.xaml"
            this.Pas_confirm.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Pas_comfirm_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\AccountWindows\CreateAccount.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CreateAccount1 = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\AccountWindows\CreateAccount.xaml"
            this.CreateAccount1.Click += new System.Windows.RoutedEventHandler(this.CreateAccount1_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

