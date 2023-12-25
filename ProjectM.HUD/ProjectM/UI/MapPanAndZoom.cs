// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.MapPanAndZoom
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace ProjectM.UI
{
  public class MapPanAndZoom : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OnBeginDrag;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnDrag;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnEndDrag;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnScroll;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnClick;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IBeginDragHandler_OnBeginDrag_Private_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IEndDragHandler_OnEndDrag_Private_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IScrollHandler_OnScroll_Private_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerClickHandler_OnPointerClick_Private_Virtual_Final_New_Void_PointerEventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270719, XrefRangeEnd = 1270737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void UnityEngine_EventSystems_IBeginDragHandler_OnBeginDrag(
      PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPanAndZoom.NativeMethodInfoPtr_UnityEngine_EventSystems_IBeginDragHandler_OnBeginDrag_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270737, XrefRangeEnd = 1270755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void UnityEngine_EventSystems_IDragHandler_OnDrag(
      PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPanAndZoom.NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270755, XrefRangeEnd = 1270773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void UnityEngine_EventSystems_IEndDragHandler_OnEndDrag(
      PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPanAndZoom.NativeMethodInfoPtr_UnityEngine_EventSystems_IEndDragHandler_OnEndDrag_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270773, XrefRangeEnd = 1270791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void UnityEngine_EventSystems_IScrollHandler_OnScroll(
      PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPanAndZoom.NativeMethodInfoPtr_UnityEngine_EventSystems_IScrollHandler_OnScroll_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1270791, XrefRangeEnd = 1270809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void UnityEngine_EventSystems_IPointerClickHandler_OnPointerClick(
      PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPanAndZoom.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerClickHandler_OnPointerClick_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MapPanAndZoom()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPanAndZoom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MapPanAndZoom()
    {
      Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (MapPanAndZoom));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr);
      MapPanAndZoom.NativeFieldInfoPtr_OnBeginDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr, nameof (OnBeginDrag));
      MapPanAndZoom.NativeFieldInfoPtr_OnDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr, nameof (OnDrag));
      MapPanAndZoom.NativeFieldInfoPtr_OnEndDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr, nameof (OnEndDrag));
      MapPanAndZoom.NativeFieldInfoPtr_OnScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr, nameof (OnScroll));
      MapPanAndZoom.NativeFieldInfoPtr_OnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr, nameof (OnClick));
      MapPanAndZoom.NativeMethodInfoPtr_UnityEngine_EventSystems_IBeginDragHandler_OnBeginDrag_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr, 100667952);
      MapPanAndZoom.NativeMethodInfoPtr_UnityEngine_EventSystems_IDragHandler_OnDrag_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr, 100667953);
      MapPanAndZoom.NativeMethodInfoPtr_UnityEngine_EventSystems_IEndDragHandler_OnEndDrag_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr, 100667954);
      MapPanAndZoom.NativeMethodInfoPtr_UnityEngine_EventSystems_IScrollHandler_OnScroll_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr, 100667955);
      MapPanAndZoom.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerClickHandler_OnPointerClick_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr, 100667956);
      MapPanAndZoom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPanAndZoom>.NativeClassPtr, 100667957);
    }

    public MapPanAndZoom(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Action<PointerEventData> OnBeginDrag
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPanAndZoom.NativeFieldInfoPtr_OnBeginDrag));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<PointerEventData>) null : new Il2CppSystem.Action<PointerEventData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPanAndZoom.NativeFieldInfoPtr_OnBeginDrag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<PointerEventData> OnDrag
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPanAndZoom.NativeFieldInfoPtr_OnDrag));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<PointerEventData>) null : new Il2CppSystem.Action<PointerEventData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPanAndZoom.NativeFieldInfoPtr_OnDrag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<PointerEventData> OnEndDrag
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPanAndZoom.NativeFieldInfoPtr_OnEndDrag));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<PointerEventData>) null : new Il2CppSystem.Action<PointerEventData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPanAndZoom.NativeFieldInfoPtr_OnEndDrag), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<PointerEventData> OnScroll
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPanAndZoom.NativeFieldInfoPtr_OnScroll));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<PointerEventData>) null : new Il2CppSystem.Action<PointerEventData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPanAndZoom.NativeFieldInfoPtr_OnScroll), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<PointerEventData> OnClick
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPanAndZoom.NativeFieldInfoPtr_OnClick));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<PointerEventData>) null : new Il2CppSystem.Action<PointerEventData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPanAndZoom.NativeFieldInfoPtr_OnClick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
