// Decompiled with JetBrains decompiler
// Type: Tests.UnitTestPrefabCollection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Tests
{
  public class UnitTestPrefabCollection : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AssetsToConvertWithIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_AssetsToConvert;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnitTestPrefabCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitTestPrefabCollection>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnitTestPrefabCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UnitTestPrefabCollection()
    {
      Il2CppClassPointerStore<UnitTestPrefabCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Tests", nameof (UnitTestPrefabCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitTestPrefabCollection>.NativeClassPtr);
      UnitTestPrefabCollection.NativeFieldInfoPtr_AssetsToConvertWithIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitTestPrefabCollection>.NativeClassPtr, nameof (AssetsToConvertWithIds));
      UnitTestPrefabCollection.NativeFieldInfoPtr_AssetsToConvert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitTestPrefabCollection>.NativeClassPtr, nameof (AssetsToConvert));
      UnitTestPrefabCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitTestPrefabCollection>.NativeClassPtr, 100663538);
    }

    public UnitTestPrefabCollection(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<UnitTestPrefabCollection.AssetWithId> AssetsToConvertWithIds
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitTestPrefabCollection.NativeFieldInfoPtr_AssetsToConvertWithIds));
        return pointer == System.IntPtr.Zero ? (List<UnitTestPrefabCollection.AssetWithId>) null : new List<UnitTestPrefabCollection.AssetWithId>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitTestPrefabCollection.NativeFieldInfoPtr_AssetsToConvertWithIds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<UnityEngine.Object> AssetsToConvert
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitTestPrefabCollection.NativeFieldInfoPtr_AssetsToConvert));
        return pointer == System.IntPtr.Zero ? (List<UnityEngine.Object>) null : new List<UnityEngine.Object>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitTestPrefabCollection.NativeFieldInfoPtr_AssetsToConvert), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class AssetWithId : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AssetId;
      private static readonly System.IntPtr NativeFieldInfoPtr_Asset;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AssetWithId()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitTestPrefabCollection.AssetWithId>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnitTestPrefabCollection.AssetWithId.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AssetWithId()
      {
        Il2CppClassPointerStore<UnitTestPrefabCollection.AssetWithId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitTestPrefabCollection>.NativeClassPtr, nameof (AssetWithId));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitTestPrefabCollection.AssetWithId>.NativeClassPtr);
        UnitTestPrefabCollection.AssetWithId.NativeFieldInfoPtr_AssetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitTestPrefabCollection.AssetWithId>.NativeClassPtr, nameof (AssetId));
        UnitTestPrefabCollection.AssetWithId.NativeFieldInfoPtr_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitTestPrefabCollection.AssetWithId>.NativeClassPtr, nameof (Asset));
        UnitTestPrefabCollection.AssetWithId.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitTestPrefabCollection.AssetWithId>.NativeClassPtr, 100663539);
      }

      public AssetWithId(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string AssetId
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitTestPrefabCollection.AssetWithId.NativeFieldInfoPtr_AssetId)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitTestPrefabCollection.AssetWithId.NativeFieldInfoPtr_AssetId), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe UnityEngine.Object Asset
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitTestPrefabCollection.AssetWithId.NativeFieldInfoPtr_Asset));
          return pointer == System.IntPtr.Zero ? (UnityEngine.Object) null : new UnityEngine.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitTestPrefabCollection.AssetWithId.NativeFieldInfoPtr_Asset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
