﻿#pragma checksum "..\..\..\RenderToy.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0EB397D208F63B2C15CA9879D31CA65B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Disque.Wpf;
using DisqueRenderToy;
using ICSharpCode.AvalonEdit;
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


namespace DisqueRenderToy {
    
    
    /// <summary>
    /// RenderToy
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class RenderToy : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding Close;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding New;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding Save;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding SaveAs;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Input.CommandBinding Open;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Disque.Wpf.XnaControl screen;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ICSharpCode.AvalonEdit.TextEditor textEditor;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lights_listbox;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_light_button;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox cameras_listbox;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_camera_button;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button image_render_button;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock status;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock fps;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\RenderToy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar renderingbar;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/DisqueRenderToy;component/rendertoy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RenderToy.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Close = ((System.Windows.Input.CommandBinding)(target));
            
            #line 8 "..\..\..\RenderToy.xaml"
            this.Close.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Close_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.New = ((System.Windows.Input.CommandBinding)(target));
            
            #line 9 "..\..\..\RenderToy.xaml"
            this.New.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.New_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Save = ((System.Windows.Input.CommandBinding)(target));
            
            #line 10 "..\..\..\RenderToy.xaml"
            this.Save.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Save_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SaveAs = ((System.Windows.Input.CommandBinding)(target));
            
            #line 11 "..\..\..\RenderToy.xaml"
            this.SaveAs.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveAs_Executed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Open = ((System.Windows.Input.CommandBinding)(target));
            
            #line 12 "..\..\..\RenderToy.xaml"
            this.Open.Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Open_Executed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.screen = ((Disque.Wpf.XnaControl)(target));
            
            #line 57 "..\..\..\RenderToy.xaml"
            this.screen.GotFocus += new System.Windows.RoutedEventHandler(this.screen_GotFocus);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\RenderToy.xaml"
            this.screen.LostFocus += new System.Windows.RoutedEventHandler(this.screen_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textEditor = ((ICSharpCode.AvalonEdit.TextEditor)(target));
            return;
            case 8:
            this.lights_listbox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 9:
            this.add_light_button = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\RenderToy.xaml"
            this.add_light_button.Click += new System.Windows.RoutedEventHandler(this.add_light_button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cameras_listbox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 11:
            this.add_camera_button = ((System.Windows.Controls.Button)(target));
            return;
            case 12:
            this.image_render_button = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\RenderToy.xaml"
            this.image_render_button.Click += new System.Windows.RoutedEventHandler(this.image_render_button_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.status = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.fps = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.renderingbar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
