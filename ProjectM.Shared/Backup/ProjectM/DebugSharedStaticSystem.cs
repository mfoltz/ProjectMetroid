// Decompiled with JetBrains decompiler
// Type: ProjectM.DebugSharedStaticSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DebugSharedStaticSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__BroadcastEvents;
    private static readonly IntPtr NativeFieldInfoPtr__UnconsumedEvents;
    private static readonly IntPtr NativeFieldInfoPtr__EntitiesToDump;
    private static readonly IntPtr NativeFieldInfoPtr__UniqueIdsAlreadyDumped;
    private static readonly IntPtr NativeFieldInfoPtr__CompletedAllJobsThisFrame;
    private static readonly IntPtr NativeMethodInfoPtr_GetNewClientEvents_Public_Void_List_1_EventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetNewServerEvents_Public_Void_List_1_EventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateIssueBroadcasting_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroyIssueBroadcasting_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateIssueBroadcasting_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateEntities_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroyEntities_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateEntityDumping_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_TryDumpEntityForWorld_Private_Static_Void_World_EventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_CompleteAllJobsInAllWorlds_Private_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 732897, RefRangeEnd = 732898, XrefRangeStart = 732887, XrefRangeEnd = 732897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetNewClientEvents(
      List<BroadcastIssueOnScreen.EventData> clientEvents)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientEvents);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugSharedStaticSystem.NativeMethodInfoPtr_GetNewClientEvents_Public_Void_List_1_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 732908, RefRangeEnd = 732909, XrefRangeStart = 732898, XrefRangeEnd = 732908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetNewServerEvents(
      List<BroadcastIssueOnScreen.EventData> out_ServerEvents)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) out_ServerEvents);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugSharedStaticSystem.NativeMethodInfoPtr_GetNewServerEvents_Public_Void_List_1_EventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732909, XrefRangeEnd = 732920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnCreateIssueBroadcasting()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugSharedStaticSystem.NativeMethodInfoPtr_OnCreateIssueBroadcasting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732920, XrefRangeEnd = 732930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroyIssueBroadcasting()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugSharedStaticSystem.NativeMethodInfoPtr_OnDestroyIssueBroadcasting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 732981, RefRangeEnd = 732982, XrefRangeStart = 732930, XrefRangeEnd = 732981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateIssueBroadcasting()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugSharedStaticSystem.NativeMethodInfoPtr_UpdateIssueBroadcasting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732982, XrefRangeEnd = 732995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnCreateEntities()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugSharedStaticSystem.NativeMethodInfoPtr_OnCreateEntities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732995, XrefRangeEnd = 733005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroyEntities()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugSharedStaticSystem.NativeMethodInfoPtr_OnDestroyEntities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 733060, RefRangeEnd = 733061, XrefRangeStart = 733005, XrefRangeEnd = 733060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateEntityDumping()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugSharedStaticSystem.NativeMethodInfoPtr_UpdateEntityDumping_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 733161, RefRangeEnd = 733162, XrefRangeStart = 733061, XrefRangeEnd = 733161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TryDumpEntityForWorld(
      World world,
      DumpEntityDebugInfo.EventData eventData)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &eventData;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugSharedStaticSystem.NativeMethodInfoPtr_TryDumpEntityForWorld_Private_Static_Void_World_EventData_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733162, XrefRangeEnd = 733186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugSharedStaticSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733186, XrefRangeEnd = 733207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugSharedStaticSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733207, XrefRangeEnd = 733209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugSharedStaticSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 733235, RefRangeEnd = 733238, XrefRangeStart = 733209, XrefRangeEnd = 733235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CompleteAllJobsInAllWorlds(bool forceComplete = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &forceComplete;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugSharedStaticSystem.NativeMethodInfoPtr_CompleteAllJobsInAllWorlds_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733238, XrefRangeEnd = 733253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugSharedStaticSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugSharedStaticSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugSharedStaticSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugSharedStaticSystem()
    {
      Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DebugSharedStaticSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr);
      DebugSharedStaticSystem.NativeFieldInfoPtr__BroadcastEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, nameof (_BroadcastEvents));
      DebugSharedStaticSystem.NativeFieldInfoPtr__UnconsumedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, nameof (_UnconsumedEvents));
      DebugSharedStaticSystem.NativeFieldInfoPtr__EntitiesToDump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, nameof (_EntitiesToDump));
      DebugSharedStaticSystem.NativeFieldInfoPtr__UniqueIdsAlreadyDumped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, nameof (_UniqueIdsAlreadyDumped));
      DebugSharedStaticSystem.NativeFieldInfoPtr__CompletedAllJobsThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, nameof (_CompletedAllJobsThisFrame));
      DebugSharedStaticSystem.NativeMethodInfoPtr_GetNewClientEvents_Public_Void_List_1_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664775);
      DebugSharedStaticSystem.NativeMethodInfoPtr_GetNewServerEvents_Public_Void_List_1_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664776);
      DebugSharedStaticSystem.NativeMethodInfoPtr_OnCreateIssueBroadcasting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664777);
      DebugSharedStaticSystem.NativeMethodInfoPtr_OnDestroyIssueBroadcasting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664778);
      DebugSharedStaticSystem.NativeMethodInfoPtr_UpdateIssueBroadcasting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664779);
      DebugSharedStaticSystem.NativeMethodInfoPtr_OnCreateEntities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664780);
      DebugSharedStaticSystem.NativeMethodInfoPtr_OnDestroyEntities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664781);
      DebugSharedStaticSystem.NativeMethodInfoPtr_UpdateEntityDumping_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664782);
      DebugSharedStaticSystem.NativeMethodInfoPtr_TryDumpEntityForWorld_Private_Static_Void_World_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664783);
      DebugSharedStaticSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664784);
      DebugSharedStaticSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664785);
      DebugSharedStaticSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664786);
      DebugSharedStaticSystem.NativeMethodInfoPtr_CompleteAllJobsInAllWorlds_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664787);
      DebugSharedStaticSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664788);
      DebugSharedStaticSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSharedStaticSystem>.NativeClassPtr, 100664789);
    }

    public DebugSharedStaticSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnsafeList<BroadcastIssueOnScreen.EventData> _BroadcastEvents
    {
      get
      {
        return *(UnsafeList<BroadcastIssueOnScreen.EventData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSharedStaticSystem.NativeFieldInfoPtr__BroadcastEvents));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSharedStaticSystem.NativeFieldInfoPtr__BroadcastEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnsafeList<BroadcastIssueOnScreen.EventData>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe List<BroadcastIssueOnScreen.EventData> _UnconsumedEvents
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSharedStaticSystem.NativeFieldInfoPtr__UnconsumedEvents));
        return pointer == IntPtr.Zero ? (List<BroadcastIssueOnScreen.EventData>) null : new List<BroadcastIssueOnScreen.EventData>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugSharedStaticSystem.NativeFieldInfoPtr__UnconsumedEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnsafeList<DumpEntityDebugInfo.EventData> _EntitiesToDump
    {
      get
      {
        return *(UnsafeList<DumpEntityDebugInfo.EventData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSharedStaticSystem.NativeFieldInfoPtr__EntitiesToDump));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSharedStaticSystem.NativeFieldInfoPtr__EntitiesToDump), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnsafeList<DumpEntityDebugInfo.EventData>>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe HashSet<EntityDumpUniquenessId> _UniqueIdsAlreadyDumped
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSharedStaticSystem.NativeFieldInfoPtr__UniqueIdsAlreadyDumped));
        return pointer == IntPtr.Zero ? (HashSet<EntityDumpUniquenessId>) null : new HashSet<EntityDumpUniquenessId>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugSharedStaticSystem.NativeFieldInfoPtr__UniqueIdsAlreadyDumped), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _CompletedAllJobsThisFrame
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSharedStaticSystem.NativeFieldInfoPtr__CompletedAllJobsThisFrame));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSharedStaticSystem.NativeFieldInfoPtr__CompletedAllJobsThisFrame)) = value;
      }
    }
  }
}
