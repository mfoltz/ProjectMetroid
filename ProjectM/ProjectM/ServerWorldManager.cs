// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerWorldManager
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ServerWorldManager : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__ServerWorld;
    private static readonly IntPtr NativeFieldInfoPtr__GameBootstrap;
    private static readonly IntPtr NativeMethodInfoPtr_get_ServerWorld_Public_get_World_0;
    private static readonly IntPtr NativeMethodInfoPtr_InitializeGameBootstrap_Public_Void_GameBootstrap_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_DestroyServerWorld_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_BeginCreateServerWorld_Public_Void_ServerRuntimeSettings_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateSaveConfiguration_Public_ServerRuntimeSettings_PrefabConversionMethod_String_String_Boolean_Boolean_Boolean_Boolean_FirstTimeSpawnServerSetting_PersistenceDebugFlags_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_CreateSaveConfiguration_Public_Static_ServerRuntimeSettings_PrefabConversionMethod_String_String_Boolean_Boolean_Boolean_Boolean_FirstTimeSpawnServerSetting_Boolean_Boolean_Int32_Single_Boolean_PersistenceDebugFlags_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_FinalizeCreateServerWorld_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddOrUpdatePhysicsSingleton_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe World ServerWorld
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 986758, RefRangeEnd = 986770, XrefRangeStart = 986758, XrefRangeEnd = 986758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerWorldManager.NativeMethodInfoPtr_get_ServerWorld_Public_get_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (World) null : new World(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitializeGameBootstrap(GameBootstrap gameBootstrap)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameBootstrap);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWorldManager.NativeMethodInfoPtr_InitializeGameBootstrap_Public_Void_GameBootstrap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986770, XrefRangeEnd = 986771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerWorldManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 986777, RefRangeEnd = 986780, XrefRangeStart = 986771, XrefRangeEnd = 986777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyServerWorld()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWorldManager.NativeMethodInfoPtr_DestroyServerWorld_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986780, XrefRangeEnd = 986859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BeginCreateServerWorld(ServerRuntimeSettings saveConfiguration)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &saveConfiguration;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWorldManager.NativeMethodInfoPtr_BeginCreateServerWorld_Public_Void_ServerRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986859, XrefRangeEnd = 986871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerRuntimeSettings CreateSaveConfiguration(
      PrefabConversionMethod conversionMethod,
      string saveDirectoryPath,
      string saveToLoad,
      bool debugEventsDisabled,
      bool adminOnlyDebugEvents,
      bool enableDangerousDebugEvents,
      bool everyoneIsAdmin,
      FirstTimeSpawnServerSetting firstTimeSpawnServerSetting,
      PersistenceDebugFlags persistenceDebugFlags,
      bool keepAliveOnError,
      bool hostLAN)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[11];
      numPtr[0] = (IntPtr) &conversionMethod;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(saveDirectoryPath);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(saveToLoad);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &debugEventsDisabled;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &adminOnlyDebugEvents;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &enableDangerousDebugEvents;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &everyoneIsAdmin;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &firstTimeSpawnServerSetting;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(8) * sizeof (IntPtr))) = (IntPtr) &persistenceDebugFlags;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(9) * sizeof (IntPtr))) = (IntPtr) &keepAliveOnError;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(10) * sizeof (IntPtr))) = (IntPtr) &hostLAN;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerWorldManager.NativeMethodInfoPtr_CreateSaveConfiguration_Public_ServerRuntimeSettings_PrefabConversionMethod_String_String_Boolean_Boolean_Boolean_Boolean_FirstTimeSpawnServerSetting_PersistenceDebugFlags_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerRuntimeSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 986883, RefRangeEnd = 986885, XrefRangeStart = 986871, XrefRangeEnd = 986883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ServerRuntimeSettings CreateSaveConfiguration(
      PrefabConversionMethod conversionMethod,
      string saveDirectoryPath,
      string saveToLoad,
      bool debugEventsDisabled,
      bool adminOnlyDebugEvents,
      bool enableDangerousDebugEvents,
      bool everyoneIsAdmin,
      FirstTimeSpawnServerSetting firstTimeSpawnServerSetting,
      bool compressSaveFiles,
      bool autoSave,
      int autoSaveCount,
      float autoSaveIntervalSeconds,
      bool saveOnExit,
      PersistenceDebugFlags persistenceDebugFlags,
      bool keepAliveOnError,
      bool hostLAN)
    {
      IntPtr* numPtr = stackalloc IntPtr[16];
      numPtr[0] = (IntPtr) &conversionMethod;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(saveDirectoryPath);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(saveToLoad);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &debugEventsDisabled;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &adminOnlyDebugEvents;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &enableDangerousDebugEvents;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &everyoneIsAdmin;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &firstTimeSpawnServerSetting;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(8) * sizeof (IntPtr))) = (IntPtr) &compressSaveFiles;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(9) * sizeof (IntPtr))) = (IntPtr) &autoSave;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(10) * sizeof (IntPtr))) = (IntPtr) &autoSaveCount;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(11) * sizeof (IntPtr))) = (IntPtr) &autoSaveIntervalSeconds;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(12) * sizeof (IntPtr))) = (IntPtr) &saveOnExit;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(13) * sizeof (IntPtr))) = (IntPtr) &persistenceDebugFlags;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(14) * sizeof (IntPtr))) = (IntPtr) &keepAliveOnError;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(15) * sizeof (IntPtr))) = (IntPtr) &hostLAN;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerWorldManager.NativeMethodInfoPtr_CreateSaveConfiguration_Public_Static_ServerRuntimeSettings_PrefabConversionMethod_String_String_Boolean_Boolean_Boolean_Boolean_FirstTimeSpawnServerSetting_Boolean_Boolean_Int32_Single_Boolean_PersistenceDebugFlags_Boolean_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerRuntimeSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerWorldManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986885, XrefRangeEnd = 986889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FinalizeCreateServerWorld()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWorldManager.NativeMethodInfoPtr_FinalizeCreateServerWorld_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986889, XrefRangeEnd = 986900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddOrUpdatePhysicsSingleton()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWorldManager.NativeMethodInfoPtr_AddOrUpdatePhysicsSingleton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerWorldManager()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerWorldManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerWorldManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerWorldManager()
    {
      Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServerWorldManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr);
      ServerWorldManager.NativeFieldInfoPtr__ServerWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, nameof (_ServerWorld));
      ServerWorldManager.NativeFieldInfoPtr__GameBootstrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, nameof (_GameBootstrap));
      ServerWorldManager.NativeMethodInfoPtr_get_ServerWorld_Public_get_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676108);
      ServerWorldManager.NativeMethodInfoPtr_InitializeGameBootstrap_Public_Void_GameBootstrap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676109);
      ServerWorldManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676110);
      ServerWorldManager.NativeMethodInfoPtr_DestroyServerWorld_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676111);
      ServerWorldManager.NativeMethodInfoPtr_BeginCreateServerWorld_Public_Void_ServerRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676112);
      ServerWorldManager.NativeMethodInfoPtr_CreateSaveConfiguration_Public_ServerRuntimeSettings_PrefabConversionMethod_String_String_Boolean_Boolean_Boolean_Boolean_FirstTimeSpawnServerSetting_PersistenceDebugFlags_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676113);
      ServerWorldManager.NativeMethodInfoPtr_CreateSaveConfiguration_Public_Static_ServerRuntimeSettings_PrefabConversionMethod_String_String_Boolean_Boolean_Boolean_Boolean_FirstTimeSpawnServerSetting_Boolean_Boolean_Int32_Single_Boolean_PersistenceDebugFlags_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676114);
      ServerWorldManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676115);
      ServerWorldManager.NativeMethodInfoPtr_FinalizeCreateServerWorld_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676116);
      ServerWorldManager.NativeMethodInfoPtr_AddOrUpdatePhysicsSingleton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676117);
      ServerWorldManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676118);
      ServerWorldManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerWorldManager>.NativeClassPtr, 100676119);
    }

    public ServerWorldManager(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CustomWorld _ServerWorld
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWorldManager.NativeFieldInfoPtr__ServerWorld));
        return pointer == IntPtr.Zero ? (CustomWorld) null : new CustomWorld(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerWorldManager.NativeFieldInfoPtr__ServerWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameBootstrap _GameBootstrap
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerWorldManager.NativeFieldInfoPtr__GameBootstrap));
        return pointer == IntPtr.Zero ? (GameBootstrap) null : new GameBootstrap(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerWorldManager.NativeFieldInfoPtr__GameBootstrap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
