// Decompiled with JetBrains decompiler
// Type: StunScrollRect
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
public class StunScrollRect : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_ViewRect;
  private static readonly IntPtr NativeFieldInfoPtr_ContentRect;
  private static readonly IntPtr NativeFieldInfoPtr_VerticalScrollbar;
  private static readonly IntPtr NativeFieldInfoPtr_ScrollSensitivity;
  private static readonly IntPtr NativeFieldInfoPtr__Prefab;
  private static readonly IntPtr NativeFieldInfoPtr__StepsPerEntry;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_RectTransform_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_Int32_byref_Int32_byref_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1209133, RefRangeEnd = 1209135, XrefRangeStart = 1209132, XrefRangeEnd = 1209133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Initialize(RectTransform prefab, int stepsPerEntry = 2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stepsPerEntry;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StunScrollRect.NativeMethodInfoPtr_Initialize_Public_Void_RectTransform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1209157, RefRangeEnd = 1209159, XrefRangeStart = 1209135, XrefRangeEnd = 1209157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Refresh(int entriesCount, out int minIndex, out int maxIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &entriesCount;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref minIndex;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref maxIndex;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StunScrollRect.NativeMethodInfoPtr_Refresh_Public_Void_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1209159, XrefRangeEnd = 1209166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnScroll(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StunScrollRect.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StunScrollRect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StunScrollRect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StunScrollRect()
  {
    Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (StunScrollRect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr);
    StunScrollRect.NativeFieldInfoPtr_ViewRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr, nameof (ViewRect));
    StunScrollRect.NativeFieldInfoPtr_ContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr, nameof (ContentRect));
    StunScrollRect.NativeFieldInfoPtr_VerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr, nameof (VerticalScrollbar));
    StunScrollRect.NativeFieldInfoPtr_ScrollSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr, nameof (ScrollSensitivity));
    StunScrollRect.NativeFieldInfoPtr__Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr, nameof (_Prefab));
    StunScrollRect.NativeFieldInfoPtr__StepsPerEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr, nameof (_StepsPerEntry));
    StunScrollRect.NativeMethodInfoPtr_Initialize_Public_Void_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr, 100663587);
    StunScrollRect.NativeMethodInfoPtr_Refresh_Public_Void_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr, 100663588);
    StunScrollRect.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr, 100663589);
    StunScrollRect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunScrollRect>.NativeClassPtr, 100663590);
  }

  public StunScrollRect(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RectTransform ViewRect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr_ViewRect));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr_ViewRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform ContentRect
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr_ContentRect));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr_ContentRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Scrollbar VerticalScrollbar
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr_VerticalScrollbar));
      return pointer == IntPtr.Zero ? (Scrollbar) null : new Scrollbar(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr_VerticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float ScrollSensitivity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr_ScrollSensitivity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr_ScrollSensitivity)) = value;
    }
  }

  public unsafe RectTransform _Prefab
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr__Prefab));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr__Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _StepsPerEntry
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr__StepsPerEntry));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunScrollRect.NativeFieldInfoPtr__StepsPerEntry)) = value;
    }
  }
}
