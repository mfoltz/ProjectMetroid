// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MiniMapHUDSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using ProjectM.CastleBuilding;
using ProjectM.Terrain;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Profiling;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace ProjectM.UI
{
  public class MiniMapHUDSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__MiniMapParent;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapScale;
    private static readonly System.IntPtr NativeFieldInfoPtr__UIDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CommonClientDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__RevealMapPresentationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapZonePolygonUIMeshSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapMenuMapper;
    private static readonly System.IntPtr NativeFieldInfoPtr__PolygonMaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr__PolygonsToShow;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerritoriesToShow;
    private static readonly System.IntPtr NativeFieldInfoPtr__MapIconRenderData;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedIconSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentZoneData;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastMapRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_VisionData;
    private static readonly System.IntPtr NativeFieldInfoPtr_RevealAlphaTexture;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectionMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapTexture;
    private static readonly System.IntPtr NativeFieldInfoPtr___DetermineVisibleMinimapTerritories_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DetermineVisibleMinimapTerritories_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetMapZones_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___GetMapZones_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateMapIconPositions_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateMapIconPositions_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LockRotation_Private_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LockRotation_Private_Static_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryInitializeMiniMap_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySetupInstance_Private_Boolean_Int32_byref_MinimapIconRenderData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraRotation_Private_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetZoneMapData_Private_Boolean_Entity_byref_Texture2D_byref_Matrix4x4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryInitializeMiniMap_b__23_0_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryInitializeMiniMap_b__23_1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDetermineVisibleMinimapTerritories_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForGetMapZones_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateMapIconPositions_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;

    public static unsafe bool LockRotation
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1272257, RefRangeEnd = 1272258, XrefRangeStart = 1272256, XrefRangeEnd = 1272257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_get_LockRotation_Private_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 1272259, RefRangeEnd = 1272260, XrefRangeStart = 1272258, XrefRangeEnd = 1272259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_set_LockRotation_Private_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272260, XrefRangeEnd = 1272306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MiniMapHUDSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272306, XrefRangeEnd = 1272315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MiniMapHUDSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272315, XrefRangeEnd = 1272317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MiniMapHUDSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MiniMapHUDSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1272369, RefRangeEnd = 1272370, XrefRangeStart = 1272317, XrefRangeEnd = 1272369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryInitializeMiniMap()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_TryInitializeMiniMap_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272370, XrefRangeEnd = 1272718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MiniMapHUDSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1272737, RefRangeEnd = 1272738, XrefRangeStart = 1272718, XrefRangeEnd = 1272737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TrySetupInstance(
      int currentCount,
      [In] ref MiniMapHUDSystem.MinimapIconRenderData entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &currentCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entry;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_TrySetupInstance_Private_Boolean_Int32_byref_MinimapIconRenderData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272738, XrefRangeEnd = 1272743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetCameraRotation()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_GetCameraRotation_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272743, XrefRangeEnd = 1272757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetZoneMapData(
      Entity worldZoneEntity,
      out Texture2D zoneMapTexture,
      out Matrix4x4 projectionMatrix)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &worldZoneEntity;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref projectionMatrix;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_TryGetZoneMapData_Private_Boolean_Entity_byref_Texture2D_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Texture2D local = ref zoneMapTexture;
      System.IntPtr pointer = zero;
      Texture2D texture2D = pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
      local = texture2D;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272757, XrefRangeEnd = 1272766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetConsumedInputs(ref BlockInputState blockInputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blockInputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HandleInput(InputState inputState)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputState;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272766, XrefRangeEnd = 1272774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MiniMapHUDSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272774, XrefRangeEnd = 1272775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _TryInitializeMiniMap_b__23_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr__TryInitializeMiniMap_b__23_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272775, XrefRangeEnd = 1272776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _TryInitializeMiniMap_b__23_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr__TryInitializeMiniMap_b__23_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272776, XrefRangeEnd = 1272881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MiniMapHUDSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1272903, RefRangeEnd = 1272904, XrefRangeStart = 1272881, XrefRangeEnd = 1272903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDetermineVisibleMinimapTerritories_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForDetermineVisibleMinimapTerritories_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272904, XrefRangeEnd = 1272923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForGetMapZones_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetMapZones_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272923, XrefRangeEnd = 1272942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1272964, RefRangeEnd = 1272965, XrefRangeStart = 1272942, XrefRangeEnd = 1272964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateMapIconPositions_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateMapIconPositions_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1272969, RefRangeEnd = 1272970, XrefRangeStart = 1272965, XrefRangeEnd = 1272969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1272974, RefRangeEnd = 1272975, XrefRangeStart = 1272970, XrefRangeEnd = 1272974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1272979, RefRangeEnd = 1272980, XrefRangeStart = 1272975, XrefRangeEnd = 1272979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1272984, RefRangeEnd = 1272985, XrefRangeStart = 1272980, XrefRangeEnd = 1272984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MiniMapHUDSystem()
    {
      Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MiniMapHUDSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr);
      MiniMapHUDSystem.NativeFieldInfoPtr__MiniMapParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_MiniMapParent));
      MiniMapHUDSystem.NativeFieldInfoPtr__MapScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_MapScale));
      MiniMapHUDSystem.NativeFieldInfoPtr__UIDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_UIDataSystem));
      MiniMapHUDSystem.NativeFieldInfoPtr__CommonClientDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_CommonClientDataSystem));
      MiniMapHUDSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_GameDataSystem));
      MiniMapHUDSystem.NativeFieldInfoPtr__InputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_InputSystem));
      MiniMapHUDSystem.NativeFieldInfoPtr__RevealMapPresentationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_RevealMapPresentationSystem));
      MiniMapHUDSystem.NativeFieldInfoPtr__MapZonePolygonUIMeshSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_MapZonePolygonUIMeshSystem));
      MiniMapHUDSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      MiniMapHUDSystem.NativeFieldInfoPtr__MapMenuMapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_MapMenuMapper));
      MiniMapHUDSystem.NativeFieldInfoPtr__PolygonMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_PolygonMaterial));
      MiniMapHUDSystem.NativeFieldInfoPtr__PolygonsToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_PolygonsToShow));
      MiniMapHUDSystem.NativeFieldInfoPtr__TerritoriesToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_TerritoriesToShow));
      MiniMapHUDSystem.NativeFieldInfoPtr__MapIconRenderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_MapIconRenderData));
      MiniMapHUDSystem.NativeFieldInfoPtr__CachedIconSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_CachedIconSettings));
      MiniMapHUDSystem.NativeFieldInfoPtr__CurrentZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_CurrentZoneData));
      MiniMapHUDSystem.NativeFieldInfoPtr__LastMapRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (_LastMapRotation));
      MiniMapHUDSystem.NativeFieldInfoPtr_VisionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (VisionData));
      MiniMapHUDSystem.NativeFieldInfoPtr_RevealAlphaTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (RevealAlphaTexture));
      MiniMapHUDSystem.NativeFieldInfoPtr_ProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (ProjectionMatrix));
      MiniMapHUDSystem.NativeFieldInfoPtr_MapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (MapTexture));
      MiniMapHUDSystem.NativeFieldInfoPtr___DetermineVisibleMinimapTerritories_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>DetermineVisibleMinimapTerritories_entityQuery");
      MiniMapHUDSystem.NativeFieldInfoPtr___DetermineVisibleMinimapTerritories_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>DetermineVisibleMinimapTerritories_profilerMarker");
      MiniMapHUDSystem.NativeFieldInfoPtr___GetMapZones_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>GetMapZones_entityQuery");
      MiniMapHUDSystem.NativeFieldInfoPtr___GetMapZones_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>GetMapZones_profilerMarker");
      MiniMapHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob2_entityQuery");
      MiniMapHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob2_profilerMarker");
      MiniMapHUDSystem.NativeFieldInfoPtr___UpdateMapIconPositions_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>UpdateMapIconPositions_entityQuery");
      MiniMapHUDSystem.NativeFieldInfoPtr___UpdateMapIconPositions_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>UpdateMapIconPositions_profilerMarker");
      MiniMapHUDSystem.NativeMethodInfoPtr_get_LockRotation_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668069);
      MiniMapHUDSystem.NativeMethodInfoPtr_set_LockRotation_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668070);
      MiniMapHUDSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668071);
      MiniMapHUDSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668072);
      MiniMapHUDSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668073);
      MiniMapHUDSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668074);
      MiniMapHUDSystem.NativeMethodInfoPtr_TryInitializeMiniMap_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668075);
      MiniMapHUDSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668076);
      MiniMapHUDSystem.NativeMethodInfoPtr_TrySetupInstance_Private_Boolean_Int32_byref_MinimapIconRenderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668077);
      MiniMapHUDSystem.NativeMethodInfoPtr_GetCameraRotation_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668078);
      MiniMapHUDSystem.NativeMethodInfoPtr_TryGetZoneMapData_Private_Boolean_Entity_byref_Texture2D_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668079);
      MiniMapHUDSystem.NativeMethodInfoPtr_GetConsumedInputs_Public_Virtual_Final_New_Void_byref_BlockInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668080);
      MiniMapHUDSystem.NativeMethodInfoPtr_HandleInput_Public_Virtual_Final_New_Void_InputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668081);
      MiniMapHUDSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668082);
      MiniMapHUDSystem.NativeMethodInfoPtr__TryInitializeMiniMap_b__23_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668084);
      MiniMapHUDSystem.NativeMethodInfoPtr__TryInitializeMiniMap_b__23_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668085);
      MiniMapHUDSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668086);
      MiniMapHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForDetermineVisibleMinimapTerritories_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668087);
      MiniMapHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForGetMapZones_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668088);
      MiniMapHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668089);
      MiniMapHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateMapIconPositions_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668090);
      MiniMapHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668091);
      MiniMapHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668092);
      MiniMapHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668093);
      MiniMapHUDSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, 100668094);
    }

    public MiniMapHUDSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MiniMapHUDParent _MiniMapParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__MiniMapParent));
        return pointer == System.IntPtr.Zero ? (MiniMapHUDParent) null : new MiniMapHUDParent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__MiniMapParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _MapScale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__MapScale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__MapScale)) = value;
      }
    }

    public unsafe UIDataSystem _UIDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__UIDataSystem));
        return pointer == System.IntPtr.Zero ? (UIDataSystem) null : new UIDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__UIDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CommonClientDataSystem _CommonClientDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__CommonClientDataSystem));
        return pointer == System.IntPtr.Zero ? (CommonClientDataSystem) null : new CommonClientDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__CommonClientDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputSystem _InputSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__InputSystem));
        return pointer == System.IntPtr.Zero ? (InputSystem) null : new InputSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__InputSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RevealMapPresentationSystem _RevealMapPresentationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__RevealMapPresentationSystem));
        return pointer == System.IntPtr.Zero ? (RevealMapPresentationSystem) null : new RevealMapPresentationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__RevealMapPresentationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapZonePolygonUIMeshSystem _MapZonePolygonUIMeshSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__MapZonePolygonUIMeshSystem));
        return pointer == System.IntPtr.Zero ? (MapZonePolygonUIMeshSystem) null : new MapZonePolygonUIMeshSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__MapZonePolygonUIMeshSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapMenuMapper _MapMenuMapper
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__MapMenuMapper));
        return pointer == System.IntPtr.Zero ? (MapMenuMapper) null : new MapMenuMapper(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__MapMenuMapper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityEngine.Material _PolygonMaterial
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__PolygonMaterial));
        return pointer == System.IntPtr.Zero ? (UnityEngine.Material) null : new UnityEngine.Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__PolygonMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<MapMenuMapper.MapZoneOutput> _PolygonsToShow
    {
      get
      {
        return *(NativeList<MapMenuMapper.MapZoneOutput>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__PolygonsToShow));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__PolygonsToShow), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MapMenuMapper.MapZoneOutput>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<MapMenuMapper.TerritoryOutput> _TerritoriesToShow
    {
      get
      {
        return *(NativeList<MapMenuMapper.TerritoryOutput>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__TerritoriesToShow));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__TerritoriesToShow), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MapMenuMapper.TerritoryOutput>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<MiniMapHUDSystem.MinimapIconRenderData> _MapIconRenderData
    {
      get
      {
        return *(NativeList<MiniMapHUDSystem.MinimapIconRenderData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__MapIconRenderData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__MapIconRenderData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MiniMapHUDSystem.MinimapIconRenderData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Dictionary<MinimapIconKey, MinimapIconResult> _CachedIconSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__CachedIconSettings));
        return pointer == System.IntPtr.Zero ? (Dictionary<MinimapIconKey, MinimapIconResult>) null : new Dictionary<MinimapIconKey, MinimapIconResult>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__CachedIconSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MiniMapHUDSystem.CurrentTextureData _CurrentZoneData
    {
      get
      {
        return *(MiniMapHUDSystem.CurrentTextureData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__CurrentZoneData));
      }
      [param: In] set
      {
        *(MiniMapHUDSystem.CurrentTextureData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__CurrentZoneData)) = value;
      }
    }

    public unsafe float _LastMapRotation
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__LastMapRotation));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr__LastMapRotation)) = value;
      }
    }

    public static unsafe int VisionData
    {
      get
      {
        int visionData;
        IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.NativeFieldInfoPtr_VisionData, (void*) &visionData);
        return visionData;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.NativeFieldInfoPtr_VisionData, (void*) &value);
      }
    }

    public static unsafe int RevealAlphaTexture
    {
      get
      {
        int revealAlphaTexture;
        IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.NativeFieldInfoPtr_RevealAlphaTexture, (void*) &revealAlphaTexture);
        return revealAlphaTexture;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.NativeFieldInfoPtr_RevealAlphaTexture, (void*) &value);
      }
    }

    public static unsafe int ProjectionMatrix
    {
      get
      {
        int projectionMatrix;
        IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.NativeFieldInfoPtr_ProjectionMatrix, (void*) &projectionMatrix);
        return projectionMatrix;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.NativeFieldInfoPtr_ProjectionMatrix, (void*) &value);
      }
    }

    public static unsafe int MapTexture
    {
      get
      {
        int mapTexture;
        IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.NativeFieldInfoPtr_MapTexture, (void*) &mapTexture);
        return mapTexture;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.NativeFieldInfoPtr_MapTexture, (void*) &value);
      }
    }

    public unsafe EntityQuery __DetermineVisibleMinimapTerritories_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___DetermineVisibleMinimapTerritories_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___DetermineVisibleMinimapTerritories_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DetermineVisibleMinimapTerritories_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___DetermineVisibleMinimapTerritories_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___DetermineVisibleMinimapTerritories_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __GetMapZones_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___GetMapZones_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___GetMapZones_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __GetMapZones_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___GetMapZones_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___GetMapZones_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateMapIconPositions_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___UpdateMapIconPositions_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___UpdateMapIconPositions_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateMapIconPositions_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___UpdateMapIconPositions_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.NativeFieldInfoPtr___UpdateMapIconPositions_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MinimapIconRenderData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AnchoredPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapIconDataPrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_MapIconDrawMode;
      private static readonly System.IntPtr NativeFieldInfoPtr_RenderOrder;
      private static readonly System.IntPtr NativeFieldInfoPtr_OverridenCastleIcon;
      private static readonly System.IntPtr NativeFieldInfoPtr_Alpha;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSiegeIcon;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_MinimapIconRenderData_0;
      [FieldOffset(0)]
      public Vector3 AnchoredPosition;
      [FieldOffset(12)]
      public Quaternion Rotation;
      [FieldOffset(28)]
      public PrefabGUID MapIconDataPrefabGuid;
      [FieldOffset(32)]
      public Entity Entity;
      [FieldOffset(40)]
      public MapIconDrawMode MapIconDrawMode;
      [FieldOffset(44)]
      public int RenderOrder;
      [FieldOffset(48)]
      public int OverridenCastleIcon;
      [FieldOffset(52)]
      public Nullable_Unboxed<float> Alpha;
      [FieldOffset(60)]
      public bool IsSiegeIcon;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271633, XrefRangeEnd = 1271635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(MiniMapHUDSystem.MinimapIconRenderData other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.MinimapIconRenderData.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_MinimapIconRenderData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static MinimapIconRenderData()
      {
        Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (MinimapIconRenderData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr);
        MiniMapHUDSystem.MinimapIconRenderData.NativeFieldInfoPtr_AnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr, nameof (AnchoredPosition));
        MiniMapHUDSystem.MinimapIconRenderData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr, nameof (Rotation));
        MiniMapHUDSystem.MinimapIconRenderData.NativeFieldInfoPtr_MapIconDataPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr, nameof (MapIconDataPrefabGuid));
        MiniMapHUDSystem.MinimapIconRenderData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr, nameof (Entity));
        MiniMapHUDSystem.MinimapIconRenderData.NativeFieldInfoPtr_MapIconDrawMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr, nameof (MapIconDrawMode));
        MiniMapHUDSystem.MinimapIconRenderData.NativeFieldInfoPtr_RenderOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr, nameof (RenderOrder));
        MiniMapHUDSystem.MinimapIconRenderData.NativeFieldInfoPtr_OverridenCastleIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr, nameof (OverridenCastleIcon));
        MiniMapHUDSystem.MinimapIconRenderData.NativeFieldInfoPtr_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr, nameof (Alpha));
        MiniMapHUDSystem.MinimapIconRenderData.NativeFieldInfoPtr_IsSiegeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr, nameof (IsSiegeIcon));
        MiniMapHUDSystem.MinimapIconRenderData.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_MinimapIconRenderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr, 100668095);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.MinimapIconRenderData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CurrentTextureData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HasTextureData;
      private static readonly System.IntPtr NativeFieldInfoPtr_ZoneType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProjectionMatrix;
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldToAnchoredSpace;
      [FieldOffset(0)]
      public bool HasTextureData;
      [FieldOffset(4)]
      public WorldZone ZoneType;
      [FieldOffset(8)]
      public Matrix4x4 ProjectionMatrix;
      [FieldOffset(72)]
      public Matrix4x4 WorldToAnchoredSpace;

      static CurrentTextureData()
      {
        Il2CppClassPointerStore<MiniMapHUDSystem.CurrentTextureData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, nameof (CurrentTextureData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.CurrentTextureData>.NativeClassPtr);
        MiniMapHUDSystem.CurrentTextureData.NativeFieldInfoPtr_HasTextureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.CurrentTextureData>.NativeClassPtr, nameof (HasTextureData));
        MiniMapHUDSystem.CurrentTextureData.NativeFieldInfoPtr_ZoneType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.CurrentTextureData>.NativeClassPtr, nameof (ZoneType));
        MiniMapHUDSystem.CurrentTextureData.NativeFieldInfoPtr_ProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.CurrentTextureData>.NativeClassPtr, nameof (ProjectionMatrix));
        MiniMapHUDSystem.CurrentTextureData.NativeFieldInfoPtr_WorldToAnchoredSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.CurrentTextureData>.NativeClassPtr, nameof (WorldToAnchoredSpace));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.CurrentTextureData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__23_2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryInitializeMiniMap_b__23_2_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapHUDSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271635, XrefRangeEnd = 1271646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _TryInitializeMiniMap_b__23_2()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c.NativeMethodInfoPtr__TryInitializeMiniMap_b__23_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<MiniMapHUDSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c>.NativeClassPtr);
        MiniMapHUDSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c>.NativeClassPtr, "<>9");
        MiniMapHUDSystem.__c.NativeFieldInfoPtr___9__23_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c>.NativeClassPtr, "<>9__23_2");
        MiniMapHUDSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c>.NativeClassPtr, 100668097);
        MiniMapHUDSystem.__c.NativeMethodInfoPtr__TryInitializeMiniMap_b__23_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c>.NativeClassPtr, 100668098);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe MiniMapHUDSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (MiniMapHUDSystem.__c) null : new MiniMapHUDSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe UnityAction __9__23_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c.NativeFieldInfoPtr___9__23_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (UnityAction) null : new UnityAction(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c.NativeFieldInfoPtr___9__23_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/<>c__DisplayClass27_0")]
    public sealed class __c__DisplayClass27_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_playerAabb;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerPos;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldToAnchoredSpace;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapIconRenderData;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerPathPrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerPathMapIconData;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerPosition2d;
      private static readonly System.IntPtr NativeFieldInfoPtr_visionRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerAnchoredPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_clampDistSq;
      private static readonly System.IntPtr NativeFieldInfoPtr_clampDist;
      private static readonly System.IntPtr NativeFieldInfoPtr_nonClampMaxDistSq;
      private static readonly System.IntPtr NativeFieldInfoPtr_getRespawnPointOwnerBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_PathRecorder_byref_DynamicBuffer_1_PathRecorderEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_MapIconData_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass27_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref PathRecorder pathRecorder,
        [In] ref DynamicBuffer<PathRecorderEntry> pathBuffer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pathRecorder;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref pathBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass27_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_PathRecorder_byref_DynamicBuffer_1_PathRecorderEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        [In] ref PrefabGUID prefabGUID,
        [In] ref Translation translation,
        [In] ref MapIconData mapIconData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapIconData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass27_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_MapIconData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass27_0()
      {
        Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>c__DisplayClass27_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr);
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerAabb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (playerAabb));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localPlayerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (localPlayerTeam));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localPlayerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (localPlayerPos));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_worldToAnchoredSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (worldToAnchoredSpace));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_mapIconRenderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (mapIconRenderData));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerPathPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (playerPathPrefabGuid));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerPathMapIconData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (playerPathMapIconData));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localPlayerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (localPlayerEntity));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerPosition2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (playerPosition2d));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_visionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (visionRange));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (playerAnchoredPosition));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_clampDistSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (clampDistSq));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_clampDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (clampDist));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_nonClampMaxDistSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (nonClampMaxDistSq));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_getRespawnPointOwnerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (getRespawnPointOwnerBuffer));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (localUserEntity));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, nameof (serverTime));
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, 100668099);
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_PathRecorder_byref_DynamicBuffer_1_PathRecorderEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, 100668100);
        MiniMapHUDSystem.__c__DisplayClass27_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_MapIconData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, 100668101);
      }

      public __c__DisplayClass27_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass27_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, data));
      }

      public unsafe Aabb playerAabb
      {
        get
        {
          return *(Aabb*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerAabb));
        }
        [param: In] set
        {
          *(Aabb*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerAabb)) = value;
        }
      }

      public unsafe Team localPlayerTeam
      {
        get
        {
          return *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localPlayerTeam));
        }
        [param: In] set
        {
          *(Team*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localPlayerTeam)) = value;
        }
      }

      public unsafe float3 localPlayerPos
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localPlayerPos));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localPlayerPos)) = value;
        }
      }

      public unsafe float4x4 worldToAnchoredSpace
      {
        get
        {
          return *(float4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_worldToAnchoredSpace));
        }
        [param: In] set
        {
          *(float4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_worldToAnchoredSpace)) = value;
        }
      }

      public unsafe NativeList<MiniMapHUDSystem.MinimapIconRenderData> mapIconRenderData
      {
        get
        {
          return *(NativeList<MiniMapHUDSystem.MinimapIconRenderData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_mapIconRenderData));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_mapIconRenderData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MiniMapHUDSystem.MinimapIconRenderData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe PrefabGUID playerPathPrefabGuid
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerPathPrefabGuid));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerPathPrefabGuid)) = value;
        }
      }

      public unsafe MapIconData playerPathMapIconData
      {
        get
        {
          return *(MapIconData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerPathMapIconData));
        }
        [param: In] set
        {
          *(MapIconData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerPathMapIconData)) = value;
        }
      }

      public unsafe MiniMapHUDSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MiniMapHUDSystem) null : new MiniMapHUDSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Entity localPlayerEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localPlayerEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localPlayerEntity)) = value;
        }
      }

      public unsafe float2 playerPosition2d
      {
        get
        {
          return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerPosition2d));
        }
        [param: In] set
        {
          *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerPosition2d)) = value;
        }
      }

      public unsafe float visionRange
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_visionRange));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_visionRange)) = value;
        }
      }

      public unsafe float3 playerAnchoredPosition
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerAnchoredPosition));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_playerAnchoredPosition)) = value;
        }
      }

      public unsafe float clampDistSq
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_clampDistSq));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_clampDistSq)) = value;
        }
      }

      public unsafe float clampDist
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_clampDist));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_clampDist)) = value;
        }
      }

      public unsafe float nonClampMaxDistSq
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_nonClampMaxDistSq));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_nonClampMaxDistSq)) = value;
        }
      }

      public unsafe BufferFromEntity<RespawnPointOwnerBuffer> getRespawnPointOwnerBuffer
      {
        get
        {
          return *(BufferFromEntity<RespawnPointOwnerBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_getRespawnPointOwnerBuffer));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_getRespawnPointOwnerBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<RespawnPointOwnerBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Entity localUserEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localUserEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_localUserEntity)) = value;
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/<>c__DisplayClass27_1")]
    public sealed class __c__DisplayClass27_1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_occupants;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryAabb;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryDecayBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_foundTerritoryPlayerIsIn;
      private static readonly System.IntPtr NativeFieldInfoPtr_tilePosPlayer;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoriesToShow;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_byref_DynamicBuffer_1_CastleTerritoryTiles_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass27_1()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass27_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        [In] ref CastleTerritory castleTerritory,
        [In] ref MapZoneData mapZoneData,
        [In] ref DynamicBuffer<CastleTerritoryTiles> tiles)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleTerritory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tiles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass27_1.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_byref_DynamicBuffer_1_CastleTerritoryTiles_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass27_1()
      {
        Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>c__DisplayClass27_1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr);
        MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr, nameof (occupants));
        MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_territoryAabb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr, nameof (territoryAabb));
        MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_territoryDecayBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr, nameof (territoryDecayBuffer));
        MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_foundTerritoryPlayerIsIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr, nameof (foundTerritoryPlayerIsIn));
        MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_tilePosPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr, nameof (tilePosPlayer));
        MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_territoriesToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr, nameof (territoriesToShow));
        MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr, "CS$<>8__locals1");
        MiniMapHUDSystem.__c__DisplayClass27_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr, 100668102);
        MiniMapHUDSystem.__c__DisplayClass27_1.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_byref_DynamicBuffer_1_CastleTerritoryTiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr, 100668103);
      }

      public __c__DisplayClass27_1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass27_1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_1>.NativeClassPtr, data));
      }

      public unsafe DynamicBuffer<CastleTerritoryOccupant> occupants
      {
        get
        {
          return *(DynamicBuffer<CastleTerritoryOccupant>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_occupants));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_occupants), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicBuffer<CastleTerritoryOccupant>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Aabb territoryAabb
      {
        get
        {
          return *(Aabb*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_territoryAabb));
        }
        [param: In] set
        {
          *(Aabb*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_territoryAabb)) = value;
        }
      }

      public unsafe DynamicBuffer<CastleTerritoryDecay> territoryDecayBuffer
      {
        get
        {
          return *(DynamicBuffer<CastleTerritoryDecay>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_territoryDecayBuffer));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_territoryDecayBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicBuffer<CastleTerritoryDecay>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe bool foundTerritoryPlayerIsIn
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_foundTerritoryPlayerIsIn));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_foundTerritoryPlayerIsIn)) = value;
        }
      }

      public unsafe int2 tilePosPlayer
      {
        get
        {
          return *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_tilePosPlayer));
        }
        [param: In] set
        {
          *(int2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_tilePosPlayer)) = value;
        }
      }

      public unsafe NativeList<MapMenuMapper.TerritoryOutput> territoriesToShow
      {
        get
        {
          return *(NativeList<MapMenuMapper.TerritoryOutput>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_territoriesToShow));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_territoriesToShow), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MapMenuMapper.TerritoryOutput>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public MiniMapHUDSystem.__c__DisplayClass27_0 field_Public___c__DisplayClass27_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0);
          return new MiniMapHUDSystem.__c__DisplayClass27_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_1.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/<>c__DisplayClass27_2")]
    public sealed class __c__DisplayClass27_2 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_polygonScale;
      private static readonly System.IntPtr NativeFieldInfoPtr_polygonsToShow;
      private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_UiPolygonMesh_byref_MapZoneData_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass27_2()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_2>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass27_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        Entity entity,
        [In] ref UiPolygonMesh uiPolygonMesh,
        [In] ref MapZoneData chunkMapZoneData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref uiPolygonMesh;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref chunkMapZoneData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass27_2.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_UiPolygonMesh_byref_MapZoneData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass27_2()
      {
        Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>c__DisplayClass27_2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_2>.NativeClassPtr);
        MiniMapHUDSystem.__c__DisplayClass27_2.NativeFieldInfoPtr_polygonScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_2>.NativeClassPtr, nameof (polygonScale));
        MiniMapHUDSystem.__c__DisplayClass27_2.NativeFieldInfoPtr_polygonsToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_2>.NativeClassPtr, nameof (polygonsToShow));
        MiniMapHUDSystem.__c__DisplayClass27_2.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_2>.NativeClassPtr, "CS$<>8__locals2");
        MiniMapHUDSystem.__c__DisplayClass27_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_2>.NativeClassPtr, 100668104);
        MiniMapHUDSystem.__c__DisplayClass27_2.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_Entity_byref_UiPolygonMesh_byref_MapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_2>.NativeClassPtr, 100668105);
      }

      public __c__DisplayClass27_2(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass27_2()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_2>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_2>.NativeClassPtr, data));
      }

      public unsafe float polygonScale
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_2.NativeFieldInfoPtr_polygonScale));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_2.NativeFieldInfoPtr_polygonScale)) = value;
        }
      }

      public unsafe NativeList<MapMenuMapper.MapZoneOutput> polygonsToShow
      {
        get
        {
          return *(NativeList<MapMenuMapper.MapZoneOutput>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_2.NativeFieldInfoPtr_polygonsToShow));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_2.NativeFieldInfoPtr_polygonsToShow), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<MapMenuMapper.MapZoneOutput>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public MiniMapHUDSystem.__c__DisplayClass27_0 field_Public___c__DisplayClass27_0_0
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_2.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0);
          return new MiniMapHUDSystem.__c__DisplayClass27_0(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MiniMapHUDSystem.__c__DisplayClass27_2.NativeFieldInfoPtr_field_Public___c__DisplayClass27_0_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass27_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_DetermineVisibleMinimapTerritories")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DetermineVisibleMinimapTerritories
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_occupants;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryAabb;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerAabb;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoryDecayBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_foundTerritoryPlayerIsIn;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerPos;
      private static readonly System.IntPtr NativeFieldInfoPtr_tilePosPlayer;
      private static readonly System.IntPtr NativeFieldInfoPtr_territoriesToShow;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_byref_DynamicBuffer_1_CastleTerritoryTiles_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public DynamicBuffer<CastleTerritoryOccupant> occupants;
      [FieldOffset(16)]
      public Aabb territoryAabb;
      [FieldOffset(40)]
      public Aabb playerAabb;
      [FieldOffset(64)]
      public Team localPlayerTeam;
      [FieldOffset(72)]
      public DynamicBuffer<CastleTerritoryDecay> territoryDecayBuffer;
      [FieldOffset(88)]
      public bool foundTerritoryPlayerIsIn;
      [FieldOffset(92)]
      public float3 localPlayerPos;
      [FieldOffset(104)]
      public int2 tilePosPlayer;
      [FieldOffset(112)]
      public NativeList<MapMenuMapper.TerritoryOutput> territoriesToShow;
      [FieldOffset(128)]
      public MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(240)]
      public unsafe MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271743, XrefRangeEnd = 1271763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref CastleTerritory castleTerritory,
        [In] ref MapZoneData mapZoneData,
        [In] ref DynamicBuffer<CastleTerritoryTiles> tiles)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleTerritory;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapZoneData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tiles;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_byref_DynamicBuffer_1_CastleTerritoryTiles_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1271763, RefRangeEnd = 1271764, XrefRangeStart = 1271763, XrefRangeEnd = 1271763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MiniMapHUDSystem.__c__DisplayClass27_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1271764, RefRangeEnd = 1271765, XrefRangeStart = 1271764, XrefRangeEnd = 1271764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MiniMapHUDSystem.__c__DisplayClass27_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271765, XrefRangeEnd = 1271767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1271779, RefRangeEnd = 1271780, XrefRangeStart = 1271767, XrefRangeEnd = 1271779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1271782, RefRangeEnd = 1271783, XrefRangeStart = 1271780, XrefRangeEnd = 1271782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MiniMapHUDSystem componentSystem,
        ref MiniMapHUDSystem.__c__DisplayClass27_1 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_1_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271783, XrefRangeEnd = 1271787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271787, XrefRangeEnd = 1271793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DetermineVisibleMinimapTerritories()
      {
        Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>c__DisplayClass_DetermineVisibleMinimapTerritories");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr);
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (occupants));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_territoryAabb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (territoryAabb));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_playerAabb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (playerAabb));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_localPlayerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (localPlayerTeam));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_territoryDecayBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (territoryDecayBuffer));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_foundTerritoryPlayerIsIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (foundTerritoryPlayerIsIn));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_localPlayerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (localPlayerPos));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_tilePosPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (tilePosPlayer));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_territoriesToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (territoriesToShow));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (_runtimes));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_CastleTerritory_byref_MapZoneData_byref_DynamicBuffer_1_CastleTerritoryTiles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, 100668106);
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, 100668107);
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, 100668108);
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, 100668109);
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, 100668110);
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, 100668111);
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, 100668112);
        MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, 100668113);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleTerritory;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapZoneData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tiles;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CastleTerritory> forParameter_castleTerritory;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<MapZoneData> forParameter_mapZoneData;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryTiles> forParameter_tiles;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1271656, RefRangeEnd = 1271657, XrefRangeStart = 1271646, XrefRangeEnd = 1271656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MiniMapHUDSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1271667, RefRangeEnd = 1271668, XrefRangeStart = 1271657, XrefRangeEnd = 1271667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleTerritory));
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapZoneData));
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tiles));
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders>.NativeClassPtr, 100668114);
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders>.NativeClassPtr, 100668115);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleTerritory;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapZoneData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tiles;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleTerritory>.Runtime runtime_castleTerritory;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<MapZoneData>.Runtime runtime_mapZoneData;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_DynamicBuffer<CastleTerritoryTiles>.Runtime runtime_tiles;

          static Runtimes()
          {
            Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleTerritory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleTerritory));
            MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapZoneData));
            MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tiles));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_DetermineVisibleMinimapTerritories/ProjectM.UI.RunWithoutJobSystem_0000111C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, "RunWithoutJobSystem_0000111C$PostfixBurstDelegate");
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668116);
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668117);
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668118);
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668119);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_DetermineVisibleMinimapTerritories/ProjectM.UI.RunWithoutJobSystem_0000111C$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271668, XrefRangeEnd = 1271682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271682, XrefRangeEnd = 1271700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271700, XrefRangeEnd = 1271715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1271742, RefRangeEnd = 1271743, XrefRangeStart = 1271715, XrefRangeEnd = 1271742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories>.NativeClassPtr, "RunWithoutJobSystem_0000111C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668120);
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668121);
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668122);
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668123);
          MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668125);
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
            IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_DetermineVisibleMinimapTerritories.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_GetMapZones")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_GetMapZones
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_playerAabb;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldToAnchoredSpace;
      private static readonly System.IntPtr NativeFieldInfoPtr_polygonScale;
      private static readonly System.IntPtr NativeFieldInfoPtr_polygonsToShow;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UiPolygonMesh_byref_MapZoneData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_2_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Aabb playerAabb;
      [FieldOffset(24)]
      public float4x4 worldToAnchoredSpace;
      [FieldOffset(88)]
      public float polygonScale;
      [FieldOffset(96)]
      public NativeList<MapMenuMapper.MapZoneOutput> polygonsToShow;
      [FieldOffset(112)]
      public MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(184)]
      public unsafe MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271884, XrefRangeEnd = 1271891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref UiPolygonMesh uiPolygonMesh,
        [In] ref MapZoneData chunkMapZoneData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref uiPolygonMesh;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref chunkMapZoneData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UiPolygonMesh_byref_MapZoneData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1271891, RefRangeEnd = 1271892, XrefRangeStart = 1271891, XrefRangeEnd = 1271891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MiniMapHUDSystem.__c__DisplayClass27_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1271892, RefRangeEnd = 1271893, XrefRangeStart = 1271892, XrefRangeEnd = 1271892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MiniMapHUDSystem.__c__DisplayClass27_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271893, XrefRangeEnd = 1271895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1271904, RefRangeEnd = 1271905, XrefRangeStart = 1271895, XrefRangeEnd = 1271904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1271907, RefRangeEnd = 1271908, XrefRangeStart = 1271905, XrefRangeEnd = 1271907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MiniMapHUDSystem componentSystem,
        ref MiniMapHUDSystem.__c__DisplayClass27_2 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271908, XrefRangeEnd = 1271912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271912, XrefRangeEnd = 1271918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_GetMapZones()
      {
        Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>c__DisplayClass_GetMapZones");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr);
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_playerAabb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (playerAabb));
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_worldToAnchoredSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (worldToAnchoredSpace));
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_polygonScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (polygonScale));
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_polygonsToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (polygonsToShow));
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (_runtimes));
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UiPolygonMesh_byref_MapZoneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100668126);
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100668127);
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100668128);
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100668129);
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100668130);
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100668131);
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100668132);
        MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, 100668133);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_uiPolygonMesh;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_chunkMapZoneData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UiPolygonMesh> forParameter_uiPolygonMesh;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<MapZoneData> forParameter_chunkMapZoneData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1271800, RefRangeEnd = 1271801, XrefRangeStart = 1271793, XrefRangeEnd = 1271800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MiniMapHUDSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1271808, RefRangeEnd = 1271809, XrefRangeStart = 1271801, XrefRangeEnd = 1271808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_uiPolygonMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_uiPolygonMesh));
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_chunkMapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_chunkMapZoneData));
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, 100668134);
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, 100668135);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_uiPolygonMesh;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_chunkMapZoneData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<UiPolygonMesh>.Runtime runtime_uiPolygonMesh;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<MapZoneData>.Runtime runtime_chunkMapZoneData;

          static Runtimes()
          {
            Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_uiPolygonMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_uiPolygonMesh));
            MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_chunkMapZoneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_chunkMapZoneData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_GetMapZones/ProjectM.UI.RunWithoutJobSystem_00001125$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, "RunWithoutJobSystem_00001125$PostfixBurstDelegate");
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668136);
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668137);
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668138);
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668139);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_GetMapZones/ProjectM.UI.RunWithoutJobSystem_00001125$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271809, XrefRangeEnd = 1271823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271823, XrefRangeEnd = 1271841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271841, XrefRangeEnd = 1271856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1271883, RefRangeEnd = 1271884, XrefRangeStart = 1271856, XrefRangeEnd = 1271883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones>.NativeClassPtr, "RunWithoutJobSystem_00001125$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668140);
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668141);
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668142);
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668143);
          MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668145);
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
            IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_GetMapZones.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_worldToAnchoredSpace;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapIconRenderData;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerPathPrefabGuid;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerPathMapIconData;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PathRecorder_byref_DynamicBuffer_1_PathRecorderEntry_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float4x4 worldToAnchoredSpace;
      [FieldOffset(64)]
      public NativeList<MiniMapHUDSystem.MinimapIconRenderData> mapIconRenderData;
      [FieldOffset(80)]
      public PrefabGUID playerPathPrefabGuid;
      [FieldOffset(84)]
      public MapIconData playerPathMapIconData;
      [FieldOffset(136)]
      public MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(216)]
      public unsafe MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272009, XrefRangeEnd = 1272027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref PathRecorder pathRecorder,
        [In] ref DynamicBuffer<PathRecorderEntry> pathBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pathRecorder;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref pathBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PathRecorder_byref_DynamicBuffer_1_PathRecorderEntry_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1272027, RefRangeEnd = 1272028, XrefRangeStart = 1272027, XrefRangeEnd = 1272027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MiniMapHUDSystem.__c__DisplayClass27_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1272028, RefRangeEnd = 1272029, XrefRangeStart = 1272028, XrefRangeEnd = 1272028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MiniMapHUDSystem.__c__DisplayClass27_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272029, XrefRangeEnd = 1272031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1272040, RefRangeEnd = 1272041, XrefRangeStart = 1272031, XrefRangeEnd = 1272040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1272043, RefRangeEnd = 1272044, XrefRangeStart = 1272041, XrefRangeEnd = 1272043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MiniMapHUDSystem componentSystem,
        ref MiniMapHUDSystem.__c__DisplayClass27_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272044, XrefRangeEnd = 1272048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272048, XrefRangeEnd = 1272054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob2()
      {
        Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr);
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_worldToAnchoredSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (worldToAnchoredSpace));
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_mapIconRenderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (mapIconRenderData));
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_playerPathPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (playerPathPrefabGuid));
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_playerPathMapIconData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (playerPathMapIconData));
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PathRecorder_byref_DynamicBuffer_1_PathRecorderEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100668146);
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100668147);
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100668148);
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100668149);
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100668150);
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100668151);
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100668152);
        MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, 100668153);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_pathRecorder;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_pathBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<PathRecorder> forParameter_pathRecorder;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<PathRecorderEntry> forParameter_pathBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1271925, RefRangeEnd = 1271926, XrefRangeStart = 1271918, XrefRangeEnd = 1271925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MiniMapHUDSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1271933, RefRangeEnd = 1271934, XrefRangeStart = 1271926, XrefRangeEnd = 1271933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_pathRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_pathRecorder));
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_pathBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_pathBuffer));
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100668154);
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100668155);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_pathRecorder;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_pathBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PathRecorder>.Runtime runtime_pathRecorder;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<PathRecorderEntry>.Runtime runtime_pathBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_pathRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_pathRecorder));
            MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_pathBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_pathBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.UI.RunWithoutJobSystem_0000112E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_0000112E$PostfixBurstDelegate");
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668156);
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668157);
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668158);
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668159);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob2/ProjectM.UI.RunWithoutJobSystem_0000112E$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271934, XrefRangeEnd = 1271948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271948, XrefRangeEnd = 1271966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271966, XrefRangeEnd = 1271981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1272008, RefRangeEnd = 1272009, XrefRangeStart = 1271981, XrefRangeEnd = 1272008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_0000112E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668160);
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668161);
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668162);
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668163);
          MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668165);
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
            IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_UpdateMapIconPositions")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateMapIconPositions
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerPosition2d;
      private static readonly System.IntPtr NativeFieldInfoPtr_visionRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_worldToAnchoredSpace;
      private static readonly System.IntPtr NativeFieldInfoPtr_playerAnchoredPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_clampDistSq;
      private static readonly System.IntPtr NativeFieldInfoPtr_clampDist;
      private static readonly System.IntPtr NativeFieldInfoPtr_nonClampMaxDistSq;
      private static readonly System.IntPtr NativeFieldInfoPtr_getRespawnPointOwnerBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_localUserEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_localPlayerTeam;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_mapIconRenderData;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_MapIconTargetEntity_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_SpawnLocationSelector_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Team_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_CastleHeart_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Pylonstation_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_MapIconData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Entity localPlayerEntity;
      [FieldOffset(8)]
      public float2 playerPosition2d;
      [FieldOffset(16)]
      public float visionRange;
      [FieldOffset(20)]
      public float4x4 worldToAnchoredSpace;
      [FieldOffset(84)]
      public float3 playerAnchoredPosition;
      [FieldOffset(96)]
      public float clampDistSq;
      [FieldOffset(100)]
      public float clampDist;
      [FieldOffset(104)]
      public float nonClampMaxDistSq;
      [FieldOffset(112)]
      public BufferFromEntity<RespawnPointOwnerBuffer> getRespawnPointOwnerBuffer;
      [FieldOffset(152)]
      public Entity localUserEntity;
      [FieldOffset(160)]
      public Team localPlayerTeam;
      [FieldOffset(168)]
      public double serverTime;
      [FieldOffset(176)]
      public NativeList<MiniMapHUDSystem.MinimapIconRenderData> mapIconRenderData;
      [FieldOffset(192)]
      public ComponentDataFromEntity<MapIconTargetEntity> _ComponentDataFromEntity_MapIconTargetEntity_0;
      [FieldOffset(224)]
      public ComponentDataFromEntity<SpawnLocationSelector> _ComponentDataFromEntity_SpawnLocationSelector_1;
      [FieldOffset(256)]
      public ComponentDataFromEntity<Team> _ComponentDataFromEntity_Team_2;
      [FieldOffset(288)]
      public ComponentDataFromEntity<CastleHeart> _ComponentDataFromEntity_CastleHeart_3;
      [FieldOffset(320)]
      public ComponentDataFromEntity<Pylonstation> _ComponentDataFromEntity_Pylonstation_4;
      [FieldOffset(352)]
      public MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(456)]
      public unsafe MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272151, XrefRangeEnd = 1272211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref PrefabGUID prefabGUID,
        [In] ref Translation translation,
        [In] ref MapIconData mapIconData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabGUID;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapIconData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_MapIconData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1272211, RefRangeEnd = 1272212, XrefRangeStart = 1272211, XrefRangeEnd = 1272211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MiniMapHUDSystem.__c__DisplayClass27_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1272212, RefRangeEnd = 1272213, XrefRangeStart = 1272212, XrefRangeEnd = 1272212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MiniMapHUDSystem.__c__DisplayClass27_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272213, XrefRangeEnd = 1272215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1272227, RefRangeEnd = 1272228, XrefRangeStart = 1272215, XrefRangeEnd = 1272227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1272245, RefRangeEnd = 1272246, XrefRangeStart = 1272228, XrefRangeEnd = 1272245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MiniMapHUDSystem componentSystem,
        ref MiniMapHUDSystem.__c__DisplayClass27_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272246, XrefRangeEnd = 1272250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272250, XrefRangeEnd = 1272256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateMapIconPositions()
      {
        Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateMapIconPositions");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr);
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_localPlayerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (localPlayerEntity));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_playerPosition2d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (playerPosition2d));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_visionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (visionRange));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_worldToAnchoredSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (worldToAnchoredSpace));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_playerAnchoredPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (playerAnchoredPosition));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_clampDistSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (clampDistSq));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_clampDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (clampDist));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_nonClampMaxDistSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (nonClampMaxDistSq));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_getRespawnPointOwnerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (getRespawnPointOwnerBuffer));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_localUserEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (localUserEntity));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_localPlayerTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (localPlayerTeam));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (serverTime));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_mapIconRenderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (mapIconRenderData));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr__ComponentDataFromEntity_MapIconTargetEntity_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (_ComponentDataFromEntity_MapIconTargetEntity_0));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr__ComponentDataFromEntity_SpawnLocationSelector_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (_ComponentDataFromEntity_SpawnLocationSelector_1));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr__ComponentDataFromEntity_Team_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (_ComponentDataFromEntity_Team_2));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr__ComponentDataFromEntity_CastleHeart_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (_ComponentDataFromEntity_CastleHeart_3));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr__ComponentDataFromEntity_Pylonstation_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (_ComponentDataFromEntity_Pylonstation_4));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (_runtimes));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_PrefabGUID_byref_Translation_byref_MapIconData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, 100668166);
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, 100668167);
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, 100668168);
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, 100668169);
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, 100668170);
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_byref___c__DisplayClass27_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, 100668171);
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, 100668172);
        MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, 100668173);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_prefabGUID;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapIconData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<PrefabGUID> forParameter_prefabGUID;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<MapIconData> forParameter_mapIconData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1272064, RefRangeEnd = 1272065, XrefRangeStart = 1272054, XrefRangeEnd = 1272064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MiniMapHUDSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1272075, RefRangeEnd = 1272076, XrefRangeStart = 1272065, XrefRangeEnd = 1272075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_prefabGUID));
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapIconData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapIconData));
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MiniMapHUDSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders>.NativeClassPtr, 100668174);
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders>.NativeClassPtr, 100668175);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_prefabGUID;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapIconData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PrefabGUID>.Runtime runtime_prefabGUID;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<MapIconData>.Runtime runtime_mapIconData;

          static Runtimes()
          {
            Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_prefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_prefabGUID));
            MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
            MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapIconData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapIconData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_UpdateMapIconPositions/ProjectM.UI.RunWithoutJobSystem_00001137$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, "RunWithoutJobSystem_00001137$PostfixBurstDelegate");
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668176);
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668177);
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668178);
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100668179);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.UI.MiniMapHUDSystem/ProjectM.UI.<>c__DisplayClass_UpdateMapIconPositions/ProjectM.UI.RunWithoutJobSystem_00001137$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272076, XrefRangeEnd = 1272090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272090, XrefRangeEnd = 1272108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272108, XrefRangeEnd = 1272123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1272150, RefRangeEnd = 1272151, XrefRangeStart = 1272123, XrefRangeEnd = 1272150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions>.NativeClassPtr, "RunWithoutJobSystem_00001137$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668180);
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668181);
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668182);
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668183);
          MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100668185);
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
            IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(MiniMapHUDSystem.__c__DisplayClass_UpdateMapIconPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
