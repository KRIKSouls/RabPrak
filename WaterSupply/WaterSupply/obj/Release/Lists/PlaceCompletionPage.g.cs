﻿#pragma checksum "..\..\..\Lists\PlaceCompletionPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74D037FC7CD718DAAB12727C517AE34CDD52EA33B1522565DD37B5BA638EC08A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ScottPlot;
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
using WaterSupply.Lists;


namespace WaterSupply.Lists {
    
    
    /// <summary>
    /// PlaceCompletionPage
    /// </summary>
    public partial class PlaceCompletionPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Lists\PlaceCompletionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPlace;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Lists\PlaceCompletionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDob;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Lists\PlaceCompletionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEzm;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Lists\PlaceCompletionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Lists\PlaceCompletionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SortName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Lists\PlaceCompletionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SortNameOrg;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Lists\PlaceCompletionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchNumPlace;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Lists\PlaceCompletionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ContractPG;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Lists\PlaceCompletionPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterSupply;component/lists/placecompletionpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Lists\PlaceCompletionPage.xaml"
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
            this.dgPlace = ((System.Windows.Controls.DataGrid)(target));
            
            #line 17 "..\..\..\Lists\PlaceCompletionPage.xaml"
            this.dgPlace.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.dgPlace_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnDob = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Lists\PlaceCompletionPage.xaml"
            this.btnDob.Click += new System.Windows.RoutedEventHandler(this.btnDob_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnEzm = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Lists\PlaceCompletionPage.xaml"
            this.btnEzm.Click += new System.Windows.RoutedEventHandler(this.btnEzm_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Lists\PlaceCompletionPage.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SortName = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Lists\PlaceCompletionPage.xaml"
            this.SortName.Click += new System.Windows.RoutedEventHandler(this.SortName_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SortNameOrg = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Lists\PlaceCompletionPage.xaml"
            this.SortNameOrg.Click += new System.Windows.RoutedEventHandler(this.SortNameOrg_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SearchNumPlace = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\Lists\PlaceCompletionPage.xaml"
            this.SearchNumPlace.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchNumPlace_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ContractPG = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Lists\PlaceCompletionPage.xaml"
            this.ContractPG.Click += new System.Windows.RoutedEventHandler(this.ContractPG_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SubBtn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Lists\PlaceCompletionPage.xaml"
            this.SubBtn.Click += new System.Windows.RoutedEventHandler(this.SubBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
