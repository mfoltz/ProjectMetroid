// Decompiled with JetBrains decompiler
// Type: ProjectM.AiMoveComponent
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class AiMoveComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MovePattern;
    private static readonly IntPtr NativeFieldInfoPtr_CircleChangeDirectionFrequencyMin;
    private static readonly IntPtr NativeFieldInfoPtr_CircleChangeDirectionFrequencyMax;
    private static readonly IntPtr NativeFieldInfoPtr_OnlyChangeCircleDirectionOnCast;
    private static readonly IntPtr NativeFieldInfoPtr_ForceLookAtTarget;
    private static readonly IntPtr NativeFieldInfoPtr_CircleCurveInRange;
    private static readonly IntPtr NativeFieldInfoPtr_CircleCurveOutOfRange;
    private static readonly IntPtr NativeFieldInfoPtr_TargetMinDistance;
    private static readonly IntPtr NativeFieldInfoPtr_TargetGoalDistance;
    private static readonly IntPtr NativeFieldInfoPtr_TargetGoalDistanceOuter;
    private static readonly IntPtr NativeFieldInfoPtr_TargetMaxDistance;
    private static readonly IntPtr NativeFieldInfoPtr_UltraHighPriority;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShouldAlertAllies_Private_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsFleeing_Private_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddMiscAiGameplayData_Private_Void_Entity_EntityManager_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_PrefabGUID_Unit_StatsSettings_Asset_PDM_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322078, XrefRangeEnd = 1322147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AiMoveComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322147, XrefRangeEnd = 1322159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ShouldAlertAllies()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveComponent.NativeMethodInfoPtr_ShouldAlertAllies_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322159, XrefRangeEnd = 1322170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsFleeing()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveComponent.NativeMethodInfoPtr_IsFleeing_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1322202, RefRangeEnd = 1322203, XrefRangeStart = 1322170, XrefRangeEnd = 1322202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddMiscAiGameplayData(Entity entity, EntityManager dstManager)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveComponent.NativeMethodInfoPtr_AddMiscAiGameplayData_Private_Void_Entity_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322203, XrefRangeEnd = 1322207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AiMoveComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322207, XrefRangeEnd = 1322208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AiMoveComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AiMoveComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1322208, XrefRangeEnd = 1322215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PrefabGUID Method_Internal_Static_PrefabGUID_Unit_StatsSettings_Asset_PDM_0(
      Unit_StatsSettings_Asset asset)
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiMoveComponent.NativeMethodInfoPtr_Method_Internal_Static_PrefabGUID_Unit_StatsSettings_Asset_PDM_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AiMoveComponent()
    {
      Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM", nameof (AiMoveComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr);
      AiMoveComponent.NativeFieldInfoPtr_MovePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (MovePattern));
      AiMoveComponent.NativeFieldInfoPtr_CircleChangeDirectionFrequencyMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (CircleChangeDirectionFrequencyMin));
      AiMoveComponent.NativeFieldInfoPtr_CircleChangeDirectionFrequencyMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (CircleChangeDirectionFrequencyMax));
      AiMoveComponent.NativeFieldInfoPtr_OnlyChangeCircleDirectionOnCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (OnlyChangeCircleDirectionOnCast));
      AiMoveComponent.NativeFieldInfoPtr_ForceLookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (ForceLookAtTarget));
      AiMoveComponent.NativeFieldInfoPtr_CircleCurveInRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (CircleCurveInRange));
      AiMoveComponent.NativeFieldInfoPtr_CircleCurveOutOfRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (CircleCurveOutOfRange));
      AiMoveComponent.NativeFieldInfoPtr_TargetMinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (TargetMinDistance));
      AiMoveComponent.NativeFieldInfoPtr_TargetGoalDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (TargetGoalDistance));
      AiMoveComponent.NativeFieldInfoPtr_TargetGoalDistanceOuter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (TargetGoalDistanceOuter));
      AiMoveComponent.NativeFieldInfoPtr_TargetMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (TargetMaxDistance));
      AiMoveComponent.NativeFieldInfoPtr_UltraHighPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, nameof (UltraHighPriority));
      AiMoveComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, 100663474);
      AiMoveComponent.NativeMethodInfoPtr_ShouldAlertAllies_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, 100663475);
      AiMoveComponent.NativeMethodInfoPtr_IsFleeing_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, 100663476);
      AiMoveComponent.NativeMethodInfoPtr_AddMiscAiGameplayData_Private_Void_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, 100663477);
      AiMoveComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, 100663478);
      AiMoveComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, 100663479);
      AiMoveComponent.NativeMethodInfoPtr_Method_Internal_Static_PrefabGUID_Unit_StatsSettings_Asset_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiMoveComponent>.NativeClassPtr, 100663480);
    }

    public AiMoveComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AiMovePattern MovePattern
    {
      get
      {
        return *(AiMovePattern*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_MovePattern));
      }
      [param: In] set
      {
        *(AiMovePattern*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_MovePattern)) = value;
      }
    }

    public unsafe float CircleChangeDirectionFrequencyMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_CircleChangeDirectionFrequencyMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_CircleChangeDirectionFrequencyMin)) = value;
      }
    }

    public unsafe float CircleChangeDirectionFrequencyMax
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_CircleChangeDirectionFrequencyMax));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_CircleChangeDirectionFrequencyMax)) = value;
      }
    }

    public unsafe bool OnlyChangeCircleDirectionOnCast
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_OnlyChangeCircleDirectionOnCast));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_OnlyChangeCircleDirectionOnCast)) = value;
      }
    }

    public unsafe AiForceLookAtTarget ForceLookAtTarget
    {
      get
      {
        return *(AiForceLookAtTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_ForceLookAtTarget));
      }
      [param: In] set
      {
        *(AiForceLookAtTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_ForceLookAtTarget)) = value;
      }
    }

    public unsafe CurveReference CircleCurveInRange
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_CircleCurveInRange));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_CircleCurveInRange)) = value;
      }
    }

    public unsafe CurveReference CircleCurveOutOfRange
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_CircleCurveOutOfRange));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_CircleCurveOutOfRange)) = value;
      }
    }

    public unsafe float TargetMinDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_TargetMinDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_TargetMinDistance)) = value;
      }
    }

    public unsafe float TargetGoalDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_TargetGoalDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_TargetGoalDistance)) = value;
      }
    }

    public unsafe float TargetGoalDistanceOuter
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_TargetGoalDistanceOuter));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_TargetGoalDistanceOuter)) = value;
      }
    }

    public unsafe float TargetMaxDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_TargetMaxDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_TargetMaxDistance)) = value;
      }
    }

    public unsafe bool UltraHighPriority
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_UltraHighPriority));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AiMoveComponent.NativeFieldInfoPtr_UltraHighPriority)) = value;
      }
    }
  }
}
