﻿#pragma checksum "..\..\..\Lists\VolumePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AC738AF87D5E8B838516139898F8DAECFEC5FEDC5678E112127DB719CE3CB28B"
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
    /// VolumePage
    /// </summary>
    public partial class VolumePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Lists\VolumePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgVol;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Lists\VolumePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WordBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Lists\VolumePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SortPrice;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Lists\VolumePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SortTotalVol;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Lists\VolumePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchNumVol;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Lists\VolumePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubBtn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Lists\VolumePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ContractPG;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Lists\VolumePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WaterQPG;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterSupply;component/lists/volumepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Lists\VolumePage.xaml"
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
            this.dgVol = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\Lists\VolumePage.xaml"
            this.dgVol.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.dgVol_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.WordBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Lists\VolumePage.xaml"
            this.WordBtn.Click += new System.Windows.RoutedEventHandler(this.WordBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SortPrice = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Lists\VolumePage.xaml"
            this.SortPrice.Click += new System.Windows.RoutedEventHandler(this.SortPrice_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SortTotalVol = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Lists\VolumePage.xaml"
            this.SortTotalVol.Click += new System.Windows.RoutedEventHandler(this.SortTotalVol_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchNumVol = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\Lists\VolumePage.xaml"
            this.SearchNumVol.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchNumVol_TextChanged);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\Lists\VolumePage.xaml"
            this.SearchNumVol.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.SearchNumVol_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SubBtn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Lists\VolumePage.xaml"
            this.SubBtn.Click += new System.Windows.RoutedEventHandler(this.SubBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ContractPG = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Lists\VolumePage.xaml"
            this.ContractPG.Click += new System.Windows.RoutedEventHandler(this.ContractPG_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.WaterQPG = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Lists\VolumePage.xaml"
            this.WaterQPG.Click += new System.Windows.RoutedEventHandler(this.WaterQPG_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
