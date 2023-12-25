// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.StunVideoPlayer
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

#nullable disable
namespace ProjectM.UI
{
  public class StunVideoPlayer : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Player;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubtitleHolder;
    private static readonly System.IntPtr NativeFieldInfoPtr_Subtitle;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoldToSkipImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoldToSkipText;
    private static readonly System.IntPtr NativeFieldInfoPtr_VideoAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnStopped;
    private static readonly System.IntPtr NativeFieldInfoPtr_VolumeDecibel;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentSubtitleEntry;
    private static readonly System.IntPtr NativeMethodInfoPtr_AudioVolumeConvertRatioToDecibel_Public_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AudioVolumeConvertDecibelToRatio_Public_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAsset_Public_Void_StunVideoAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHoldToSkip_Public_Void_Boolean_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275937, XrefRangeEnd = 1275938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float AudioVolumeConvertRatioToDecibel(float volumeRatio)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &volumeRatio;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunVideoPlayer.NativeMethodInfoPtr_AudioVolumeConvertRatioToDecibel_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1275939, RefRangeEnd = 1275940, XrefRangeStart = 1275938, XrefRangeEnd = 1275939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float AudioVolumeConvertDecibelToRatio(float volumeDecibel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &volumeDecibel;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunVideoPlayer.NativeMethodInfoPtr_AudioVolumeConvertDecibelToRatio_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe bool isPlaying
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275940, XrefRangeEnd = 1275942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunVideoPlayer.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1275945, RefRangeEnd = 1275946, XrefRangeStart = 1275942, XrefRangeEnd = 1275945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAsset(StunVideoAsset videoAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) videoAsset);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunVideoPlayer.NativeMethodInfoPtr_SetAsset_Public_Void_StunVideoAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1275948, RefRangeEnd = 1275949, XrefRangeStart = 1275946, XrefRangeEnd = 1275948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Play()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunVideoPlayer.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275949, XrefRangeEnd = 1275978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunVideoPlayer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275978, XrefRangeEnd = 1275980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Stop()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunVideoPlayer.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1275994, RefRangeEnd = 1275996, XrefRangeStart = 1275980, XrefRangeEnd = 1275994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateHoldToSkip(bool canSkip, float timeToSkip = 1f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &canSkip;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &timeToSkip;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunVideoPlayer.NativeMethodInfoPtr_UpdateHoldToSkip_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunVideoPlayer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunVideoPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StunVideoPlayer()
    {
      Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (StunVideoPlayer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr);
      StunVideoPlayer.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, nameof (Player));
      StunVideoPlayer.NativeFieldInfoPtr_SubtitleHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, nameof (SubtitleHolder));
      StunVideoPlayer.NativeFieldInfoPtr_Subtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, nameof (Subtitle));
      StunVideoPlayer.NativeFieldInfoPtr_HoldToSkipImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, nameof (HoldToSkipImage));
      StunVideoPlayer.NativeFieldInfoPtr_HoldToSkipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, nameof (HoldToSkipText));
      StunVideoPlayer.NativeFieldInfoPtr_VideoAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, nameof (VideoAsset));
      StunVideoPlayer.NativeFieldInfoPtr_OnStopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, nameof (OnStopped));
      StunVideoPlayer.NativeFieldInfoPtr_VolumeDecibel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, nameof (VolumeDecibel));
      StunVideoPlayer.NativeFieldInfoPtr__CurrentSubtitleEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, nameof (_CurrentSubtitleEntry));
      StunVideoPlayer.NativeMethodInfoPtr_AudioVolumeConvertRatioToDecibel_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, 100668515);
      StunVideoPlayer.NativeMethodInfoPtr_AudioVolumeConvertDecibelToRatio_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, 100668516);
      StunVideoPlayer.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, 100668517);
      StunVideoPlayer.NativeMethodInfoPtr_SetAsset_Public_Void_StunVideoAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, 100668518);
      StunVideoPlayer.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, 100668519);
      StunVideoPlayer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, 100668520);
      StunVideoPlayer.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, 100668521);
      StunVideoPlayer.NativeMethodInfoPtr_UpdateHoldToSkip_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, 100668522);
      StunVideoPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunVideoPlayer>.NativeClassPtr, 100668523);
    }

    public StunVideoPlayer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe VideoPlayer Player
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_Player));
        return pointer == System.IntPtr.Zero ? (VideoPlayer) null : new VideoPlayer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform SubtitleHolder
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_SubtitleHolder));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_SubtitleHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Subtitle
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_Subtitle));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_Subtitle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image HoldToSkipImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_HoldToSkipImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_HoldToSkipImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText HoldToSkipText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_HoldToSkipText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_HoldToSkipText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StunVideoAsset VideoAsset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_VideoAsset));
        return pointer == System.IntPtr.Zero ? (StunVideoAsset) null : new StunVideoAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_VideoAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action OnStopped
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_OnStopped));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_OnStopped), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float VolumeDecibel
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_VolumeDecibel));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr_VolumeDecibel)) = value;
      }
    }

    public unsafe Nullable_Unboxed<SubtitleEntry> _CurrentSubtitleEntry
    {
      get
      {
        return *(Nullable_Unboxed<SubtitleEntry>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr__CurrentSubtitleEntry));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunVideoPlayer.NativeFieldInfoPtr__CurrentSubtitleEntry), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<SubtitleEntry>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
