// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AchievementState
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.UI
{
  public class AchievementState : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementCollectionInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllVBloods;
    private static readonly System.IntPtr NativeFieldInfoPtr_SortedAchievements;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllEntriesData;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastAchievementOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementSubTasksInProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementSubTaskProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementsClaimed;
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementsCompleted;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrackVBloodEntry;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrackVBloodSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClosestVBloodSourceAchievement;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrackVBloodPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_TrackVBloodGhostBuffRemainingTime;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FullReset_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetAchievementState_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAchievementCompleted_Public_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAchievementClaimed_Public_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsDependencyClear_Public_Boolean_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsSubTaskCompleted_Public_Boolean_PrefabGUID_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSubTaskProgress_Public_Int32_PrefabGUID_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214717, XrefRangeEnd = 1214744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AchievementState(Allocator allocator)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementState>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementState.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214744, XrefRangeEnd = 1214754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FullReset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementState.NativeMethodInfoPtr_FullReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1214765, RefRangeEnd = 1214767, XrefRangeStart = 1214754, XrefRangeEnd = 1214765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetAchievementState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementState.NativeMethodInfoPtr_ResetAchievementState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1214770, RefRangeEnd = 1214772, XrefRangeStart = 1214767, XrefRangeEnd = 1214770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAchievementCompleted(PrefabGUID achievementGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &achievementGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementState.NativeMethodInfoPtr_IsAchievementCompleted_Public_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1214775, RefRangeEnd = 1214776, XrefRangeStart = 1214772, XrefRangeEnd = 1214775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsAchievementClaimed(PrefabGUID achievementGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &achievementGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementState.NativeMethodInfoPtr_IsAchievementClaimed_Public_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1214781, RefRangeEnd = 1214782, XrefRangeStart = 1214776, XrefRangeEnd = 1214781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsDependencyClear(PrefabGUID dependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &dependency;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementState.NativeMethodInfoPtr_IsDependencyClear_Public_Boolean_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214782, XrefRangeEnd = 1214796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1214799, RefRangeEnd = 1214800, XrefRangeStart = 1214796, XrefRangeEnd = 1214799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsSubTaskCompleted(PrefabGUID prefabGuid, int requiredCompletedCount)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &requiredCompletedCount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementState.NativeMethodInfoPtr_IsSubTaskCompleted_Public_Boolean_PrefabGUID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1214803, RefRangeEnd = 1214804, XrefRangeStart = 1214800, XrefRangeEnd = 1214803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetSubTaskProgress(PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementState.NativeMethodInfoPtr_GetSubTaskProgress_Public_Int32_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AchievementState()
    {
      Il2CppClassPointerStore<AchievementState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (AchievementState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementState>.NativeClassPtr);
      AchievementState.NativeFieldInfoPtr_AchievementCollectionInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (AchievementCollectionInitialized));
      AchievementState.NativeFieldInfoPtr_AllVBloods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (AllVBloods));
      AchievementState.NativeFieldInfoPtr_SortedAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (SortedAchievements));
      AchievementState.NativeFieldInfoPtr_AllEntriesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (AllEntriesData));
      AchievementState.NativeFieldInfoPtr_LastAchievementOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (LastAchievementOwner));
      AchievementState.NativeFieldInfoPtr_AchievementSubTasksInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (AchievementSubTasksInProgress));
      AchievementState.NativeFieldInfoPtr_AchievementSubTaskProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (AchievementSubTaskProgress));
      AchievementState.NativeFieldInfoPtr_AchievementsClaimed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (AchievementsClaimed));
      AchievementState.NativeFieldInfoPtr_AchievementsCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (AchievementsCompleted));
      AchievementState.NativeFieldInfoPtr_TrackVBloodEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (TrackVBloodEntry));
      AchievementState.NativeFieldInfoPtr_TrackVBloodSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (TrackVBloodSource));
      AchievementState.NativeFieldInfoPtr_ClosestVBloodSourceAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (ClosestVBloodSourceAchievement));
      AchievementState.NativeFieldInfoPtr_TrackVBloodPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (TrackVBloodPosition));
      AchievementState.NativeFieldInfoPtr_TrackVBloodGhostBuffRemainingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (TrackVBloodGhostBuffRemainingTime));
      AchievementState.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, 100664068);
      AchievementState.NativeMethodInfoPtr_FullReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, 100664069);
      AchievementState.NativeMethodInfoPtr_ResetAchievementState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, 100664070);
      AchievementState.NativeMethodInfoPtr_IsAchievementCompleted_Public_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, 100664071);
      AchievementState.NativeMethodInfoPtr_IsAchievementClaimed_Public_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, 100664072);
      AchievementState.NativeMethodInfoPtr_IsDependencyClear_Public_Boolean_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, 100664073);
      AchievementState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, 100664074);
      AchievementState.NativeMethodInfoPtr_IsSubTaskCompleted_Public_Boolean_PrefabGUID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, 100664075);
      AchievementState.NativeMethodInfoPtr_GetSubTaskProgress_Public_Int32_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, 100664076);
    }

    public AchievementState(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool AchievementCollectionInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AchievementCollectionInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AchievementCollectionInitialized)) = value;
      }
    }

    public unsafe NativeList<AchievementState.CachedVBloodData> AllVBloods
    {
      get
      {
        return *(NativeList<AchievementState.CachedVBloodData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AllVBloods));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AllVBloods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<AchievementState.CachedVBloodData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<AchievementEntryData> SortedAchievements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_SortedAchievements));
        return pointer == System.IntPtr.Zero ? (List<AchievementEntryData>) null : new List<AchievementEntryData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_SortedAchievements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AchievementEntryData> AllEntriesData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AllEntriesData));
        return pointer == System.IntPtr.Zero ? (List<AchievementEntryData>) null : new List<AchievementEntryData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AllEntriesData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity LastAchievementOwner
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_LastAchievementOwner));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_LastAchievementOwner)) = value;
      }
    }

    public unsafe NativeList<PrefabGUID> AchievementSubTasksInProgress
    {
      get
      {
        return *(NativeList<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AchievementSubTasksInProgress));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AchievementSubTasksInProgress), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<PrefabGUID, int> AchievementSubTaskProgress
    {
      get
      {
        return *(NativeHashMap<PrefabGUID, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AchievementSubTaskProgress));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AchievementSubTaskProgress), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashSet<PrefabGUID> AchievementsClaimed
    {
      get
      {
        return *(NativeHashSet<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AchievementsClaimed));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AchievementsClaimed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashSet<PrefabGUID> AchievementsCompleted
    {
      get
      {
        return *(NativeHashSet<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AchievementsCompleted));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_AchievementsCompleted), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public Il2CppSystem.Nullable<AchievementEntryData> TrackVBloodEntry
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_TrackVBloodEntry);
        return new Il2CppSystem.Nullable<AchievementEntryData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<AchievementEntryData>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_TrackVBloodEntry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<AchievementEntryData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabGUID TrackVBloodSource
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_TrackVBloodSource));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_TrackVBloodSource)) = value;
      }
    }

    public unsafe PrefabGUID ClosestVBloodSourceAchievement
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_ClosestVBloodSourceAchievement));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_ClosestVBloodSourceAchievement)) = value;
      }
    }

    public unsafe float3 TrackVBloodPosition
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_TrackVBloodPosition));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_TrackVBloodPosition)) = value;
      }
    }

    public unsafe float TrackVBloodGhostBuffRemainingTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_TrackVBloodGhostBuffRemainingTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementState.NativeFieldInfoPtr_TrackVBloodGhostBuffRemainingTime)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CachedVBloodData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AchievementGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_QuestFlavorTextOverride;
      private static readonly System.IntPtr NativeFieldInfoPtr_JournalCategory;
      [FieldOffset(0)]
      public PrefabGUID AchievementGUID;
      [FieldOffset(4)]
      public LocalizationKey QuestFlavorTextOverride;
      [FieldOffset(20)]
      public JournalCategoryType JournalCategory;

      static CachedVBloodData()
      {
        Il2CppClassPointerStore<AchievementState.CachedVBloodData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementState>.NativeClassPtr, nameof (CachedVBloodData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementState.CachedVBloodData>.NativeClassPtr);
        AchievementState.CachedVBloodData.NativeFieldInfoPtr_AchievementGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState.CachedVBloodData>.NativeClassPtr, nameof (AchievementGUID));
        AchievementState.CachedVBloodData.NativeFieldInfoPtr_QuestFlavorTextOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState.CachedVBloodData>.NativeClassPtr, nameof (QuestFlavorTextOverride));
        AchievementState.CachedVBloodData.NativeFieldInfoPtr_JournalCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementState.CachedVBloodData>.NativeClassPtr, nameof (JournalCategory));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchievementState.CachedVBloodData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
