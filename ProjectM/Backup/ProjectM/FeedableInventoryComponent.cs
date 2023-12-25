// Decompiled with JetBrains decompiler
// Type: ProjectM.FeedableInventoryComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class FeedableInventoryComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_NetworkedInventory;
    private static readonly IntPtr NativeFieldInfoPtr_RequiredItem;
    private static readonly IntPtr NativeFieldInfoPtr_TimePerFeed;
    private static readonly IntPtr NativeFieldInfoPtr_DamageTickTime;
    private static readonly IntPtr NativeFieldInfoPtr_DamageTickPercentage;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019457, XrefRangeEnd = 1019462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(FeedableInventoryComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019462, XrefRangeEnd = 1019466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FeedableInventoryComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1019466, XrefRangeEnd = 1019467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FeedableInventoryComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedableInventoryComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FeedableInventoryComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FeedableInventoryComponent()
    {
      Il2CppClassPointerStore<FeedableInventoryComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (FeedableInventoryComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedableInventoryComponent>.NativeClassPtr);
      FeedableInventoryComponent.NativeFieldInfoPtr_NetworkedInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventoryComponent>.NativeClassPtr, nameof (NetworkedInventory));
      FeedableInventoryComponent.NativeFieldInfoPtr_RequiredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventoryComponent>.NativeClassPtr, nameof (RequiredItem));
      FeedableInventoryComponent.NativeFieldInfoPtr_TimePerFeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventoryComponent>.NativeClassPtr, nameof (TimePerFeed));
      FeedableInventoryComponent.NativeFieldInfoPtr_DamageTickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventoryComponent>.NativeClassPtr, nameof (DamageTickTime));
      FeedableInventoryComponent.NativeFieldInfoPtr_DamageTickPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedableInventoryComponent>.NativeClassPtr, nameof (DamageTickPercentage));
      FeedableInventoryComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedableInventoryComponent>.NativeClassPtr, 100679538);
      FeedableInventoryComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedableInventoryComponent>.NativeClassPtr, 100679539);
      FeedableInventoryComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedableInventoryComponent>.NativeClassPtr, 100679540);
    }

    public FeedableInventoryComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<InventoryComponent> NetworkedInventory
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedableInventoryComponent.NativeFieldInfoPtr_NetworkedInventory));
        return pointer == IntPtr.Zero ? (WeakAssetReference<InventoryComponent>) null : new WeakAssetReference<InventoryComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedableInventoryComponent.NativeFieldInfoPtr_NetworkedInventory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<ItemDataComponent> RequiredItem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedableInventoryComponent.NativeFieldInfoPtr_RequiredItem));
        return pointer == IntPtr.Zero ? (WeakAssetReference<ItemDataComponent>) null : new WeakAssetReference<ItemDataComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedableInventoryComponent.NativeFieldInfoPtr_RequiredItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float TimePerFeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedableInventoryComponent.NativeFieldInfoPtr_TimePerFeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedableInventoryComponent.NativeFieldInfoPtr_TimePerFeed)) = value;
      }
    }

    public unsafe float DamageTickTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedableInventoryComponent.NativeFieldInfoPtr_DamageTickTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedableInventoryComponent.NativeFieldInfoPtr_DamageTickTime)) = value;
      }
    }

    public unsafe float DamageTickPercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedableInventoryComponent.NativeFieldInfoPtr_DamageTickPercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedableInventoryComponent.NativeFieldInfoPtr_DamageTickPercentage)) = value;
      }
    }
  }
}
