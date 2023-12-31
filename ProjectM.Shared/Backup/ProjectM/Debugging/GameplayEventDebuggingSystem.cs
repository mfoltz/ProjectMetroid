// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.GameplayEventDebuggingSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Debugging
{
  public class GameplayEventDebuggingSystem : GameplayDebuggingSystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_RecordedFrame;
    private static readonly IntPtr NativeFieldInfoPtr_Systems;
    private static readonly IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly IntPtr NativeFieldInfoPtr_OnDataUpdated;
    private static readonly IntPtr NativeMethodInfoPtr_add_OnDataUpdated_Public_add_Void_GameplayEventRecordsUpdate_0;
    private static readonly IntPtr NativeMethodInfoPtr_remove_OnDataUpdated_Public_rem_Void_GameplayEventRecordsUpdate_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetGameplayDebugRecorder_Public_GameplayDebugRecorder_SystemBase_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetPrefabName_Private_String_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770074, XrefRangeEnd = 770078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void add_OnDataUpdated(GameplayEventRecordsUpdate value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayEventDebuggingSystem.NativeMethodInfoPtr_add_OnDataUpdated_Public_add_Void_GameplayEventRecordsUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770078, XrefRangeEnd = 770082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void remove_OnDataUpdated(GameplayEventRecordsUpdate value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayEventDebuggingSystem.NativeMethodInfoPtr_remove_OnDataUpdated_Public_rem_Void_GameplayEventRecordsUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770082, XrefRangeEnd = 770121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameplayEventDebuggingSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770121, XrefRangeEnd = 770138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameplayEventDebuggingSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 770147, RefRangeEnd = 770152, XrefRangeStart = 770138, XrefRangeEnd = 770147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayDebugRecorder GetGameplayDebugRecorder(SystemBase systemBase)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayEventDebuggingSystem.NativeMethodInfoPtr_GetGameplayDebugRecorder_Public_GameplayDebugRecorder_SystemBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameplayDebugRecorder*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770152, XrefRangeEnd = 770159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetPrefabName(PrefabGUID prefabGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &prefabGuid;
      IntPtr exc;
      IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameplayEventDebuggingSystem.NativeMethodInfoPtr_GetPrefabName_Private_String_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770159, XrefRangeEnd = 770162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameplayEventDebuggingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayEventDebuggingSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayEventDebuggingSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameplayEventDebuggingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayEventDebuggingSystem()
    {
      Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (GameplayEventDebuggingSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr);
      GameplayEventDebuggingSystem.NativeFieldInfoPtr_RecordedFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, nameof (RecordedFrame));
      GameplayEventDebuggingSystem.NativeFieldInfoPtr_Systems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, nameof (Systems));
      GameplayEventDebuggingSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      GameplayEventDebuggingSystem.NativeFieldInfoPtr_OnDataUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, nameof (OnDataUpdated));
      GameplayEventDebuggingSystem.NativeMethodInfoPtr_add_OnDataUpdated_Public_add_Void_GameplayEventRecordsUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, 100668177);
      GameplayEventDebuggingSystem.NativeMethodInfoPtr_remove_OnDataUpdated_Public_rem_Void_GameplayEventRecordsUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, 100668178);
      GameplayEventDebuggingSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, 100668179);
      GameplayEventDebuggingSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, 100668180);
      GameplayEventDebuggingSystem.NativeMethodInfoPtr_GetGameplayDebugRecorder_Public_GameplayDebugRecorder_SystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, 100668181);
      GameplayEventDebuggingSystem.NativeMethodInfoPtr_GetPrefabName_Private_String_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, 100668182);
      GameplayEventDebuggingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, 100668183);
      GameplayEventDebuggingSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, 100668184);
      GameplayEventDebuggingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventDebuggingSystem>.NativeClassPtr, 100668185);
    }

    public GameplayEventDebuggingSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RecordedFrame RecordedFrame
    {
      get
      {
        return *(RecordedFrame*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventDebuggingSystem.NativeFieldInfoPtr_RecordedFrame));
      }
      [param: In] set
      {
        *(RecordedFrame*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventDebuggingSystem.NativeFieldInfoPtr_RecordedFrame)) = value;
      }
    }

    public unsafe List<SystemBase> Systems
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventDebuggingSystem.NativeFieldInfoPtr_Systems));
        return pointer == IntPtr.Zero ? (List<SystemBase>) null : new List<SystemBase>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventDebuggingSystem.NativeFieldInfoPtr_Systems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventDebuggingSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventDebuggingSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameplayEventRecordsUpdate OnDataUpdated
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventDebuggingSystem.NativeFieldInfoPtr_OnDataUpdated));
        return pointer == IntPtr.Zero ? (GameplayEventRecordsUpdate) null : new GameplayEventRecordsUpdate(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameplayEventDebuggingSystem.NativeFieldInfoPtr_OnDataUpdated), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
