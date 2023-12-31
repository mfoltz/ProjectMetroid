// Decompiled with JetBrains decompiler
// Type: ProjectM.GameDataSettings
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
  public class GameDataSettings : SettingsBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultPath;
    private static readonly IntPtr NativeFieldInfoPtr_LocalPath;
    private static readonly IntPtr NativeFieldInfoPtr_ConversionMethod;
    private static readonly IntPtr NativeFieldInfoPtr_UseSubscenesForUI;
    private static readonly IntPtr NativeFieldInfoPtr_UseSubScenesForStreamingAssets;
    private static readonly IntPtr NativeFieldInfoPtr_EnableJewelSupportInConvertOnDemand;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 734941, RefRangeEnd = 734943, XrefRangeStart = 734936, XrefRangeEnd = 734941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameDataSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameDataSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameDataSettings()
    {
      Il2CppClassPointerStore<GameDataSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameDataSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataSettings>.NativeClassPtr);
      GameDataSettings.NativeFieldInfoPtr_DefaultPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSettings>.NativeClassPtr, nameof (DefaultPath));
      GameDataSettings.NativeFieldInfoPtr_LocalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSettings>.NativeClassPtr, nameof (LocalPath));
      GameDataSettings.NativeFieldInfoPtr_ConversionMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSettings>.NativeClassPtr, nameof (ConversionMethod));
      GameDataSettings.NativeFieldInfoPtr_UseSubscenesForUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSettings>.NativeClassPtr, nameof (UseSubscenesForUI));
      GameDataSettings.NativeFieldInfoPtr_UseSubScenesForStreamingAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSettings>.NativeClassPtr, nameof (UseSubScenesForStreamingAssets));
      GameDataSettings.NativeFieldInfoPtr_EnableJewelSupportInConvertOnDemand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataSettings>.NativeClassPtr, nameof (EnableJewelSupportInConvertOnDemand));
      GameDataSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataSettings>.NativeClassPtr, 100664904);
    }

    public GameDataSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string DefaultPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataSettings.NativeFieldInfoPtr_DefaultPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataSettings.NativeFieldInfoPtr_DefaultPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string LocalPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(GameDataSettings.NativeFieldInfoPtr_LocalPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameDataSettings.NativeFieldInfoPtr_LocalPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe PrefabConversionMethod ConversionMethod
    {
      get
      {
        return *(PrefabConversionMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSettings.NativeFieldInfoPtr_ConversionMethod));
      }
      [param: In] set
      {
        *(PrefabConversionMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSettings.NativeFieldInfoPtr_ConversionMethod)) = value;
      }
    }

    public unsafe bool UseSubscenesForUI
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSettings.NativeFieldInfoPtr_UseSubscenesForUI));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSettings.NativeFieldInfoPtr_UseSubscenesForUI)) = value;
      }
    }

    public unsafe bool UseSubScenesForStreamingAssets
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSettings.NativeFieldInfoPtr_UseSubScenesForStreamingAssets));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSettings.NativeFieldInfoPtr_UseSubScenesForStreamingAssets)) = value;
      }
    }

    public unsafe bool EnableJewelSupportInConvertOnDemand
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSettings.NativeFieldInfoPtr_EnableJewelSupportInConvertOnDemand));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameDataSettings.NativeFieldInfoPtr_EnableJewelSupportInConvertOnDemand)) = value;
      }
    }
  }
}
