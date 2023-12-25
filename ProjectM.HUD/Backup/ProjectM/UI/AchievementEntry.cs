// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AchievementEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class AchievementEntry : UIEntry
  {
    private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;
    private static readonly IntPtr NativeFieldInfoPtr_ClaimButtonParent;
    private static readonly IntPtr NativeFieldInfoPtr_ClaimButton;
    private static readonly IntPtr NativeFieldInfoPtr_Icon;
    private static readonly IntPtr NativeFieldInfoPtr_IconTooltip;
    private static readonly IntPtr NativeFieldInfoPtr_IconTooltipText;
    private static readonly IntPtr NativeFieldInfoPtr_CheckMark;
    private static readonly IntPtr NativeFieldInfoPtr_Text_Flavor;
    private static readonly IntPtr NativeFieldInfoPtr_Text_Quest;
    private static readonly IntPtr NativeFieldInfoPtr_Text_Reward;
    private static readonly IntPtr NativeFieldInfoPtr_Text_Distance;
    private static readonly IntPtr NativeFieldInfoPtr_Motion2DInOut;
    private static readonly IntPtr NativeFieldInfoPtr_Motion2DInOutReward;
    private static readonly IntPtr NativeFieldInfoPtr_GlowAnimator;
    private static readonly IntPtr NativeFieldInfoPtr_QuestTextFormat;
    private static readonly IntPtr NativeFieldInfoPtr_SubTasks;
    private static readonly IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly IntPtr NativeFieldInfoPtr_Achievement;
    private static readonly IntPtr NativeFieldInfoPtr__Refresh_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__BackgroundHover;
    private static readonly IntPtr NativeMethodInfoPtr_get_Refresh_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_Refresh_Public_set_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_ClaimButtonHover_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_BackgroundHover_Public_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_String_Int32_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnBackgroundEnter_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnBackgroundExit_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnIconEnter_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnIconExit_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_ReInit_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe bool Refresh
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr_get_Refresh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr_set_Refresh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool ClaimButtonHover
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr_get_ClaimButtonHover_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool BackgroundHover
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr_get_BackgroundHover_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213330, XrefRangeEnd = 1213350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1213351, RefRangeEnd = 1213352, XrefRangeStart = 1213350, XrefRangeEnd = 1213351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetQuestText(LocalizationKey questKey)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &questKey;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void OnBackgroundEnter()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr_OnBackgroundEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void OnBackgroundExit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr_OnBackgroundExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213352, XrefRangeEnd = 1213355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnIconEnter()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr_OnIconEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213355, XrefRangeEnd = 1213358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnIconExit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr_OnIconExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void ReInit()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr_ReInit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213358, XrefRangeEnd = 1213359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AchievementEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AchievementEntry()
    {
      Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (AchievementEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr);
      AchievementEntry.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (CanvasGroup));
      AchievementEntry.NativeFieldInfoPtr_ClaimButtonParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (ClaimButtonParent));
      AchievementEntry.NativeFieldInfoPtr_ClaimButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (ClaimButton));
      AchievementEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (Icon));
      AchievementEntry.NativeFieldInfoPtr_IconTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (IconTooltip));
      AchievementEntry.NativeFieldInfoPtr_IconTooltipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (IconTooltipText));
      AchievementEntry.NativeFieldInfoPtr_CheckMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (CheckMark));
      AchievementEntry.NativeFieldInfoPtr_Text_Flavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (Text_Flavor));
      AchievementEntry.NativeFieldInfoPtr_Text_Quest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (Text_Quest));
      AchievementEntry.NativeFieldInfoPtr_Text_Reward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (Text_Reward));
      AchievementEntry.NativeFieldInfoPtr_Text_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (Text_Distance));
      AchievementEntry.NativeFieldInfoPtr_Motion2DInOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (Motion2DInOut));
      AchievementEntry.NativeFieldInfoPtr_Motion2DInOutReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (Motion2DInOutReward));
      AchievementEntry.NativeFieldInfoPtr_GlowAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (GlowAnimator));
      AchievementEntry.NativeFieldInfoPtr_QuestTextFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (QuestTextFormat));
      AchievementEntry.NativeFieldInfoPtr_SubTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (SubTasks));
      AchievementEntry.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (PrefabGUID));
      AchievementEntry.NativeFieldInfoPtr_Achievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (Achievement));
      AchievementEntry.NativeFieldInfoPtr__Refresh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, "<Refresh>k__BackingField");
      AchievementEntry.NativeFieldInfoPtr__BackgroundHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, nameof (_BackgroundHover));
      AchievementEntry.NativeMethodInfoPtr_get_Refresh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663932);
      AchievementEntry.NativeMethodInfoPtr_set_Refresh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663933);
      AchievementEntry.NativeMethodInfoPtr_get_ClaimButtonHover_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663934);
      AchievementEntry.NativeMethodInfoPtr_get_BackgroundHover_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663935);
      AchievementEntry.NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663936);
      AchievementEntry.NativeMethodInfoPtr_SetQuestText_Public_Void_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663937);
      AchievementEntry.NativeMethodInfoPtr_OnBackgroundEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663938);
      AchievementEntry.NativeMethodInfoPtr_OnBackgroundExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663939);
      AchievementEntry.NativeMethodInfoPtr_OnIconEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663940);
      AchievementEntry.NativeMethodInfoPtr_OnIconExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663941);
      AchievementEntry.NativeMethodInfoPtr_ReInit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663942);
      AchievementEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementEntry>.NativeClassPtr, 100663943);
    }

    public AchievementEntry(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CanvasGroup CanvasGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_CanvasGroup));
        return pointer == IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject ClaimButtonParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_ClaimButtonParent));
        return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_ClaimButtonParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ClaimButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_ClaimButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_ClaimButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Icon
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Icon));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform IconTooltip
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_IconTooltip));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_IconTooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText IconTooltipText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_IconTooltipText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_IconTooltipText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform CheckMark
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_CheckMark));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_CheckMark), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_Flavor
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Text_Flavor));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Text_Flavor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_Quest
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Text_Quest));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Text_Quest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_Reward
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Text_Reward));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Text_Reward), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Text_Distance
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Text_Distance));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Text_Distance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut Motion2DInOut
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Motion2DInOut));
        return pointer == IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Motion2DInOut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut Motion2DInOutReward
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Motion2DInOutReward));
        return pointer == IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Motion2DInOutReward), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Animator GlowAnimator
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_GlowAnimator));
        return pointer == IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_GlowAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey QuestTextFormat
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_QuestTextFormat));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_QuestTextFormat)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<AchievementSubEntry> SubTasks
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_SubTasks));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<AchievementSubEntry>) null : new Il2CppReferenceArray<AchievementSubEntry>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_SubTasks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGUID PrefabGUID
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_PrefabGUID));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_PrefabGUID)) = value;
      }
    }

    public AchievementEntryData Achievement
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Achievement);
        return new AchievementEntryData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr_Achievement), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AchievementEntryData>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe bool _Refresh_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr__Refresh_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr__Refresh_k__BackingField)) = value;
      }
    }

    public unsafe bool _BackgroundHover
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr__BackgroundHover));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementEntry.NativeFieldInfoPtr__BackgroundHover)) = value;
      }
    }
  }
}
