// Decompiled with JetBrains decompiler
// Type: ProjectM.Roofs.TestWorld
// Assembly: ProjectM.Roofs, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D6B6D22B-4E3A-4809-82A6-CC2DECC85297
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Roofs.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Roofs
{
  public class TestWorld : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabGUIDById;
    private static readonly System.IntPtr NativeFieldInfoPtr_World;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabCollectionAuthoring;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerDebugSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabCollectionSystem;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_NetworkedSequence_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_CastleTeam_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_CastleTerritory_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_BloodFountain_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_CastleRoom_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_StandardFloor_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_StandardPillar_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_StandardWall_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_BP_Wall_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_ForgeFloor_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_Stairs_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PrefabGUID_Stairs180_Public_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EntityManager_Public_get_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PreSetup_Public_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertPrefabs_Private_Void_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PreConversionSetup_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGUID_NetworkedSequence
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637323, XrefRangeEnd = 1637329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_NetworkedSequence_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGUID_CastleTeam
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637329, XrefRangeEnd = 1637335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_CastleTeam_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGUID_CastleTerritory
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637335, XrefRangeEnd = 1637341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_CastleTerritory_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGUID_BloodFountain
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1637347, RefRangeEnd = 1637349, XrefRangeStart = 1637341, XrefRangeEnd = 1637347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_BloodFountain_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGUID_CastleRoom
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637349, XrefRangeEnd = 1637355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_CastleRoom_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGUID_StandardFloor
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637355, XrefRangeEnd = 1637361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_StandardFloor_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGUID_StandardPillar
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637361, XrefRangeEnd = 1637367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_StandardPillar_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGUID_StandardWall
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637367, XrefRangeEnd = 1637966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_StandardWall_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGUID_BP_Wall
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637966, XrefRangeEnd = 1637972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_BP_Wall_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGUID_ForgeFloor
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637972, XrefRangeEnd = 1637978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_ForgeFloor_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGUID_Stairs
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637978, XrefRangeEnd = 1637984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_Stairs_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe PrefabGUID PrefabGUID_Stairs180
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637984, XrefRangeEnd = 1637990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_PrefabGUID_Stairs180_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe EntityManager EntityManager
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1637992, RefRangeEnd = 1637994, XrefRangeStart = 1637990, XrefRangeEnd = 1637992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_get_EntityManager_Public_get_EntityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(EntityManager*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1637994, XrefRangeEnd = 1637998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabGUID GetPrefabGUID(string assetId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(assetId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1638002, RefRangeEnd = 1638010, XrefRangeStart = 1637998, XrefRangeEnd = 1638002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetPrefabEntity(string assetId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(assetId);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638010, XrefRangeEnd = 1638011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entity GetPrefabEntity(PrefabGUID prefabGUID)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGUID;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PreSetup(string prefabCollectionPath)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(prefabCollectionPath);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_PreSetup_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638011, XrefRangeEnd = 1638020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Setup(World world)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_Setup_Public_Void_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1638079, RefRangeEnd = 1638081, XrefRangeStart = 1638020, XrefRangeEnd = 1638079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ConvertPrefabs(World world)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_ConvertPrefabs_Private_Void_World_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1638102, RefRangeEnd = 1638103, XrefRangeStart = 1638081, XrefRangeEnd = 1638102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PreConversionSetup()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr_PreConversionSetup_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1638103, XrefRangeEnd = 1638111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TestWorld()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TestWorld>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TestWorld.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TestWorld()
    {
      Il2CppClassPointerStore<TestWorld>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Roofs.dll", "ProjectM.Roofs", nameof (TestWorld));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TestWorld>.NativeClassPtr);
      TestWorld.NativeFieldInfoPtr__PrefabGUIDById = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, nameof (_PrefabGUIDById));
      TestWorld.NativeFieldInfoPtr_World = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, nameof (World));
      TestWorld.NativeFieldInfoPtr_PrefabCollectionAuthoring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, nameof (PrefabCollectionAuthoring));
      TestWorld.NativeFieldInfoPtr_ServerDebugSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, nameof (ServerDebugSettings));
      TestWorld.NativeFieldInfoPtr_PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, nameof (PrefabCollectionSystem));
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_NetworkedSequence_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663320);
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_CastleTeam_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663321);
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_CastleTerritory_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663322);
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_BloodFountain_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663323);
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_CastleRoom_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663324);
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_StandardFloor_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663325);
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_StandardPillar_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663326);
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_StandardWall_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663327);
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_BP_Wall_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663328);
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_ForgeFloor_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663329);
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_Stairs_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663330);
      TestWorld.NativeMethodInfoPtr_get_PrefabGUID_Stairs180_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663331);
      TestWorld.NativeMethodInfoPtr_get_EntityManager_Public_get_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663332);
      TestWorld.NativeMethodInfoPtr_GetPrefabGUID_Public_PrefabGUID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663333);
      TestWorld.NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663334);
      TestWorld.NativeMethodInfoPtr_GetPrefabEntity_Public_Entity_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663335);
      TestWorld.NativeMethodInfoPtr_PreSetup_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663336);
      TestWorld.NativeMethodInfoPtr_Setup_Public_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663337);
      TestWorld.NativeMethodInfoPtr_ConvertPrefabs_Private_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663338);
      TestWorld.NativeMethodInfoPtr_PreConversionSetup_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663339);
      TestWorld.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TestWorld>.NativeClassPtr, 100663340);
    }

    public TestWorld(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Dictionary<string, PrefabGUID> _PrefabGUIDById
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestWorld.NativeFieldInfoPtr__PrefabGUIDById));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, PrefabGUID>) null : new Dictionary<string, PrefabGUID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TestWorld.NativeFieldInfoPtr__PrefabGUIDById), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe World World
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestWorld.NativeFieldInfoPtr_World));
        return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TestWorld.NativeFieldInfoPtr_World), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabCollectionAuthoring PrefabCollectionAuthoring
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestWorld.NativeFieldInfoPtr_PrefabCollectionAuthoring));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionAuthoring) null : new PrefabCollectionAuthoring(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TestWorld.NativeFieldInfoPtr_PrefabCollectionAuthoring), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<SyncedServerDebugSettings> ServerDebugSettings
    {
      get
      {
        return *(SingletonAccessor<SyncedServerDebugSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestWorld.NativeFieldInfoPtr_ServerDebugSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestWorld.NativeFieldInfoPtr_ServerDebugSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SyncedServerDebugSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe PrefabCollectionSystem PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TestWorld.NativeFieldInfoPtr_PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TestWorld.NativeFieldInfoPtr_PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
