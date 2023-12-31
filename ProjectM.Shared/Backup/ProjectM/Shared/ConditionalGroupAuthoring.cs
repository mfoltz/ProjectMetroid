// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionalGroupAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Shared
{
  [Serializable]
  public class ConditionalGroupAuthoring : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LogicGate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditionals;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionalGroups;
    private static readonly System.IntPtr NativeFieldInfoPtr_SharedConditionals;
    private static readonly System.IntPtr NativeFieldInfoPtr__Count_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AllGroups_Private_get_IEnumerable_1_ConditionalGroupAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AllConditionals_Private_get_IEnumerable_1_IConditionalAuthoring_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateCount_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Build_Public_BlobAssetReference_1_ConditionBlob_MonoBehaviour_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Build_Public_NativeArray_1_ConditionElement_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_IConditionalAuthoring_Build_Private_Virtual_Final_New_Void_byref_NativeArray_1_ConditionElement_byref_Int32_Int32_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildString_Public_Void_StringBuilder_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass17_0_PDM_0;

    public unsafe IEnumerable<ConditionalGroupAuthoring> AllGroups
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 800107, RefRangeEnd = 800112, XrefRangeStart = 800085, XrefRangeEnd = 800107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.NativeMethodInfoPtr_get_AllGroups_Private_get_IEnumerable_1_ConditionalGroupAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<ConditionalGroupAuthoring>) null : new IEnumerable<ConditionalGroupAuthoring>(pointer);
      }
    }

    public unsafe IEnumerable<IConditionalAuthoring> AllConditionals
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800112, XrefRangeEnd = 800116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.NativeMethodInfoPtr_get_AllConditionals_Private_get_IEnumerable_1_IConditionalAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<IConditionalAuthoring>) null : new IEnumerable<IConditionalAuthoring>(pointer);
      }
    }

    public virtual unsafe int Count
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 32697, RefRangeEnd = 32698, XrefRangeStart = 32697, XrefRangeEnd = 32698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 42947, RefRangeEnd = 42948, XrefRangeStart = 42947, XrefRangeEnd = 42948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800136, RefRangeEnd = 800137, XrefRangeStart = 800116, XrefRangeEnd = 800136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CalculateCount()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.NativeMethodInfoPtr_CalculateCount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800161, RefRangeEnd = 800162, XrefRangeStart = 800137, XrefRangeEnd = 800161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BlobAssetReference<ConditionBlob> Build(MonoBehaviour debugComponentInfo = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) debugComponentInfo);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.NativeMethodInfoPtr_Build_Public_BlobAssetReference_1_ConditionBlob_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BlobAssetReference<ConditionBlob>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 800193, RefRangeEnd = 800195, XrefRangeStart = 800162, XrefRangeEnd = 800193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NativeArray<ConditionElement> Build(Allocator allocator)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.NativeMethodInfoPtr_Build_Public_NativeArray_1_ConditionElement_Allocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(NativeArray<ConditionElement>*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800195, XrefRangeEnd = 800287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_Shared_IConditionalAuthoring_Build(
      ref NativeArray<ConditionElement> outConditions,
      ref int nextIndex,
      int groupSuccessIndex,
      int groupFailureIndex,
      ref NativeList<int> successIndices,
      ref NativeList<int> failureIndices)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref outConditions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref nextIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &groupSuccessIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &groupFailureIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref successIndices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref failureIndices;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IConditionalAuthoring_Build_Private_Virtual_Final_New_Void_byref_NativeArray_1_ConditionElement_byref_Int32_Int32_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800287, XrefRangeEnd = 800293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConditionalGroupAuthoring.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800308, RefRangeEnd = 800309, XrefRangeStart = 800293, XrefRangeEnd = 800308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildString(StringBuilder builder, int indentation = 0)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) builder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &indentation;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.NativeMethodInfoPtr_BuildString_Public_Void_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800309, XrefRangeEnd = 800322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionalGroupAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800322, XrefRangeEnd = 800337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Private_Void_byref___c__DisplayClass17_0_PDM_0(
      ref ConditionalGroupAuthoring.__c__DisplayClass17_0 _param1)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param1);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass17_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConditionalGroupAuthoring()
    {
      Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ConditionalGroupAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr);
      ConditionalGroupAuthoring.NativeFieldInfoPtr_LogicGate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, nameof (LogicGate));
      ConditionalGroupAuthoring.NativeFieldInfoPtr_Conditionals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, nameof (Conditionals));
      ConditionalGroupAuthoring.NativeFieldInfoPtr_ConditionalGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, nameof (ConditionalGroups));
      ConditionalGroupAuthoring.NativeFieldInfoPtr_SharedConditionals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, nameof (SharedConditionals));
      ConditionalGroupAuthoring.NativeFieldInfoPtr__Count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, "<Count>k__BackingField");
      ConditionalGroupAuthoring.NativeMethodInfoPtr_get_AllGroups_Private_get_IEnumerable_1_ConditionalGroupAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670583);
      ConditionalGroupAuthoring.NativeMethodInfoPtr_get_AllConditionals_Private_get_IEnumerable_1_IConditionalAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670584);
      ConditionalGroupAuthoring.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670585);
      ConditionalGroupAuthoring.NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670586);
      ConditionalGroupAuthoring.NativeMethodInfoPtr_CalculateCount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670587);
      ConditionalGroupAuthoring.NativeMethodInfoPtr_Build_Public_BlobAssetReference_1_ConditionBlob_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670588);
      ConditionalGroupAuthoring.NativeMethodInfoPtr_Build_Public_NativeArray_1_ConditionElement_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670589);
      ConditionalGroupAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IConditionalAuthoring_Build_Private_Virtual_Final_New_Void_byref_NativeArray_1_ConditionElement_byref_Int32_Int32_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670590);
      ConditionalGroupAuthoring.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670591);
      ConditionalGroupAuthoring.NativeMethodInfoPtr_BuildString_Public_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670592);
      ConditionalGroupAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670593);
      ConditionalGroupAuthoring.NativeMethodInfoPtr_Method_Private_Void_byref___c__DisplayClass17_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, 100670594);
    }

    public ConditionalGroupAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ConditionalGroupLogicGate LogicGate
    {
      get
      {
        return *(ConditionalGroupLogicGate*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.NativeFieldInfoPtr_LogicGate));
      }
      [param: In] set
      {
        *(ConditionalGroupLogicGate*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.NativeFieldInfoPtr_LogicGate)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<ConditionalAuthoring> Conditionals
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.NativeFieldInfoPtr_Conditionals));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ConditionalAuthoring>) null : new Il2CppReferenceArray<ConditionalAuthoring>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.NativeFieldInfoPtr_Conditionals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<ConditionalGroupAuthoring> ConditionalGroups
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.NativeFieldInfoPtr_ConditionalGroups));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ConditionalGroupAuthoring>) null : new Il2CppReferenceArray<ConditionalGroupAuthoring>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.NativeFieldInfoPtr_ConditionalGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<SharedConditionalAsset> SharedConditionals
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.NativeFieldInfoPtr_SharedConditionals));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SharedConditionalAsset>) null : new Il2CppReferenceArray<SharedConditionalAsset>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.NativeFieldInfoPtr_SharedConditionals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _Count_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.NativeFieldInfoPtr__Count_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.NativeFieldInfoPtr__Count_k__BackingField)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Shared.ConditionalGroupAuthoring/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__12_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_AllGroups_b__5_0_Internal_ConditionalGroupAuthoring_SharedConditionalAsset_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__CalculateCount_b__12_0_Internal_Int32_ConditionalGroupAuthoring_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe ConditionalGroupAuthoring _get_AllGroups_b__5_0(
        SharedConditionalAsset sharedConditional)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sharedConditional);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.__c.NativeMethodInfoPtr__get_AllGroups_b__5_0_Internal_ConditionalGroupAuthoring_SharedConditionalAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ConditionalGroupAuthoring) null : new ConditionalGroupAuthoring(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800084, XrefRangeEnd = 800085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _CalculateCount_b__12_0(ConditionalGroupAuthoring group)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalGroupAuthoring.__c.NativeMethodInfoPtr__CalculateCount_b__12_0_Internal_Int32_ConditionalGroupAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<ConditionalGroupAuthoring.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c>.NativeClassPtr);
        ConditionalGroupAuthoring.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c>.NativeClassPtr, "<>9");
        ConditionalGroupAuthoring.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c>.NativeClassPtr, "<>9__5_0");
        ConditionalGroupAuthoring.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c>.NativeClassPtr, "<>9__12_0");
        ConditionalGroupAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c>.NativeClassPtr, 100670596);
        ConditionalGroupAuthoring.__c.NativeMethodInfoPtr__get_AllGroups_b__5_0_Internal_ConditionalGroupAuthoring_SharedConditionalAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c>.NativeClassPtr, 100670597);
        ConditionalGroupAuthoring.__c.NativeMethodInfoPtr__CalculateCount_b__12_0_Internal_Int32_ConditionalGroupAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c>.NativeClassPtr, 100670598);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ConditionalGroupAuthoring.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ConditionalGroupAuthoring.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ConditionalGroupAuthoring.__c) null : new ConditionalGroupAuthoring.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ConditionalGroupAuthoring.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<SharedConditionalAsset, ConditionalGroupAuthoring> __9__5_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ConditionalGroupAuthoring.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SharedConditionalAsset, ConditionalGroupAuthoring>) null : new Il2CppSystem.Func<SharedConditionalAsset, ConditionalGroupAuthoring>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ConditionalGroupAuthoring.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ConditionalGroupAuthoring, int> __9__12_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ConditionalGroupAuthoring.__c.NativeFieldInfoPtr___9__12_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ConditionalGroupAuthoring, int>) null : new Il2CppSystem.Func<ConditionalGroupAuthoring, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ConditionalGroupAuthoring.__c.NativeFieldInfoPtr___9__12_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.ConditionalGroupAuthoring/<>c__DisplayClass17_0")]
    public sealed class __c__DisplayClass17_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_builder;
      private static readonly System.IntPtr NativeFieldInfoPtr_indentation;
      private static readonly System.IntPtr NativeFieldInfoPtr_hasWritten;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

      static __c__DisplayClass17_0()
      {
        Il2CppClassPointerStore<ConditionalGroupAuthoring.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConditionalGroupAuthoring>.NativeClassPtr, "<>c__DisplayClass17_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c__DisplayClass17_0>.NativeClassPtr);
        ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c__DisplayClass17_0>.NativeClassPtr, nameof (builder));
        ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr_indentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c__DisplayClass17_0>.NativeClassPtr, nameof (indentation));
        ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr_hasWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c__DisplayClass17_0>.NativeClassPtr, nameof (hasWritten));
        ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
      }

      public __c__DisplayClass17_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass17_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c__DisplayClass17_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionalGroupAuthoring.__c__DisplayClass17_0>.NativeClassPtr, data));
      }

      public unsafe StringBuilder builder
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr_builder));
          return pointer == System.IntPtr.Zero ? (StringBuilder) null : new StringBuilder(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int indentation
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr_indentation));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr_indentation)) = value;
        }
      }

      public unsafe bool hasWritten
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr_hasWritten));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr_hasWritten)) = value;
        }
      }

      public unsafe ConditionalGroupAuthoring __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ConditionalGroupAuthoring) null : new ConditionalGroupAuthoring(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionalGroupAuthoring.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
