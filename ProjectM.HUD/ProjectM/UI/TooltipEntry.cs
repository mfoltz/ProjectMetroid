// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class TooltipEntry : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubHeaderText;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionText;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipEntry()
    {
      Il2CppClassPointerStore<TooltipEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TooltipEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipEntry>.NativeClassPtr);
      TooltipEntry.NativeFieldInfoPtr_HeaderIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEntry>.NativeClassPtr, nameof (HeaderIcon));
      TooltipEntry.NativeFieldInfoPtr_HeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEntry>.NativeClassPtr, nameof (HeaderText));
      TooltipEntry.NativeFieldInfoPtr_SubHeaderText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEntry>.NativeClassPtr, nameof (SubHeaderText));
      TooltipEntry.NativeFieldInfoPtr_DescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEntry>.NativeClassPtr, nameof (DescriptionText));
      TooltipEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipEntry>.NativeClassPtr, 100663914);
    }

    public TooltipEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image HeaderIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.NativeFieldInfoPtr_HeaderIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.NativeFieldInfoPtr_HeaderIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.NativeFieldInfoPtr_HeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.NativeFieldInfoPtr_HeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText SubHeaderText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.NativeFieldInfoPtr_SubHeaderText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.NativeFieldInfoPtr_SubHeaderText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText DescriptionText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.NativeFieldInfoPtr_DescriptionText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.NativeFieldInfoPtr_DescriptionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ScreenPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_Pivot;
      private static readonly System.IntPtr NativeFieldInfoPtr_HeaderIcon;
      private static readonly System.IntPtr NativeFieldInfoPtr_Header;
      private static readonly System.IntPtr NativeFieldInfoPtr_SubHeader;
      private static readonly System.IntPtr NativeFieldInfoPtr_Description;

      static Data()
      {
        Il2CppClassPointerStore<TooltipEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipEntry.Data>.NativeClassPtr);
        TooltipEntry.Data.NativeFieldInfoPtr_ScreenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEntry.Data>.NativeClassPtr, nameof (ScreenPosition));
        TooltipEntry.Data.NativeFieldInfoPtr_Pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEntry.Data>.NativeClassPtr, nameof (Pivot));
        TooltipEntry.Data.NativeFieldInfoPtr_HeaderIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEntry.Data>.NativeClassPtr, nameof (HeaderIcon));
        TooltipEntry.Data.NativeFieldInfoPtr_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEntry.Data>.NativeClassPtr, nameof (Header));
        TooltipEntry.Data.NativeFieldInfoPtr_SubHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEntry.Data>.NativeClassPtr, nameof (SubHeader));
        TooltipEntry.Data.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipEntry.Data>.NativeClassPtr, nameof (Description));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TooltipEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipEntry.Data>.NativeClassPtr, data));
      }

      public unsafe float3 ScreenPosition
      {
        get
        {
          return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_ScreenPosition));
        }
        [param: In] set
        {
          *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_ScreenPosition)) = value;
        }
      }

      public unsafe float2 Pivot
      {
        get
        {
          return *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_Pivot));
        }
        [param: In] set
        {
          *(float2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_Pivot)) = value;
        }
      }

      public unsafe Sprite HeaderIcon
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_HeaderIcon));
          return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_HeaderIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe LocalizationKey Header
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_Header));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_Header)) = value;
        }
      }

      public unsafe LocalizationKey SubHeader
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_SubHeader));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_SubHeader)) = value;
        }
      }

      public unsafe LocalizationKey Description
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_Description));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipEntry.Data.NativeFieldInfoPtr_Description)) = value;
        }
      }
    }
  }
}
