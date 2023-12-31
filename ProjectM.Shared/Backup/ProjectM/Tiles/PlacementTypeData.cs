// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.PlacementTypeData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using ProjectM.ContentTesting;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Tiles
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlacementTypeData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BasicFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_ObjectFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloorFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_WallFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntranceFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_LiquidFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_MustMatchAll;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlacementTypeBasicFlags_PlacementTypeObjectFlags_PlacementTypeTerrainFlags_PlacementTypeFloorFlags_PlacementTypeUnitFlags_PlacementTypeWallFlags_PlacementTypeEntranceFlags_PlacementTypeLiquidFlags_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAnyOrAll_Public_Boolean_PlacementTypeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAny_Public_Boolean_PlacementTypeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAll_Public_Boolean_PlacementTypeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Merge_Public_Void_PlacementTypeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOverlapping_Public_PlacementTypeData_PlacementTypeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContentTestAttachmentFlagTags_Public_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContentTestReplaceableFlagTags_Public_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllTaggedAttachmentFlags_Public_Static_PlacementTypeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckAttachmentFlags_Private_Void_T_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckReplaceableFlags_Private_Void_T_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAttachmentFlags_Private_Static_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DebugLog_Public_Void_0;
    [FieldOffset(0)]
    public PlacementTypeBasicFlags BasicFlags;
    [FieldOffset(8)]
    public PlacementTypeObjectFlags ObjectFlags;
    [FieldOffset(16)]
    public PlacementTypeTerrainFlags TerrainFlags;
    [FieldOffset(24)]
    public PlacementTypeFloorFlags FloorFlags;
    [FieldOffset(32)]
    public PlacementTypeUnitFlags UnitFlags;
    [FieldOffset(33)]
    public PlacementTypeWallFlags WallFlags;
    [FieldOffset(34)]
    public PlacementTypeEntranceFlags EntranceFlags;
    [FieldOffset(35)]
    public PlacementTypeLiquidFlags LiquidFlags;
    [FieldOffset(36)]
    public bool MustMatchAll;

    [CallerCount(0)]
    public unsafe PlacementTypeData(
      PlacementTypeBasicFlags basicFlags,
      PlacementTypeObjectFlags objectFlags,
      PlacementTypeTerrainFlags terrainFlags,
      PlacementTypeFloorFlags floorFlags,
      PlacementTypeUnitFlags unitFlags,
      PlacementTypeWallFlags wallFlags,
      PlacementTypeEntranceFlags entranceFlags,
      PlacementTypeLiquidFlags liquidFlags,
      bool mustMatchAll)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &basicFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &objectFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &terrainFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &floorFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &unitFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &wallFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &entranceFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &liquidFlags;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &mustMatchAll;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr__ctor_Public_Void_PlacementTypeBasicFlags_PlacementTypeObjectFlags_PlacementTypeTerrainFlags_PlacementTypeFloorFlags_PlacementTypeUnitFlags_PlacementTypeWallFlags_PlacementTypeEntranceFlags_PlacementTypeLiquidFlags_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 790047, RefRangeEnd = 790055, XrefRangeStart = 790047, XrefRangeEnd = 790047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEmpty()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 790056, RefRangeEnd = 790064, XrefRangeStart = 790055, XrefRangeEnd = 790056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckAnyOrAll(PlacementTypeData types)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &types;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr_CheckAnyOrAll_Public_Boolean_PlacementTypeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 790064, RefRangeEnd = 790067, XrefRangeStart = 790064, XrefRangeEnd = 790064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckAny(PlacementTypeData types)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &types;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr_CheckAny_Public_Boolean_PlacementTypeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 790067, RefRangeEnd = 790072, XrefRangeStart = 790067, XrefRangeEnd = 790067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CheckAll(PlacementTypeData types)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &types;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr_CheckAll_Public_Boolean_PlacementTypeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 790072, RefRangeEnd = 790076, XrefRangeStart = 790072, XrefRangeEnd = 790072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Merge(PlacementTypeData types)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &types;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr_Merge_Public_Void_PlacementTypeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790076, RefRangeEnd = 790077, XrefRangeStart = 790076, XrefRangeEnd = 790076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlacementTypeData GetOverlapping(PlacementTypeData types)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &types;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr_GetOverlapping_Public_PlacementTypeData_PlacementTypeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementTypeData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 790077, XrefRangeEnd = 790134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790158, RefRangeEnd = 790159, XrefRangeStart = 790134, XrefRangeEnd = 790158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ContentTestAttachmentFlagTags(
      TestContext<GameObject> context,
      List<ContentIssue> outIssues)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr_ContentTestAttachmentFlagTags_Public_Void_TestContext_1_GameObject_List_1_ContentIssue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790183, RefRangeEnd = 790184, XrefRangeStart = 790159, XrefRangeEnd = 790183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ContentTestReplaceableFlagTags(
      TestContext<GameObject> context,
      List<ContentIssue> outIssues)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr_ContentTestReplaceableFlagTags_Public_Void_TestContext_1_GameObject_List_1_ContentIssue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 790219, RefRangeEnd = 790220, XrefRangeStart = 790184, XrefRangeEnd = 790219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlacementTypeData GetAllTaggedAttachmentFlags()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr_GetAllTaggedAttachmentFlags_Public_Static_PlacementTypeData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlacementTypeData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 790277, RefRangeEnd = 790282, XrefRangeStart = 790220, XrefRangeEnd = 790277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckAttachmentFlags<T>(
      T enumValue,
      TestContext<GameObject> context,
      List<ContentIssue> outIssues)
      where T : Il2CppSystem.Enum
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) enumValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref enumValue;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.MethodInfoStoreGeneric_CheckAttachmentFlags_Private_Void_T_TestContext_1_GameObject_List_1_ContentIssue_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 790339, RefRangeEnd = 790344, XrefRangeStart = 790282, XrefRangeEnd = 790339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CheckReplaceableFlags<T>(
      T enumValue,
      TestContext<GameObject> context,
      List<ContentIssue> outIssues)
      where T : Il2CppSystem.Enum
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      // ISSUE: variable of a reference type
      T& local1;
      if (!typeof (T).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<T> local2 = (object) enumValue;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref enumValue;
      *numPtr2 = (System.IntPtr) ref local1;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.MethodInfoStoreGeneric_CheckReplaceableFlags_Private_Void_T_TestContext_1_GameObject_List_1_ContentIssue_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 790365, RefRangeEnd = 790370, XrefRangeStart = 790344, XrefRangeEnd = 790365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe long GetAttachmentFlags<T>()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.MethodInfoStoreGeneric_GetAttachmentFlags_Private_Static_Int64_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(long*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 790418, RefRangeEnd = 790420, XrefRangeStart = 790370, XrefRangeEnd = 790418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DebugLog()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlacementTypeData.NativeMethodInfoPtr_DebugLog_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlacementTypeData()
    {
      Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (PlacementTypeData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr);
      PlacementTypeData.NativeFieldInfoPtr_BasicFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, nameof (BasicFlags));
      PlacementTypeData.NativeFieldInfoPtr_ObjectFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, nameof (ObjectFlags));
      PlacementTypeData.NativeFieldInfoPtr_TerrainFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, nameof (TerrainFlags));
      PlacementTypeData.NativeFieldInfoPtr_FloorFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, nameof (FloorFlags));
      PlacementTypeData.NativeFieldInfoPtr_UnitFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, nameof (UnitFlags));
      PlacementTypeData.NativeFieldInfoPtr_WallFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, nameof (WallFlags));
      PlacementTypeData.NativeFieldInfoPtr_EntranceFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, nameof (EntranceFlags));
      PlacementTypeData.NativeFieldInfoPtr_LiquidFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, nameof (LiquidFlags));
      PlacementTypeData.NativeFieldInfoPtr_MustMatchAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, nameof (MustMatchAll));
      PlacementTypeData.NativeMethodInfoPtr__ctor_Public_Void_PlacementTypeBasicFlags_PlacementTypeObjectFlags_PlacementTypeTerrainFlags_PlacementTypeFloorFlags_PlacementTypeUnitFlags_PlacementTypeWallFlags_PlacementTypeEntranceFlags_PlacementTypeLiquidFlags_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669518);
      PlacementTypeData.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669519);
      PlacementTypeData.NativeMethodInfoPtr_CheckAnyOrAll_Public_Boolean_PlacementTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669520);
      PlacementTypeData.NativeMethodInfoPtr_CheckAny_Public_Boolean_PlacementTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669521);
      PlacementTypeData.NativeMethodInfoPtr_CheckAll_Public_Boolean_PlacementTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669522);
      PlacementTypeData.NativeMethodInfoPtr_Merge_Public_Void_PlacementTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669523);
      PlacementTypeData.NativeMethodInfoPtr_GetOverlapping_Public_PlacementTypeData_PlacementTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669524);
      PlacementTypeData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669525);
      PlacementTypeData.NativeMethodInfoPtr_ContentTestAttachmentFlagTags_Public_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669526);
      PlacementTypeData.NativeMethodInfoPtr_ContentTestReplaceableFlagTags_Public_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669527);
      PlacementTypeData.NativeMethodInfoPtr_GetAllTaggedAttachmentFlags_Public_Static_PlacementTypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669528);
      PlacementTypeData.NativeMethodInfoPtr_CheckAttachmentFlags_Private_Void_T_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669529);
      PlacementTypeData.NativeMethodInfoPtr_CheckReplaceableFlags_Private_Void_T_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669530);
      PlacementTypeData.NativeMethodInfoPtr_GetAttachmentFlags_Private_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669531);
      PlacementTypeData.NativeMethodInfoPtr_DebugLog_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, 100669532);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr, (System.IntPtr) ref this));
    }

    private sealed class MethodInfoStoreGeneric_CheckAttachmentFlags_Private_Void_T_TestContext_1_GameObject_List_1_ContentIssue_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlacementTypeData.NativeMethodInfoPtr_CheckAttachmentFlags_Private_Void_T_TestContext_1_GameObject_List_1_ContentIssue_0, Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_CheckReplaceableFlags_Private_Void_T_TestContext_1_GameObject_List_1_ContentIssue_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlacementTypeData.NativeMethodInfoPtr_CheckReplaceableFlags_Private_Void_T_TestContext_1_GameObject_List_1_ContentIssue_0, Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_GetAttachmentFlags_Private_Static_Int64_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlacementTypeData.NativeMethodInfoPtr_GetAttachmentFlags_Private_Static_Int64_0, Il2CppClassPointerStore<PlacementTypeData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
