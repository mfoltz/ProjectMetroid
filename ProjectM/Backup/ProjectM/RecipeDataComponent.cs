// Decompiled with JetBrains decompiler
// Type: ProjectM.RecipeDataComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class RecipeDataComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OutputItems;
    private static readonly System.IntPtr NativeFieldInfoPtr_Requirements;
    private static readonly System.IntPtr NativeFieldInfoPtr_CraftDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_HudSortingOrder;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_HideInStation;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreServerSettings;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992908, XrefRangeEnd = 992966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(RecipeDataComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnBeforeSerialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecipeDataComponent.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnAfterDeserialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecipeDataComponent.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992966, XrefRangeEnd = 992967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RecipeDataComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecipeDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RecipeDataComponent()
    {
      Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RecipeDataComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr);
      RecipeDataComponent.NativeFieldInfoPtr_OutputItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, nameof (OutputItems));
      RecipeDataComponent.NativeFieldInfoPtr_Requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, nameof (Requirements));
      RecipeDataComponent.NativeFieldInfoPtr_CraftDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, nameof (CraftDuration));
      RecipeDataComponent.NativeFieldInfoPtr_HudSortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, nameof (HudSortingOrder));
      RecipeDataComponent.NativeFieldInfoPtr_AlwaysUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, nameof (AlwaysUnlocked));
      RecipeDataComponent.NativeFieldInfoPtr_HideInStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, nameof (HideInStation));
      RecipeDataComponent.NativeFieldInfoPtr_IgnoreServerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, nameof (IgnoreServerSettings));
      RecipeDataComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, 100676660);
      RecipeDataComponent.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, 100676661);
      RecipeDataComponent.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, 100676662);
      RecipeDataComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, 100676663);
    }

    public RecipeDataComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe RecipeDataComponent.OutputEntryArray OutputItems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_OutputItems));
        return pointer == System.IntPtr.Zero ? (RecipeDataComponent.OutputEntryArray) null : new RecipeDataComponent.OutputEntryArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_OutputItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RecipeDataComponent.RequirementEntryArray Requirements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_Requirements));
        return pointer == System.IntPtr.Zero ? (RecipeDataComponent.RequirementEntryArray) null : new RecipeDataComponent.RequirementEntryArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_Requirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float CraftDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_CraftDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_CraftDuration)) = value;
      }
    }

    public unsafe int HudSortingOrder
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_HudSortingOrder));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_HudSortingOrder)) = value;
      }
    }

    public unsafe bool AlwaysUnlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_AlwaysUnlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_AlwaysUnlocked)) = value;
      }
    }

    public unsafe bool HideInStation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_HideInStation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_HideInStation)) = value;
      }
    }

    public unsafe bool IgnoreServerSettings
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_IgnoreServerSettings));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.NativeFieldInfoPtr_IgnoreServerSettings)) = value;
      }
    }

    [Serializable]
    public class OutputEntryArray : ReorderableArray<RecipeDataComponent.RecipeOutputEntry>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992902, XrefRangeEnd = 992905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe OutputEntryArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeDataComponent.OutputEntryArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RecipeDataComponent.OutputEntryArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static OutputEntryArray()
      {
        Il2CppClassPointerStore<RecipeDataComponent.OutputEntryArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, nameof (OutputEntryArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDataComponent.OutputEntryArray>.NativeClassPtr);
        RecipeDataComponent.OutputEntryArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataComponent.OutputEntryArray>.NativeClassPtr, 100676664);
      }

      public OutputEntryArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class RequirementEntryArray : ReorderableArray<RecipeDataComponent.RecipeRequirement>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992905, XrefRangeEnd = 992908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe RequirementEntryArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeDataComponent.RequirementEntryArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RecipeDataComponent.RequirementEntryArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static RequirementEntryArray()
      {
        Il2CppClassPointerStore<RecipeDataComponent.RequirementEntryArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, nameof (RequirementEntryArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDataComponent.RequirementEntryArray>.NativeClassPtr);
        RecipeDataComponent.RequirementEntryArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeDataComponent.RequirementEntryArray>.NativeClassPtr, 100676665);
      }

      public RequirementEntryArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public sealed class RecipeRequirement : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Item;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

      static RecipeRequirement()
      {
        Il2CppClassPointerStore<RecipeDataComponent.RecipeRequirement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, nameof (RecipeRequirement));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDataComponent.RecipeRequirement>.NativeClassPtr);
        RecipeDataComponent.RecipeRequirement.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataComponent.RecipeRequirement>.NativeClassPtr, nameof (Item));
        RecipeDataComponent.RecipeRequirement.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataComponent.RecipeRequirement>.NativeClassPtr, nameof (Amount));
      }

      public RecipeRequirement(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public RecipeRequirement()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RecipeDataComponent.RecipeRequirement>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RecipeDataComponent.RecipeRequirement>.NativeClassPtr, data));
      }

      public unsafe ItemDataComponent Item
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.RecipeRequirement.NativeFieldInfoPtr_Item));
          return pointer == System.IntPtr.Zero ? (ItemDataComponent) null : new ItemDataComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.RecipeRequirement.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.RecipeRequirement.NativeFieldInfoPtr_Amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.RecipeRequirement.NativeFieldInfoPtr_Amount)) = value;
        }
      }
    }

    [Serializable]
    public sealed class RecipeOutputEntry : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Item;
      private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

      static RecipeOutputEntry()
      {
        Il2CppClassPointerStore<RecipeDataComponent.RecipeOutputEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeDataComponent>.NativeClassPtr, nameof (RecipeOutputEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeDataComponent.RecipeOutputEntry>.NativeClassPtr);
        RecipeDataComponent.RecipeOutputEntry.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataComponent.RecipeOutputEntry>.NativeClassPtr, nameof (Item));
        RecipeDataComponent.RecipeOutputEntry.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeDataComponent.RecipeOutputEntry>.NativeClassPtr, nameof (Amount));
      }

      public RecipeOutputEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public RecipeOutputEntry()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RecipeDataComponent.RecipeOutputEntry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RecipeDataComponent.RecipeOutputEntry>.NativeClassPtr, data));
      }

      public unsafe ItemDataComponent Item
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.RecipeOutputEntry.NativeFieldInfoPtr_Item));
          return pointer == System.IntPtr.Zero ? (ItemDataComponent) null : new ItemDataComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.RecipeOutputEntry.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Amount
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.RecipeOutputEntry.NativeFieldInfoPtr_Amount));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RecipeDataComponent.RecipeOutputEntry.NativeFieldInfoPtr_Amount)) = value;
        }
      }
    }
  }
}
