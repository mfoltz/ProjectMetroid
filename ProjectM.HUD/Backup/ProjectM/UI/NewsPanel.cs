// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.NewsPanel
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class NewsPanel : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdsContentNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewsContentNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewsEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__AdsEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr__NewsEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReadMoreNewsButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_OpenLinkInBrowser;
    private static readonly System.IntPtr NativeFieldInfoPtr__NewsManagerSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentAdsIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnOpenPopup;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSystem_Private_Boolean_byref_NewsManagerSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnOpenGameLink_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetGameLinkType_Private_GameLinkType_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowTooltipIfHovered_Private_Void_SimpleStunButton_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279460, XrefRangeEnd = 1279482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1279490, RefRangeEnd = 1279491, XrefRangeStart = 1279482, XrefRangeEnd = 1279490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetSystem(out NewsManagerSystem system)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsPanel.NativeMethodInfoPtr_TryGetSystem_Private_Boolean_byref_NewsManagerSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref NewsManagerSystem local = ref system;
      System.IntPtr pointer = zero;
      NewsManagerSystem newsManagerSystem = pointer == System.IntPtr.Zero ? (NewsManagerSystem) null : new NewsManagerSystem(pointer);
      local = newsManagerSystem;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279491, XrefRangeEnd = 1279617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279617, XrefRangeEnd = 1279637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnOpenGameLink(string link)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(link);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanel.NativeMethodInfoPtr_OnOpenGameLink_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279637, XrefRangeEnd = 1279641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameLinkType GetGameLinkType(string linkTypeString)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(linkTypeString);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsPanel.NativeMethodInfoPtr_GetGameLinkType_Private_GameLinkType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GameLinkType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279641, XrefRangeEnd = 1279645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowTooltipIfHovered(SimpleStunButton button, LocalizationKey key)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) button);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &key;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanel.NativeMethodInfoPtr_ShowTooltipIfHovered_Private_Void_SimpleStunButton_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NewsPanel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NewsPanel()
    {
      Il2CppClassPointerStore<NewsPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (NewsPanel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr);
      NewsPanel.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, nameof (CanvasGroup));
      NewsPanel.NativeFieldInfoPtr_AdsContentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, nameof (AdsContentNode));
      NewsPanel.NativeFieldInfoPtr_NewsContentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, nameof (NewsContentNode));
      NewsPanel.NativeFieldInfoPtr_NewsEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, nameof (NewsEntryPrefab));
      NewsPanel.NativeFieldInfoPtr__AdsEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, nameof (_AdsEntries));
      NewsPanel.NativeFieldInfoPtr__NewsEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, nameof (_NewsEntries));
      NewsPanel.NativeFieldInfoPtr_ReadMoreNewsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, nameof (ReadMoreNewsButton));
      NewsPanel.NativeFieldInfoPtr_LK_OpenLinkInBrowser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, nameof (LK_OpenLinkInBrowser));
      NewsPanel.NativeFieldInfoPtr__NewsManagerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, nameof (_NewsManagerSystem));
      NewsPanel.NativeFieldInfoPtr__CurrentAdsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, nameof (_CurrentAdsIndex));
      NewsPanel.NativeFieldInfoPtr_OnOpenPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, nameof (OnOpenPopup));
      NewsPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, 100668951);
      NewsPanel.NativeMethodInfoPtr_TryGetSystem_Private_Boolean_byref_NewsManagerSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, 100668952);
      NewsPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, 100668953);
      NewsPanel.NativeMethodInfoPtr_OnOpenGameLink_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, 100668954);
      NewsPanel.NativeMethodInfoPtr_GetGameLinkType_Private_GameLinkType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, 100668955);
      NewsPanel.NativeMethodInfoPtr_ShowTooltipIfHovered_Private_Void_SimpleStunButton_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, 100668956);
      NewsPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, 100668957);
    }

    public NewsPanel(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CanvasGroup CanvasGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_CanvasGroup));
        return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform AdsContentNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_AdsContentNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_AdsContentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform NewsContentNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_NewsContentNode));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_NewsContentNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NewsPanelEntry NewsEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_NewsEntryPrefab));
        return pointer == System.IntPtr.Zero ? (NewsPanelEntry) null : new NewsPanelEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_NewsEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<NewsPanelEntry> _AdsEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr__AdsEntries));
        return pointer == System.IntPtr.Zero ? (UI_Cache<NewsPanelEntry>) null : new UI_Cache<NewsPanelEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr__AdsEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<NewsPanelEntry> _NewsEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr__NewsEntries));
        return pointer == System.IntPtr.Zero ? (UI_Cache<NewsPanelEntry>) null : new UI_Cache<NewsPanelEntry>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr__NewsEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ReadMoreNewsButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_ReadMoreNewsButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_ReadMoreNewsButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_OpenLinkInBrowser
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_LK_OpenLinkInBrowser));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_LK_OpenLinkInBrowser)) = value;
      }
    }

    public unsafe NewsManagerSystem _NewsManagerSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr__NewsManagerSystem));
        return pointer == System.IntPtr.Zero ? (NewsManagerSystem) null : new NewsManagerSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr__NewsManagerSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _CurrentAdsIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr__CurrentAdsIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr__CurrentAdsIndex)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<PopupType> OnOpenPopup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_OnOpenPopup));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<PopupType>) null : new Il2CppSystem.Action<PopupType>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.NativeFieldInfoPtr_OnOpenPopup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.NewsPanel/<>c__DisplayClass13_0")]
    public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_system;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__0_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__1_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__2_Internal_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__3_Internal_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass13_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NewsPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279452, XrefRangeEnd = 1279454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Update_b__0()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NewsPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__Update_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279454, XrefRangeEnd = 1279456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Update_b__1()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NewsPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__Update_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279456, XrefRangeEnd = 1279458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Update_b__2()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NewsPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__Update_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279458, XrefRangeEnd = 1279460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _Update_b__3()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NewsPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__Update_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass13_0()
      {
        Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewsPanel>.NativeClassPtr, "<>c__DisplayClass13_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr);
        NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_system = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr, nameof (system));
        NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr, "<>9__0");
        NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr, "<>9__1");
        NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr, "<>9__2");
        NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr, "<>9__3");
        NewsPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr, 100668958);
        NewsPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__Update_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr, 100668959);
        NewsPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__Update_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr, 100668960);
        NewsPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__Update_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr, 100668961);
        NewsPanel.__c__DisplayClass13_0.NativeMethodInfoPtr__Update_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanel.__c__DisplayClass13_0>.NativeClassPtr, 100668962);
      }

      public __c__DisplayClass13_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe NewsManagerSystem system
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_system));
          return pointer == System.IntPtr.Zero ? (NewsManagerSystem) null : new NewsManagerSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr_system), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action __9__0
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__0));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action __9__1
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__1));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action __9__2
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__2));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppSystem.Action __9__3
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__3));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanel.__c__DisplayClass13_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
