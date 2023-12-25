// Decompiled with JetBrains decompiler
// Type: ProjectM.UpdateSalvageSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class UpdateSalvageSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSalvage_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateSalvage_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetItemFromInventory_Private_InventoryBuffer_NativeArray_1_InventoryBuffer_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstItem_Private_InventoryBuffer_NativeArray_1_InventoryBuffer_PrefabLookupMap_Single_Entity_byref_NativeList_1_RecipeOutputBuffer_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanSalvageThisItem_Private_Boolean_Boolean_Entity_Entity_Salvageable_Single_Entity_byref_NativeList_1_RecipeOutputBuffer_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateSalvage_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417645, XrefRangeEnd = 1417656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateSalvageSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417656, XrefRangeEnd = 1417666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateSalvageSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417666, XrefRangeEnd = 1417686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InventoryBuffer GetItemFromInventory(
      NativeArray<InventoryBuffer> inputInventory,
      PrefabGUID prevItem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &inputInventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prevItem;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.NativeMethodInfoPtr_GetItemFromInventory_Private_InventoryBuffer_NativeArray_1_InventoryBuffer_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(InventoryBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1417712, RefRangeEnd = 1417713, XrefRangeStart = 1417686, XrefRangeEnd = 1417712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InventoryBuffer GetFirstItem(
      NativeArray<InventoryBuffer> inventory,
      PrefabLookupMap prefabMapping,
      float itemMultiplier,
      Entity outputInventoryEntity,
      ref NativeList<RecipeOutputBuffer> outputItemsArrayFirst,
      out bool containerFull)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &inventory;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &prefabMapping;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemMultiplier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &outputInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref outputItemsArrayFirst;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref containerFull;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.NativeMethodInfoPtr_GetFirstItem_Private_InventoryBuffer_NativeArray_1_InventoryBuffer_PrefabLookupMap_Single_Entity_byref_NativeList_1_RecipeOutputBuffer_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(InventoryBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1417743, RefRangeEnd = 1417744, XrefRangeStart = 1417713, XrefRangeEnd = 1417743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool CanSalvageThisItem(
      bool isRecipe,
      Entity bufferEntity,
      Entity itemEntity,
      Salvageable salvageData,
      float itemMultiplier,
      Entity outputInventoryEntity,
      ref NativeList<RecipeOutputBuffer> outputItemsArray,
      out bool containerFull)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = (System.IntPtr) &isRecipe;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &bufferEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &itemEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &salvageData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &itemMultiplier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &outputInventoryEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref outputItemsArray;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref containerFull;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.NativeMethodInfoPtr_CanSalvageThisItem_Private_Boolean_Boolean_Entity_Entity_Salvageable_Single_Entity_byref_NativeList_1_RecipeOutputBuffer_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateSalvageSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417744, XrefRangeEnd = 1417767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateSalvageSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417767, XrefRangeEnd = 1417786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateSalvage_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSalvage_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UpdateSalvageSystem()
    {
      Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (UpdateSalvageSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr);
      UpdateSalvageSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, nameof (_GameDataSystem));
      UpdateSalvageSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      UpdateSalvageSystem.NativeFieldInfoPtr___UpdateSalvage_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, "<>UpdateSalvage_entityQuery");
      UpdateSalvageSystem.NativeFieldInfoPtr___UpdateSalvage_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, "<>UpdateSalvage_profilerMarker");
      UpdateSalvageSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, 100669335);
      UpdateSalvageSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, 100669336);
      UpdateSalvageSystem.NativeMethodInfoPtr_GetItemFromInventory_Private_InventoryBuffer_NativeArray_1_InventoryBuffer_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, 100669337);
      UpdateSalvageSystem.NativeMethodInfoPtr_GetFirstItem_Private_InventoryBuffer_NativeArray_1_InventoryBuffer_PrefabLookupMap_Single_Entity_byref_NativeList_1_RecipeOutputBuffer_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, 100669338);
      UpdateSalvageSystem.NativeMethodInfoPtr_CanSalvageThisItem_Private_Boolean_Boolean_Entity_Entity_Salvageable_Single_Entity_byref_NativeList_1_RecipeOutputBuffer_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, 100669339);
      UpdateSalvageSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, 100669340);
      UpdateSalvageSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, 100669341);
      UpdateSalvageSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateSalvage_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, 100669342);
    }

    public UpdateSalvageSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __UpdateSalvage_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.NativeFieldInfoPtr___UpdateSalvage_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.NativeFieldInfoPtr___UpdateSalvage_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateSalvage_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.NativeFieldInfoPtr___UpdateSalvage_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.NativeFieldInfoPtr___UpdateSalvage_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UpdateSalvageSystem/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMapping;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Salvagestation_byref_CastleWorkstation_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref Salvagestation station,
        ref CastleWorkstation castleWorkstation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref station;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleWorkstation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Salvagestation_byref_CastleWorkstation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass3_0>.NativeClassPtr);
        UpdateSalvageSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        UpdateSalvageSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_prefabMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (prefabMapping));
        UpdateSalvageSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass3_0>.NativeClassPtr, 100669343);
        UpdateSalvageSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Salvagestation_byref_CastleWorkstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass3_0>.NativeClassPtr, 100669344);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass3_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass3_0>.NativeClassPtr, data));
      }

      public unsafe UpdateSalvageSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (UpdateSalvageSystem) null : new UpdateSalvageSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabMapping
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_prefabMapping));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_prefabMapping)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.UpdateSalvageSystem/ProjectM.<>c__DisplayClass_UpdateSalvage")]
    public sealed class __c__DisplayClass_UpdateSalvage : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMapping;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Salvagestation_byref_CastleWorkstation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSalvageSystem_byref___c__DisplayClass3_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1417617, RefRangeEnd = 1417618, XrefRangeStart = 1417541, XrefRangeEnd = 1417617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref Salvagestation station,
        ref CastleWorkstation castleWorkstation)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref station;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleWorkstation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Salvagestation_byref_CastleWorkstation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UpdateSalvageSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 998278, RefRangeEnd = 998286, XrefRangeStart = 998278, XrefRangeEnd = 998286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UpdateSalvageSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417618, XrefRangeEnd = 1417638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1417644, RefRangeEnd = 1417645, XrefRangeStart = 1417638, XrefRangeEnd = 1417644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 998308, RefRangeEnd = 998316, XrefRangeStart = 998308, XrefRangeEnd = 998316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UpdateSalvageSystem componentSystem,
        ref UpdateSalvageSystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSalvageSystem_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateSalvage()
      {
        Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateSalvageSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateSalvage");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr);
        UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, "<>4__this");
        UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr_prefabMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, nameof (prefabMapping));
        UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, nameof (_runtimes));
        UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, nameof (_performLambdaDelegate));
        UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Salvagestation_byref_CastleWorkstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, 100669345);
        UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, 100669346);
        UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, 100669347);
        UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, 100669349);
        UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, 100669350);
        UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSalvageSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, 100669351);
      }

      public __c__DisplayClass_UpdateSalvage(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UpdateSalvage()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, data));
      }

      public unsafe UpdateSalvageSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (UpdateSalvageSystem) null : new UpdateSalvageSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PrefabLookupMap prefabMapping
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr_prefabMapping));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr_prefabMapping)) = value;
        }
      }

      public unsafe UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_station;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleWorkstation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSalvageSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Salvagestation> forParameter_station;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<CastleWorkstation> forParameter_castleWorkstation;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1417525, XrefRangeEnd = 1417532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UpdateSalvageSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSalvageSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1417540, RefRangeEnd = 1417541, XrefRangeStart = 1417532, XrefRangeEnd = 1417540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_station));
          UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleWorkstation));
          UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateSalvageSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders>.NativeClassPtr, 100669352);
          UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders>.NativeClassPtr, 100669353);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_station;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleWorkstation;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<Salvagestation>.StructuralChangeRuntime runtime_station;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<CastleWorkstation>.StructuralChangeRuntime runtime_castleWorkstation;

          static Runtimes()
          {
            Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_station));
            UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleWorkstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleWorkstation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSalvageSystem.__c__DisplayClass_UpdateSalvage.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
