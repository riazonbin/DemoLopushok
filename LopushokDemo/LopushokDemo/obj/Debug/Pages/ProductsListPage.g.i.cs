﻿#pragma checksum "..\..\..\Pages\ProductsListPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "143CDF976D97A4C329B36EDB3F8BB4690FCBFB7A2CC1816A1F468A37330A628D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LopushokDemo.Pages;
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


namespace LopushokDemo.Pages {
    
    
    /// <summary>
    /// ProductsListPage
    /// </summary>
    public partial class ProductsListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\ProductsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\ProductsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSortOrders;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\ProductsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSort;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\ProductsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFilter;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\ProductsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvProducts;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Pages\ProductsListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox PagesListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/LopushokDemo;component/pages/productslistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ProductsListPage.xaml"
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
            
            #line 9 "..\..\..\Pages\ProductsListPage.xaml"
            ((LopushokDemo.Pages.ProductsListPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\Pages\ProductsListPage.xaml"
            this.tbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbSortOrders = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\Pages\ProductsListPage.xaml"
            this.cbSortOrders.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSortOrders_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\Pages\ProductsListPage.xaml"
            this.cbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\Pages\ProductsListPage.xaml"
            this.cbFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lvProducts = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            
            #line 76 "..\..\..\Pages\ProductsListPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PrevPageButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PagesListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 77 "..\..\..\Pages\ProductsListPage.xaml"
            this.PagesListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PagesListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 89 "..\..\..\Pages\ProductsListPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NextPageButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

