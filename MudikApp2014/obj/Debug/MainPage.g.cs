﻿#pragma checksum "C:\Users\boniyustin\Documents\MudikApp2014\MudikApp2014\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3FF791BBA81BA8ACFC2675957F042396"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using Telerik.Windows.Controls;


namespace MudikApp2014 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Telerik.Windows.Controls.RadAutoCompleteBox address1TextBox;
        
        internal System.Windows.Controls.CheckBox CurrentLocationCheckBox;
        
        internal Telerik.Windows.Controls.RadAutoCompleteBox address2TextBox;
        
        internal System.Windows.Controls.ListBox NewsListBox;
        
        internal System.Windows.Controls.Grid LoadingIndicator;
        
        internal System.Windows.Controls.TextBlock LoadingStatus;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/MudikApp2014;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.address1TextBox = ((Telerik.Windows.Controls.RadAutoCompleteBox)(this.FindName("address1TextBox")));
            this.CurrentLocationCheckBox = ((System.Windows.Controls.CheckBox)(this.FindName("CurrentLocationCheckBox")));
            this.address2TextBox = ((Telerik.Windows.Controls.RadAutoCompleteBox)(this.FindName("address2TextBox")));
            this.NewsListBox = ((System.Windows.Controls.ListBox)(this.FindName("NewsListBox")));
            this.LoadingIndicator = ((System.Windows.Controls.Grid)(this.FindName("LoadingIndicator")));
            this.LoadingStatus = ((System.Windows.Controls.TextBlock)(this.FindName("LoadingStatus")));
        }
    }
}

