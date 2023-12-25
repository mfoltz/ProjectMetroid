// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterAttributeEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterAttributeEntry : GridSelectionEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entry_Core;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entry_Headline;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entry_Header;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entry_SubHeader;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeFieldInfoPtr_Desc;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Static_Void_CharacterAttributeEntry_Data_ControllerType_GridSelectionGroup_2_CharacterAttributeEntry_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyUI_Private_Static_Void_CharacterAttributeEntry_CharacterAttributeEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1230019, RefRangeEnd = 1230020, XrefRangeStart = 1229990, XrefRangeEnd = 1230019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RefreshData(
      CharacterAttributeEntry entry,
      CharacterAttributeEntry.Data data,
      ControllerType controllerType,
      GridSelectionGroup<CharacterAttributeEntry, CharacterAttributeEntry.Data> parent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterAttributeEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_CharacterAttributeEntry_Data_ControllerType_GridSelectionGroup_2_CharacterAttributeEntry_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1230036, RefRangeEnd = 1230037, XrefRangeStart = 1230020, XrefRangeEnd = 1230036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyUI(CharacterAttributeEntry core, CharacterAttributeEntry entry)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) core);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterAttributeEntry.NativeMethodInfoPtr_CopyUI_Private_Static_Void_CharacterAttributeEntry_CharacterAttributeEntry_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterAttributeEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterAttributeEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterAttributeEntry()
    {
      Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterAttributeEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr);
      CharacterAttributeEntry.NativeFieldInfoPtr_Entry_Core = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, nameof (Entry_Core));
      CharacterAttributeEntry.NativeFieldInfoPtr_Entry_Headline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, nameof (Entry_Headline));
      CharacterAttributeEntry.NativeFieldInfoPtr_Entry_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, nameof (Entry_Header));
      CharacterAttributeEntry.NativeFieldInfoPtr_Entry_SubHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, nameof (Entry_SubHeader));
      CharacterAttributeEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, nameof (Text));
      CharacterAttributeEntry.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, nameof (Value));
      CharacterAttributeEntry.NativeFieldInfoPtr_Desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, nameof (Desc));
      CharacterAttributeEntry.NativeMethodInfoPtr_RefreshData_Public_Static_Void_CharacterAttributeEntry_Data_ControllerType_GridSelectionGroup_2_CharacterAttributeEntry_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, 100665267);
      CharacterAttributeEntry.NativeMethodInfoPtr_CopyUI_Private_Static_Void_CharacterAttributeEntry_CharacterAttributeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, 100665268);
      CharacterAttributeEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, 100665269);
    }

    public CharacterAttributeEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CharacterAttributeEntry Entry_Core
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Entry_Core));
        return pointer == System.IntPtr.Zero ? (CharacterAttributeEntry) null : new CharacterAttributeEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Entry_Core), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAttributeEntry Entry_Headline
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Entry_Headline));
        return pointer == System.IntPtr.Zero ? (CharacterAttributeEntry) null : new CharacterAttributeEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Entry_Headline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAttributeEntry Entry_Header
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Entry_Header));
        return pointer == System.IntPtr.Zero ? (CharacterAttributeEntry) null : new CharacterAttributeEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Entry_Header), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAttributeEntry Entry_SubHeader
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Entry_SubHeader));
        return pointer == System.IntPtr.Zero ? (CharacterAttributeEntry) null : new CharacterAttributeEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Entry_SubHeader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Text));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Value
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Value));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string Desc
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Desc)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.NativeFieldInfoPtr_Desc), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public sealed class Data : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AttributeUIType;
      private static readonly System.IntPtr NativeFieldInfoPtr_TextKey;
      private static readonly System.IntPtr NativeFieldInfoPtr_TooltipDesc;
      private static readonly System.IntPtr NativeFieldInfoPtr_Value;

      static Data()
      {
        Il2CppClassPointerStore<CharacterAttributeEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAttributeEntry.Data>.NativeClassPtr);
        CharacterAttributeEntry.Data.NativeFieldInfoPtr_AttributeUIType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry.Data>.NativeClassPtr, nameof (AttributeUIType));
        CharacterAttributeEntry.Data.NativeFieldInfoPtr_TextKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry.Data>.NativeClassPtr, nameof (TextKey));
        CharacterAttributeEntry.Data.NativeFieldInfoPtr_TooltipDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry.Data>.NativeClassPtr, nameof (TooltipDesc));
        CharacterAttributeEntry.Data.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry.Data>.NativeClassPtr, nameof (Value));
      }

      public Data(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Data()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterAttributeEntry.Data>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterAttributeEntry.Data>.NativeClassPtr, data));
      }

      public unsafe AttributeUIType AttributeUIType
      {
        get
        {
          return *(AttributeUIType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.Data.NativeFieldInfoPtr_AttributeUIType));
        }
        [param: In] set
        {
          *(AttributeUIType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.Data.NativeFieldInfoPtr_AttributeUIType)) = value;
        }
      }

      public unsafe LocalizationKey TextKey
      {
        get
        {
          return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.Data.NativeFieldInfoPtr_TextKey));
        }
        [param: In] set
        {
          *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.Data.NativeFieldInfoPtr_TextKey)) = value;
        }
      }

      public unsafe string TooltipDesc
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.Data.NativeFieldInfoPtr_TooltipDesc)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.Data.NativeFieldInfoPtr_TooltipDesc), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public CharacterAttributeEntry.AttributeValue Value
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.Data.NativeFieldInfoPtr_Value);
          return new CharacterAttributeEntry.AttributeValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterAttributeEntry.AttributeValue>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.Data.NativeFieldInfoPtr_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterAttributeEntry.AttributeValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    public sealed class AttributeValue : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ValueType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Format;
      private static readonly System.IntPtr NativeFieldInfoPtr_IntValue;
      private static readonly System.IntPtr NativeFieldInfoPtr_FloatValue;

      static AttributeValue()
      {
        Il2CppClassPointerStore<CharacterAttributeEntry.AttributeValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAttributeEntry>.NativeClassPtr, nameof (AttributeValue));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAttributeEntry.AttributeValue>.NativeClassPtr);
        CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry.AttributeValue>.NativeClassPtr, nameof (ValueType));
        CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry.AttributeValue>.NativeClassPtr, nameof (Format));
        CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_IntValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry.AttributeValue>.NativeClassPtr, nameof (IntValue));
        CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_FloatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttributeEntry.AttributeValue>.NativeClassPtr, nameof (FloatValue));
      }

      public AttributeValue(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public AttributeValue()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterAttributeEntry.AttributeValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterAttributeEntry.AttributeValue>.NativeClassPtr, data));
      }

      public unsafe CharacterAttributeEntry.AttributeValueType ValueType
      {
        get
        {
          return *(CharacterAttributeEntry.AttributeValueType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_ValueType));
        }
        [param: In] set
        {
          *(CharacterAttributeEntry.AttributeValueType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_ValueType)) = value;
        }
      }

      public unsafe string Format
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_Format)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_Format), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int IntValue
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_IntValue));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_IntValue)) = value;
        }
      }

      public unsafe float FloatValue
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_FloatValue));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttributeEntry.AttributeValue.NativeFieldInfoPtr_FloatValue)) = value;
        }
      }
    }

    public enum AttributeValueType
    {
      Integer,
      Float,
      Empty,
    }
  }
}
