// Updated by XamlIntelliSenseFileGenerator 12-Jan-24 1:52:20 PM
#pragma checksum "..\..\..\BookingReservation.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01029F41E66C13C030250E6BA2A21D67F0FF08A5"
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


namespace FuMiniHotel
{


    /// <summary>
    /// BookingReservation
    /// </summary>
    public partial class BookingReservation : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FuMiniHotel;V1.0.0.0;component/bookingreservation.xaml", System.UriKind.Relative);

#line 1 "..\..\..\BookingReservation.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button btnBooking;
        internal System.Windows.Controls.Button btnRoom;
        internal System.Windows.Controls.Button btnRoomType;
        internal System.Windows.Controls.Button btnLogOut;
        internal System.Windows.Controls.Label lbTitle;
        internal System.Windows.Controls.Label lbId;
        internal System.Windows.Controls.TextBox txtId;
        internal System.Windows.Controls.Label lbFullname;
        internal System.Windows.Controls.TextBox txtFullname;
        internal System.Windows.Controls.Label BookingDate;
        internal System.Windows.Controls.TextBox txtBookingDate;
        internal System.Windows.Controls.Label lbTelephone;
        internal System.Windows.Controls.TextBox txtTelephone;
        internal System.Windows.Controls.Button btnInsert;
        internal System.Windows.Controls.Button btnUpdate;
        internal System.Windows.Controls.Button btnDelete;
        internal System.Windows.Controls.Button btnSearch;
        internal System.Windows.Controls.ListView lvMembers;
    }
}

