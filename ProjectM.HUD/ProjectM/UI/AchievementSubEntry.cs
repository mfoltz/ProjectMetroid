// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AchievementSubEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class AchievementSubEntry : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Text;
    private static readonly IntPtr NativeFieldInfoPtr_Check;
    private static readonly IntPtr NativeFieldInfoPtr_HeaderTextFormat;
    private static readonly IntPtr NativeFieldInfoPtr__HeaderTextString;
    private static readonly IntPtr NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_String_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1213373, RefRangeEnd = 1213375, XrefRangeStart = 1213359, XrefRangeEnd = 1213373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetQuestText(
      LocalizationKey questKey,
      string color,
      int value1,
      int value2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &questKey;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(color);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &value1;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &value2;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementSubEntry.NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1213376, RefRangeEnd = 1213377, XrefRangeStart = 1213375, XrefRangeEnd = 1213376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetQuestText(LocalizationKey questKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &questKey;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementSubEntry.NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AchievementSubEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementSubEntry>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementSubEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AchievementSubEntry()
    {
      Il2CppClassPointerStore<AchievementSubEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (AchievementSubEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementSubEntry>.NativeClassPtr);
      AchievementSubEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubEntry>.NativeClassPtr, nameof (Text));
      AchievementSubEntry.NativeFieldInfoPtr_Check = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubEntry>.NativeClassPtr, nameof (Check));
      AchievementSubEntry.NativeFieldInfoPtr_HeaderTextFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubEntry>.NativeClassPtr, nameof (HeaderTextFormat));
      AchievementSubEntry.NativeFieldInfoPtr__HeaderTextString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementSubEntry>.NativeClassPtr, nameof (_HeaderTextString));
      AchievementSubEntry.NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementSubEntry>.NativeClassPtr, 100663944);
      AchievementSubEntry.NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementSubEntry>.NativeClassPtr, 100663945);
      AchievementSubEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementSubEntry>.NativeClassPtr, 100663946);
    }

    public AchievementSubEntry(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Text
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubEntry.NativeFieldInfoPtr_Text));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubEntry.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform Check
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubEntry.NativeFieldInfoPtr_Check));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubEntry.NativeFieldInfoPtr_Check), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey HeaderTextFormat
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubEntry.NativeFieldInfoPtr_HeaderTextFormat));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubEntry.NativeFieldInfoPtr_HeaderTextFormat)) = value;
      }
    }

    public LocalizedString _HeaderTextString
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubEntry.NativeFieldInfoPtr__HeaderTextString);
        return new LocalizedString(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementSubEntry.NativeFieldInfoPtr__HeaderTextString), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalizedString>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
