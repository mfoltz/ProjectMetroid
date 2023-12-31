// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.GameplayDebugRecorder
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameplayDebugRecorder
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Records;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
    private static readonly System.IntPtr NativeFieldInfoPtr_System;
    private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDefault_Public_Static_GameplayDebugRecorder_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateRecord_Public_GameplayDebugRecord_DebugRecordTypeEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddRecord_Public_Void_byref_GameplayDebugRecord_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDealDamageEvent_Public_DealDamageRecorder_byref_DealDamageEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateGameplayEventRecorder_Public_GameplayEventRecorder_GameplayEventTypeEnum_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateBeginCondition_Public_Void_byref_ConditionEntities_byref_BlobAssetReference_1_ConditionBlob_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEndCondition_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateBeginConditionCheck_Public_Void_byref_ConditionElement_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEndConditionCheck_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateConditionReportHasComponent_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateConditionReportMissingComponent_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateConditionReportHasBuffer_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateConditionReportMissingBuffer_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateConditionReportType_Private_Void_Int32_Boolean_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntitySpawned_Public_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntityDestroyed_Public_Void_Entity_0;
    [FieldOffset(0)]
    public NativeList<GameplayDebugRecord> Records;
    [FieldOffset(16)]
    public NativeHashSet<Entity> Entities;
    [FieldOffset(32)]
    public SystemId System;
    [FieldOffset(36)]
    public bool Enabled;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770646, RefRangeEnd = 770647, XrefRangeStart = 770646, XrefRangeEnd = 770646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe GameplayDebugRecorder GetDefault()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_GetDefault_Public_Static_GameplayDebugRecorder_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayDebugRecorder*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770647, XrefRangeEnd = 770648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayDebugRecord CreateRecord(DebugRecordTypeEnum type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_CreateRecord_Public_GameplayDebugRecord_DebugRecordTypeEnum_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayDebugRecord*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770648, XrefRangeEnd = 770655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddRecord([In] ref GameplayDebugRecord record)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref record;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_AddRecord_Public_Void_byref_GameplayDebugRecord_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770667, RefRangeEnd = 770668, XrefRangeStart = 770655, XrefRangeEnd = 770667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DealDamageRecorder CreateDealDamageEvent([In] ref DealDamageEvent dealDamageEvent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref dealDamageEvent;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_CreateDealDamageEvent_Public_DealDamageRecorder_byref_DealDamageEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(DealDamageRecorder*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770683, RefRangeEnd = 770684, XrefRangeStart = 770668, XrefRangeEnd = 770683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayEventRecorder CreateGameplayEventRecorder(
      GameplayEventTypeEnum gameplayEventType,
      Entity listener)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &gameplayEventType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &listener;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_CreateGameplayEventRecorder_Public_GameplayEventRecorder_GameplayEventTypeEnum_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayEventRecorder*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770692, RefRangeEnd = 770693, XrefRangeStart = 770684, XrefRangeEnd = 770692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateBeginCondition(
      [In] ref ConditionEntities entities,
      [In] ref BlobAssetReference<ConditionBlob> condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref entities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref condition;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_CreateBeginCondition_Public_Void_byref_ConditionEntities_byref_BlobAssetReference_1_ConditionBlob_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770701, RefRangeEnd = 770702, XrefRangeStart = 770693, XrefRangeEnd = 770701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateEndCondition(bool result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_CreateEndCondition_Public_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770710, RefRangeEnd = 770711, XrefRangeStart = 770702, XrefRangeEnd = 770710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateBeginConditionCheck([In] ref ConditionElement element, int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref element;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_CreateBeginConditionCheck_Public_Void_byref_ConditionElement_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770719, RefRangeEnd = 770720, XrefRangeStart = 770711, XrefRangeEnd = 770719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateEndConditionCheck(bool result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_CreateEndConditionCheck_Public_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770720, XrefRangeEnd = 770724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateConditionReportHasComponent<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.MethodInfoStoreGeneric_CreateConditionReportHasComponent_Public_Void_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770728, RefRangeEnd = 770729, XrefRangeStart = 770724, XrefRangeEnd = 770728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateConditionReportMissingComponent<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.MethodInfoStoreGeneric_CreateConditionReportMissingComponent_Public_Void_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770729, XrefRangeEnd = 770733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateConditionReportHasBuffer<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.MethodInfoStoreGeneric_CreateConditionReportHasBuffer_Public_Void_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770737, RefRangeEnd = 770738, XrefRangeStart = 770733, XrefRangeEnd = 770737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateConditionReportMissingBuffer<T>(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.MethodInfoStoreGeneric_CreateConditionReportMissingBuffer_Public_Void_Entity_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 770749, RefRangeEnd = 770753, XrefRangeStart = 770738, XrefRangeEnd = 770749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateConditionReportType(int typeIndex, bool successFetch, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &typeIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &successFetch;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_CreateConditionReportType_Private_Void_Int32_Boolean_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770764, RefRangeEnd = 770765, XrefRangeStart = 770753, XrefRangeEnd = 770764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateEntitySpawned(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_CreateEntitySpawned_Public_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770776, RefRangeEnd = 770777, XrefRangeStart = 770765, XrefRangeEnd = 770776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateEntityDestroyed(Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayDebugRecorder.NativeMethodInfoPtr_CreateEntityDestroyed_Public_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayDebugRecorder()
    {
      Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (GameplayDebugRecorder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr);
      GameplayDebugRecorder.NativeFieldInfoPtr_Records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, nameof (Records));
      GameplayDebugRecorder.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, nameof (Entities));
      GameplayDebugRecorder.NativeFieldInfoPtr_System = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, nameof (System));
      GameplayDebugRecorder.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, nameof (Enabled));
      GameplayDebugRecorder.NativeMethodInfoPtr_GetDefault_Public_Static_GameplayDebugRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668251);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateRecord_Public_GameplayDebugRecord_DebugRecordTypeEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668252);
      GameplayDebugRecorder.NativeMethodInfoPtr_AddRecord_Public_Void_byref_GameplayDebugRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668253);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateDealDamageEvent_Public_DealDamageRecorder_byref_DealDamageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668254);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateGameplayEventRecorder_Public_GameplayEventRecorder_GameplayEventTypeEnum_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668255);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateBeginCondition_Public_Void_byref_ConditionEntities_byref_BlobAssetReference_1_ConditionBlob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668256);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateEndCondition_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668257);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateBeginConditionCheck_Public_Void_byref_ConditionElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668258);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateEndConditionCheck_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668259);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateConditionReportHasComponent_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668260);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateConditionReportMissingComponent_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668261);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateConditionReportHasBuffer_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668262);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateConditionReportMissingBuffer_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668263);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateConditionReportType_Private_Void_Int32_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668264);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateEntitySpawned_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668265);
      GameplayDebugRecorder.NativeMethodInfoPtr_CreateEntityDestroyed_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, 100668266);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr, (System.IntPtr) ref this));
    }

    private sealed class MethodInfoStoreGeneric_CreateConditionReportHasComponent_Public_Void_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameplayDebugRecorder.NativeMethodInfoPtr_CreateConditionReportHasComponent_Public_Void_Entity_0, Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CreateConditionReportMissingComponent_Public_Void_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameplayDebugRecorder.NativeMethodInfoPtr_CreateConditionReportMissingComponent_Public_Void_Entity_0, Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CreateConditionReportHasBuffer_Public_Void_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameplayDebugRecorder.NativeMethodInfoPtr_CreateConditionReportHasBuffer_Public_Void_Entity_0, Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CreateConditionReportMissingBuffer_Public_Void_Entity_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameplayDebugRecorder.NativeMethodInfoPtr_CreateConditionReportMissingBuffer_Public_Void_Entity_0, Il2CppClassPointerStore<GameplayDebugRecorder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
