﻿#pragma checksum "..\..\..\ViewBooking.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9561DE841C48B89789D6C5723818C0E87C9B2BA0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FuMiniHotel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace FuMiniHotel {
    
    
    /// <summary>
    /// ViewBooking
    /// </summary>
    public partial class ViewBooking : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\ViewBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBookingReservation;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ViewBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogOut;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\ViewBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvMembers;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\ViewBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvDetail;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FuMiniHotel;component/viewbooking.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewBooking.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnBookingReservation = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\ViewBooking.xaml"
            this.btnBookingReservation.Click += new System.Windows.RoutedEventHandler(this.btnBookingReservation_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnLogOut = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\ViewBooking.xaml"
            this.btnLogOut.Click += new System.Windows.RoutedEventHandler(this.btnLogOut_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lvMembers = ((System.Windows.Controls.ListView)(target));
            
            #line 40 "..\..\..\ViewBooking.xaml"
            this.lvMembers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvMembers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lvDetail = ((System.Windows.Controls.ListView)(target));
            
            #line 48 "..\..\..\ViewBooking.xaml"
            this.lvDetail.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvMembers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

