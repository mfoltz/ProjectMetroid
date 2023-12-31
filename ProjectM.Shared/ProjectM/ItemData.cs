// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ItemData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SilverValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemTypeGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropItemPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropItemArc;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemType;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_RemoveOnConsume;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SoulBound_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_BloodBound_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CanBeDropped_Public_get_Boolean_0;
    [FieldOffset(0)]
    public float SilverValue;
    [FieldOffset(4)]
    public Entity Entity;
    [FieldOffset(12)]
    public PrefabGUID ItemTypeGUID;
    [FieldOffset(16)]
    public PrefabGUID DropItemPrefab;
    [FieldOffset(20)]
    public PrefabGUID DropItemArc;
    [FieldOffset(24)]
    public int MaxAmount;
    [FieldOffset(28)]
    public ItemType ItemType;
    [FieldOffset(32)]
    public ItemCategory ItemCategory;
    [FieldOffset(40)]
    public bool RemoveOnConsume;

    public unsafe bool SoulBound
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 727178, RefRangeEnd = 727184, XrefRangeStart = 727178, XrefRangeEnd = 727178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemData.NativeMethodInfoPtr_get_SoulBound_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool BloodBound
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 727184, RefRangeEnd = 727188, XrefRangeStart = 727184, XrefRangeEnd = 727184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemData.NativeMethodInfoPtr_get_BloodBound_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool CanBeDropped
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemData.NativeMethodInfoPtr_get_CanBeDropped_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static ItemData()
    {
      Il2CppClassPointerStore<ItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ItemData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemData>.NativeClassPtr);
      ItemData.NativeFieldInfoPtr_SilverValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, nameof (SilverValue));
      ItemData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, nameof (Entity));
      ItemData.NativeFieldInfoPtr_ItemTypeGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, nameof (ItemTypeGUID));
      ItemData.NativeFieldInfoPtr_DropItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, nameof (DropItemPrefab));
      ItemData.NativeFieldInfoPtr_DropItemArc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, nameof (DropItemArc));
      ItemData.NativeFieldInfoPtr_MaxAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, nameof (MaxAmount));
      ItemData.NativeFieldInfoPtr_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, nameof (ItemType));
      ItemData.NativeFieldInfoPtr_ItemCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, nameof (ItemCategory));
      ItemData.NativeFieldInfoPtr_RemoveOnConsume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, nameof (RemoveOnConsume));
      ItemData.NativeMethodInfoPtr_get_SoulBound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100664327);
      ItemData.NativeMethodInfoPtr_get_BloodBound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100664328);
      ItemData.NativeMethodInfoPtr_get_CanBeDropped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100664329);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
