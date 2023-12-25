// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterMenu : HUDMenu
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ControllerInputContexts;
    private static readonly System.IntPtr NativeFieldInfoPtr_InventoryMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellsMenu;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentTabButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuildTabButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellsTabButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubMenuNode;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterMenu()
    {
      Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr);
      CharacterMenu.NativeFieldInfoPtr_ControllerInputContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr, nameof (ControllerInputContexts));
      CharacterMenu.NativeFieldInfoPtr_InventoryMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr, nameof (InventoryMenu));
      CharacterMenu.NativeFieldInfoPtr_BuildMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr, nameof (BuildMenu));
      CharacterMenu.NativeFieldInfoPtr_SpellsMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr, nameof (SpellsMenu));
      CharacterMenu.NativeFieldInfoPtr_EquipmentTabButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr, nameof (EquipmentTabButton));
      CharacterMenu.NativeFieldInfoPtr_BuildTabButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr, nameof (BuildTabButton));
      CharacterMenu.NativeFieldInfoPtr_SpellsTabButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr, nameof (SpellsTabButton));
      CharacterMenu.NativeFieldInfoPtr_SubMenuNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr, nameof (SubMenuNode));
      CharacterMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr, 100665385);
    }

    public CharacterMenu(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<GameObject> ControllerInputContexts
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_ControllerInputContexts));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_ControllerInputContexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InventoryMenu InventoryMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_InventoryMenu));
        return pointer == System.IntPtr.Zero ? (InventoryMenu) null : new InventoryMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_InventoryMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuildMenu BuildMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_BuildMenu));
        return pointer == System.IntPtr.Zero ? (BuildMenu) null : new BuildMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_BuildMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BuildMenu SpellsMenu
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_SpellsMenu));
        return pointer == System.IntPtr.Zero ? (BuildMenu) null : new BuildMenu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_SpellsMenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TabButton EquipmentTabButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_EquipmentTabButton));
        return pointer == System.IntPtr.Zero ? (TabButton) null : new TabButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_EquipmentTabButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TabButton BuildTabButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_BuildTabButton));
        return pointer == System.IntPtr.Zero ? (TabButton) null : new TabButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_BuildTabButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TabButton SpellsTabButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_SpellsTabButton));
        return pointer == System.IntPtr.Zero ? (TabButton) null : new TabButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_SpellsTabButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SubMenuNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_SubMenuNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMenu.NativeFieldInfoPtr_SubMenuNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct InitData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DefaultTab;
      [FieldOffset(0)]
      public CharacterMenuTab DefaultTab;

      static InitData()
      {
        Il2CppClassPointerStore<CharacterMenu.InitData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterMenu>.NativeClassPtr, nameof (InitData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMenu.InitData>.NativeClassPtr);
        CharacterMenu.InitData.NativeFieldInfoPtr_DefaultTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMenu.InitData>.NativeClassPtr, nameof (DefaultTab));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterMenu.InitData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
