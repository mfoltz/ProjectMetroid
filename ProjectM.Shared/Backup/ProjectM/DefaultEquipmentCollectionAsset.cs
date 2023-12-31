// Decompiled with JetBrains decompiler
// Type: ProjectM.DefaultEquipmentCollectionAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class DefaultEquipmentCollectionAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Boots;
    private static readonly IntPtr NativeFieldInfoPtr_Chest;
    private static readonly IntPtr NativeFieldInfoPtr_Gloves;
    private static readonly IntPtr NativeFieldInfoPtr_Legs;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734496, XrefRangeEnd = 734534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultEquipmentCollectionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DefaultEquipmentCollectionAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultEquipmentCollectionAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DefaultEquipmentCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DefaultEquipmentCollectionAsset()
    {
      Il2CppClassPointerStore<DefaultEquipmentCollectionAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DefaultEquipmentCollectionAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultEquipmentCollectionAsset>.NativeClassPtr);
      DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Boots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEquipmentCollectionAsset>.NativeClassPtr, nameof (Boots));
      DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Chest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEquipmentCollectionAsset>.NativeClassPtr, nameof (Chest));
      DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Gloves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEquipmentCollectionAsset>.NativeClassPtr, nameof (Gloves));
      DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Legs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultEquipmentCollectionAsset>.NativeClassPtr, nameof (Legs));
      DefaultEquipmentCollectionAsset.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEquipmentCollectionAsset>.NativeClassPtr, 100664868);
      DefaultEquipmentCollectionAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultEquipmentCollectionAsset>.NativeClassPtr, 100664869);
    }

    public DefaultEquipmentCollectionAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject Boots
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Boots));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Boots), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Chest
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Chest));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Chest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Gloves
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Gloves));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Gloves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Legs
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Legs));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultEquipmentCollectionAsset.NativeFieldInfoPtr_Legs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
