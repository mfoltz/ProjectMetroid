// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FilterCategoryEntry
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
  public class FilterCategoryEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TextName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImageSelect;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Disabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Hovered;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Selected;
    private static readonly System.IntPtr NativeFieldInfoPtr_Color_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_FilterCategoryEntry_Data_ControllerType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217449, XrefRangeEnd = 1217463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(
      FilterCategoryEntry entry,
      FilterCategoryEntry.Data data,
      ControllerType controllerType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FilterCategoryEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_FilterCategoryEntry_Data_ControllerType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FilterCategoryEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FilterCategoryEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FilterCategoryEntry()
    {
      Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (FilterCategoryEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr);
      FilterCategoryEntry.NativeFieldInfoPtr_TextName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr, nameof (TextName));
      FilterCategoryEntry.NativeFieldInfoPtr_ImageSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr, nameof (ImageSelect));
      FilterCategoryEntry.NativeFieldInfoPtr_Color_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr, nameof (Color_Disabled));
      FilterCategoryEntry.NativeFieldInfoPtr_Color_Hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr, nameof (Color_Hovered));
      FilterCategoryEntry.NativeFieldInfoPtr_Color_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr, nameof (Color_Selected));
      FilterCategoryEntry.NativeFieldInfoPtr_Color_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr, nameof (Color_Normal));
      FilterCategoryEntry.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr, nameof (Stacks));
      FilterCategoryEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_FilterCategoryEntry_Data_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr, 100664299);
      FilterCategoryEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr, 100664300);
    }

    public FilterCategoryEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText TextName
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_TextName));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_TextName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ImageSelect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_ImageSelect));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_ImageSelect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Color Color_Disabled
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_Color_Disabled));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_Color_Disabled)) = value;
      }
    }

    public unsafe Color Color_Hovered
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_Color_Hovered));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_Color_Hovered)) = value;
      }
    }

    public unsafe Color Color_Selected
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_Color_Selected));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_Color_Selected)) = value;
      }
    }

    public unsafe Color Color_Normal
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_Color_Normal));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_Color_Normal)) = value;
      }
    }

    public unsafe int Stacks
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_Stacks));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilterCategoryEntry.NativeFieldInfoPtr_Stacks)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSelected;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsHovered;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsDisabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
      [FieldOffset(0)]
      public bool IsSelected;
      [FieldOffset(1)]
      public bool IsHovered;
      [FieldOffset(2)]
      public bool IsDisabled;
      [FieldOffset(4)]
      public LocalizationKey Name;
      [FieldOffset(20)]
      public int Stacks;

      static Data()
      {
        Il2CppClassPointerStore<FilterCategoryEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterCategoryEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterCategoryEntry.Data>.NativeClassPtr);
        FilterCategoryEntry.Data.NativeFieldInfoPtr_IsSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry.Data>.NativeClassPtr, nameof (IsSelected));
        FilterCategoryEntry.Data.NativeFieldInfoPtr_IsHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry.Data>.NativeClassPtr, nameof (IsHovered));
        FilterCategoryEntry.Data.NativeFieldInfoPtr_IsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry.Data>.NativeClassPtr, nameof (IsDisabled));
        FilterCategoryEntry.Data.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry.Data>.NativeClassPtr, nameof (Name));
        FilterCategoryEntry.Data.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterCategoryEntry.Data>.NativeClassPtr, nameof (Stacks));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FilterCategoryEntry.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
