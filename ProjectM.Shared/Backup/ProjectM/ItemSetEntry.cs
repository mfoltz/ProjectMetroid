// Decompiled with JetBrains decompiler
// Type: ProjectM.ItemSetEntry
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public sealed class ItemSetEntry : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabName;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;

    static ItemSetEntry()
    {
      Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ItemSetEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr);
      ItemSetEntry.NativeFieldInfoPtr_PrefabName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, nameof (PrefabName));
      ItemSetEntry.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, nameof (PrefabGUID));
      ItemSetEntry.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, nameof (Amount));
    }

    public ItemSetEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ItemSetEntry()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemSetEntry>.NativeClassPtr, data));
    }

    public unsafe string PrefabName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemSetEntry.NativeFieldInfoPtr_PrefabName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ItemSetEntry.NativeFieldInfoPtr_PrefabName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe PrefabGUID PrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemSetEntry.NativeFieldInfoPtr_PrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemSetEntry.NativeFieldInfoPtr_PrefabGUID)) = value;
      }
    }

    public unsafe int Amount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemSetEntry.NativeFieldInfoPtr_Amount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ItemSetEntry.NativeFieldInfoPtr_Amount)) = value;
      }
    }
  }
}
