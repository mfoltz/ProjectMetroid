// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ParticleLifetimeSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using ProjectM.Presentation.Trails;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Transforms;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class ParticleLifetimeSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAllowedVFXLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAllowedDecalLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParticleParent;
    private static readonly System.IntPtr NativeFieldInfoPtr__TrailEmitters;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientBootstrapSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParticlePool;
    private static readonly System.IntPtr NativeFieldInfoPtr__WarmupPrefabs;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveVFXDebugData;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedVFXPropertyAccessors;
    private static readonly System.IntPtr NativeFieldInfoPtr_PKillerProp;
    private static readonly System.IntPtr NativeFieldInfoPtr_SeqLifetimeProp;
    private static readonly System.IntPtr NativeFieldInfoPtr_SeqGLifetimeProp;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrintVFXDebugInfo;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastImportedAssetsCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr___CheckIfShouldSpawn_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CheckIfShouldSpawn_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateParticleState_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateParticleState_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateVisualEffectParameterElement_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateVisualEffectParameterElement_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateLineRendererPositionElement_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateLineRendererPositionElement_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_46;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_WarmupPrefabs_Public_get_List_1_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNumActiveVFXInstances_Public_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveVFXDataLog_Public_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyParticle_Private_Void_EntityCommandBuffer_Entity_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCheckIfShouldSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateParticleState_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateVisualEffectParameterElement_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateLineRendererPositionElement_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    public unsafe List<GameObject> WarmupPrefabs
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22405, RefRangeEnd = 22406, XrefRangeStart = 22405, XrefRangeEnd = 22406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.NativeMethodInfoPtr_get_WarmupPrefabs_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1104381, RefRangeEnd = 1104383, XrefRangeStart = 1104380, XrefRangeEnd = 1104381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetNumActiveVFXInstances()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.NativeMethodInfoPtr_GetNumActiveVFXInstances_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1104389, RefRangeEnd = 1104391, XrefRangeStart = 1104383, XrefRangeEnd = 1104389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetActiveVFXDataLog()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.NativeMethodInfoPtr_GetActiveVFXDataLog_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104391, XrefRangeEnd = 1104468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ParticleLifetimeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104468, XrefRangeEnd = 1104480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ParticleLifetimeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104480, XrefRangeEnd = 1104659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ParticleLifetimeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1104666, RefRangeEnd = 1104668, XrefRangeStart = 1104659, XrefRangeEnd = 1104666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DestroyParticle(
      EntityCommandBuffer commandBuffer,
      Entity entity,
      GameObject gameObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.NativeMethodInfoPtr_DestroyParticle_Private_Void_EntityCommandBuffer_Entity_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104668, XrefRangeEnd = 1104678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ParticleLifetimeSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104678, XrefRangeEnd = 1104775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ParticleLifetimeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1104800, RefRangeEnd = 1104801, XrefRangeStart = 1104775, XrefRangeEnd = 1104800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCheckIfShouldSpawn_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForCheckIfShouldSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1104829, RefRangeEnd = 1104830, XrefRangeStart = 1104801, XrefRangeEnd = 1104829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateParticleState_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateParticleState_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104830, XrefRangeEnd = 1104849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateVisualEffectParameterElement_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateVisualEffectParameterElement_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104849, XrefRangeEnd = 1104868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateLineRendererPositionElement_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateLineRendererPositionElement_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1104872, RefRangeEnd = 1104873, XrefRangeStart = 1104868, XrefRangeEnd = 1104872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ParticleLifetimeSystem()
    {
      Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ParticleLifetimeSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr);
      ParticleLifetimeSystem.NativeFieldInfoPtr_MaxAllowedVFXLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (MaxAllowedVFXLifetime));
      ParticleLifetimeSystem.NativeFieldInfoPtr_MaxAllowedDecalLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (MaxAllowedDecalLifetime));
      ParticleLifetimeSystem.NativeFieldInfoPtr__ParticleParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (_ParticleParent));
      ParticleLifetimeSystem.NativeFieldInfoPtr__TrailEmitters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (_TrailEmitters));
      ParticleLifetimeSystem.NativeFieldInfoPtr__ClientBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (_ClientBootstrapSystem));
      ParticleLifetimeSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      ParticleLifetimeSystem.NativeFieldInfoPtr__ParticlePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (_ParticlePool));
      ParticleLifetimeSystem.NativeFieldInfoPtr__WarmupPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (_WarmupPrefabs));
      ParticleLifetimeSystem.NativeFieldInfoPtr__ActiveVFXDebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (_ActiveVFXDebugData));
      ParticleLifetimeSystem.NativeFieldInfoPtr__CachedVFXPropertyAccessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (_CachedVFXPropertyAccessors));
      ParticleLifetimeSystem.NativeFieldInfoPtr_PKillerProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (PKillerProp));
      ParticleLifetimeSystem.NativeFieldInfoPtr_SeqLifetimeProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (SeqLifetimeProp));
      ParticleLifetimeSystem.NativeFieldInfoPtr_SeqGLifetimeProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (SeqGLifetimeProp));
      ParticleLifetimeSystem.NativeFieldInfoPtr_PrintVFXDebugInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (PrintVFXDebugInfo));
      ParticleLifetimeSystem.NativeFieldInfoPtr_LastImportedAssetsCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (LastImportedAssetsCounter));
      ParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawn_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>CheckIfShouldSpawn_entityQuery");
      ParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawn_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>CheckIfShouldSpawn_profilerMarker");
      ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateParticleState_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>UpdateParticleState_entityQuery");
      ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateParticleState_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>UpdateParticleState_profilerMarker");
      ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateVisualEffectParameterElement_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>UpdateVisualEffectParameterElement_entityQuery");
      ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateVisualEffectParameterElement_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>UpdateVisualEffectParameterElement_profilerMarker");
      ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateLineRendererPositionElement_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>UpdateLineRendererPositionElement_entityQuery");
      ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateLineRendererPositionElement_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>UpdateLineRendererPositionElement_profilerMarker");
      ParticleLifetimeSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_46 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalUser_46));
      ParticleLifetimeSystem.NativeMethodInfoPtr_get_WarmupPrefabs_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687529);
      ParticleLifetimeSystem.NativeMethodInfoPtr_GetNumActiveVFXInstances_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687530);
      ParticleLifetimeSystem.NativeMethodInfoPtr_GetActiveVFXDataLog_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687531);
      ParticleLifetimeSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687532);
      ParticleLifetimeSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687533);
      ParticleLifetimeSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687534);
      ParticleLifetimeSystem.NativeMethodInfoPtr_DestroyParticle_Private_Void_EntityCommandBuffer_Entity_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687535);
      ParticleLifetimeSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687536);
      ParticleLifetimeSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687537);
      ParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForCheckIfShouldSpawn_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687538);
      ParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateParticleState_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687539);
      ParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateVisualEffectParameterElement_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687540);
      ParticleLifetimeSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateLineRendererPositionElement_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687541);
      ParticleLifetimeSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, 100687542);
    }

    public ParticleLifetimeSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float MaxAllowedVFXLifetime
    {
      get
      {
        float allowedVfxLifetime;
        IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.NativeFieldInfoPtr_MaxAllowedVFXLifetime, (void*) &allowedVfxLifetime);
        return allowedVfxLifetime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.NativeFieldInfoPtr_MaxAllowedVFXLifetime, (void*) &value);
      }
    }

    public static unsafe float MaxAllowedDecalLifetime
    {
      get
      {
        float allowedDecalLifetime;
        IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.NativeFieldInfoPtr_MaxAllowedDecalLifetime, (void*) &allowedDecalLifetime);
        return allowedDecalLifetime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.NativeFieldInfoPtr_MaxAllowedDecalLifetime, (void*) &value);
      }
    }

    public unsafe Transform _ParticleParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__ParticleParent));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__ParticleParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TrailEmitter> _TrailEmitters
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__TrailEmitters));
        return pointer == System.IntPtr.Zero ? (List<TrailEmitter>) null : new List<TrailEmitter>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__TrailEmitters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClientBootstrapSystem _ClientBootstrapSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__ClientBootstrapSystem));
        return pointer == System.IntPtr.Zero ? (ClientBootstrapSystem) null : new ClientBootstrapSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__ClientBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ParticlePool _ParticlePool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__ParticlePool));
        return pointer == System.IntPtr.Zero ? (ParticlePool) null : new ParticlePool(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__ParticlePool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<GameObject> _WarmupPrefabs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__WarmupPrefabs));
        return pointer == System.IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__WarmupPrefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ParticleLifetimeSystem.ActiveVFXDebugData _ActiveVFXDebugData
    {
      get
      {
        return *(ParticleLifetimeSystem.ActiveVFXDebugData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__ActiveVFXDebugData));
      }
      [param: In] set
      {
        *(ParticleLifetimeSystem.ActiveVFXDebugData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__ActiveVFXDebugData)) = value;
      }
    }

    public unsafe NativeHashMap<FixedString64, int> _CachedVFXPropertyAccessors
    {
      get
      {
        return *(NativeHashMap<FixedString64, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__CachedVFXPropertyAccessors));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__CachedVFXPropertyAccessors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<FixedString64, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int PKillerProp
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr_PKillerProp));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr_PKillerProp)) = value;
      }
    }

    public unsafe int SeqLifetimeProp
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr_SeqLifetimeProp));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr_SeqLifetimeProp)) = value;
      }
    }

    public unsafe int SeqGLifetimeProp
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr_SeqGLifetimeProp));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr_SeqGLifetimeProp)) = value;
      }
    }

    public unsafe bool PrintVFXDebugInfo
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr_PrintVFXDebugInfo));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr_PrintVFXDebugInfo)) = value;
      }
    }

    public unsafe int LastImportedAssetsCounter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr_LastImportedAssetsCounter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr_LastImportedAssetsCounter)) = value;
      }
    }

    public unsafe EntityQuery __CheckIfShouldSpawn_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawn_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawn_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CheckIfShouldSpawn_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawn_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___CheckIfShouldSpawn_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateParticleState_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateParticleState_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateParticleState_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateParticleState_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateParticleState_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateParticleState_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateVisualEffectParameterElement_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateVisualEffectParameterElement_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateVisualEffectParameterElement_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateVisualEffectParameterElement_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateVisualEffectParameterElement_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateVisualEffectParameterElement_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateLineRendererPositionElement_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateLineRendererPositionElement_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateLineRendererPositionElement_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateLineRendererPositionElement_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateLineRendererPositionElement_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr___UpdateLineRendererPositionElement_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalUser_46
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_46));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalUser_46)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ParticleToSpawn
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DistanceSq;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ParticleToSpawn_0;
      [FieldOffset(0)]
      public float DistanceSq;
      [FieldOffset(4)]
      public Entity Entity;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(ParticleLifetimeSystem.ParticleToSpawn other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.ParticleToSpawn.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ParticleToSpawn_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static ParticleToSpawn()
      {
        Il2CppClassPointerStore<ParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (ParticleToSpawn));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr);
        ParticleLifetimeSystem.ParticleToSpawn.NativeFieldInfoPtr_DistanceSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr, nameof (DistanceSq));
        ParticleLifetimeSystem.ParticleToSpawn.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr, nameof (Entity));
        ParticleLifetimeSystem.ParticleToSpawn.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ParticleToSpawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr, 100687543);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.ParticleToSpawn>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct VFXDebugData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabName;
      private static readonly System.IntPtr NativeFieldInfoPtr_NumActive;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VFXDebugData_0;
      [FieldOffset(0)]
      public FixedString128 PrefabName;
      [FieldOffset(128)]
      public int NumActive;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103638, XrefRangeEnd = 1103639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(ParticleLifetimeSystem.VFXDebugData other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.VFXDebugData.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VFXDebugData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static VFXDebugData()
      {
        Il2CppClassPointerStore<ParticleLifetimeSystem.VFXDebugData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (VFXDebugData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleLifetimeSystem.VFXDebugData>.NativeClassPtr);
        ParticleLifetimeSystem.VFXDebugData.NativeFieldInfoPtr_PrefabName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.VFXDebugData>.NativeClassPtr, nameof (PrefabName));
        ParticleLifetimeSystem.VFXDebugData.NativeFieldInfoPtr_NumActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.VFXDebugData>.NativeClassPtr, nameof (NumActive));
        ParticleLifetimeSystem.VFXDebugData.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_VFXDebugData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.VFXDebugData>.NativeClassPtr, 100687544);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.VFXDebugData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ActiveVFXDebugData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MostActiveInstancesAllTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_MostActiveInstancesSinceLastSummary;
      private static readonly System.IntPtr NativeFieldInfoPtr_ActiveInstances;
      private static readonly System.IntPtr NativeFieldInfoPtr_ActiveInstancesSinceLastPerformanceDump;
      private static readonly System.IntPtr NativeFieldInfoPtr_INIT_CAPACITY;
      private static readonly System.IntPtr NativeFieldInfoPtr_ACTIVE_RECORD_THRESHOLD;
      private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AddVFXData_Public_Void_GameObject_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RemoveVFXData_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ResetOnPerformanceDump_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetLog_Public_Void_byref_StringBuilder_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentActiveInstances_Public_Int32_0;
      [FieldOffset(0)]
      public NativeHashMap<int, ParticleLifetimeSystem.VFXDebugData> MostActiveInstancesAllTime;
      [FieldOffset(16)]
      public NativeHashMap<int, ParticleLifetimeSystem.VFXDebugData> MostActiveInstancesSinceLastSummary;
      [FieldOffset(32)]
      public NativeHashMap<int, ParticleLifetimeSystem.VFXDebugData> ActiveInstances;
      [FieldOffset(48)]
      public NativeHashMap<int, ParticleLifetimeSystem.VFXDebugData> ActiveInstancesSinceLastPerformanceDump;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1103648, RefRangeEnd = 1103649, XrefRangeStart = 1103639, XrefRangeEnd = 1103648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Init()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_Init_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1103658, RefRangeEnd = 1103659, XrefRangeStart = 1103649, XrefRangeEnd = 1103658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1103692, RefRangeEnd = 1103693, XrefRangeStart = 1103659, XrefRangeEnd = 1103692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void AddVFXData(GameObject vfxPrefab)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vfxPrefab);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_AddVFXData_Public_Void_GameObject_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1103715, RefRangeEnd = 1103716, XrefRangeStart = 1103693, XrefRangeEnd = 1103715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void RemoveVFXData(int prefabInstanceID)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &prefabInstanceID;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_RemoveVFXData_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1103726, RefRangeEnd = 1103727, XrefRangeStart = 1103716, XrefRangeEnd = 1103726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ResetOnPerformanceDump()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_ResetOnPerformanceDump_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1103800, RefRangeEnd = 1103801, XrefRangeStart = 1103727, XrefRangeEnd = 1103800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void GetLog(ref StringBuilder sb)
      {
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
        System.IntPtr* numPtr2 = numPtr1;
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
        System.IntPtr* numPtr3 = &ptr;
        *numPtr2 = (System.IntPtr) numPtr3;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_GetLog_Public_Void_byref_StringBuilder_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref StringBuilder local = ref sb;
        System.IntPtr pointer = ptr;
        StringBuilder stringBuilder = pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
        local = stringBuilder;
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1103820, RefRangeEnd = 1103821, XrefRangeStart = 1103801, XrefRangeEnd = 1103820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int GetCurrentActiveInstances()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_GetCurrentActiveInstances_Public_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static ActiveVFXDebugData()
      {
        Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, nameof (ActiveVFXDebugData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr);
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeFieldInfoPtr_MostActiveInstancesAllTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, nameof (MostActiveInstancesAllTime));
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeFieldInfoPtr_MostActiveInstancesSinceLastSummary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, nameof (MostActiveInstancesSinceLastSummary));
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeFieldInfoPtr_ActiveInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, nameof (ActiveInstances));
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeFieldInfoPtr_ActiveInstancesSinceLastPerformanceDump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, nameof (ActiveInstancesSinceLastPerformanceDump));
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeFieldInfoPtr_INIT_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, nameof (INIT_CAPACITY));
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeFieldInfoPtr_ACTIVE_RECORD_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, nameof (ACTIVE_RECORD_THRESHOLD));
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, 100687545);
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, 100687546);
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_AddVFXData_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, 100687547);
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_RemoveVFXData_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, 100687548);
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_ResetOnPerformanceDump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, 100687549);
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_GetLog_Public_Void_byref_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, 100687550);
        ParticleLifetimeSystem.ActiveVFXDebugData.NativeMethodInfoPtr_GetCurrentActiveInstances_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, 100687551);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.ActiveVFXDebugData>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe int INIT_CAPACITY
      {
        get
        {
          int initCapacity;
          IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.ActiveVFXDebugData.NativeFieldInfoPtr_INIT_CAPACITY, (void*) &initCapacity);
          return initCapacity;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.ActiveVFXDebugData.NativeFieldInfoPtr_INIT_CAPACITY, (void*) &value);
        }
      }

      public static unsafe int ACTIVE_RECORD_THRESHOLD
      {
        get
        {
          int activeRecordThreshold;
          IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.ActiveVFXDebugData.NativeFieldInfoPtr_ACTIVE_RECORD_THRESHOLD, (void*) &activeRecordThreshold);
          return activeRecordThreshold;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.ActiveVFXDebugData.NativeFieldInfoPtr_ACTIVE_RECORD_THRESHOLD, (void*) &value);
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.ParticleLifetimeSystem/<>c__DisplayClass24_0")]
    public sealed class __c__DisplayClass24_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_hasValidPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_particlesToSpawn;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_ParticleSettings_byref_SequencerParticle_byref_Translation_byref_Rotation_byref_NonUniformScale_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_HybridVisualEffects_byref_DynamicBuffer_1_VisualEffectParameterElement_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass24_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref Translation translation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        ParticleSettings particleSettings,
        ref SequencerParticle particleState,
        [In] ref Translation translation,
        [In] ref Rotation rotation,
        [In] ref NonUniformScale scale)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) particleSettings);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref particleState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref scale;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_ParticleSettings_byref_SequencerParticle_byref_Translation_byref_Rotation_byref_NonUniformScale_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        HybridVisualEffects hybridVisualEffects,
        ref DynamicBuffer<VisualEffectParameterElement> parameters)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hybridVisualEffects);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref parameters;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_HybridVisualEffects_byref_DynamicBuffer_1_VisualEffectParameterElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass24_0()
      {
        Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>c__DisplayClass24_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr);
        ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (localPosition));
        ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_hasValidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (hasValidPosition));
        ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_particlesToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (particlesToSpawn));
        ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
        ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (deltaTime));
        ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, nameof (commandBuffer));
        ParticleLifetimeSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, 100687552);
        ParticleLifetimeSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, 100687553);
        ParticleLifetimeSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_ParticleSettings_byref_SequencerParticle_byref_Translation_byref_Rotation_byref_NonUniformScale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, 100687554);
        ParticleLifetimeSystem.__c__DisplayClass24_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_HybridVisualEffects_byref_DynamicBuffer_1_VisualEffectParameterElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, 100687555);
      }

      public __c__DisplayClass24_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass24_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass24_0>.NativeClassPtr, data));
      }

      public unsafe float3 localPosition
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_localPosition));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_localPosition)) = value;
        }
      }

      public unsafe bool hasValidPosition
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_hasValidPosition));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_hasValidPosition)) = value;
        }
      }

      public unsafe NativeList<ParticleLifetimeSystem.ParticleToSpawn> particlesToSpawn
      {
        get
        {
          return *(NativeList<ParticleLifetimeSystem.ParticleToSpawn>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_particlesToSpawn));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_particlesToSpawn), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ParticleLifetimeSystem.ParticleToSpawn>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ParticleLifetimeSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ParticleLifetimeSystem) null : new ParticleLifetimeSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass24_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.ParticleLifetimeSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__24_3;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__24_3_Internal_Void_HybridLineRenderers_byref_DynamicBuffer_1_LineRendererPositionElement_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleLifetimeSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__24_3(
        HybridLineRenderers hybridLineRenderers,
        ref DynamicBuffer<LineRendererPositionElement> parameters)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hybridLineRenderers);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref parameters;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c.NativeMethodInfoPtr__OnUpdate_b__24_3_Internal_Void_HybridLineRenderers_byref_DynamicBuffer_1_LineRendererPositionElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<ParticleLifetimeSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleLifetimeSystem.__c>.NativeClassPtr);
        ParticleLifetimeSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c>.NativeClassPtr, "<>9");
        ParticleLifetimeSystem.__c.NativeFieldInfoPtr___9__24_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c>.NativeClassPtr, "<>9__24_3");
        ParticleLifetimeSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c>.NativeClassPtr, 100687557);
        ParticleLifetimeSystem.__c.NativeMethodInfoPtr__OnUpdate_b__24_3_Internal_Void_HybridLineRenderers_byref_DynamicBuffer_1_LineRendererPositionElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c>.NativeClassPtr, 100687558);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ParticleLifetimeSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ParticleLifetimeSystem.__c) null : new ParticleLifetimeSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe VR<HybridLineRenderers, DynamicBuffer<LineRendererPositionElement>> __9__24_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.__c.NativeFieldInfoPtr___9__24_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (VR<HybridLineRenderers, DynamicBuffer<LineRendererPositionElement>>) null : new VR<HybridLineRenderers, DynamicBuffer<LineRendererPositionElement>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.__c.NativeFieldInfoPtr___9__24_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.ParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_CheckIfShouldSpawn")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CheckIfShouldSpawn
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_hasValidPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_particlesToSpawn;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float3 localPosition;
      [FieldOffset(12)]
      public bool hasValidPosition;
      [FieldOffset(16)]
      public NativeList<ParticleLifetimeSystem.ParticleToSpawn> particlesToSpawn;
      [FieldOffset(32)]
      public ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103906, XrefRangeEnd = 1103909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1101382, RefRangeEnd = 1101384, XrefRangeStart = 1101382, XrefRangeEnd = 1101384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ParticleLifetimeSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1101384, RefRangeEnd = 1101386, XrefRangeStart = 1101384, XrefRangeEnd = 1101386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ParticleLifetimeSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103909, XrefRangeEnd = 1103911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1103917, RefRangeEnd = 1103918, XrefRangeStart = 1103911, XrefRangeEnd = 1103917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1103920, RefRangeEnd = 1103921, XrefRangeStart = 1103918, XrefRangeEnd = 1103920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ParticleLifetimeSystem componentSystem,
        ref ParticleLifetimeSystem.__c__DisplayClass24_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_byref___c__DisplayClass24_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103921, XrefRangeEnd = 1103925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103925, XrefRangeEnd = 1103931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CheckIfShouldSpawn()
      {
        Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>c__DisplayClass_CheckIfShouldSpawn");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr);
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeFieldInfoPtr_localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, nameof (localPosition));
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeFieldInfoPtr_hasValidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, nameof (hasValidPosition));
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeFieldInfoPtr_particlesToSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, nameof (particlesToSpawn));
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, nameof (_runtimes));
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, 100687559);
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, 100687560);
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, 100687561);
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, 100687562);
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, 100687563);
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, 100687564);
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, 100687565);
        ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, 100687566);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1103825, RefRangeEnd = 1103826, XrefRangeStart = 1103821, XrefRangeEnd = 1103825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ParticleLifetimeSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1103830, RefRangeEnd = 1103831, XrefRangeStart = 1103826, XrefRangeEnd = 1103830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders>.NativeClassPtr, 100687567);
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders>.NativeClassPtr, 100687568);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.ParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_CheckIfShouldSpawn/ProjectM.Sequencer.RunWithoutJobSystem_00005518$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, "RunWithoutJobSystem_00005518$PostfixBurstDelegate");
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687569);
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687570);
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687571);
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687572);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.ParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_CheckIfShouldSpawn/ProjectM.Sequencer.RunWithoutJobSystem_00005518$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103831, XrefRangeEnd = 1103845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103845, XrefRangeEnd = 1103863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103863, XrefRangeEnd = 1103878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1103905, RefRangeEnd = 1103906, XrefRangeStart = 1103878, XrefRangeEnd = 1103905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn>.NativeClassPtr, "RunWithoutJobSystem_00005518$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687573);
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687574);
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687575);
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687576);
          ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687578);
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
            IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.__c__DisplayClass_CheckIfShouldSpawn.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.ParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_UpdateParticleState")]
    public sealed class __c__DisplayClass_UpdateParticleState : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_ParticleSettings_byref_SequencerParticle_byref_Translation_byref_Rotation_byref_NonUniformScale_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104151, RefRangeEnd = 1104152, XrefRangeStart = 1103966, XrefRangeEnd = 1104151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ParticleSettings particleSettings,
        ref SequencerParticle particleState,
        [In] ref Translation translation,
        [In] ref Rotation rotation,
        [In] ref NonUniformScale scale)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) particleSettings);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref particleState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rotation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref scale;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_ParticleSettings_byref_SequencerParticle_byref_Translation_byref_Rotation_byref_NonUniformScale_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104153, RefRangeEnd = 1104154, XrefRangeStart = 1104152, XrefRangeEnd = 1104153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ParticleLifetimeSystem.__c__DisplayClass24_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104155, RefRangeEnd = 1104156, XrefRangeStart = 1104154, XrefRangeEnd = 1104155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ParticleLifetimeSystem.__c__DisplayClass24_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104156, XrefRangeEnd = 1104158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104176, RefRangeEnd = 1104177, XrefRangeStart = 1104158, XrefRangeEnd = 1104176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104179, RefRangeEnd = 1104180, XrefRangeStart = 1104177, XrefRangeEnd = 1104179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ParticleLifetimeSystem componentSystem,
        ref ParticleLifetimeSystem.__c__DisplayClass24_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_byref___c__DisplayClass24_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104180, XrefRangeEnd = 1104186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateParticleState()
      {
        Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateParticleState");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, "<>4__this");
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, nameof (deltaTime));
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, nameof (commandBuffer));
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, nameof (_runtimes));
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_ParticleSettings_byref_SequencerParticle_byref_Translation_byref_Rotation_byref_NonUniformScale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, 100687579);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, 100687580);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, 100687581);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, 100687582);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, 100687583);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, 100687584);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, 100687585);
      }

      public __c__DisplayClass_UpdateParticleState(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpdateParticleState()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, data));
      }

      public unsafe ParticleLifetimeSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ParticleLifetimeSystem) null : new ParticleLifetimeSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_particleSettings;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_particleState;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_rotation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_scale;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<ParticleSettings> forParameter_particleSettings;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<SequencerParticle> forParameter_particleState;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(112)]
        public LambdaParameterValueProvider_IComponentData<Rotation> forParameter_rotation;
        [FieldOffset(144)]
        public LambdaParameterValueProvider_IComponentData<NonUniformScale> forParameter_scale;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1103947, RefRangeEnd = 1103948, XrefRangeStart = 1103931, XrefRangeEnd = 1103947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ParticleLifetimeSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1103965, RefRangeEnd = 1103966, XrefRangeStart = 1103948, XrefRangeEnd = 1103965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_particleSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_particleSettings));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_particleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_particleState));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_rotation));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_scale));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders>.NativeClassPtr, 100687586);
          ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders>.NativeClassPtr, 100687587);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_particleSettings;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_particleState;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_rotation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_scale;

          static Runtimes()
          {
            Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_particleSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_particleSettings));
            ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_particleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_particleState));
            ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_rotation));
            ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_scale));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public unsafe LambdaParameterValueProvider_Entity.Runtime runtime_entity
          {
            get
            {
              return *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity));
            }
            [param: In] set
            {
              *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity)) = value;
            }
          }

          public LambdaParameterValueProvider_ManagedComponentData<ParticleSettings>.Runtime runtime_particleSettings
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_particleSettings);
              return new LambdaParameterValueProvider_ManagedComponentData<ParticleSettings>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<ParticleSettings>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_particleSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<ParticleSettings>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_IComponentData<SequencerParticle>.Runtime runtime_particleState
          {
            get
            {
              return *(LambdaParameterValueProvider_IComponentData<SequencerParticle>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_particleState));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_particleState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_IComponentData<SequencerParticle>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation
          {
            get
            {
              return *(LambdaParameterValueProvider_IComponentData<Translation>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_IComponentData<Translation>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_IComponentData<Rotation>.Runtime runtime_rotation
          {
            get
            {
              return *(LambdaParameterValueProvider_IComponentData<Rotation>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_rotation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_IComponentData<Rotation>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_IComponentData<NonUniformScale>.Runtime runtime_scale
          {
            get
            {
              return *(LambdaParameterValueProvider_IComponentData<NonUniformScale>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_scale));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateParticleState.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_scale), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_IComponentData<NonUniformScale>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.ParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_UpdateVisualEffectParameterElement")]
    public sealed class __c__DisplayClass_UpdateVisualEffectParameterElement : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridVisualEffects_byref_DynamicBuffer_1_VisualEffectParameterElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_byref___c__DisplayClass24_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104248, RefRangeEnd = 1104249, XrefRangeStart = 1104201, XrefRangeEnd = 1104248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        HybridVisualEffects hybridVisualEffects,
        ref DynamicBuffer<VisualEffectParameterElement> parameters)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hybridVisualEffects);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref parameters;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridVisualEffects_byref_DynamicBuffer_1_VisualEffectParameterElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104250, RefRangeEnd = 1104251, XrefRangeStart = 1104249, XrefRangeEnd = 1104250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ParticleLifetimeSystem.__c__DisplayClass24_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104312, RefRangeEnd = 1104313, XrefRangeStart = 1104251, XrefRangeEnd = 1104312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ParticleLifetimeSystem.__c__DisplayClass24_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104313, XrefRangeEnd = 1104315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104323, RefRangeEnd = 1104324, XrefRangeStart = 1104315, XrefRangeEnd = 1104323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104326, RefRangeEnd = 1104327, XrefRangeStart = 1104324, XrefRangeEnd = 1104326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ParticleLifetimeSystem componentSystem,
        ref ParticleLifetimeSystem.__c__DisplayClass24_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_byref___c__DisplayClass24_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104327, XrefRangeEnd = 1104333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateVisualEffectParameterElement()
      {
        Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateVisualEffectParameterElement");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, "<>4__this");
        ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, nameof (_runtimes));
        ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridVisualEffects_byref_DynamicBuffer_1_VisualEffectParameterElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, 100687588);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, 100687589);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, 100687590);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, 100687591);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, 100687592);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_byref___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, 100687593);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, 100687594);
      }

      public __c__DisplayClass_UpdateVisualEffectParameterElement(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpdateVisualEffectParameterElement()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, data));
      }

      public unsafe ParticleLifetimeSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ParticleLifetimeSystem) null : new ParticleLifetimeSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hybridVisualEffects;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_parameters;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_ManagedComponentData<HybridVisualEffects> forParameter_hybridVisualEffects;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<VisualEffectParameterElement> forParameter_parameters;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1104192, RefRangeEnd = 1104193, XrefRangeStart = 1104186, XrefRangeEnd = 1104192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ParticleLifetimeSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1104200, RefRangeEnd = 1104201, XrefRangeStart = 1104193, XrefRangeEnd = 1104200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hybridVisualEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hybridVisualEffects));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_parameters));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders>.NativeClassPtr, 100687595);
          ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders>.NativeClassPtr, 100687596);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hybridVisualEffects;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_parameters;

          static Runtimes()
          {
            Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridVisualEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hybridVisualEffects));
            ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_parameters));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public LambdaParameterValueProvider_ManagedComponentData<HybridVisualEffects>.Runtime runtime_hybridVisualEffects
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridVisualEffects);
              return new LambdaParameterValueProvider_ManagedComponentData<HybridVisualEffects>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridVisualEffects>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridVisualEffects), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridVisualEffects>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_DynamicBuffer<VisualEffectParameterElement>.Runtime runtime_parameters
          {
            get
            {
              return *(LambdaParameterValueProvider_DynamicBuffer<VisualEffectParameterElement>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_parameters));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateVisualEffectParameterElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_parameters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_DynamicBuffer<VisualEffectParameterElement>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.ParticleLifetimeSystem/ProjectM.Sequencer.<>c__DisplayClass_UpdateLineRendererPositionElement")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateLineRendererPositionElement
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridLineRenderers_byref_DynamicBuffer_1_LineRendererPositionElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104360, RefRangeEnd = 1104361, XrefRangeStart = 1104348, XrefRangeEnd = 1104360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        HybridLineRenderers hybridLineRenderers,
        ref DynamicBuffer<LineRendererPositionElement> parameters)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hybridLineRenderers);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref parameters;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridLineRenderers_byref_DynamicBuffer_1_LineRendererPositionElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104361, XrefRangeEnd = 1104363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104371, RefRangeEnd = 1104372, XrefRangeStart = 1104363, XrefRangeEnd = 1104371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1104373, RefRangeEnd = 1104374, XrefRangeStart = 1104372, XrefRangeEnd = 1104373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(ParticleLifetimeSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1104374, XrefRangeEnd = 1104380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateLineRendererPositionElement()
      {
        Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateLineRendererPositionElement");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr, nameof (_runtimes));
        ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_HybridLineRenderers_byref_DynamicBuffer_1_LineRendererPositionElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr, 100687597);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr, 100687598);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr, 100687599);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr, 100687600);
        ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr, 100687601);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_hybridLineRenderers;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_parameters;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_ManagedComponentData<HybridLineRenderers> forParameter_hybridLineRenderers;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<LineRendererPositionElement> forParameter_parameters;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1104339, RefRangeEnd = 1104340, XrefRangeStart = 1104333, XrefRangeEnd = 1104339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ParticleLifetimeSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1104347, RefRangeEnd = 1104348, XrefRangeStart = 1104340, XrefRangeEnd = 1104347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_hybridLineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_hybridLineRenderers));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_parameters));
          ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ParticleLifetimeSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders>.NativeClassPtr, 100687602);
          ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders>.NativeClassPtr, 100687603);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_hybridLineRenderers;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_parameters;

          static Runtimes()
          {
            Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridLineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_hybridLineRenderers));
            ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_parameters));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public LambdaParameterValueProvider_ManagedComponentData<HybridLineRenderers>.Runtime runtime_hybridLineRenderers
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridLineRenderers);
              return new LambdaParameterValueProvider_ManagedComponentData<HybridLineRenderers>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridLineRenderers>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_hybridLineRenderers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<HybridLineRenderers>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }

          public unsafe LambdaParameterValueProvider_DynamicBuffer<LineRendererPositionElement>.Runtime runtime_parameters
          {
            get
            {
              return *(LambdaParameterValueProvider_DynamicBuffer<LineRendererPositionElement>.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_parameters));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleLifetimeSystem.__c__DisplayClass_UpdateLineRendererPositionElement.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_parameters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_DynamicBuffer<LineRendererPositionElement>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }
  }
}
