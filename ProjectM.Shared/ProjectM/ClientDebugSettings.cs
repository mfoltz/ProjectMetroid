// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientDebugSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ClientDebugSettings : SettingsBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultPath;
    private static readonly IntPtr NativeFieldInfoPtr_LocalPath;
    private static readonly IntPtr NativeFieldInfoPtr_LIMIT_FPS_MIN;
    private static readonly IntPtr NativeFieldInfoPtr_LIMIT_FPS_MAX;
    private static readonly IntPtr NativeFieldInfoPtr_SCREENSHAKE_MIN;
    private static readonly IntPtr NativeFieldInfoPtr_SCREENSHAKE_MAX;
    private static readonly IntPtr NativeFieldInfoPtr_EnableLineOfSight;
    private static readonly IntPtr NativeFieldInfoPtr_RevealedMap;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748566, XrefRangeEnd = 748571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientDebugSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientDebugSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientDebugSettings()
    {
      Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ClientDebugSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr);
      ClientDebugSettings.NativeFieldInfoPtr_DefaultPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr, nameof (DefaultPath));
      ClientDebugSettings.NativeFieldInfoPtr_LocalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr, nameof (LocalPath));
      ClientDebugSettings.NativeFieldInfoPtr_LIMIT_FPS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr, nameof (LIMIT_FPS_MIN));
      ClientDebugSettings.NativeFieldInfoPtr_LIMIT_FPS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr, nameof (LIMIT_FPS_MAX));
      ClientDebugSettings.NativeFieldInfoPtr_SCREENSHAKE_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr, nameof (SCREENSHAKE_MIN));
      ClientDebugSettings.NativeFieldInfoPtr_SCREENSHAKE_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr, nameof (SCREENSHAKE_MAX));
      ClientDebugSettings.NativeFieldInfoPtr_EnableLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr, nameof (EnableLineOfSight));
      ClientDebugSettings.NativeFieldInfoPtr_RevealedMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr, nameof (RevealedMap));
      ClientDebugSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientDebugSettings>.NativeClassPtr, 100665903);
    }

    public ClientDebugSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string DefaultPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ClientDebugSettings.NativeFieldInfoPtr_DefaultPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientDebugSettings.NativeFieldInfoPtr_DefaultPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string LocalPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ClientDebugSettings.NativeFieldInfoPtr_LocalPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientDebugSettings.NativeFieldInfoPtr_LocalPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe int LIMIT_FPS_MIN
    {
      get
      {
        int limitFpsMin;
        IL2CPP.il2cpp_field_static_get_value(ClientDebugSettings.NativeFieldInfoPtr_LIMIT_FPS_MIN, (void*) &limitFpsMin);
        return limitFpsMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientDebugSettings.NativeFieldInfoPtr_LIMIT_FPS_MIN, (void*) &value);
      }
    }

    public static unsafe int LIMIT_FPS_MAX
    {
      get
      {
        int limitFpsMax;
        IL2CPP.il2cpp_field_static_get_value(ClientDebugSettings.NativeFieldInfoPtr_LIMIT_FPS_MAX, (void*) &limitFpsMax);
        return limitFpsMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientDebugSettings.NativeFieldInfoPtr_LIMIT_FPS_MAX, (void*) &value);
      }
    }

    public static unsafe float SCREENSHAKE_MIN
    {
      get
      {
        float screenshakeMin;
        IL2CPP.il2cpp_field_static_get_value(ClientDebugSettings.NativeFieldInfoPtr_SCREENSHAKE_MIN, (void*) &screenshakeMin);
        return screenshakeMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientDebugSettings.NativeFieldInfoPtr_SCREENSHAKE_MIN, (void*) &value);
      }
    }

    public static unsafe float SCREENSHAKE_MAX
    {
      get
      {
        float screenshakeMax;
        IL2CPP.il2cpp_field_static_get_value(ClientDebugSettings.NativeFieldInfoPtr_SCREENSHAKE_MAX, (void*) &screenshakeMax);
        return screenshakeMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientDebugSettings.NativeFieldInfoPtr_SCREENSHAKE_MAX, (void*) &value);
      }
    }

    public unsafe bool EnableLineOfSight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientDebugSettings.NativeFieldInfoPtr_EnableLineOfSight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientDebugSettings.NativeFieldInfoPtr_EnableLineOfSight)) = value;
      }
    }

    public unsafe bool RevealedMap
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientDebugSettings.NativeFieldInfoPtr_RevealedMap));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientDebugSettings.NativeFieldInfoPtr_RevealedMap)) = value;
      }
    }
  }
}
