// Decompiled with JetBrains decompiler
// Type: ProjectM.Compatibility.PersistenceCompatibilityData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using ProjectM.Terrain;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Compatibility
{
  public class PersistenceCompatibilityData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentHeaderVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_ApplicationType;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameData;
    private static readonly System.IntPtr NativeFieldInfoPtr_World;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeHeader_Public_Static_Void_PersistenceCompatibilityData_BinaryWriter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeGameDataCollection_Private_Static_Void_byref_GameDataCollection_BinaryWriter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeEntityArchetype_Private_Static_Void_BinaryWriter_PersistentEntityArchetype_Dictionary_2_String_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeWorldData_Private_Static_Void_byref_WorldData_BinaryWriter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeHeader_Public_Static_PersistenceCompatibilityData_BinaryReader_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeGameDataCollection_Private_Static_GameDataCollection_BinaryReader_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeEntityArchetype_Private_Static_PersistentEntityArchetype_BinaryReader_Dictionary_2_Int32_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeWorldData_Private_Static_WorldData_BinaryReader_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PersistenceCompatibilityData_PersistenceCompatibilityChecker_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111024, XrefRangeEnd = 1111027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeHeader(
      PersistenceCompatibilityData compatibilityData,
      BinaryWriter writer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compatibilityData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.NativeMethodInfoPtr_SerializeHeader_Public_Static_Void_PersistenceCompatibilityData_BinaryWriter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1111197, RefRangeEnd = 1111199, XrefRangeStart = 1111027, XrefRangeEnd = 1111197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeGameDataCollection(
      [In] ref PersistenceCompatibilityData.GameDataCollection gameData,
      BinaryWriter writer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) gameData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.NativeMethodInfoPtr_SerializeGameDataCollection_Private_Static_Void_byref_GameDataCollection_BinaryWriter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1111206, RefRangeEnd = 1111207, XrefRangeStart = 1111199, XrefRangeEnd = 1111206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeEntityArchetype(
      BinaryWriter writer,
      PersistenceCompatibilityData.PersistentEntityArchetype persistentEntityArchetype,
      Dictionary<string, int> componentIdToCompressedIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) persistentEntityArchetype));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentIdToCompressedIndex);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.NativeMethodInfoPtr_SerializeEntityArchetype_Private_Static_Void_BinaryWriter_PersistentEntityArchetype_Dictionary_2_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1111268, RefRangeEnd = 1111270, XrefRangeStart = 1111207, XrefRangeEnd = 1111268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SerializeWorldData(
      [In] ref PersistenceCompatibilityData.WorldData worldData,
      BinaryWriter writer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) worldData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.NativeMethodInfoPtr_SerializeWorldData_Private_Static_Void_byref_WorldData_BinaryWriter_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111270, XrefRangeEnd = 1111279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceCompatibilityData DeserializeHeader(BinaryReader reader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.NativeMethodInfoPtr_DeserializeHeader_Public_Static_PersistenceCompatibilityData_BinaryReader_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (PersistenceCompatibilityData) null : new PersistenceCompatibilityData(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1111331, RefRangeEnd = 1111333, XrefRangeStart = 1111279, XrefRangeEnd = 1111331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceCompatibilityData.GameDataCollection DeserializeGameDataCollection(
      BinaryReader reader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.NativeMethodInfoPtr_DeserializeGameDataCollection_Private_Static_GameDataCollection_BinaryReader_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new PersistenceCompatibilityData.GameDataCollection(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1111349, RefRangeEnd = 1111351, XrefRangeStart = 1111333, XrefRangeEnd = 1111349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceCompatibilityData.PersistentEntityArchetype DeserializeEntityArchetype(
      BinaryReader reader,
      Dictionary<int, string> componentIndexToName)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentIndexToName);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.NativeMethodInfoPtr_DeserializeEntityArchetype_Private_Static_PersistentEntityArchetype_BinaryReader_Dictionary_2_Int32_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new PersistenceCompatibilityData.PersistentEntityArchetype(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1111378, RefRangeEnd = 1111380, XrefRangeStart = 1111351, XrefRangeEnd = 1111378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PersistenceCompatibilityData.WorldData DeserializeWorldData(
      BinaryReader reader)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.NativeMethodInfoPtr_DeserializeWorldData_Private_Static_WorldData_BinaryReader_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new PersistenceCompatibilityData.WorldData(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111380, XrefRangeEnd = 1111382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe string GetName()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1111400, RefRangeEnd = 1111401, XrefRangeStart = 1111382, XrefRangeEnd = 1111400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void CanLoadSaveFrom(
      PersistenceCompatibilityData previousVersion,
      PersistenceCompatibilityChecker checker)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) previousVersion);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checker);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PersistenceCompatibilityData_PersistenceCompatibilityChecker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PersistenceCompatibilityData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PersistenceCompatibilityData()
    {
      Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Compatibility", nameof (PersistenceCompatibilityData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr);
      PersistenceCompatibilityData.NativeFieldInfoPtr_CurrentHeaderVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, nameof (CurrentHeaderVersion));
      PersistenceCompatibilityData.NativeFieldInfoPtr_HeaderVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, nameof (HeaderVersion));
      PersistenceCompatibilityData.NativeFieldInfoPtr_ApplicationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, nameof (ApplicationType));
      PersistenceCompatibilityData.NativeFieldInfoPtr_GameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, nameof (GameData));
      PersistenceCompatibilityData.NativeFieldInfoPtr_World = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, nameof (World));
      PersistenceCompatibilityData.NativeMethodInfoPtr_SerializeHeader_Public_Static_Void_PersistenceCompatibilityData_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, 100687935);
      PersistenceCompatibilityData.NativeMethodInfoPtr_SerializeGameDataCollection_Private_Static_Void_byref_GameDataCollection_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, 100687936);
      PersistenceCompatibilityData.NativeMethodInfoPtr_SerializeEntityArchetype_Private_Static_Void_BinaryWriter_PersistentEntityArchetype_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, 100687937);
      PersistenceCompatibilityData.NativeMethodInfoPtr_SerializeWorldData_Private_Static_Void_byref_WorldData_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, 100687938);
      PersistenceCompatibilityData.NativeMethodInfoPtr_DeserializeHeader_Public_Static_PersistenceCompatibilityData_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, 100687939);
      PersistenceCompatibilityData.NativeMethodInfoPtr_DeserializeGameDataCollection_Private_Static_GameDataCollection_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, 100687940);
      PersistenceCompatibilityData.NativeMethodInfoPtr_DeserializeEntityArchetype_Private_Static_PersistentEntityArchetype_BinaryReader_Dictionary_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, 100687941);
      PersistenceCompatibilityData.NativeMethodInfoPtr_DeserializeWorldData_Private_Static_WorldData_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, 100687942);
      PersistenceCompatibilityData.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, 100687943);
      PersistenceCompatibilityData.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PersistenceCompatibilityData_PersistenceCompatibilityChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, 100687944);
      PersistenceCompatibilityData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, 100687945);
    }

    public PersistenceCompatibilityData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CurrentHeaderVersion
    {
      get
      {
        int currentHeaderVersion;
        IL2CPP.il2cpp_field_static_get_value(PersistenceCompatibilityData.NativeFieldInfoPtr_CurrentHeaderVersion, (void*) &currentHeaderVersion);
        return currentHeaderVersion;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PersistenceCompatibilityData.NativeFieldInfoPtr_CurrentHeaderVersion, (void*) &value);
      }
    }

    public unsafe int HeaderVersion
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.NativeFieldInfoPtr_HeaderVersion));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.NativeFieldInfoPtr_HeaderVersion)) = value;
      }
    }

    public unsafe ApplicationType ApplicationType
    {
      get
      {
        return *(ApplicationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.NativeFieldInfoPtr_ApplicationType));
      }
      [param: In] set
      {
        *(ApplicationType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.NativeFieldInfoPtr_ApplicationType)) = value;
      }
    }

    public PersistenceCompatibilityData.GameDataCollection GameData
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.NativeFieldInfoPtr_GameData);
        return new PersistenceCompatibilityData.GameDataCollection(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceCompatibilityData.GameDataCollection>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.NativeFieldInfoPtr_GameData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PersistenceCompatibilityData.GameDataCollection>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public PersistenceCompatibilityData.WorldData World
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.NativeFieldInfoPtr_World);
        return new PersistenceCompatibilityData.WorldData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceCompatibilityData.WorldData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.NativeFieldInfoPtr_World), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PersistenceCompatibilityData.WorldData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public sealed class GameDataCollection : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PersistentComponents;
      private static readonly System.IntPtr NativeFieldInfoPtr_RequiredNonPersistentComponents;
      private static readonly System.IntPtr NativeFieldInfoPtr_Prefabs;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_GameDataCollection_PersistenceCompatibilityChecker_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110817, XrefRangeEnd = 1110819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe string GetName()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.GameDataCollection.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110819, XrefRangeEnd = 1110833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void CanLoadSaveFrom(
        PersistenceCompatibilityData.GameDataCollection previousVersion,
        PersistenceCompatibilityChecker checker)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) previousVersion));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checker);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.GameDataCollection.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_GameDataCollection_PersistenceCompatibilityChecker_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static GameDataCollection()
      {
        Il2CppClassPointerStore<PersistenceCompatibilityData.GameDataCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, nameof (GameDataCollection));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityData.GameDataCollection>.NativeClassPtr);
        PersistenceCompatibilityData.GameDataCollection.NativeFieldInfoPtr_PersistentComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.GameDataCollection>.NativeClassPtr, nameof (PersistentComponents));
        PersistenceCompatibilityData.GameDataCollection.NativeFieldInfoPtr_RequiredNonPersistentComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.GameDataCollection>.NativeClassPtr, nameof (RequiredNonPersistentComponents));
        PersistenceCompatibilityData.GameDataCollection.NativeFieldInfoPtr_Prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.GameDataCollection>.NativeClassPtr, nameof (Prefabs));
        PersistenceCompatibilityData.GameDataCollection.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.GameDataCollection>.NativeClassPtr, 100687946);
        PersistenceCompatibilityData.GameDataCollection.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_GameDataCollection_PersistenceCompatibilityChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.GameDataCollection>.NativeClassPtr, 100687947);
      }

      public GameDataCollection(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public GameDataCollection()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PersistenceCompatibilityData.GameDataCollection>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceCompatibilityData.GameDataCollection>.NativeClassPtr, data));
      }

      public unsafe Dictionary<string, PersistenceCompatibilityData.ComponentInformation> PersistentComponents
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.GameDataCollection.NativeFieldInfoPtr_PersistentComponents));
          return pointer == System.IntPtr.Zero ? (Dictionary<string, PersistenceCompatibilityData.ComponentInformation>) null : new Dictionary<string, PersistenceCompatibilityData.ComponentInformation>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.GameDataCollection.NativeFieldInfoPtr_PersistentComponents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<string, PersistenceCompatibilityData.ComponentInformation> RequiredNonPersistentComponents
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.GameDataCollection.NativeFieldInfoPtr_RequiredNonPersistentComponents));
          return pointer == System.IntPtr.Zero ? (Dictionary<string, PersistenceCompatibilityData.ComponentInformation>) null : new Dictionary<string, PersistenceCompatibilityData.ComponentInformation>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.GameDataCollection.NativeFieldInfoPtr_RequiredNonPersistentComponents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<PrefabGUID, PersistenceCompatibilityData.PrefabInformation> Prefabs
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.GameDataCollection.NativeFieldInfoPtr_Prefabs));
          return pointer == System.IntPtr.Zero ? (Dictionary<PrefabGUID, PersistenceCompatibilityData.PrefabInformation>) null : new Dictionary<PrefabGUID, PersistenceCompatibilityData.PrefabInformation>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.GameDataCollection.NativeFieldInfoPtr_Prefabs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class ComponentInformation : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentName;
      private static readonly System.IntPtr NativeFieldInfoPtr_StableTypeHash;
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentSize;
      private static readonly System.IntPtr NativeFieldInfoPtr_Persistent;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_ComponentInformation_PersistenceCompatibilityChecker_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

      [CallerCount(54)]
      [CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe string GetName()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.ComponentInformation.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110833, XrefRangeEnd = 1110852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void CanLoadSaveFrom(
        PersistenceCompatibilityData.ComponentInformation previousVersion,
        PersistenceCompatibilityChecker checker)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) previousVersion));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checker);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.ComponentInformation.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_ComponentInformation_PersistenceCompatibilityChecker_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110852, XrefRangeEnd = 1110861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.ComponentInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static ComponentInformation()
      {
        Il2CppClassPointerStore<PersistenceCompatibilityData.ComponentInformation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, nameof (ComponentInformation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityData.ComponentInformation>.NativeClassPtr);
        PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_ComponentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.ComponentInformation>.NativeClassPtr, nameof (ComponentName));
        PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_StableTypeHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.ComponentInformation>.NativeClassPtr, nameof (StableTypeHash));
        PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_ComponentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.ComponentInformation>.NativeClassPtr, nameof (ComponentSize));
        PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_Persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.ComponentInformation>.NativeClassPtr, nameof (Persistent));
        PersistenceCompatibilityData.ComponentInformation.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.ComponentInformation>.NativeClassPtr, 100687948);
        PersistenceCompatibilityData.ComponentInformation.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_ComponentInformation_PersistenceCompatibilityChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.ComponentInformation>.NativeClassPtr, 100687949);
        PersistenceCompatibilityData.ComponentInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.ComponentInformation>.NativeClassPtr, 100687950);
      }

      public ComponentInformation(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public ComponentInformation()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PersistenceCompatibilityData.ComponentInformation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceCompatibilityData.ComponentInformation>.NativeClassPtr, data));
      }

      public unsafe string ComponentName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_ComponentName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_ComponentName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe ulong StableTypeHash
      {
        get
        {
          return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_StableTypeHash));
        }
        [param: In] set
        {
          *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_StableTypeHash)) = value;
        }
      }

      public unsafe int ComponentSize
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_ComponentSize));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_ComponentSize)) = value;
        }
      }

      public unsafe bool Persistent
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_Persistent));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.ComponentInformation.NativeFieldInfoPtr_Persistent)) = value;
        }
      }
    }

    public sealed class PrefabInformation : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabName;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabArchetype;
      private static readonly System.IntPtr NativeFieldInfoPtr_LinkedEntityArchetypes;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PrefabInformation_PersistenceCompatibilityChecker_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110861, XrefRangeEnd = 1110867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe string GetName()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.PrefabInformation.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110867, XrefRangeEnd = 1110894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void CanLoadSaveFrom(
        PersistenceCompatibilityData.PrefabInformation previousVersion,
        PersistenceCompatibilityChecker checker)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) previousVersion));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checker);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.PrefabInformation.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PrefabInformation_PersistenceCompatibilityChecker_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PrefabInformation()
      {
        Il2CppClassPointerStore<PersistenceCompatibilityData.PrefabInformation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, nameof (PrefabInformation));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityData.PrefabInformation>.NativeClassPtr);
        PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.PrefabInformation>.NativeClassPtr, nameof (PrefabGUID));
        PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_PrefabName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.PrefabInformation>.NativeClassPtr, nameof (PrefabName));
        PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_PrefabArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.PrefabInformation>.NativeClassPtr, nameof (PrefabArchetype));
        PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_LinkedEntityArchetypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.PrefabInformation>.NativeClassPtr, nameof (LinkedEntityArchetypes));
        PersistenceCompatibilityData.PrefabInformation.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.PrefabInformation>.NativeClassPtr, 100687951);
        PersistenceCompatibilityData.PrefabInformation.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PrefabInformation_PersistenceCompatibilityChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.PrefabInformation>.NativeClassPtr, 100687952);
      }

      public PrefabInformation(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public PrefabInformation()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PersistenceCompatibilityData.PrefabInformation>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceCompatibilityData.PrefabInformation>.NativeClassPtr, data));
      }

      public unsafe PrefabGUID PrefabGUID
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_PrefabGUID));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_PrefabGUID)) = value;
        }
      }

      public unsafe string PrefabName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_PrefabName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_PrefabName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public PersistenceCompatibilityData.PersistentEntityArchetype PrefabArchetype
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_PrefabArchetype);
          return new PersistenceCompatibilityData.PersistentEntityArchetype(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_PrefabArchetype), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Il2CppReferenceArray<PersistenceCompatibilityData.PersistentEntityArchetype> LinkedEntityArchetypes
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_LinkedEntityArchetypes));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<PersistenceCompatibilityData.PersistentEntityArchetype>) null : new Il2CppReferenceArray<PersistenceCompatibilityData.PersistentEntityArchetype>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PrefabInformation.NativeFieldInfoPtr_LinkedEntityArchetypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class PersistentEntityArchetype : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_NonPersistentComponents;
      private static readonly System.IntPtr NativeFieldInfoPtr_PersistentComponents;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PersistentEntityArchetype_PersistenceCompatibilityChecker_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PersistentEntityArchetype_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ArraysEqual_Private_Static_Boolean_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110894, XrefRangeEnd = 1110896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe string GetName()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110896, XrefRangeEnd = 1110921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void CanLoadSaveFrom(
        PersistenceCompatibilityData.PersistentEntityArchetype previousVersion,
        PersistenceCompatibilityChecker checker)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) previousVersion));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checker);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PersistentEntityArchetype_PersistenceCompatibilityChecker_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110921, XrefRangeEnd = 1110926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(
        PersistenceCompatibilityData.PersistentEntityArchetype other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PersistentEntityArchetype_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1110926, RefRangeEnd = 1110930, XrefRangeStart = 1110926, XrefRangeEnd = 1110926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool ArraysEqual<T>(Il2CppArrayBase<T> mine, Il2CppArrayBase<T> other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mine);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.PersistentEntityArchetype.MethodInfoStoreGeneric_ArraysEqual_Private_Static_Boolean_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110930, XrefRangeEnd = 1110933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe bool Equals(Il2CppSystem.Object obj)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110933, XrefRangeEnd = 1110938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static PersistentEntityArchetype()
      {
        Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, nameof (PersistentEntityArchetype));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr);
        PersistenceCompatibilityData.PersistentEntityArchetype.NativeFieldInfoPtr_NonPersistentComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, nameof (NonPersistentComponents));
        PersistenceCompatibilityData.PersistentEntityArchetype.NativeFieldInfoPtr_PersistentComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, nameof (PersistentComponents));
        PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, 100687953);
        PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PersistentEntityArchetype_PersistenceCompatibilityChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, 100687954);
        PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PersistentEntityArchetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, 100687955);
        PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_ArraysEqual_Private_Static_Boolean_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, 100687956);
        PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, 100687957);
        PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, 100687958);
      }

      public PersistentEntityArchetype(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public PersistentEntityArchetype()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr, data));
      }

      public unsafe Il2CppStringArray NonPersistentComponents
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PersistentEntityArchetype.NativeFieldInfoPtr_NonPersistentComponents));
          return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PersistentEntityArchetype.NativeFieldInfoPtr_NonPersistentComponents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppStringArray PersistentComponents
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PersistentEntityArchetype.NativeFieldInfoPtr_PersistentComponents));
          return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PersistentEntityArchetype.NativeFieldInfoPtr_PersistentComponents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      private sealed class MethodInfoStoreGeneric_ArraysEqual_Private_Static_Boolean_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
      {
        internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PersistenceCompatibilityData.PersistentEntityArchetype.NativeMethodInfoPtr_ArraysEqual_Private_Static_Boolean_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<PersistenceCompatibilityData.PersistentEntityArchetype>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))));
      }
    }

    public sealed class WorldData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Chunks;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_WorldData_PersistenceCompatibilityChecker_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110938, XrefRangeEnd = 1110940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe string GetName()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.WorldData.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1110945, RefRangeEnd = 1110946, XrefRangeStart = 1110940, XrefRangeEnd = 1110945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void CanLoadSaveFrom(
        PersistenceCompatibilityData.WorldData previousVersion,
        PersistenceCompatibilityChecker checker)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) previousVersion));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checker);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.WorldData.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_WorldData_PersistenceCompatibilityChecker_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static WorldData()
      {
        Il2CppClassPointerStore<PersistenceCompatibilityData.WorldData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, nameof (WorldData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityData.WorldData>.NativeClassPtr);
        PersistenceCompatibilityData.WorldData.NativeFieldInfoPtr_Chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.WorldData>.NativeClassPtr, nameof (Chunks));
        PersistenceCompatibilityData.WorldData.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.WorldData>.NativeClassPtr, 100687959);
        PersistenceCompatibilityData.WorldData.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_WorldData_PersistenceCompatibilityChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.WorldData>.NativeClassPtr, 100687960);
      }

      public WorldData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public WorldData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PersistenceCompatibilityData.WorldData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceCompatibilityData.WorldData>.NativeClassPtr, data));
      }

      public unsafe Dictionary<TerrainChunk, PersistenceCompatibilityData.PlacedChunkData> Chunks
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.WorldData.NativeFieldInfoPtr_Chunks));
          return pointer == System.IntPtr.Zero ? (Dictionary<TerrainChunk, PersistenceCompatibilityData.PlacedChunkData>) null : new Dictionary<TerrainChunk, PersistenceCompatibilityData.PlacedChunkData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.WorldData.NativeFieldInfoPtr_Chunks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class PlacedChunkData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkCoordinate;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRotation;
      private static readonly System.IntPtr NativeFieldInfoPtr_SceneGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_StaticTransforms;
      private static readonly System.IntPtr NativeFieldInfoPtr_BusStops;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PlacedChunkData_PersistenceCompatibilityChecker_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110946, XrefRangeEnd = 1110950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe string GetName()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.PlacedChunkData.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110950, XrefRangeEnd = 1110993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void CanLoadSaveFrom(
        PersistenceCompatibilityData.PlacedChunkData previousVersion,
        PersistenceCompatibilityChecker checker)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) previousVersion));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checker);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.PlacedChunkData.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PlacedChunkData_PersistenceCompatibilityChecker_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static PlacedChunkData()
      {
        Il2CppClassPointerStore<PersistenceCompatibilityData.PlacedChunkData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, nameof (PlacedChunkData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityData.PlacedChunkData>.NativeClassPtr);
        PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_ChunkCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.PlacedChunkData>.NativeClassPtr, nameof (ChunkCoordinate));
        PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_ChunkRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.PlacedChunkData>.NativeClassPtr, nameof (ChunkRotation));
        PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_SceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.PlacedChunkData>.NativeClassPtr, nameof (SceneGUID));
        PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_StaticTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.PlacedChunkData>.NativeClassPtr, nameof (StaticTransforms));
        PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_BusStops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.PlacedChunkData>.NativeClassPtr, nameof (BusStops));
        PersistenceCompatibilityData.PlacedChunkData.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.PlacedChunkData>.NativeClassPtr, 100687961);
        PersistenceCompatibilityData.PlacedChunkData.NativeMethodInfoPtr_CanLoadSaveFrom_Public_Virtual_Final_New_Void_PlacedChunkData_PersistenceCompatibilityChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.PlacedChunkData>.NativeClassPtr, 100687962);
      }

      public PlacedChunkData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public PlacedChunkData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PersistenceCompatibilityData.PlacedChunkData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistenceCompatibilityData.PlacedChunkData>.NativeClassPtr, data));
      }

      public unsafe TerrainChunk ChunkCoordinate
      {
        get
        {
          return *(TerrainChunk*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_ChunkCoordinate));
        }
        [param: In] set
        {
          *(TerrainChunk*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_ChunkCoordinate)) = value;
        }
      }

      public unsafe OrthogonalRotation ChunkRotation
      {
        get
        {
          return *(OrthogonalRotation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_ChunkRotation));
        }
        [param: In] set
        {
          *(OrthogonalRotation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_ChunkRotation)) = value;
        }
      }

      public unsafe SubSceneGUID SceneGUID
      {
        get
        {
          return *(SubSceneGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_SceneGUID));
        }
        [param: In] set
        {
          *(SubSceneGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_SceneGUID)) = value;
        }
      }

      public unsafe Il2CppStructArray<float4x4> StaticTransforms
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_StaticTransforms));
          return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float4x4>) null : new Il2CppStructArray<float4x4>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_StaticTransforms), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe HashSet<AssetGuid> BusStops
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_BusStops));
          return pointer == System.IntPtr.Zero ? (HashSet<AssetGuid>) null : new HashSet<AssetGuid>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistenceCompatibilityData.PlacedChunkData.NativeFieldInfoPtr_BusStops), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Compatibility.PersistenceCompatibilityData/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__6_3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__6_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__6_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__6_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__8_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SerializeGameDataCollection_b__6_3_Internal_Int32_KeyValuePair_2_String_Int32_KeyValuePair_2_String_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SerializeGameDataCollection_b__6_0_Internal_Int32_ComponentInformation_ComponentInformation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SerializeGameDataCollection_b__6_1_Internal_Int32_ComponentInformation_ComponentInformation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SerializeGameDataCollection_b__6_2_Internal_Int32_PrefabInformation_PrefabInformation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SerializeWorldData_b__8_0_Internal_Int32_PlacedChunkData_PlacedChunkData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SerializeWorldData_b__8_1_Internal_Int32_AssetGuid_AssetGuid_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110993, XrefRangeEnd = 1111003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _SerializeGameDataCollection_b__6_3(
        KeyValuePair<string, int> a,
        KeyValuePair<string, int> b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeGameDataCollection_b__6_3_Internal_Int32_KeyValuePair_2_String_Int32_KeyValuePair_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111003, XrefRangeEnd = 1111012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _SerializeGameDataCollection_b__6_0(
        PersistenceCompatibilityData.ComponentInformation a,
        PersistenceCompatibilityData.ComponentInformation b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeGameDataCollection_b__6_0_Internal_Int32_ComponentInformation_ComponentInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111012, XrefRangeEnd = 1111021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _SerializeGameDataCollection_b__6_1(
        PersistenceCompatibilityData.ComponentInformation a,
        PersistenceCompatibilityData.ComponentInformation b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeGameDataCollection_b__6_1_Internal_Int32_ComponentInformation_ComponentInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111021, XrefRangeEnd = 1111022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _SerializeGameDataCollection_b__6_2(
        PersistenceCompatibilityData.PrefabInformation a,
        PersistenceCompatibilityData.PrefabInformation b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeGameDataCollection_b__6_2_Internal_Int32_PrefabInformation_PrefabInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111022, XrefRangeEnd = 1111023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _SerializeWorldData_b__8_0(
        PersistenceCompatibilityData.PlacedChunkData a,
        PersistenceCompatibilityData.PlacedChunkData b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeWorldData_b__8_0_Internal_Int32_PlacedChunkData_PlacedChunkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111023, XrefRangeEnd = 1111024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _SerializeWorldData_b__8_1(AssetGuid a, AssetGuid b)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeWorldData_b__8_1_Internal_Int32_AssetGuid_AssetGuid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistenceCompatibilityData>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr);
        PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, "<>9");
        PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, "<>9__6_3");
        PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, "<>9__6_0");
        PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, "<>9__6_1");
        PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, "<>9__6_2");
        PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, "<>9__8_0");
        PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, "<>9__8_1");
        PersistenceCompatibilityData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, 100687964);
        PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeGameDataCollection_b__6_3_Internal_Int32_KeyValuePair_2_String_Int32_KeyValuePair_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, 100687965);
        PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeGameDataCollection_b__6_0_Internal_Int32_ComponentInformation_ComponentInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, 100687966);
        PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeGameDataCollection_b__6_1_Internal_Int32_ComponentInformation_ComponentInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, 100687967);
        PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeGameDataCollection_b__6_2_Internal_Int32_PrefabInformation_PrefabInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, 100687968);
        PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeWorldData_b__8_0_Internal_Int32_PlacedChunkData_PlacedChunkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, 100687969);
        PersistenceCompatibilityData.__c.NativeMethodInfoPtr__SerializeWorldData_b__8_1_Internal_Int32_AssetGuid_AssetGuid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceCompatibilityData.__c>.NativeClassPtr, 100687970);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe PersistenceCompatibilityData.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (PersistenceCompatibilityData.__c) null : new PersistenceCompatibilityData.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<KeyValuePair<string, int>> __9__6_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<KeyValuePair<string, int>>) null : new Il2CppSystem.Comparison<KeyValuePair<string, int>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<PersistenceCompatibilityData.ComponentInformation> __9__6_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<PersistenceCompatibilityData.ComponentInformation>) null : new Il2CppSystem.Comparison<PersistenceCompatibilityData.ComponentInformation>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<PersistenceCompatibilityData.ComponentInformation> __9__6_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<PersistenceCompatibilityData.ComponentInformation>) null : new Il2CppSystem.Comparison<PersistenceCompatibilityData.ComponentInformation>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<PersistenceCompatibilityData.PrefabInformation> __9__6_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<PersistenceCompatibilityData.PrefabInformation>) null : new Il2CppSystem.Comparison<PersistenceCompatibilityData.PrefabInformation>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__6_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<PersistenceCompatibilityData.PlacedChunkData> __9__8_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<PersistenceCompatibilityData.PlacedChunkData>) null : new Il2CppSystem.Comparison<PersistenceCompatibilityData.PlacedChunkData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<AssetGuid> __9__8_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__8_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<AssetGuid>) null : new Il2CppSystem.Comparison<AssetGuid>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PersistenceCompatibilityData.__c.NativeFieldInfoPtr___9__8_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
