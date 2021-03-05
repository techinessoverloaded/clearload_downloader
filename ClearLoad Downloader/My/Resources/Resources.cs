// Decompiled with JetBrains decompiler
// Type: Downloader.My.Resources.Resources
// Assembly: Downloader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB94EAB6-C9A9-4A4F-9FDA-81A0C74F9286
// Assembly location: C:\Program Files (x86)\ClearLoad Downloader\ClearLoad Downloader.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Downloader.My.Resources
{
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [CompilerGenerated]
  [HideModuleName]
  [StandardModule]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) Downloader.My.Resources.Resources.resourceMan, (object) null))
          Downloader.My.Resources.Resources.resourceMan = new ResourceManager("Downloader.Resources", typeof (Downloader.My.Resources.Resources).Assembly);
        return Downloader.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Downloader.My.Resources.Resources.resourceCulture;
      set => Downloader.My.Resources.Resources.resourceCulture = value;
    }
  }
}
