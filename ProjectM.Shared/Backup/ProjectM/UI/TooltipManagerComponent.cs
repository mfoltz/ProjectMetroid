// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TooltipManagerComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class TooltipManagerComponent : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipText;
    private static readonly System.IntPtr NativeFieldInfoPtr_TooltipRect;
    private static readonly System.IntPtr NativeFieldInfoPtr_SizeFitter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTooltipData;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTooltip_Public_Static_Void_LocalizationKey_Vector2_PivotPresets_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetTooltip_Public_Static_Void_String_Vector2_PivotPresets_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 795688, RefRangeEnd = 795701, XrefRangeStart = 795680, XrefRangeEnd = 795688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetTooltip(
      LocalizationKey textKey,
      Vector2 screenPosition,
      PivotPresets pivot,
      Nullable_Unboxed<float> maxWidth = default (Nullable_Unboxed<float>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &textKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &screenPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxWidth;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipManagerComponent.NativeMethodInfoPtr_SetTooltip_Public_Static_Void_LocalizationKey_Vector2_PivotPresets_Nullable_Unboxed_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 795709, RefRangeEnd = 795711, XrefRangeStart = 795701, XrefRangeEnd = 795709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetTooltip(
      string text,
      Vector2 screenPosition,
      PivotPresets pivot,
      Nullable_Unboxed<float> maxWidth = default (Nullable_Unboxed<float>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &screenPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxWidth;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipManagerComponent.NativeMethodInfoPtr_SetTooltip_Public_Static_Void_String_Vector2_PivotPresets_Nullable_Unboxed_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795711, XrefRangeEnd = 795729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipManagerComponent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TooltipManagerComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TooltipManagerComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TooltipManagerComponent()
    {
      Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (TooltipManagerComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr);
      TooltipManagerComponent.NativeFieldInfoPtr_TooltipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr, nameof (TooltipText));
      TooltipManagerComponent.NativeFieldInfoPtr_TooltipRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr, nameof (TooltipRect));
      TooltipManagerComponent.NativeFieldInfoPtr_SizeFitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr, nameof (SizeFitter));
      TooltipManagerComponent.NativeFieldInfoPtr_CurrentTooltipData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr, nameof (CurrentTooltipData));
      TooltipManagerComponent.NativeMethodInfoPtr_SetTooltip_Public_Static_Void_LocalizationKey_Vector2_PivotPresets_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr, 100670217);
      TooltipManagerComponent.NativeMethodInfoPtr_SetTooltip_Public_Static_Void_String_Vector2_PivotPresets_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr, 100670218);
      TooltipManagerComponent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr, 100670219);
      TooltipManagerComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr, 100670220);
    }

    public TooltipManagerComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText TooltipText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.NativeFieldInfoPtr_TooltipText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.NativeFieldInfoPtr_TooltipText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform TooltipRect
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.NativeFieldInfoPtr_TooltipRect));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.NativeFieldInfoPtr_TooltipRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ContentSizeFitter SizeFitter
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.NativeFieldInfoPtr_SizeFitter));
        return pointer == System.IntPtr.Zero ? (ContentSizeFitter) null : new ContentSizeFitter(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.NativeFieldInfoPtr_SizeFitter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Nullable<TooltipManagerComponent.TooltipData> CurrentTooltipData
    {
      get
      {
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<TooltipManagerComponent.TooltipData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        IL2CPP.il2cpp_field_static_get_value(TooltipManagerComponent.NativeFieldInfoPtr_CurrentTooltipData, (void*) data);
        return new Il2CppSystem.Nullable<TooltipManagerComponent.TooltipData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<TooltipManagerComponent.TooltipData>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TooltipManagerComponent.NativeFieldInfoPtr_CurrentTooltipData, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
      }
    }

    [Serializable]
    public sealed class TooltipData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      private static readonly System.IntPtr NativeFieldInfoPtr_ScreenPosition;
      private static readonly System.IntPtr NativeFieldInfoPtr_Pivot;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxWidth;

      static TooltipData()
      {
        Il2CppClassPointerStore<TooltipManagerComponent.TooltipData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipManagerComponent>.NativeClassPtr, nameof (TooltipData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipManagerComponent.TooltipData>.NativeClassPtr);
        TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManagerComponent.TooltipData>.NativeClassPtr, nameof (Text));
        TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_ScreenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManagerComponent.TooltipData>.NativeClassPtr, nameof (ScreenPosition));
        TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_Pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManagerComponent.TooltipData>.NativeClassPtr, nameof (Pivot));
        TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_MaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManagerComponent.TooltipData>.NativeClassPtr, nameof (MaxWidth));
      }

      public TooltipData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public TooltipData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TooltipManagerComponent.TooltipData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TooltipManagerComponent.TooltipData>.NativeClassPtr, data));
      }

      public LocalizedString Text
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_Text);
          return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_Text), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe Vector2 ScreenPosition
      {
        get
        {
          return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_ScreenPosition));
        }
        [param: In] set
        {
          *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_ScreenPosition)) = value;
        }
      }

      public unsafe PivotPresets Pivot
      {
        get
        {
          return *(PivotPresets*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_Pivot));
        }
        [param: In] set
        {
          *(PivotPresets*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_Pivot)) = value;
        }
      }

      public unsafe Nullable_Unboxed<float> MaxWidth
      {
        get
        {
          return *(Nullable_Unboxed<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_MaxWidth));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipManagerComponent.TooltipData.NativeFieldInfoPtr_MaxWidth), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
