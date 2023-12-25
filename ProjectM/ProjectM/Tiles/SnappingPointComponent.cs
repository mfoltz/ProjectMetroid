// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.SnappingPointComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Tiles
{
  public class SnappingPointComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SnapRotation;
    private static readonly IntPtr NativeFieldInfoPtr_AlternativePoint;
    private static readonly IntPtr NativeFieldInfoPtr_Radius;
    private static readonly IntPtr NativeFieldInfoPtr_LimitToPrefabSet;
    private static readonly IntPtr NativeFieldInfoPtr_Priority;
    private static readonly IntPtr NativeFieldInfoPtr_SnappingPointType;
    private static readonly IntPtr NativeFieldInfoPtr_OnlySnapToMatchingRotation;
    private static readonly IntPtr NativeFieldInfoPtr_OnlySnapToMatchingRotationOrMirrored;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 631690, RefRangeEnd = 631694, XrefRangeStart = 631690, XrefRangeEnd = 631694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SnappingPointComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SnappingPointComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SnappingPointComponent()
    {
      Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (SnappingPointComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr);
      SnappingPointComponent.NativeFieldInfoPtr_SnapRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr, nameof (SnapRotation));
      SnappingPointComponent.NativeFieldInfoPtr_AlternativePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr, nameof (AlternativePoint));
      SnappingPointComponent.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr, nameof (Radius));
      SnappingPointComponent.NativeFieldInfoPtr_LimitToPrefabSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr, nameof (LimitToPrefabSet));
      SnappingPointComponent.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr, nameof (Priority));
      SnappingPointComponent.NativeFieldInfoPtr_SnappingPointType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr, nameof (SnappingPointType));
      SnappingPointComponent.NativeFieldInfoPtr_OnlySnapToMatchingRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr, nameof (OnlySnapToMatchingRotation));
      SnappingPointComponent.NativeFieldInfoPtr_OnlySnapToMatchingRotationOrMirrored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr, nameof (OnlySnapToMatchingRotationOrMirrored));
      SnappingPointComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnappingPointComponent>.NativeClassPtr, 100685514);
    }

    public SnappingPointComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool SnapRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_SnapRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_SnapRotation)) = value;
      }
    }

    public unsafe Transform AlternativePoint
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_AlternativePoint));
        return pointer == IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_AlternativePoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_Radius)) = value;
      }
    }

    public unsafe PrefabSet LimitToPrefabSet
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_LimitToPrefabSet));
        return pointer == IntPtr.Zero ? (PrefabSet) null : new PrefabSet(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_LimitToPrefabSet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Priority
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_Priority));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_Priority)) = value;
      }
    }

    public unsafe SnappingPointType SnappingPointType
    {
      get
      {
        return *(SnappingPointType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_SnappingPointType));
      }
      [param: In] set
      {
        *(SnappingPointType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_SnappingPointType)) = value;
      }
    }

    public unsafe bool OnlySnapToMatchingRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_OnlySnapToMatchingRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_OnlySnapToMatchingRotation)) = value;
      }
    }

    public unsafe bool OnlySnapToMatchingRotationOrMirrored
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_OnlySnapToMatchingRotationOrMirrored));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SnappingPointComponent.NativeFieldInfoPtr_OnlySnapToMatchingRotationOrMirrored)) = value;
      }
    }
  }
}
