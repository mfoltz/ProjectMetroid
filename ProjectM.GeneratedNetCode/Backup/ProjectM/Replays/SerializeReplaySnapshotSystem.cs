// Decompiled with JetBrains decompiler
// Type: ProjectM.Replays.SerializeReplaySnapshotSystem
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Network;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Profiling;
using UnityEngine;

#nullable disable
namespace ProjectM.Replays
{
  public class SerializeReplaySnapshotSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__CreateSnapshotQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkedComponentLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkedComponentSet;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkedComponentToTypeIndexLookup;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkedComponentSizes;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetBufferData;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetBufferLengthBits;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentEventEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReceivePacketSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ScaleTextureMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__EncodeTextureMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__FinalizeMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkedComponents_Private_Void_List_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkedComponentsExternal_Public_Void_List_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleScreenshot_Private_Void_Texture2D_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResizeTexture_Private_Texture2D_Texture2D_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintNetBuffer_Public_Void_byref_NetBufferIn_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RunWeakRefJob_Public_Void_NativeArray_1_Entity_byref_WeakRefTracker_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1481274, XrefRangeEnd = 1481293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializeReplaySnapshotSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1481293, XrefRangeEnd = 1481362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStartRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializeReplaySnapshotSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1481362, XrefRangeEnd = 1481378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnStopRunning()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializeReplaySnapshotSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1481593, RefRangeEnd = 1481595, XrefRangeStart = 1481378, XrefRangeEnd = 1481593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetNetworkedComponents(List<Il2CppSystem.Type> types)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) types);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.NativeMethodInfoPtr_GetNetworkedComponents_Private_Void_List_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1481596, RefRangeEnd = 1481597, XrefRangeStart = 1481595, XrefRangeEnd = 1481596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetNetworkedComponentsExternal(List<Il2CppSystem.Type> types)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) types);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.NativeMethodInfoPtr_GetNetworkedComponentsExternal_Public_Void_List_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1481597, XrefRangeEnd = 1481676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializeReplaySnapshotSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1481676, XrefRangeEnd = 1481720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleScreenshot(Texture2D texture)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.NativeMethodInfoPtr_HandleScreenshot_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1481720, XrefRangeEnd = 1481742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Texture2D ResizeTexture(Texture2D texture, int x, int y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.NativeMethodInfoPtr_ResizeTexture_Private_Texture2D_Texture2D_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1481742, XrefRangeEnd = 1481882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintNetBuffer(ref NetBufferIn netBuffer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.NativeMethodInfoPtr_PrintNetBuffer_Public_Void_byref_NetBufferIn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1482005, RefRangeEnd = 1482006, XrefRangeStart = 1481882, XrefRangeEnd = 1482005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetupJob(
      ref SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams jobParams)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref jobParams;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1482022, RefRangeEnd = 1482023, XrefRangeStart = 1482006, XrefRangeEnd = 1482022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RunWeakRefJob(
      NativeArray<Entity> snapshotEntities,
      ref WeakRefTracker weakRefTracker)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &snapshotEntities;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref weakRefTracker;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.NativeMethodInfoPtr_RunWeakRefJob_Public_Void_NativeArray_1_Entity_byref_WeakRefTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SerializeReplaySnapshotSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SerializeReplaySnapshotSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SerializeReplaySnapshotSystem()
    {
      Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Replays", nameof (SerializeReplaySnapshotSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr);
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_Query));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__CreateSnapshotQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_CreateSnapshotQuery));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_NetworkedComponentLookup));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_NetworkedComponentSet));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentToTypeIndexLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_NetworkedComponentToTypeIndexLookup));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_NetworkedComponentSizes));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_NetBufferData));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetBufferLengthBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_NetBufferLengthBits));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__CurrentEventEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_CurrentEventEntity));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__ReceivePacketSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_ReceivePacketSystem));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__ScaleTextureMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_ScaleTextureMarker));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__EncodeTextureMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_EncodeTextureMarker));
      SerializeReplaySnapshotSystem.NativeFieldInfoPtr__FinalizeMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (_FinalizeMarker));
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663299);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_OnStartRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663300);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_OnStopRunning_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663301);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_GetNetworkedComponents_Private_Void_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663302);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_GetNetworkedComponentsExternal_Public_Void_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663303);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663304);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_HandleScreenshot_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663305);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_ResizeTexture_Private_Texture2D_Texture2D_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663306);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_PrintNetBuffer_Public_Void_byref_NetBufferIn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663307);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_SetupJob_Private_Void_byref_JobParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663308);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_RunWeakRefJob_Public_Void_NativeArray_1_Entity_byref_WeakRefTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663309);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663310);
      SerializeReplaySnapshotSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, 100663312);
    }

    public SerializeReplaySnapshotSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe EntityQuery _CreateSnapshotQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__CreateSnapshotQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__CreateSnapshotQuery)) = value;
      }
    }

    public unsafe NativeHashMap<int, int> _NetworkedComponentLookup
    {
      get
      {
        return *(NativeHashMap<int, int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentLookup));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeHashSet<int> _NetworkedComponentSet
    {
      get
      {
        return *(NativeHashSet<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentSet));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentSet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetworkedComponentToTypeIndexLookup
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentToTypeIndexLookup));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentToTypeIndexLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetworkedComponentSizes
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentSizes));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetworkedComponentSizes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeArray<byte> _NetBufferData
    {
      get
      {
        return *(NativeArray<byte>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetBufferData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetBufferData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeArray<int> _NetBufferLengthBits
    {
      get
      {
        return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetBufferLengthBits));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__NetBufferLengthBits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Entity _CurrentEventEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__CurrentEventEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__CurrentEventEntity)) = value;
      }
    }

    public unsafe ReceivePacketSystem _ReceivePacketSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__ReceivePacketSystem));
        return pointer == System.IntPtr.Zero ? (ReceivePacketSystem) null : new ReceivePacketSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__ReceivePacketSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe ProfilerMarker _ScaleTextureMarker
    {
      get
      {
        ProfilerMarker scaleTextureMarker;
        IL2CPP.il2cpp_field_static_get_value(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__ScaleTextureMarker, (void*) &scaleTextureMarker);
        return scaleTextureMarker;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__ScaleTextureMarker, (void*) &value);
      }
    }

    public static unsafe ProfilerMarker _EncodeTextureMarker
    {
      get
      {
        ProfilerMarker encodeTextureMarker;
        IL2CPP.il2cpp_field_static_get_value(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__EncodeTextureMarker, (void*) &encodeTextureMarker);
        return encodeTextureMarker;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__EncodeTextureMarker, (void*) &value);
      }
    }

    public static unsafe ProfilerMarker _FinalizeMarker
    {
      get
      {
        ProfilerMarker finalizeMarker;
        IL2CPP.il2cpp_field_static_get_value(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__FinalizeMarker, (void*) &finalizeMarker);
        return finalizeMarker;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SerializeReplaySnapshotSystem.NativeFieldInfoPtr__FinalizeMarker, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SetupWeakRefsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SnapshotEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkId;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetworkSnapshot;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetNetSnapshot;
      private static readonly System.IntPtr NativeFieldInfoPtr_WeakRefTracker;
      private static readonly System.IntPtr NativeFieldInfoPtr_Params;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbbdiefgbd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbbgiidegf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbdgdebikk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbfcjichfb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbhckcfdfd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbhkjccgdi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbicfeedbb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbiddcjjid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acccfjkdigh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acccgefcedb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accdbefiheb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accdjiedgfe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accgciikfbf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accgiggcif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acchhgcjcbh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acchibekekj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acciegkehkf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdccjhicfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdehhkijdj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdfgkkfchc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdficciidc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdibbekbkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdidhjbjgj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdjdjkckhd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdjighgcci_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdkgjbefjd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdkkhcbdcg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acecggedbff_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aceegbjekgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aceehcgeedj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acegbdcgkdf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aceihfcgifd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acekdgegehc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acekjgheehk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfckgbfifj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfebiceeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfhdekidie_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfikjcfik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgbiiekebj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgchdfhdbe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgckficfjg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgddgdckdd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgefcgggfi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgfefhihji_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acggehdijfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acggfcbekbj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acggkbfbjck_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acghdchgjgf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achbffjechg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achbhefgeeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achbhhddbh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achcbdhidik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achdjgjdgkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achfcefeheb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achgedhdigf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achgegcdkcj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achicekidek_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achiggdccdc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achjkedegdi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achjkicgkif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aciddedkjj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acidekciged_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acidjkkbgbk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acifkidfebh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acigkbdedfb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acihcehbbb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acihehkdfeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acihkdjfdkb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aciibbeciec_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acikghjjgki_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acikhjeehkg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjbgiffidc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjdegcccg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjigbfeikj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjkcgkfjff_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackbhgekeci_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackchfegcjc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackdkfeghk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackebkbdbjj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackffdikde_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackgdbibjbd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackifjdcjjd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackjbcfijee_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackkecjdkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbbickeikd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbfkibeiid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbfkjhfcjd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbgiccjej_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbhchjbgek_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbijghdjjj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjcebiefe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjdjfkiif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjkedbgjg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjkhhkffi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbkdbehhdh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adcbfjighfe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adcdbdebfjg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adcffdijihg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adejkghcfk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adekhbkfjb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adgbkkgkkc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adgcbgkcfb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adjbidcgdh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adkecehjdk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aebfefikfc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aegjbedggh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aeibfebcie_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aejfcffkde_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afcdibbdhk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afdcikchcf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afdgichhbg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afdgigchdc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afejhccjki_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afgfgihgc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afghjhgcgk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afibjfgjj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afiidbjjg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afkbfgfhef_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agcdkcdjfe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agfgchgici_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aggchckijc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agghikgigk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aghhkgkfc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agijkdicg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agjkgikkig_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agkckkkggd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahbgechgbk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahciehbbdc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahiggbegei_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahijjfgjce_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahkcgijbei_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahkijdhjcb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aicgdjfcgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aidbefcifj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aidcegcehg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aiebecdijh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aieefjchbd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aiejbddfde_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aifejkfbkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aifkcjfiic_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aigchgfejj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajcejdgdjc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajchjhccfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajfedjbbig_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajghhigdb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajgkhchijb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajkhbehfkf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akdddhikjj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akdhbfiiid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akfbbffjcg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akgbiefjbh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akhbjjbcei_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akhiekbd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akidjkegkj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akjcidekhd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akjiekjkkh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbbeifjkdj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbffeddche_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbggkebbfk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbhkgfiiif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbjidfdhfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbkcbhjiek_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbkfhfcjb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccbfibgeci_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cccffebffc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cccggcfdkg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccekgicgfh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccfhfbhikj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccgjgbjcgi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cchfdhghjd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cddckigibk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdedfgfkdj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdfdcchhe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdfibdbkfb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdfjfbikid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdgbkkidfd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdgibkchih_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdidfjjidb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdjkcdjcgc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cebdekghcc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceceehkkdb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cechbcjbje_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cechggbfcg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cechibbibc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cedekbhedh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceecjebgfd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceffhbdbf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cegbicbcfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cegkcgkkgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceiggdddik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cejhdeejck_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cekhfceefg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfbedkikg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfbjdedjcj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfbjghgjgf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfcfjiceg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfcjbdhdik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfcjgefdjg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfedcgehh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfffedbhfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfiggjfcfh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfjbbdjcdi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfkdeghg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgbbhfbgbj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgbeibighh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgdieefdkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cghhdebggi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgighkjefc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgjchkijib_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chdckkkgkg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chedkdbce_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chhcdcgigb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chibdbkfde_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chibgkeeji_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chiceijbgj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chiffhjbee_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chiiihhffh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cichefikeb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cicjgdikig_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cifbcfjkdj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cigfkckdgc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cijeifhgec_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cijijgbkgk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjbcjhhgke_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjbjeehdbk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjdkihjijd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjfdcbgfgj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjgbfhfgef_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjhkjfhhf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjicjgdfff_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjjdbgbddi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjjdkdfkkh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjjjckihek_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ckbiikefid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ckeiejdgib_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ckkddehif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbbbcebccf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbedicfecc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbfehhjdb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbibcdhcc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbjjcgeeki_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcbffdidkk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcbkfgcjid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcdjbbkec_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcebfkhcgc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcecciefge_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcehkgkifb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcfehdgdkj_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ddffjifbf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ddikijcge_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_debdghice_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dfcjdjkjk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dfjibkhbh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dihkeehk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_djigibich_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ebgkehdgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ecgibfdjb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_edfkjgfch_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ehkcekjii_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_eidhfehik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_eiehjkdd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ejjgbkdff_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ejkdcifhg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fbejgkdib_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fdjggbfcb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fdkkidgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fekcijijf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fgcbdbbid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fgfckhdf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fhcdfebdc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fhjkfjice_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fihfdkijh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fjkikekhi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fkbkbchgb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fkedkejgf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fkfbciibe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gbchjfieb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gbibihicb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_geijfbdhc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gfgdjegbe_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gihjfdefi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gjgidfgeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hbeefgbjc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hcehhjdfk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hekdkcdeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hfjfeiijk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hhbehfckd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hhkbgdice_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hikdcfgkb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hkdbgkgik_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ibbddjcfb_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ichfccfhh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_idchgghie_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iddeebfkg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iddhiekfi_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_idjfhgckc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ihbgcbhic_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iicekghif_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iifbheddf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ikejdbedk_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jcdhbjde_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jceehdeeh_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jchhdjhkg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jgcekgbii_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jigekbbhd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jjjcegjeg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jkekeckbf_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kbcfjkedc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kdbikhddc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kddgijibc_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kdhdheib_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kfbbiddfg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kfkchgjdd_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kiighbfgg_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kijdhbiid_Private_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunForEntity_Private_Void_Entity_0;
      [FieldOffset(0)]
      public NativeArray<Entity> SnapshotEntities;
      [FieldOffset(16)]
      public ComponentDataFromEntity<NetworkId> GetNetworkId;
      [FieldOffset(48)]
      public ComponentDataFromEntity<NetworkSnapshot> GetNetworkSnapshot;
      [FieldOffset(80)]
      public BufferFromEntity<NetSnapshot> GetNetSnapshot;
      [FieldOffset(120)]
      public WeakRefTracker WeakRefTracker;
      [FieldOffset(176)]
      public SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams Params;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474038, RefRangeEnd = 1474039, XrefRangeStart = 1474022, XrefRangeEnd = 1474038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acbbdiefgbd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbbdiefgbd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474061, RefRangeEnd = 1474062, XrefRangeStart = 1474039, XrefRangeEnd = 1474061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acbbgiidegf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbbgiidegf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474081, RefRangeEnd = 1474082, XrefRangeStart = 1474062, XrefRangeEnd = 1474081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acbdgdebikk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbdgdebikk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474104, RefRangeEnd = 1474105, XrefRangeStart = 1474082, XrefRangeEnd = 1474104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acbfcjichfb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbfcjichfb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474124, RefRangeEnd = 1474125, XrefRangeStart = 1474105, XrefRangeEnd = 1474124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acbhckcfdfd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbhckcfdfd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474144, RefRangeEnd = 1474145, XrefRangeStart = 1474125, XrefRangeEnd = 1474144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acbhkjccgdi(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbhkjccgdi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474173, RefRangeEnd = 1474174, XrefRangeStart = 1474145, XrefRangeEnd = 1474173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acbicfeedbb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbicfeedbb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474198, RefRangeEnd = 1474199, XrefRangeStart = 1474174, XrefRangeEnd = 1474198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acbiddcjjid(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbiddcjjid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474227, RefRangeEnd = 1474228, XrefRangeStart = 1474199, XrefRangeEnd = 1474227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acccfjkdigh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acccfjkdigh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474244, RefRangeEnd = 1474245, XrefRangeStart = 1474228, XrefRangeEnd = 1474244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acccgefcedb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acccgefcedb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474261, RefRangeEnd = 1474262, XrefRangeStart = 1474245, XrefRangeEnd = 1474261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_accdbefiheb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accdbefiheb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474281, RefRangeEnd = 1474282, XrefRangeStart = 1474262, XrefRangeEnd = 1474281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_accdjiedgfe(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accdjiedgfe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474306, RefRangeEnd = 1474307, XrefRangeStart = 1474282, XrefRangeEnd = 1474306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_accgciikfbf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accgciikfbf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474327, RefRangeEnd = 1474328, XrefRangeStart = 1474307, XrefRangeEnd = 1474327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_accgiggcif(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accgiggcif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474354, RefRangeEnd = 1474355, XrefRangeStart = 1474328, XrefRangeEnd = 1474354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acchhgcjcbh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acchhgcjcbh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474375, RefRangeEnd = 1474376, XrefRangeStart = 1474355, XrefRangeEnd = 1474375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acchibekekj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acchibekekj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474395, RefRangeEnd = 1474396, XrefRangeStart = 1474376, XrefRangeEnd = 1474395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acciegkehkf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acciegkehkf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474416, RefRangeEnd = 1474417, XrefRangeStart = 1474396, XrefRangeEnd = 1474416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acdccjhicfg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdccjhicfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474445, RefRangeEnd = 1474446, XrefRangeStart = 1474417, XrefRangeEnd = 1474445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acdehhkijdj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdehhkijdj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474465, RefRangeEnd = 1474466, XrefRangeStart = 1474446, XrefRangeEnd = 1474465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acdfgkkfchc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdfgkkfchc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474482, RefRangeEnd = 1474483, XrefRangeStart = 1474466, XrefRangeEnd = 1474482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acdficciidc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdficciidc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474499, RefRangeEnd = 1474500, XrefRangeStart = 1474483, XrefRangeEnd = 1474499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acdibbekbkk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdibbekbkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474528, RefRangeEnd = 1474529, XrefRangeStart = 1474500, XrefRangeEnd = 1474528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acdidhjbjgj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdidhjbjgj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474553, RefRangeEnd = 1474554, XrefRangeStart = 1474529, XrefRangeEnd = 1474553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acdjdjkckhd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdjdjkckhd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474574, RefRangeEnd = 1474575, XrefRangeStart = 1474554, XrefRangeEnd = 1474574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acdjighgcci(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdjighgcci_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474595, RefRangeEnd = 1474596, XrefRangeStart = 1474575, XrefRangeEnd = 1474595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acdkgjbefjd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdkgjbefjd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474612, RefRangeEnd = 1474613, XrefRangeStart = 1474596, XrefRangeEnd = 1474612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acdkkhcbdcg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdkkhcbdcg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474635, RefRangeEnd = 1474636, XrefRangeStart = 1474613, XrefRangeEnd = 1474635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acecggedbff(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acecggedbff_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474658, RefRangeEnd = 1474659, XrefRangeStart = 1474636, XrefRangeEnd = 1474658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aceegbjekgb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aceegbjekgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474681, RefRangeEnd = 1474682, XrefRangeStart = 1474659, XrefRangeEnd = 1474681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aceehcgeedj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aceehcgeedj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474704, RefRangeEnd = 1474705, XrefRangeStart = 1474682, XrefRangeEnd = 1474704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acegbdcgkdf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acegbdcgkdf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474721, RefRangeEnd = 1474722, XrefRangeStart = 1474705, XrefRangeEnd = 1474721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aceihfcgifd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aceihfcgifd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474742, RefRangeEnd = 1474743, XrefRangeStart = 1474722, XrefRangeEnd = 1474742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acekdgegehc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acekdgegehc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474765, RefRangeEnd = 1474766, XrefRangeStart = 1474743, XrefRangeEnd = 1474765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acekjgheehk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acekjgheehk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474794, RefRangeEnd = 1474795, XrefRangeStart = 1474766, XrefRangeEnd = 1474794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acfckgbfifj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfckgbfifj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474823, RefRangeEnd = 1474824, XrefRangeStart = 1474795, XrefRangeEnd = 1474823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acfebiceeh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfebiceeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474850, RefRangeEnd = 1474851, XrefRangeStart = 1474824, XrefRangeEnd = 1474850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acfhdekidie(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfhdekidie_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474871, RefRangeEnd = 1474872, XrefRangeStart = 1474851, XrefRangeEnd = 1474871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acfikjcfik(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfikjcfik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474894, RefRangeEnd = 1474895, XrefRangeStart = 1474872, XrefRangeEnd = 1474894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acgbiiekebj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgbiiekebj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474919, RefRangeEnd = 1474920, XrefRangeStart = 1474895, XrefRangeEnd = 1474919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acgchdfhdbe(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgchdfhdbe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474942, RefRangeEnd = 1474943, XrefRangeStart = 1474920, XrefRangeEnd = 1474942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acgckficfjg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgckficfjg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474965, RefRangeEnd = 1474966, XrefRangeStart = 1474943, XrefRangeEnd = 1474965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acgddgdckdd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgddgdckdd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1474985, RefRangeEnd = 1474986, XrefRangeStart = 1474966, XrefRangeEnd = 1474985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acgefcgggfi(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgefcgggfi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475008, RefRangeEnd = 1475009, XrefRangeStart = 1474986, XrefRangeEnd = 1475008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acgfefhihji(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgfefhihji_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475033, RefRangeEnd = 1475034, XrefRangeStart = 1475009, XrefRangeEnd = 1475033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acggehdijfg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acggehdijfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475054, RefRangeEnd = 1475055, XrefRangeStart = 1475034, XrefRangeEnd = 1475054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acggfcbekbj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acggfcbekbj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475077, RefRangeEnd = 1475078, XrefRangeStart = 1475055, XrefRangeEnd = 1475077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acggkbfbjck(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acggkbfbjck_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475097, RefRangeEnd = 1475098, XrefRangeStart = 1475078, XrefRangeEnd = 1475097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acghdchgjgf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acghdchgjgf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475114, RefRangeEnd = 1475115, XrefRangeStart = 1475098, XrefRangeEnd = 1475114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achbffjechg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achbffjechg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475134, RefRangeEnd = 1475135, XrefRangeStart = 1475115, XrefRangeEnd = 1475134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achbhefgeeh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achbhefgeeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475159, RefRangeEnd = 1475160, XrefRangeStart = 1475135, XrefRangeEnd = 1475159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achbhhddbh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achbhhddbh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475182, RefRangeEnd = 1475183, XrefRangeStart = 1475160, XrefRangeEnd = 1475182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achcbdhidik(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achcbdhidik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475203, RefRangeEnd = 1475204, XrefRangeStart = 1475183, XrefRangeEnd = 1475203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achdjgjdgkk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achdjgjdgkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475226, RefRangeEnd = 1475227, XrefRangeStart = 1475204, XrefRangeEnd = 1475226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achfcefeheb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achfcefeheb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475247, RefRangeEnd = 1475248, XrefRangeStart = 1475227, XrefRangeEnd = 1475247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achgedhdigf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achgedhdigf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475270, RefRangeEnd = 1475271, XrefRangeStart = 1475248, XrefRangeEnd = 1475270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achgegcdkcj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achgegcdkcj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475290, RefRangeEnd = 1475291, XrefRangeStart = 1475271, XrefRangeEnd = 1475290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achicekidek(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achicekidek_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475311, RefRangeEnd = 1475312, XrefRangeStart = 1475291, XrefRangeEnd = 1475311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achiggdccdc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achiggdccdc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475332, RefRangeEnd = 1475333, XrefRangeStart = 1475312, XrefRangeEnd = 1475332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achjkedegdi(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achjkedegdi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475355, RefRangeEnd = 1475356, XrefRangeStart = 1475333, XrefRangeEnd = 1475355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_achjkicgkif(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achjkicgkif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475376, RefRangeEnd = 1475377, XrefRangeStart = 1475356, XrefRangeEnd = 1475376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aciddedkjj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aciddedkjj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475399, RefRangeEnd = 1475400, XrefRangeStart = 1475377, XrefRangeEnd = 1475399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acidekciged(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acidekciged_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475420, RefRangeEnd = 1475421, XrefRangeStart = 1475400, XrefRangeEnd = 1475420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acidjkkbgbk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acidjkkbgbk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475445, RefRangeEnd = 1475446, XrefRangeStart = 1475421, XrefRangeEnd = 1475445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acifkidfebh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acifkidfebh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475462, RefRangeEnd = 1475463, XrefRangeStart = 1475446, XrefRangeEnd = 1475462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acigkbdedfb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acigkbdedfb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475485, RefRangeEnd = 1475486, XrefRangeStart = 1475463, XrefRangeEnd = 1475485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acihcehbbb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acihcehbbb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475502, RefRangeEnd = 1475503, XrefRangeStart = 1475486, XrefRangeEnd = 1475502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acihehkdfeh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acihehkdfeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475523, RefRangeEnd = 1475524, XrefRangeStart = 1475503, XrefRangeEnd = 1475523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acihkdjfdkb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acihkdjfdkb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475544, RefRangeEnd = 1475545, XrefRangeStart = 1475524, XrefRangeEnd = 1475544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aciibbeciec(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aciibbeciec_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475565, RefRangeEnd = 1475566, XrefRangeStart = 1475545, XrefRangeEnd = 1475565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acikghjjgki(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acikghjjgki_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475588, RefRangeEnd = 1475589, XrefRangeStart = 1475566, XrefRangeEnd = 1475588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acikhjeehkg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acikhjeehkg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475605, RefRangeEnd = 1475606, XrefRangeStart = 1475589, XrefRangeEnd = 1475605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acjbgiffidc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjbgiffidc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475631, RefRangeEnd = 1475632, XrefRangeStart = 1475606, XrefRangeEnd = 1475631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acjdegcccg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjdegcccg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475652, RefRangeEnd = 1475653, XrefRangeStart = 1475632, XrefRangeEnd = 1475652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acjigbfeikj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjigbfeikj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475681, RefRangeEnd = 1475682, XrefRangeStart = 1475653, XrefRangeEnd = 1475681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_acjkcgkfjff(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjkcgkfjff_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475702, RefRangeEnd = 1475703, XrefRangeStart = 1475682, XrefRangeEnd = 1475702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ackbhgekeci(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackbhgekeci_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475723, RefRangeEnd = 1475724, XrefRangeStart = 1475703, XrefRangeEnd = 1475723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ackchfegcjc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackchfegcjc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475746, RefRangeEnd = 1475747, XrefRangeStart = 1475724, XrefRangeEnd = 1475746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ackdkfeghk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackdkfeghk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475769, RefRangeEnd = 1475770, XrefRangeStart = 1475747, XrefRangeEnd = 1475769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ackebkbdbjj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackebkbdbjj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475794, RefRangeEnd = 1475795, XrefRangeStart = 1475770, XrefRangeEnd = 1475794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ackffdikde(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackffdikde_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475811, RefRangeEnd = 1475812, XrefRangeStart = 1475795, XrefRangeEnd = 1475811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ackgdbibjbd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackgdbibjbd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475832, RefRangeEnd = 1475833, XrefRangeStart = 1475812, XrefRangeEnd = 1475832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ackifjdcjjd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackifjdcjjd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475855, RefRangeEnd = 1475856, XrefRangeStart = 1475833, XrefRangeEnd = 1475855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ackjbcfijee(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackjbcfijee_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475880, RefRangeEnd = 1475881, XrefRangeStart = 1475856, XrefRangeEnd = 1475880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ackkecjdkk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackkecjdkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475901, RefRangeEnd = 1475902, XrefRangeStart = 1475881, XrefRangeEnd = 1475901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adbbickeikd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbbickeikd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475922, RefRangeEnd = 1475923, XrefRangeStart = 1475902, XrefRangeEnd = 1475922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adbfkibeiid(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbfkibeiid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475943, RefRangeEnd = 1475944, XrefRangeStart = 1475923, XrefRangeEnd = 1475943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adbfkjhfcjd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbfkjhfcjd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475966, RefRangeEnd = 1475967, XrefRangeStart = 1475944, XrefRangeEnd = 1475966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adbgiccjej(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbgiccjej_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1475987, RefRangeEnd = 1475988, XrefRangeStart = 1475967, XrefRangeEnd = 1475987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adbhchjbgek(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbhchjbgek_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476014, RefRangeEnd = 1476015, XrefRangeStart = 1475988, XrefRangeEnd = 1476014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adbijghdjjj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbijghdjjj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476035, RefRangeEnd = 1476036, XrefRangeStart = 1476015, XrefRangeEnd = 1476035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adbjcebiefe(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjcebiefe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476064, RefRangeEnd = 1476065, XrefRangeStart = 1476036, XrefRangeEnd = 1476064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adbjdjfkiif(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjdjfkiif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476081, RefRangeEnd = 1476082, XrefRangeStart = 1476065, XrefRangeEnd = 1476081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adbjkedbgjg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjkedbgjg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476098, RefRangeEnd = 1476099, XrefRangeStart = 1476082, XrefRangeEnd = 1476098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adbjkhhkffi(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjkhhkffi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476119, RefRangeEnd = 1476120, XrefRangeStart = 1476099, XrefRangeEnd = 1476119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adbkdbehhdh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbkdbehhdh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476136, RefRangeEnd = 1476137, XrefRangeStart = 1476120, XrefRangeEnd = 1476136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adcbfjighfe(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adcbfjighfe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476159, RefRangeEnd = 1476160, XrefRangeStart = 1476137, XrefRangeEnd = 1476159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adcdbdebfjg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adcdbdebfjg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476176, RefRangeEnd = 1476177, XrefRangeStart = 1476160, XrefRangeEnd = 1476176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adcffdijihg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adcffdijihg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476193, RefRangeEnd = 1476194, XrefRangeStart = 1476177, XrefRangeEnd = 1476193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adejkghcfk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adejkghcfk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476214, RefRangeEnd = 1476215, XrefRangeStart = 1476194, XrefRangeEnd = 1476214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adekhbkfjb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adekhbkfjb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476235, RefRangeEnd = 1476236, XrefRangeStart = 1476215, XrefRangeEnd = 1476235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adgbkkgkkc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adgbkkgkkc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476260, RefRangeEnd = 1476261, XrefRangeStart = 1476236, XrefRangeEnd = 1476260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adgcbgkcfb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adgcbgkcfb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476277, RefRangeEnd = 1476278, XrefRangeStart = 1476261, XrefRangeEnd = 1476277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adjbidcgdh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adjbidcgdh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476300, RefRangeEnd = 1476301, XrefRangeStart = 1476278, XrefRangeEnd = 1476300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_adkecehjdk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adkecehjdk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476323, RefRangeEnd = 1476324, XrefRangeStart = 1476301, XrefRangeEnd = 1476323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aebfefikfc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aebfefikfc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476346, RefRangeEnd = 1476347, XrefRangeStart = 1476324, XrefRangeEnd = 1476346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aegjbedggh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aegjbedggh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476367, RefRangeEnd = 1476368, XrefRangeStart = 1476347, XrefRangeEnd = 1476367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aeibfebcie(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aeibfebcie_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476388, RefRangeEnd = 1476389, XrefRangeStart = 1476368, XrefRangeEnd = 1476388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aejfcffkde(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aejfcffkde_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476409, RefRangeEnd = 1476410, XrefRangeStart = 1476389, XrefRangeEnd = 1476409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_afcdibbdhk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afcdibbdhk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476438, RefRangeEnd = 1476439, XrefRangeStart = 1476410, XrefRangeEnd = 1476438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_afdcikchcf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afdcikchcf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476461, RefRangeEnd = 1476462, XrefRangeStart = 1476439, XrefRangeEnd = 1476461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_afdgichhbg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afdgichhbg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476484, RefRangeEnd = 1476485, XrefRangeStart = 1476462, XrefRangeEnd = 1476484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_afdgigchdc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afdgigchdc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476501, RefRangeEnd = 1476502, XrefRangeStart = 1476485, XrefRangeEnd = 1476501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_afejhccjki(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afejhccjki_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476524, RefRangeEnd = 1476525, XrefRangeStart = 1476502, XrefRangeEnd = 1476524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_afgfgihgc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afgfgihgc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476541, RefRangeEnd = 1476542, XrefRangeStart = 1476525, XrefRangeEnd = 1476541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_afghjhgcgk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afghjhgcgk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476561, RefRangeEnd = 1476562, XrefRangeStart = 1476542, XrefRangeEnd = 1476561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_afibjfgjj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afibjfgjj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476590, RefRangeEnd = 1476591, XrefRangeStart = 1476562, XrefRangeEnd = 1476590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_afiidbjjg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afiidbjjg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476613, RefRangeEnd = 1476614, XrefRangeStart = 1476591, XrefRangeEnd = 1476613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_afkbfgfhef(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afkbfgfhef_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476642, RefRangeEnd = 1476643, XrefRangeStart = 1476614, XrefRangeEnd = 1476642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_agcdkcdjfe(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agcdkcdjfe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476663, RefRangeEnd = 1476664, XrefRangeStart = 1476643, XrefRangeEnd = 1476663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_agfgchgici(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agfgchgici_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476680, RefRangeEnd = 1476681, XrefRangeStart = 1476664, XrefRangeEnd = 1476680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aggchckijc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aggchckijc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476697, RefRangeEnd = 1476698, XrefRangeStart = 1476681, XrefRangeEnd = 1476697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_agghikgigk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agghikgigk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476720, RefRangeEnd = 1476721, XrefRangeStart = 1476698, XrefRangeEnd = 1476720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aghhkgkfc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aghhkgkfc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476747, RefRangeEnd = 1476748, XrefRangeStart = 1476721, XrefRangeEnd = 1476747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_agijkdicg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agijkdicg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476764, RefRangeEnd = 1476765, XrefRangeStart = 1476748, XrefRangeEnd = 1476764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_agjkgikkig(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agjkgikkig_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476781, RefRangeEnd = 1476782, XrefRangeStart = 1476765, XrefRangeEnd = 1476781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_agkckkkggd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agkckkkggd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476804, RefRangeEnd = 1476805, XrefRangeStart = 1476782, XrefRangeEnd = 1476804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ahbgechgbk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahbgechgbk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476829, RefRangeEnd = 1476830, XrefRangeStart = 1476805, XrefRangeEnd = 1476829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ahciehbbdc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahciehbbdc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476846, RefRangeEnd = 1476847, XrefRangeStart = 1476830, XrefRangeEnd = 1476846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ahiggbegei(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahiggbegei_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476869, RefRangeEnd = 1476870, XrefRangeStart = 1476847, XrefRangeEnd = 1476869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ahijjfgjce(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahijjfgjce_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476890, RefRangeEnd = 1476891, XrefRangeStart = 1476870, XrefRangeEnd = 1476890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ahkcgijbei(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahkcgijbei_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476913, RefRangeEnd = 1476914, XrefRangeStart = 1476891, XrefRangeEnd = 1476913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ahkijdhjcb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahkijdhjcb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476936, RefRangeEnd = 1476937, XrefRangeStart = 1476914, XrefRangeEnd = 1476936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aicgdjfcgb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aicgdjfcgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476965, RefRangeEnd = 1476966, XrefRangeStart = 1476937, XrefRangeEnd = 1476965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aidbefcifj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aidbefcifj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1476988, RefRangeEnd = 1476989, XrefRangeStart = 1476966, XrefRangeEnd = 1476988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aidcegcehg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aidcegcehg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477011, RefRangeEnd = 1477012, XrefRangeStart = 1476989, XrefRangeEnd = 1477011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aiebecdijh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aiebecdijh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477040, RefRangeEnd = 1477041, XrefRangeStart = 1477012, XrefRangeEnd = 1477040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aieefjchbd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aieefjchbd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477060, RefRangeEnd = 1477061, XrefRangeStart = 1477041, XrefRangeEnd = 1477060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aiejbddfde(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aiejbddfde_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477080, RefRangeEnd = 1477081, XrefRangeStart = 1477061, XrefRangeEnd = 1477080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aifejkfbkk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aifejkfbkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477103, RefRangeEnd = 1477104, XrefRangeStart = 1477081, XrefRangeEnd = 1477103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aifkcjfiic(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aifkcjfiic_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477120, RefRangeEnd = 1477121, XrefRangeStart = 1477104, XrefRangeEnd = 1477120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_aigchgfejj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aigchgfejj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477143, RefRangeEnd = 1477144, XrefRangeStart = 1477121, XrefRangeEnd = 1477143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ajcejdgdjc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajcejdgdjc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477166, RefRangeEnd = 1477167, XrefRangeStart = 1477144, XrefRangeEnd = 1477166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ajchjhccfg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajchjhccfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477183, RefRangeEnd = 1477184, XrefRangeStart = 1477167, XrefRangeEnd = 1477183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ajfedjbbig(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajfedjbbig_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477204, RefRangeEnd = 1477205, XrefRangeStart = 1477184, XrefRangeEnd = 1477204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ajghhigdb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajghhigdb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477225, RefRangeEnd = 1477226, XrefRangeStart = 1477205, XrefRangeEnd = 1477225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ajgkhchijb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajgkhchijb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477246, RefRangeEnd = 1477247, XrefRangeStart = 1477226, XrefRangeEnd = 1477246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ajkhbehfkf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajkhbehfkf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477269, RefRangeEnd = 1477270, XrefRangeStart = 1477247, XrefRangeEnd = 1477269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_akdddhikjj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akdddhikjj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477292, RefRangeEnd = 1477293, XrefRangeStart = 1477270, XrefRangeEnd = 1477292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_akdhbfiiid(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akdhbfiiid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477313, RefRangeEnd = 1477314, XrefRangeStart = 1477293, XrefRangeEnd = 1477313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_akfbbffjcg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akfbbffjcg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477334, RefRangeEnd = 1477335, XrefRangeStart = 1477314, XrefRangeEnd = 1477334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_akgbiefjbh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akgbiefjbh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477351, RefRangeEnd = 1477352, XrefRangeStart = 1477335, XrefRangeEnd = 1477351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_akhbjjbcei(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akhbjjbcei_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477372, RefRangeEnd = 1477373, XrefRangeStart = 1477352, XrefRangeEnd = 1477372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_akhiekbd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akhiekbd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477393, RefRangeEnd = 1477394, XrefRangeStart = 1477373, XrefRangeEnd = 1477393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_akidjkegkj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akidjkegkj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477422, RefRangeEnd = 1477423, XrefRangeStart = 1477394, XrefRangeEnd = 1477422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_akjcidekhd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akjcidekhd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477443, RefRangeEnd = 1477444, XrefRangeStart = 1477423, XrefRangeEnd = 1477443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_akjiekjkkh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akjiekjkkh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477464, RefRangeEnd = 1477465, XrefRangeStart = 1477444, XrefRangeEnd = 1477464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cbbeifjkdj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbbeifjkdj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477485, RefRangeEnd = 1477486, XrefRangeStart = 1477465, XrefRangeEnd = 1477485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cbffeddche(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbffeddche_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477508, RefRangeEnd = 1477509, XrefRangeStart = 1477486, XrefRangeEnd = 1477508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cbggkebbfk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbggkebbfk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477525, RefRangeEnd = 1477526, XrefRangeStart = 1477509, XrefRangeEnd = 1477525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cbhkgfiiif(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbhkgfiiif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477542, RefRangeEnd = 1477543, XrefRangeStart = 1477526, XrefRangeEnd = 1477542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cbjidfdhfg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbjidfdhfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477559, RefRangeEnd = 1477560, XrefRangeStart = 1477543, XrefRangeEnd = 1477559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cbkcbhjiek(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbkcbhjiek_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477580, RefRangeEnd = 1477581, XrefRangeStart = 1477560, XrefRangeEnd = 1477580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cbkfhfcjb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbkfhfcjb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477601, RefRangeEnd = 1477602, XrefRangeStart = 1477581, XrefRangeEnd = 1477601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ccbfibgeci(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccbfibgeci_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477624, RefRangeEnd = 1477625, XrefRangeStart = 1477602, XrefRangeEnd = 1477624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cccffebffc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cccffebffc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477645, RefRangeEnd = 1477646, XrefRangeStart = 1477625, XrefRangeEnd = 1477645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cccggcfdkg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cccggcfdkg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477674, RefRangeEnd = 1477675, XrefRangeStart = 1477646, XrefRangeEnd = 1477674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ccekgicgfh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccekgicgfh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477695, RefRangeEnd = 1477696, XrefRangeStart = 1477675, XrefRangeEnd = 1477695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ccfhfbhikj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccfhfbhikj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477718, RefRangeEnd = 1477719, XrefRangeStart = 1477696, XrefRangeEnd = 1477718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ccgjgbjcgi(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccgjgbjcgi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477738, RefRangeEnd = 1477739, XrefRangeStart = 1477719, XrefRangeEnd = 1477738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cchfdhghjd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cchfdhghjd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477761, RefRangeEnd = 1477762, XrefRangeStart = 1477739, XrefRangeEnd = 1477761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cddckigibk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cddckigibk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477784, RefRangeEnd = 1477785, XrefRangeStart = 1477762, XrefRangeEnd = 1477784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cdedfgfkdj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdedfgfkdj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477813, RefRangeEnd = 1477814, XrefRangeStart = 1477785, XrefRangeEnd = 1477813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cdfdcchhe(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdfdcchhe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477830, RefRangeEnd = 1477831, XrefRangeStart = 1477814, XrefRangeEnd = 1477830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cdfibdbkfb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdfibdbkfb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477850, RefRangeEnd = 1477851, XrefRangeStart = 1477831, XrefRangeEnd = 1477850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cdfjfbikid(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdfjfbikid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477873, RefRangeEnd = 1477874, XrefRangeStart = 1477851, XrefRangeEnd = 1477873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cdgbkkidfd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdgbkkidfd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477896, RefRangeEnd = 1477897, XrefRangeStart = 1477874, XrefRangeEnd = 1477896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cdgibkchih(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdgibkchih_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477919, RefRangeEnd = 1477920, XrefRangeStart = 1477897, XrefRangeEnd = 1477919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cdidfjjidb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdidfjjidb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477940, RefRangeEnd = 1477941, XrefRangeStart = 1477920, XrefRangeEnd = 1477940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cdjkcdjcgc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdjkcdjcgc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477963, RefRangeEnd = 1477964, XrefRangeStart = 1477941, XrefRangeEnd = 1477963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cebdekghcc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cebdekghcc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1477992, RefRangeEnd = 1477993, XrefRangeStart = 1477964, XrefRangeEnd = 1477992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ceceehkkdb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceceehkkdb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478015, RefRangeEnd = 1478016, XrefRangeStart = 1477993, XrefRangeEnd = 1478015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cechbcjbje(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cechbcjbje_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478036, RefRangeEnd = 1478037, XrefRangeStart = 1478016, XrefRangeEnd = 1478036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cechggbfcg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cechggbfcg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478053, RefRangeEnd = 1478054, XrefRangeStart = 1478037, XrefRangeEnd = 1478053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cechibbibc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cechibbibc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478082, RefRangeEnd = 1478083, XrefRangeStart = 1478054, XrefRangeEnd = 1478082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cedekbhedh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cedekbhedh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478105, RefRangeEnd = 1478106, XrefRangeStart = 1478083, XrefRangeEnd = 1478105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ceecjebgfd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceecjebgfd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478122, RefRangeEnd = 1478123, XrefRangeStart = 1478106, XrefRangeEnd = 1478122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ceffhbdbf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceffhbdbf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478139, RefRangeEnd = 1478140, XrefRangeStart = 1478123, XrefRangeEnd = 1478139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cegbicbcfg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cegbicbcfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478156, RefRangeEnd = 1478157, XrefRangeStart = 1478140, XrefRangeEnd = 1478156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cegkcgkkgb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cegkcgkkgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478181, RefRangeEnd = 1478182, XrefRangeStart = 1478157, XrefRangeEnd = 1478181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ceiggdddik(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceiggdddik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478202, RefRangeEnd = 1478203, XrefRangeStart = 1478182, XrefRangeEnd = 1478202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cejhdeejck(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cejhdeejck_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478231, RefRangeEnd = 1478232, XrefRangeStart = 1478203, XrefRangeEnd = 1478231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cekhfceefg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cekhfceefg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478260, RefRangeEnd = 1478261, XrefRangeStart = 1478232, XrefRangeEnd = 1478260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cfbedkikg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfbedkikg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478280, RefRangeEnd = 1478281, XrefRangeStart = 1478261, XrefRangeEnd = 1478280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cfbjdedjcj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfbjdedjcj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478303, RefRangeEnd = 1478304, XrefRangeStart = 1478281, XrefRangeEnd = 1478303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cfbjghgjgf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfbjghgjgf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478330, RefRangeEnd = 1478331, XrefRangeStart = 1478304, XrefRangeEnd = 1478330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cfcfjiceg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfcfjiceg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478347, RefRangeEnd = 1478348, XrefRangeStart = 1478331, XrefRangeEnd = 1478347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cfcjbdhdik(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfcjbdhdik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478364, RefRangeEnd = 1478365, XrefRangeStart = 1478348, XrefRangeEnd = 1478364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cfcjgefdjg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfcjgefdjg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478387, RefRangeEnd = 1478388, XrefRangeStart = 1478365, XrefRangeEnd = 1478387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cfedcgehh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfedcgehh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478410, RefRangeEnd = 1478411, XrefRangeStart = 1478388, XrefRangeEnd = 1478410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cfffedbhfg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfffedbhfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478433, RefRangeEnd = 1478434, XrefRangeStart = 1478411, XrefRangeEnd = 1478433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cfiggjfcfh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfiggjfcfh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478453, RefRangeEnd = 1478454, XrefRangeStart = 1478434, XrefRangeEnd = 1478453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cfjbbdjcdi(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfjbbdjcdi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478474, RefRangeEnd = 1478475, XrefRangeStart = 1478454, XrefRangeEnd = 1478474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cfkdeghg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfkdeghg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478495, RefRangeEnd = 1478496, XrefRangeStart = 1478475, XrefRangeEnd = 1478495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cgbbhfbgbj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgbbhfbgbj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478522, RefRangeEnd = 1478523, XrefRangeStart = 1478496, XrefRangeEnd = 1478522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cgbeibighh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgbeibighh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478543, RefRangeEnd = 1478544, XrefRangeStart = 1478523, XrefRangeEnd = 1478543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cgdieefdkk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgdieefdkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478564, RefRangeEnd = 1478565, XrefRangeStart = 1478544, XrefRangeEnd = 1478564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cghhdebggi(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cghhdebggi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478593, RefRangeEnd = 1478594, XrefRangeStart = 1478565, XrefRangeEnd = 1478593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cgighkjefc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgighkjefc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478610, RefRangeEnd = 1478611, XrefRangeStart = 1478594, XrefRangeEnd = 1478610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cgjchkijib(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgjchkijib_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478631, RefRangeEnd = 1478632, XrefRangeStart = 1478611, XrefRangeEnd = 1478631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_chdckkkgkg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chdckkkgkg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478651, RefRangeEnd = 1478652, XrefRangeStart = 1478632, XrefRangeEnd = 1478651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_chedkdbce(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chedkdbce_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478671, RefRangeEnd = 1478672, XrefRangeStart = 1478652, XrefRangeEnd = 1478671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_chhcdcgigb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chhcdcgigb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478691, RefRangeEnd = 1478692, XrefRangeStart = 1478672, XrefRangeEnd = 1478691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_chibdbkfde(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chibdbkfde_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478712, RefRangeEnd = 1478713, XrefRangeStart = 1478692, XrefRangeEnd = 1478712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_chibgkeeji(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chibgkeeji_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478741, RefRangeEnd = 1478742, XrefRangeStart = 1478713, XrefRangeEnd = 1478741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_chiceijbgj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chiceijbgj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478762, RefRangeEnd = 1478763, XrefRangeStart = 1478742, XrefRangeEnd = 1478762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_chiffhjbee(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chiffhjbee_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478785, RefRangeEnd = 1478786, XrefRangeStart = 1478763, XrefRangeEnd = 1478785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_chiiihhffh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chiiihhffh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478805, RefRangeEnd = 1478806, XrefRangeStart = 1478786, XrefRangeEnd = 1478805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cichefikeb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cichefikeb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478826, RefRangeEnd = 1478827, XrefRangeStart = 1478806, XrefRangeEnd = 1478826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cicjgdikig(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cicjgdikig_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478846, RefRangeEnd = 1478847, XrefRangeStart = 1478827, XrefRangeEnd = 1478846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cifbcfjkdj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cifbcfjkdj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478866, RefRangeEnd = 1478867, XrefRangeStart = 1478847, XrefRangeEnd = 1478866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cigfkckdgc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cigfkckdgc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478889, RefRangeEnd = 1478890, XrefRangeStart = 1478867, XrefRangeEnd = 1478889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cijeifhgec(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cijeifhgec_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478915, RefRangeEnd = 1478916, XrefRangeStart = 1478890, XrefRangeEnd = 1478915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cijijgbkgk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cijijgbkgk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478936, RefRangeEnd = 1478937, XrefRangeStart = 1478916, XrefRangeEnd = 1478936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cjbcjhhgke(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjbcjhhgke_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478953, RefRangeEnd = 1478954, XrefRangeStart = 1478937, XrefRangeEnd = 1478953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cjbjeehdbk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjbjeehdbk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478970, RefRangeEnd = 1478971, XrefRangeStart = 1478954, XrefRangeEnd = 1478970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cjdkihjijd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjdkihjijd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1478991, RefRangeEnd = 1478992, XrefRangeStart = 1478971, XrefRangeEnd = 1478991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cjfdcbgfgj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjfdcbgfgj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479014, RefRangeEnd = 1479015, XrefRangeStart = 1478992, XrefRangeEnd = 1479014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cjgbfhfgef(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjgbfhfgef_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479039, RefRangeEnd = 1479040, XrefRangeStart = 1479015, XrefRangeEnd = 1479039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cjhkjfhhf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjhkjfhhf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479059, RefRangeEnd = 1479060, XrefRangeStart = 1479040, XrefRangeEnd = 1479059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cjicjgdfff(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjicjgdfff_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479080, RefRangeEnd = 1479081, XrefRangeStart = 1479060, XrefRangeEnd = 1479080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cjjdbgbddi(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjjdbgbddi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479105, RefRangeEnd = 1479106, XrefRangeStart = 1479081, XrefRangeEnd = 1479105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cjjdkdfkkh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjjdkdfkkh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479126, RefRangeEnd = 1479127, XrefRangeStart = 1479106, XrefRangeEnd = 1479126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_cjjjckihek(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjjjckihek_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479155, RefRangeEnd = 1479156, XrefRangeStart = 1479127, XrefRangeEnd = 1479155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ckbiikefid(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ckbiikefid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479178, RefRangeEnd = 1479179, XrefRangeStart = 1479156, XrefRangeEnd = 1479178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ckeiejdgib(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ckeiejdgib_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479205, RefRangeEnd = 1479206, XrefRangeStart = 1479179, XrefRangeEnd = 1479205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ckkddehif(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ckkddehif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479226, RefRangeEnd = 1479227, XrefRangeStart = 1479206, XrefRangeEnd = 1479226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dbbbcebccf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbbbcebccf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479247, RefRangeEnd = 1479248, XrefRangeStart = 1479227, XrefRangeEnd = 1479247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dbedicfecc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbedicfecc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479270, RefRangeEnd = 1479271, XrefRangeStart = 1479248, XrefRangeEnd = 1479270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dbfehhjdb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbfehhjdb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479291, RefRangeEnd = 1479292, XrefRangeStart = 1479271, XrefRangeEnd = 1479291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dbibcdhcc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbibcdhcc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479314, RefRangeEnd = 1479315, XrefRangeStart = 1479292, XrefRangeEnd = 1479314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dbjjcgeeki(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbjjcgeeki_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479331, RefRangeEnd = 1479332, XrefRangeStart = 1479315, XrefRangeEnd = 1479331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dcbffdidkk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcbffdidkk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479358, RefRangeEnd = 1479359, XrefRangeStart = 1479332, XrefRangeEnd = 1479358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dcbkfgcjid(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcbkfgcjid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479381, RefRangeEnd = 1479382, XrefRangeStart = 1479359, XrefRangeEnd = 1479381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dcdjbbkec(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcdjbbkec_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479402, RefRangeEnd = 1479403, XrefRangeStart = 1479382, XrefRangeEnd = 1479402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dcebfkhcgc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcebfkhcgc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479423, RefRangeEnd = 1479424, XrefRangeStart = 1479403, XrefRangeEnd = 1479423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dcecciefge(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcecciefge_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479444, RefRangeEnd = 1479445, XrefRangeStart = 1479424, XrefRangeEnd = 1479444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dcehkgkifb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcehkgkifb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479467, RefRangeEnd = 1479468, XrefRangeStart = 1479445, XrefRangeEnd = 1479467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dcfehdgdkj(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcfehdgdkj_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479487, RefRangeEnd = 1479488, XrefRangeStart = 1479468, XrefRangeEnd = 1479487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ddffjifbf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ddffjifbf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479508, RefRangeEnd = 1479509, XrefRangeStart = 1479488, XrefRangeEnd = 1479508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ddikijcge(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ddikijcge_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479533, RefRangeEnd = 1479534, XrefRangeStart = 1479509, XrefRangeEnd = 1479533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_debdghice(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_debdghice_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479556, RefRangeEnd = 1479557, XrefRangeStart = 1479534, XrefRangeEnd = 1479556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dfcjdjkjk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dfcjdjkjk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479585, RefRangeEnd = 1479586, XrefRangeStart = 1479557, XrefRangeEnd = 1479585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dfjibkhbh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dfjibkhbh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479606, RefRangeEnd = 1479607, XrefRangeStart = 1479586, XrefRangeEnd = 1479606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_dihkeehk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dihkeehk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479629, RefRangeEnd = 1479630, XrefRangeStart = 1479607, XrefRangeEnd = 1479629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_djigibich(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_djigibich_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479650, RefRangeEnd = 1479651, XrefRangeStart = 1479630, XrefRangeEnd = 1479650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ebgkehdgb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ebgkehdgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479673, RefRangeEnd = 1479674, XrefRangeStart = 1479651, XrefRangeEnd = 1479673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ecgibfdjb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ecgibfdjb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479696, RefRangeEnd = 1479697, XrefRangeStart = 1479674, XrefRangeEnd = 1479696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_edfkjgfch(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_edfkjgfch_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479719, RefRangeEnd = 1479720, XrefRangeStart = 1479697, XrefRangeEnd = 1479719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ehkcekjii(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ehkcekjii_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479748, RefRangeEnd = 1479749, XrefRangeStart = 1479720, XrefRangeEnd = 1479748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_eidhfehik(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_eidhfehik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479771, RefRangeEnd = 1479772, XrefRangeStart = 1479749, XrefRangeEnd = 1479771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_eiehjkdd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_eiehjkdd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479794, RefRangeEnd = 1479795, XrefRangeStart = 1479772, XrefRangeEnd = 1479794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ejjgbkdff(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ejjgbkdff_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479815, RefRangeEnd = 1479816, XrefRangeStart = 1479795, XrefRangeEnd = 1479815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ejkdcifhg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ejkdcifhg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479835, RefRangeEnd = 1479836, XrefRangeStart = 1479816, XrefRangeEnd = 1479835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fbejgkdib(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fbejgkdib_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479856, RefRangeEnd = 1479857, XrefRangeStart = 1479836, XrefRangeEnd = 1479856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fdjggbfcb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fdjggbfcb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479877, RefRangeEnd = 1479878, XrefRangeStart = 1479857, XrefRangeEnd = 1479877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fdkkidgb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fdkkidgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479894, RefRangeEnd = 1479895, XrefRangeStart = 1479878, XrefRangeEnd = 1479894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fekcijijf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fekcijijf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479915, RefRangeEnd = 1479916, XrefRangeStart = 1479895, XrefRangeEnd = 1479915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fgcbdbbid(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fgcbdbbid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479938, RefRangeEnd = 1479939, XrefRangeStart = 1479916, XrefRangeEnd = 1479938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fgfckhdf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fgfckhdf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479959, RefRangeEnd = 1479960, XrefRangeStart = 1479939, XrefRangeEnd = 1479959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fhcdfebdc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fhcdfebdc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1479979, RefRangeEnd = 1479980, XrefRangeStart = 1479960, XrefRangeEnd = 1479979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fhjkfjice(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fhjkfjice_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480000, RefRangeEnd = 1480001, XrefRangeStart = 1479980, XrefRangeEnd = 1480000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fihfdkijh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fihfdkijh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480023, RefRangeEnd = 1480024, XrefRangeStart = 1480001, XrefRangeEnd = 1480023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fjkikekhi(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fjkikekhi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480046, RefRangeEnd = 1480047, XrefRangeStart = 1480024, XrefRangeEnd = 1480046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fkbkbchgb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fkbkbchgb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480063, RefRangeEnd = 1480064, XrefRangeStart = 1480047, XrefRangeEnd = 1480063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fkedkejgf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fkedkejgf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480083, RefRangeEnd = 1480084, XrefRangeStart = 1480064, XrefRangeEnd = 1480083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_fkfbciibe(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fkfbciibe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480106, RefRangeEnd = 1480107, XrefRangeStart = 1480084, XrefRangeEnd = 1480106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_gbchjfieb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gbchjfieb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480135, RefRangeEnd = 1480136, XrefRangeStart = 1480107, XrefRangeEnd = 1480135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_gbibihicb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gbibihicb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480164, RefRangeEnd = 1480165, XrefRangeStart = 1480136, XrefRangeEnd = 1480164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_geijfbdhc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_geijfbdhc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480187, RefRangeEnd = 1480188, XrefRangeStart = 1480165, XrefRangeEnd = 1480187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_gfgdjegbe(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gfgdjegbe_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480207, RefRangeEnd = 1480208, XrefRangeStart = 1480188, XrefRangeEnd = 1480207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_gihjfdefi(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gihjfdefi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480230, RefRangeEnd = 1480231, XrefRangeStart = 1480208, XrefRangeEnd = 1480230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_gjgidfgeh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gjgidfgeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480251, RefRangeEnd = 1480252, XrefRangeStart = 1480231, XrefRangeEnd = 1480251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_hbeefgbjc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hbeefgbjc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480280, RefRangeEnd = 1480281, XrefRangeStart = 1480252, XrefRangeEnd = 1480280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_hcehhjdfk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hcehhjdfk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480300, RefRangeEnd = 1480301, XrefRangeStart = 1480281, XrefRangeEnd = 1480300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_hekdkcdeh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hekdkcdeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480321, RefRangeEnd = 1480322, XrefRangeStart = 1480301, XrefRangeEnd = 1480321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_hfjfeiijk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hfjfeiijk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480350, RefRangeEnd = 1480351, XrefRangeStart = 1480322, XrefRangeEnd = 1480350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_hhbehfckd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hhbehfckd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480367, RefRangeEnd = 1480368, XrefRangeStart = 1480351, XrefRangeEnd = 1480367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_hhkbgdice(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hhkbgdice_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480384, RefRangeEnd = 1480385, XrefRangeStart = 1480368, XrefRangeEnd = 1480384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_hikdcfgkb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hikdcfgkb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480407, RefRangeEnd = 1480408, XrefRangeStart = 1480385, XrefRangeEnd = 1480407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_hkdbgkgik(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hkdbgkgik_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480432, RefRangeEnd = 1480433, XrefRangeStart = 1480408, XrefRangeEnd = 1480432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ibbddjcfb(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ibbddjcfb_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480453, RefRangeEnd = 1480454, XrefRangeStart = 1480433, XrefRangeEnd = 1480453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ichfccfhh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ichfccfhh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480474, RefRangeEnd = 1480475, XrefRangeStart = 1480454, XrefRangeEnd = 1480474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_idchgghie(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_idchgghie_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480497, RefRangeEnd = 1480498, XrefRangeStart = 1480475, XrefRangeEnd = 1480497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_iddeebfkg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iddeebfkg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480518, RefRangeEnd = 1480519, XrefRangeStart = 1480498, XrefRangeEnd = 1480518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_iddhiekfi(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iddhiekfi_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480543, RefRangeEnd = 1480544, XrefRangeStart = 1480519, XrefRangeEnd = 1480543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_idjfhgckc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_idjfhgckc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480560, RefRangeEnd = 1480561, XrefRangeStart = 1480544, XrefRangeEnd = 1480560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ihbgcbhic(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ihbgcbhic_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480581, RefRangeEnd = 1480582, XrefRangeStart = 1480561, XrefRangeEnd = 1480581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_iicekghif(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iicekghif_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480598, RefRangeEnd = 1480599, XrefRangeStart = 1480582, XrefRangeEnd = 1480598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_iifbheddf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iifbheddf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480618, RefRangeEnd = 1480619, XrefRangeStart = 1480599, XrefRangeEnd = 1480618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_ikejdbedk(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ikejdbedk_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480645, RefRangeEnd = 1480646, XrefRangeStart = 1480619, XrefRangeEnd = 1480645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_jcdhbjde(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jcdhbjde_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480668, RefRangeEnd = 1480669, XrefRangeStart = 1480646, XrefRangeEnd = 1480668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_jceehdeeh(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jceehdeeh_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480691, RefRangeEnd = 1480692, XrefRangeStart = 1480669, XrefRangeEnd = 1480691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_jchhdjhkg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jchhdjhkg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480714, RefRangeEnd = 1480715, XrefRangeStart = 1480692, XrefRangeEnd = 1480714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_jgcekgbii(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jgcekgbii_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480735, RefRangeEnd = 1480736, XrefRangeStart = 1480715, XrefRangeEnd = 1480735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_jigekbbhd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jigekbbhd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480756, RefRangeEnd = 1480757, XrefRangeStart = 1480736, XrefRangeEnd = 1480756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_jjjcegjeg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jjjcegjeg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480773, RefRangeEnd = 1480774, XrefRangeStart = 1480757, XrefRangeEnd = 1480773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_jkekeckbf(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jkekeckbf_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480793, RefRangeEnd = 1480794, XrefRangeStart = 1480774, XrefRangeEnd = 1480793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_kbcfjkedc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kbcfjkedc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480814, RefRangeEnd = 1480815, XrefRangeStart = 1480794, XrefRangeEnd = 1480814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_kdbikhddc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kdbikhddc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480834, RefRangeEnd = 1480835, XrefRangeStart = 1480815, XrefRangeEnd = 1480834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_kddgijibc(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kddgijibc_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480857, RefRangeEnd = 1480858, XrefRangeStart = 1480835, XrefRangeEnd = 1480857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_kdhdheib(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kdhdheib_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480880, RefRangeEnd = 1480881, XrefRangeStart = 1480858, XrefRangeEnd = 1480880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_kfbbiddfg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kfbbiddfg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480903, RefRangeEnd = 1480904, XrefRangeStart = 1480881, XrefRangeEnd = 1480903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_kfkchgjdd(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kfkchgjdd_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480924, RefRangeEnd = 1480925, XrefRangeStart = 1480904, XrefRangeEnd = 1480924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_kiighbfgg(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kiighbfgg_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1480947, RefRangeEnd = 1480948, XrefRangeStart = 1480925, XrefRangeEnd = 1480947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void SetupWeakRefs_Snapshot_kijdhbiid(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kijdhbiid_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1480948, XrefRangeEnd = 1480949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1481273, RefRangeEnd = 1481274, XrefRangeStart = 1480949, XrefRangeEnd = 1481273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void RunForEntity(Entity snapshotEntity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &snapshotEntity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_RunForEntity_Private_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SetupWeakRefsJob()
      {
        Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializeReplaySnapshotSystem>.NativeClassPtr, nameof (SetupWeakRefsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeFieldInfoPtr_SnapshotEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, nameof (SnapshotEntities));
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeFieldInfoPtr_GetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, nameof (GetNetworkId));
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeFieldInfoPtr_GetNetworkSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, nameof (GetNetworkSnapshot));
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeFieldInfoPtr_GetNetSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, nameof (GetNetSnapshot));
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeFieldInfoPtr_WeakRefTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, nameof (WeakRefTracker));
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeFieldInfoPtr_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, nameof (Params));
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbbdiefgbd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663313);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbbgiidegf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663314);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbdgdebikk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663315);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbfcjichfb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663316);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbhckcfdfd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663317);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbhkjccgdi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663318);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbicfeedbb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663319);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acbiddcjjid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663320);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acccfjkdigh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663321);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acccgefcedb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663322);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accdbefiheb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663323);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accdjiedgfe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663324);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accgciikfbf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663325);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_accgiggcif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663326);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acchhgcjcbh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663327);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acchibekekj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663328);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acciegkehkf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663329);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdccjhicfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663330);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdehhkijdj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663331);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdfgkkfchc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663332);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdficciidc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663333);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdibbekbkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663334);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdidhjbjgj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663335);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdjdjkckhd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663336);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdjighgcci_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663337);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdkgjbefjd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663338);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acdkkhcbdcg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663339);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acecggedbff_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663340);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aceegbjekgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663341);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aceehcgeedj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663342);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acegbdcgkdf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663343);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aceihfcgifd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663344);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acekdgegehc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663345);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acekjgheehk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663346);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfckgbfifj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663347);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfebiceeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663348);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfhdekidie_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663349);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acfikjcfik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663350);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgbiiekebj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663351);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgchdfhdbe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663352);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgckficfjg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663353);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgddgdckdd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663354);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgefcgggfi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663355);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acgfefhihji_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663356);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acggehdijfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663357);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acggfcbekbj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663358);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acggkbfbjck_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663359);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acghdchgjgf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663360);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achbffjechg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663361);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achbhefgeeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663362);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achbhhddbh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663363);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achcbdhidik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663364);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achdjgjdgkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663365);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achfcefeheb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663366);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achgedhdigf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663367);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achgegcdkcj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663368);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achicekidek_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663369);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achiggdccdc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663370);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achjkedegdi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663371);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_achjkicgkif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663372);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aciddedkjj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663373);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acidekciged_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663374);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acidjkkbgbk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663375);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acifkidfebh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663376);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acigkbdedfb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663377);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acihcehbbb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663378);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acihehkdfeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663379);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acihkdjfdkb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663380);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aciibbeciec_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663381);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acikghjjgki_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663382);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acikhjeehkg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663383);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjbgiffidc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663384);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjdegcccg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663385);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjigbfeikj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663386);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_acjkcgkfjff_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663387);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackbhgekeci_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663388);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackchfegcjc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663389);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackdkfeghk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663390);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackebkbdbjj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663391);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackffdikde_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663392);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackgdbibjbd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663393);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackifjdcjjd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663394);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackjbcfijee_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663395);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ackkecjdkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663396);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbbickeikd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663397);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbfkibeiid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663398);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbfkjhfcjd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663399);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbgiccjej_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663400);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbhchjbgek_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663401);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbijghdjjj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663402);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjcebiefe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663403);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjdjfkiif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663404);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjkedbgjg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663405);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbjkhhkffi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663406);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adbkdbehhdh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663407);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adcbfjighfe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663408);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adcdbdebfjg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663409);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adcffdijihg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663410);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adejkghcfk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663411);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adekhbkfjb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663412);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adgbkkgkkc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663413);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adgcbgkcfb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663414);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adjbidcgdh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663415);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_adkecehjdk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663416);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aebfefikfc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663417);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aegjbedggh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663418);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aeibfebcie_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663419);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aejfcffkde_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663420);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afcdibbdhk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663421);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afdcikchcf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663422);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afdgichhbg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663423);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afdgigchdc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663424);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afejhccjki_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663425);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afgfgihgc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663426);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afghjhgcgk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663427);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afibjfgjj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663428);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afiidbjjg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663429);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_afkbfgfhef_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663430);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agcdkcdjfe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663431);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agfgchgici_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663432);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aggchckijc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663433);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agghikgigk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663434);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aghhkgkfc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663435);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agijkdicg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663436);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agjkgikkig_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663437);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_agkckkkggd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663438);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahbgechgbk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663439);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahciehbbdc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663440);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahiggbegei_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663441);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahijjfgjce_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663442);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahkcgijbei_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663443);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ahkijdhjcb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663444);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aicgdjfcgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663445);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aidbefcifj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663446);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aidcegcehg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663447);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aiebecdijh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663448);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aieefjchbd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663449);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aiejbddfde_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663450);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aifejkfbkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663451);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aifkcjfiic_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663452);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_aigchgfejj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663453);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajcejdgdjc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663454);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajchjhccfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663455);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajfedjbbig_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663456);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajghhigdb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663457);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajgkhchijb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663458);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ajkhbehfkf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663459);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akdddhikjj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663460);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akdhbfiiid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663461);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akfbbffjcg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663462);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akgbiefjbh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663463);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akhbjjbcei_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663464);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akhiekbd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663465);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akidjkegkj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663466);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akjcidekhd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663467);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_akjiekjkkh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663468);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbbeifjkdj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663469);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbffeddche_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663470);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbggkebbfk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663471);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbhkgfiiif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663472);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbjidfdhfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663473);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbkcbhjiek_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663474);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cbkfhfcjb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663475);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccbfibgeci_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663476);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cccffebffc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663477);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cccggcfdkg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663478);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccekgicgfh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663479);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccfhfbhikj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663480);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ccgjgbjcgi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663481);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cchfdhghjd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663482);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cddckigibk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663483);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdedfgfkdj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663484);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdfdcchhe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663485);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdfibdbkfb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663486);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdfjfbikid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663487);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdgbkkidfd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663488);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdgibkchih_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663489);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdidfjjidb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663490);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cdjkcdjcgc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663491);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cebdekghcc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663492);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceceehkkdb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663493);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cechbcjbje_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663494);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cechggbfcg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663495);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cechibbibc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663496);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cedekbhedh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663497);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceecjebgfd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663498);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceffhbdbf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663499);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cegbicbcfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663500);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cegkcgkkgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663501);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ceiggdddik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663502);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cejhdeejck_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663503);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cekhfceefg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663504);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfbedkikg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663505);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfbjdedjcj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663506);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfbjghgjgf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663507);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfcfjiceg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663508);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfcjbdhdik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663509);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfcjgefdjg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663510);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfedcgehh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663511);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfffedbhfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663512);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfiggjfcfh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663513);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfjbbdjcdi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663514);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cfkdeghg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663515);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgbbhfbgbj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663516);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgbeibighh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663517);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgdieefdkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663518);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cghhdebggi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663519);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgighkjefc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663520);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cgjchkijib_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663521);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chdckkkgkg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663522);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chedkdbce_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663523);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chhcdcgigb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663524);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chibdbkfde_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663525);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chibgkeeji_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663526);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chiceijbgj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663527);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chiffhjbee_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663528);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_chiiihhffh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663529);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cichefikeb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663530);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cicjgdikig_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663531);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cifbcfjkdj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663532);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cigfkckdgc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663533);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cijeifhgec_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663534);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cijijgbkgk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663535);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjbcjhhgke_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663536);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjbjeehdbk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663537);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjdkihjijd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663538);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjfdcbgfgj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663539);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjgbfhfgef_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663540);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjhkjfhhf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663541);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjicjgdfff_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663542);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjjdbgbddi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663543);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjjdkdfkkh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663544);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_cjjjckihek_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663545);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ckbiikefid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663546);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ckeiejdgib_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663547);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ckkddehif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663548);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbbbcebccf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663549);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbedicfecc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663550);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbfehhjdb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663551);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbibcdhcc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663552);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dbjjcgeeki_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663553);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcbffdidkk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663554);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcbkfgcjid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663555);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcdjbbkec_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663556);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcebfkhcgc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663557);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcecciefge_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663558);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcehkgkifb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663559);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dcfehdgdkj_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663560);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ddffjifbf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663561);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ddikijcge_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663562);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_debdghice_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663563);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dfcjdjkjk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663564);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dfjibkhbh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663565);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_dihkeehk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663566);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_djigibich_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663567);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ebgkehdgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663568);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ecgibfdjb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663569);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_edfkjgfch_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663570);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ehkcekjii_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663571);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_eidhfehik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663572);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_eiehjkdd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663573);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ejjgbkdff_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663574);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ejkdcifhg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663575);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fbejgkdib_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663576);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fdjggbfcb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663577);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fdkkidgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663578);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fekcijijf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663579);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fgcbdbbid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663580);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fgfckhdf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663581);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fhcdfebdc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663582);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fhjkfjice_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663583);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fihfdkijh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663584);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fjkikekhi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663585);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fkbkbchgb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663586);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fkedkejgf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663587);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_fkfbciibe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663588);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gbchjfieb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663589);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gbibihicb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663590);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_geijfbdhc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663591);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gfgdjegbe_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663592);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gihjfdefi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663593);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_gjgidfgeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663594);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hbeefgbjc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663595);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hcehhjdfk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663596);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hekdkcdeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663597);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hfjfeiijk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663598);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hhbehfckd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663599);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hhkbgdice_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663600);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hikdcfgkb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663601);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_hkdbgkgik_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663602);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ibbddjcfb_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663603);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ichfccfhh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663604);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_idchgghie_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663605);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iddeebfkg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663606);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iddhiekfi_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663607);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_idjfhgckc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663608);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ihbgcbhic_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663609);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iicekghif_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663610);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_iifbheddf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663611);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_ikejdbedk_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663612);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jcdhbjde_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663613);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jceehdeeh_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663614);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jchhdjhkg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663615);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jgcekgbii_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663616);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jigekbbhd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663617);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jjjcegjeg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663618);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_jkekeckbf_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663619);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kbcfjkedc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663620);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kdbikhddc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663621);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kddgijibc_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663622);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kdhdheib_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663623);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kfbbiddfg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663624);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kfkchgjdd_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663625);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kiighbfgg_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663626);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_SetupWeakRefs_Snapshot_kijdhbiid_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663627);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663628);
        SerializeReplaySnapshotSystem.SetupWeakRefsJob.NativeMethodInfoPtr_RunForEntity_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, 100663629);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct JobParams
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_AbilityStateBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_AchievementInProgressElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_ActionBarSlotElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_AllyPermission;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_BloodHuntBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_ActiveServantMission;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleBuildingAttachedChildrenBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleBuildingAttachToParentsBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleBuildingFusedChildrenBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleMemberNames;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleTeleporterElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleTerritoryDecay;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleTerritoryOccupant;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_ClanMemberStatus;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_FollowerBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_AbilityChargeCooldowns;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_Script_LightningProjectile_Nodes;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_InventoryBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_InventoryInstanceElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_PerksBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_ProgressionBookBlueprintElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_ProgressionBookRecipeElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_ProgressionBookShapeshiftElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_ProgressionBookTechElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_PylonstationCastleClaimBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_PylonstationCastleDestroyBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_PylonstationCastleRaidBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_PylonstationUpgradesBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_QueuedWorkstationCraftAction;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_RefinementstationRecipesBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_ResearchBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_RespawnPointOwnerBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_Restricted_InventoryBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_ShardBossHuntBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_SpawnedUnitsBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_TradeCost;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_TradeOutput;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_TraderEntry;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_UnlockedVBlood;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_UnlockedWaypointElement;
        private static readonly System.IntPtr NativeFieldInfoPtr_GetSnapshot_Snapshot_UserMapZoneElement;
        [FieldOffset(0)]
        public BufferFromEntity<Snapshot_AbilityStateBuffer> GetSnapshot_Snapshot_AbilityStateBuffer;
        [FieldOffset(40)]
        public BufferFromEntity<Snapshot_AchievementInProgressElement> GetSnapshot_Snapshot_AchievementInProgressElement;
        [FieldOffset(80)]
        public BufferFromEntity<Snapshot_ActionBarSlotElement> GetSnapshot_Snapshot_ActionBarSlotElement;
        [FieldOffset(120)]
        public BufferFromEntity<Snapshot_AllyPermission> GetSnapshot_Snapshot_AllyPermission;
        [FieldOffset(160)]
        public BufferFromEntity<Snapshot_BloodHuntBuffer> GetSnapshot_Snapshot_BloodHuntBuffer;
        [FieldOffset(200)]
        public BufferFromEntity<Snapshot_ActiveServantMission> GetSnapshot_Snapshot_ActiveServantMission;
        [FieldOffset(240)]
        public BufferFromEntity<Snapshot_CastleBuildingAttachedChildrenBuffer> GetSnapshot_Snapshot_CastleBuildingAttachedChildrenBuffer;
        [FieldOffset(280)]
        public BufferFromEntity<Snapshot_CastleBuildingAttachToParentsBuffer> GetSnapshot_Snapshot_CastleBuildingAttachToParentsBuffer;
        [FieldOffset(320)]
        public BufferFromEntity<Snapshot_CastleBuildingFusedChildrenBuffer> GetSnapshot_Snapshot_CastleBuildingFusedChildrenBuffer;
        [FieldOffset(360)]
        public BufferFromEntity<Snapshot_CastleMemberNames> GetSnapshot_Snapshot_CastleMemberNames;
        [FieldOffset(400)]
        public BufferFromEntity<Snapshot_CastleTeleporterElement> GetSnapshot_Snapshot_CastleTeleporterElement;
        [FieldOffset(440)]
        public BufferFromEntity<Snapshot_CastleTerritoryDecay> GetSnapshot_Snapshot_CastleTerritoryDecay;
        [FieldOffset(480)]
        public BufferFromEntity<Snapshot_CastleTerritoryOccupant> GetSnapshot_Snapshot_CastleTerritoryOccupant;
        [FieldOffset(520)]
        public BufferFromEntity<Snapshot_ClanMemberStatus> GetSnapshot_Snapshot_ClanMemberStatus;
        [FieldOffset(560)]
        public BufferFromEntity<Snapshot_FollowerBuffer> GetSnapshot_Snapshot_FollowerBuffer;
        [FieldOffset(600)]
        public BufferFromEntity<Snapshot_AbilityChargeCooldowns> GetSnapshot_Snapshot_AbilityChargeCooldowns;
        [FieldOffset(640)]
        public BufferFromEntity<Snapshot_Script_LightningProjectile_Nodes> GetSnapshot_Snapshot_Script_LightningProjectile_Nodes;
        [FieldOffset(680)]
        public BufferFromEntity<Snapshot_InventoryBuffer> GetSnapshot_Snapshot_InventoryBuffer;
        [FieldOffset(720)]
        public BufferFromEntity<Snapshot_InventoryInstanceElement> GetSnapshot_Snapshot_InventoryInstanceElement;
        [FieldOffset(760)]
        public BufferFromEntity<Snapshot_PerksBuffer> GetSnapshot_Snapshot_PerksBuffer;
        [FieldOffset(800)]
        public BufferFromEntity<Snapshot_ProgressionBookBlueprintElement> GetSnapshot_Snapshot_ProgressionBookBlueprintElement;
        [FieldOffset(840)]
        public BufferFromEntity<Snapshot_ProgressionBookRecipeElement> GetSnapshot_Snapshot_ProgressionBookRecipeElement;
        [FieldOffset(880)]
        public BufferFromEntity<Snapshot_ProgressionBookShapeshiftElement> GetSnapshot_Snapshot_ProgressionBookShapeshiftElement;
        [FieldOffset(920)]
        public BufferFromEntity<Snapshot_ProgressionBookTechElement> GetSnapshot_Snapshot_ProgressionBookTechElement;
        [FieldOffset(960)]
        public BufferFromEntity<Snapshot_PylonstationCastleClaimBuffer> GetSnapshot_Snapshot_PylonstationCastleClaimBuffer;
        [FieldOffset(1000)]
        public BufferFromEntity<Snapshot_PylonstationCastleDestroyBuffer> GetSnapshot_Snapshot_PylonstationCastleDestroyBuffer;
        [FieldOffset(1040)]
        public BufferFromEntity<Snapshot_PylonstationCastleRaidBuffer> GetSnapshot_Snapshot_PylonstationCastleRaidBuffer;
        [FieldOffset(1080)]
        public BufferFromEntity<Snapshot_PylonstationUpgradesBuffer> GetSnapshot_Snapshot_PylonstationUpgradesBuffer;
        [FieldOffset(1120)]
        public BufferFromEntity<Snapshot_QueuedWorkstationCraftAction> GetSnapshot_Snapshot_QueuedWorkstationCraftAction;
        [FieldOffset(1160)]
        public BufferFromEntity<Snapshot_RefinementstationRecipesBuffer> GetSnapshot_Snapshot_RefinementstationRecipesBuffer;
        [FieldOffset(1200)]
        public BufferFromEntity<Snapshot_ResearchBuffer> GetSnapshot_Snapshot_ResearchBuffer;
        [FieldOffset(1240)]
        public BufferFromEntity<Snapshot_RespawnPointOwnerBuffer> GetSnapshot_Snapshot_RespawnPointOwnerBuffer;
        [FieldOffset(1280)]
        public BufferFromEntity<Snapshot_Restricted_InventoryBuffer> GetSnapshot_Snapshot_Restricted_InventoryBuffer;
        [FieldOffset(1320)]
        public BufferFromEntity<Snapshot_ShardBossHuntBuffer> GetSnapshot_Snapshot_ShardBossHuntBuffer;
        [FieldOffset(1360)]
        public BufferFromEntity<Snapshot_SpawnedUnitsBuffer> GetSnapshot_Snapshot_SpawnedUnitsBuffer;
        [FieldOffset(1400)]
        public BufferFromEntity<Snapshot_TradeCost> GetSnapshot_Snapshot_TradeCost;
        [FieldOffset(1440)]
        public BufferFromEntity<Snapshot_TradeOutput> GetSnapshot_Snapshot_TradeOutput;
        [FieldOffset(1480)]
        public BufferFromEntity<Snapshot_TraderEntry> GetSnapshot_Snapshot_TraderEntry;
        [FieldOffset(1520)]
        public BufferFromEntity<Snapshot_UnlockedVBlood> GetSnapshot_Snapshot_UnlockedVBlood;
        [FieldOffset(1560)]
        public BufferFromEntity<Snapshot_UnlockedWaypointElement> GetSnapshot_Snapshot_UnlockedWaypointElement;
        [FieldOffset(1600)]
        public BufferFromEntity<Snapshot_UserMapZoneElement> GetSnapshot_Snapshot_UserMapZoneElement;

        static JobParams()
        {
          Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob>.NativeClassPtr, nameof (JobParams));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr);
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_AbilityStateBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_AbilityStateBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_AchievementInProgressElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_AchievementInProgressElement));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_ActionBarSlotElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_ActionBarSlotElement));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_AllyPermission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_AllyPermission));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_BloodHuntBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_BloodHuntBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_ActiveServantMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_ActiveServantMission));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleBuildingAttachedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_CastleBuildingAttachedChildrenBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleBuildingAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_CastleBuildingAttachToParentsBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleBuildingFusedChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_CastleBuildingFusedChildrenBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleMemberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_CastleMemberNames));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleTeleporterElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_CastleTeleporterElement));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleTerritoryDecay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_CastleTerritoryDecay));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_CastleTerritoryOccupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_CastleTerritoryOccupant));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_ClanMemberStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_ClanMemberStatus));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_FollowerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_FollowerBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_AbilityChargeCooldowns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_AbilityChargeCooldowns));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_Script_LightningProjectile_Nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_Script_LightningProjectile_Nodes));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_InventoryBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_InventoryInstanceElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_InventoryInstanceElement));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_PerksBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_PerksBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_ProgressionBookBlueprintElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_ProgressionBookBlueprintElement));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_ProgressionBookRecipeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_ProgressionBookRecipeElement));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_ProgressionBookShapeshiftElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_ProgressionBookShapeshiftElement));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_ProgressionBookTechElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_ProgressionBookTechElement));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_PylonstationCastleClaimBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_PylonstationCastleClaimBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_PylonstationCastleDestroyBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_PylonstationCastleDestroyBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_PylonstationCastleRaidBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_PylonstationCastleRaidBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_PylonstationUpgradesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_PylonstationUpgradesBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_QueuedWorkstationCraftAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_QueuedWorkstationCraftAction));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_RefinementstationRecipesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_RefinementstationRecipesBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_ResearchBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_ResearchBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_RespawnPointOwnerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_RespawnPointOwnerBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_Restricted_InventoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_Restricted_InventoryBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_ShardBossHuntBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_ShardBossHuntBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_SpawnedUnitsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_SpawnedUnitsBuffer));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_TradeCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_TradeCost));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_TradeOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_TradeOutput));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_TraderEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_TraderEntry));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_UnlockedVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_UnlockedVBlood));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_UnlockedWaypointElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_UnlockedWaypointElement));
          SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams.NativeFieldInfoPtr_GetSnapshot_Snapshot_UserMapZoneElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, nameof (GetSnapshot_Snapshot_UserMapZoneElement));
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SerializeReplaySnapshotSystem.SetupWeakRefsJob.JobParams>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }
  }
}
