﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pbp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DataDirectory {
            get {
                return ((string)(this["DataDirectory"]));
            }
            set {
                this["DataDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Calibri, 60pt, style=Bold")]
        public global::System.Drawing.Font ProjectionMasterFont {
            get {
                return ((global::System.Drawing.Font)(this["ProjectionMasterFont"]));
            }
            set {
                this["ProjectionMasterFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color ProjectionBackColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionBackColor"]));
            }
            set {
                this["ProjectionBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color ProjectionMasterFontColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionMasterFontColor"]));
            }
            set {
                this["ProjectionMasterFontColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color ProjectionOutlineColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionOutlineColor"]));
            }
            set {
                this["ProjectionOutlineColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ProjectionFontScaling {
            get {
                return ((bool)(this["ProjectionFontScaling"]));
            }
            set {
                this["ProjectionFontScaling"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("80")]
        public int ProjectionPadding {
            get {
                return ((int)(this["ProjectionPadding"]));
            }
            set {
                this["ProjectionPadding"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Deutsch</string>
  <string>Englisch</string>
  <string>Französisch</string>
  <string>Italienisch</string>
  <string>Schweizerdeutsch</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Languages {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Languages"]));
            }
            set {
                this["Languages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Lobpreis</string>
  <string>Anbetung</string>
  <string>Trost</string>
  <string>Hingabe</string>
  <string>Heiliger Geist</string>
  <string>Segen</string>
  <string>Dank</string>
  <string>Bitte</string>
  <string>Evangelisation</string>
  <string>Vertrauen</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Tags {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Tags"]));
            }
            set {
                this["Tags"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Refrain</string>
  <string>Pre-Chorus</string>
  <string>Chorus</string>
  <string>Strophe 1</string>
  <string>Strophe 2</string>
  <string>Strophe 3</string>
  <string>Teil 1</string>
  <string>Teil 2</string>
  <string>Teil 3</string>
  <string>Instrumental</string>
  <string>Bridge</string>
  <string>Schluss</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SongParts {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SongParts"]));
            }
            set {
                this["SongParts"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Songs")]
        public string SongDir {
            get {
                return ((string)(this["SongDir"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Backgrounds")]
        public string ImageDir {
            get {
                return ((string)(this["ImageDir"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PraiseBase Presenter")]
        public string DataDirDefaultName {
            get {
                return ((string)(this["DataDirDefaultName"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Calibri, 39.75pt, style=Italic")]
        public global::System.Drawing.Font ProjectionMasterFontTranslation {
            get {
                return ((global::System.Drawing.Font)(this["ProjectionMasterFontTranslation"]));
            }
            set {
                this["ProjectionMasterFontTranslation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ProjectionMasterLineSpacing {
            get {
                return ((int)(this["ProjectionMasterLineSpacing"]));
            }
            set {
                this["ProjectionMasterLineSpacing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color ProjectionMasterTranslationColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionMasterTranslationColor"]));
            }
            set {
                this["ProjectionMasterTranslationColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SettingsLastTabIndex {
            get {
                return ((int)(this["SettingsLastTabIndex"]));
            }
            set {
                this["SettingsLastTabIndex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color ProjectionShadowColor {
            get {
                return ((global::System.Drawing.Color)(this["ProjectionShadowColor"]));
            }
            set {
                this["ProjectionShadowColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ProjectionOutlineSize {
            get {
                return ((int)(this["ProjectionOutlineSize"]));
            }
            set {
                this["ProjectionOutlineSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public int ProjectionShadowSize {
            get {
                return ((int)(this["ProjectionShadowSize"]));
            }
            set {
                this["ProjectionShadowSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ProjectionUseMaster {
            get {
                return ((bool)(this["ProjectionUseMaster"]));
            }
            set {
                this["ProjectionUseMaster"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState ViewerWindowState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["ViewerWindowState"]));
            }
            set {
                this["ViewerWindowState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState EditorWindowState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["EditorWindowState"]));
            }
            set {
                this["EditorWindowState"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.10.7.1")]
        public string Version {
            get {
                return ((string)(this["Version"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://code.google.com/p/praisebasepresenter")]
        public string Weburl {
            get {
                return ((string)(this["Weburl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Setlists")]
        public string SetListDir {
            get {
                return ((string)(this["SetListDir"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ProjectionFadeTime {
            get {
                return ((int)(this["ProjectionFadeTime"]));
            }
            set {
                this["ProjectionFadeTime"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://code.google.com/p/praisebasepresenter/issues/entry?template=Defect%20repor" +
            "t%20from%20user")]
        public string BugReportUrl {
            get {
                return ((string)(this["BugReportUrl"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("90, 60")]
        public global::System.Drawing.Size ThumbSize {
            get {
                return ((global::System.Drawing.Size)(this["ThumbSize"]));
            }
            set {
                this["ThumbSize"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Thumbs")]
        public string ThumbDir {
            get {
                return ((string)(this["ThumbDir"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowLoadingScreen {
            get {
                return ((bool)(this["ShowLoadingScreen"]));
            }
            set {
                this["ShowLoadingScreen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LinkLayers {
            get {
                return ((bool)(this["LinkLayers"]));
            }
            set {
                this["LinkLayers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.ArrayList ImageFavorites {
            get {
                return ((global::System.Collections.ArrayList)(this["ImageFavorites"]));
            }
            set {
                this["ImageFavorites"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://code.google.com/p/praisebasepresenter/w/list")]
        public string HelpUrl {
            get {
                return ((string)(this["HelpUrl"]));
            }
            set {
                this["HelpUrl"] = value;
            }
        }
    }
}
