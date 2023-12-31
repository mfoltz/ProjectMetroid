// Decompiled with JetBrains decompiler
// Type: ProjectM.Restricted_InventoryBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Restricted_InventoryBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RestrictedType;
    private static readonly System.IntPtr NativeFieldInfoPtr_RestrictedItemCategory;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsRestricted_Public_Boolean_PrefabGUID_ItemCategory_0;
    [FieldOffset(0)]
    public PrefabGUID RestrictedType;
    [FieldOffset(8)]
    public ItemCategory RestrictedItemCategory;

    public unsafe bool IsEmpty
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 727169, RefRangeEnd = 727170, XrefRangeStart = 727168, XrefRangeEnd = 727169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Restricted_InventoryBuffer.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 727173, RefRangeEnd = 727178, XrefRangeStart = 727170, XrefRangeEnd = 727173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsRestricted(PrefabGUID itemType, ItemCategory itemCategory)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &itemType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &itemCategory;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Restricted_InventoryBuffer.NativeMethodInfoPtr_IsRestricted_Public_Boolean_PrefabGUID_ItemCategory_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static Restricted_InventoryBuffer()
    {
      Il2CppClassPointerStore<Restricted_InventoryBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Restricted_InventoryBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Restricted_InventoryBuffer>.NativeClassPtr);
      Restricted_InventoryBuffer.NativeFieldInfoPtr_RestrictedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Restricted_InventoryBuffer>.NativeClassPtr, nameof (RestrictedType));
      Restricted_InventoryBuffer.NativeFieldInfoPtr_RestrictedItemCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Restricted_InventoryBuffer>.NativeClassPtr, nameof (RestrictedItemCategory));
      Restricted_InventoryBuffer.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Restricted_InventoryBuffer>.NativeClassPtr, 100664325);
      Restricted_InventoryBuffer.NativeMethodInfoPtr_IsRestricted_Public_Boolean_PrefabGUID_ItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Restricted_InventoryBuffer>.NativeClassPtr, 100664326);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Restricted_InventoryBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
