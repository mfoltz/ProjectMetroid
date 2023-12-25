// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StunlockMusicVolumeComponent
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
  public class StunlockMusicVolumeComponent : VolumeComponent
  {
    private static readonly IntPtr NativeFieldInfoPtr_Asset;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144483, XrefRangeEnd = 1144494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunlockMusicVolumeComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunlockMusicVolumeComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunlockMusicVolumeComponent.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144494, XrefRangeEnd = 1144497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunlockMusicVolumeComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static StunlockMusicVolumeComponent()
    {
      Il2CppClassPointerStore<StunlockMusicVolumeComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StunlockMusicVolumeComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunlockMusicVolumeComponent>.NativeClassPtr);
      StunlockMusicVolumeComponent.NativeFieldInfoPtr_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunlockMusicVolumeComponent>.NativeClassPtr, nameof (Asset));
      StunlockMusicVolumeComponent.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunlockMusicVolumeComponent>.NativeClassPtr, 100690596);
      StunlockMusicVolumeComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunlockMusicVolumeComponent>.NativeClassPtr, 100690597);
    }

    public StunlockMusicVolumeComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe VolumeParameter<StunlockMusicAmbienceAsset> Asset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunlockMusicVolumeComponent.NativeFieldInfoPtr_Asset));
        return pointer == IntPtr.Zero ? (VolumeParameter<StunlockMusicAmbienceAsset>) null : new VolumeParameter<StunlockMusicAmbienceAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunlockMusicVolumeComponent.NativeFieldInfoPtr_Asset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
