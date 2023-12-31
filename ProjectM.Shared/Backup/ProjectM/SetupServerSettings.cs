// Decompiled with JetBrains decompiler
// Type: ProjectM.SetupServerSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Gameplay.Scripting;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class SetupServerSettings : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__MainQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalRecipeRequirementBufferAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalTechItemRequirementBufferStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_6;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSettingsContainedWithinNewPrefabs_Private_Void_ServerGameBalanceSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSettingsWithDependenciesBetweenPrefabs_Private_Void_ServerGameBalanceSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsContainedWithinNewPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_6;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760566, XrefRangeEnd = 760572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupServerSettings.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760572, XrefRangeEnd = 760577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupServerSettings.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760577, XrefRangeEnd = 760587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupServerSettings.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 760605, RefRangeEnd = 760606, XrefRangeStart = 760587, XrefRangeEnd = 760605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateSettingsContainedWithinNewPrefabs(
      ServerGameBalanceSettings balanceSettings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &balanceSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr_UpdateSettingsContainedWithinNewPrefabs_Private_Void_ServerGameBalanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 760759, RefRangeEnd = 760760, XrefRangeStart = 760606, XrefRangeEnd = 760759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateSettingsWithDependenciesBetweenPrefabs(
      ServerGameBalanceSettings balanceSettings)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &balanceSettings;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr_UpdateSettingsWithDependenciesBetweenPrefabs_Private_Void_ServerGameBalanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetupServerSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760760, XrefRangeEnd = 760947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupServerSettings.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760947, XrefRangeEnd = 760963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSettingsContainedWithinNewPrefabs_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsContainedWithinNewPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760963, XrefRangeEnd = 760979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761001, RefRangeEnd = 761002, XrefRangeStart = 760979, XrefRangeEnd = 761001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761024, RefRangeEnd = 761025, XrefRangeStart = 761002, XrefRangeEnd = 761024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761047, RefRangeEnd = 761048, XrefRangeStart = 761025, XrefRangeEnd = 761047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761070, RefRangeEnd = 761071, XrefRangeStart = 761048, XrefRangeEnd = 761070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761093, RefRangeEnd = 761094, XrefRangeStart = 761071, XrefRangeEnd = 761093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761116, RefRangeEnd = 761117, XrefRangeStart = 761094, XrefRangeEnd = 761116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761139, RefRangeEnd = 761140, XrefRangeStart = 761117, XrefRangeEnd = 761139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761162, RefRangeEnd = 761163, XrefRangeStart = 761140, XrefRangeEnd = 761162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761167, RefRangeEnd = 761168, XrefRangeStart = 761163, XrefRangeEnd = 761167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761172, RefRangeEnd = 761173, XrefRangeStart = 761168, XrefRangeEnd = 761172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761177, RefRangeEnd = 761178, XrefRangeStart = 761173, XrefRangeEnd = 761177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761182, RefRangeEnd = 761183, XrefRangeStart = 761178, XrefRangeEnd = 761182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761187, RefRangeEnd = 761188, XrefRangeStart = 761183, XrefRangeEnd = 761187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761192, RefRangeEnd = 761193, XrefRangeStart = 761188, XrefRangeEnd = 761192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 761197, RefRangeEnd = 761198, XrefRangeStart = 761193, XrefRangeEnd = 761197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_6()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_6, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetupServerSettings()
    {
      Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SetupServerSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr);
      SetupServerSettings.NativeFieldInfoPtr__MainQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, nameof (_MainQuery));
      SetupServerSettings.NativeFieldInfoPtr__OriginalRecipeRequirementBufferAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, nameof (_OriginalRecipeRequirementBufferAmount));
      SetupServerSettings.NativeFieldInfoPtr__OriginalTechItemRequirementBufferStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, nameof (_OriginalTechItemRequirementBufferStacks));
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_entityQuery");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_profilerMarker");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_entityQuery");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_profilerMarker");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_entityQuery");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_profilerMarker");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_entityQuery");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_profilerMarker");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_entityQuery");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_profilerMarker");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_entityQuery");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_profilerMarker");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_entityQuery");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_profilerMarker");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_entityQuery");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_profilerMarker");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_entityQuery");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_profilerMarker");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_entityQuery");
      SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_profilerMarker");
      SetupServerSettings.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, nameof (_SingletonEntityQuery_ServerGameBalanceSettings_6));
      SetupServerSettings.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100666990);
      SetupServerSettings.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100666991);
      SetupServerSettings.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100666992);
      SetupServerSettings.NativeMethodInfoPtr_UpdateSettingsContainedWithinNewPrefabs_Private_Void_ServerGameBalanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100666993);
      SetupServerSettings.NativeMethodInfoPtr_UpdateSettingsWithDependenciesBetweenPrefabs_Private_Void_ServerGameBalanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100666994);
      SetupServerSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100666995);
      SetupServerSettings.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100666996);
      SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsContainedWithinNewPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100666997);
      SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100666998);
      SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100666999);
      SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667000);
      SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667001);
      SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667002);
      SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667003);
      SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667004);
      SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667005);
      SetupServerSettings.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667006);
      SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667007);
      SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667008);
      SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667009);
      SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667010);
      SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667011);
      SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667012);
      SetupServerSettings.NativeMethodInfoPtr_Method_Public_Static_Void_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, 100667013);
    }

    public SetupServerSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _MainQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr__MainQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr__MainQuery)) = value;
      }
    }

    public unsafe NativeHashMap<SetupServerSettings.PrefabBufferKey, int> _OriginalRecipeRequirementBufferAmount
    {
      get
      {
        return *(NativeHashMap<SetupServerSettings.PrefabBufferKey, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr__OriginalRecipeRequirementBufferAmount));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr__OriginalRecipeRequirementBufferAmount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<SetupServerSettings.PrefabBufferKey, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashMap<SetupServerSettings.PrefabBufferKey, int> _OriginalTechItemRequirementBufferStacks
    {
      get
      {
        return *(NativeHashMap<SetupServerSettings.PrefabBufferKey, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr__OriginalTechItemRequirementBufferStacks));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr__OriginalTechItemRequirementBufferStacks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<SetupServerSettings.PrefabBufferKey, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsContainedWithinNewPrefabs_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr___UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ServerGameBalanceSettings_6
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_6));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.NativeFieldInfoPtr__SingletonEntityQuery_ServerGameBalanceSettings_6)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct PrefabBufferKey
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_BufferIndex;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabBufferKey_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public int BufferIndex;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759128, XrefRangeEnd = 759129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(SetupServerSettings.PrefabBufferKey other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.PrefabBufferKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabBufferKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759129, XrefRangeEnd = 759133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.PrefabBufferKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.PrefabBufferKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static PrefabBufferKey()
      {
        Il2CppClassPointerStore<SetupServerSettings.PrefabBufferKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, nameof (PrefabBufferKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.PrefabBufferKey>.NativeClassPtr);
        SetupServerSettings.PrefabBufferKey.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.PrefabBufferKey>.NativeClassPtr, nameof (Entity));
        SetupServerSettings.PrefabBufferKey.NativeFieldInfoPtr_BufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.PrefabBufferKey>.NativeClassPtr, nameof (BufferIndex));
        SetupServerSettings.PrefabBufferKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PrefabBufferKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.PrefabBufferKey>.NativeClassPtr, 100667014);
        SetupServerSettings.PrefabBufferKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.PrefabBufferKey>.NativeClassPtr, 100667015);
        SetupServerSettings.PrefabBufferKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.PrefabBufferKey>.NativeClassPtr, 100667016);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.PrefabBufferKey>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/<>c__DisplayClass7_0")]
    public sealed class __c__DisplayClass7_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_balanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_overrideVBloodSettings;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSettingsContainedWithinNewPrefabs_b__0_Internal_Void_byref_RegisterPrefab_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass7_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSettingsContainedWithinNewPrefabs_b__0(
        [In] ref RegisterPrefab registerPrefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateSettingsContainedWithinNewPrefabs_b__0_Internal_Void_byref_RegisterPrefab_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass7_0>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
        SetupServerSettings.__c__DisplayClass7_0.NativeFieldInfoPtr_balanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass7_0>.NativeClassPtr, nameof (balanceSettings));
        SetupServerSettings.__c__DisplayClass7_0.NativeFieldInfoPtr_overrideVBloodSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass7_0>.NativeClassPtr, nameof (overrideVBloodSettings));
        SetupServerSettings.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass7_0>.NativeClassPtr, 100667017);
        SetupServerSettings.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateSettingsContainedWithinNewPrefabs_b__0_Internal_Void_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass7_0>.NativeClassPtr, 100667018);
      }

      public __c__DisplayClass7_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass7_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass7_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass7_0>.NativeClassPtr, data));
      }

      public unsafe SetupServerSettings __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SetupServerSettings) null : new SetupServerSettings(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerGameBalanceSettings balanceSettings
      {
        get
        {
          return *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass7_0.NativeFieldInfoPtr_balanceSettings));
        }
        [param: In] set
        {
          *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass7_0.NativeFieldInfoPtr_balanceSettings)) = value;
        }
      }

      public unsafe FixedList512<VBloodUnitSetting.StructData> overrideVBloodSettings
      {
        get
        {
          return *(FixedList512<VBloodUnitSetting.StructData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass7_0.NativeFieldInfoPtr_overrideVBloodSettings));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass7_0.NativeFieldInfoPtr_overrideVBloodSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FixedList512<VBloodUnitSetting.StructData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_originalRecipeRequirementBufferAmount;
      private static readonly System.IntPtr NativeFieldInfoPtr_originalTechItemRequirementBufferStacks;
      private static readonly System.IntPtr NativeFieldInfoPtr_legendaryWeaponMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_refinementstationRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr_workstationRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr_craftedItemToSourceRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr_balanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__0_Internal_Void_byref_RegisterPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__1_Internal_Void_Entity_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__2_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__3_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__4_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RecipeOutputBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__5_Internal_Void_Entity_byref_DynamicBuffer_1_RecipeRequirementBuffer_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__6_Internal_Void_Entity_byref_Durability_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__7_Internal_Void_Entity_byref_Salvageable_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__8_Internal_Void_Entity_byref_DynamicBuffer_1_TechItemRequirementBuffer_byref_PrefabGUID_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSettingsWithDependenciesBetweenPrefabs_b__0(
        [In] ref RegisterPrefab registerPrefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__0_Internal_Void_byref_RegisterPrefab_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSettingsWithDependenciesBetweenPrefabs_b__1(
        Entity prefabEntity,
        [In] ref PrefabGUID prefabGUID)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &prefabEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__1_Internal_Void_Entity_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSettingsWithDependenciesBetweenPrefabs_b__2(
        [In] ref PrefabGUID prefabGUID,
        [In] ref DynamicBuffer<RefinementstationRecipesBuffer> recipes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref recipes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__2_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSettingsWithDependenciesBetweenPrefabs_b__3(
        [In] ref PrefabGUID prefabGUID,
        [In] ref DynamicBuffer<WorkstationRecipesBuffer> recipes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref recipes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__3_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSettingsWithDependenciesBetweenPrefabs_b__4(
        [In] ref PrefabGUID prefabGUID,
        [In] ref DynamicBuffer<RecipeOutputBuffer> outputs)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outputs;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__4_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RecipeOutputBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSettingsWithDependenciesBetweenPrefabs_b__5(
        Entity prefabEntity,
        ref DynamicBuffer<RecipeRequirementBuffer> recipeRequirements,
        [In] ref PrefabGUID prefabGUID)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &prefabEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref recipeRequirements;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__5_Internal_Void_Entity_byref_DynamicBuffer_1_RecipeRequirementBuffer_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSettingsWithDependenciesBetweenPrefabs_b__6(
        Entity prefabEntity,
        ref Durability durability,
        [In] ref PrefabGUID prefabGUID)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &prefabEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref durability;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__6_Internal_Void_Entity_byref_Durability_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSettingsWithDependenciesBetweenPrefabs_b__7(
        Entity prefabEntity,
        ref Salvageable salvageable,
        [In] ref PrefabGUID prefabGUID)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &prefabEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref salvageable;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__7_Internal_Void_Entity_byref_Salvageable_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _UpdateSettingsWithDependenciesBetweenPrefabs_b__8(
        Entity prefabEntity,
        ref DynamicBuffer<TechItemRequirementBuffer> researchRequirements,
        [In] ref PrefabGUID prefabGUID)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &prefabEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref researchRequirements;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__8_Internal_Void_Entity_byref_DynamicBuffer_1_TechItemRequirementBuffer_byref_PrefabGUID_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_originalRecipeRequirementBufferAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, nameof (originalRecipeRequirementBufferAmount));
        SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_originalTechItemRequirementBufferStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, nameof (originalTechItemRequirementBufferStacks));
        SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_legendaryWeaponMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, nameof (legendaryWeaponMap));
        SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_refinementstationRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, nameof (refinementstationRecipes));
        SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_workstationRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, nameof (workstationRecipes));
        SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_craftedItemToSourceRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, nameof (craftedItemToSourceRecipes));
        SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_balanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, nameof (balanceSettings));
        SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, nameof (entityManager));
        SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, 100667019);
        SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__0_Internal_Void_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, 100667020);
        SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__1_Internal_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, 100667021);
        SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__2_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, 100667022);
        SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__3_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, 100667023);
        SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__4_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RecipeOutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, 100667024);
        SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__5_Internal_Void_Entity_byref_DynamicBuffer_1_RecipeRequirementBuffer_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, 100667025);
        SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__6_Internal_Void_Entity_byref_Durability_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, 100667026);
        SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__7_Internal_Void_Entity_byref_Salvageable_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, 100667027);
        SetupServerSettings.__c__DisplayClass8_0.NativeMethodInfoPtr__UpdateSettingsWithDependenciesBetweenPrefabs_b__8_Internal_Void_Entity_byref_DynamicBuffer_1_TechItemRequirementBuffer_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, 100667028);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass8_0>.NativeClassPtr, data));
      }

      public unsafe SetupServerSettings __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SetupServerSettings) null : new SetupServerSettings(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<SetupServerSettings.PrefabBufferKey, int> originalRecipeRequirementBufferAmount
      {
        get
        {
          return *(NativeHashMap<SetupServerSettings.PrefabBufferKey, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_originalRecipeRequirementBufferAmount));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_originalRecipeRequirementBufferAmount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<SetupServerSettings.PrefabBufferKey, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<SetupServerSettings.PrefabBufferKey, int> originalTechItemRequirementBufferStacks
      {
        get
        {
          return *(NativeHashMap<SetupServerSettings.PrefabBufferKey, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_originalTechItemRequirementBufferStacks));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_originalTechItemRequirementBufferStacks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<SetupServerSettings.PrefabBufferKey, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<PrefabGUID, Entity> legendaryWeaponMap
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_legendaryWeaponMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_legendaryWeaponMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashSet<PrefabGUID> refinementstationRecipes
      {
        get
        {
          return *(NativeHashSet<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_refinementstationRecipes));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_refinementstationRecipes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashSet<PrefabGUID> workstationRecipes
      {
        get
        {
          return *(NativeHashSet<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_workstationRecipes));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_workstationRecipes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeMultiHashMap<PrefabGUID, PrefabGUID> craftedItemToSourceRecipes
      {
        get
        {
          return *(NativeMultiHashMap<PrefabGUID, PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_craftedItemToSourceRecipes));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_craftedItemToSourceRecipes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeMultiHashMap<PrefabGUID, PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServerGameBalanceSettings balanceSettings
      {
        get
        {
          return *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_balanceSettings));
        }
        [param: In] set
        {
          *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_balanceSettings)) = value;
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass8_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0")]
    public sealed class __c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0 : 
      Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_balanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_overrideVBloodSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Script_GarlicAreaDebuff_DataServer_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_HolyAreaDebuff_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_DealDamageOnGameplayEvent_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Script_SilverDebuff_DataServer_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_TakeDamageInSun_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_FloatModificationBuffer_6;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_DayNightCycle_7;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_UnitLevel_8;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_UnitStats_9;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_VBloodConsumeSource_10;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_UnitSpawnData_11;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ServantData_12;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Health_13;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Energy_14;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Equippable_15;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759379, RefRangeEnd = 759380, XrefRangeStart = 759141, XrefRangeEnd = 759379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref RegisterPrefab registerPrefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759382, RefRangeEnd = 759383, XrefRangeStart = 759380, XrefRangeEnd = 759382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupServerSettings.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759385, RefRangeEnd = 759386, XrefRangeStart = 759383, XrefRangeEnd = 759385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupServerSettings.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759386, XrefRangeEnd = 759388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759393, RefRangeEnd = 759394, XrefRangeStart = 759388, XrefRangeEnd = 759393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759444, RefRangeEnd = 759445, XrefRangeStart = 759394, XrefRangeEnd = 759444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupServerSettings componentSystem,
        ref SetupServerSettings.__c__DisplayClass7_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass7_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759445, XrefRangeEnd = 759451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, "<>4__this");
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr_balanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (balanceSettings));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr_overrideVBloodSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (overrideVBloodSettings));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_0));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Script_GarlicAreaDebuff_DataServer_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Script_GarlicAreaDebuff_DataServer_1));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_HolyAreaDebuff_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_HolyAreaDebuff_2));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__BufferFromEntity_DealDamageOnGameplayEvent_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_BufferFromEntity_DealDamageOnGameplayEvent_3));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Script_SilverDebuff_DataServer_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Script_SilverDebuff_DataServer_4));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_TakeDamageInSun_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_TakeDamageInSun_5));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__BufferFromEntity_FloatModificationBuffer_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_BufferFromEntity_FloatModificationBuffer_6));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_DayNightCycle_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_DayNightCycle_7));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitLevel_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_UnitLevel_8));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitStats_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_UnitStats_9));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_VBloodConsumeSource_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_VBloodConsumeSource_10));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitSpawnData_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_UnitSpawnData_11));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_ServantData_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_ServantData_12));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Health_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Health_13));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Energy_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Energy_14));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Equippable_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_Equippable_15));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, 100667029);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, 100667030);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, 100667031);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, 100667032);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, 100667033);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, 100667034);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, 100667035);
      }

      public __c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe SetupServerSettings __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SetupServerSettings) null : new SetupServerSettings(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerGameBalanceSettings balanceSettings
      {
        get
        {
          return *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr_balanceSettings));
        }
        [param: In] set
        {
          *(ServerGameBalanceSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr_balanceSettings)) = value;
        }
      }

      public unsafe FixedList512<VBloodUnitSetting.StructData> overrideVBloodSettings
      {
        get
        {
          return *(FixedList512<VBloodUnitSetting.StructData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr_overrideVBloodSettings));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr_overrideVBloodSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FixedList512<VBloodUnitSetting.StructData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_0
      {
        get
        {
          return *(ComponentDataFromEntity<PrefabGUID>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<PrefabGUID>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Script_GarlicAreaDebuff_DataServer> _ComponentDataFromEntity_Script_GarlicAreaDebuff_DataServer_1
      {
        get
        {
          return *(ComponentDataFromEntity<Script_GarlicAreaDebuff_DataServer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Script_GarlicAreaDebuff_DataServer_1));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Script_GarlicAreaDebuff_DataServer_1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Script_GarlicAreaDebuff_DataServer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<HolyAreaDebuff> _ComponentDataFromEntity_HolyAreaDebuff_2
      {
        get
        {
          return *(ComponentDataFromEntity<HolyAreaDebuff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_HolyAreaDebuff_2));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_HolyAreaDebuff_2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<HolyAreaDebuff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BufferFromEntity<DealDamageOnGameplayEvent> _BufferFromEntity_DealDamageOnGameplayEvent_3
      {
        get
        {
          return *(BufferFromEntity<DealDamageOnGameplayEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__BufferFromEntity_DealDamageOnGameplayEvent_3));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__BufferFromEntity_DealDamageOnGameplayEvent_3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<DealDamageOnGameplayEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Script_SilverDebuff_DataServer> _ComponentDataFromEntity_Script_SilverDebuff_DataServer_4
      {
        get
        {
          return *(ComponentDataFromEntity<Script_SilverDebuff_DataServer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Script_SilverDebuff_DataServer_4));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Script_SilverDebuff_DataServer_4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Script_SilverDebuff_DataServer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<TakeDamageInSun> _ComponentDataFromEntity_TakeDamageInSun_5
      {
        get
        {
          return *(ComponentDataFromEntity<TakeDamageInSun>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_TakeDamageInSun_5));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_TakeDamageInSun_5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<TakeDamageInSun>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BufferFromEntity<FloatModificationBuffer> _BufferFromEntity_FloatModificationBuffer_6
      {
        get
        {
          return *(BufferFromEntity<FloatModificationBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__BufferFromEntity_FloatModificationBuffer_6));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__BufferFromEntity_FloatModificationBuffer_6), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<FloatModificationBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<DayNightCycle> _ComponentDataFromEntity_DayNightCycle_7
      {
        get
        {
          return *(ComponentDataFromEntity<DayNightCycle>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_DayNightCycle_7));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_DayNightCycle_7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<DayNightCycle>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<UnitLevel> _ComponentDataFromEntity_UnitLevel_8
      {
        get
        {
          return *(ComponentDataFromEntity<UnitLevel>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitLevel_8));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitLevel_8), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<UnitLevel>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<UnitStats> _ComponentDataFromEntity_UnitStats_9
      {
        get
        {
          return *(ComponentDataFromEntity<UnitStats>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitStats_9));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitStats_9), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<UnitStats>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<VBloodConsumeSource> _ComponentDataFromEntity_VBloodConsumeSource_10
      {
        get
        {
          return *(ComponentDataFromEntity<VBloodConsumeSource>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_VBloodConsumeSource_10));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_VBloodConsumeSource_10), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<VBloodConsumeSource>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<UnitSpawnData> _ComponentDataFromEntity_UnitSpawnData_11
      {
        get
        {
          return *(ComponentDataFromEntity<UnitSpawnData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitSpawnData_11));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_UnitSpawnData_11), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<UnitSpawnData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<ServantData> _ComponentDataFromEntity_ServantData_12
      {
        get
        {
          return *(ComponentDataFromEntity<ServantData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_ServantData_12));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_ServantData_12), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<ServantData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Health> _ComponentDataFromEntity_Health_13
      {
        get
        {
          return *(ComponentDataFromEntity<Health>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Health_13));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Health_13), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Health>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Energy> _ComponentDataFromEntity_Energy_14
      {
        get
        {
          return *(ComponentDataFromEntity<Energy>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Energy_14));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Energy_14), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Energy>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Equippable> _ComponentDataFromEntity_Equippable_15
      {
        get
        {
          return *(ComponentDataFromEntity<Equippable>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Equippable_15));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_Equippable_15), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Equippable>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerPrefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefab> forParameter_registerPrefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759136, RefRangeEnd = 759137, XrefRangeStart = 759133, XrefRangeEnd = 759136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupServerSettings componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759140, RefRangeEnd = 759141, XrefRangeStart = 759137, XrefRangeEnd = 759140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerPrefab));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667036);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667037);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerPrefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefab>.Runtime runtime_registerPrefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerPrefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsContainedWithinNewPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0")]
    public sealed class __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0 : 
      Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_originalRecipeRequirementBufferAmount;
      private static readonly System.IntPtr NativeFieldInfoPtr_originalTechItemRequirementBufferStacks;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759488, RefRangeEnd = 759489, XrefRangeStart = 759459, XrefRangeEnd = 759488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref RegisterPrefab registerPrefab)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref registerPrefab;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759490, RefRangeEnd = 759491, XrefRangeStart = 759489, XrefRangeEnd = 759490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 759492, RefRangeEnd = 759494, XrefRangeStart = 759491, XrefRangeEnd = 759492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759494, XrefRangeEnd = 759496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759501, RefRangeEnd = 759502, XrefRangeStart = 759496, XrefRangeEnd = 759501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759504, RefRangeEnd = 759505, XrefRangeStart = 759502, XrefRangeEnd = 759504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupServerSettings componentSystem,
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759505, XrefRangeEnd = 759511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, "<>4__this");
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr_originalRecipeRequirementBufferAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, nameof (originalRecipeRequirementBufferAmount));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr_originalTechItemRequirementBufferStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, nameof (originalTechItemRequirementBufferStacks));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RegisterPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, 100667038);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, 100667039);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, 100667040);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, 100667041);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, 100667042);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, 100667043);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, 100667044);
      }

      public __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0(
        System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe SetupServerSettings __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SetupServerSettings) null : new SetupServerSettings(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<SetupServerSettings.PrefabBufferKey, int> originalRecipeRequirementBufferAmount
      {
        get
        {
          return *(NativeHashMap<SetupServerSettings.PrefabBufferKey, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr_originalRecipeRequirementBufferAmount));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr_originalRecipeRequirementBufferAmount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<SetupServerSettings.PrefabBufferKey, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<SetupServerSettings.PrefabBufferKey, int> originalTechItemRequirementBufferStacks
      {
        get
        {
          return *(NativeHashMap<SetupServerSettings.PrefabBufferKey, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr_originalTechItemRequirementBufferStacks));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr_originalTechItemRequirementBufferStacks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<SetupServerSettings.PrefabBufferKey, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_registerPrefab;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RegisterPrefab> forParameter_registerPrefab;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759454, RefRangeEnd = 759455, XrefRangeStart = 759451, XrefRangeEnd = 759454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupServerSettings componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759458, RefRangeEnd = 759459, XrefRangeStart = 759455, XrefRangeEnd = 759458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_registerPrefab));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667045);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667046);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_registerPrefab;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RegisterPrefab>.Runtime runtime_registerPrefab;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_registerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_registerPrefab));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_legendaryWeaponMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, Entity> legendaryWeaponMap;
      [FieldOffset(16)]
      public SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759596, XrefRangeEnd = 759599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity prefabEntity, [In] ref PrefabGUID prefabGUID)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &prefabEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 759599, RefRangeEnd = 759601, XrefRangeStart = 759599, XrefRangeEnd = 759599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 759601, RefRangeEnd = 759603, XrefRangeStart = 759601, XrefRangeEnd = 759601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759603, XrefRangeEnd = 759605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759611, RefRangeEnd = 759612, XrefRangeStart = 759605, XrefRangeEnd = 759611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759614, RefRangeEnd = 759615, XrefRangeStart = 759612, XrefRangeEnd = 759614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupServerSettings componentSystem,
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759615, XrefRangeEnd = 759619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759619, XrefRangeEnd = 759625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeFieldInfoPtr_legendaryWeaponMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, nameof (legendaryWeaponMap));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, 100667047);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, 100667048);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, 100667049);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, 100667050);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, 100667051);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, 100667052);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, 100667053);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, 100667054);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_prefabEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759515, RefRangeEnd = 759516, XrefRangeStart = 759511, XrefRangeEnd = 759515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupServerSettings componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759520, RefRangeEnd = 759521, XrefRangeStart = 759516, XrefRangeEnd = 759520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabEntity));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100667055);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100667056);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_prefabEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabEntity));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1/ProjectM.RunWithoutJobSystem_00000D1A$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000D1A$PostfixBurstDelegate");
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667057);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667058);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667059);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667060);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1/ProjectM.RunWithoutJobSystem_00000D1A$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759521, XrefRangeEnd = 759535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759535, XrefRangeEnd = 759553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759553, XrefRangeEnd = 759568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759595, RefRangeEnd = 759596, XrefRangeStart = 759568, XrefRangeEnd = 759595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00000D1A$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667061);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667062);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667063);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667064);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667066);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_refinementstationRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<PrefabGUID> refinementstationRecipes;
      [FieldOffset(16)]
      public SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759714, XrefRangeEnd = 759725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref PrefabGUID prefabGUID,
        [In] ref DynamicBuffer<RefinementstationRecipesBuffer> recipes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref recipes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 759725, RefRangeEnd = 759727, XrefRangeStart = 759725, XrefRangeEnd = 759725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 759727, RefRangeEnd = 759729, XrefRangeStart = 759727, XrefRangeEnd = 759727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759729, XrefRangeEnd = 759731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759739, RefRangeEnd = 759740, XrefRangeStart = 759731, XrefRangeEnd = 759739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759742, RefRangeEnd = 759743, XrefRangeStart = 759740, XrefRangeEnd = 759742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupServerSettings componentSystem,
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759743, XrefRangeEnd = 759747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759747, XrefRangeEnd = 759753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeFieldInfoPtr_refinementstationRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, nameof (refinementstationRecipes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RefinementstationRecipesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, 100667067);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, 100667068);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, 100667069);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, 100667070);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, 100667071);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, 100667072);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, 100667073);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, 100667074);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_recipes;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<RefinementstationRecipesBuffer> forParameter_recipes;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759631, RefRangeEnd = 759632, XrefRangeStart = 759625, XrefRangeEnd = 759631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupServerSettings componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759638, RefRangeEnd = 759639, XrefRangeStart = 759632, XrefRangeEnd = 759638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_recipes));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100667075);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100667076);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_recipes;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<RefinementstationRecipesBuffer>.Runtime runtime_recipes;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_recipes));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2/ProjectM.RunWithoutJobSystem_00000D23$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000D23$PostfixBurstDelegate");
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667077);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667078);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667079);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667080);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2/ProjectM.RunWithoutJobSystem_00000D23$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759639, XrefRangeEnd = 759653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759653, XrefRangeEnd = 759671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759671, XrefRangeEnd = 759686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759713, RefRangeEnd = 759714, XrefRangeStart = 759686, XrefRangeEnd = 759713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_00000D23$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667081);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667082);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667083);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667084);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667086);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_workstationRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<PrefabGUID> workstationRecipes;
      [FieldOffset(16)]
      public SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759842, XrefRangeEnd = 759853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref PrefabGUID prefabGUID,
        [In] ref DynamicBuffer<WorkstationRecipesBuffer> recipes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref recipes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 759853, RefRangeEnd = 759856, XrefRangeStart = 759853, XrefRangeEnd = 759853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 759856, RefRangeEnd = 759859, XrefRangeStart = 759856, XrefRangeEnd = 759856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759859, XrefRangeEnd = 759861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759869, RefRangeEnd = 759870, XrefRangeStart = 759861, XrefRangeEnd = 759869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759872, RefRangeEnd = 759873, XrefRangeStart = 759870, XrefRangeEnd = 759872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupServerSettings componentSystem,
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759873, XrefRangeEnd = 759877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759877, XrefRangeEnd = 759883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeFieldInfoPtr_workstationRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, nameof (workstationRecipes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, nameof (_runtimes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_WorkstationRecipesBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, 100667087);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, 100667088);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, 100667089);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, 100667090);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, 100667091);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, 100667092);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, 100667093);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, 100667094);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_recipes;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<WorkstationRecipesBuffer> forParameter_recipes;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759759, RefRangeEnd = 759760, XrefRangeStart = 759753, XrefRangeEnd = 759759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupServerSettings componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759766, RefRangeEnd = 759767, XrefRangeStart = 759760, XrefRangeEnd = 759766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_recipes));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100667095);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100667096);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_recipes;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<WorkstationRecipesBuffer>.Runtime runtime_recipes;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_recipes));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3/ProjectM.RunWithoutJobSystem_00000D2C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_00000D2C$PostfixBurstDelegate");
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667097);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667098);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667099);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667100);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3/ProjectM.RunWithoutJobSystem_00000D2C$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759767, XrefRangeEnd = 759781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759781, XrefRangeEnd = 759799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759799, XrefRangeEnd = 759814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759841, RefRangeEnd = 759842, XrefRangeStart = 759814, XrefRangeEnd = 759841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_00000D2C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667101);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667102);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667103);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667104);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667106);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_craftedItemToSourceRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RecipeOutputBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeMultiHashMap<PrefabGUID, PrefabGUID> craftedItemToSourceRecipes;
      [FieldOffset(16)]
      public SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759972, XrefRangeEnd = 759983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref PrefabGUID prefabGUID,
        [In] ref DynamicBuffer<RecipeOutputBuffer> outputs)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outputs;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RecipeOutputBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759983, RefRangeEnd = 759984, XrefRangeStart = 759983, XrefRangeEnd = 759983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759984, RefRangeEnd = 759985, XrefRangeStart = 759984, XrefRangeEnd = 759984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759985, XrefRangeEnd = 759987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759995, RefRangeEnd = 759996, XrefRangeStart = 759987, XrefRangeEnd = 759995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 759998, RefRangeEnd = 759999, XrefRangeStart = 759996, XrefRangeEnd = 759998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupServerSettings componentSystem,
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759999, XrefRangeEnd = 760003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760003, XrefRangeEnd = 760009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeFieldInfoPtr_craftedItemToSourceRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, nameof (craftedItemToSourceRecipes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, nameof (_runtimes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_PrefabGUID_byref_DynamicBuffer_1_RecipeOutputBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, 100667107);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, 100667108);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, 100667109);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, 100667110);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, 100667111);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, 100667112);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, 100667113);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, 100667114);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_outputs;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_DynamicBuffer<RecipeOutputBuffer> forParameter_outputs;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759889, RefRangeEnd = 759890, XrefRangeStart = 759883, XrefRangeEnd = 759889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupServerSettings componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759896, RefRangeEnd = 759897, XrefRangeStart = 759890, XrefRangeEnd = 759896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_outputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_outputs));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100667115);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100667116);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_outputs;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<RecipeOutputBuffer>.Runtime runtime_outputs;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_outputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_outputs));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4/ProjectM.RunWithoutJobSystem_00000D35$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_00000D35$PostfixBurstDelegate");
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667117);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667118);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667119);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667120);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4/ProjectM.RunWithoutJobSystem_00000D35$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759897, XrefRangeEnd = 759911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759911, XrefRangeEnd = 759929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759929, XrefRangeEnd = 759944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 759971, RefRangeEnd = 759972, XrefRangeStart = 759944, XrefRangeEnd = 759971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_00000D35$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667121);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667122);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667123);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667124);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667126);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_refinementstationRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr_balanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_workstationRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr_originalRecipeRequirementBufferAmount;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_RecipeRequirementBuffer_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public NativeHashSet<PrefabGUID> refinementstationRecipes;
      [FieldOffset(16)]
      public ServerGameBalanceSettings balanceSettings;
      [FieldOffset(1416)]
      public NativeHashSet<PrefabGUID> workstationRecipes;
      [FieldOffset(1432)]
      public NativeHashMap<SetupServerSettings.PrefabBufferKey, int> originalRecipeRequirementBufferAmount;
      [FieldOffset(1448)]
      public SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(1528)]
      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760106, RefRangeEnd = 760107, XrefRangeStart = 760025, XrefRangeEnd = 760106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity prefabEntity,
        ref DynamicBuffer<RecipeRequirementBuffer> recipeRequirements,
        [In] ref PrefabGUID prefabGUID)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &prefabEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref recipeRequirements;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_RecipeRequirementBuffer_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760108, RefRangeEnd = 760109, XrefRangeStart = 760107, XrefRangeEnd = 760108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760110, RefRangeEnd = 760111, XrefRangeStart = 760109, XrefRangeEnd = 760110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760111, XrefRangeEnd = 760113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760122, RefRangeEnd = 760123, XrefRangeStart = 760113, XrefRangeEnd = 760122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760125, RefRangeEnd = 760126, XrefRangeStart = 760123, XrefRangeEnd = 760125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupServerSettings componentSystem,
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760126, XrefRangeEnd = 760132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeFieldInfoPtr_refinementstationRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, nameof (refinementstationRecipes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeFieldInfoPtr_balanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, nameof (balanceSettings));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeFieldInfoPtr_workstationRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, nameof (workstationRecipes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeFieldInfoPtr_originalRecipeRequirementBufferAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, nameof (originalRecipeRequirementBufferAmount));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, nameof (_runtimes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_RecipeRequirementBuffer_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, 100667127);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, 100667128);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, 100667129);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, 100667130);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, 100667131);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, 100667132);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, 100667133);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_recipeRequirements;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_prefabEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<RecipeRequirementBuffer> forParameter_recipeRequirements;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 760016, RefRangeEnd = 760017, XrefRangeStart = 760009, XrefRangeEnd = 760016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupServerSettings componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 760024, RefRangeEnd = 760025, XrefRangeStart = 760017, XrefRangeEnd = 760024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabEntity));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_recipeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_recipeRequirements));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, 100667134);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, 100667135);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_recipeRequirements;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_prefabEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<RecipeRequirementBuffer>.Runtime runtime_recipeRequirements;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabEntity));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_recipeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_recipeRequirements));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_legendaryWeaponMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_craftedItemToSourceRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Durability_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeHashMap<PrefabGUID, Entity> legendaryWeaponMap;
      [FieldOffset(24)]
      public NativeMultiHashMap<PrefabGUID, PrefabGUID> craftedItemToSourceRecipes;
      [FieldOffset(40)]
      public SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(112)]
      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760223, XrefRangeEnd = 760245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity prefabEntity,
        ref Durability durability,
        [In] ref PrefabGUID prefabGUID)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &prefabEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref durability;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Durability_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760245, RefRangeEnd = 760246, XrefRangeStart = 760245, XrefRangeEnd = 760245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760246, RefRangeEnd = 760247, XrefRangeStart = 760246, XrefRangeEnd = 760246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760247, XrefRangeEnd = 760249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760258, RefRangeEnd = 760259, XrefRangeStart = 760249, XrefRangeEnd = 760258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760261, RefRangeEnd = 760262, XrefRangeStart = 760259, XrefRangeEnd = 760261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupServerSettings componentSystem,
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760262, XrefRangeEnd = 760266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760266, XrefRangeEnd = 760272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, nameof (entityManager));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeFieldInfoPtr_legendaryWeaponMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, nameof (legendaryWeaponMap));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeFieldInfoPtr_craftedItemToSourceRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, nameof (craftedItemToSourceRecipes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, nameof (_runtimes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Durability_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, 100667136);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, 100667137);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, 100667138);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, 100667139);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, 100667140);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, 100667141);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, 100667142);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, 100667143);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_durability;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_prefabEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Durability> forParameter_durability;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 760139, RefRangeEnd = 760140, XrefRangeStart = 760132, XrefRangeEnd = 760139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupServerSettings componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 760147, RefRangeEnd = 760148, XrefRangeStart = 760140, XrefRangeEnd = 760147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabEntity));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_durability));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, 100667144);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, 100667145);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_durability;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_prefabEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Durability>.Runtime runtime_durability;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabEntity));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_durability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_durability));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6/ProjectM.RunWithoutJobSystem_00000D47$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, "RunWithoutJobSystem_00000D47$PostfixBurstDelegate");
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667146);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667147);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667148);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667149);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6/ProjectM.RunWithoutJobSystem_00000D47$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760148, XrefRangeEnd = 760162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760162, XrefRangeEnd = 760180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760180, XrefRangeEnd = 760195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 760222, RefRangeEnd = 760223, XrefRangeStart = 760195, XrefRangeEnd = 760222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6>.NativeClassPtr, "RunWithoutJobSystem_00000D47$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667150);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667151);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667152);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667153);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667155);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob6.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_craftedItemToSourceRecipes;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Salvageable_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeMultiHashMap<PrefabGUID, PrefabGUID> craftedItemToSourceRecipes;
      [FieldOffset(16)]
      public EntityManager entityManager;
      [FieldOffset(24)]
      public SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(96)]
      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760363, XrefRangeEnd = 760376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity prefabEntity,
        ref Salvageable salvageable,
        [In] ref PrefabGUID prefabGUID)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &prefabEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref salvageable;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Salvageable_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760376, RefRangeEnd = 760377, XrefRangeStart = 760376, XrefRangeEnd = 760376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760377, RefRangeEnd = 760378, XrefRangeStart = 760377, XrefRangeEnd = 760377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760378, XrefRangeEnd = 760380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760389, RefRangeEnd = 760390, XrefRangeStart = 760380, XrefRangeEnd = 760389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760392, RefRangeEnd = 760393, XrefRangeStart = 760390, XrefRangeEnd = 760392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupServerSettings componentSystem,
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760393, XrefRangeEnd = 760397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760397, XrefRangeEnd = 760403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeFieldInfoPtr_craftedItemToSourceRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, nameof (craftedItemToSourceRecipes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, nameof (entityManager));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, nameof (_runtimes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Salvageable_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, 100667156);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, 100667157);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, 100667158);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, 100667159);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, 100667160);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, 100667161);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, 100667162);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, 100667163);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_salvageable;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_prefabEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Salvageable> forParameter_salvageable;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 760279, RefRangeEnd = 760280, XrefRangeStart = 760272, XrefRangeEnd = 760279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupServerSettings componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 760287, RefRangeEnd = 760288, XrefRangeStart = 760280, XrefRangeEnd = 760287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabEntity));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_salvageable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_salvageable));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, 100667164);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, 100667165);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_salvageable;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_prefabEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Salvageable>.Runtime runtime_salvageable;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabEntity));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_salvageable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_salvageable));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7/ProjectM.RunWithoutJobSystem_00000D50$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, "RunWithoutJobSystem_00000D50$PostfixBurstDelegate");
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667166);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667167);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667168);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667169);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7/ProjectM.RunWithoutJobSystem_00000D50$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760288, XrefRangeEnd = 760302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760302, XrefRangeEnd = 760320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760320, XrefRangeEnd = 760335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 760362, RefRangeEnd = 760363, XrefRangeStart = 760335, XrefRangeEnd = 760362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7>.NativeClassPtr, "RunWithoutJobSystem_00000D50$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667170);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667171);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667172);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667173);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667175);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob7.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_originalTechItemRequirementBufferStacks;
      private static readonly System.IntPtr NativeFieldInfoPtr_balanceSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_TechItemRequirementBuffer_byref_PrefabGUID_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<SetupServerSettings.PrefabBufferKey, int> originalTechItemRequirementBufferStacks;
      [FieldOffset(16)]
      public ServerGameBalanceSettings balanceSettings;
      [FieldOffset(1416)]
      public SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(1496)]
      public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760494, XrefRangeEnd = 760537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity prefabEntity,
        ref DynamicBuffer<TechItemRequirementBuffer> researchRequirements,
        [In] ref PrefabGUID prefabGUID)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &prefabEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref researchRequirements;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_TechItemRequirementBuffer_byref_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760538, RefRangeEnd = 760539, XrefRangeStart = 760537, XrefRangeEnd = 760538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760540, RefRangeEnd = 760541, XrefRangeStart = 760539, XrefRangeEnd = 760540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760541, XrefRangeEnd = 760543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760552, RefRangeEnd = 760553, XrefRangeStart = 760543, XrefRangeEnd = 760552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 760555, RefRangeEnd = 760556, XrefRangeStart = 760553, XrefRangeEnd = 760555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SetupServerSettings componentSystem,
        ref SetupServerSettings.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760556, XrefRangeEnd = 760560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760560, XrefRangeEnd = 760566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8()
      {
        Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings>.NativeClassPtr, "<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeFieldInfoPtr_originalTechItemRequirementBufferStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, nameof (originalTechItemRequirementBufferStacks));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeFieldInfoPtr_balanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, nameof (balanceSettings));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, nameof (_runtimes));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_TechItemRequirementBuffer_byref_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, 100667176);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, 100667177);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, 100667178);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, 100667179);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, 100667180);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, 100667181);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, 100667182);
        SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, 100667183);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_researchRequirements;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_prefabEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<TechItemRequirementBuffer> forParameter_researchRequirements;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 760410, RefRangeEnd = 760411, XrefRangeStart = 760403, XrefRangeEnd = 760410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SetupServerSettings componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 760418, RefRangeEnd = 760419, XrefRangeStart = 760411, XrefRangeEnd = 760418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabEntity));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_researchRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_researchRequirements));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SetupServerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders>.NativeClassPtr, 100667184);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders>.NativeClassPtr, 100667185);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_researchRequirements;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_prefabEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<TechItemRequirementBuffer>.Runtime runtime_researchRequirements;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;

          static Runtimes()
          {
            Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabEntity));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_researchRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_researchRequirements));
            SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8/ProjectM.RunWithoutJobSystem_00000D59$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 396179, RefRangeEnd = 396180, XrefRangeStart = 396179, XrefRangeEnd = 396180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData,
          Il2CppSystem.AsyncCallback _param3,
          Il2CppSystem.Object _param4)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[4];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param3);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param4);
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
        }

        [CallerCount(3)]
        [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult _param1)
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, "RunWithoutJobSystem_00000D59$PostfixBurstDelegate");
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667186);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667187);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667188);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100667189);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SetupServerSettings/ProjectM.<>c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8/ProjectM.RunWithoutJobSystem_00000D59$BurstDirectCall")]
      public static class ObjectNInternalAbstractSealedInPoDeInUnique : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Pointer;
        private static readonly System.IntPtr NativeFieldInfoPtr_DeferredCompilation;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Constructor_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760419, XrefRangeEnd = 760433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760433, XrefRangeEnd = 760451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760451, XrefRangeEnd = 760466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 760493, RefRangeEnd = 760494, XrefRangeStart = 760466, XrefRangeEnd = 760493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8>.NativeClassPtr, "RunWithoutJobSystem_00000D59$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667190);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667191);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667192);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667193);
          SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100667195);
        }

        public ObjectNInternalAbstractSealedInPoDeInUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public new static unsafe System.IntPtr Pointer
        {
          get
          {
            System.IntPtr pointer;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SetupServerSettings.__c__DisplayClass_UpdateSettingsWithDependenciesBetweenPrefabs_LambdaJob8.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
