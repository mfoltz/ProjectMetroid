// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LocalizedTimeBuilder
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public sealed class LocalizedTimeBuilder : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TimeString;
    private static readonly System.IntPtr NativeFieldInfoPtr__TimeValueStrings;
    private static readonly System.IntPtr NativeFieldInfoPtr__DaysText;
    private static readonly System.IntPtr NativeFieldInfoPtr__HoursText;
    private static readonly System.IntPtr NativeFieldInfoPtr__MinutesText;
    private static readonly System.IntPtr NativeFieldInfoPtr__SecondsText;
    private static readonly System.IntPtr NativeMethodInfoPtr__ValidateTimeValueLength_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildTimeString_Public_LocalizedString_Single_byref_TimeLocalizationKeys_TimeValueSeperator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeString_Private_String_byref_TimeLocalizationKeys_TimeType_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedTimeString_Public_LocalizedString_byref_TimeLocalizationKeys_TimeType_Int32_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1160682, RefRangeEnd = 1160684, XrefRangeStart = 1160677, XrefRangeEnd = 1160682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _ValidateTimeValueLength(int length)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &length;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalizedTimeBuilder.NativeMethodInfoPtr__ValidateTimeValueLength_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(24)]
    [CachedScanResults(RefRangeStart = 1160732, RefRangeEnd = 1160756, XrefRangeStart = 1160684, XrefRangeEnd = 1160732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedString BuildTimeString(
      float timeLeft,
      ref TimeLocalizationKeys keys,
      TimeValueSeperator seperator)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &timeLeft;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref keys;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &seperator;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LocalizedTimeBuilder.NativeMethodInfoPtr_BuildTimeString_Public_LocalizedString_Single_byref_TimeLocalizationKeys_TimeValueSeperator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LocalizedString(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160756, XrefRangeEnd = 1160757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetTimeString(ref TimeLocalizationKeys keys, TimeType type, int value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref keys;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LocalizedTimeBuilder.NativeMethodInfoPtr_GetTimeString_Private_String_byref_TimeLocalizationKeys_TimeType_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1160759, RefRangeEnd = 1160763, XrefRangeStart = 1160757, XrefRangeEnd = 1160759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedString GetLocalizedTimeString(
      ref TimeLocalizationKeys keys,
      TimeType type,
      int value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref keys;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LocalizedTimeBuilder.NativeMethodInfoPtr_GetLocalizedTimeString_Public_LocalizedString_byref_TimeLocalizationKeys_TimeType_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LocalizedString(pointer);
    }

    static LocalizedTimeBuilder()
    {
      Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (LocalizedTimeBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr);
      LocalizedTimeBuilder.NativeFieldInfoPtr__TimeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, nameof (_TimeString));
      LocalizedTimeBuilder.NativeFieldInfoPtr__TimeValueStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, nameof (_TimeValueStrings));
      LocalizedTimeBuilder.NativeFieldInfoPtr__DaysText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, nameof (_DaysText));
      LocalizedTimeBuilder.NativeFieldInfoPtr__HoursText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, nameof (_HoursText));
      LocalizedTimeBuilder.NativeFieldInfoPtr__MinutesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, nameof (_MinutesText));
      LocalizedTimeBuilder.NativeFieldInfoPtr__SecondsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, nameof (_SecondsText));
      LocalizedTimeBuilder.NativeMethodInfoPtr__ValidateTimeValueLength_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, 100692285);
      LocalizedTimeBuilder.NativeMethodInfoPtr_BuildTimeString_Public_LocalizedString_Single_byref_TimeLocalizationKeys_TimeValueSeperator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, 100692286);
      LocalizedTimeBuilder.NativeMethodInfoPtr_GetTimeString_Private_String_byref_TimeLocalizationKeys_TimeType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, 100692287);
      LocalizedTimeBuilder.NativeMethodInfoPtr_GetLocalizedTimeString_Public_LocalizedString_byref_TimeLocalizationKeys_TimeType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, 100692288);
    }

    public LocalizedTimeBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public LocalizedTimeBuilder()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedTimeBuilder>.NativeClassPtr, data));
    }

    public LocalizedString _TimeString
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__TimeString);
        return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__TimeString), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<LocalizedString> _TimeValueStrings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__TimeValueStrings));
        return pointer == System.IntPtr.Zero ? (List<LocalizedString>) null : new List<LocalizedString>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__TimeValueStrings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public LocalizedString _DaysText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__DaysText);
        return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__DaysText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public LocalizedString _HoursText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__HoursText);
        return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__HoursText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public LocalizedString _MinutesText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__MinutesText);
        return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__MinutesText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public LocalizedString _SecondsText
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__SecondsText);
        return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedTimeBuilder.NativeFieldInfoPtr__SecondsText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
