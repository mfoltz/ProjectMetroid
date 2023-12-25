// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.UserActivityGrid
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UserActivityGrid
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Grid;
    private static readonly System.IntPtr NativeFieldInfoPtr_BitMaskGrid;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserPositionFromUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserEntityFromUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControlledEntityFromUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserEntityNetworkIdFromUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControlledEntityNetworkIdFromUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputDataEntityNetworkIdFromUserIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_CellSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_CellCountOnEachAxis;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsUserClose_Public_Boolean_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateAllUserBitMask_Public_UserBitMask128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsUserCloseToBoundingBox_Public_Boolean_float3_SyncBoundingBox_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetUserIndexFromEntity_Public_Boolean_Entity_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsers_Public_Void_float3_NativeList_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsersInRadius_Public_Void_float3_Single_NativeList_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsersInRadiusAsBitMask_Public_UserBitMask128_float3_Single_NativeList_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsersAsUserBitMask_Public_UserBitMask128_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsersAsUserBitMask_Public_UserBitMask128_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsersAsUserBitMaskWithBoundingBox_Public_UserBitMask128_float3_SyncBoundingBox_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUsersAsUserBitMaskWithBoundingBox_Public_UserBitMask128_float2_SyncBoundingBox_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCellIndexWithinRange_Private_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDistanceSqToClosestUser_Public_Boolean_float3_NativeList_1_Int32_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellIndex_Private_Int32_float3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellIndex_Private_Int32_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellPosition2dFromIndex_Public_float2_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellPositionFromWorldPosition_Public_int2_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCellsInRadius_Public_Void_NativeList_1_Int32_float3_Single_0;
    [FieldOffset(0)]
    public NativeBitArray Grid;
    [FieldOffset(16)]
    public NativeArray<UserBitMask128> BitMaskGrid;
    [FieldOffset(32)]
    public NativeArray<float2> UserPositionFromUserIndex;
    [FieldOffset(48)]
    public NativeArray<Entity> UserEntityFromUserIndex;
    [FieldOffset(64)]
    public NativeArray<Entity> ControlledEntityFromUserIndex;
    [FieldOffset(80)]
    public NativeArray<NetworkId> UserEntityNetworkIdFromUserIndex;
    [FieldOffset(96)]
    public NativeArray<NetworkId> ControlledEntityNetworkIdFromUserIndex;
    [FieldOffset(112)]
    public NativeArray<NetworkId> InputDataEntityNetworkIdFromUserIndex;
    [FieldOffset(128)]
    public float2 Offset;
    [FieldOffset(136)]
    public int CellSize;
    [FieldOffset(140)]
    public int CellCountOnEachAxis;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1153685, RefRangeEnd = 1153687, XrefRangeStart = 1153683, XrefRangeEnd = 1153685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsUserClose(float3 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_IsUserClose_Public_Boolean_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153687, XrefRangeEnd = 1153689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserBitMask128 CalculateAllUserBitMask()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_CalculateAllUserBitMask_Public_UserBitMask128_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserBitMask128*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1153693, RefRangeEnd = 1153695, XrefRangeStart = 1153689, XrefRangeEnd = 1153693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsUserCloseToBoundingBox(float3 worldPosition, SyncBoundingBox box)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &box;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_IsUserCloseToBoundingBox_Public_Boolean_float3_SyncBoundingBox_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1153698, RefRangeEnd = 1153699, XrefRangeStart = 1153695, XrefRangeEnd = 1153698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetUserIndexFromEntity(Entity entity, out int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_TryGetUserIndexFromEntity_Public_Boolean_Entity_byref_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153699, XrefRangeEnd = 1153713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetUsers(float3 worldPosition, NativeList<int> users)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &users;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetUsers_Public_Void_float3_NativeList_1_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1153733, RefRangeEnd = 1153741, XrefRangeStart = 1153713, XrefRangeEnd = 1153733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetUsersInRadius(float3 worldPosition, float radius, NativeList<int> users)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &users;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetUsersInRadius_Public_Void_float3_Single_NativeList_1_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1153751, RefRangeEnd = 1153753, XrefRangeStart = 1153741, XrefRangeEnd = 1153751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserBitMask128 GetUsersInRadiusAsBitMask(
      float3 worldPosition,
      float radius,
      NativeList<int> users)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &users;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetUsersInRadiusAsBitMask_Public_UserBitMask128_float3_Single_NativeList_1_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserBitMask128*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153753, XrefRangeEnd = 1153755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserBitMask128 GetUsersAsUserBitMask(float3 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetUsersAsUserBitMask_Public_UserBitMask128_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserBitMask128*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153755, XrefRangeEnd = 1153757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserBitMask128 GetUsersAsUserBitMask(float2 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetUsersAsUserBitMask_Public_UserBitMask128_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserBitMask128*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153757, XrefRangeEnd = 1153759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserBitMask128 GetUsersAsUserBitMaskWithBoundingBox(
      float3 worldPosition,
      SyncBoundingBox boundingBox)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &boundingBox;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetUsersAsUserBitMaskWithBoundingBox_Public_UserBitMask128_float3_SyncBoundingBox_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserBitMask128*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1153759, XrefRangeEnd = 1153761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UserBitMask128 GetUsersAsUserBitMaskWithBoundingBox(
      float2 worldPosition,
      SyncBoundingBox boundingBox)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &boundingBox;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetUsersAsUserBitMaskWithBoundingBox_Public_UserBitMask128_float2_SyncBoundingBox_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UserBitMask128*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool IsCellIndexWithinRange(int cellIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &cellIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_IsCellIndexWithinRange_Private_Boolean_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1153776, RefRangeEnd = 1153779, XrefRangeStart = 1153761, XrefRangeEnd = 1153776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetDistanceSqToClosestUser(
      float3 worldPosition,
      NativeList<int> users,
      out float closestDistanceSq)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &users;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref closestDistanceSq;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_TryGetDistanceSqToClosestUser_Public_Boolean_float3_NativeList_1_Int32_byref_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe int GetCellIndex(float3 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetCellIndex_Private_Int32_float3_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe int GetCellIndex(float2 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetCellIndex_Private_Int32_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe float2 GetCellPosition2dFromIndex(int index)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &index;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetCellPosition2dFromIndex_Public_float2_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe int2 GetCellPositionFromWorldPosition(float2 worldPosition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldPosition;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetCellPositionFromWorldPosition_Public_int2_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int2*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1153785, RefRangeEnd = 1153787, XrefRangeStart = 1153779, XrefRangeEnd = 1153785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetCellsInRadius(NativeList<int> cells, float3 worldPosition, float radius)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &cells;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UserActivityGrid.NativeMethodInfoPtr_GetCellsInRadius_Public_Void_NativeList_1_Int32_float3_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UserActivityGrid()
    {
      Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (UserActivityGrid));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr);
      UserActivityGrid.NativeFieldInfoPtr_Grid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, nameof (Grid));
      UserActivityGrid.NativeFieldInfoPtr_BitMaskGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, nameof (BitMaskGrid));
      UserActivityGrid.NativeFieldInfoPtr_UserPositionFromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, nameof (UserPositionFromUserIndex));
      UserActivityGrid.NativeFieldInfoPtr_UserEntityFromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, nameof (UserEntityFromUserIndex));
      UserActivityGrid.NativeFieldInfoPtr_ControlledEntityFromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, nameof (ControlledEntityFromUserIndex));
      UserActivityGrid.NativeFieldInfoPtr_UserEntityNetworkIdFromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, nameof (UserEntityNetworkIdFromUserIndex));
      UserActivityGrid.NativeFieldInfoPtr_ControlledEntityNetworkIdFromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, nameof (ControlledEntityNetworkIdFromUserIndex));
      UserActivityGrid.NativeFieldInfoPtr_InputDataEntityNetworkIdFromUserIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, nameof (InputDataEntityNetworkIdFromUserIndex));
      UserActivityGrid.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, nameof (Offset));
      UserActivityGrid.NativeFieldInfoPtr_CellSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, nameof (CellSize));
      UserActivityGrid.NativeFieldInfoPtr_CellCountOnEachAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, nameof (CellCountOnEachAxis));
      UserActivityGrid.NativeMethodInfoPtr_IsUserClose_Public_Boolean_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691730);
      UserActivityGrid.NativeMethodInfoPtr_CalculateAllUserBitMask_Public_UserBitMask128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691731);
      UserActivityGrid.NativeMethodInfoPtr_IsUserCloseToBoundingBox_Public_Boolean_float3_SyncBoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691732);
      UserActivityGrid.NativeMethodInfoPtr_TryGetUserIndexFromEntity_Public_Boolean_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691733);
      UserActivityGrid.NativeMethodInfoPtr_GetUsers_Public_Void_float3_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691734);
      UserActivityGrid.NativeMethodInfoPtr_GetUsersInRadius_Public_Void_float3_Single_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691735);
      UserActivityGrid.NativeMethodInfoPtr_GetUsersInRadiusAsBitMask_Public_UserBitMask128_float3_Single_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691736);
      UserActivityGrid.NativeMethodInfoPtr_GetUsersAsUserBitMask_Public_UserBitMask128_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691737);
      UserActivityGrid.NativeMethodInfoPtr_GetUsersAsUserBitMask_Public_UserBitMask128_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691738);
      UserActivityGrid.NativeMethodInfoPtr_GetUsersAsUserBitMaskWithBoundingBox_Public_UserBitMask128_float3_SyncBoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691739);
      UserActivityGrid.NativeMethodInfoPtr_GetUsersAsUserBitMaskWithBoundingBox_Public_UserBitMask128_float2_SyncBoundingBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691740);
      UserActivityGrid.NativeMethodInfoPtr_IsCellIndexWithinRange_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691741);
      UserActivityGrid.NativeMethodInfoPtr_TryGetDistanceSqToClosestUser_Public_Boolean_float3_NativeList_1_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691742);
      UserActivityGrid.NativeMethodInfoPtr_GetCellIndex_Private_Int32_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691743);
      UserActivityGrid.NativeMethodInfoPtr_GetCellIndex_Private_Int32_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691744);
      UserActivityGrid.NativeMethodInfoPtr_GetCellPosition2dFromIndex_Public_float2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691745);
      UserActivityGrid.NativeMethodInfoPtr_GetCellPositionFromWorldPosition_Public_int2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691746);
      UserActivityGrid.NativeMethodInfoPtr_GetCellsInRadius_Public_Void_NativeList_1_Int32_float3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, 100691747);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserActivityGrid>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
