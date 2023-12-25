// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.HybridMountComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Hybrid
{
  public class HybridMountComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_AttachmentPoint;
    private static readonly IntPtr NativeFieldInfoPtr_LeftHandAttachmentPoint;
    private static readonly IntPtr NativeFieldInfoPtr_RightHandAttachmentPoint;
    private static readonly IntPtr NativeFieldInfoPtr_MountColliders;
    private static readonly IntPtr NativeFieldInfoPtr_RiderBendOffsetDuringIdle;
    private static readonly IntPtr NativeFieldInfoPtr_RiderBendOffsetDuringTrot;
    private static readonly IntPtr NativeFieldInfoPtr_RiderBendOffsetDuringGallop;
    private static readonly IntPtr NativeFieldInfoPtr_RiderLeanStrength;
    private static readonly IntPtr NativeFieldInfoPtr_TrotVelocityThreshold;
    private static readonly IntPtr NativeFieldInfoPtr_GallopVelocityThreshold;
    private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddComponent(
      World world,
      PrefabLookupMap prefabLookupMap,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &prefabLookupMap;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &hybridEntity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridMountComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridMountComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridMountComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridMountComponent()
    {
      Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (HybridMountComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr);
      HybridMountComponent.NativeFieldInfoPtr_AttachmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, nameof (AttachmentPoint));
      HybridMountComponent.NativeFieldInfoPtr_LeftHandAttachmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, nameof (LeftHandAttachmentPoint));
      HybridMountComponent.NativeFieldInfoPtr_RightHandAttachmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, nameof (RightHandAttachmentPoint));
      HybridMountComponent.NativeFieldInfoPtr_MountColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, nameof (MountColliders));
      HybridMountComponent.NativeFieldInfoPtr_RiderBendOffsetDuringIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, nameof (RiderBendOffsetDuringIdle));
      HybridMountComponent.NativeFieldInfoPtr_RiderBendOffsetDuringTrot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, nameof (RiderBendOffsetDuringTrot));
      HybridMountComponent.NativeFieldInfoPtr_RiderBendOffsetDuringGallop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, nameof (RiderBendOffsetDuringGallop));
      HybridMountComponent.NativeFieldInfoPtr_RiderLeanStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, nameof (RiderLeanStrength));
      HybridMountComponent.NativeFieldInfoPtr_TrotVelocityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, nameof (TrotVelocityThreshold));
      HybridMountComponent.NativeFieldInfoPtr_GallopVelocityThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, nameof (GallopVelocityThreshold));
      HybridMountComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, 100692242);
      HybridMountComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridMountComponent>.NativeClassPtr, 100692243);
    }

    public HybridMountComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Transform AttachmentPoint
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_AttachmentPoint));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_AttachmentPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform LeftHandAttachmentPoint
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_LeftHandAttachmentPoint));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_LeftHandAttachmentPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform RightHandAttachmentPoint
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_RightHandAttachmentPoint));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_RightHandAttachmentPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<CapsuleCollider> MountColliders
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_MountColliders));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CapsuleCollider>) null : new Il2CppReferenceArray<CapsuleCollider>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_MountColliders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float RiderBendOffsetDuringIdle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_RiderBendOffsetDuringIdle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_RiderBendOffsetDuringIdle)) = value;
      }
    }

    public unsafe float RiderBendOffsetDuringTrot
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_RiderBendOffsetDuringTrot));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_RiderBendOffsetDuringTrot)) = value;
      }
    }

    public unsafe float RiderBendOffsetDuringGallop
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_RiderBendOffsetDuringGallop));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_RiderBendOffsetDuringGallop)) = value;
      }
    }

    public unsafe float RiderLeanStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_RiderLeanStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_RiderLeanStrength)) = value;
      }
    }

    public unsafe float TrotVelocityThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_TrotVelocityThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_TrotVelocityThreshold)) = value;
      }
    }

    public unsafe float GallopVelocityThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_GallopVelocityThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridMountComponent.NativeFieldInfoPtr_GallopVelocityThreshold)) = value;
      }
    }
  }
}
