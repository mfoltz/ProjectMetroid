// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TMP_LinkClickHandler
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace ProjectM.UI
{
  public class TMP_LinkClickHandler : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr__TextElement;
    private static readonly IntPtr NativeFieldInfoPtr__onLinkClicked_k__BackingField;
    private static readonly IntPtr NativeMethodInfoPtr_get_onLinkClicked_Public_get_LinkClickedEvent_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_onLinkClicked_Public_set_Void_LinkClickedEvent_0;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe LinkClickedEvent onLinkClicked
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(TMP_LinkClickHandler.NativeMethodInfoPtr_get_onLinkClicked_Public_get_LinkClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (LinkClickedEvent) null : new LinkClickedEvent(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TMP_LinkClickHandler.NativeMethodInfoPtr_set_onLinkClicked_Public_set_Void_LinkClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287976, XrefRangeEnd = 1287980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TMP_LinkClickHandler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287980, XrefRangeEnd = 1287989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnPointerClick(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TMP_LinkClickHandler.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1287989, XrefRangeEnd = 1287995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TMP_LinkClickHandler()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_LinkClickHandler>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TMP_LinkClickHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TMP_LinkClickHandler()
    {
      Il2CppClassPointerStore<TMP_LinkClickHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TMP_LinkClickHandler));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_LinkClickHandler>.NativeClassPtr);
      TMP_LinkClickHandler.NativeFieldInfoPtr__TextElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkClickHandler>.NativeClassPtr, nameof (_TextElement));
      TMP_LinkClickHandler.NativeFieldInfoPtr__onLinkClicked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_LinkClickHandler>.NativeClassPtr, "<onLinkClicked>k__BackingField");
      TMP_LinkClickHandler.NativeMethodInfoPtr_get_onLinkClicked_Public_get_LinkClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_LinkClickHandler>.NativeClassPtr, 100669610);
      TMP_LinkClickHandler.NativeMethodInfoPtr_set_onLinkClicked_Public_set_Void_LinkClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_LinkClickHandler>.NativeClassPtr, 100669611);
      TMP_LinkClickHandler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_LinkClickHandler>.NativeClassPtr, 100669612);
      TMP_LinkClickHandler.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_LinkClickHandler>.NativeClassPtr, 100669613);
      TMP_LinkClickHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_LinkClickHandler>.NativeClassPtr, 100669614);
    }

    public TMP_LinkClickHandler(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TMP_Text _TextElement
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TMP_LinkClickHandler.NativeFieldInfoPtr__TextElement));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TMP_LinkClickHandler.NativeFieldInfoPtr__TextElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LinkClickedEvent _onLinkClicked_k__BackingField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TMP_LinkClickHandler.NativeFieldInfoPtr__onLinkClicked_k__BackingField));
        return pointer == IntPtr.Zero ? (LinkClickedEvent) null : new LinkClickedEvent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TMP_LinkClickHandler.NativeFieldInfoPtr__onLinkClicked_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
