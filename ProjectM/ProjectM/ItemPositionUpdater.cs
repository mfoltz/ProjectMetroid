// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemPositionUpdater
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class ItemPositionUpdater : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FRAME_RATE;
    private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_FREQUENCY;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveExternalInventoryJobQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveExternalInventoryJobChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveInventoryItemsJobQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveInventoryItemsJobChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveEquipmentJobQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveEquipmentJobChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveEquippedJewelsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveEquippedJewelsJobChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__TranslationCache;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020755, XrefRangeEnd = 1020793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ItemPositionUpdater.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020793, XrefRangeEnd = 1020796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ItemPositionUpdater.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020796, XrefRangeEnd = 1020855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ItemPositionUpdater.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ItemPositionUpdater()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemPositionUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ItemPositionUpdater.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ItemPositionUpdater()
    {
      Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ItemPositionUpdater));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr);
      ItemPositionUpdater.NativeFieldInfoPtr_FRAME_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (FRAME_RATE));
      ItemPositionUpdater.NativeFieldInfoPtr_UPDATE_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (UPDATE_FREQUENCY));
      ItemPositionUpdater.NativeFieldInfoPtr__MoveExternalInventoryJobQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (_MoveExternalInventoryJobQuery));
      ItemPositionUpdater.NativeFieldInfoPtr__MoveExternalInventoryJobChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (_MoveExternalInventoryJobChunkRange));
      ItemPositionUpdater.NativeFieldInfoPtr__MoveInventoryItemsJobQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (_MoveInventoryItemsJobQuery));
      ItemPositionUpdater.NativeFieldInfoPtr__MoveInventoryItemsJobChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (_MoveInventoryItemsJobChunkRange));
      ItemPositionUpdater.NativeFieldInfoPtr__MoveEquipmentJobQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (_MoveEquipmentJobQuery));
      ItemPositionUpdater.NativeFieldInfoPtr__MoveEquipmentJobChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (_MoveEquipmentJobChunkRange));
      ItemPositionUpdater.NativeFieldInfoPtr__MoveEquippedJewelsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (_MoveEquippedJewelsQuery));
      ItemPositionUpdater.NativeFieldInfoPtr__MoveEquippedJewelsJobChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (_MoveEquippedJewelsJobChunkRange));
      ItemPositionUpdater.NativeFieldInfoPtr__TranslationCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (_TranslationCache));
      ItemPositionUpdater.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, 100679655);
      ItemPositionUpdater.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, 100679656);
      ItemPositionUpdater.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, 100679657);
      ItemPositionUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, 100679658);
      ItemPositionUpdater.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, 100679659);
    }

    public ItemPositionUpdater(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int FRAME_RATE
    {
      get
      {
        int frameRate;
        IL2CPP.il2cpp_field_static_get_value(ItemPositionUpdater.NativeFieldInfoPtr_FRAME_RATE, (void*) &frameRate);
        return frameRate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ItemPositionUpdater.NativeFieldInfoPtr_FRAME_RATE, (void*) &value);
      }
    }

    public static unsafe float UPDATE_FREQUENCY
    {
      get
      {
        float updateFrequency;
        IL2CPP.il2cpp_field_static_get_value(ItemPositionUpdater.NativeFieldInfoPtr_UPDATE_FREQUENCY, (void*) &updateFrequency);
        return updateFrequency;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ItemPositionUpdater.NativeFieldInfoPtr_UPDATE_FREQUENCY, (void*) &value);
      }
    }

    public unsafe EntityQuery _MoveExternalInventoryJobQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveExternalInventoryJobQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveExternalInventoryJobQuery)) = value;
      }
    }

    public unsafe ChunkRange _MoveExternalInventoryJobChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveExternalInventoryJobChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveExternalInventoryJobChunkRange)) = value;
      }
    }

    public unsafe EntityQuery _MoveInventoryItemsJobQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveInventoryItemsJobQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveInventoryItemsJobQuery)) = value;
      }
    }

    public unsafe ChunkRange _MoveInventoryItemsJobChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveInventoryItemsJobChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveInventoryItemsJobChunkRange)) = value;
      }
    }

    public unsafe EntityQuery _MoveEquipmentJobQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveEquipmentJobQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveEquipmentJobQuery)) = value;
      }
    }

    public unsafe ChunkRange _MoveEquipmentJobChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveEquipmentJobChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveEquipmentJobChunkRange)) = value;
      }
    }

    public unsafe EntityQuery _MoveEquippedJewelsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveEquippedJewelsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveEquippedJewelsQuery)) = value;
      }
    }

    public unsafe ChunkRange _MoveEquippedJewelsJobChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveEquippedJewelsJobChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__MoveEquippedJewelsJobChunkRange)) = value;
      }
    }

    public unsafe NativeHashMap<Entity, Translation> _TranslationCache
    {
      get
      {
        return *(NativeHashMap<Entity, Translation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__TranslationCache));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemPositionUpdater.NativeFieldInfoPtr__TranslationCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<Entity, Translation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MoveEquippedJewelsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AbilitySpellModItemType;
      private static readonly System.IntPtr NativeFieldInfoPtr_AttachedType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationCache;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<AbilitySpellModItem> AbilitySpellModItemType;
      [FieldOffset(32)]
      public ComponentTypeHandle<Attached> AttachedType;
      [FieldOffset(64)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(96)]
      public NativeHashMap<Entity, Translation> TranslationCache;
      [FieldOffset(112)]
      public ChunkRange ChunkRange;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020628, XrefRangeEnd = 1020656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemPositionUpdater.MoveEquippedJewelsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MoveEquippedJewelsJob()
      {
        Il2CppClassPointerStore<ItemPositionUpdater.MoveEquippedJewelsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (MoveEquippedJewelsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquippedJewelsJob>.NativeClassPtr);
        ItemPositionUpdater.MoveEquippedJewelsJob.NativeFieldInfoPtr_AbilitySpellModItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquippedJewelsJob>.NativeClassPtr, nameof (AbilitySpellModItemType));
        ItemPositionUpdater.MoveEquippedJewelsJob.NativeFieldInfoPtr_AttachedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquippedJewelsJob>.NativeClassPtr, nameof (AttachedType));
        ItemPositionUpdater.MoveEquippedJewelsJob.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquippedJewelsJob>.NativeClassPtr, nameof (GetTranslation));
        ItemPositionUpdater.MoveEquippedJewelsJob.NativeFieldInfoPtr_TranslationCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquippedJewelsJob>.NativeClassPtr, nameof (TranslationCache));
        ItemPositionUpdater.MoveEquippedJewelsJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquippedJewelsJob>.NativeClassPtr, nameof (ChunkRange));
        ItemPositionUpdater.MoveEquippedJewelsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquippedJewelsJob>.NativeClassPtr, 100679660);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquippedJewelsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MoveExternalInventoryJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_InventoryOwnerType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public BufferTypeHandle<InventoryInstanceElement> InventoryOwnerType;
      [FieldOffset(40)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(72)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(104)]
      public ChunkRange ChunkRange;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020656, XrefRangeEnd = 1020687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemPositionUpdater.MoveExternalInventoryJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MoveExternalInventoryJob()
      {
        Il2CppClassPointerStore<ItemPositionUpdater.MoveExternalInventoryJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (MoveExternalInventoryJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPositionUpdater.MoveExternalInventoryJob>.NativeClassPtr);
        ItemPositionUpdater.MoveExternalInventoryJob.NativeFieldInfoPtr_InventoryOwnerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveExternalInventoryJob>.NativeClassPtr, nameof (InventoryOwnerType));
        ItemPositionUpdater.MoveExternalInventoryJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveExternalInventoryJob>.NativeClassPtr, nameof (TranslationType));
        ItemPositionUpdater.MoveExternalInventoryJob.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveExternalInventoryJob>.NativeClassPtr, nameof (GetTranslation));
        ItemPositionUpdater.MoveExternalInventoryJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveExternalInventoryJob>.NativeClassPtr, nameof (ChunkRange));
        ItemPositionUpdater.MoveExternalInventoryJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPositionUpdater.MoveExternalInventoryJob>.NativeClassPtr, 100679661);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemPositionUpdater.MoveExternalInventoryJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MoveInventoryItemsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_InventoryBufferTypeHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public BufferTypeHandle<InventoryBuffer> InventoryBufferTypeHandle;
      [FieldOffset(40)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(72)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(104)]
      public ChunkRange ChunkRange;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020687, XrefRangeEnd = 1020716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemPositionUpdater.MoveInventoryItemsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MoveInventoryItemsJob()
      {
        Il2CppClassPointerStore<ItemPositionUpdater.MoveInventoryItemsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (MoveInventoryItemsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPositionUpdater.MoveInventoryItemsJob>.NativeClassPtr);
        ItemPositionUpdater.MoveInventoryItemsJob.NativeFieldInfoPtr_InventoryBufferTypeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveInventoryItemsJob>.NativeClassPtr, nameof (InventoryBufferTypeHandle));
        ItemPositionUpdater.MoveInventoryItemsJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveInventoryItemsJob>.NativeClassPtr, nameof (TranslationType));
        ItemPositionUpdater.MoveInventoryItemsJob.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveInventoryItemsJob>.NativeClassPtr, nameof (GetTranslation));
        ItemPositionUpdater.MoveInventoryItemsJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveInventoryItemsJob>.NativeClassPtr, nameof (ChunkRange));
        ItemPositionUpdater.MoveInventoryItemsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPositionUpdater.MoveInventoryItemsJob>.NativeClassPtr, 100679662);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemPositionUpdater.MoveInventoryItemsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MoveEquipmentJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TranslationType;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTranslation;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeFieldInfoPtr__EquipmentEntities;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<Equipment> EquipmentType;
      [FieldOffset(32)]
      public ComponentTypeHandle<Translation> TranslationType;
      [FieldOffset(64)]
      public ComponentDataFromEntity<Translation> GetTranslation;
      [FieldOffset(96)]
      public ChunkRange ChunkRange;
      [FieldOffset(112)]
      public NativeList<Entity> _EquipmentEntities;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020716, XrefRangeEnd = 1020755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemPositionUpdater.MoveEquipmentJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static MoveEquipmentJob()
      {
        Il2CppClassPointerStore<ItemPositionUpdater.MoveEquipmentJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemPositionUpdater>.NativeClassPtr, nameof (MoveEquipmentJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquipmentJob>.NativeClassPtr);
        ItemPositionUpdater.MoveEquipmentJob.NativeFieldInfoPtr_EquipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquipmentJob>.NativeClassPtr, nameof (EquipmentType));
        ItemPositionUpdater.MoveEquipmentJob.NativeFieldInfoPtr_TranslationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquipmentJob>.NativeClassPtr, nameof (TranslationType));
        ItemPositionUpdater.MoveEquipmentJob.NativeFieldInfoPtr_GetTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquipmentJob>.NativeClassPtr, nameof (GetTranslation));
        ItemPositionUpdater.MoveEquipmentJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquipmentJob>.NativeClassPtr, nameof (ChunkRange));
        ItemPositionUpdater.MoveEquipmentJob.NativeFieldInfoPtr__EquipmentEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquipmentJob>.NativeClassPtr, nameof (_EquipmentEntities));
        ItemPositionUpdater.MoveEquipmentJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquipmentJob>.NativeClassPtr, 100679663);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemPositionUpdater.MoveEquipmentJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
