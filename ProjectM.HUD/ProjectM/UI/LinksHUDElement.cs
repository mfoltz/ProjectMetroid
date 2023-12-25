// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LinksHUDElement
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class LinksHUDElement : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
    private static readonly System.IntPtr NativeFieldInfoPtr_Highlight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Keybind;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelEquippedMotionNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_JewelEquippedIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_HUDMenuType;
    private static readonly System.IntPtr NativeFieldInfoPtr_LinkExtraData;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_LinksHUDElement_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267517, XrefRangeEnd = 1267532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(LinksHUDElement entry, LinksHUDElement.Data data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinksHUDElement.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_LinksHUDElement_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LinksHUDElement()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinksHUDElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LinksHUDElement()
    {
      Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (LinksHUDElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr);
      LinksHUDElement.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, nameof (Button));
      LinksHUDElement.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, nameof (Icon));
      LinksHUDElement.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, nameof (Highlight));
      LinksHUDElement.NativeFieldInfoPtr_Keybind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, nameof (Keybind));
      LinksHUDElement.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, nameof (Name));
      LinksHUDElement.NativeFieldInfoPtr_JewelEquippedMotionNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, nameof (JewelEquippedMotionNode));
      LinksHUDElement.NativeFieldInfoPtr_JewelEquippedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, nameof (JewelEquippedIcon));
      LinksHUDElement.NativeFieldInfoPtr_HUDMenuType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, nameof (HUDMenuType));
      LinksHUDElement.NativeFieldInfoPtr_LinkExtraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, nameof (LinkExtraData));
      LinksHUDElement.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_LinksHUDElement_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, 100667692);
      LinksHUDElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, 100667693);
    }

    public LinksHUDElement(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Icon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_Icon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Highlight
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_Highlight));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_Highlight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Keybind
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_Keybind));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_Keybind), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Name
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_Name));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform JewelEquippedMotionNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_JewelEquippedMotionNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_JewelEquippedMotionNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image JewelEquippedIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_JewelEquippedIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_JewelEquippedIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HUDMenuType HUDMenuType
    {
      get
      {
        return *(HUDMenuType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_HUDMenuType));
      }
      [param: In] set
      {
        *(HUDMenuType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_HUDMenuType)) = value;
      }
    }

    public unsafe LinkExtraData LinkExtraData
    {
      get
      {
        return *(LinkExtraData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_LinkExtraData));
      }
      [param: In] set
      {
        *(LinkExtraData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.NativeFieldInfoPtr_LinkExtraData)) = value;
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Visible;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Icon;
      private static readonly System.IntPtr NativeFieldInfoPtr_Keybind;
      private static readonly System.IntPtr NativeFieldInfoPtr_HUDMenuType;
      private static readonly System.IntPtr NativeFieldInfoPtr_LinkExtraData;
      private static readonly System.IntPtr NativeFieldInfoPtr_Highlight;
      private static readonly System.IntPtr NativeFieldInfoPtr_InputText;
      private static readonly System.IntPtr NativeFieldInfoPtr_ProgressionRequirementPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_EquippedJewelIcon;

      static Data()
      {
        Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LinksHUDElement>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr);
        LinksHUDElement.Data.NativeFieldInfoPtr_Visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, nameof (Visible));
        LinksHUDElement.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, nameof (Name));
        LinksHUDElement.Data.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, nameof (Icon));
        LinksHUDElement.Data.NativeFieldInfoPtr_Keybind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, nameof (Keybind));
        LinksHUDElement.Data.NativeFieldInfoPtr_HUDMenuType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, nameof (HUDMenuType));
        LinksHUDElement.Data.NativeFieldInfoPtr_LinkExtraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, nameof (LinkExtraData));
        LinksHUDElement.Data.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, nameof (Highlight));
        LinksHUDElement.Data.NativeFieldInfoPtr_InputText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, nameof (InputText));
        LinksHUDElement.Data.NativeFieldInfoPtr_ProgressionRequirementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, nameof (ProgressionRequirementPrefab));
        LinksHUDElement.Data.NativeFieldInfoPtr_EquippedJewelIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, nameof (EquippedJewelIcon));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LinksHUDElement.Data>.NativeClassPtr, data));
      }

      public unsafe bool Visible
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_Visible));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_Visible)) = value;
        }
      }

      public unsafe LocalizationKey Name
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_Name));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_Name)) = value;
        }
      }

      public unsafe Sprite Icon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_Icon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe InputFlag Keybind
      {
        get
        {
          return *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_Keybind));
        }
        [param: In] set
        {
          *(InputFlag*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_Keybind)) = value;
        }
      }

      public unsafe HUDMenuType HUDMenuType
      {
        get
        {
          return *(HUDMenuType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_HUDMenuType));
        }
        [param: In] set
        {
          *(HUDMenuType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_HUDMenuType)) = value;
        }
      }

      public unsafe LinkExtraData LinkExtraData
      {
        get
        {
          return *(LinkExtraData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_LinkExtraData));
        }
        [param: In] set
        {
          *(LinkExtraData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_LinkExtraData)) = value;
        }
      }

      public unsafe bool Highlight
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_Highlight));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_Highlight)) = value;
        }
      }

      public unsafe string InputText
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_InputText)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_InputText), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe PrefabGUID ProgressionRequirementPrefab
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_ProgressionRequirementPrefab));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_ProgressionRequirementPrefab)) = value;
        }
      }

      public unsafe Sprite EquippedJewelIcon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_EquippedJewelIcon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDElement.Data.NativeFieldInfoPtr_EquippedJewelIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
