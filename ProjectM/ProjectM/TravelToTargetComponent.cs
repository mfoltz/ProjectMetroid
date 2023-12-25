// Decompiled with JetBrains decompiler
// Type: ProjectM.TravelToTargetComponent
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
  public class TravelToTargetComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_Offset;
    private static readonly IntPtr NativeFieldInfoPtr_OffsetType;
    private static readonly IntPtr NativeFieldInfoPtr_FetchLocationFirstFrame;
    private static readonly IntPtr NativeFieldInfoPtr_YOffset;
    private static readonly IntPtr NativeFieldInfoPtr_TravelSpeedBasedOnDistance;
    private static readonly IntPtr NativeFieldInfoPtr_MinimumDuration;
    private static readonly IntPtr NativeFieldInfoPtr_UseVisualOffset;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002284, XrefRangeEnd = 1002300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TravelToTargetComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002300, XrefRangeEnd = 1002304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TravelToTargetComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TravelToTargetComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TravelToTargetComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TravelToTargetComponent()
    {
      Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TravelToTargetComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr);
      TravelToTargetComponent.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr, nameof (Curve));
      TravelToTargetComponent.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr, nameof (Offset));
      TravelToTargetComponent.NativeFieldInfoPtr_OffsetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr, nameof (OffsetType));
      TravelToTargetComponent.NativeFieldInfoPtr_FetchLocationFirstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr, nameof (FetchLocationFirstFrame));
      TravelToTargetComponent.NativeFieldInfoPtr_YOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr, nameof (YOffset));
      TravelToTargetComponent.NativeFieldInfoPtr_TravelSpeedBasedOnDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr, nameof (TravelSpeedBasedOnDistance));
      TravelToTargetComponent.NativeFieldInfoPtr_MinimumDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr, nameof (MinimumDuration));
      TravelToTargetComponent.NativeFieldInfoPtr_UseVisualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr, nameof (UseVisualOffset));
      TravelToTargetComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr, 100677640);
      TravelToTargetComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr, 100677641);
      TravelToTargetComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelToTargetComponent>.NativeClassPtr, 100677642);
    }

    public TravelToTargetComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CurveReference Curve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_Curve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_Curve)) = value;
      }
    }

    public unsafe float3 Offset
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_Offset));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_Offset)) = value;
      }
    }

    public unsafe TravelToTargetOffsetType OffsetType
    {
      get
      {
        return *(TravelToTargetOffsetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_OffsetType));
      }
      [param: In] set
      {
        *(TravelToTargetOffsetType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_OffsetType)) = value;
      }
    }

    public unsafe bool FetchLocationFirstFrame
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_FetchLocationFirstFrame));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_FetchLocationFirstFrame)) = value;
      }
    }

    public unsafe float YOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_YOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_YOffset)) = value;
      }
    }

    public unsafe float TravelSpeedBasedOnDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_TravelSpeedBasedOnDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_TravelSpeedBasedOnDistance)) = value;
      }
    }

    public unsafe float MinimumDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_MinimumDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_MinimumDuration)) = value;
      }
    }

    public unsafe bool UseVisualOffset
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_UseVisualOffset));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelToTargetComponent.NativeFieldInfoPtr_UseVisualOffset)) = value;
      }
    }
  }
}
