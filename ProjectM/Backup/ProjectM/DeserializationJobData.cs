// Decompiled with JetBrains decompiler
// Type: ProjectM.DeserializationJobData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DeserializationJobData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OldToNewEntities;
    private static readonly System.IntPtr NativeFieldInfoPtr_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_Archetypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityToArchetype;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldTypeIndexToNewTypeIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HeaderData_Dictionary_2_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1058270, RefRangeEnd = 1058271, XrefRangeStart = 1058250, XrefRangeEnd = 1058270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DeserializationJobData(
      DeserializationJobData.HeaderData header,
      Dictionary<int, int> oldTypeIndexToNewTypeIndex)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) header);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) oldTypeIndexToNewTypeIndex);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeserializationJobData.NativeMethodInfoPtr__ctor_Public_Void_HeaderData_Dictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1058271, XrefRangeEnd = 1058290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeserializationJobData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DeserializationJobData()
    {
      Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DeserializationJobData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr);
      DeserializationJobData.NativeFieldInfoPtr_OldToNewEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr, nameof (OldToNewEntities));
      DeserializationJobData.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr, nameof (Header));
      DeserializationJobData.NativeFieldInfoPtr_Archetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr, nameof (Archetypes));
      DeserializationJobData.NativeFieldInfoPtr_EntityToArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr, nameof (EntityToArchetype));
      DeserializationJobData.NativeFieldInfoPtr_OldTypeIndexToNewTypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr, nameof (OldTypeIndexToNewTypeIndex));
      DeserializationJobData.NativeMethodInfoPtr__ctor_Public_Void_HeaderData_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr, 100683077);
      DeserializationJobData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr, 100683078);
    }

    public DeserializationJobData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeHashMap<Entity, Entity> OldToNewEntities
    {
      get
      {
        return *(NativeHashMap<Entity, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.NativeFieldInfoPtr_OldToNewEntities));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.NativeFieldInfoPtr_OldToNewEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<Entity, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe DeserializationJobData.HeaderData Header
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.NativeFieldInfoPtr_Header));
        return pointer == System.IntPtr.Zero ? (DeserializationJobData.HeaderData) null : new DeserializationJobData.HeaderData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.NativeFieldInfoPtr_Header), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<DeserializationJobData.DeserializedArchetype> Archetypes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.NativeFieldInfoPtr_Archetypes));
        return pointer == System.IntPtr.Zero ? (List<DeserializationJobData.DeserializedArchetype>) null : new List<DeserializationJobData.DeserializedArchetype>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.NativeFieldInfoPtr_Archetypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<Entity, DeserializationJobData.DeserializedArchetype> EntityToArchetype
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.NativeFieldInfoPtr_EntityToArchetype));
        return pointer == System.IntPtr.Zero ? (Dictionary<Entity, DeserializationJobData.DeserializedArchetype>) null : new Dictionary<Entity, DeserializationJobData.DeserializedArchetype>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.NativeFieldInfoPtr_EntityToArchetype), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, int> OldTypeIndexToNewTypeIndex
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.NativeFieldInfoPtr_OldTypeIndexToNewTypeIndex));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, int>) null : new Dictionary<int, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.NativeFieldInfoPtr_OldTypeIndexToNewTypeIndex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class HeaderData : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HeaderMetadata;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExcludedComponentTypes;
      private static readonly System.IntPtr NativeFieldInfoPtr_PersistentComponents;
      private static readonly System.IntPtr NativeFieldInfoPtr_RequiredComponents;
      private static readonly System.IntPtr NativeFieldInfoPtr_OldPrefabEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_OldBlobAssets;
      private static readonly System.IntPtr NativeFieldInfoPtr_OldExistingVersionsByEntityIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_NonPersistentEntityDebugData;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1058209, RefRangeEnd = 1058210, XrefRangeStart = 1058202, XrefRangeEnd = 1058209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializationJobData.HeaderData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe HeaderData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializationJobData.HeaderData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static HeaderData()
      {
        Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr, nameof (HeaderData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr);
        DeserializationJobData.HeaderData.NativeFieldInfoPtr_HeaderMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr, nameof (HeaderMetadata));
        DeserializationJobData.HeaderData.NativeFieldInfoPtr_ExcludedComponentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr, nameof (ExcludedComponentTypes));
        DeserializationJobData.HeaderData.NativeFieldInfoPtr_PersistentComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr, nameof (PersistentComponents));
        DeserializationJobData.HeaderData.NativeFieldInfoPtr_RequiredComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr, nameof (RequiredComponents));
        DeserializationJobData.HeaderData.NativeFieldInfoPtr_OldPrefabEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr, nameof (OldPrefabEntities));
        DeserializationJobData.HeaderData.NativeFieldInfoPtr_OldBlobAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr, nameof (OldBlobAssets));
        DeserializationJobData.HeaderData.NativeFieldInfoPtr_OldExistingVersionsByEntityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr, nameof (OldExistingVersionsByEntityIndex));
        DeserializationJobData.HeaderData.NativeFieldInfoPtr_NonPersistentEntityDebugData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr, nameof (NonPersistentEntityDebugData));
        DeserializationJobData.HeaderData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr, 100683079);
        DeserializationJobData.HeaderData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationJobData.HeaderData>.NativeClassPtr, 100683080);
      }

      public HeaderData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PersistenceHeaderMetadata HeaderMetadata
      {
        get
        {
          return *(PersistenceHeaderMetadata*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_HeaderMetadata));
        }
        [param: In] set
        {
          *(PersistenceHeaderMetadata*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_HeaderMetadata)) = value;
        }
      }

      public unsafe NativeBitArray ExcludedComponentTypes
      {
        get
        {
          return *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_ExcludedComponentTypes));
        }
        [param: In] set
        {
          *(NativeBitArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_ExcludedComponentTypes)) = value;
        }
      }

      public unsafe List<PersistentComponentMetadata> PersistentComponents
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_PersistentComponents));
          return pointer == System.IntPtr.Zero ? (List<PersistentComponentMetadata>) null : new List<PersistentComponentMetadata>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_PersistentComponents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe List<RequiredComponentMetadata> RequiredComponents
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_RequiredComponents));
          return pointer == System.IntPtr.Zero ? (List<RequiredComponentMetadata>) null : new List<RequiredComponentMetadata>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_RequiredComponents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<PrefabGUID, DeserializationJobData.OldPrefabData> OldPrefabEntities
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_OldPrefabEntities));
          return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, DeserializationJobData.OldPrefabData>) null : new Dictionary<PrefabGUID, DeserializationJobData.OldPrefabData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_OldPrefabEntities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe List<PersistentBlobMetadata> OldBlobAssets
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_OldBlobAssets));
          return pointer == System.IntPtr.Zero ? (List<PersistentBlobMetadata>) null : new List<PersistentBlobMetadata>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_OldBlobAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeArray<int> OldExistingVersionsByEntityIndex
      {
        get
        {
          return *(NativeArray<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_OldExistingVersionsByEntityIndex));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_OldExistingVersionsByEntityIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe LoadPersistenceSystemV2.NonPersistentEntityDebugData NonPersistentEntityDebugData
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_NonPersistentEntityDebugData));
          return pointer == System.IntPtr.Zero ? (LoadPersistenceSystemV2.NonPersistentEntityDebugData) null : new LoadPersistenceSystemV2.NonPersistentEntityDebugData(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.HeaderData.NativeFieldInfoPtr_NonPersistentEntityDebugData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class OldPrefabData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_LinkedEntities;

      static OldPrefabData()
      {
        Il2CppClassPointerStore<DeserializationJobData.OldPrefabData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr, nameof (OldPrefabData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializationJobData.OldPrefabData>.NativeClassPtr);
        DeserializationJobData.OldPrefabData.NativeFieldInfoPtr_PrefabEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.OldPrefabData>.NativeClassPtr, nameof (PrefabEntity));
        DeserializationJobData.OldPrefabData.NativeFieldInfoPtr_LinkedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.OldPrefabData>.NativeClassPtr, nameof (LinkedEntities));
      }

      public OldPrefabData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public OldPrefabData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DeserializationJobData.OldPrefabData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializationJobData.OldPrefabData>.NativeClassPtr, data));
      }

      public unsafe Entity PrefabEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.OldPrefabData.NativeFieldInfoPtr_PrefabEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.OldPrefabData.NativeFieldInfoPtr_PrefabEntity)) = value;
        }
      }

      public unsafe List<Entity> LinkedEntities
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.OldPrefabData.NativeFieldInfoPtr_LinkedEntities));
          return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.OldPrefabData.NativeFieldInfoPtr_LinkedEntities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class DeserializedArchetype : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_OldEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_NewEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentTypes;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_EntityCount_Public_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

      public unsafe int EntityCount
      {
        [CallerCount(1), CachedScanResults(RefRangeStart = 1058230, RefRangeEnd = 1058231, XrefRangeStart = 1058210, XrefRangeEnd = 1058230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeserializationJobData.DeserializedArchetype.NativeMethodInfoPtr_get_EntityCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1058240, RefRangeEnd = 1058241, XrefRangeStart = 1058231, XrefRangeEnd = 1058240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe DeserializedArchetype()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializationJobData.DeserializedArchetype>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializationJobData.DeserializedArchetype.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1058249, RefRangeEnd = 1058250, XrefRangeStart = 1058241, XrefRangeEnd = 1058249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DeserializationJobData.DeserializedArchetype.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static DeserializedArchetype()
      {
        Il2CppClassPointerStore<DeserializationJobData.DeserializedArchetype>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeserializationJobData>.NativeClassPtr, nameof (DeserializedArchetype));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializationJobData.DeserializedArchetype>.NativeClassPtr);
        DeserializationJobData.DeserializedArchetype.NativeFieldInfoPtr_OldEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.DeserializedArchetype>.NativeClassPtr, nameof (OldEntities));
        DeserializationJobData.DeserializedArchetype.NativeFieldInfoPtr_NewEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.DeserializedArchetype>.NativeClassPtr, nameof (NewEntities));
        DeserializationJobData.DeserializedArchetype.NativeFieldInfoPtr_ComponentTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializationJobData.DeserializedArchetype>.NativeClassPtr, nameof (ComponentTypes));
        DeserializationJobData.DeserializedArchetype.NativeMethodInfoPtr_get_EntityCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationJobData.DeserializedArchetype>.NativeClassPtr, 100683081);
        DeserializationJobData.DeserializedArchetype.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationJobData.DeserializedArchetype>.NativeClassPtr, 100683082);
        DeserializationJobData.DeserializedArchetype.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationJobData.DeserializedArchetype>.NativeClassPtr, 100683083);
      }

      public DeserializedArchetype(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe NativeList<Entity> OldEntities
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.DeserializedArchetype.NativeFieldInfoPtr_OldEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.DeserializedArchetype.NativeFieldInfoPtr_OldEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<Entity> NewEntities
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.DeserializedArchetype.NativeFieldInfoPtr_NewEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.DeserializedArchetype.NativeFieldInfoPtr_NewEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<ComponentType> ComponentTypes
      {
        get
        {
          return *(NativeList<ComponentType>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.DeserializedArchetype.NativeFieldInfoPtr_ComponentTypes));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeserializationJobData.DeserializedArchetype.NativeFieldInfoPtr_ComponentTypes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<ComponentType>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
