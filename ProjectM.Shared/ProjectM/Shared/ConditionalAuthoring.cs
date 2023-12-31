// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionalAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Shared
{
  [Serializable]
  public class ConditionalAuthoring : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_InvertCheck;
    private static readonly System.IntPtr NativeFieldInfoPtr_BoolValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMod;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponTypeValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitHealthType;
    private static readonly System.IntPtr NativeFieldInfoPtr_AiPointOfInterestType;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumberComparison;
    private static readonly System.IntPtr NativeFieldInfoPtr_FloatValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_IntValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffModificationTypes;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_IConditionalAuthoring_get_Count_Private_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_Shared_IConditionalAuthoring_Build_Private_Virtual_Final_New_Void_byref_NativeArray_1_ConditionElement_byref_Int32_Int32_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Build_Public_ConditionElement_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe int ProjectM\u002EShared\u002EIConditionalAuthoring\u002ECount
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IConditionalAuthoring_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800337, XrefRangeEnd = 800343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ProjectM_Shared_IConditionalAuthoring_Build(
      ref NativeArray<ConditionElement> outConditions,
      ref int nextIndex,
      int successIndex,
      int failureIndex,
      ref NativeList<int> successIndices,
      ref NativeList<int> failureIndices)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) ref outConditions;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref nextIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &successIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &failureIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref successIndices;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref failureIndices;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IConditionalAuthoring_Build_Private_Virtual_Final_New_Void_byref_NativeArray_1_ConditionElement_byref_Int32_Int32_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800343, XrefRangeEnd = 800344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionElement Build(int successIndex, int failureIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &successIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &failureIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionalAuthoring.NativeMethodInfoPtr_Build_Public_ConditionElement_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ConditionElement*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800344, XrefRangeEnd = 800389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConditionalAuthoring.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionalAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConditionalAuthoring()
    {
      Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ConditionalAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr);
      ConditionalAuthoring.NativeFieldInfoPtr_ConditionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (ConditionTarget));
      ConditionalAuthoring.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (Type));
      ConditionalAuthoring.NativeFieldInfoPtr_InvertCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (InvertCheck));
      ConditionalAuthoring.NativeFieldInfoPtr_BoolValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (BoolValue));
      ConditionalAuthoring.NativeFieldInfoPtr_PrefabValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (PrefabValue));
      ConditionalAuthoring.NativeFieldInfoPtr_SpellMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (SpellMod));
      ConditionalAuthoring.NativeFieldInfoPtr_EntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (EntityCategory));
      ConditionalAuthoring.NativeFieldInfoPtr_WeaponTypeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (WeaponTypeValue));
      ConditionalAuthoring.NativeFieldInfoPtr_UnitHealthType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (UnitHealthType));
      ConditionalAuthoring.NativeFieldInfoPtr_AiPointOfInterestType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (AiPointOfInterestType));
      ConditionalAuthoring.NativeFieldInfoPtr_NumberComparison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (NumberComparison));
      ConditionalAuthoring.NativeFieldInfoPtr_FloatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (FloatValue));
      ConditionalAuthoring.NativeFieldInfoPtr_IntValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (IntValue));
      ConditionalAuthoring.NativeFieldInfoPtr_BuffCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (BuffCategory));
      ConditionalAuthoring.NativeFieldInfoPtr_BuffModificationTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, nameof (BuffModificationTypes));
      ConditionalAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IConditionalAuthoring_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, 100670599);
      ConditionalAuthoring.NativeMethodInfoPtr_ProjectM_Shared_IConditionalAuthoring_Build_Private_Virtual_Final_New_Void_byref_NativeArray_1_ConditionElement_byref_Int32_Int32_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, 100670600);
      ConditionalAuthoring.NativeMethodInfoPtr_Build_Public_ConditionElement_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, 100670601);
      ConditionalAuthoring.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, 100670602);
      ConditionalAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalAuthoring>.NativeClassPtr, 100670603);
    }

    public ConditionalAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ConditionTarget ConditionTarget
    {
      get
      {
        return *(ConditionTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_ConditionTarget));
      }
      [param: In] set
      {
        *(ConditionTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_ConditionTarget)) = value;
      }
    }

    public unsafe ConditionSource Type
    {
      get
      {
        return *(ConditionSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(ConditionSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe bool InvertCheck
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_InvertCheck));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_InvertCheck)) = value;
      }
    }

    public unsafe bool BoolValue
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_BoolValue));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_BoolValue)) = value;
      }
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> PrefabValue
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_PrefabValue));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_PrefabValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<SpellModAsset> SpellMod
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_SpellMod));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<SpellModAsset>) null : new WeakAssetReference<SpellModAsset>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_SpellMod), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityCategory EntityCategory
    {
      get
      {
        return *(EntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_EntityCategory));
      }
      [param: In] set
      {
        *(EntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_EntityCategory)) = value;
      }
    }

    public unsafe WeaponType WeaponTypeValue
    {
      get
      {
        return *(WeaponType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_WeaponTypeValue));
      }
      [param: In] set
      {
        *(WeaponType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_WeaponTypeValue)) = value;
      }
    }

    public unsafe UnitBaseStatsType UnitHealthType
    {
      get
      {
        return *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_UnitHealthType));
      }
      [param: In] set
      {
        *(UnitBaseStatsType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_UnitHealthType)) = value;
      }
    }

    public unsafe AiPointOfInterestType AiPointOfInterestType
    {
      get
      {
        return *(AiPointOfInterestType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_AiPointOfInterestType));
      }
      [param: In] set
      {
        *(AiPointOfInterestType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_AiPointOfInterestType)) = value;
      }
    }

    public unsafe ConditionTypes NumberComparison
    {
      get
      {
        return *(ConditionTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_NumberComparison));
      }
      [param: In] set
      {
        *(ConditionTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_NumberComparison)) = value;
      }
    }

    public unsafe float FloatValue
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_FloatValue));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_FloatValue)) = value;
      }
    }

    public unsafe int IntValue
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_IntValue));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_IntValue)) = value;
      }
    }

    public unsafe long BuffCategory
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_BuffCategory));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_BuffCategory)) = value;
      }
    }

    public unsafe long BuffModificationTypes
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_BuffModificationTypes));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalAuthoring.NativeFieldInfoPtr_BuffModificationTypes)) = value;
      }
    }
  }
}
