// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.NewsPanelEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class NewsPanelEntry : UIEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ImageButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_Image;
    private static readonly System.IntPtr NativeFieldInfoPtr_TitleText;
    private static readonly System.IntPtr NativeFieldInfoPtr_BodyText;
    private static readonly System.IntPtr NativeFieldInfoPtr_LinkText;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrevButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReadMoreButton;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBar;
    private static readonly System.IntPtr NativeFieldInfoPtr_Border;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_OpenLinkInBrowser;
    private static readonly System.IntPtr NativeFieldInfoPtr_LK_OpenInGameLink;
    private static readonly System.IntPtr NativeFieldInfoPtr__Data;
    private static readonly System.IntPtr NativeFieldInfoPtr__DisplayProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr__Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnProgressChange;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnOpenGameLink;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnPrev;
    private static readonly System.IntPtr NativeFieldInfoPtr__OnNext;
    private static readonly System.IntPtr NativeFieldInfoPtr__WebRequest;
    private static readonly System.IntPtr NativeFieldInfoPtr__Texture;
    private static readonly System.IntPtr NativeFieldInfoPtr__DownloadedImageUrlHash;
    private static readonly System.IntPtr NativeFieldInfoPtr__Hover;
    private static readonly System.IntPtr NativeFieldInfoPtr_IMAGE_CACHE_DIR;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CacheDir_Private_Static_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrevButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_NextButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadMoreButton_OnClick_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidLink_Private_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidWebLink_Private_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidGameLink_Private_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_NewsPanelEntryData_Boolean_Boolean_Single_Action_1_Boolean_Action_Action_Action_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoUpdate_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLinkTooltip_Private_LocalizationKey_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowTooltipIfHovered_Private_Void_SimpleStunButton_LocalizationKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDownloader_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrySaveTextureToDisk_Private_Void_Texture2D_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadTextureFromDisk_Private_Boolean_String_byref_Texture2D_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ClearWebRequest_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSha256Hash_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public static unsafe string CacheDir
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1279652, RefRangeEnd = 1279654, XrefRangeStart = 1279645, XrefRangeEnd = 1279652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_get_CacheDir_Private_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279654, XrefRangeEnd = 1279683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrevButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_PrevButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279683, XrefRangeEnd = 1279684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void NextButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_NextButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279684, XrefRangeEnd = 1279686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279686, XrefRangeEnd = 1279693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279693, XrefRangeEnd = 1279708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReadMoreButton_OnClick()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_ReadMoreButton_OnClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279708, XrefRangeEnd = 1279713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValidLink(string link)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(link);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_IsValidLink_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279713, XrefRangeEnd = 1279715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValidWebLink(string link)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(link);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_IsValidWebLink_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279715, XrefRangeEnd = 1279717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValidGameLink(string link)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(link);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_IsValidGameLink_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1279723, RefRangeEnd = 1279725, XrefRangeStart = 1279717, XrefRangeEnd = 1279723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      NewsPanelEntryData data,
      bool display,
      bool displayProgress,
      float progress,
      Il2CppSystem.Action<bool> onProgressChange,
      Il2CppSystem.Action onPrev,
      Il2CppSystem.Action onNext,
      Il2CppSystem.Action<string> onOpenGameLink)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[8];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &display;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &displayProgress;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &progress;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onProgressChange);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onPrev);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onNext);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onOpenGameLink);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_SetData_Public_Void_NewsPanelEntryData_Boolean_Boolean_Single_Action_1_Boolean_Action_Action_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1279779, RefRangeEnd = 1279780, XrefRangeStart = 1279725, XrefRangeEnd = 1279779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoUpdate(bool display)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &display;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_DoUpdate_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279780, XrefRangeEnd = 1279790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizationKey GetLinkTooltip(string linkUrl)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(linkUrl);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_GetLinkTooltip_Private_LocalizationKey_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(LocalizationKey*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279790, XrefRangeEnd = 1279794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ShowTooltipIfHovered(SimpleStunButton button, LocalizationKey key)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) button);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &key;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_ShowTooltipIfHovered_Private_Void_SimpleStunButton_LocalizationKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1279806, RefRangeEnd = 1279807, XrefRangeStart = 1279794, XrefRangeEnd = 1279806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateDownloader()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_UpdateDownloader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279807, XrefRangeEnd = 1279827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TrySaveTextureToDisk(Texture2D texture, string imageUrlHash)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(imageUrlHash);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_TrySaveTextureToDisk_Private_Void_Texture2D_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1279862, RefRangeEnd = 1279863, XrefRangeStart = 1279827, XrefRangeEnd = 1279862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryLoadTextureFromDisk(string imageUrlHash, out Texture2D tex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(imageUrlHash);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_TryLoadTextureFromDisk_Private_Boolean_String_byref_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Texture2D local = ref tex;
      System.IntPtr pointer = zero;
      Texture2D texture2D = pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
      local = texture2D;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279863, XrefRangeEnd = 1279866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ClearWebRequest()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_ClearWebRequest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1279882, RefRangeEnd = 1279886, XrefRangeStart = 1279866, XrefRangeEnd = 1279882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string ComputeSha256Hash(string rawString)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(rawString);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_ComputeSha256Hash_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279886, XrefRangeEnd = 1279889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerEnter(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279889, XrefRangeEnd = 1279892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerExit(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NewsPanelEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NewsPanelEntry()
    {
      Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (NewsPanelEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr);
      NewsPanelEntry.NativeFieldInfoPtr_ImageButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (ImageButton));
      NewsPanelEntry.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (Image));
      NewsPanelEntry.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (TitleText));
      NewsPanelEntry.NativeFieldInfoPtr_BodyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (BodyText));
      NewsPanelEntry.NativeFieldInfoPtr_LinkText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (LinkText));
      NewsPanelEntry.NativeFieldInfoPtr_PrevButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (PrevButton));
      NewsPanelEntry.NativeFieldInfoPtr_NextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (NextButton));
      NewsPanelEntry.NativeFieldInfoPtr_ReadMoreButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (ReadMoreButton));
      NewsPanelEntry.NativeFieldInfoPtr_ProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (ProgressBar));
      NewsPanelEntry.NativeFieldInfoPtr_Border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (Border));
      NewsPanelEntry.NativeFieldInfoPtr_LK_OpenLinkInBrowser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (LK_OpenLinkInBrowser));
      NewsPanelEntry.NativeFieldInfoPtr_LK_OpenInGameLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (LK_OpenInGameLink));
      NewsPanelEntry.NativeFieldInfoPtr__Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (_Data));
      NewsPanelEntry.NativeFieldInfoPtr__DisplayProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (_DisplayProgress));
      NewsPanelEntry.NativeFieldInfoPtr__Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (_Progress));
      NewsPanelEntry.NativeFieldInfoPtr__OnProgressChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (_OnProgressChange));
      NewsPanelEntry.NativeFieldInfoPtr__OnOpenGameLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (_OnOpenGameLink));
      NewsPanelEntry.NativeFieldInfoPtr__OnPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (_OnPrev));
      NewsPanelEntry.NativeFieldInfoPtr__OnNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (_OnNext));
      NewsPanelEntry.NativeFieldInfoPtr__WebRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (_WebRequest));
      NewsPanelEntry.NativeFieldInfoPtr__Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (_Texture));
      NewsPanelEntry.NativeFieldInfoPtr__DownloadedImageUrlHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (_DownloadedImageUrlHash));
      NewsPanelEntry.NativeFieldInfoPtr__Hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (_Hover));
      NewsPanelEntry.NativeFieldInfoPtr_IMAGE_CACHE_DIR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, nameof (IMAGE_CACHE_DIR));
      NewsPanelEntry.NativeMethodInfoPtr_get_CacheDir_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668963);
      NewsPanelEntry.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668964);
      NewsPanelEntry.NativeMethodInfoPtr_PrevButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668965);
      NewsPanelEntry.NativeMethodInfoPtr_NextButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668966);
      NewsPanelEntry.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668967);
      NewsPanelEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668968);
      NewsPanelEntry.NativeMethodInfoPtr_ReadMoreButton_OnClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668969);
      NewsPanelEntry.NativeMethodInfoPtr_IsValidLink_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668970);
      NewsPanelEntry.NativeMethodInfoPtr_IsValidWebLink_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668971);
      NewsPanelEntry.NativeMethodInfoPtr_IsValidGameLink_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668972);
      NewsPanelEntry.NativeMethodInfoPtr_SetData_Public_Void_NewsPanelEntryData_Boolean_Boolean_Single_Action_1_Boolean_Action_Action_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668973);
      NewsPanelEntry.NativeMethodInfoPtr_DoUpdate_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668974);
      NewsPanelEntry.NativeMethodInfoPtr_GetLinkTooltip_Private_LocalizationKey_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668975);
      NewsPanelEntry.NativeMethodInfoPtr_ShowTooltipIfHovered_Private_Void_SimpleStunButton_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668976);
      NewsPanelEntry.NativeMethodInfoPtr_UpdateDownloader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668977);
      NewsPanelEntry.NativeMethodInfoPtr_TrySaveTextureToDisk_Private_Void_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668978);
      NewsPanelEntry.NativeMethodInfoPtr_TryLoadTextureFromDisk_Private_Boolean_String_byref_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668979);
      NewsPanelEntry.NativeMethodInfoPtr_ClearWebRequest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668980);
      NewsPanelEntry.NativeMethodInfoPtr_ComputeSha256Hash_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668981);
      NewsPanelEntry.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668982);
      NewsPanelEntry.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668983);
      NewsPanelEntry.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668984);
      NewsPanelEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntry>.NativeClassPtr, 100668985);
    }

    public NewsPanelEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton ImageButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_ImageButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_ImageButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RawImage Image
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_Image));
        return pointer == System.IntPtr.Zero ? (RawImage) null : new RawImage(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text TitleText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_TitleText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text BodyText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_BodyText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_BodyText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text LinkText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_LinkText));
        return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_LinkText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton PrevButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_PrevButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_PrevButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton NextButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_NextButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_NextButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton ReadMoreButton
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_ReadMoreButton));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_ReadMoreButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityEngine.UI.Image ProgressBar
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_ProgressBar));
        return pointer == System.IntPtr.Zero ? (UnityEngine.UI.Image) null : new UnityEngine.UI.Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_ProgressBar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityEngine.UI.Image Border
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_Border));
        return pointer == System.IntPtr.Zero ? (UnityEngine.UI.Image) null : new UnityEngine.UI.Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_Border), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LK_OpenLinkInBrowser
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_LK_OpenLinkInBrowser));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_LK_OpenLinkInBrowser)) = value;
      }
    }

    public unsafe LocalizationKey LK_OpenInGameLink
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_LK_OpenInGameLink));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr_LK_OpenInGameLink)) = value;
      }
    }

    public unsafe NewsPanelEntryData _Data
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__Data));
        return pointer == System.IntPtr.Zero ? (NewsPanelEntryData) null : new NewsPanelEntryData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__Data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _DisplayProgress
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__DisplayProgress));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__DisplayProgress)) = value;
      }
    }

    public unsafe float _Progress
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__Progress));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__Progress)) = value;
      }
    }

    public unsafe Il2CppSystem.Action<bool> _OnProgressChange
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__OnProgressChange));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<bool>) null : new Il2CppSystem.Action<bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__OnProgressChange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<string> _OnOpenGameLink
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__OnOpenGameLink));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<string>) null : new Il2CppSystem.Action<string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__OnOpenGameLink), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action _OnPrev
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__OnPrev));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__OnPrev), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action _OnNext
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__OnNext));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__OnNext), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityWebRequest _WebRequest
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__WebRequest));
        return pointer == System.IntPtr.Zero ? (UnityWebRequest) null : new UnityWebRequest(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__WebRequest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Texture2D _Texture
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__Texture));
        return pointer == System.IntPtr.Zero ? (Texture2D) null : new Texture2D(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__Texture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string _DownloadedImageUrlHash
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__DownloadedImageUrlHash)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__DownloadedImageUrlHash), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool _Hover
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__Hover));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntry.NativeFieldInfoPtr__Hover)) = value;
      }
    }

    public static unsafe string IMAGE_CACHE_DIR
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(NewsPanelEntry.NativeFieldInfoPtr_IMAGE_CACHE_DIR, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NewsPanelEntry.NativeFieldInfoPtr_IMAGE_CACHE_DIR, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
