// Decompiled with JetBrains decompiler
// Type: ProjectM.HybridRagdollComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.ContentTesting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class HybridRagdollComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Animator;
    private static readonly IntPtr NativeFieldInfoPtr_RagdollDriver;
    private static readonly IntPtr NativeFieldInfoPtr_BoneTransforms;
    private static readonly IntPtr NativeFieldInfoPtr_ResetBoneTransforms;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0;
    private static readonly IntPtr NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsParentFor_Private_Static_Boolean_Transform_Transform_0;
    private static readonly IntPtr NativeMethodInfoPtr_DeclareConversionDependencies_Public_Virtual_Final_New_Void_ConvertOnDemandConversionSystem_Object_0;
    private static readonly IntPtr NativeMethodInfoPtr_ToggleAnimator_Public_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063410, XrefRangeEnd = 1063417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridRagdollComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063417, XrefRangeEnd = 1063432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void AddComponent(
      World world,
      PrefabLookupMap prefabLookupMap,
      Entity hybridEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &prefabLookupMap;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &hybridEntity;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridRagdollComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1063451, RefRangeEnd = 1063452, XrefRangeStart = 1063432, XrefRangeEnd = 1063451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasContentErrors()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridRagdollComponent.NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe TestGroupFlags ProjectM\u002EContentTesting\u002EIGameObjectContentTest\u002ETestGroups
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridRagdollComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TestGroupFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_ContentTesting_IGameObjectContentTest_Test(
      TestContext<GameObject> context,
      List<ContentIssue> outIssues)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridRagdollComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063452, XrefRangeEnd = 1063459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsParentFor(Transform parent, Transform transform)
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridRagdollComponent.NativeMethodInfoPtr_IsParentFor_Private_Static_Boolean_Transform_Transform_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1063459, XrefRangeEnd = 1063471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void DeclareConversionDependencies(
      ConvertOnDemandConversionSystem convertOnDemandSystem,
      UnityEngine.Object referenceOwner)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) convertOnDemandSystem);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) referenceOwner);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridRagdollComponent.NativeMethodInfoPtr_DeclareConversionDependencies_Public_Virtual_Final_New_Void_ConvertOnDemandConversionSystem_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1063513, RefRangeEnd = 1063515, XrefRangeStart = 1063471, XrefRangeEnd = 1063513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ToggleAnimator(bool enable)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &enable;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridRagdollComponent.NativeMethodInfoPtr_ToggleAnimator_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridRagdollComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridRagdollComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridRagdollComponent()
    {
      Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HybridRagdollComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr);
      HybridRagdollComponent.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, nameof (Animator));
      HybridRagdollComponent.NativeFieldInfoPtr_RagdollDriver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, nameof (RagdollDriver));
      HybridRagdollComponent.NativeFieldInfoPtr_BoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, nameof (BoneTransforms));
      HybridRagdollComponent.NativeFieldInfoPtr_ResetBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, nameof (ResetBoneTransforms));
      HybridRagdollComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, 100683492);
      HybridRagdollComponent.NativeMethodInfoPtr_AddComponent_Public_Virtual_Final_New_Void_World_PrefabLookupMap_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, 100683493);
      HybridRagdollComponent.NativeMethodInfoPtr_HasContentErrors_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, 100683494);
      HybridRagdollComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_get_TestGroups_Private_Virtual_Final_New_get_TestGroupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, 100683495);
      HybridRagdollComponent.NativeMethodInfoPtr_ProjectM_ContentTesting_IGameObjectContentTest_Test_Private_Virtual_Final_New_Void_TestContext_1_GameObject_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, 100683496);
      HybridRagdollComponent.NativeMethodInfoPtr_IsParentFor_Private_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, 100683497);
      HybridRagdollComponent.NativeMethodInfoPtr_DeclareConversionDependencies_Public_Virtual_Final_New_Void_ConvertOnDemandConversionSystem_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, 100683498);
      HybridRagdollComponent.NativeMethodInfoPtr_ToggleAnimator_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, 100683499);
      HybridRagdollComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridRagdollComponent>.NativeClassPtr, 100683500);
    }

    public HybridRagdollComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Animator Animator
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridRagdollComponent.NativeFieldInfoPtr_Animator));
        return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridRagdollComponent.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RagdollDriverComponent RagdollDriver
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridRagdollComponent.NativeFieldInfoPtr_RagdollDriver));
        return pointer == IntPtr.Zero ? (RagdollDriverComponent) null : new RagdollDriverComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridRagdollComponent.NativeFieldInfoPtr_RagdollDriver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Transform> BoneTransforms
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridRagdollComponent.NativeFieldInfoPtr_BoneTransforms));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : new Il2CppReferenceArray<Transform>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridRagdollComponent.NativeFieldInfoPtr_BoneTransforms), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ResetTransform> ResetBoneTransforms
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HybridRagdollComponent.NativeFieldInfoPtr_ResetBoneTransforms));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<ResetTransform>) null : new Il2CppReferenceArray<ResetTransform>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HybridRagdollComponent.NativeFieldInfoPtr_ResetBoneTransforms), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
