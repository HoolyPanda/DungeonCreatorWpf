﻿#pragma checksum "..\..\Constructor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9080A76B8D123804CB3E46986687E63C929C1D35"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DungeonCreatorWpf;
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


namespace DungeonCreatorWpf {
    
    
    /// <summary>
    /// Constructor
    /// </summary>
    public partial class Constructor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DungeonName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Answer;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Enter;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox EncounterList;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ActionList;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ActionDis;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ActionCons;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EncounterName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MainData;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image DungeonMap;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SetDungeonMap;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Check;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Constructor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Test;
        
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
            System.Uri resourceLocater = new System.Uri("/DungeonCreatorWpf;component/constructor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Constructor.xaml"
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
            this.DungeonName = ((System.Windows.Controls.Label)(target));
            
            #line 13 "..\..\Constructor.xaml"
            this.DungeonName.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.DungeonName_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\Constructor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Description_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Answer = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Constructor.xaml"
            this.Answer.Click += new System.Windows.RoutedEventHandler(this.Answer_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Enter = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Constructor.xaml"
            this.Enter.Click += new System.Windows.RoutedEventHandler(this.Enter_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EncounterList = ((System.Windows.Controls.ListBox)(target));
            
            #line 18 "..\..\Constructor.xaml"
            this.EncounterList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.EncounterList_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 18 "..\..\Constructor.xaml"
            this.EncounterList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.EncounterList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 28 "..\..\Constructor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EncounterDescription);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ActionList = ((System.Windows.Controls.ListBox)(target));
            
            #line 29 "..\..\Constructor.xaml"
            this.ActionList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ActionList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ActionDis = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Constructor.xaml"
            this.ActionDis.Click += new System.Windows.RoutedEventHandler(this.ActionDis_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ActionCons = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Constructor.xaml"
            this.ActionCons.Click += new System.Windows.RoutedEventHandler(this.ActionCons_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 41 "..\..\Constructor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save);
            
            #line default
            #line hidden
            return;
            case 11:
            this.EncounterName = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Constructor.xaml"
            this.EncounterName.Click += new System.Windows.RoutedEventHandler(this.EncounterName_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.MainData = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.DungeonMap = ((System.Windows.Controls.Image)(target));
            return;
            case 14:
            this.SetDungeonMap = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\Constructor.xaml"
            this.SetDungeonMap.Click += new System.Windows.RoutedEventHandler(this.SetDungeonMap_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.Check = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\Constructor.xaml"
            this.Check.Click += new System.Windows.RoutedEventHandler(this.Check_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.Test = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\Constructor.xaml"
            this.Test.Click += new System.Windows.RoutedEventHandler(this.Test_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

