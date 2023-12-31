// Decompiled with JetBrains decompiler
// Type: ProjectM.DirtyTileBoundsManager
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;

#nullable disable
namespace ProjectM
{
  public class DirtyTileBoundsManager : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RelevantTileTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileDataCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__DirtyWorldBoundsOutputDeps;
    private static readonly System.IntPtr NativeFieldInfoPtr__InputJobHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__DirtyWorldBoundsQueue;
    private static readonly System.IntPtr NativeFieldInfoPtr__DirtyWorldBoundsList;
    private static readonly System.IntPtr NativeFieldInfoPtr__ResultDependencies;
    private static readonly System.IntPtr NativeFieldInfoPtr__Datas;
    private static readonly System.IntPtr NativeFieldInfoPtr__DirtyTileCellList;
    private static readonly System.IntPtr NativeFieldInfoPtr__DirtyTileCellOutputHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr__NewCustomDirtyWorldBoundQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__SerializeBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldTypeAccessor;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDirtyBoundsMergeQueueAsync_Public_NativeQueue_1_CustomDirtyTileBoundsEvent_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedDirtyTileBoundsAndComplete_Public_NativeList_1_BoundsMinMax_DirtyTileBoundsType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMergedDirtyTileBoundsAsync_Public_NativeList_1_BoundsMinMax_DirtyTileBoundsType_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDirtyTileCellsAsync_Public_NativeList_1_DirtyTileCell_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleDoubleEditorFluffDirtying_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleMergeDirtyBoundsJobs_Private_Void_byref_TileTypeData_JobHandle_NativeList_1_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 731782, RefRangeEnd = 731783, XrefRangeStart = 731781, XrefRangeEnd = 731782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeQueue<CustomDirtyTileBoundsEvent> GetDirtyBoundsMergeQueueAsync(
      out JobHandle boundsOutputDeps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref boundsOutputDeps;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.NativeMethodInfoPtr_GetDirtyBoundsMergeQueueAsync_Public_NativeQueue_1_CustomDirtyTileBoundsEvent_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeQueue<CustomDirtyTileBoundsEvent>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 731784, RefRangeEnd = 731789, XrefRangeStart = 731783, XrefRangeEnd = 731784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddInputJobHandle(JobHandle inputDeps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inputDeps;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731789, XrefRangeEnd = 731790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<BoundsMinMax> GetMergedDirtyTileBoundsAndComplete(
      DirtyTileBoundsType type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &type;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.NativeMethodInfoPtr_GetMergedDirtyTileBoundsAndComplete_Public_NativeList_1_BoundsMinMax_DirtyTileBoundsType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<BoundsMinMax>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 731791, RefRangeEnd = 731793, XrefRangeStart = 731790, XrefRangeEnd = 731791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<BoundsMinMax> GetMergedDirtyTileBoundsAsync(
      DirtyTileBoundsType type,
      out JobHandle outputDeps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outputDeps;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.NativeMethodInfoPtr_GetMergedDirtyTileBoundsAsync_Public_NativeList_1_BoundsMinMax_DirtyTileBoundsType_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<BoundsMinMax>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 731794, RefRangeEnd = 731796, XrefRangeStart = 731793, XrefRangeEnd = 731794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeList<DirtyTileCell> GetDirtyTileCellsAsync(out JobHandle outputDeps)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref outputDeps;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.NativeMethodInfoPtr_GetDirtyTileCellsAsync_Public_NativeList_1_DirtyTileCell_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeList<DirtyTileCell>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731796, XrefRangeEnd = 731837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DirtyTileBoundsManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731837, XrefRangeEnd = 731861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DirtyTileBoundsManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731861, XrefRangeEnd = 731920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DirtyTileBoundsManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731920, XrefRangeEnd = 731946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleDoubleEditorFluffDirtying()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.NativeMethodInfoPtr_HandleDoubleEditorFluffDirtying_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731946, XrefRangeEnd = 731961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ScheduleMergeDirtyBoundsJobs(
      ref DirtyTileBoundsManager.TileTypeData tileTypeData,
      JobHandle inputDependency,
      NativeList<JobHandle> resultdependencies)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref tileTypeData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputDependency;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &resultdependencies;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.NativeMethodInfoPtr_ScheduleMergeDirtyBoundsJobs_Private_Void_byref_TileTypeData_JobHandle_NativeList_1_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DirtyTileBoundsManager()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DirtyTileBoundsManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DirtyTileBoundsManager()
    {
      Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DirtyTileBoundsManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr);
      DirtyTileBoundsManager.NativeFieldInfoPtr_RelevantTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (RelevantTileTypes));
      DirtyTileBoundsManager.NativeFieldInfoPtr_TileDataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (TileDataCount));
      DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyWorldBoundsOutputDeps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (_DirtyWorldBoundsOutputDeps));
      DirtyTileBoundsManager.NativeFieldInfoPtr__InputJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (_InputJobHandle));
      DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyWorldBoundsQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (_DirtyWorldBoundsQueue));
      DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyWorldBoundsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (_DirtyWorldBoundsList));
      DirtyTileBoundsManager.NativeFieldInfoPtr__ResultDependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (_ResultDependencies));
      DirtyTileBoundsManager.NativeFieldInfoPtr__Datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (_Datas));
      DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyTileCellList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (_DirtyTileCellList));
      DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyTileCellOutputHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (_DirtyTileCellOutputHandle));
      DirtyTileBoundsManager.NativeFieldInfoPtr__NewCustomDirtyWorldBoundQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (_NewCustomDirtyWorldBoundQuery));
      DirtyTileBoundsManager.NativeFieldInfoPtr__SerializeBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (_SerializeBarrier));
      DirtyTileBoundsManager.NativeFieldInfoPtr__WorldTypeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (_WorldTypeAccessor));
      DirtyTileBoundsManager.NativeMethodInfoPtr_GetDirtyBoundsMergeQueueAsync_Public_NativeQueue_1_CustomDirtyTileBoundsEvent_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664649);
      DirtyTileBoundsManager.NativeMethodInfoPtr_AddInputJobHandle_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664650);
      DirtyTileBoundsManager.NativeMethodInfoPtr_GetMergedDirtyTileBoundsAndComplete_Public_NativeList_1_BoundsMinMax_DirtyTileBoundsType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664651);
      DirtyTileBoundsManager.NativeMethodInfoPtr_GetMergedDirtyTileBoundsAsync_Public_NativeList_1_BoundsMinMax_DirtyTileBoundsType_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664652);
      DirtyTileBoundsManager.NativeMethodInfoPtr_GetDirtyTileCellsAsync_Public_NativeList_1_DirtyTileCell_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664653);
      DirtyTileBoundsManager.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664654);
      DirtyTileBoundsManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664655);
      DirtyTileBoundsManager.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664656);
      DirtyTileBoundsManager.NativeMethodInfoPtr_HandleDoubleEditorFluffDirtying_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664657);
      DirtyTileBoundsManager.NativeMethodInfoPtr_ScheduleMergeDirtyBoundsJobs_Private_Void_byref_TileTypeData_JobHandle_NativeList_1_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664658);
      DirtyTileBoundsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664659);
      DirtyTileBoundsManager.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, 100664660);
    }

    public DirtyTileBoundsManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe TileType RelevantTileTypes
    {
      get
      {
        TileType relevantTileTypes;
        IL2CPP.il2cpp_field_static_get_value(DirtyTileBoundsManager.NativeFieldInfoPtr_RelevantTileTypes, (void*) &relevantTileTypes);
        return relevantTileTypes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DirtyTileBoundsManager.NativeFieldInfoPtr_RelevantTileTypes, (void*) &value);
      }
    }

    public static unsafe int TileDataCount
    {
      get
      {
        int tileDataCount;
        IL2CPP.il2cpp_field_static_get_value(DirtyTileBoundsManager.NativeFieldInfoPtr_TileDataCount, (void*) &tileDataCount);
        return tileDataCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DirtyTileBoundsManager.NativeFieldInfoPtr_TileDataCount, (void*) &value);
      }
    }

    public unsafe JobHandleManager _DirtyWorldBoundsOutputDeps
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyWorldBoundsOutputDeps));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyWorldBoundsOutputDeps)) = value;
      }
    }

    public unsafe JobHandleManager _InputJobHandle
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__InputJobHandle));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__InputJobHandle)) = value;
      }
    }

    public unsafe NativeQueue<CustomDirtyTileBoundsEvent> _DirtyWorldBoundsQueue
    {
      get
      {
        return *(NativeQueue<CustomDirtyTileBoundsEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyWorldBoundsQueue));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyWorldBoundsQueue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeQueue<CustomDirtyTileBoundsEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<CustomDirtyTileBoundsEvent> _DirtyWorldBoundsList
    {
      get
      {
        return *(NativeList<CustomDirtyTileBoundsEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyWorldBoundsList));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyWorldBoundsList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<CustomDirtyTileBoundsEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<JobHandle> _ResultDependencies
    {
      get
      {
        return *(NativeList<JobHandle>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__ResultDependencies));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__ResultDependencies), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<JobHandle>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Il2CppStructArray<DirtyTileBoundsManager.TileTypeData> _Datas
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__Datas));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<DirtyTileBoundsManager.TileTypeData>) null : new Il2CppStructArray<DirtyTileBoundsManager.TileTypeData>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__Datas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NativeList<DirtyTileCell> _DirtyTileCellList
    {
      get
      {
        return *(NativeList<DirtyTileCell>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyTileCellList));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyTileCellList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DirtyTileCell>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe JobHandleManager _DirtyTileCellOutputHandle
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyTileCellOutputHandle));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__DirtyTileCellOutputHandle)) = value;
      }
    }

    public unsafe EntityQuery _NewCustomDirtyWorldBoundQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__NewCustomDirtyWorldBoundQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__NewCustomDirtyWorldBoundQuery)) = value;
      }
    }

    public unsafe SerializeBarrier _SerializeBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__SerializeBarrier));
        return pointer == System.IntPtr.Zero ? (SerializeBarrier) null : new SerializeBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__SerializeBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<WorldTypeSingleton> _WorldTypeAccessor
    {
      get
      {
        return *(SingletonAccessor<WorldTypeSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__WorldTypeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirtyTileBoundsManager.NativeFieldInfoPtr__WorldTypeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldTypeSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TileTypeData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_RelevantTileTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutputDeps;
      private static readonly System.IntPtr NativeFieldInfoPtr_OutputBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_BoundsToMergeByChunk;
      private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_TileTypeData_TileType_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public TileType RelevantTileTypes;
      [FieldOffset(8)]
      public JobHandleManager OutputDeps;
      [FieldOffset(32)]
      public NativeList<BoundsMinMax> OutputBounds;
      [FieldOffset(48)]
      public NativeMultiHashMap<TerrainChunk, BoundsMinMax> BoundsToMergeByChunk;

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 731655, RefRangeEnd = 731661, XrefRangeStart = 731648, XrefRangeEnd = 731655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe DirtyTileBoundsManager.TileTypeData Create(TileType relevantTileTypes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &relevantTileTypes;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.TileTypeData.NativeMethodInfoPtr_Create_Public_Static_TileTypeData_TileType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DirtyTileBoundsManager.TileTypeData*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 731668, RefRangeEnd = 731669, XrefRangeStart = 731661, XrefRangeEnd = 731668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.TileTypeData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TileTypeData()
      {
        Il2CppClassPointerStore<DirtyTileBoundsManager.TileTypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (TileTypeData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirtyTileBoundsManager.TileTypeData>.NativeClassPtr);
        DirtyTileBoundsManager.TileTypeData.NativeFieldInfoPtr_RelevantTileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.TileTypeData>.NativeClassPtr, nameof (RelevantTileTypes));
        DirtyTileBoundsManager.TileTypeData.NativeFieldInfoPtr_OutputDeps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.TileTypeData>.NativeClassPtr, nameof (OutputDeps));
        DirtyTileBoundsManager.TileTypeData.NativeFieldInfoPtr_OutputBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.TileTypeData>.NativeClassPtr, nameof (OutputBounds));
        DirtyTileBoundsManager.TileTypeData.NativeFieldInfoPtr_BoundsToMergeByChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.TileTypeData>.NativeClassPtr, nameof (BoundsToMergeByChunk));
        DirtyTileBoundsManager.TileTypeData.NativeMethodInfoPtr_Create_Public_Static_TileTypeData_TileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager.TileTypeData>.NativeClassPtr, 100664661);
        DirtyTileBoundsManager.TileTypeData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager.TileTypeData>.NativeClassPtr, 100664662);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirtyTileBoundsManager.TileTypeData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CheckForDirtyTileBounds_AddCustomDirtyWorldBounds
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CustomWorldBoundEventType;
      private static readonly System.IntPtr NativeFieldInfoPtr_DirtyWorldBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_CommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public EntityTypeHandle EntityType;
      [FieldOffset(8)]
      public ComponentTypeHandle<CustomDirtyTileBoundsEvent> CustomWorldBoundEventType;
      [FieldOffset(40)]
      public NativeQueue<CustomDirtyTileBoundsEvent> DirtyWorldBounds;
      [FieldOffset(64)]
      public EntityCommandBuffer CommandBuffer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731669, XrefRangeEnd = 731681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CheckForDirtyTileBounds_AddCustomDirtyWorldBounds()
      {
        Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (CheckForDirtyTileBounds_AddCustomDirtyWorldBounds));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds>.NativeClassPtr);
        DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds>.NativeClassPtr, nameof (EntityType));
        DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds.NativeFieldInfoPtr_CustomWorldBoundEventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds>.NativeClassPtr, nameof (CustomWorldBoundEventType));
        DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds.NativeFieldInfoPtr_DirtyWorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds>.NativeClassPtr, nameof (DirtyWorldBounds));
        DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds.NativeFieldInfoPtr_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds>.NativeClassPtr, nameof (CommandBuffer));
        DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds>.NativeClassPtr, 100664663);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_AddCustomDirtyWorldBounds>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DirtyWorldBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_BoundsToMergeByChunk;
      private static readonly System.IntPtr NativeFieldInfoPtr_ResultList;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsServer;
      private static readonly System.IntPtr NativeFieldInfoPtr_MergeBoundsLimit;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public NativeList<CustomDirtyTileBoundsEvent> DirtyWorldBounds;
      [FieldOffset(16)]
      public NativeMultiHashMap<TerrainChunk, BoundsMinMax> BoundsToMergeByChunk;
      [FieldOffset(32)]
      public NativeList<BoundsMinMax> ResultList;
      [FieldOffset(48)]
      public TileType TileTypes;
      [FieldOffset(49)]
      public bool IsServer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731681, XrefRangeEnd = 731725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob()
      {
        Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob>.NativeClassPtr);
        DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob.NativeFieldInfoPtr_DirtyWorldBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob>.NativeClassPtr, nameof (DirtyWorldBounds));
        DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob.NativeFieldInfoPtr_BoundsToMergeByChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob>.NativeClassPtr, nameof (BoundsToMergeByChunk));
        DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob.NativeFieldInfoPtr_ResultList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob>.NativeClassPtr, nameof (ResultList));
        DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob.NativeFieldInfoPtr_TileTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob>.NativeClassPtr, nameof (TileTypes));
        DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob.NativeFieldInfoPtr_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob>.NativeClassPtr, nameof (IsServer));
        DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob.NativeFieldInfoPtr_MergeBoundsLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob>.NativeClassPtr, nameof (MergeBoundsLimit));
        DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob>.NativeClassPtr, 100664664);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe int MergeBoundsLimit
      {
        get
        {
          int mergeBoundsLimit;
          IL2CPP.il2cpp_field_static_get_value(DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob.NativeFieldInfoPtr_MergeBoundsLimit, (void*) &mergeBoundsLimit);
          return mergeBoundsLimit;
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DirtyTileBoundsManager.CheckForDirtyTileBounds_MergeDirtyWorldBoundsJob.NativeFieldInfoPtr_MergeBoundsLimit, (void*) &value);
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ConvertDirtyBoundsToList
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Source;
      private static readonly System.IntPtr NativeFieldInfoPtr_Result;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public NativeQueue<CustomDirtyTileBoundsEvent> Source;
      [FieldOffset(24)]
      public NativeList<CustomDirtyTileBoundsEvent> Result;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731725, XrefRangeEnd = 731736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.ConvertDirtyBoundsToList.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ConvertDirtyBoundsToList()
      {
        Il2CppClassPointerStore<DirtyTileBoundsManager.ConvertDirtyBoundsToList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (ConvertDirtyBoundsToList));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirtyTileBoundsManager.ConvertDirtyBoundsToList>.NativeClassPtr);
        DirtyTileBoundsManager.ConvertDirtyBoundsToList.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.ConvertDirtyBoundsToList>.NativeClassPtr, nameof (Source));
        DirtyTileBoundsManager.ConvertDirtyBoundsToList.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.ConvertDirtyBoundsToList>.NativeClassPtr, nameof (Result));
        DirtyTileBoundsManager.ConvertDirtyBoundsToList.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager.ConvertDirtyBoundsToList>.NativeClassPtr, 100664665);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirtyTileBoundsManager.ConvertDirtyBoundsToList>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CalculateDirtyTileCellsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_UnmergedDirtyTileBounds;
      private static readonly System.IntPtr NativeFieldInfoPtr_ResultDirtyTileCells;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
      [FieldOffset(0)]
      public NativeList<CustomDirtyTileBoundsEvent> UnmergedDirtyTileBounds;
      [FieldOffset(16)]
      public NativeList<DirtyTileCell> ResultDirtyTileCells;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731736, XrefRangeEnd = 731781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DirtyTileBoundsManager.CalculateDirtyTileCellsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CalculateDirtyTileCellsJob()
      {
        Il2CppClassPointerStore<DirtyTileBoundsManager.CalculateDirtyTileCellsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DirtyTileBoundsManager>.NativeClassPtr, nameof (CalculateDirtyTileCellsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirtyTileBoundsManager.CalculateDirtyTileCellsJob>.NativeClassPtr);
        DirtyTileBoundsManager.CalculateDirtyTileCellsJob.NativeFieldInfoPtr_UnmergedDirtyTileBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CalculateDirtyTileCellsJob>.NativeClassPtr, nameof (UnmergedDirtyTileBounds));
        DirtyTileBoundsManager.CalculateDirtyTileCellsJob.NativeFieldInfoPtr_ResultDirtyTileCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyTileBoundsManager.CalculateDirtyTileCellsJob>.NativeClassPtr, nameof (ResultDirtyTileCells));
        DirtyTileBoundsManager.CalculateDirtyTileCellsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyTileBoundsManager.CalculateDirtyTileCellsJob>.NativeClassPtr, 100664666);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirtyTileBoundsManager.CalculateDirtyTileCellsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
