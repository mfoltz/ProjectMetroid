// Decompiled with JetBrains decompiler
// Type: ProjectM.DropTableComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class DropTableComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DropTrigger;
    private static readonly IntPtr NativeFieldInfoPtr_DropTableAssets;
    private static readonly IntPtr NativeFieldInfoPtr_CrowdednessDropTableSettingsAsset;
    private static readonly IntPtr NativeFieldInfoPtr_CustomDropArc;
    private static readonly IntPtr NativeFieldInfoPtr_CustomDropArc_MinRange;
    private static readonly IntPtr NativeFieldInfoPtr_CustomDropArc_MaxRange;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_RunPrefabTest_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013769, XrefRangeEnd = 1013806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropTableComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013806, XrefRangeEnd = 1013831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_Shared_IChunkSummaryDataSource_FillTree(
      ChunkSummaryBuilder summary)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) summary);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropTableComponent.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013831, XrefRangeEnd = 1013858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RunPrefabTest(
      TestContext<GameObject> context,
      List<ContentIssue> outIssues)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropTableComponent.NativeMethodInfoPtr_RunPrefabTest_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DropTableComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropTableComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DropTableComponent()
    {
      Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropTableComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr);
      DropTableComponent.NativeFieldInfoPtr_DropTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr, nameof (DropTrigger));
      DropTableComponent.NativeFieldInfoPtr_DropTableAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr, nameof (DropTableAssets));
      DropTableComponent.NativeFieldInfoPtr_CrowdednessDropTableSettingsAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr, nameof (CrowdednessDropTableSettingsAsset));
      DropTableComponent.NativeFieldInfoPtr_CustomDropArc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr, nameof (CustomDropArc));
      DropTableComponent.NativeFieldInfoPtr_CustomDropArc_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr, nameof (CustomDropArc_MinRange));
      DropTableComponent.NativeFieldInfoPtr_CustomDropArc_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr, nameof (CustomDropArc_MaxRange));
      DropTableComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr, 100679032);
      DropTableComponent.NativeMethodInfoPtr_ProjectM_Shared_IChunkSummaryDataSource_FillTree_Private_Virtual_Final_New_Void_ChunkSummaryBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr, 100679033);
      DropTableComponent.NativeMethodInfoPtr_RunPrefabTest_Public_Static_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr, 100679034);
      DropTableComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropTableComponent>.NativeClassPtr, 100679035);
    }

    public DropTableComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe DropTriggerType DropTrigger
    {
      get
      {
        return *(DropTriggerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_DropTrigger));
      }
      [param: In] set
      {
        *(DropTriggerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_DropTrigger)) = value;
      }
    }

    public unsafe List<DropTableDataAsset> DropTableAssets
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_DropTableAssets));
        return pointer == IntPtr.Zero ? (List<DropTableDataAsset>) null : new List<DropTableDataAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_DropTableAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CrowdednessDropTableSettingsAsset CrowdednessDropTableSettingsAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_CrowdednessDropTableSettingsAsset));
        return pointer == IntPtr.Zero ? (CrowdednessDropTableSettingsAsset) null : new CrowdednessDropTableSettingsAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_CrowdednessDropTableSettingsAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> CustomDropArc
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_CustomDropArc));
        return pointer == IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_CustomDropArc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float CustomDropArc_MinRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_CustomDropArc_MinRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_CustomDropArc_MinRange)) = value;
      }
    }

    public unsafe float CustomDropArc_MaxRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_CustomDropArc_MaxRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropTableComponent.NativeFieldInfoPtr_CustomDropArc_MaxRange)) = value;
      }
    }
  }
}
