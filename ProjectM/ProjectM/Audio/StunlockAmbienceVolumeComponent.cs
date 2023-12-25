// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StunlockAmbienceVolumeComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Audio
{
  [Serializable]
  public class StunlockAmbienceVolumeComponent : VolumeComponent
  {
    private static readonly IntPtr NativeFieldInfoPtr_Asset;
    private static readonly IntPtr NativeFieldInfoPtr_IndoorAsset;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144462, XrefRangeEnd = 1144480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunlockAmbienceVolumeComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunlockAmbienceVolumeComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunlockAmbienceVolumeComponent.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144480, XrefRangeEnd = 1144483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunlockAmbienceVolumeComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static StunlockAmbienceVolumeComponent()
    {
      Il2CppClassPointerStore<StunlockAmbienceVolumeComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StunlockAmbienceVolumeComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunlockAmbienceVolumeComponent>.NativeClassPtr);
      StunlockAmbienceVolumeComponent.NativeFieldInfoPtr_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunlockAmbienceVolumeComponent>.NativeClassPtr, nameof (Asset));
      StunlockAmbienceVolumeComponent.NativeFieldInfoPtr_IndoorAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunlockAmbienceVolumeComponent>.NativeClassPtr, nameof (IndoorAsset));
      StunlockAmbienceVolumeComponent.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunlockAmbienceVolumeComponent>.NativeClassPtr, 100690592);
      StunlockAmbienceVolumeComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunlockAmbienceVolumeComponent>.NativeClassPtr, 100690593);
    }

    public StunlockAmbienceVolumeComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe VolumeParameter<StunlockMusicAmbienceAsset> Asset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunlockAmbienceVolumeComponent.NativeFieldInfoPtr_Asset));
        return pointer == IntPtr.Zero ? (VolumeParameter<StunlockMusicAmbienceAsset>) null : new VolumeParameter<StunlockMusicAmbienceAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunlockAmbienceVolumeComponent.NativeFieldInfoPtr_Asset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VolumeParameter<StunlockIndoorAmbienceAsset> IndoorAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunlockAmbienceVolumeComponent.NativeFieldInfoPtr_IndoorAsset));
        return pointer == IntPtr.Zero ? (VolumeParameter<StunlockIndoorAmbienceAsset>) null : new VolumeParameter<StunlockIndoorAmbienceAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunlockAmbienceVolumeComponent.NativeFieldInfoPtr_IndoorAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
