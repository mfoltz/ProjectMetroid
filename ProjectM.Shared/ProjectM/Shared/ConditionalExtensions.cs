// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionalExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Shared
{
  public static class ConditionalExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToConditionBlob_Public_Static_BlobAssetReference_1_ConditionBlob_GameplayConditionGroupData_Editor_Parent_MonoBehaviour_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToManagedConditionalGroup_Internal_Static_ConditionalGroupAuthoring_GameplayConditionGroupData_Editor_Parent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToManagedConditionalGroup_Internal_Static_ConditionalGroupAuthoring_GameplayConditionGroupData_Editor_Il2CppReferenceArray_1_GameplayConditionGroupData_Editor_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToManagedConditional_Internal_Static_ConditionalAuthoring_GameplayConditionComponentData_Editor_0;

    [CallerCount(48)]
    [CachedScanResults(RefRangeStart = 799953, RefRangeEnd = 800001, XrefRangeStart = 799950, XrefRangeEnd = 799953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BlobAssetReference<ConditionBlob> ConvertToConditionBlob(
      this GameplayConditionGroupData_Editor_Parent parent,
      MonoBehaviour builderComponent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) builderComponent);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalExtensions.NativeMethodInfoPtr_ConvertToConditionBlob_Public_Static_BlobAssetReference_1_ConditionBlob_GameplayConditionGroupData_Editor_Parent_MonoBehaviour_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<ConditionBlob>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800003, RefRangeEnd = 800004, XrefRangeStart = 800001, XrefRangeEnd = 800003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ConditionalGroupAuthoring ConvertToManagedConditionalGroup(
      this GameplayConditionGroupData_Editor_Parent parent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalExtensions.NativeMethodInfoPtr_ConvertToManagedConditionalGroup_Internal_Static_ConditionalGroupAuthoring_GameplayConditionGroupData_Editor_Parent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ConditionalGroupAuthoring) null : new ConditionalGroupAuthoring(pointer);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 800073, RefRangeEnd = 800077, XrefRangeStart = 800004, XrefRangeEnd = 800073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ConditionalGroupAuthoring ConvertToManagedConditionalGroup(
      this GameplayConditionGroupData_Editor root,
      Il2CppReferenceArray<GameplayConditionGroupData_Editor> subGroups)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) root);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) subGroups);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalExtensions.NativeMethodInfoPtr_ConvertToManagedConditionalGroup_Internal_Static_ConditionalGroupAuthoring_GameplayConditionGroupData_Editor_Il2CppReferenceArray_1_GameplayConditionGroupData_Editor_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ConditionalGroupAuthoring) null : new ConditionalGroupAuthoring(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800077, XrefRangeEnd = 800084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ConditionalAuthoring ConvertToManagedConditional(
      this GameplayConditionComponentData_Editor condition)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) condition);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalExtensions.NativeMethodInfoPtr_ConvertToManagedConditional_Internal_Static_ConditionalAuthoring_GameplayConditionComponentData_Editor_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ConditionalAuthoring) null : new ConditionalAuthoring(pointer);
    }

    static ConditionalExtensions()
    {
      Il2CppClassPointerStore<ConditionalExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ConditionalExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalExtensions>.NativeClassPtr);
      ConditionalExtensions.NativeMethodInfoPtr_ConvertToConditionBlob_Public_Static_BlobAssetReference_1_ConditionBlob_GameplayConditionGroupData_Editor_Parent_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExtensions>.NativeClassPtr, 100670575);
      ConditionalExtensions.NativeMethodInfoPtr_ConvertToManagedConditionalGroup_Internal_Static_ConditionalGroupAuthoring_GameplayConditionGroupData_Editor_Parent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExtensions>.NativeClassPtr, 100670576);
      ConditionalExtensions.NativeMethodInfoPtr_ConvertToManagedConditionalGroup_Internal_Static_ConditionalGroupAuthoring_GameplayConditionGroupData_Editor_Il2CppReferenceArray_1_GameplayConditionGroupData_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExtensions>.NativeClassPtr, 100670577);
      ConditionalExtensions.NativeMethodInfoPtr_ConvertToManagedConditional_Internal_Static_ConditionalAuthoring_GameplayConditionComponentData_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalExtensions>.NativeClassPtr, 100670578);
    }

    public ConditionalExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
