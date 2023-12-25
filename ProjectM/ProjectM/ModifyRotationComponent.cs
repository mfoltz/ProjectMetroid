// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyRotationComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public class ModifyRotationComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Type;
    private static readonly IntPtr NativeFieldInfoPtr_Value;
    private static readonly IntPtr NativeFieldInfoPtr_UseZeroAsDefaultForCurveRotation;
    private static readonly IntPtr NativeFieldInfoPtr_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_ActiveTimeline;
    private static readonly IntPtr NativeFieldInfoPtr_ForcedDirectionType;
    private static readonly IntPtr NativeFieldInfoPtr_SnapToDirectionOnSpawn;
    private static readonly IntPtr NativeFieldInfoPtr_OffsetRotation;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025056, XrefRangeEnd = 1025064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyRotationComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025064, XrefRangeEnd = 1025071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ModifyRotationComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModifyRotationComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyRotationComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModifyRotationComponent()
    {
      Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyRotationComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr);
      ModifyRotationComponent.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr, nameof (Type));
      ModifyRotationComponent.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr, nameof (Value));
      ModifyRotationComponent.NativeFieldInfoPtr_UseZeroAsDefaultForCurveRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr, nameof (UseZeroAsDefaultForCurveRotation));
      ModifyRotationComponent.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr, nameof (Curve));
      ModifyRotationComponent.NativeFieldInfoPtr_ActiveTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr, nameof (ActiveTimeline));
      ModifyRotationComponent.NativeFieldInfoPtr_ForcedDirectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr, nameof (ForcedDirectionType));
      ModifyRotationComponent.NativeFieldInfoPtr_SnapToDirectionOnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr, nameof (SnapToDirectionOnSpawn));
      ModifyRotationComponent.NativeFieldInfoPtr_OffsetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr, nameof (OffsetRotation));
      ModifyRotationComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr, 100680101);
      ModifyRotationComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr, 100680102);
      ModifyRotationComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyRotationComponent>.NativeClassPtr, 100680103);
    }

    public ModifyRotationComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RotationModificationType Type
    {
      get
      {
        return *(RotationModificationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(RotationModificationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe float Value
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_Value));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_Value)) = value;
      }
    }

    public unsafe bool UseZeroAsDefaultForCurveRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_UseZeroAsDefaultForCurveRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_UseZeroAsDefaultForCurveRotation)) = value;
      }
    }

    public unsafe CurveReference Curve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_Curve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_Curve)) = value;
      }
    }

    public unsafe MinMaxValue ActiveTimeline
    {
      get
      {
        return *(MinMaxValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_ActiveTimeline));
      }
      [param: In] set
      {
        *(MinMaxValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_ActiveTimeline)) = value;
      }
    }

    public unsafe TargetDirectionType ForcedDirectionType
    {
      get
      {
        return *(TargetDirectionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_ForcedDirectionType));
      }
      [param: In] set
      {
        *(TargetDirectionType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_ForcedDirectionType)) = value;
      }
    }

    public unsafe bool SnapToDirectionOnSpawn
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_SnapToDirectionOnSpawn));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_SnapToDirectionOnSpawn)) = value;
      }
    }

    public unsafe float3 OffsetRotation
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_OffsetRotation));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyRotationComponent.NativeFieldInfoPtr_OffsetRotation)) = value;
      }
    }
  }
}
