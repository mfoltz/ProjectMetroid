// Decompiled with JetBrains decompiler
// Type: ProjectM.TriggerPersistenceSaveSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class TriggerPersistenceSaveSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly IntPtr NativeFieldInfoPtr__LastSaveTime;
    private static readonly IntPtr NativeFieldInfoPtr__SaveCounter;
    private static readonly IntPtr NativeFieldInfoPtr__SaveInitialized;
    private static readonly IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_37;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_TriggerAutoSave_Public_Void_ServerRuntimeSettings_0;
    private static readonly IntPtr NativeMethodInfoPtr_TriggerSave_Public_Void_SaveReason_FixedString128_ServerRuntimeSettings_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsReadyToSave_Private_Boolean_ServerRuntimeSettings_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061699, XrefRangeEnd = 1061710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TriggerPersistenceSaveSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061710, XrefRangeEnd = 1061749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TriggerPersistenceSaveSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061749, XrefRangeEnd = 1061770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TriggerAutoSave(ServerRuntimeSettings runtimeSettings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &runtimeSettings;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TriggerPersistenceSaveSystem.NativeMethodInfoPtr_TriggerAutoSave_Public_Void_ServerRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1061805, RefRangeEnd = 1061807, XrefRangeStart = 1061770, XrefRangeEnd = 1061805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TriggerSave(
      SaveReason reason,
      FixedString128 saveName,
      ServerRuntimeSettings saveConfig)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &reason;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &saveName;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &saveConfig;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TriggerPersistenceSaveSystem.NativeMethodInfoPtr_TriggerSave_Public_Void_SaveReason_FixedString128_ServerRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061807, XrefRangeEnd = 1061809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsReadyToSave(ServerRuntimeSettings runtimeSettings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &runtimeSettings;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(TriggerPersistenceSaveSystem.NativeMethodInfoPtr_IsReadyToSave_Private_Boolean_ServerRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TriggerPersistenceSaveSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TriggerPersistenceSaveSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061809, XrefRangeEnd = 1061817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TriggerPersistenceSaveSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TriggerPersistenceSaveSystem()
    {
      Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TriggerPersistenceSaveSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr);
      TriggerPersistenceSaveSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, nameof (_TerrainManager));
      TriggerPersistenceSaveSystem.NativeFieldInfoPtr__LastSaveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, nameof (_LastSaveTime));
      TriggerPersistenceSaveSystem.NativeFieldInfoPtr__SaveCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, nameof (_SaveCounter));
      TriggerPersistenceSaveSystem.NativeFieldInfoPtr__SaveInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, nameof (_SaveInitialized));
      TriggerPersistenceSaveSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_37 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerRuntimeSettings_37));
      TriggerPersistenceSaveSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, 100683295);
      TriggerPersistenceSaveSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, 100683296);
      TriggerPersistenceSaveSystem.NativeMethodInfoPtr_TriggerAutoSave_Public_Void_ServerRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, 100683297);
      TriggerPersistenceSaveSystem.NativeMethodInfoPtr_TriggerSave_Public_Void_SaveReason_FixedString128_ServerRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, 100683298);
      TriggerPersistenceSaveSystem.NativeMethodInfoPtr_IsReadyToSave_Private_Boolean_ServerRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, 100683299);
      TriggerPersistenceSaveSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, 100683300);
      TriggerPersistenceSaveSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPersistenceSaveSystem>.NativeClassPtr, 100683301);
    }

    public TriggerPersistenceSaveSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerPersistenceSaveSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TriggerPersistenceSaveSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe double _LastSaveTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerPersistenceSaveSystem.NativeFieldInfoPtr__LastSaveTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerPersistenceSaveSystem.NativeFieldInfoPtr__LastSaveTime)) = value;
      }
    }

    public unsafe int _SaveCounter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerPersistenceSaveSystem.NativeFieldInfoPtr__SaveCounter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerPersistenceSaveSystem.NativeFieldInfoPtr__SaveCounter)) = value;
      }
    }

    public unsafe bool _SaveInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerPersistenceSaveSystem.NativeFieldInfoPtr__SaveInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerPersistenceSaveSystem.NativeFieldInfoPtr__SaveInitialized)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerRuntimeSettings_37
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerPersistenceSaveSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_37));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TriggerPersistenceSaveSystem.NativeFieldInfoPtr__SingletonEntityQuery_ServerRuntimeSettings_37)) = value;
      }
    }
  }
}
