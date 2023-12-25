// Decompiled with JetBrains decompiler
// Type: ProjectM.OnGameplayEventAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Malee;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class OnGameplayEventAuthoring : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EventIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerMultipleTimes;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxTriggerCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerCooldown;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IOnGameplayEvent_get_EventIds_Private_Virtual_Final_New_get_GameplayEventId_EditorArray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddEventId_Public_Virtual_Final_New_Void_GameplayEventIdListener_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_New_GameplayEventTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddEventToBuffer_Protected_Static_Int32_EntityManager_byref_Entity_byref_TEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertEventIds_Protected_Void_Entity_EntityManager_byref_Int32_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_byref_TEvent_GameplayConditionGroupData_Editor_Parent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_byref_TEvent_byref_Int32_GameplayConditionGroupData_Editor_Parent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_Int32_BlobAssetReference_1_ConditionBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHeaderName_Public_Virtual_New_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public virtual unsafe OnGameplayEventAuthoring.GameplayEventId_EditorArray ProjectM\u002EIOnGameplayEvent\u002EEventIds
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnGameplayEventAuthoring.NativeMethodInfoPtr_ProjectM_IOnGameplayEvent_get_EventIds_Private_Virtual_Final_New_get_GameplayEventId_EditorArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (OnGameplayEventAuthoring.GameplayEventId_EditorArray) null : new OnGameplayEventAuthoring.GameplayEventId_EditorArray(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008132, XrefRangeEnd = 1008140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddEventId(GameplayEventIdListener eventId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) eventId));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnGameplayEventAuthoring.NativeMethodInfoPtr_AddEventId_Public_Virtual_Final_New_Void_GameplayEventIdListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe GameplayEventTypeEnum GetGameplayEventType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_New_GameplayEventTypeEnum_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventTypeEnum*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008140, XrefRangeEnd = 1008144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int AddEventToBuffer<TEvent>(
      EntityManager entityManager,
      [In] ref Entity entity,
      [In] ref TEvent evt)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entity;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) evt);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnGameplayEventAuthoring.MethodInfoStoreGeneric_AddEventToBuffer_Protected_Static_Int32_EntityManager_byref_Entity_byref_TEvent_0<TEvent>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TEvent local = ref evt;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEvent>(objectPointer, false, false);
      local = (TEvent) valueGeneric;
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1008170, RefRangeEnd = 1008175, XrefRangeStart = 1008144, XrefRangeEnd = 1008170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertEventIds(
      Entity entity,
      EntityManager entityManager,
      out int index,
      out int count)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnGameplayEventAuthoring.NativeMethodInfoPtr_ConvertEventIds_Protected_Void_Entity_EntityManager_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 1008175, RefRangeEnd = 1008190, XrefRangeStart = 1008175, XrefRangeEnd = 1008175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertGameplayEvent<TEvent>(
      EntityManager dstManager,
      Entity entity,
      [In] ref TEvent evt,
      GameplayConditionGroupData_Editor_Parent conditional = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) evt);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conditional);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnGameplayEventAuthoring.MethodInfoStoreGeneric_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_byref_TEvent_GameplayConditionGroupData_Editor_Parent_0<TEvent>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TEvent local = ref evt;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEvent>(objectPointer, false, false);
      local = (TEvent) valueGeneric;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008190, XrefRangeEnd = 1008196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertGameplayEvent<TEvent>(
      EntityManager dstManager,
      Entity entity,
      [In] ref TEvent evt,
      out int eventIndexOfType,
      GameplayConditionGroupData_Editor_Parent conditional = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      numPtr1[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) evt);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventIndexOfType;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conditional);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnGameplayEventAuthoring.MethodInfoStoreGeneric_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_byref_TEvent_byref_Int32_GameplayConditionGroupData_Editor_Parent_0<TEvent>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TEvent local = ref evt;
      System.IntPtr objectPointer = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = objectPointer == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TEvent>(objectPointer, false, false);
      local = (TEvent) valueGeneric;
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1008221, RefRangeEnd = 1008222, XrefRangeStart = 1008196, XrefRangeEnd = 1008221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertGameplayEvent(
      EntityManager dstManager,
      Entity entity,
      int eventIndexOfType,
      BlobAssetReference<ConditionBlob> conditionBlob)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &eventIndexOfType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &conditionBlob;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnGameplayEventAuthoring.NativeMethodInfoPtr_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_Int32_BlobAssetReference_1_ConditionBlob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008222, XrefRangeEnd = 1008224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe string GetHeaderName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OnGameplayEventAuthoring.NativeMethodInfoPtr_GetHeaderName_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnGameplayEventAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static OnGameplayEventAuthoring()
    {
      Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (OnGameplayEventAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr);
      OnGameplayEventAuthoring.NativeFieldInfoPtr_EventIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, nameof (EventIds));
      OnGameplayEventAuthoring.NativeFieldInfoPtr_TriggerMultipleTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, nameof (TriggerMultipleTimes));
      OnGameplayEventAuthoring.NativeFieldInfoPtr_MaxTriggerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, nameof (MaxTriggerCount));
      OnGameplayEventAuthoring.NativeFieldInfoPtr_TriggerCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, nameof (TriggerCooldown));
      OnGameplayEventAuthoring.NativeMethodInfoPtr_ProjectM_IOnGameplayEvent_get_EventIds_Private_Virtual_Final_New_get_GameplayEventId_EditorArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, 100678304);
      OnGameplayEventAuthoring.NativeMethodInfoPtr_AddEventId_Public_Virtual_Final_New_Void_GameplayEventIdListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, 100678305);
      OnGameplayEventAuthoring.NativeMethodInfoPtr_GetGameplayEventType_Protected_Virtual_New_GameplayEventTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, 100678306);
      OnGameplayEventAuthoring.NativeMethodInfoPtr_AddEventToBuffer_Protected_Static_Int32_EntityManager_byref_Entity_byref_TEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, 100678307);
      OnGameplayEventAuthoring.NativeMethodInfoPtr_ConvertEventIds_Protected_Void_Entity_EntityManager_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, 100678308);
      OnGameplayEventAuthoring.NativeMethodInfoPtr_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_byref_TEvent_GameplayConditionGroupData_Editor_Parent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, 100678309);
      OnGameplayEventAuthoring.NativeMethodInfoPtr_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_byref_TEvent_byref_Int32_GameplayConditionGroupData_Editor_Parent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, 100678310);
      OnGameplayEventAuthoring.NativeMethodInfoPtr_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_Int32_BlobAssetReference_1_ConditionBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, 100678311);
      OnGameplayEventAuthoring.NativeMethodInfoPtr_GetHeaderName_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, 100678312);
      OnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, 100678313);
    }

    public OnGameplayEventAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe OnGameplayEventAuthoring.GameplayEventId_EditorArray EventIds
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnGameplayEventAuthoring.NativeFieldInfoPtr_EventIds));
        return pointer == System.IntPtr.Zero ? (OnGameplayEventAuthoring.GameplayEventId_EditorArray) null : new OnGameplayEventAuthoring.GameplayEventId_EditorArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnGameplayEventAuthoring.NativeFieldInfoPtr_EventIds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool TriggerMultipleTimes
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnGameplayEventAuthoring.NativeFieldInfoPtr_TriggerMultipleTimes));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnGameplayEventAuthoring.NativeFieldInfoPtr_TriggerMultipleTimes)) = value;
      }
    }

    public unsafe int MaxTriggerCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnGameplayEventAuthoring.NativeFieldInfoPtr_MaxTriggerCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnGameplayEventAuthoring.NativeFieldInfoPtr_MaxTriggerCount)) = value;
      }
    }

    public unsafe float TriggerCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnGameplayEventAuthoring.NativeFieldInfoPtr_TriggerCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnGameplayEventAuthoring.NativeFieldInfoPtr_TriggerCooldown)) = value;
      }
    }

    [Serializable]
    public class GameplayEventId_EditorArray : ReorderableArray<GameplayEventIdListener>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1008131, RefRangeEnd = 1008132, XrefRangeStart = 1008128, XrefRangeEnd = 1008131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GameplayEventId_EditorArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnGameplayEventAuthoring.GameplayEventId_EditorArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnGameplayEventAuthoring.GameplayEventId_EditorArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GameplayEventId_EditorArray()
      {
        Il2CppClassPointerStore<OnGameplayEventAuthoring.GameplayEventId_EditorArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr, nameof (GameplayEventId_EditorArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnGameplayEventAuthoring.GameplayEventId_EditorArray>.NativeClassPtr);
        OnGameplayEventAuthoring.GameplayEventId_EditorArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnGameplayEventAuthoring.GameplayEventId_EditorArray>.NativeClassPtr, 100678314);
      }

      public GameplayEventId_EditorArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    private sealed class MethodInfoStoreGeneric_AddEventToBuffer_Protected_Static_Int32_EntityManager_byref_Entity_byref_TEvent_0<TEvent>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(OnGameplayEventAuthoring.NativeMethodInfoPtr_AddEventToBuffer_Protected_Static_Int32_EntityManager_byref_Entity_byref_TEvent_0, Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEvent>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_byref_TEvent_GameplayConditionGroupData_Editor_Parent_0<TEvent>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(OnGameplayEventAuthoring.NativeMethodInfoPtr_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_byref_TEvent_GameplayConditionGroupData_Editor_Parent_0, Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEvent>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_byref_TEvent_byref_Int32_GameplayConditionGroupData_Editor_Parent_0<TEvent>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(OnGameplayEventAuthoring.NativeMethodInfoPtr_ConvertGameplayEvent_Protected_Void_EntityManager_Entity_byref_TEvent_byref_Int32_GameplayConditionGroupData_Editor_Parent_0, Il2CppClassPointerStore<OnGameplayEventAuthoring>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEvent>.NativeClassPtr))
      }))));
    }
  }
}
