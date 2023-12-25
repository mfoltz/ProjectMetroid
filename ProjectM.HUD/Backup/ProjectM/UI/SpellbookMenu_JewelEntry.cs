// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.SpellbookMenu_JewelEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class SpellbookMenu_JewelEntry : GenericSelectionEntry<SpellbookMenu_JewelEntry.Data>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameText;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquippedIndicator;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263259, XrefRangeEnd = 1263264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Refresh([In] ref SpellbookMenu_JewelEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpellbookMenu_JewelEntry.NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263264, XrefRangeEnd = 1263267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpellbookMenu_JewelEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpellbookMenu_JewelEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpellbookMenu_JewelEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpellbookMenu_JewelEntry()
    {
      Il2CppClassPointerStore<SpellbookMenu_JewelEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (SpellbookMenu_JewelEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenu_JewelEntry>.NativeClassPtr);
      SpellbookMenu_JewelEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelEntry>.NativeClassPtr, nameof (Button));
      SpellbookMenu_JewelEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelEntry>.NativeClassPtr, nameof (Icon));
      SpellbookMenu_JewelEntry.NativeFieldInfoPtr_NameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelEntry>.NativeClassPtr, nameof (NameText));
      SpellbookMenu_JewelEntry.NativeFieldInfoPtr_EquippedIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelEntry>.NativeClassPtr, nameof (EquippedIndicator));
      SpellbookMenu_JewelEntry.NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_JewelEntry>.NativeClassPtr, 100667440);
      SpellbookMenu_JewelEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellbookMenu_JewelEntry>.NativeClassPtr, 100667441);
    }

    public SpellbookMenu_JewelEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.NativeFieldInfoPtr_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText NameText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.NativeFieldInfoPtr_NameText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.NativeFieldInfoPtr_NameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject EquippedIndicator
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.NativeFieldInfoPtr_EquippedIndicator));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.NativeFieldInfoPtr_EquippedIndicator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
      private static readonly System.IntPtr NativeFieldInfoPtr_SpellModEntity;
      private static readonly System.IntPtr NativeFieldInfoPtr_InventoryIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSelected;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsEquipped;

      static Data()
      {
        Il2CppClassPointerStore<SpellbookMenu_JewelEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpellbookMenu_JewelEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellbookMenu_JewelEntry.Data>.NativeClassPtr);
        SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelEntry.Data>.NativeClassPtr, nameof (Icon));
        SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelEntry.Data>.NativeClassPtr, nameof (Name));
        SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelEntry.Data>.NativeClassPtr, nameof (Ability));
        SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_SpellModEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelEntry.Data>.NativeClassPtr, nameof (SpellModEntity));
        SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_InventoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelEntry.Data>.NativeClassPtr, nameof (InventoryIndex));
        SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_IsSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelEntry.Data>.NativeClassPtr, nameof (IsSelected));
        SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_IsEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellbookMenu_JewelEntry.Data>.NativeClassPtr, nameof (IsEquipped));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellbookMenu_JewelEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellbookMenu_JewelEntry.Data>.NativeClassPtr, data));
      }

      public unsafe Sprite Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe PrefabGUID Ability
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_Ability));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_Ability)) = value;
        }
      }

      public unsafe Entity SpellModEntity
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_SpellModEntity));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_SpellModEntity)) = value;
        }
      }

      public unsafe int InventoryIndex
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_InventoryIndex));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_InventoryIndex)) = value;
        }
      }

      public unsafe bool IsSelected
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_IsSelected));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_IsSelected)) = value;
        }
      }

      public unsafe bool IsEquipped
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_IsEquipped));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpellbookMenu_JewelEntry.Data.NativeFieldInfoPtr_IsEquipped)) = value;
        }
      }
    }
  }
}
