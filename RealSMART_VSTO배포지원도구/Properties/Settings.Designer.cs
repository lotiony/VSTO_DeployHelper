﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealSMART_VSTO배포지원도구.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<vstav3:postActions>
  <vstav3:postAction>
    <vstav3:entryPoint class=""VSTOInstaller.VSTOInstaller"">
      <assemblyIdentity name=""VSTOInstaller"" version=""1.2015.12.24"" language=""neutral"" processorArchitecture=""msil"" />
    </vstav3:entryPoint>
    <vstav3:postActionData>
    </vstav3:postActionData>
  </vstav3:postAction>
</vstav3:postActions>")]
        public string ManifestValue {
            get {
                return ((string)(this["ManifestValue"]));
            }
            set {
                this["ManifestValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\Tools\\LaunchDevCm" +
            "d.bat")]
        public string VsDevCmdPath {
            get {
                return ((string)(this["VsDevCmdPath"]));
            }
            set {
                this["VsDevCmdPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\dev\\KEDPI_KMIQ_N\\KEDPI_KMIQ\\KMIQ_Report\\KMIQ_Report_TemporaryKey.pfx")]
        public string CertFilePath {
            get {
                return ((string)(this["CertFilePath"]));
            }
            set {
                this["CertFilePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("smart1807")]
        public string CertFilePwd {
            get {
                return ((string)(this["CertFilePwd"]));
            }
            set {
                this["CertFilePwd"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("cd /d {0} & mage -sign \"{1}.dll.manifest\" -certfile \"{2}\" -pwd {3} & cd .. & cd ." +
            ". & mage -update \"{1}.vsto\" -appmanifest \"Application files\\{4}\\{1}.dll.manifest" +
            "\" -certfile \"{2}\" -pwd {3} & copy /Y {1}.vsto \"Application files\\{4}\\\"")]
        public string WorkString {
            get {
                return ((string)(this["WorkString"]));
            }
            set {
                this["WorkString"] = value;
            }
        }
    }
}
