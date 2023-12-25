// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningStrikeSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.LightningStorm
{
  [Serializable]
  public class LightningStrikeSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_PredictionTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScatterRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Void_byref_LightningStrikeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116794, XrefRangeEnd = 1116795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(ref LightningStrikeData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStrikeSettings.NativeMethodInfoPtr_Convert_Public_Void_byref_LightningStrikeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116795, XrefRangeEnd = 1116796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LightningStrikeSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightningStrikeSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LightningStrikeSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LightningStrikeSettings()
    {
      Il2CppClassPointerStore<LightningStrikeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningStrikeSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStrikeSettings>.NativeClassPtr);
      LightningStrikeSettings.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStrikeSettings>.NativeClassPtr, nameof (Weight));
      LightningStrikeSettings.NativeFieldInfoPtr_PredictionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStrikeSettings>.NativeClassPtr, nameof (PredictionTime));
      LightningStrikeSettings.NativeFieldInfoPtr_ScatterRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStrikeSettings>.NativeClassPtr, nameof (ScatterRadius));
      LightningStrikeSettings.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStrikeSettings>.NativeClassPtr, nameof (Prefab));
      LightningStrikeSettings.NativeMethodInfoPtr_Convert_Public_Void_byref_LightningStrikeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStrikeSettings>.NativeClassPtr, 100688499);
      LightningStrikeSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightningStrikeSettings>.NativeClassPtr, 100688500);
    }

    public LightningStrikeSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Weight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStrikeSettings.NativeFieldInfoPtr_Weight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStrikeSettings.NativeFieldInfoPtr_Weight)) = value;
      }
    }

    public unsafe float PredictionTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStrikeSettings.NativeFieldInfoPtr_PredictionTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStrikeSettings.NativeFieldInfoPtr_PredictionTime)) = value;
      }
    }

    public unsafe float ScatterRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStrikeSettings.NativeFieldInfoPtr_ScatterRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStrikeSettings.NativeFieldInfoPtr_ScatterRadius)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Prefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightningStrikeSettings.NativeFieldInfoPtr_Prefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightningStrikeSettings.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
