// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MemoizedItemCategories
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public sealed class MemoizedItemCategories : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Value;
    private static readonly System.IntPtr NativeFieldInfoPtr__Text;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Public_String_ItemCategorySettings_ItemCategory_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1265158, RefRangeEnd = 1265159, XrefRangeStart = 1265148, XrefRangeEnd = 1265158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetString(ItemCategorySettings settings, ItemCategory val)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MemoizedItemCategories.NativeMethodInfoPtr_GetString_Public_String_ItemCategorySettings_ItemCategory_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static MemoizedItemCategories()
    {
      Il2CppClassPointerStore<MemoizedItemCategories>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MemoizedItemCategories));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoizedItemCategories>.NativeClassPtr);
      MemoizedItemCategories.NativeFieldInfoPtr__Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedItemCategories>.NativeClassPtr, nameof (_Value));
      MemoizedItemCategories.NativeFieldInfoPtr__Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoizedItemCategories>.NativeClassPtr, nameof (_Text));
      MemoizedItemCategories.NativeMethodInfoPtr_GetString_Public_String_ItemCategorySettings_ItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoizedItemCategories>.NativeClassPtr, 100667544);
    }

    public MemoizedItemCategories(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MemoizedItemCategories()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedItemCategories>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedItemCategories>.NativeClassPtr, data));
    }

    public unsafe Nullable_Unboxed<ItemCategory> _Value
    {
      get
      {
        return *(Nullable_Unboxed<ItemCategory>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedItemCategories.NativeFieldInfoPtr__Value));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedItemCategories.NativeFieldInfoPtr__Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<ItemCategory>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe string _Text
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MemoizedItemCategories.NativeFieldInfoPtr__Text)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MemoizedItemCategories.NativeFieldInfoPtr__Text), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
