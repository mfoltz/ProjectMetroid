// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LinksHUDParent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class LinksHUDParent : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LinkElementSelectionGroup;
    private static readonly IntPtr NativeFieldInfoPtr_LinkElementParent;
    private static readonly IntPtr NativeFieldInfoPtr_LinkElementPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_MenuData;
    private static readonly IntPtr NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1267540, XrefRangeEnd = 1267555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new virtual unsafe void StunShared_UI_IInitializeableUI_InitializeUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinksHUDParent.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LinksHUDParent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinksHUDParent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LinksHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LinksHUDParent()
    {
      Il2CppClassPointerStore<LinksHUDParent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (LinksHUDParent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinksHUDParent>.NativeClassPtr);
      LinksHUDParent.NativeFieldInfoPtr_LinkElementSelectionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDParent>.NativeClassPtr, nameof (LinkElementSelectionGroup));
      LinksHUDParent.NativeFieldInfoPtr_LinkElementParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDParent>.NativeClassPtr, nameof (LinkElementParent));
      LinksHUDParent.NativeFieldInfoPtr_LinkElementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDParent>.NativeClassPtr, nameof (LinkElementPrefab));
      LinksHUDParent.NativeFieldInfoPtr_MenuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinksHUDParent>.NativeClassPtr, nameof (MenuData));
      LinksHUDParent.NativeMethodInfoPtr_StunShared_UI_IInitializeableUI_InitializeUI_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinksHUDParent>.NativeClassPtr, 100667697);
      LinksHUDParent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinksHUDParent>.NativeClassPtr, 100667698);
    }

    public LinksHUDParent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GridSelectionGroup<LinksHUDElement, LinksHUDElement.Data> LinkElementSelectionGroup
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDParent.NativeFieldInfoPtr_LinkElementSelectionGroup));
        return pointer == IntPtr.Zero ? (GridSelectionGroup<LinksHUDElement, LinksHUDElement.Data>) null : new GridSelectionGroup<LinksHUDElement, LinksHUDElement.Data>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDParent.NativeFieldInfoPtr_LinkElementSelectionGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GridLayoutGroup LinkElementParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDParent.NativeFieldInfoPtr_LinkElementParent));
        return pointer == IntPtr.Zero ? (GridLayoutGroup) null : new GridLayoutGroup(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDParent.NativeFieldInfoPtr_LinkElementParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LinksHUDElement LinkElementPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDParent.NativeFieldInfoPtr_LinkElementPrefab));
        return pointer == IntPtr.Zero ? (LinksHUDElement) null : new LinksHUDElement(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDParent.NativeFieldInfoPtr_LinkElementPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LinksHUDDataArray MenuData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDParent.NativeFieldInfoPtr_MenuData));
        return pointer == IntPtr.Zero ? (LinksHUDDataArray) null : new LinksHUDDataArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LinksHUDParent.NativeFieldInfoPtr_MenuData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
