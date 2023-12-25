// Decompiled with JetBrains decompiler
// Type: ProjectM.ExternalInventoryComponent
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
  public class ExternalInventoryComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryInstances;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoConvert_Public_Static_Void_Entity_EntityManager_List_1_InventoryInstancesData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019174, XrefRangeEnd = 1019191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ExternalInventoryComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019191, XrefRangeEnd = 1019195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ExternalInventoryComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019195, XrefRangeEnd = 1019212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DoConvert(
      Entity entity,
      EntityManager dstManager,
      List<ExternalInventoryComponent.InventoryInstancesData> inventoryInstanceDatas)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inventoryInstanceDatas);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalInventoryComponent.NativeMethodInfoPtr_DoConvert_Public_Static_Void_Entity_EntityManager_List_1_InventoryInstancesData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019212, XrefRangeEnd = 1019224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ExternalInventoryComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalInventoryComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExternalInventoryComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ExternalInventoryComponent()
    {
      Il2CppClassPointerStore<ExternalInventoryComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ExternalInventoryComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalInventoryComponent>.NativeClassPtr);
      ExternalInventoryComponent.NativeFieldInfoPtr_InventoryInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalInventoryComponent>.NativeClassPtr, nameof (InventoryInstances));
      ExternalInventoryComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalInventoryComponent>.NativeClassPtr, 100679502);
      ExternalInventoryComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalInventoryComponent>.NativeClassPtr, 100679503);
      ExternalInventoryComponent.NativeMethodInfoPtr_DoConvert_Public_Static_Void_Entity_EntityManager_List_1_InventoryInstancesData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalInventoryComponent>.NativeClassPtr, 100679504);
      ExternalInventoryComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalInventoryComponent>.NativeClassPtr, 100679505);
    }

    public ExternalInventoryComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<ExternalInventoryComponent.InventoryInstancesData> InventoryInstances
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalInventoryComponent.NativeFieldInfoPtr_InventoryInstances));
        return pointer == System.IntPtr.Zero ? (List<ExternalInventoryComponent.InventoryInstancesData>) null : new List<ExternalInventoryComponent.InventoryInstancesData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExternalInventoryComponent.NativeFieldInfoPtr_InventoryInstances), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class InventoryInstancesData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_Slots;
      private static readonly System.IntPtr NativeFieldInfoPtr_ExternalInventoryEntity;

      static InventoryInstancesData()
      {
        Il2CppClassPointerStore<ExternalInventoryComponent.InventoryInstancesData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExternalInventoryComponent>.NativeClassPtr, nameof (InventoryInstancesData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalInventoryComponent.InventoryInstancesData>.NativeClassPtr);
        ExternalInventoryComponent.InventoryInstancesData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalInventoryComponent.InventoryInstancesData>.NativeClassPtr, nameof (Type));
        ExternalInventoryComponent.InventoryInstancesData.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalInventoryComponent.InventoryInstancesData>.NativeClassPtr, nameof (Slots));
        ExternalInventoryComponent.InventoryInstancesData.NativeFieldInfoPtr_ExternalInventoryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalInventoryComponent.InventoryInstancesData>.NativeClassPtr, nameof (ExternalInventoryEntity));
      }

      public InventoryInstancesData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public InventoryInstancesData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExternalInventoryComponent.InventoryInstancesData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExternalInventoryComponent.InventoryInstancesData>.NativeClassPtr, data));
      }

      public unsafe InventoryInstanceElement.InstanceCategory Type
      {
        get
        {
          return *(InventoryInstanceElement.InstanceCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalInventoryComponent.InventoryInstancesData.NativeFieldInfoPtr_Type));
        }
        [param: In] set
        {
          *(InventoryInstanceElement.InstanceCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalInventoryComponent.InventoryInstancesData.NativeFieldInfoPtr_Type)) = value;
        }
      }

      public unsafe int Slots
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalInventoryComponent.InventoryInstancesData.NativeFieldInfoPtr_Slots));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalInventoryComponent.InventoryInstancesData.NativeFieldInfoPtr_Slots)) = value;
        }
      }

      public unsafe WeakAssetReference<InventoryComponent> ExternalInventoryEntity
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalInventoryComponent.InventoryInstancesData.NativeFieldInfoPtr_ExternalInventoryEntity));
          return pointer == System.IntPtr.Zero ? (WeakAssetReference<InventoryComponent>) null : new WeakAssetReference<InventoryComponent>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExternalInventoryComponent.InventoryInstancesData.NativeFieldInfoPtr_ExternalInventoryEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
