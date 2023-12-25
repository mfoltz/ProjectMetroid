// Decompiled with JetBrains decompiler
// Type: SoundImplementation.SoundUiTriggerComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SoundImplementation
{
  public class SoundUiTriggerComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_soundMapping;
    private static readonly IntPtr NativeFieldInfoPtr_clickSoundType;
    private static readonly IntPtr NativeFieldInfoPtr_hoverSoundType;
    private static readonly IntPtr NativeMethodInfoPtr_PlayClick_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_PlayHover_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164835, XrefRangeEnd = 1164842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SoundUiTriggerComponent.NativeMethodInfoPtr_PlayClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164842, XrefRangeEnd = 1164849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PlayHover()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SoundUiTriggerComponent.NativeMethodInfoPtr_PlayHover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SoundUiTriggerComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundUiTriggerComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SoundUiTriggerComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SoundUiTriggerComponent()
    {
      Il2CppClassPointerStore<SoundUiTriggerComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "SoundImplementation", nameof (SoundUiTriggerComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundUiTriggerComponent>.NativeClassPtr);
      SoundUiTriggerComponent.NativeFieldInfoPtr_soundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundUiTriggerComponent>.NativeClassPtr, nameof (soundMapping));
      SoundUiTriggerComponent.NativeFieldInfoPtr_clickSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundUiTriggerComponent>.NativeClassPtr, nameof (clickSoundType));
      SoundUiTriggerComponent.NativeFieldInfoPtr_hoverSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundUiTriggerComponent>.NativeClassPtr, nameof (hoverSoundType));
      SoundUiTriggerComponent.NativeMethodInfoPtr_PlayClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundUiTriggerComponent>.NativeClassPtr, 100692630);
      SoundUiTriggerComponent.NativeMethodInfoPtr_PlayHover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundUiTriggerComponent>.NativeClassPtr, 100692631);
      SoundUiTriggerComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundUiTriggerComponent>.NativeClassPtr, 100692632);
    }

    public SoundUiTriggerComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UISoundMapping soundMapping
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundUiTriggerComponent.NativeFieldInfoPtr_soundMapping));
        return pointer == IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SoundUiTriggerComponent.NativeFieldInfoPtr_soundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundType clickSoundType
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundUiTriggerComponent.NativeFieldInfoPtr_clickSoundType));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundUiTriggerComponent.NativeFieldInfoPtr_clickSoundType)) = value;
      }
    }

    public unsafe UISoundType hoverSoundType
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundUiTriggerComponent.NativeFieldInfoPtr_hoverSoundType));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SoundUiTriggerComponent.NativeFieldInfoPtr_hoverSoundType)) = value;
      }
    }
  }
}
