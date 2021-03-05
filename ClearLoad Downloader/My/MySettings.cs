// Decompiled with JetBrains decompiler
// Type: Downloader.My.MySettings
// Assembly: Downloader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB94EAB6-C9A9-4A4F-9FDA-81A0C74F9286
// Assembly location: C:\Program Files (x86)\ClearLoad Downloader\ClearLoad Downloader.exe

using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Downloader.My
{
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [CompilerGenerated]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());
    private static bool addedHandler;
    private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DebuggerNonUserCode]
    private static void AutoSaveSettings(object sender, EventArgs e)
    {
      if (!MyProject.Application.SaveMySettingsOnExit)
        return;
      MySettingsProperty.Settings.Save();
    }

    public static MySettings Default
    {
      get
      {
        if (!MySettings.addedHandler)
        {
          object handlerLockObject = MySettings.addedHandlerLockObject;
          ObjectFlowControl.CheckForSyncLockOnValueType(handlerLockObject);
          bool lockTaken = false;
          try
          {
            Monitor.Enter(handlerLockObject, ref lockTaken);
            if (!MySettings.addedHandler)
            {
              MyProject.Application.Shutdown += (ShutdownEventHandler) ((sender, e) =>
              {
                if (!MyProject.Application.SaveMySettingsOnExit)
                  return;
                MySettingsProperty.Settings.Save();
              });
              MySettings.addedHandler = true;
            }
          }
          finally
          {
            if (lockTaken)
              Monitor.Exit(handlerLockObject);
          }
        }
        return MySettings.defaultInstance;
      }
    }
  }
}
