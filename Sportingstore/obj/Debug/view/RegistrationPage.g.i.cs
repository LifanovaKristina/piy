﻿#pragma checksum "..\..\..\view\RegistrationPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "011591C3C40CD1677F119DBE49D9DD007773913E4EE28910C8B906FC88766E84"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Sportingstore.view {
    
    
    /// <summary>
    /// RegistrationPage
    /// </summary>
    public partial class RegistrationPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\view\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Registr;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\view\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginField;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\view\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordField;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\view\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SecretPhrase;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\view\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox retryPasswordField;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\view\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailField;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\view\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\view\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button authorButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\view\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button crossButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Sportingstore;component/view/registrationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\view\RegistrationPage.xaml"
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
            this.Registr = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.loginField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.passwordField = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.SecretPhrase = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.retryPasswordField = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.emailField = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.loginButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\view\RegistrationPage.xaml"
            this.loginButton.Click += new System.Windows.RoutedEventHandler(this.registerButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.authorButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\view\RegistrationPage.xaml"
            this.authorButton.Click += new System.Windows.RoutedEventHandler(this.backToLoginButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.crossButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
