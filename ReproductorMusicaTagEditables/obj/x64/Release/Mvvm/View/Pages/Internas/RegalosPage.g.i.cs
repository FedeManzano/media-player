﻿#pragma checksum "..\..\..\..\..\..\..\Mvvm\View\Pages\Internas\RegalosPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC4A9E2A0A623DE67ACDE0CEC5B17861915F325BD97E4181FB0C9DD2C3212DAF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using ReproductorMusicaTagEditables.Controls.Paginador;
using ReproductorMusicaTagEditables.Controls.Regalos;
using ReproductorMusicaTagEditables.Mvvm.View.Pages.Internas;
using ReproductorMusicaTagEditables.Mvvm.ViewModel;
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


namespace ReproductorMusicaTagEditables.Mvvm.View.Pages.Internas {
    
    
    /// <summary>
    /// RegalosPage
    /// </summary>
    public partial class RegalosPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\..\..\Mvvm\View\Pages\Internas\RegalosPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ReproductorMusicaTagEditables.Mvvm.ViewModel.RegalosViewModel regalosViewModel;
        
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
            System.Uri resourceLocater = new System.Uri("/ReproductorMusicaTagEditables;component/mvvm/view/pages/internas/regalospage.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\..\Mvvm\View\Pages\Internas\RegalosPage.xaml"
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
            
            #line 14 "..\..\..\..\..\..\..\Mvvm\View\Pages\Internas\RegalosPage.xaml"
            ((ReproductorMusicaTagEditables.Mvvm.View.Pages.Internas.RegalosPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\..\..\..\..\Mvvm\View\Pages\Internas\RegalosPage.xaml"
            ((ReproductorMusicaTagEditables.Mvvm.View.Pages.Internas.RegalosPage)(target)).Unloaded += new System.Windows.RoutedEventHandler(this.Page_Unloaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.regalosViewModel = ((ReproductorMusicaTagEditables.Mvvm.ViewModel.RegalosViewModel)(target));
            return;
            case 3:
            
            #line 40 "..\..\..\..\..\..\..\Mvvm\View\Pages\Internas\RegalosPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Ir_Atras);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

