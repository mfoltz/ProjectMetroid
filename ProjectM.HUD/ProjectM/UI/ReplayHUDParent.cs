// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ReplayHUDParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ReplayHUDParent : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Slider;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScreenshotImage;
    private static readonly System.IntPtr NativeFieldInfoPtr_BottomBar;
    private static readonly System.IntPtr NativeFieldInfoPtr_Motions;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartRecordingButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_PauseButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecordCameraSweepButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaybackCameraSweepButtonText;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnSliderPointerUp;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnSliderPointerDown;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnToggleRecordingClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnTogglePauseClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnToggleSweepRecordingClicked;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnToggleSweepPlaybackClicked;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleSliderPointerDown_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleSliderPointerUp_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleToggleRecordingClicked_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleTogglePauseClicked_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleToggleSweepRecordingClicked_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleToggleSweepPlaybackClicked_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274317, XrefRangeEnd = 1274318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleSliderPointerDown()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDParent.NativeMethodInfoPtr_HandleSliderPointerDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleSliderPointerUp()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDParent.NativeMethodInfoPtr_HandleSliderPointerUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274318, XrefRangeEnd = 1274319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleToggleRecordingClicked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDParent.NativeMethodInfoPtr_HandleToggleRecordingClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274319, XrefRangeEnd = 1274320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleTogglePauseClicked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDParent.NativeMethodInfoPtr_HandleTogglePauseClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274320, XrefRangeEnd = 1274321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleToggleSweepRecordingClicked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDParent.NativeMethodInfoPtr_HandleToggleSweepRecordingClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274321, XrefRangeEnd = 1274322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleToggleSweepPlaybackClicked()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDParent.NativeMethodInfoPtr_HandleToggleSweepPlaybackClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReplayHUDParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplayHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReplayHUDParent()
    {
      Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ReplayHUDParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr);
      ReplayHUDParent.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (Slider));
      ReplayHUDParent.NativeFieldInfoPtr_ScreenshotImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (ScreenshotImage));
      ReplayHUDParent.NativeFieldInfoPtr_BottomBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (BottomBar));
      ReplayHUDParent.NativeFieldInfoPtr_Motions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (Motions));
      ReplayHUDParent.NativeFieldInfoPtr_StartRecordingButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (StartRecordingButtonText));
      ReplayHUDParent.NativeFieldInfoPtr_PauseButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (PauseButtonText));
      ReplayHUDParent.NativeFieldInfoPtr_RecordCameraSweepButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (RecordCameraSweepButtonText));
      ReplayHUDParent.NativeFieldInfoPtr_PlaybackCameraSweepButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (PlaybackCameraSweepButtonText));
      ReplayHUDParent.NativeFieldInfoPtr_OnSliderPointerUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (OnSliderPointerUp));
      ReplayHUDParent.NativeFieldInfoPtr_OnSliderPointerDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (OnSliderPointerDown));
      ReplayHUDParent.NativeFieldInfoPtr_OnToggleRecordingClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (OnToggleRecordingClicked));
      ReplayHUDParent.NativeFieldInfoPtr_OnTogglePauseClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (OnTogglePauseClicked));
      ReplayHUDParent.NativeFieldInfoPtr_OnToggleSweepRecordingClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (OnToggleSweepRecordingClicked));
      ReplayHUDParent.NativeFieldInfoPtr_OnToggleSweepPlaybackClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, nameof (OnToggleSweepPlaybackClicked));
      ReplayHUDParent.NativeMethodInfoPtr_HandleSliderPointerDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, 100668332);
      ReplayHUDParent.NativeMethodInfoPtr_HandleSliderPointerUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, 100668333);
      ReplayHUDParent.NativeMethodInfoPtr_HandleToggleRecordingClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, 100668334);
      ReplayHUDParent.NativeMethodInfoPtr_HandleTogglePauseClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, 100668335);
      ReplayHUDParent.NativeMethodInfoPtr_HandleToggleSweepRecordingClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, 100668336);
      ReplayHUDParent.NativeMethodInfoPtr_HandleToggleSweepPlaybackClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, 100668337);
      ReplayHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplayHUDParent>.NativeClassPtr, 100668338);
    }

    public ReplayHUDParent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Slider Slider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_Slider));
        return pointer == System.IntPtr.Zero ? (Slider) null : new Slider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image ScreenshotImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_ScreenshotImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_ScreenshotImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform BottomBar
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_BottomBar));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_BottomBar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DInOut Motions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_Motions));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_Motions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextMeshProUGUI StartRecordingButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_StartRecordingButtonText));
        return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_StartRecordingButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextMeshProUGUI PauseButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_PauseButtonText));
        return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_PauseButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextMeshProUGUI RecordCameraSweepButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_RecordCameraSweepButtonText));
        return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_RecordCameraSweepButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TextMeshProUGUI PlaybackCameraSweepButtonText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_PlaybackCameraSweepButtonText));
        return pointer == System.IntPtr.Zero ? (TextMeshProUGUI) null : new TextMeshProUGUI(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_PlaybackCameraSweepButtonText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action OnSliderPointerUp
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnSliderPointerUp));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnSliderPointerUp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action OnSliderPointerDown
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnSliderPointerDown));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnSliderPointerDown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action OnToggleRecordingClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnToggleRecordingClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnToggleRecordingClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action OnTogglePauseClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnTogglePauseClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnTogglePauseClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action OnToggleSweepRecordingClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnToggleSweepRecordingClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnToggleSweepRecordingClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action OnToggleSweepPlaybackClicked
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnToggleSweepPlaybackClicked));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplayHUDParent.NativeFieldInfoPtr_OnToggleSweepPlaybackClicked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
