// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.DebugCastlePrefabsCollection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class DebugCastlePrefabsCollection : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_CastleHeart;
    private static readonly IntPtr NativeFieldInfoPtr_Floor;
    private static readonly IntPtr NativeFieldInfoPtr_Wall;
    private static readonly IntPtr NativeFieldInfoPtr_Pillar;
    private static readonly IntPtr NativeFieldInfoPtr__Guid;
    private static readonly IntPtr NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe PrefabGUID PrefabGuid
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 748888, RefRangeEnd = 748893, XrefRangeStart = 748888, XrefRangeEnd = 748893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugCastlePrefabsCollection.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1127255, XrefRangeEnd = 1127269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugCastlePrefabsCollection.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugCastlePrefabsCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugCastlePrefabsCollection>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugCastlePrefabsCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugCastlePrefabsCollection()
    {
      Il2CppClassPointerStore<DebugCastlePrefabsCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (DebugCastlePrefabsCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugCastlePrefabsCollection>.NativeClassPtr);
      DebugCastlePrefabsCollection.NativeFieldInfoPtr_CastleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCastlePrefabsCollection>.NativeClassPtr, nameof (CastleHeart));
      DebugCastlePrefabsCollection.NativeFieldInfoPtr_Floor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCastlePrefabsCollection>.NativeClassPtr, nameof (Floor));
      DebugCastlePrefabsCollection.NativeFieldInfoPtr_Wall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCastlePrefabsCollection>.NativeClassPtr, nameof (Wall));
      DebugCastlePrefabsCollection.NativeFieldInfoPtr_Pillar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCastlePrefabsCollection>.NativeClassPtr, nameof (Pillar));
      DebugCastlePrefabsCollection.NativeFieldInfoPtr__Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugCastlePrefabsCollection>.NativeClassPtr, nameof (_Guid));
      DebugCastlePrefabsCollection.NativeMethodInfoPtr_get_PrefabGuid_Public_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCastlePrefabsCollection>.NativeClassPtr, 100689540);
      DebugCastlePrefabsCollection.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCastlePrefabsCollection>.NativeClassPtr, 100689541);
      DebugCastlePrefabsCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugCastlePrefabsCollection>.NativeClassPtr, 100689542);
    }

    public DebugCastlePrefabsCollection(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<GameObject> CastleHeart
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCastlePrefabsCollection.NativeFieldInfoPtr_CastleHeart));
        return pointer == IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCastlePrefabsCollection.NativeFieldInfoPtr_CastleHeart), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> Floor
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCastlePrefabsCollection.NativeFieldInfoPtr_Floor));
        return pointer == IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCastlePrefabsCollection.NativeFieldInfoPtr_Floor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> Wall
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCastlePrefabsCollection.NativeFieldInfoPtr_Wall));
        return pointer == IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCastlePrefabsCollection.NativeFieldInfoPtr_Wall), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> Pillar
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCastlePrefabsCollection.NativeFieldInfoPtr_Pillar));
        return pointer == IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCastlePrefabsCollection.NativeFieldInfoPtr_Pillar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugCastlePrefabsCollection.NativeFieldInfoPtr__Guid)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugCastlePrefabsCollection.NativeFieldInfoPtr__Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
