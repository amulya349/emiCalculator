﻿#pragma checksum "C:\Users\Amulya\documents\visual studio 2010\Projects\emiCaluclator\emiCaluclator\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "89733036FFBFE89C3D742E63D78E76C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
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


namespace emiCaluclator {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox principal;
        
        internal System.Windows.Controls.TextBox rate;
        
        internal System.Windows.Controls.TextBox time;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBlock textBlock3;
        
        internal System.Windows.Controls.TextBlock textBlock4;
        
        internal System.Windows.Controls.Button calculate;
        
        internal System.Windows.Controls.TextBlock emi;
        
        internal System.Windows.Controls.TextBlock textBlock8;
        
        internal System.Windows.Controls.TextBlock sumPaid;
        
        internal System.Windows.Controls.TextBlock textBlock5;
        
        internal System.Windows.Controls.TextBlock totalInterest;
        
        internal System.Windows.Controls.Button reset;
        
        internal System.Windows.Controls.Button button1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/emiCalculator;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.principal = ((System.Windows.Controls.TextBox)(this.FindName("principal")));
            this.rate = ((System.Windows.Controls.TextBox)(this.FindName("rate")));
            this.time = ((System.Windows.Controls.TextBox)(this.FindName("time")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3")));
            this.textBlock4 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock4")));
            this.calculate = ((System.Windows.Controls.Button)(this.FindName("calculate")));
            this.emi = ((System.Windows.Controls.TextBlock)(this.FindName("emi")));
            this.textBlock8 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock8")));
            this.sumPaid = ((System.Windows.Controls.TextBlock)(this.FindName("sumPaid")));
            this.textBlock5 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock5")));
            this.totalInterest = ((System.Windows.Controls.TextBlock)(this.FindName("totalInterest")));
            this.reset = ((System.Windows.Controls.Button)(this.FindName("reset")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
        }
    }
}

