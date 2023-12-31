// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.StunHovereableButton
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace ProjectM.UI
{
  public class StunHovereableButton : SimpleStunButton
  {
    private static readonly IntPtr NativeFieldInfoPtr_Hovered;
    private static readonly IntPtr NativeFieldInfoPtr_EnabledObjectsOnHover;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Void_PointerEventData_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795659, XrefRangeEnd = 795660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunHovereableButton()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunHovereableButton>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunHovereableButton.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795660, XrefRangeEnd = 795666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnPointerEnter(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunHovereableButton.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 795666, XrefRangeEnd = 795672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnPointerExit(PointerEventData eventData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StunHovereableButton.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StunHovereableButton()
    {
      Il2CppClassPointerStore<StunHovereableButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (StunHovereableButton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunHovereableButton>.NativeClassPtr);
      StunHovereableButton.NativeFieldInfoPtr_Hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunHovereableButton>.NativeClassPtr, nameof (Hovered));
      StunHovereableButton.NativeFieldInfoPtr_EnabledObjectsOnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunHovereableButton>.NativeClassPtr, nameof (EnabledObjectsOnHover));
      StunHovereableButton.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunHovereableButton>.NativeClassPtr, 100670212);
      StunHovereableButton.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunHovereableButton>.NativeClassPtr, 100670213);
      StunHovereableButton.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunHovereableButton>.NativeClassPtr, 100670214);
    }

    public StunHovereableButton(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool Hovered
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunHovereableButton.NativeFieldInfoPtr_Hovered));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunHovereableButton.NativeFieldInfoPtr_Hovered)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<GameObject> EnabledObjectsOnHover
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunHovereableButton.NativeFieldInfoPtr_EnabledObjectsOnHover));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunHovereableButton.NativeFieldInfoPtr_EnabledObjectsOnHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
