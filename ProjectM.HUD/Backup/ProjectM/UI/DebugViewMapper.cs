// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DebugViewMapper
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Mathematics;
using Unity.Profiling;

#nullable disable
namespace ProjectM.UI
{
  public class DebugViewMapper : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientConnectState;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerEntitiesEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerEntitiesDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientEntitiesEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientEntitiesDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerNetworkedEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientNetworkedEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerArchetypeCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientArchetypeCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerUsers;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxServerUsers;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientUsers;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerFps;
    private static readonly System.IntPtr NativeFieldInfoPtr__AiEnabledCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__AiHighPriorityCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__Fps;
    private static readonly System.IntPtr NativeFieldInfoPtr__Latency;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerChunksLoaded;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerChunksRequested;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerChunksTotal;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientChunksLoaded;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientChunksRequested;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientChunksTotal;
    private static readonly System.IntPtr NativeFieldInfoPtr__AssetStreamingState;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientNetStats;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerNetworkTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReplayData;
    private static readonly System.IntPtr NativeFieldInfoPtr__Element;
    private static readonly System.IntPtr NativeFieldInfoPtr__BinderSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalCoordinate;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldCoordinate;
    private static readonly System.IntPtr NativeFieldInfoPtr__MousePositionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerDebugViewData;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateElements_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFps_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePositions_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEntities_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateArchetypes_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateNetwork_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateChunks_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateReplay_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAi_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAssetStreaming_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__36_0_Private_Void_Entity_UICanvasBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260005, XrefRangeEnd = 1260011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugViewMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260011, XrefRangeEnd = 1260019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugViewMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260019, XrefRangeEnd = 1260031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugViewMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1260053, RefRangeEnd = 1260054, XrefRangeStart = 1260031, XrefRangeEnd = 1260053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateElements()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr_UpdateElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1260155, RefRangeEnd = 1260156, XrefRangeStart = 1260054, XrefRangeEnd = 1260155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateFps()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr_UpdateFps_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1260306, RefRangeEnd = 1260307, XrefRangeStart = 1260156, XrefRangeEnd = 1260306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdatePositions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr_UpdatePositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1260345, RefRangeEnd = 1260346, XrefRangeStart = 1260307, XrefRangeEnd = 1260345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateEntities()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr_UpdateEntities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1260356, RefRangeEnd = 1260357, XrefRangeStart = 1260346, XrefRangeEnd = 1260356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateArchetypes()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr_UpdateArchetypes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1260390, RefRangeEnd = 1260391, XrefRangeStart = 1260357, XrefRangeEnd = 1260390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateNetwork()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr_UpdateNetwork_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1260424, RefRangeEnd = 1260425, XrefRangeStart = 1260391, XrefRangeEnd = 1260424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateChunks()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr_UpdateChunks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1260482, RefRangeEnd = 1260483, XrefRangeStart = 1260425, XrefRangeEnd = 1260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateReplay()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr_UpdateReplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260483, XrefRangeEnd = 1260497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateAi()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr_UpdateAi_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1260522, RefRangeEnd = 1260523, XrefRangeStart = 1260497, XrefRangeEnd = 1260522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateAssetStreaming()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr_UpdateAssetStreaming_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260523, XrefRangeEnd = 1260543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugViewMapper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1260549, RefRangeEnd = 1260550, XrefRangeStart = 1260543, XrefRangeEnd = 1260549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__36_0(Entity entity, UICanvasBase canvas)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr__OnUpdate_b__36_0_Private_Void_Entity_UICanvasBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260550, XrefRangeEnd = 1260579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugViewMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260579, XrefRangeEnd = 1260595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DebugViewMapper()
    {
      Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DebugViewMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr);
      DebugViewMapper.NativeFieldInfoPtr__ClientConnectState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ClientConnectState));
      DebugViewMapper.NativeFieldInfoPtr__ServerEntitiesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ServerEntitiesEnabled));
      DebugViewMapper.NativeFieldInfoPtr__ServerEntitiesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ServerEntitiesDisabled));
      DebugViewMapper.NativeFieldInfoPtr__ClientEntitiesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ClientEntitiesEnabled));
      DebugViewMapper.NativeFieldInfoPtr__ClientEntitiesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ClientEntitiesDisabled));
      DebugViewMapper.NativeFieldInfoPtr__ServerNetworkedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ServerNetworkedEntities));
      DebugViewMapper.NativeFieldInfoPtr__ClientNetworkedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ClientNetworkedEntities));
      DebugViewMapper.NativeFieldInfoPtr__ServerArchetypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ServerArchetypeCount));
      DebugViewMapper.NativeFieldInfoPtr__ClientArchetypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ClientArchetypeCount));
      DebugViewMapper.NativeFieldInfoPtr__ServerUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ServerUsers));
      DebugViewMapper.NativeFieldInfoPtr__MaxServerUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_MaxServerUsers));
      DebugViewMapper.NativeFieldInfoPtr__ClientUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ClientUsers));
      DebugViewMapper.NativeFieldInfoPtr__ServerFps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ServerFps));
      DebugViewMapper.NativeFieldInfoPtr__AiEnabledCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_AiEnabledCount));
      DebugViewMapper.NativeFieldInfoPtr__AiHighPriorityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_AiHighPriorityCount));
      DebugViewMapper.NativeFieldInfoPtr__Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_Fps));
      DebugViewMapper.NativeFieldInfoPtr__Latency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_Latency));
      DebugViewMapper.NativeFieldInfoPtr__ServerChunksLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ServerChunksLoaded));
      DebugViewMapper.NativeFieldInfoPtr__ServerChunksRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ServerChunksRequested));
      DebugViewMapper.NativeFieldInfoPtr__ServerChunksTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ServerChunksTotal));
      DebugViewMapper.NativeFieldInfoPtr__ClientChunksLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ClientChunksLoaded));
      DebugViewMapper.NativeFieldInfoPtr__ClientChunksRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ClientChunksRequested));
      DebugViewMapper.NativeFieldInfoPtr__ClientChunksTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ClientChunksTotal));
      DebugViewMapper.NativeFieldInfoPtr__AssetStreamingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_AssetStreamingState));
      DebugViewMapper.NativeFieldInfoPtr__ClientNetStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ClientNetStats));
      DebugViewMapper.NativeFieldInfoPtr__CurrentChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_CurrentChunk));
      DebugViewMapper.NativeFieldInfoPtr__ServerNetworkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ServerNetworkTime));
      DebugViewMapper.NativeFieldInfoPtr__ReplayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ReplayData));
      DebugViewMapper.NativeFieldInfoPtr__Element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_Element));
      DebugViewMapper.NativeFieldInfoPtr__BinderSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_BinderSystem));
      DebugViewMapper.NativeFieldInfoPtr__LocalCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_LocalCoordinate));
      DebugViewMapper.NativeFieldInfoPtr__WorldCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_WorldCoordinate));
      DebugViewMapper.NativeFieldInfoPtr__MousePositionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_MousePositionWorld));
      DebugViewMapper.NativeFieldInfoPtr__ServerDebugViewData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, nameof (_ServerDebugViewData));
      DebugViewMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      DebugViewMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      DebugViewMapper.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667194);
      DebugViewMapper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667195);
      DebugViewMapper.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667196);
      DebugViewMapper.NativeMethodInfoPtr_UpdateElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667197);
      DebugViewMapper.NativeMethodInfoPtr_UpdateFps_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667198);
      DebugViewMapper.NativeMethodInfoPtr_UpdatePositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667199);
      DebugViewMapper.NativeMethodInfoPtr_UpdateEntities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667200);
      DebugViewMapper.NativeMethodInfoPtr_UpdateArchetypes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667201);
      DebugViewMapper.NativeMethodInfoPtr_UpdateNetwork_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667202);
      DebugViewMapper.NativeMethodInfoPtr_UpdateChunks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667203);
      DebugViewMapper.NativeMethodInfoPtr_UpdateReplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667204);
      DebugViewMapper.NativeMethodInfoPtr_UpdateAi_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667205);
      DebugViewMapper.NativeMethodInfoPtr_UpdateAssetStreaming_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667206);
      DebugViewMapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667207);
      DebugViewMapper.NativeMethodInfoPtr__OnUpdate_b__36_0_Private_Void_Entity_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667208);
      DebugViewMapper.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667209);
      DebugViewMapper.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, 100667210);
    }

    public DebugViewMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ClientConnectState _ClientConnectState
    {
      get
      {
        return *(ClientConnectState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientConnectState));
      }
      [param: In] set
      {
        *(ClientConnectState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientConnectState)) = value;
      }
    }

    public unsafe Nullable_Unboxed<int> _ServerEntitiesEnabled
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerEntitiesEnabled));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerEntitiesEnabled), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<int> _ServerEntitiesDisabled
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerEntitiesDisabled));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerEntitiesDisabled), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _ClientEntitiesEnabled
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientEntitiesEnabled));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientEntitiesEnabled)) = value;
      }
    }

    public unsafe int _ClientEntitiesDisabled
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientEntitiesDisabled));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientEntitiesDisabled)) = value;
      }
    }

    public unsafe Nullable_Unboxed<int> _ServerNetworkedEntities
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerNetworkedEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerNetworkedEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _ClientNetworkedEntities
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientNetworkedEntities));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientNetworkedEntities)) = value;
      }
    }

    public unsafe Nullable_Unboxed<int> _ServerArchetypeCount
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerArchetypeCount));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerArchetypeCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _ClientArchetypeCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientArchetypeCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientArchetypeCount)) = value;
      }
    }

    public unsafe Nullable_Unboxed<int> _ServerUsers
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerUsers));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerUsers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<int> _MaxServerUsers
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__MaxServerUsers));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__MaxServerUsers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _ClientUsers
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientUsers));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientUsers)) = value;
      }
    }

    public unsafe int _ServerFps
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerFps));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerFps)) = value;
      }
    }

    public unsafe int _AiEnabledCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__AiEnabledCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__AiEnabledCount)) = value;
      }
    }

    public unsafe int _AiHighPriorityCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__AiHighPriorityCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__AiHighPriorityCount)) = value;
      }
    }

    public unsafe int _Fps
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__Fps));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__Fps)) = value;
      }
    }

    public unsafe int _Latency
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__Latency));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__Latency)) = value;
      }
    }

    public unsafe Nullable_Unboxed<int> _ServerChunksLoaded
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerChunksLoaded));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerChunksLoaded), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<int> _ServerChunksRequested
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerChunksRequested));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerChunksRequested), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Nullable_Unboxed<int> _ServerChunksTotal
    {
      get
      {
        return *(Nullable_Unboxed<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerChunksTotal));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerChunksTotal), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _ClientChunksLoaded
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientChunksLoaded));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientChunksLoaded)) = value;
      }
    }

    public unsafe int _ClientChunksRequested
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientChunksRequested));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientChunksRequested)) = value;
      }
    }

    public unsafe int _ClientChunksTotal
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientChunksTotal));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientChunksTotal)) = value;
      }
    }

    public unsafe DebugViewData.AssetStreamingData _AssetStreamingState
    {
      get
      {
        return *(DebugViewData.AssetStreamingData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__AssetStreamingState));
      }
      [param: In] set
      {
        *(DebugViewData.AssetStreamingData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__AssetStreamingState)) = value;
      }
    }

    public unsafe string _ClientNetStats
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientNetStats)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ClientNetStats), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _CurrentChunk
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__CurrentChunk)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__CurrentChunk), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float _ServerNetworkTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerNetworkTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerNetworkTime)) = value;
      }
    }

    public unsafe DebugViewData.ReplayData _ReplayData
    {
      get
      {
        return *(DebugViewData.ReplayData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ReplayData));
      }
      [param: In] set
      {
        *(DebugViewData.ReplayData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ReplayData)) = value;
      }
    }

    public unsafe DebugView _Element
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__Element));
        return pointer == System.IntPtr.Zero ? (DebugView) null : new DebugView(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__Element), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DebugViewBinderSystem _BinderSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__BinderSystem));
        return pointer == System.IntPtr.Zero ? (DebugViewBinderSystem) null : new DebugViewBinderSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__BinderSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float2 _LocalCoordinate
    {
      get
      {
        return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__LocalCoordinate));
      }
      [param: In] set
      {
        *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__LocalCoordinate)) = value;
      }
    }

    public unsafe float3 _WorldCoordinate
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__WorldCoordinate));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__WorldCoordinate)) = value;
      }
    }

    public unsafe float3 _MousePositionWorld
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__MousePositionWorld));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__MousePositionWorld)) = value;
      }
    }

    public unsafe ServerDebugViewData _ServerDebugViewData
    {
      get
      {
        return *(ServerDebugViewData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerDebugViewData));
      }
      [param: In] set
      {
        *(ServerDebugViewData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr__ServerDebugViewData)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UI.DebugViewMapper/ProjectM.UI.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugViewMapper_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1259987, RefRangeEnd = 1259988, XrefRangeStart = 1259985, XrefRangeEnd = 1259987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, UICanvasBase canvas)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) canvas);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259988, XrefRangeEnd = 1259990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1259996, RefRangeEnd = 1259997, XrefRangeStart = 1259990, XrefRangeEnd = 1259996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) runtimes);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259997, XrefRangeEnd = 1259999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(DebugViewMapper componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugViewMapper_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259999, XrefRangeEnd = 1260005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewMapper>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_Entity_UICanvasBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667211);
        DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667212);
        DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667213);
        DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugViewMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667214);
        DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100667215);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe DebugViewMapper hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (DebugViewMapper) null : new DebugViewMapper(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_canvas;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugViewMapper_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_ManagedComponentData<UICanvasBase> forParameter_canvas;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1259978, RefRangeEnd = 1259979, XrefRangeStart = 1259974, XrefRangeEnd = 1259978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DebugViewMapper componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugViewMapper_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1259984, RefRangeEnd = 1259985, XrefRangeStart = 1259979, XrefRangeEnd = 1259984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return new DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes(pointer);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_canvas));
          DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DebugViewMapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667216);
          DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100667217);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        public sealed class Runtimes : Il2CppSystem.ValueType
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_canvas;

          static Runtimes()
          {
            Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_canvas));
          }

          public Runtimes(System.IntPtr pointer)
            : base(pointer)
          {
          }

          public Runtimes()
          {
            // ISSUE: cast to a reference type
            // ISSUE: untyped stack allocation
            System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            // ISSUE: explicit constructor call
            base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, data));
          }

          public unsafe LambdaParameterValueProvider_Entity.Runtime runtime_entity
          {
            get
            {
              return *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity));
            }
            [param: In] set
            {
              *(LambdaParameterValueProvider_Entity.Runtime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity)) = value;
            }
          }

          public LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime runtime_canvas
          {
            get
            {
              System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvas);
              return new LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime>.NativeClassPtr, data));
            }
            [param: In] set
            {
              __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewMapper.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_canvas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LambdaParameterValueProvider_ManagedComponentData<UICanvasBase>.Runtime>.NativeClassPtr, (uint&) System.IntPtr.Zero));
            }
          }
        }
      }
    }
  }
}
