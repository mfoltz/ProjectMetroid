// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.AntiCheatCommonInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  public sealed class AntiCheatCommonInterface : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LogeventApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogeventStringMaxLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoggameroundendApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoggameroundstartApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogplayerdespawnApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogplayerreviveApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogplayerspawnApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogplayertakedamageApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogplayertickApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogplayeruseabilityApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogplayeruseweaponApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogplayeruseweaponWeaponnameMaxLength;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegistereventApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegistereventCustomeventbase;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegistereventMaxParamdefscount;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetclientdetailsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetgamesessionidApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AntiCheatCommonInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AntiCheatCommonInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AntiCheatCommonInterface()
    {
      Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (AntiCheatCommonInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr);
      AntiCheatCommonInterface.NativeFieldInfoPtr_LogeventApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LogeventApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_LogeventStringMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LogeventStringMaxLength));
      AntiCheatCommonInterface.NativeFieldInfoPtr_LoggameroundendApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LoggameroundendApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_LoggameroundstartApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LoggameroundstartApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayerdespawnApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LogplayerdespawnApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayerreviveApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LogplayerreviveApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayerspawnApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LogplayerspawnApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayertakedamageApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LogplayertakedamageApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayertickApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LogplayertickApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayeruseabilityApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LogplayeruseabilityApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayeruseweaponApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LogplayeruseweaponApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayeruseweaponWeaponnameMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (LogplayeruseweaponWeaponnameMaxLength));
      AntiCheatCommonInterface.NativeFieldInfoPtr_RegistereventApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (RegistereventApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_RegistereventCustomeventbase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (RegistereventCustomeventbase));
      AntiCheatCommonInterface.NativeFieldInfoPtr_RegistereventMaxParamdefscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (RegistereventMaxParamdefscount));
      AntiCheatCommonInterface.NativeFieldInfoPtr_SetclientdetailsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (SetclientdetailsApiLatest));
      AntiCheatCommonInterface.NativeFieldInfoPtr_SetgamesessionidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, nameof (SetgamesessionidApiLatest));
      AntiCheatCommonInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiCheatCommonInterface>.NativeClassPtr, 100673925);
    }

    public AntiCheatCommonInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int LogeventApiLatest
    {
      get
      {
        int logeventApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogeventApiLatest, (void*) &logeventApiLatest);
        return logeventApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogeventApiLatest, (void*) &value);
      }
    }

    public static unsafe int LogeventStringMaxLength
    {
      get
      {
        int logeventStringMaxLength;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogeventStringMaxLength, (void*) &logeventStringMaxLength);
        return logeventStringMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogeventStringMaxLength, (void*) &value);
      }
    }

    public static unsafe int LoggameroundendApiLatest
    {
      get
      {
        int loggameroundendApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LoggameroundendApiLatest, (void*) &loggameroundendApiLatest);
        return loggameroundendApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LoggameroundendApiLatest, (void*) &value);
      }
    }

    public static unsafe int LoggameroundstartApiLatest
    {
      get
      {
        int loggameroundstartApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LoggameroundstartApiLatest, (void*) &loggameroundstartApiLatest);
        return loggameroundstartApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LoggameroundstartApiLatest, (void*) &value);
      }
    }

    public static unsafe int LogplayerdespawnApiLatest
    {
      get
      {
        int logplayerdespawnApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayerdespawnApiLatest, (void*) &logplayerdespawnApiLatest);
        return logplayerdespawnApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayerdespawnApiLatest, (void*) &value);
      }
    }

    public static unsafe int LogplayerreviveApiLatest
    {
      get
      {
        int logplayerreviveApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayerreviveApiLatest, (void*) &logplayerreviveApiLatest);
        return logplayerreviveApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayerreviveApiLatest, (void*) &value);
      }
    }

    public static unsafe int LogplayerspawnApiLatest
    {
      get
      {
        int logplayerspawnApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayerspawnApiLatest, (void*) &logplayerspawnApiLatest);
        return logplayerspawnApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayerspawnApiLatest, (void*) &value);
      }
    }

    public static unsafe int LogplayertakedamageApiLatest
    {
      get
      {
        int logplayertakedamageApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayertakedamageApiLatest, (void*) &logplayertakedamageApiLatest);
        return logplayertakedamageApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayertakedamageApiLatest, (void*) &value);
      }
    }

    public static unsafe int LogplayertickApiLatest
    {
      get
      {
        int logplayertickApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayertickApiLatest, (void*) &logplayertickApiLatest);
        return logplayertickApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayertickApiLatest, (void*) &value);
      }
    }

    public static unsafe int LogplayeruseabilityApiLatest
    {
      get
      {
        int logplayeruseabilityApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayeruseabilityApiLatest, (void*) &logplayeruseabilityApiLatest);
        return logplayeruseabilityApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayeruseabilityApiLatest, (void*) &value);
      }
    }

    public static unsafe int LogplayeruseweaponApiLatest
    {
      get
      {
        int logplayeruseweaponApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayeruseweaponApiLatest, (void*) &logplayeruseweaponApiLatest);
        return logplayeruseweaponApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayeruseweaponApiLatest, (void*) &value);
      }
    }

    public static unsafe int LogplayeruseweaponWeaponnameMaxLength
    {
      get
      {
        int weaponnameMaxLength;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayeruseweaponWeaponnameMaxLength, (void*) &weaponnameMaxLength);
        return weaponnameMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_LogplayeruseweaponWeaponnameMaxLength, (void*) &value);
      }
    }

    public static unsafe int RegistereventApiLatest
    {
      get
      {
        int registereventApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_RegistereventApiLatest, (void*) &registereventApiLatest);
        return registereventApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_RegistereventApiLatest, (void*) &value);
      }
    }

    public static unsafe int RegistereventCustomeventbase
    {
      get
      {
        int registereventCustomeventbase;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_RegistereventCustomeventbase, (void*) &registereventCustomeventbase);
        return registereventCustomeventbase;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_RegistereventCustomeventbase, (void*) &value);
      }
    }

    public static unsafe int RegistereventMaxParamdefscount
    {
      get
      {
        int maxParamdefscount;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_RegistereventMaxParamdefscount, (void*) &maxParamdefscount);
        return maxParamdefscount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_RegistereventMaxParamdefscount, (void*) &value);
      }
    }

    public static unsafe int SetclientdetailsApiLatest
    {
      get
      {
        int setclientdetailsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_SetclientdetailsApiLatest, (void*) &setclientdetailsApiLatest);
        return setclientdetailsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_SetclientdetailsApiLatest, (void*) &value);
      }
    }

    public static unsafe int SetgamesessionidApiLatest
    {
      get
      {
        int setgamesessionidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AntiCheatCommonInterface.NativeFieldInfoPtr_SetgamesessionidApiLatest, (void*) &setgamesessionidApiLatest);
        return setgamesessionidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AntiCheatCommonInterface.NativeFieldInfoPtr_SetgamesessionidApiLatest, (void*) &value);
      }
    }
  }
}
