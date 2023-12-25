// Decompiled with JetBrains decompiler
// Type: ProjectM.ClaimAchievementSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ClaimAchievementSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly IntPtr NativeFieldInfoPtr__ProgressionDependencySystem;
    private static readonly IntPtr NativeFieldInfoPtr__ForceClaimQuery;
    private static readonly IntPtr NativeFieldInfoPtr__ClaimEventQuery;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_HandleEvent_Private_Void_PrefabGUID_FromCharacter_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_CompleteAchievement_Public_Void_PrefabGUID_Entity_Entity_Entity_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsUnlockedProgressionElementAlreadyAdded_Private_Boolean_DynamicBuffer_1_UnlockedProgressionElement_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsSubTaskCompleted_Private_Boolean_PrefabGUID_Int32_DynamicBuffer_1_AchievementInProgressElement_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996607, XrefRangeEnd = 996635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClaimAchievementSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996635, XrefRangeEnd = 996673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClaimAchievementSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 996727, RefRangeEnd = 996729, XrefRangeStart = 996673, XrefRangeEnd = 996727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleEvent(
      PrefabGUID claimAchievementGUID,
      FromCharacter fromCharacter,
      bool forceClaim)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &claimAchievementGUID;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &fromCharacter;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &forceClaim;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClaimAchievementSystem.NativeMethodInfoPtr_HandleEvent_Private_Void_PrefabGUID_FromCharacter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 996826, RefRangeEnd = 996831, XrefRangeStart = 996729, XrefRangeEnd = 996826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CompleteAchievement(
      PrefabGUID achievementPrefabGuid,
      Entity userEntity,
      Entity characterEntity,
      Entity achievementOwnerEntity,
      bool reApplyMode = false,
      bool logOnDuplicate = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[6];
      numPtr[0] = (IntPtr) &achievementPrefabGuid;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &userEntity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &characterEntity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &achievementOwnerEntity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &reApplyMode;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &logOnDuplicate;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClaimAchievementSystem.NativeMethodInfoPtr_CompleteAchievement_Public_Void_PrefabGUID_Entity_Entity_Entity_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996840, RefRangeEnd = 996841, XrefRangeStart = 996831, XrefRangeEnd = 996840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsUnlockedProgressionElementAlreadyAdded(
      DynamicBuffer<UnlockedProgressionElement> unlockedProgressionBuffer,
      PrefabGUID unlockedPrefab)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &unlockedProgressionBuffer;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &unlockedPrefab;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClaimAchievementSystem.NativeMethodInfoPtr_IsUnlockedProgressionElementAlreadyAdded_Private_Boolean_DynamicBuffer_1_UnlockedProgressionElement_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996850, RefRangeEnd = 996851, XrefRangeStart = 996841, XrefRangeEnd = 996850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSubTaskCompleted(
      PrefabGUID prefabGuid,
      int requiredCompletedCount,
      DynamicBuffer<AchievementInProgressElement> subAchievementInProgressList)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &prefabGuid;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &requiredCompletedCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &subAchievementInProgressList;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClaimAchievementSystem.NativeMethodInfoPtr_IsSubTaskCompleted_Private_Boolean_PrefabGUID_Int32_DynamicBuffer_1_AchievementInProgressElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClaimAchievementSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClaimAchievementSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClaimAchievementSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClaimAchievementSystem()
    {
      Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ClaimAchievementSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr);
      ClaimAchievementSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ClaimAchievementSystem.NativeFieldInfoPtr__ProgressionDependencySystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, nameof (_ProgressionDependencySystem));
      ClaimAchievementSystem.NativeFieldInfoPtr__ForceClaimQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, nameof (_ForceClaimQuery));
      ClaimAchievementSystem.NativeFieldInfoPtr__ClaimEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, nameof (_ClaimEventQuery));
      ClaimAchievementSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, 100677043);
      ClaimAchievementSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, 100677044);
      ClaimAchievementSystem.NativeMethodInfoPtr_HandleEvent_Private_Void_PrefabGUID_FromCharacter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, 100677045);
      ClaimAchievementSystem.NativeMethodInfoPtr_CompleteAchievement_Public_Void_PrefabGUID_Entity_Entity_Entity_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, 100677046);
      ClaimAchievementSystem.NativeMethodInfoPtr_IsUnlockedProgressionElementAlreadyAdded_Private_Boolean_DynamicBuffer_1_UnlockedProgressionElement_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, 100677047);
      ClaimAchievementSystem.NativeMethodInfoPtr_IsSubTaskCompleted_Private_Boolean_PrefabGUID_Int32_DynamicBuffer_1_AchievementInProgressElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, 100677048);
      ClaimAchievementSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, 100677049);
      ClaimAchievementSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClaimAchievementSystem>.NativeClassPtr, 100677050);
    }

    public ClaimAchievementSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClaimAchievementSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClaimAchievementSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ProgressionDependencySystem _ProgressionDependencySystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClaimAchievementSystem.NativeFieldInfoPtr__ProgressionDependencySystem));
        return pointer == IntPtr.Zero ? (ProgressionDependencySystem) null : new ProgressionDependencySystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClaimAchievementSystem.NativeFieldInfoPtr__ProgressionDependencySystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _ForceClaimQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClaimAchievementSystem.NativeFieldInfoPtr__ForceClaimQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClaimAchievementSystem.NativeFieldInfoPtr__ForceClaimQuery)) = value;
      }
    }

    public unsafe EntityQuery _ClaimEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClaimAchievementSystem.NativeFieldInfoPtr__ClaimEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClaimAchievementSystem.NativeFieldInfoPtr__ClaimEventQuery)) = value;
      }
    }
  }
}
