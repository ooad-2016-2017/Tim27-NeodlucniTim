﻿#pragma checksum "C:\Users\user\Desktop\novi\Tim27-DDR2\Projekat\Ehotel\DDR2\View\Guests.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "13B4E9E649235D085332FD795C8C789E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DDR2.View
{
    partial class Guests : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Button element1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\View\Guests.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element1).Click += this.Button_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnAddGuest = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 21 "..\..\..\View\Guests.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAddGuest).Click += this.btnAddGuest_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnRemoveGuest = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\View\Guests.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnRemoveGuest).Click += this.btnRemoveGuest_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnEditGuest = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\View\Guests.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnEditGuest).Click += this.btnEditGuest_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnGoBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\View\Guests.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnGoBack).Click += this.btnGoBack_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.GuestListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

