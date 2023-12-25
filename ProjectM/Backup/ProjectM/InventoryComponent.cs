// Decompiled with JetBrains decompiler
// Type: ProjectM.InventoryComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class InventoryComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Slots;
    private static readonly IntPtr NativeFieldInfoPtr_StartInventoryItems;
    private static readonly IntPtr NativeFieldInfoPtr_RestrictedType;
    private static readonly IntPtr NativeFieldInfoPtr_RestrictedCategory;
    private static readonly IntPtr NativeFieldInfoPtr_SyncInventory;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_DoConvert_Public_Static_Void_Entity_EntityManager_Int32_List_1_InventoryItem_Editor_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020001, XrefRangeEnd = 1020025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1020058, RefRangeEnd = 1020059, XrefRangeStart = 1020025, XrefRangeEnd = 1020058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DoConvert(
      Entity entity,
      EntityManager dstManager,
      int slots,
      List<InventoryItem_Editor> startInventoryItems = null)
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &slots;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) startInventoryItems);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryComponent.NativeMethodInfoPtr_DoConvert_Public_Static_Void_Entity_EntityManager_Int32_List_1_InventoryItem_Editor_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020059, XrefRangeEnd = 1020062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InventoryComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020062, XrefRangeEnd = 1020063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InventoryComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InventoryComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InventoryComponent()
    {
      Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (InventoryComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr);
      InventoryComponent.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr, nameof (Slots));
      InventoryComponent.NativeFieldInfoPtr_StartInventoryItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr, nameof (StartInventoryItems));
      InventoryComponent.NativeFieldInfoPtr_RestrictedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr, nameof (RestrictedType));
      InventoryComponent.NativeFieldInfoPtr_RestrictedCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr, nameof (RestrictedCategory));
      InventoryComponent.NativeFieldInfoPtr_SyncInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr, nameof (SyncInventory));
      InventoryComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr, 100679598);
      InventoryComponent.NativeMethodInfoPtr_DoConvert_Public_Static_Void_Entity_EntityManager_Int32_List_1_InventoryItem_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr, 100679599);
      InventoryComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr, 100679600);
      InventoryComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryComponent>.NativeClassPtr, 100679601);
    }

    public InventoryComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int Slots
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryComponent.NativeFieldInfoPtr_Slots));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryComponent.NativeFieldInfoPtr_Slots)) = value;
      }
    }

    public unsafe List<InventoryItem_Editor> StartInventoryItems
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryComponent.NativeFieldInfoPtr_StartInventoryItems));
        return pointer == IntPtr.Zero ? (List<InventoryItem_Editor>) null : new List<InventoryItem_Editor>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryComponent.NativeFieldInfoPtr_StartInventoryItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent RestrictedType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryComponent.NativeFieldInfoPtr_RestrictedType));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InventoryComponent.NativeFieldInfoPtr_RestrictedType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe long RestrictedCategory
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryComponent.NativeFieldInfoPtr_RestrictedCategory));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryComponent.NativeFieldInfoPtr_RestrictedCategory)) = value;
      }
    }

    public unsafe bool SyncInventory
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryComponent.NativeFieldInfoPtr_SyncInventory));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InventoryComponent.NativeFieldInfoPtr_SyncInventory)) = value;
      }
    }
  }
}
