﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Artemis.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class CounterStrike : global::System.Configuration.ApplicationSettingsBase {
        
        private static CounterStrike defaultInstance = ((CounterStrike)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new CounterStrike())));
        
        public static CounterStrike Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Counter-Strike Global Offensive")]
        public string GameDirectory {
            get {
                return ((string)(this["GameDirectory"]));
            }
            set {
                this["GameDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AmmoEnabled {
            get {
                return ((bool)(this["AmmoEnabled"]));
            }
            set {
                this["AmmoEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFF2900")]
        public global::System.Windows.Media.Color AmmoMainColor {
            get {
                return ((global::System.Windows.Media.Color)(this["AmmoMainColor"]));
            }
            set {
                this["AmmoMainColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF26F600")]
        public global::System.Windows.Media.Color AmmoSecondaryColor {
            get {
                return ((global::System.Windows.Media.Color)(this["AmmoSecondaryColor"]));
            }
            set {
                this["AmmoSecondaryColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TeamColorEnabled {
            get {
                return ((bool)(this["TeamColorEnabled"]));
            }
            set {
                this["TeamColorEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FlashEnabled {
            get {
                return ((bool)(this["FlashEnabled"]));
            }
            set {
                this["FlashEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SmokeEnabled {
            get {
                return ((bool)(this["SmokeEnabled"]));
            }
            set {
                this["SmokeEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LowHpEnabled {
            get {
                return ((bool)(this["LowHpEnabled"]));
            }
            set {
                this["LowHpEnabled"] = value;
            }
        }
    }
}
