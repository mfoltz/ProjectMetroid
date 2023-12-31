// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FontState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public sealed class FontState : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_NormalFont;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HighlightedFont;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PressedFont;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SelectedFont;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DisabledFont;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_normalFont_Public_get_TMP_FontAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_normalFont_Public_set_Void_TMP_FontAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_highlightedFont_Public_get_TMP_FontAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_highlightedFont_Public_set_Void_TMP_FontAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_pressedFont_Public_get_TMP_FontAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_pressedFont_Public_set_Void_TMP_FontAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_selectedFont_Public_get_TMP_FontAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_selectedFont_Public_set_Void_TMP_FontAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledFont_Public_get_TMP_FontAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledFont_Public_set_Void_TMP_FontAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FontState_0;

    public unsafe TMP_FontAsset normalFont
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FontState.NativeMethodInfoPtr_get_normalFont_Public_get_TMP_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FontState.NativeMethodInfoPtr_set_normalFont_Public_set_Void_TMP_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe TMP_FontAsset highlightedFont
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FontState.NativeMethodInfoPtr_get_highlightedFont_Public_get_TMP_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 318047, RefRangeEnd = 318048, XrefRangeStart = 318047, XrefRangeEnd = 318048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FontState.NativeMethodInfoPtr_set_highlightedFont_Public_set_Void_TMP_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe TMP_FontAsset pressedFont
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FontState.NativeMethodInfoPtr_get_pressedFont_Public_get_TMP_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FontState.NativeMethodInfoPtr_set_pressedFont_Public_set_Void_TMP_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe TMP_FontAsset selectedFont
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FontState.NativeMethodInfoPtr_get_selectedFont_Public_get_TMP_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FontState.NativeMethodInfoPtr_set_selectedFont_Public_set_Void_TMP_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe TMP_FontAsset disabledFont
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FontState.NativeMethodInfoPtr_get_disabledFont_Public_get_TMP_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FontState.NativeMethodInfoPtr_set_disabledFont_Public_set_Void_TMP_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795294, XrefRangeEnd = 795310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(FontState other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FontState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FontState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static FontState()
    {
      Il2CppClassPointerStore<FontState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (FontState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontState>.NativeClassPtr);
      FontState.NativeFieldInfoPtr_m_NormalFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontState>.NativeClassPtr, nameof (m_NormalFont));
      FontState.NativeFieldInfoPtr_m_HighlightedFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontState>.NativeClassPtr, nameof (m_HighlightedFont));
      FontState.NativeFieldInfoPtr_m_PressedFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontState>.NativeClassPtr, nameof (m_PressedFont));
      FontState.NativeFieldInfoPtr_m_SelectedFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontState>.NativeClassPtr, nameof (m_SelectedFont));
      FontState.NativeFieldInfoPtr_m_DisabledFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontState>.NativeClassPtr, nameof (m_DisabledFont));
      FontState.NativeMethodInfoPtr_get_normalFont_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontState>.NativeClassPtr, 100670143);
      FontState.NativeMethodInfoPtr_set_normalFont_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontState>.NativeClassPtr, 100670144);
      FontState.NativeMethodInfoPtr_get_highlightedFont_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontState>.NativeClassPtr, 100670145);
      FontState.NativeMethodInfoPtr_set_highlightedFont_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontState>.NativeClassPtr, 100670146);
      FontState.NativeMethodInfoPtr_get_pressedFont_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontState>.NativeClassPtr, 100670147);
      FontState.NativeMethodInfoPtr_set_pressedFont_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontState>.NativeClassPtr, 100670148);
      FontState.NativeMethodInfoPtr_get_selectedFont_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontState>.NativeClassPtr, 100670149);
      FontState.NativeMethodInfoPtr_set_selectedFont_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontState>.NativeClassPtr, 100670150);
      FontState.NativeMethodInfoPtr_get_disabledFont_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontState>.NativeClassPtr, 100670151);
      FontState.NativeMethodInfoPtr_set_disabledFont_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontState>.NativeClassPtr, 100670152);
      FontState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FontState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontState>.NativeClassPtr, 100670153);
    }

    public FontState(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public FontState()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FontState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontState>.NativeClassPtr, data));
    }

    public unsafe TMP_FontAsset m_NormalFont
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FontState.NativeFieldInfoPtr_m_NormalFont));
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FontState.NativeFieldInfoPtr_m_NormalFont), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_FontAsset m_HighlightedFont
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FontState.NativeFieldInfoPtr_m_HighlightedFont));
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FontState.NativeFieldInfoPtr_m_HighlightedFont), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_FontAsset m_PressedFont
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FontState.NativeFieldInfoPtr_m_PressedFont));
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FontState.NativeFieldInfoPtr_m_PressedFont), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_FontAsset m_SelectedFont
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FontState.NativeFieldInfoPtr_m_SelectedFont));
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FontState.NativeFieldInfoPtr_m_SelectedFont), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_FontAsset m_DisabledFont
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FontState.NativeFieldInfoPtr_m_DisabledFont));
        return pointer == System.IntPtr.Zero ? (TMP_FontAsset) null : new TMP_FontAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FontState.NativeFieldInfoPtr_m_DisabledFont), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
