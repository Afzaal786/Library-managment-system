﻿#pragma checksum "..\..\frmRack.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BE292F097413BCD2CF5E06FB4BD8BADC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace Library_Managment_System {
    
    
    /// <summary>
    /// frmRack
    /// </summary>
    public partial class frmRack : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\frmRack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\frmRack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRackSearch;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\frmRack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRackDelete;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\frmRack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveRack;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\frmRack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewAllRackss;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\frmRack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchRack;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\frmRack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGiveRackId;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\frmRack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgRack;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\frmRack.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSectionId;
        
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
            System.Uri resourceLocater = new System.Uri("/Library Managment System;component/frmrack.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\frmRack.xaml"
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
            
            #line 4 "..\..\frmRack.xaml"
            ((Library_Managment_System.frmRack)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\frmRack.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnRackSearch = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\frmRack.xaml"
            this.btnRackSearch.Click += new System.Windows.RoutedEventHandler(this.btnRackSearch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnRackDelete = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\frmRack.xaml"
            this.btnRackDelete.Click += new System.Windows.RoutedEventHandler(this.btnRackDelete_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSaveRack = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\frmRack.xaml"
            this.btnSaveRack.Click += new System.Windows.RoutedEventHandler(this.btnSaveRack_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnViewAllRackss = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\frmRack.xaml"
            this.btnViewAllRackss.Click += new System.Windows.RoutedEventHandler(this.btnViewAllRacks_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtSearchRack = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtGiveRackId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.dgRack = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.cmbSectionId = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

