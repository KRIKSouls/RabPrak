#pragma checksum "..\..\..\Lists\WaterQualityPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AD1A6C8F6F183361D5AFD9748669D9C4A46A6640E1D8A2D5E9926C47BACB70E0"
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
    /// WaterQualityPage
    /// </summary>
    public partial class WaterQualityPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Lists\WaterQualityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgQuality;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Lists\WaterQualityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WordBtn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Lists\WaterQualityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SortNumInd;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Lists\WaterQualityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SortHazzard;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Lists\WaterQualityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchNumInd;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Lists\WaterQualityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubBtn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Lists\WaterQualityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ContractPG;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Lists\WaterQualityPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WaterVPG;
        
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
            System.Uri resourceLocater = new System.Uri("/WaterSupply;component/lists/waterqualitypage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Lists\WaterQualityPage.xaml"
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
            this.dgQuality = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\Lists\WaterQualityPage.xaml"
            this.dgQuality.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.dgQuality_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.WordBtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Lists\WaterQualityPage.xaml"
            this.WordBtn.Click += new System.Windows.RoutedEventHandler(this.WordBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SortNumInd = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Lists\WaterQualityPage.xaml"
            this.SortNumInd.Click += new System.Windows.RoutedEventHandler(this.SortNumInd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SortHazzard = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Lists\WaterQualityPage.xaml"
            this.SortHazzard.Click += new System.Windows.RoutedEventHandler(this.SortHazzard_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchNumInd = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\Lists\WaterQualityPage.xaml"
            this.SearchNumInd.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchNumInd_TextChanged);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\Lists\WaterQualityPage.xaml"
            this.SearchNumInd.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.SearchNumInd_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SubBtn = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\Lists\WaterQualityPage.xaml"
            this.SubBtn.Click += new System.Windows.RoutedEventHandler(this.SubBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ContractPG = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\Lists\WaterQualityPage.xaml"
            this.ContractPG.Click += new System.Windows.RoutedEventHandler(this.ContractPG_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.WaterVPG = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Lists\WaterQualityPage.xaml"
            this.WaterVPG.Click += new System.Windows.RoutedEventHandler(this.WaterVPG_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

