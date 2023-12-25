// Decompiled with JetBrains decompiler
// Type: PopupManager
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class PopupManager : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Popups;
  private static readonly System.IntPtr NativeFieldInfoPtr_FadeImage;
  private static readonly System.IntPtr NativeFieldInfoPtr__CurrentPopup;
  private static readonly System.IntPtr NativeFieldInfoPtr__QueuedPopups;
  private static readonly System.IntPtr NativeMethodInfoPtr_PushPopup_Public_Void_PopupType_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetActivePopup_Private_Void_ShowPopupRequest_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClosePopup_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 1209095, RefRangeEnd = 1209098, XrefRangeStart = 1209092, XrefRangeEnd = 1209095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PushPopup(PopupType popup, Il2CppSystem.Action onClose = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &popup;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onClose);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_PushPopup_Public_Void_PopupType_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209098, XrefRangeEnd = 1209099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetActivePopup(PopupManager.ShowPopupRequest request)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) request));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_SetActivePopup_Private_Void_ShowPopupRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209099, XrefRangeEnd = 1209105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClosePopup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_ClosePopup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209105, XrefRangeEnd = 1209111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209111, XrefRangeEnd = 1209118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209118, XrefRangeEnd = 1209126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PopupManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PopupManager()
  {
    Il2CppClassPointerStore<PopupManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (PopupManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopupManager>.NativeClassPtr);
    PopupManager.NativeFieldInfoPtr_Popups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, nameof (Popups));
    PopupManager.NativeFieldInfoPtr_FadeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, nameof (FadeImage));
    PopupManager.NativeFieldInfoPtr__CurrentPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, nameof (_CurrentPopup));
    PopupManager.NativeFieldInfoPtr__QueuedPopups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, nameof (_QueuedPopups));
    PopupManager.NativeMethodInfoPtr_PushPopup_Public_Void_PopupType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100663576);
    PopupManager.NativeMethodInfoPtr_SetActivePopup_Private_Void_ShowPopupRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100663577);
    PopupManager.NativeMethodInfoPtr_ClosePopup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100663578);
    PopupManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100663579);
    PopupManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100663580);
    PopupManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100663581);
  }

  public PopupManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<PopupData> Popups
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_Popups));
      return pointer == System.IntPtr.Zero ? (List<PopupData>) null : new List<PopupData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_Popups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image FadeImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_FadeImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_FadeImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public PopupManager.ShowPopupRequest _CurrentPopup
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr__CurrentPopup);
      return new PopupManager.ShowPopupRequest(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PopupManager.ShowPopupRequest>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr__CurrentPopup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PopupManager.ShowPopupRequest>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Queue<PopupManager.ShowPopupRequest> _QueuedPopups
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr__QueuedPopups));
      return pointer == System.IntPtr.Zero ? (Queue<PopupManager.ShowPopupRequest>) null : new Queue<PopupManager.ShowPopupRequest>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr__QueuedPopups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class ShowPopupRequest : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnClose;

    static ShowPopupRequest()
    {
      Il2CppClassPointerStore<PopupManager.ShowPopupRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, nameof (ShowPopupRequest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopupManager.ShowPopupRequest>.NativeClassPtr);
      PopupManager.ShowPopupRequest.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager.ShowPopupRequest>.NativeClassPtr, nameof (Type));
      PopupManager.ShowPopupRequest.NativeFieldInfoPtr_OnClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager.ShowPopupRequest>.NativeClassPtr, nameof (OnClose));
    }

    public ShowPopupRequest(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ShowPopupRequest()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PopupManager.ShowPopupRequest>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PopupManager.ShowPopupRequest>.NativeClassPtr, data));
    }

    public unsafe PopupType Type
    {
      get
      {
        return *(PopupType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.ShowPopupRequest.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(PopupType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.ShowPopupRequest.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe Il2CppSystem.Action OnClose
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.ShowPopupRequest.NativeFieldInfoPtr_OnClose));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PopupManager.ShowPopupRequest.NativeFieldInfoPtr_OnClose), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
