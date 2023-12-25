// Decompiled with JetBrains decompiler
// Type: ProjectM.ShatteredItemAuthoring
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
  public class ShatteredItemAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_RequiredItem;
    private static readonly IntPtr NativeFieldInfoPtr_OutputItem;
    private static readonly IntPtr NativeFieldInfoPtr_SharedShatteredCost;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993107, XrefRangeEnd = 993132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ShatteredItemAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShatteredItemAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShatteredItemAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShatteredItemAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShatteredItemAuthoring()
    {
      Il2CppClassPointerStore<ShatteredItemAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShatteredItemAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShatteredItemAuthoring>.NativeClassPtr);
      ShatteredItemAuthoring.NativeFieldInfoPtr_RequiredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShatteredItemAuthoring>.NativeClassPtr, nameof (RequiredItem));
      ShatteredItemAuthoring.NativeFieldInfoPtr_OutputItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShatteredItemAuthoring>.NativeClassPtr, nameof (OutputItem));
      ShatteredItemAuthoring.NativeFieldInfoPtr_SharedShatteredCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShatteredItemAuthoring>.NativeClassPtr, nameof (SharedShatteredCost));
      ShatteredItemAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShatteredItemAuthoring>.NativeClassPtr, 100676687);
      ShatteredItemAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShatteredItemAuthoring>.NativeClassPtr, 100676688);
    }

    public ShatteredItemAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<ItemDataComponent> RequiredItem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShatteredItemAuthoring.NativeFieldInfoPtr_RequiredItem));
        return pointer == IntPtr.Zero ? (WeakAssetReference<ItemDataComponent>) null : new WeakAssetReference<ItemDataComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShatteredItemAuthoring.NativeFieldInfoPtr_RequiredItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<ItemDataComponent> OutputItem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShatteredItemAuthoring.NativeFieldInfoPtr_OutputItem));
        return pointer == IntPtr.Zero ? (WeakAssetReference<ItemDataComponent>) null : new WeakAssetReference<ItemDataComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShatteredItemAuthoring.NativeFieldInfoPtr_OutputItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SharedItemRequirementAsset> SharedShatteredCost
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShatteredItemAuthoring.NativeFieldInfoPtr_SharedShatteredCost));
        return pointer == IntPtr.Zero ? (List<SharedItemRequirementAsset>) null : new List<SharedItemRequirementAsset>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShatteredItemAuthoring.NativeFieldInfoPtr_SharedShatteredCost), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
