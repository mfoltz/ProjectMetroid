// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DebugViewBinderSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Network;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class DebugViewBinderSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EnabledDebugModes;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebugViewData;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllClientEntitiesDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllClientEntitiesEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__AllClientNetworkedEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientTerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__HybridModelStreamingHandler;
    private static readonly System.IntPtr NativeFieldInfoPtr__ClientUIStreamingHandler;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerData;
    private static readonly System.IntPtr NativeFieldInfoPtr__FpsCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr__NextFpsTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastClientNetworkStatsTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastServerNetworkStatsTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_18;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_19;
    private static readonly System.IntPtr NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_20;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EnabledDebugModes_Public_get_DebugViewCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_EnabledDebugModes_Public_set_Void_DebugViewCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LastEnabledDebugViewModes_Public_get_DebugViewCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LastEnabledDebugViewModes_Public_set_Void_DebugViewCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateServerWorld_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsModeEnabled_Public_Boolean_DebugViewCategory_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetArchetypeCount_Private_Nullable_Unboxed_1_Int32_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetChunksLoadedInfo_Private_Void_World_byref_Nullable_Unboxed_1_Int32_byref_Nullable_Unboxed_1_Int32_byref_Nullable_Unboxed_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe DebugViewCategory EnabledDebugModes
    {
      [CallerCount(264), CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugViewBinderSystem.NativeMethodInfoPtr_get_EnabledDebugModes_Public_get_DebugViewCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DebugViewCategory*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugViewBinderSystem.NativeMethodInfoPtr_set_EnabledDebugModes_Public_set_Void_DebugViewCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe DebugViewCategory LastEnabledDebugViewModes
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugViewBinderSystem.NativeMethodInfoPtr_get_LastEnabledDebugViewModes_Public_get_DebugViewCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DebugViewCategory*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(10560), CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugViewBinderSystem.NativeMethodInfoPtr_set_LastEnabledDebugViewModes_Public_set_Void_DebugViewCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260641, XrefRangeEnd = 1260693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugViewBinderSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1260704, RefRangeEnd = 1260706, XrefRangeStart = 1260693, XrefRangeEnd = 1260704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateServerWorld()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewBinderSystem.NativeMethodInfoPtr_UpdateServerWorld_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool IsModeEnabled(DebugViewCategory mode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &mode;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugViewBinderSystem.NativeMethodInfoPtr_IsModeEnabled_Public_Boolean_DebugViewCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260706, XrefRangeEnd = 1260857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugViewBinderSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1260871, RefRangeEnd = 1260873, XrefRangeStart = 1260857, XrefRangeEnd = 1260871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Nullable_Unboxed<int> GetArchetypeCount(World serverWorld)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverWorld);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugViewBinderSystem.NativeMethodInfoPtr_GetArchetypeCount_Private_Nullable_Unboxed_1_Int32_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Nullable_Unboxed<int>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1260924, RefRangeEnd = 1260926, XrefRangeStart = 1260873, XrefRangeEnd = 1260924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetChunksLoadedInfo(
      World world,
      out Nullable_Unboxed<int> numOfLoaded,
      out Nullable_Unboxed<int> numOfRequested,
      out Nullable_Unboxed<int> totalChunks)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref numOfLoaded;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref numOfRequested;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalChunks;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewBinderSystem.NativeMethodInfoPtr_GetChunksLoadedInfo_Private_Void_World_byref_Nullable_Unboxed_1_Int32_byref_Nullable_Unboxed_1_Int32_byref_Nullable_Unboxed_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugViewBinderSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugViewBinderSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1260926, XrefRangeEnd = 1260946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DebugViewBinderSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugViewBinderSystem()
    {
      Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DebugViewBinderSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr);
      DebugViewBinderSystem.NativeFieldInfoPtr__EnabledDebugModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_EnabledDebugModes));
      DebugViewBinderSystem.NativeFieldInfoPtr_DebugViewData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (DebugViewData));
      DebugViewBinderSystem.NativeFieldInfoPtr__AllClientEntitiesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_AllClientEntitiesDisabled));
      DebugViewBinderSystem.NativeFieldInfoPtr__AllClientEntitiesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_AllClientEntitiesEnabled));
      DebugViewBinderSystem.NativeFieldInfoPtr__AllClientNetworkedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_AllClientNetworkedEntities));
      DebugViewBinderSystem.NativeFieldInfoPtr__ClientTerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_ClientTerrainManager));
      DebugViewBinderSystem.NativeFieldInfoPtr__HybridModelStreamingHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_HybridModelStreamingHandler));
      DebugViewBinderSystem.NativeFieldInfoPtr__ClientUIStreamingHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_ClientUIStreamingHandler));
      DebugViewBinderSystem.NativeFieldInfoPtr__ServerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_ServerData));
      DebugViewBinderSystem.NativeFieldInfoPtr__FpsCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_FpsCounter));
      DebugViewBinderSystem.NativeFieldInfoPtr__NextFpsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_NextFpsTime));
      DebugViewBinderSystem.NativeFieldInfoPtr__LastClientNetworkStatsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_LastClientNetworkStatsTime));
      DebugViewBinderSystem.NativeFieldInfoPtr__LastServerNetworkStatsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_LastServerNetworkStatsTime));
      DebugViewBinderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ClientReplayPlayerEnabled_18));
      DebugViewBinderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_ClientReplayRecorderEnabled_19));
      DebugViewBinderSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (_SingletonEntityQuery_LocalControlled_20));
      DebugViewBinderSystem.NativeMethodInfoPtr_get_EnabledDebugModes_Public_get_DebugViewCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667218);
      DebugViewBinderSystem.NativeMethodInfoPtr_set_EnabledDebugModes_Public_set_Void_DebugViewCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667219);
      DebugViewBinderSystem.NativeMethodInfoPtr_get_LastEnabledDebugViewModes_Public_get_DebugViewCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667220);
      DebugViewBinderSystem.NativeMethodInfoPtr_set_LastEnabledDebugViewModes_Public_set_Void_DebugViewCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667221);
      DebugViewBinderSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667222);
      DebugViewBinderSystem.NativeMethodInfoPtr_UpdateServerWorld_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667223);
      DebugViewBinderSystem.NativeMethodInfoPtr_IsModeEnabled_Public_Boolean_DebugViewCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667224);
      DebugViewBinderSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667225);
      DebugViewBinderSystem.NativeMethodInfoPtr_GetArchetypeCount_Private_Nullable_Unboxed_1_Int32_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667226);
      DebugViewBinderSystem.NativeMethodInfoPtr_GetChunksLoadedInfo_Private_Void_World_byref_Nullable_Unboxed_1_Int32_byref_Nullable_Unboxed_1_Int32_byref_Nullable_Unboxed_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667227);
      DebugViewBinderSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667228);
      DebugViewBinderSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, 100667229);
    }

    public DebugViewBinderSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe DebugViewCategory _EnabledDebugModes
    {
      get
      {
        return *(DebugViewCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__EnabledDebugModes));
      }
      [param: In] set
      {
        *(DebugViewCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__EnabledDebugModes)) = value;
      }
    }

    public DebugViewData DebugViewData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr_DebugViewData);
        return new DebugViewData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr_DebugViewData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugViewData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _AllClientEntitiesDisabled
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__AllClientEntitiesDisabled));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__AllClientEntitiesDisabled)) = value;
      }
    }

    public unsafe EntityQuery _AllClientEntitiesEnabled
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__AllClientEntitiesEnabled));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__AllClientEntitiesEnabled)) = value;
      }
    }

    public unsafe EntityQuery _AllClientNetworkedEntities
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__AllClientNetworkedEntities));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__AllClientNetworkedEntities)) = value;
      }
    }

    public unsafe TerrainManager _ClientTerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__ClientTerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__ClientTerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HybridModelStreamingHandler _HybridModelStreamingHandler
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__HybridModelStreamingHandler));
        return pointer == System.IntPtr.Zero ? (HybridModelStreamingHandler) null : new HybridModelStreamingHandler(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__HybridModelStreamingHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIAssetSubSceneLoader_ClientWorld _ClientUIStreamingHandler
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__ClientUIStreamingHandler));
        return pointer == System.IntPtr.Zero ? (UIAssetSubSceneLoader_ClientWorld) null : new UIAssetSubSceneLoader_ClientWorld(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__ClientUIStreamingHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DebugViewBinderSystem.ServerWorldAccess _ServerData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__ServerData));
        return pointer == System.IntPtr.Zero ? (DebugViewBinderSystem.ServerWorldAccess) null : new DebugViewBinderSystem.ServerWorldAccess(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__ServerData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _FpsCounter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__FpsCounter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__FpsCounter)) = value;
      }
    }

    public unsafe double _NextFpsTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__NextFpsTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__NextFpsTime)) = value;
      }
    }

    public unsafe double _LastClientNetworkStatsTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__LastClientNetworkStatsTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__LastClientNetworkStatsTime)) = value;
      }
    }

    public unsafe double _LastServerNetworkStatsTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__LastServerNetworkStatsTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__LastServerNetworkStatsTime)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ClientReplayPlayerEnabled_18
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_18));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayPlayerEnabled_18)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_ClientReplayRecorderEnabled_19
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_19));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__SingletonEntityQuery_ClientReplayRecorderEnabled_19)) = value;
      }
    }

    public unsafe EntityQuery _SingletonEntityQuery_LocalControlled_20
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_20));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.NativeFieldInfoPtr__SingletonEntityQuery_LocalControlled_20)) = value;
      }
    }

    public class ServerWorldAccess : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_World;
      private static readonly System.IntPtr NativeFieldInfoPtr_AllServerEntitiesDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_AllServerEntitiesEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_AllServerUsers;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerInitializationSystemGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerSimulationSystemGroup;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerBootstrapSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_NetworkedServerSystem;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_World_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1260635, RefRangeEnd = 1260636, XrefRangeStart = 1260595, XrefRangeEnd = 1260635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ServerWorldAccess(World serverWorld)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serverWorld);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugViewBinderSystem.ServerWorldAccess.NativeMethodInfoPtr__ctor_Public_Void_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1260640, RefRangeEnd = 1260641, XrefRangeStart = 1260636, XrefRangeEnd = 1260640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DebugViewBinderSystem.ServerWorldAccess.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ServerWorldAccess()
      {
        Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugViewBinderSystem>.NativeClassPtr, nameof (ServerWorldAccess));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr);
        DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_World = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr, nameof (World));
        DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_AllServerEntitiesDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr, nameof (AllServerEntitiesDisabled));
        DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_AllServerEntitiesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr, nameof (AllServerEntitiesEnabled));
        DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_AllServerUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr, nameof (AllServerUsers));
        DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_ServerInitializationSystemGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr, nameof (ServerInitializationSystemGroup));
        DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_ServerSimulationSystemGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr, nameof (ServerSimulationSystemGroup));
        DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_ServerBootstrapSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr, nameof (ServerBootstrapSystem));
        DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_NetworkedServerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr, nameof (NetworkedServerSystem));
        DebugViewBinderSystem.ServerWorldAccess.NativeMethodInfoPtr__ctor_Public_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr, 100667230);
        DebugViewBinderSystem.ServerWorldAccess.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugViewBinderSystem.ServerWorldAccess>.NativeClassPtr, 100667231);
      }

      public ServerWorldAccess(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe World World
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_World));
          return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_World), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityQuery AllServerEntitiesDisabled
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_AllServerEntitiesDisabled));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_AllServerEntitiesDisabled)) = value;
        }
      }

      public unsafe EntityQuery AllServerEntitiesEnabled
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_AllServerEntitiesEnabled));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_AllServerEntitiesEnabled)) = value;
        }
      }

      public unsafe EntityQuery AllServerUsers
      {
        get
        {
          return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_AllServerUsers));
        }
        [param: In] set
        {
          *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_AllServerUsers)) = value;
        }
      }

      public unsafe ServerInitializationSystemGroup ServerInitializationSystemGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_ServerInitializationSystemGroup));
          return pointer == System.IntPtr.Zero ? (ServerInitializationSystemGroup) null : new ServerInitializationSystemGroup(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_ServerInitializationSystemGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerSimulationSystemGroup ServerSimulationSystemGroup
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_ServerSimulationSystemGroup));
          return pointer == System.IntPtr.Zero ? (ServerSimulationSystemGroup) null : new ServerSimulationSystemGroup(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_ServerSimulationSystemGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServerBootstrapSystem ServerBootstrapSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_ServerBootstrapSystem));
          return pointer == System.IntPtr.Zero ? (ServerBootstrapSystem) null : new ServerBootstrapSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_ServerBootstrapSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SetupNetworkIdSystem NetworkedServerSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_NetworkedServerSystem));
          return pointer == System.IntPtr.Zero ? (SetupNetworkIdSystem) null : new SetupNetworkIdSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugViewBinderSystem.ServerWorldAccess.NativeFieldInfoPtr_NetworkedServerSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
