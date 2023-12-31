// Decompiled with JetBrains decompiler
// Type: ProjectM.CustomWorldSpawning
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Scenes;

#nullable disable
namespace ProjectM
{
  public static class CustomWorldSpawning : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SpawnAndSetupBasicWorld_Public_Static_World_WorldType_String_Boolean_Il2CppReferenceArray_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSceneSystemConfigurationIfExists_Public_Static_Void_World_Nullable_Unboxed_1_SceneSystemConfiguration_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterSystemsForWorldType_Public_Static_HashSet_1_Type_WorldTypeConfiguration_IEnumerable_1_Type_Nullable_Unboxed_1_ApplicationType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterSystemsForWorldType_Public_Static_HashSet_1_Type_WorldTypeConfiguration_IEnumerable_1_Type_Boolean_Boolean_Boolean_Nullable_Unboxed_1_ApplicationType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterSystemsForWorldType_Public_Static_HashSet_1_Type_WorldTypeConfiguration_IEnumerable_1_Type_Type_Type_Type_Nullable_Unboxed_1_ApplicationType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSpawnInWorld_Public_Static_Boolean_Type_WorldType_ApplicationType_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoesAnyRootGroupExist_Private_Static_Boolean_Type_Type_Type_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupWorldWithCustomRootGroups_Public_Static_CustomWorld_World_World_WorldTypeConfiguration_Type_Type_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldTypeConfig_Public_Static_WorldTypeConfiguration_WorldType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupWorldWithCustomRootGroups_Public_Static_CustomWorld_World_World_WorldTypeConfiguration_IEnumerable_1_Type_Type_Type_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSystemsToWorld_Public_Static_Void_World_WorldTypeConfiguration_Il2CppReferenceArray_1_Type_Type_Type_Type_CustomWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSystemToGroups_Private_Static_Void_World_byref_CoreSystemGroups_Type_T_Action_2_T_ComponentSystemGroup_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoCustomSystemHandling_Private_Static_Boolean_World_Type_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRootGroupOrRootBarrier_Private_Static_Boolean_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupCoreGroupAndBarriers_Private_Static_ComponentSystemGroup_World_Type_Type_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySetupTicking_Private_Static_Void_ComponentSystemGroup_CustomWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDefaultWorldWithBootstrap_Public_Static_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_T_Type_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 721152, RefRangeEnd = 721154, XrefRangeStart = 721100, XrefRangeEnd = 721152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe World SpawnAndSetupBasicWorld(
      WorldType worldType,
      string customName = null,
      bool registerUpdateAndRenderInPlayerLoop = true,
      Il2CppReferenceArray<Il2CppSystem.Type> additionalSystems = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(customName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &registerUpdateAndRenderInPlayerLoop;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) additionalSystems);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_SpawnAndSetupBasicWorld_Public_Static_World_WorldType_String_Boolean_Il2CppReferenceArray_1_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721154, XrefRangeEnd = 721159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateSceneSystemConfigurationIfExists(
      World world,
      Nullable_Unboxed<SceneSystemConfiguration> sceneSystemConfiguration)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sceneSystemConfiguration;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_CreateSceneSystemConfigurationIfExists_Public_Static_Void_World_Nullable_Unboxed_1_SceneSystemConfiguration_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 721176, RefRangeEnd = 721177, XrefRangeStart = 721159, XrefRangeEnd = 721176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe HashSet<Il2CppSystem.Type> FilterSystemsForWorldType(
      WorldTypeConfiguration worldConfig,
      IEnumerable<Il2CppSystem.Type> systems,
      Nullable_Unboxed<ApplicationType> applicationType = default (Nullable_Unboxed<ApplicationType>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) worldConfig));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systems);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &applicationType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_FilterSystemsForWorldType_Public_Static_HashSet_1_Type_WorldTypeConfiguration_IEnumerable_1_Type_Nullable_Unboxed_1_ApplicationType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (HashSet<Il2CppSystem.Type>) null : new HashSet<Il2CppSystem.Type>(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721177, XrefRangeEnd = 721197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe HashSet<Il2CppSystem.Type> FilterSystemsForWorldType(
      WorldTypeConfiguration worldConfig,
      IEnumerable<Il2CppSystem.Type> systems,
      bool includeInitializationSystemGroup,
      bool includeSimulationSystemGroup,
      bool includePresentationSystemGroup,
      Nullable_Unboxed<ApplicationType> applicationType = default (Nullable_Unboxed<ApplicationType>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) worldConfig));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systems);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &includeInitializationSystemGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &includeSimulationSystemGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &includePresentationSystemGroup;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &applicationType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_FilterSystemsForWorldType_Public_Static_HashSet_1_Type_WorldTypeConfiguration_IEnumerable_1_Type_Boolean_Boolean_Boolean_Nullable_Unboxed_1_ApplicationType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (HashSet<Il2CppSystem.Type>) null : new HashSet<Il2CppSystem.Type>(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 721270, RefRangeEnd = 721274, XrefRangeStart = 721197, XrefRangeEnd = 721270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe HashSet<Il2CppSystem.Type> FilterSystemsForWorldType(
      WorldTypeConfiguration worldConfig,
      IEnumerable<Il2CppSystem.Type> systems,
      Il2CppSystem.Type initializationSystemGroupType,
      Il2CppSystem.Type simulationSystemGroupType,
      Il2CppSystem.Type presentationSystemGroupType,
      Nullable_Unboxed<ApplicationType> applicationType = default (Nullable_Unboxed<ApplicationType>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) worldConfig));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systems);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initializationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) simulationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) presentationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &applicationType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_FilterSystemsForWorldType_Public_Static_HashSet_1_Type_WorldTypeConfiguration_IEnumerable_1_Type_Type_Type_Type_Nullable_Unboxed_1_ApplicationType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (HashSet<Il2CppSystem.Type>) null : new HashSet<Il2CppSystem.Type>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 721305, RefRangeEnd = 721306, XrefRangeStart = 721274, XrefRangeEnd = 721305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShouldSpawnInWorld(
      Il2CppSystem.Type systemType,
      WorldType worldType,
      ApplicationType application,
      bool requireExplicitSpawnInWorldAttribute = true)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &application;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &requireExplicitSpawnInWorldAttribute;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_ShouldSpawnInWorld_Public_Static_Boolean_Type_WorldType_ApplicationType_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 721344, RefRangeEnd = 721346, XrefRangeStart = 721306, XrefRangeEnd = 721344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool DoesAnyRootGroupExist(
      Il2CppSystem.Type systemType,
      Il2CppSystem.Type initializationSystemGroupType,
      Il2CppSystem.Type simulationSystemGroupType,
      Il2CppSystem.Type presentationSystemGroupType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initializationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) simulationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) presentationSystemGroupType);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_DoesAnyRootGroupExist_Private_Static_Boolean_Type_Type_Type_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721346, XrefRangeEnd = 721369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CustomWorld SetupWorldWithCustomRootGroups(
      World world,
      World parentTickerWorld,
      WorldTypeConfiguration worldTypeConfig,
      Il2CppSystem.Type initializationSystemGroupType,
      Il2CppSystem.Type simulationSystemGroupType,
      Il2CppSystem.Type presentationSystemGroupType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parentTickerWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) worldTypeConfig));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initializationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) simulationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) presentationSystemGroupType);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_SetupWorldWithCustomRootGroups_Public_Static_CustomWorld_World_World_WorldTypeConfiguration_Type_Type_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CustomWorld) null : new CustomWorld(pointer);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 721422, RefRangeEnd = 721430, XrefRangeStart = 721369, XrefRangeEnd = 721422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe WorldTypeConfiguration GetWorldTypeConfig(WorldType worldType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldType;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_GetWorldTypeConfig_Public_Static_WorldTypeConfiguration_WorldType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new WorldTypeConfiguration(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 721534, RefRangeEnd = 721537, XrefRangeStart = 721430, XrefRangeEnd = 721534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CustomWorld SetupWorldWithCustomRootGroups(
      World world,
      World parentTickerWorld,
      WorldTypeConfiguration worldConfig,
      IEnumerable<Il2CppSystem.Type> allSystems,
      Il2CppSystem.Type initializationSystemGroupType,
      Il2CppSystem.Type simulationSystemGroupType,
      Il2CppSystem.Type presentationSystemGroupType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parentTickerWorld);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) worldConfig));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) allSystems);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initializationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) simulationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) presentationSystemGroupType);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_SetupWorldWithCustomRootGroups_Public_Static_CustomWorld_World_World_WorldTypeConfiguration_IEnumerable_1_Type_Type_Type_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CustomWorld) null : new CustomWorld(pointer);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 721732, RefRangeEnd = 721737, XrefRangeStart = 721537, XrefRangeEnd = 721732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddSystemsToWorld(
      World world,
      WorldTypeConfiguration worldTypeConfig,
      Il2CppReferenceArray<Il2CppSystem.Type> systemTypes,
      Il2CppSystem.Type initializationSystemGroupType,
      Il2CppSystem.Type simulationSystemGroupType,
      Il2CppSystem.Type presentationSystemGroupType,
      CustomWorld customWorld = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) worldTypeConfig));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemTypes);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initializationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) simulationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) presentationSystemGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) customWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_AddSystemsToWorld_Public_Static_Void_World_WorldTypeConfiguration_Il2CppReferenceArray_1_Type_Type_Type_Type_CustomWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 721841, RefRangeEnd = 721842, XrefRangeStart = 721737, XrefRangeEnd = 721841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddSystemToGroups<T>(
      World world,
      ref CustomWorldSpawning.CoreSystemGroups coreSystemGroups,
      Il2CppSystem.Type systemType,
      T system,
      Il2CppSystem.Action<T, ComponentSystemGroup> addToGroup)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) coreSystemGroups);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemType);
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) system;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref system;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) addToGroup);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.MethodInfoStoreGeneric_AddSystemToGroups_Private_Static_Void_World_byref_CoreSystemGroups_Type_T_Action_2_T_ComponentSystemGroup_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 721868, RefRangeEnd = 721869, XrefRangeStart = 721842, XrefRangeEnd = 721868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool DoCustomSystemHandling(
      World world,
      Il2CppSystem.Type systemType,
      ComponentSystemBase system)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) system);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_DoCustomSystemHandling_Private_Static_Boolean_World_Type_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 721915, RefRangeEnd = 721916, XrefRangeStart = 721869, XrefRangeEnd = 721915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsRootGroupOrRootBarrier(Il2CppSystem.Type systemType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemType);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_IsRootGroupOrRootBarrier_Private_Static_Boolean_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 721933, RefRangeEnd = 721936, XrefRangeStart = 721916, XrefRangeEnd = 721933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ComponentSystemGroup SetupCoreGroupAndBarriers(
      World world,
      Il2CppSystem.Type coreGroupType,
      Il2CppSystem.Type beginBarrierType,
      Il2CppSystem.Type endBarrierType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) coreGroupType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) beginBarrierType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) endBarrierType);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_SetupCoreGroupAndBarriers_Private_Static_ComponentSystemGroup_World_Type_Type_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ComponentSystemGroup) null : new ComponentSystemGroup(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721936, XrefRangeEnd = 721956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TrySetupTicking(
      ComponentSystemGroup realGroup,
      CustomWorld customWorld)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) realGroup);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) customWorld);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_TrySetupTicking_Private_Static_Void_ComponentSystemGroup_CustomWorld_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 721981, RefRangeEnd = 721982, XrefRangeStart = 721956, XrefRangeEnd = 721981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void InitializeDefaultWorldWithBootstrap(string defaultWorldName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(defaultWorldName);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.NativeMethodInfoPtr_InitializeDefaultWorldWithBootstrap_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 722003, RefRangeEnd = 722005, XrefRangeStart = 721982, XrefRangeEnd = 722003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe T Method_Internal_Static_T_Type_0<T>(Il2CppSystem.Type type) where T : class
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.MethodInfoStoreGeneric_Method_Internal_Static_T_Type_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }

    static CustomWorldSpawning()
    {
      Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CustomWorldSpawning));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr);
      CustomWorldSpawning.NativeMethodInfoPtr_SpawnAndSetupBasicWorld_Public_Static_World_WorldType_String_Boolean_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663727);
      CustomWorldSpawning.NativeMethodInfoPtr_CreateSceneSystemConfigurationIfExists_Public_Static_Void_World_Nullable_Unboxed_1_SceneSystemConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663728);
      CustomWorldSpawning.NativeMethodInfoPtr_FilterSystemsForWorldType_Public_Static_HashSet_1_Type_WorldTypeConfiguration_IEnumerable_1_Type_Nullable_Unboxed_1_ApplicationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663729);
      CustomWorldSpawning.NativeMethodInfoPtr_FilterSystemsForWorldType_Public_Static_HashSet_1_Type_WorldTypeConfiguration_IEnumerable_1_Type_Boolean_Boolean_Boolean_Nullable_Unboxed_1_ApplicationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663730);
      CustomWorldSpawning.NativeMethodInfoPtr_FilterSystemsForWorldType_Public_Static_HashSet_1_Type_WorldTypeConfiguration_IEnumerable_1_Type_Type_Type_Type_Nullable_Unboxed_1_ApplicationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663731);
      CustomWorldSpawning.NativeMethodInfoPtr_ShouldSpawnInWorld_Public_Static_Boolean_Type_WorldType_ApplicationType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663732);
      CustomWorldSpawning.NativeMethodInfoPtr_DoesAnyRootGroupExist_Private_Static_Boolean_Type_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663733);
      CustomWorldSpawning.NativeMethodInfoPtr_SetupWorldWithCustomRootGroups_Public_Static_CustomWorld_World_World_WorldTypeConfiguration_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663734);
      CustomWorldSpawning.NativeMethodInfoPtr_GetWorldTypeConfig_Public_Static_WorldTypeConfiguration_WorldType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663735);
      CustomWorldSpawning.NativeMethodInfoPtr_SetupWorldWithCustomRootGroups_Public_Static_CustomWorld_World_World_WorldTypeConfiguration_IEnumerable_1_Type_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663736);
      CustomWorldSpawning.NativeMethodInfoPtr_AddSystemsToWorld_Public_Static_Void_World_WorldTypeConfiguration_Il2CppReferenceArray_1_Type_Type_Type_Type_CustomWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663737);
      CustomWorldSpawning.NativeMethodInfoPtr_AddSystemToGroups_Private_Static_Void_World_byref_CoreSystemGroups_Type_T_Action_2_T_ComponentSystemGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663738);
      CustomWorldSpawning.NativeMethodInfoPtr_DoCustomSystemHandling_Private_Static_Boolean_World_Type_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663739);
      CustomWorldSpawning.NativeMethodInfoPtr_IsRootGroupOrRootBarrier_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663740);
      CustomWorldSpawning.NativeMethodInfoPtr_SetupCoreGroupAndBarriers_Private_Static_ComponentSystemGroup_World_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663741);
      CustomWorldSpawning.NativeMethodInfoPtr_TrySetupTicking_Private_Static_Void_ComponentSystemGroup_CustomWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663742);
      CustomWorldSpawning.NativeMethodInfoPtr_InitializeDefaultWorldWithBootstrap_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663743);
      CustomWorldSpawning.NativeMethodInfoPtr_Method_Internal_Static_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, 100663744);
    }

    public CustomWorldSpawning(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ReservedEntityIndex
    {
      static ReservedEntityIndex()
      {
        Il2CppClassPointerStore<CustomWorldSpawning.ReservedEntityIndex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, nameof (ReservedEntityIndex));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWorldSpawning.ReservedEntityIndex>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomWorldSpawning.ReservedEntityIndex>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class CoreSystemGroups : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_InitializationSystemGroupType;
      private static readonly System.IntPtr NativeFieldInfoPtr_SimulationSystemGroupType;
      private static readonly System.IntPtr NativeFieldInfoPtr_PresentationSystemGroupType;
      private static readonly System.IntPtr NativeFieldInfoPtr_InitializationSystemGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_SimulationSystemGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_PresentationSystemGroup;

      static CoreSystemGroups()
      {
        Il2CppClassPointerStore<CustomWorldSpawning.CoreSystemGroups>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, nameof (CoreSystemGroups));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWorldSpawning.CoreSystemGroups>.NativeClassPtr);
        CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_InitializationSystemGroupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorldSpawning.CoreSystemGroups>.NativeClassPtr, nameof (InitializationSystemGroupType));
        CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_SimulationSystemGroupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorldSpawning.CoreSystemGroups>.NativeClassPtr, nameof (SimulationSystemGroupType));
        CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_PresentationSystemGroupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorldSpawning.CoreSystemGroups>.NativeClassPtr, nameof (PresentationSystemGroupType));
        CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_InitializationSystemGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorldSpawning.CoreSystemGroups>.NativeClassPtr, nameof (InitializationSystemGroup));
        CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_SimulationSystemGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorldSpawning.CoreSystemGroups>.NativeClassPtr, nameof (SimulationSystemGroup));
        CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_PresentationSystemGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorldSpawning.CoreSystemGroups>.NativeClassPtr, nameof (PresentationSystemGroup));
      }

      public CoreSystemGroups(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public CoreSystemGroups()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomWorldSpawning.CoreSystemGroups>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomWorldSpawning.CoreSystemGroups>.NativeClassPtr, data));
      }

      public unsafe Il2CppSystem.Type InitializationSystemGroupType
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_InitializationSystemGroupType));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_InitializationSystemGroupType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Type SimulationSystemGroupType
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_SimulationSystemGroupType));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_SimulationSystemGroupType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Type PresentationSystemGroupType
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_PresentationSystemGroupType));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_PresentationSystemGroupType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ComponentSystemGroup InitializationSystemGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_InitializationSystemGroup));
          return pointer == System.IntPtr.Zero ? (ComponentSystemGroup) null : new ComponentSystemGroup(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_InitializationSystemGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ComponentSystemGroup SimulationSystemGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_SimulationSystemGroup));
          return pointer == System.IntPtr.Zero ? (ComponentSystemGroup) null : new ComponentSystemGroup(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_SimulationSystemGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ComponentSystemGroup PresentationSystemGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_PresentationSystemGroup));
          return pointer == System.IntPtr.Zero ? (ComponentSystemGroup) null : new ComponentSystemGroup(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.CoreSystemGroups.NativeFieldInfoPtr_PresentationSystemGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.CustomWorldSpawning/<>c__DisplayClass6_0")]
    public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_worldType;
      private static readonly System.IntPtr NativeFieldInfoPtr_application;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ShouldSpawnInWorld_b__0_Internal_Boolean_SpawnInWorldAttribute_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ShouldSpawnInWorld_b__1_Internal_Boolean_SpawnInApplicationAttribute_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWorldSpawning.__c__DisplayClass6_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe bool _ShouldSpawnInWorld_b__0(SpawnInWorldAttribute x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.__c__DisplayClass6_0.NativeMethodInfoPtr__ShouldSpawnInWorld_b__0_Internal_Boolean_SpawnInWorldAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe bool _ShouldSpawnInWorld_b__1(SpawnInApplicationAttribute x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.__c__DisplayClass6_0.NativeMethodInfoPtr__ShouldSpawnInWorld_b__1_Internal_Boolean_SpawnInApplicationAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<CustomWorldSpawning.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWorldSpawning.__c__DisplayClass6_0>.NativeClassPtr);
        CustomWorldSpawning.__c__DisplayClass6_0.NativeFieldInfoPtr_worldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorldSpawning.__c__DisplayClass6_0>.NativeClassPtr, nameof (worldType));
        CustomWorldSpawning.__c__DisplayClass6_0.NativeFieldInfoPtr_application = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorldSpawning.__c__DisplayClass6_0>.NativeClassPtr, nameof (application));
        CustomWorldSpawning.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning.__c__DisplayClass6_0>.NativeClassPtr, 100663745);
        CustomWorldSpawning.__c__DisplayClass6_0.NativeMethodInfoPtr__ShouldSpawnInWorld_b__0_Internal_Boolean_SpawnInWorldAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning.__c__DisplayClass6_0>.NativeClassPtr, 100663746);
        CustomWorldSpawning.__c__DisplayClass6_0.NativeMethodInfoPtr__ShouldSpawnInWorld_b__1_Internal_Boolean_SpawnInApplicationAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning.__c__DisplayClass6_0>.NativeClassPtr, 100663747);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe WorldType worldType
      {
        get
        {
          return *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.__c__DisplayClass6_0.NativeFieldInfoPtr_worldType));
        }
        [param: In] set
        {
          *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.__c__DisplayClass6_0.NativeFieldInfoPtr_worldType)) = value;
        }
      }

      public unsafe ApplicationType application
      {
        get
        {
          return *(ApplicationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.__c__DisplayClass6_0.NativeFieldInfoPtr_application));
        }
        [param: In] set
        {
          *(ApplicationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomWorldSpawning.__c__DisplayClass6_0.NativeFieldInfoPtr_application)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.CustomWorldSpawning/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__11_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddSystemsToWorld_b__11_0_Internal_Void_ComponentSystemBase_ComponentSystemGroup_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddSystemsToWorld_b__11_1_Internal_Void_SystemHandleUntyped_ComponentSystemGroup_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomWorldSpawning.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721096, XrefRangeEnd = 721098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddSystemsToWorld_b__11_0(
        ComponentSystemBase sys,
        ComponentSystemGroup group)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sys);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.__c.NativeMethodInfoPtr__AddSystemsToWorld_b__11_0_Internal_Void_ComponentSystemBase_ComponentSystemGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721098, XrefRangeEnd = 721100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _AddSystemsToWorld_b__11_1(
        SystemHandleUntyped sys,
        ComponentSystemGroup group)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &sys;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CustomWorldSpawning.__c.NativeMethodInfoPtr__AddSystemsToWorld_b__11_1_Internal_Void_SystemHandleUntyped_ComponentSystemGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<CustomWorldSpawning.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomWorldSpawning.__c>.NativeClassPtr);
        CustomWorldSpawning.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorldSpawning.__c>.NativeClassPtr, "<>9");
        CustomWorldSpawning.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorldSpawning.__c>.NativeClassPtr, "<>9__11_0");
        CustomWorldSpawning.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomWorldSpawning.__c>.NativeClassPtr, "<>9__11_1");
        CustomWorldSpawning.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning.__c>.NativeClassPtr, 100663749);
        CustomWorldSpawning.__c.NativeMethodInfoPtr__AddSystemsToWorld_b__11_0_Internal_Void_ComponentSystemBase_ComponentSystemGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning.__c>.NativeClassPtr, 100663750);
        CustomWorldSpawning.__c.NativeMethodInfoPtr__AddSystemsToWorld_b__11_1_Internal_Void_SystemHandleUntyped_ComponentSystemGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomWorldSpawning.__c>.NativeClassPtr, 100663751);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe CustomWorldSpawning.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CustomWorldSpawning.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (CustomWorldSpawning.__c) null : new CustomWorldSpawning.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CustomWorldSpawning.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ComponentSystemBase, ComponentSystemGroup> __9__11_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CustomWorldSpawning.__c.NativeFieldInfoPtr___9__11_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ComponentSystemBase, ComponentSystemGroup>) null : new Il2CppSystem.Action<ComponentSystemBase, ComponentSystemGroup>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CustomWorldSpawning.__c.NativeFieldInfoPtr___9__11_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<SystemHandleUntyped, ComponentSystemGroup> __9__11_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CustomWorldSpawning.__c.NativeFieldInfoPtr___9__11_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<SystemHandleUntyped, ComponentSystemGroup>) null : new Il2CppSystem.Action<SystemHandleUntyped, ComponentSystemGroup>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CustomWorldSpawning.__c.NativeFieldInfoPtr___9__11_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_AddSystemToGroups_Private_Static_Void_World_byref_CoreSystemGroups_Type_T_Action_2_T_ComponentSystemGroup_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomWorldSpawning.NativeMethodInfoPtr_AddSystemToGroups_Private_Static_Void_World_byref_CoreSystemGroups_Type_T_Action_2_T_ComponentSystemGroup_0, Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_Method_Internal_Static_T_Type_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CustomWorldSpawning.NativeMethodInfoPtr_Method_Internal_Static_T_Type_0, Il2CppClassPointerStore<CustomWorldSpawning>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
