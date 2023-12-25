// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ReplayHUDSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Replays;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class ReplayHUDSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplayParent;
    private static readonly System.IntPtr NativeFieldInfoPtr__PointerDown;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientReplayPlayerEnabledAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__PersistentReplayDataAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__Sprites;
    private static readonly System.IntPtr NativeFieldInfoPtr__Data;
    private static readonly System.IntPtr NativeFieldInfoPtr__TimeScaleInitialized;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrePauseTimeScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_START_RECORDING_TEXT;
    private static readonly System.IntPtr NativeFieldInfoPtr_STOP_RECORDING_TEXT;
    private static readonly System.IntPtr NativeFieldInfoPtr_PAUSE_TEXT;
    private static readonly System.IntPtr NativeFieldInfoPtr_RESUME_TEXT;
    private static readonly System.IntPtr NativeFieldInfoPtr_START_SWEEP_RECORDING_TEXT;
    private static readonly System.IntPtr NativeFieldInfoPtr_STOP_SWEEP_RECORDING_TEXT;
    private static readonly System.IntPtr NativeFieldInfoPtr_START_SWEEP_PLAYBACK_TEXT;
    private static readonly System.IntPtr NativeFieldInfoPtr_STOP_SWEEP_PLAYBACK_TEXT;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_TimeScale_27;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_ReplayPlayerData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindSprite_Private_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleSliderPointerUp_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleSliderPointerDown_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleToggleRecordingClicked_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPaused_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleTogglePauseClicked_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRecordingCameraSweep_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayingCameraSweep_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleToggleSweepRecordingClicked_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleToggleSweepPlaybackClicked_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHovered_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPersistentTimeScale_Private_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPersistentTimeScale_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__21_0_Private_Void_Entity_UICanvasBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274354, XrefRangeEnd = 1274381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplayHUDSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274381, XrefRangeEnd = 1274388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplayHUDSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274388, XrefRangeEnd = 1274396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplayHUDSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274396, XrefRangeEnd = 1274477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplayHUDSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1274487, RefRangeEnd = 1274488, XrefRangeStart = 1274477, XrefRangeEnd = 1274487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Reset(ReplayHUDSystem.ReplayPlayerData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_Reset_Public_Void_ReplayPlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274488, XrefRangeEnd = 1274491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetActive(bool value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274491, XrefRangeEnd = 1274492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Sprite FindSprite()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_FindSprite_Private_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274492, XrefRangeEnd = 1274509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleSliderPointerUp()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_HandleSliderPointerUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274509, XrefRangeEnd = 1274513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleSliderPointerDown()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_HandleSliderPointerDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274513, XrefRangeEnd = 1274535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleToggleRecordingClicked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_HandleToggleRecordingClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1274538, RefRangeEnd = 1274539, XrefRangeStart = 1274535, XrefRangeEnd = 1274538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsPaused()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_IsPaused_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274539, XrefRangeEnd = 1274547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleTogglePauseClicked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_HandleTogglePauseClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1274560, RefRangeEnd = 1274562, XrefRangeStart = 1274547, XrefRangeEnd = 1274560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsRecordingCameraSweep()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_IsRecordingCameraSweep_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1274575, RefRangeEnd = 1274577, XrefRangeStart = 1274562, XrefRangeEnd = 1274575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsPlayingCameraSweep()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_IsPlayingCameraSweep_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274577, XrefRangeEnd = 1274599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleToggleSweepRecordingClicked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_HandleToggleSweepRecordingClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274599, XrefRangeEnd = 1274621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleToggleSweepPlaybackClicked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_HandleToggleSweepPlaybackClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274621, XrefRangeEnd = 1274627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsHovered()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_IsHovered_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274627, XrefRangeEnd = 1274630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetPersistentTimeScale()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_GetPersistentTimeScale_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1274644, RefRangeEnd = 1274646, XrefRangeStart = 1274630, XrefRangeEnd = 1274644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetPersistentTimeScale()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr_SetPersistentTimeScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274646, XrefRangeEnd = 1274654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReplayHUDSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1274698, RefRangeEnd = 1274699, XrefRangeStart = 1274654, XrefRangeEnd = 1274698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__21_0(Entity entity, UICanvasBase canvasBase)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvasBase);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr__OnUpdate_b__21_0_Private_Void_Entity_UICanvasBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274699, XrefRangeEnd = 1274738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplayHUDSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274738, XrefRangeEnd = 1274754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ReplayHUDSystem()
    {
      Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ReplayHUDSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr);
      ReplayHUDSystem.NativeFieldInfoPtr__ReplayParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (_ReplayParent));
      ReplayHUDSystem.NativeFieldInfoPtr__PointerDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (_PointerDown));
      ReplayHUDSystem.NativeFieldInfoPtr__ClientReplayPlayerEnabledAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (_ClientReplayPlayerEnabledAccessor));
      ReplayHUDSystem.NativeFieldInfoPtr__PersistentReplayDataAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (_PersistentReplayDataAccessor));
      ReplayHUDSystem.NativeFieldInfoPtr__Sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (_Sprites));
      ReplayHUDSystem.NativeFieldInfoPtr__Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (_Data));
      ReplayHUDSystem.NativeFieldInfoPtr__TimeScaleInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (_TimeScaleInitialized));
      ReplayHUDSystem.NativeFieldInfoPtr__PrePauseTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (_PrePauseTimeScale));
      ReplayHUDSystem.NativeFieldInfoPtr_START_RECORDING_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (START_RECORDING_TEXT));
      ReplayHUDSystem.NativeFieldInfoPtr_STOP_RECORDING_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (STOP_RECORDING_TEXT));
      ReplayHUDSystem.NativeFieldInfoPtr_PAUSE_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (PAUSE_TEXT));
      ReplayHUDSystem.NativeFieldInfoPtr_RESUME_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (RESUME_TEXT));
      ReplayHUDSystem.NativeFieldInfoPtr_START_SWEEP_RECORDING_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (START_SWEEP_RECORDING_TEXT));
      ReplayHUDSystem.NativeFieldInfoPtr_STOP_SWEEP_RECORDING_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (STOP_SWEEP_RECORDING_TEXT));
      ReplayHUDSystem.NativeFieldInfoPtr_START_SWEEP_PLAYBACK_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (START_SWEEP_PLAYBACK_TEXT));
      ReplayHUDSystem.NativeFieldInfoPtr_STOP_SWEEP_PLAYBACK_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (STOP_SWEEP_PLAYBACK_TEXT));
      ReplayHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      ReplayHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      ReplayHUDSystem.NativeFieldInfoPtr__SingletonEntityQuery_TimeScale_27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_TimeScale_27));
      ReplayHUDSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668339);
      ReplayHUDSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668340);
      ReplayHUDSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668341);
      ReplayHUDSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668342);
      ReplayHUDSystem.NativeMethodInfoPtr_Reset_Public_Void_ReplayPlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668343);
      ReplayHUDSystem.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668344);
      ReplayHUDSystem.NativeMethodInfoPtr_FindSprite_Private_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668345);
      ReplayHUDSystem.NativeMethodInfoPtr_HandleSliderPointerUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668346);
      ReplayHUDSystem.NativeMethodInfoPtr_HandleSliderPointerDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668347);
      ReplayHUDSystem.NativeMethodInfoPtr_HandleToggleRecordingClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668348);
      ReplayHUDSystem.NativeMethodInfoPtr_IsPaused_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668349);
      ReplayHUDSystem.NativeMethodInfoPtr_HandleTogglePauseClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668350);
      ReplayHUDSystem.NativeMethodInfoPtr_IsRecordingCameraSweep_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668351);
      ReplayHUDSystem.NativeMethodInfoPtr_IsPlayingCameraSweep_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668352);
      ReplayHUDSystem.NativeMethodInfoPtr_HandleToggleSweepRecordingClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668353);
      ReplayHUDSystem.NativeMethodInfoPtr_HandleToggleSweepPlaybackClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668354);
      ReplayHUDSystem.NativeMethodInfoPtr_IsHovered_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668355);
      ReplayHUDSystem.NativeMethodInfoPtr_GetPersistentTimeScale_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668356);
      ReplayHUDSystem.NativeMethodInfoPtr_SetPersistentTimeScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668357);
      ReplayHUDSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668358);
      ReplayHUDSystem.NativeMethodInfoPtr__OnUpdate_b__21_0_Private_Void_Entity_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668360);
      ReplayHUDSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668361);
      ReplayHUDSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, 100668362);
    }

    public ReplayHUDSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ReplayHUDParent _ReplayParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__ReplayParent));
        return pointer == System.IntPtr.Zero ? (ReplayHUDParent) null : new ReplayHUDParent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__ReplayParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _PointerDown
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__PointerDown));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__PointerDown)) = value;
      }
    }

    public unsafe SingletonAccessor<ClientReplayPlayerEnabled> _ClientReplayPlayerEnabledAccessor
    {
      get
      {
        return *(SingletonAccessor<ClientReplayPlayerEnabled>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__ClientReplayPlayerEnabledAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__ClientReplayPlayerEnabledAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ClientReplayPlayerEnabled>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<PersistentReplayData> _PersistentReplayDataAccessor
    {
      get
      {
        return *(SingletonAccessor<PersistentReplayData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__PersistentReplayDataAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__PersistentReplayDataAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<PersistentReplayData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<Sprite> _Sprites
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__Sprites));
        return pointer == System.IntPtr.Zero ? (List<Sprite>) null : new List<Sprite>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__Sprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ReplayHUDSystem.ReplayPlayerData _Data
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__Data));
        return pointer == System.IntPtr.Zero ? (ReplayHUDSystem.ReplayPlayerData) null : new ReplayHUDSystem.ReplayPlayerData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__Data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _TimeScaleInitialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__TimeScaleInitialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__TimeScaleInitialized)) = value;
      }
    }

    public unsafe float _PrePauseTimeScale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__PrePauseTimeScale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__PrePauseTimeScale)) = value;
      }
    }

    public static unsafe string START_RECORDING_TEXT
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ReplayHUDSystem.NativeFieldInfoPtr_START_RECORDING_TEXT, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayHUDSystem.NativeFieldInfoPtr_START_RECORDING_TEXT, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string STOP_RECORDING_TEXT
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ReplayHUDSystem.NativeFieldInfoPtr_STOP_RECORDING_TEXT, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayHUDSystem.NativeFieldInfoPtr_STOP_RECORDING_TEXT, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string PAUSE_TEXT
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ReplayHUDSystem.NativeFieldInfoPtr_PAUSE_TEXT, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayHUDSystem.NativeFieldInfoPtr_PAUSE_TEXT, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string RESUME_TEXT
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ReplayHUDSystem.NativeFieldInfoPtr_RESUME_TEXT, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayHUDSystem.NativeFieldInfoPtr_RESUME_TEXT, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string START_SWEEP_RECORDING_TEXT
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ReplayHUDSystem.NativeFieldInfoPtr_START_SWEEP_RECORDING_TEXT, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayHUDSystem.NativeFieldInfoPtr_START_SWEEP_RECORDING_TEXT, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string STOP_SWEEP_RECORDING_TEXT
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ReplayHUDSystem.NativeFieldInfoPtr_STOP_SWEEP_RECORDING_TEXT, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayHUDSystem.NativeFieldInfoPtr_STOP_SWEEP_RECORDING_TEXT, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string START_SWEEP_PLAYBACK_TEXT
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ReplayHUDSystem.NativeFieldInfoPtr_START_SWEEP_PLAYBACK_TEXT, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayHUDSystem.NativeFieldInfoPtr_START_SWEEP_PLAYBACK_TEXT, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string STOP_SWEEP_PLAYBACK_TEXT
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ReplayHUDSystem.NativeFieldInfoPtr_STOP_SWEEP_PLAYBACK_TEXT, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ReplayHUDSystem.NativeFieldInfoPtr_STOP_SWEEP_PLAYBACK_TEXT, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_TimeScale_27
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__SingletonEntityQuery_TimeScale_27));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.NativeFieldInfoPtr__SingletonEntityQuery_TimeScale_27)) = value;
      }
    }

    public class Screenshot : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Texture;
      private static readonly System.IntPtr NativeFieldInfoPtr_Time;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Screenshot()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplayHUDSystem.Screenshot>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.Screenshot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Screenshot()
      {
        Il2CppClassPointerStore<ReplayHUDSystem.Screenshot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (Screenshot));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplayHUDSystem.Screenshot>.NativeClassPtr);
        ReplayHUDSystem.Screenshot.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.Screenshot>.NativeClassPtr, nameof (Texture));
        ReplayHUDSystem.Screenshot.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.Screenshot>.NativeClassPtr, nameof (Time));
        ReplayHUDSystem.Screenshot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem.Screenshot>.NativeClassPtr, 100668363);
      }

      public Screenshot(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Texture2D Texture
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.Screenshot.NativeFieldInfoPtr_Texture));
          return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.Screenshot.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe double Time
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.Screenshot.NativeFieldInfoPtr_Time));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.Screenshot.NativeFieldInfoPtr_Time)) = value;
        }
      }
    }

    public class ReplayPlayerData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Screenshots;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_Length;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ReplayPlayerData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplayHUDSystem.ReplayPlayerData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.ReplayPlayerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ReplayPlayerData()
      {
        Il2CppClassPointerStore<ReplayHUDSystem.ReplayPlayerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, nameof (ReplayPlayerData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplayHUDSystem.ReplayPlayerData>.NativeClassPtr);
        ReplayHUDSystem.ReplayPlayerData.NativeFieldInfoPtr_Screenshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.ReplayPlayerData>.NativeClassPtr, nameof (Screenshots));
        ReplayHUDSystem.ReplayPlayerData.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.ReplayPlayerData>.NativeClassPtr, nameof (StartTime));
        ReplayHUDSystem.ReplayPlayerData.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.ReplayPlayerData>.NativeClassPtr, nameof (Length));
        ReplayHUDSystem.ReplayPlayerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem.ReplayPlayerData>.NativeClassPtr, 100668364);
      }

      public ReplayPlayerData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe Il2CppReferenceArray<ReplayHUDSystem.Screenshot> Screenshots
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.ReplayPlayerData.NativeFieldInfoPtr_Screenshots));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ReplayHUDSystem.Screenshot>) null : new Il2CppReferenceArray<ReplayHUDSystem.Screenshot>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.ReplayPlayerData.NativeFieldInfoPtr_Screenshots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe double StartTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.ReplayPlayerData.NativeFieldInfoPtr_StartTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.ReplayPlayerData.NativeFieldInfoPtr_StartTime)) = value;
        }
      }

      public unsafe double Length
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.ReplayPlayerData.NativeFieldInfoPtr_Length));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.ReplayPlayerData.NativeFieldInfoPtr_Length)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.ReplayHUDSystem/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplayHUDSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1274335, RefRangeEnd = 1274336, XrefRangeStart = 1274333, XrefRangeEnd = 1274335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, UICanvasBase canvasBase)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvasBase);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274336, XrefRangeEnd = 1274338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1274344, RefRangeEnd = 1274345, XrefRangeStart = 1274338, XrefRangeEnd = 1274344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1274347, RefRangeEnd = 1274348, XrefRangeStart = 1274345, XrefRangeEnd = 1274347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(ReplayHUDSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplayHUDSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274348, XrefRangeEnd = 1274354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplayHUDSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668365);
        ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668366);
        ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668367);
        ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplayHUDSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668368);
        ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100668369);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe ReplayHUDSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (ReplayHUDSystem) null : new ReplayHUDSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_canvasBase;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplayHUDSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<UICanvasBase> forParameter_canvasBase;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1274326, RefRangeEnd = 1274327, XrefRangeStart = 1274322, XrefRangeEnd = 1274326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ReplayHUDSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplayHUDSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1274332, RefRangeEnd = 1274333, XrefRangeStart = 1274327, XrefRangeEnd = 1274332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_canvasBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_canvasBase));
          ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplayHUDSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100668370);
          ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100668371);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_canvasBase;

          static Runtimes()
          {
            Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvasBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_canvasBase));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public unsafe LambdaParameterValueProvider_Entity.Runtime runtime_entity
          {
            get
            {
              return *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity));
            }
            [param: In] set
            {
              *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity)) = value;
            }
          }

          public LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime runtime_canvasBase
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvasBase);
              return new LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvasBase), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }
  }
}
