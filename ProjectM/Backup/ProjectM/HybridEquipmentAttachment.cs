// Decompiled with JetBrains decompiler
// Type: ProjectM.HybridEquipmentAttachment
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class HybridEquipmentAttachment : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TargetBone;
    private static readonly IntPtr NativeFieldInfoPtr_LocalTranslationOffset;
    private static readonly IntPtr NativeFieldInfoPtr_LocalRotationOffset;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044901, XrefRangeEnd = 1044904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridEquipmentAttachment()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridEquipmentAttachment>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridEquipmentAttachment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridEquipmentAttachment()
    {
      Il2CppClassPointerStore<HybridEquipmentAttachment>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HybridEquipmentAttachment));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridEquipmentAttachment>.NativeClassPtr);
      HybridEquipmentAttachment.NativeFieldInfoPtr_TargetBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentAttachment>.NativeClassPtr, nameof (TargetBone));
      HybridEquipmentAttachment.NativeFieldInfoPtr_LocalTranslationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentAttachment>.NativeClassPtr, nameof (LocalTranslationOffset));
      HybridEquipmentAttachment.NativeFieldInfoPtr_LocalRotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridEquipmentAttachment>.NativeClassPtr, nameof (LocalRotationOffset));
      HybridEquipmentAttachment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridEquipmentAttachment>.NativeClassPtr, 100681872);
    }

    public HybridEquipmentAttachment(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HybridBoneEnum TargetBone
    {
      get
      {
        return *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentAttachment.NativeFieldInfoPtr_TargetBone));
      }
      [param: In] set
      {
        *(HybridBoneEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentAttachment.NativeFieldInfoPtr_TargetBone)) = value;
      }
    }

    public unsafe Vector3 LocalTranslationOffset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentAttachment.NativeFieldInfoPtr_LocalTranslationOffset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentAttachment.NativeFieldInfoPtr_LocalTranslationOffset)) = value;
      }
    }

    public unsafe Vector3 LocalRotationOffset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentAttachment.NativeFieldInfoPtr_LocalRotationOffset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridEquipmentAttachment.NativeFieldInfoPtr_LocalRotationOffset)) = value;
      }
    }
  }
}
