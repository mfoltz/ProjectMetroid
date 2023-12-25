// Decompiled with JetBrains decompiler
// Type: ProjectM.ResearchstationAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Malee;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ResearchstationAuthoring : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DiscoverCosts;
    private static readonly System.IntPtr NativeFieldInfoPtr_Techs;
    private static readonly System.IntPtr NativeFieldInfoPtr_Bonuses;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResearchCompletedGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequence;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UsedTechs_Public_Virtual_Final_New_get_List_1_TechDataAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe List<TechDataAsset> UsedTechs
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065338, XrefRangeEnd = 1065350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResearchstationAuthoring.NativeMethodInfoPtr_get_UsedTechs_Public_Virtual_Final_New_get_List_1_TechDataAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<TechDataAsset>) null : new List<TechDataAsset>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065350, XrefRangeEnd = 1065410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResearchstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065410, XrefRangeEnd = 1065423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ResearchstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ResearchstationAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ResearchstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ResearchstationAuthoring()
    {
      Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ResearchstationAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr);
      ResearchstationAuthoring.NativeFieldInfoPtr_DiscoverCosts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, nameof (DiscoverCosts));
      ResearchstationAuthoring.NativeFieldInfoPtr_Techs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, nameof (Techs));
      ResearchstationAuthoring.NativeFieldInfoPtr_Bonuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, nameof (Bonuses));
      ResearchstationAuthoring.NativeFieldInfoPtr_ResearchCompletedGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, nameof (ResearchCompletedGuid));
      ResearchstationAuthoring.NativeFieldInfoPtr_ActiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, nameof (ActiveSequence));
      ResearchstationAuthoring.NativeFieldInfoPtr_InactiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, nameof (InactiveSequence));
      ResearchstationAuthoring.NativeMethodInfoPtr_get_UsedTechs_Public_Virtual_Final_New_get_List_1_TechDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, 100683723);
      ResearchstationAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, 100683724);
      ResearchstationAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, 100683725);
      ResearchstationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, 100683726);
    }

    public ResearchstationAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<ResearchstationAuthoring.DiscoverRequirement> DiscoverCosts
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_DiscoverCosts));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ResearchstationAuthoring.DiscoverRequirement>) null : new Il2CppReferenceArray<ResearchstationAuthoring.DiscoverRequirement>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_DiscoverCosts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ResearchstationAuthoring.TechArray Techs
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_Techs));
        return pointer == System.IntPtr.Zero ? (ResearchstationAuthoring.TechArray) null : new ResearchstationAuthoring.TechArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_Techs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ResearchstationAuthoring.StationBonusArray Bonuses
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_Bonuses));
        return pointer == System.IntPtr.Zero ? (ResearchstationAuthoring.StationBonusArray) null : new ResearchstationAuthoring.StationBonusArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_Bonuses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField ResearchCompletedGuid
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_ResearchCompletedGuid));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_ResearchCompletedGuid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField ActiveSequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_ActiveSequence));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_ActiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField InactiveSequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_InactiveSequence));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.NativeFieldInfoPtr_InactiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class StationBonusArray : ReorderableArray<StationBonusDataComponent>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065332, XrefRangeEnd = 1065335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe StationBonusArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchstationAuthoring.StationBonusArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ResearchstationAuthoring.StationBonusArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static StationBonusArray()
      {
        Il2CppClassPointerStore<ResearchstationAuthoring.StationBonusArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, nameof (StationBonusArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchstationAuthoring.StationBonusArray>.NativeClassPtr);
        ResearchstationAuthoring.StationBonusArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationAuthoring.StationBonusArray>.NativeClassPtr, 100683727);
      }

      public StationBonusArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class TechArray : ReorderableArray<TechDataAsset>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065335, XrefRangeEnd = 1065338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TechArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResearchstationAuthoring.TechArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ResearchstationAuthoring.TechArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static TechArray()
      {
        Il2CppClassPointerStore<ResearchstationAuthoring.TechArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, nameof (TechArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchstationAuthoring.TechArray>.NativeClassPtr);
        ResearchstationAuthoring.TechArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResearchstationAuthoring.TechArray>.NativeClassPtr, 100683728);
      }

      public TechArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public sealed class DiscoverRequirement : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Item;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

      static DiscoverRequirement()
      {
        Il2CppClassPointerStore<ResearchstationAuthoring.DiscoverRequirement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResearchstationAuthoring>.NativeClassPtr, nameof (DiscoverRequirement));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResearchstationAuthoring.DiscoverRequirement>.NativeClassPtr);
        ResearchstationAuthoring.DiscoverRequirement.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationAuthoring.DiscoverRequirement>.NativeClassPtr, nameof (Item));
        ResearchstationAuthoring.DiscoverRequirement.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResearchstationAuthoring.DiscoverRequirement>.NativeClassPtr, nameof (Amount));
      }

      public DiscoverRequirement(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public DiscoverRequirement()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ResearchstationAuthoring.DiscoverRequirement>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResearchstationAuthoring.DiscoverRequirement>.NativeClassPtr, data));
      }

      public unsafe ItemDataComponent Item
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.DiscoverRequirement.NativeFieldInfoPtr_Item));
          return pointer == System.IntPtr.Zero ? (ItemDataComponent) null : new ItemDataComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.DiscoverRequirement.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.DiscoverRequirement.NativeFieldInfoPtr_Amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ResearchstationAuthoring.DiscoverRequirement.NativeFieldInfoPtr_Amount)) = value;
        }
      }
    }
  }
}
