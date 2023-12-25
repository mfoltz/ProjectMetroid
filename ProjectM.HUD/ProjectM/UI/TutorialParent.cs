// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TutorialParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class TutorialParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Motions;
    private static readonly IntPtr NativeFieldInfoPtr_Requirement_CraftingTutorial;
    private static readonly IntPtr NativeFieldInfoPtr_Requirement_BuildingTutorial;
    private static readonly IntPtr NativeFieldInfoPtr__TutorialObjectives;
    private static readonly IntPtr NativeFieldInfoPtr__QueuedTutorialQuests;
    private static readonly IntPtr NativeFieldInfoPtr__CurrentQuest;
    private static readonly IntPtr NativeFieldInfoPtr__ActiveQuestTime;
    private static readonly IntPtr NativeFieldInfoPtr__CompleteDelayTime;
    private static readonly IntPtr NativeFieldInfoPtr__AutoCompleteTime;
    private static readonly IntPtr NativeFieldInfoPtr__MinimumActiveTime;
    private static readonly IntPtr NativeFieldInfoPtr__ActivationDelayTime;
    private static readonly IntPtr NativeFieldInfoPtr__NextQuestHaveNoActivation;
    private static readonly IntPtr NativeMethodInfoPtr_Initialized_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Void_EntityManager_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_ShouldAutoComplete_Public_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ClearAllActiveQuests_Internal_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddTutorialQuest_Public_Void_TutorialObjectiveType_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasTutorialQuest_Internal_Boolean_TutorialObjectiveType_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetCurrentQuest_Internal_TutorialObjectiveType_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1276631, RefRangeEnd = 1276632, XrefRangeStart = 1276601, XrefRangeEnd = 1276631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialized()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialParent.NativeMethodInfoPtr_Initialized_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276632, XrefRangeEnd = 1276633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddComponent(EntityManager entityManager, Entity entity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &entity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialParent.NativeMethodInfoPtr_AddComponent_Public_Void_EntityManager_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool ShouldAutoComplete()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialParent.NativeMethodInfoPtr_ShouldAutoComplete_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276633, XrefRangeEnd = 1276683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialParent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1276687, RefRangeEnd = 1276688, XrefRangeStart = 1276683, XrefRangeEnd = 1276687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearAllActiveQuests()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialParent.NativeMethodInfoPtr_ClearAllActiveQuests_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1276710, RefRangeEnd = 1276722, XrefRangeStart = 1276688, XrefRangeEnd = 1276710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddTutorialQuest(TutorialObjectiveType tutorialQuestType, bool instaActivate = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &tutorialQuestType;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &instaActivate;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialParent.NativeMethodInfoPtr_AddTutorialQuest_Public_Void_TutorialObjectiveType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1276738, RefRangeEnd = 1276750, XrefRangeStart = 1276722, XrefRangeEnd = 1276738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasTutorialQuest(TutorialObjectiveType tutorialQuestType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &tutorialQuestType;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialParent.NativeMethodInfoPtr_HasTutorialQuest_Internal_Boolean_TutorialObjectiveType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 32748, RefRangeEnd = 32752, XrefRangeStart = 32748, XrefRangeEnd = 32752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TutorialObjectiveType GetCurrentQuest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialParent.NativeMethodInfoPtr_GetCurrentQuest_Internal_TutorialObjectiveType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TutorialObjectiveType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276750, XrefRangeEnd = 1276758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TutorialParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TutorialParent()
    {
      Il2CppClassPointerStore<TutorialParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TutorialParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr);
      TutorialParent.NativeFieldInfoPtr_Motions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (Motions));
      TutorialParent.NativeFieldInfoPtr_Requirement_CraftingTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (Requirement_CraftingTutorial));
      TutorialParent.NativeFieldInfoPtr_Requirement_BuildingTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (Requirement_BuildingTutorial));
      TutorialParent.NativeFieldInfoPtr__TutorialObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (_TutorialObjectives));
      TutorialParent.NativeFieldInfoPtr__QueuedTutorialQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (_QueuedTutorialQuests));
      TutorialParent.NativeFieldInfoPtr__CurrentQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (_CurrentQuest));
      TutorialParent.NativeFieldInfoPtr__ActiveQuestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (_ActiveQuestTime));
      TutorialParent.NativeFieldInfoPtr__CompleteDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (_CompleteDelayTime));
      TutorialParent.NativeFieldInfoPtr__AutoCompleteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (_AutoCompleteTime));
      TutorialParent.NativeFieldInfoPtr__MinimumActiveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (_MinimumActiveTime));
      TutorialParent.NativeFieldInfoPtr__ActivationDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (_ActivationDelayTime));
      TutorialParent.NativeFieldInfoPtr__NextQuestHaveNoActivation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, nameof (_NextQuestHaveNoActivation));
      TutorialParent.NativeMethodInfoPtr_Initialized_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, 100668559);
      TutorialParent.NativeMethodInfoPtr_AddComponent_Public_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, 100668560);
      TutorialParent.NativeMethodInfoPtr_ShouldAutoComplete_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, 100668561);
      TutorialParent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, 100668562);
      TutorialParent.NativeMethodInfoPtr_ClearAllActiveQuests_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, 100668563);
      TutorialParent.NativeMethodInfoPtr_AddTutorialQuest_Public_Void_TutorialObjectiveType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, 100668564);
      TutorialParent.NativeMethodInfoPtr_HasTutorialQuest_Internal_Boolean_TutorialObjectiveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, 100668565);
      TutorialParent.NativeMethodInfoPtr_GetCurrentQuest_Internal_TutorialObjectiveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, 100668566);
      TutorialParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialParent>.NativeClassPtr, 100668567);
    }

    public TutorialParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Motion2DInOut Motions
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr_Motions));
        return pointer == IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr_Motions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Requirement_CraftingTutorial
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr_Requirement_CraftingTutorial));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr_Requirement_CraftingTutorial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> Requirement_BuildingTutorial
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr_Requirement_BuildingTutorial));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr_Requirement_BuildingTutorial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TutorialObjective> _TutorialObjectives
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__TutorialObjectives));
        return pointer == IntPtr.Zero ? (List<TutorialObjective>) null : new List<TutorialObjective>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__TutorialObjectives), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TutorialObjective> _QueuedTutorialQuests
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__QueuedTutorialQuests));
        return pointer == IntPtr.Zero ? (List<TutorialObjective>) null : new List<TutorialObjective>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__QueuedTutorialQuests), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TutorialObjectiveType _CurrentQuest
    {
      get
      {
        return *(TutorialObjectiveType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__CurrentQuest));
      }
      [param: In] set
      {
        *(TutorialObjectiveType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__CurrentQuest)) = value;
      }
    }

    public unsafe float _ActiveQuestTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__ActiveQuestTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__ActiveQuestTime)) = value;
      }
    }

    public unsafe float _CompleteDelayTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__CompleteDelayTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__CompleteDelayTime)) = value;
      }
    }

    public unsafe float _AutoCompleteTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__AutoCompleteTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__AutoCompleteTime)) = value;
      }
    }

    public unsafe float _MinimumActiveTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__MinimumActiveTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__MinimumActiveTime)) = value;
      }
    }

    public unsafe float _ActivationDelayTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__ActivationDelayTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__ActivationDelayTime)) = value;
      }
    }

    public unsafe bool _NextQuestHaveNoActivation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__NextQuestHaveNoActivation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialParent.NativeFieldInfoPtr__NextQuestHaveNoActivation)) = value;
      }
    }
  }
}
