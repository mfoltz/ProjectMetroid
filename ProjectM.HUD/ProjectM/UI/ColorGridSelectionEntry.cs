// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ColorGridSelectionEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ColorGridSelectionEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatch;
    private static readonly System.IntPtr NativeFieldInfoPtr_Selected;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ColorGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_ColorGridSelectionEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompColor_Private_Static_Color_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1277607, RefRangeEnd = 1277610, XrefRangeStart = 1277603, XrefRangeEnd = 1277607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(
      ColorGridSelectionEntry entry,
      ColorGridSelectionEntry.Data data,
      ControllerType controllerType,
      GridSelectionGroup<ColorGridSelectionEntry, ColorGridSelectionEntry.Data> parent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ColorGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ColorGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_ColorGridSelectionEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277610, XrefRangeEnd = 1277613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Color CompColor(Color color)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &color;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColorGridSelectionEntry.NativeMethodInfoPtr_CompColor_Private_Static_Color_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ColorGridSelectionEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGridSelectionEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ColorGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ColorGridSelectionEntry()
    {
      Il2CppClassPointerStore<ColorGridSelectionEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ColorGridSelectionEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGridSelectionEntry>.NativeClassPtr);
      ColorGridSelectionEntry.NativeFieldInfoPtr_ColorSwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGridSelectionEntry>.NativeClassPtr, nameof (ColorSwatch));
      ColorGridSelectionEntry.NativeFieldInfoPtr_Selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGridSelectionEntry>.NativeClassPtr, nameof (Selected));
      ColorGridSelectionEntry.NativeMethodInfoPtr_RefreshData_Internal_Static_Void_ColorGridSelectionEntry_Data_ControllerType_GridSelectionGroup_2_ColorGridSelectionEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGridSelectionEntry>.NativeClassPtr, 100668709);
      ColorGridSelectionEntry.NativeMethodInfoPtr_CompColor_Private_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGridSelectionEntry>.NativeClassPtr, 100668710);
      ColorGridSelectionEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGridSelectionEntry>.NativeClassPtr, 100668711);
    }

    public ColorGridSelectionEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image ColorSwatch
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorGridSelectionEntry.NativeFieldInfoPtr_ColorSwatch));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorGridSelectionEntry.NativeFieldInfoPtr_ColorSwatch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Selected
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorGridSelectionEntry.NativeFieldInfoPtr_Selected));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorGridSelectionEntry.NativeFieldInfoPtr_Selected), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Color;
      [FieldOffset(0)]
      public Color Color;

      static Data()
      {
        Il2CppClassPointerStore<ColorGridSelectionEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGridSelectionEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGridSelectionEntry.Data>.NativeClassPtr);
        ColorGridSelectionEntry.Data.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGridSelectionEntry.Data>.NativeClassPtr, nameof (Color));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ColorGridSelectionEntry.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
