// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ForgeSubMenu_MagicCircle
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ForgeSubMenu_MagicCircle : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ForegroundImage;
    private static readonly IntPtr NativeFieldInfoPtr_Motion;
    private static readonly IntPtr NativeFieldInfoPtr_Icon_T06;
    private static readonly IntPtr NativeFieldInfoPtr_Icon_T08;
    private static readonly IntPtr NativeMethodInfoPtr_Refresh_Internal_Void_Single_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetActive_Internal_Void_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1235379, RefRangeEnd = 1235380, XrefRangeStart = 1235374, XrefRangeEnd = 1235379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Refresh(float weaponLevel, bool resetMotion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &weaponLevel;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &resetMotion;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu_MagicCircle.NativeMethodInfoPtr_Refresh_Internal_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235380, XrefRangeEnd = 1235381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetActive(bool state)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &state;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu_MagicCircle.NativeMethodInfoPtr_SetActive_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ForgeSubMenu_MagicCircle()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForgeSubMenu_MagicCircle>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ForgeSubMenu_MagicCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ForgeSubMenu_MagicCircle()
    {
      Il2CppClassPointerStore<ForgeSubMenu_MagicCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ForgeSubMenu_MagicCircle));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForgeSubMenu_MagicCircle>.NativeClassPtr);
      ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_ForegroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_MagicCircle>.NativeClassPtr, nameof (ForegroundImage));
      ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_Motion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_MagicCircle>.NativeClassPtr, nameof (Motion));
      ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_Icon_T06 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_MagicCircle>.NativeClassPtr, nameof (Icon_T06));
      ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_Icon_T08 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForgeSubMenu_MagicCircle>.NativeClassPtr, nameof (Icon_T08));
      ForgeSubMenu_MagicCircle.NativeMethodInfoPtr_Refresh_Internal_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu_MagicCircle>.NativeClassPtr, 100665732);
      ForgeSubMenu_MagicCircle.NativeMethodInfoPtr_SetActive_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu_MagicCircle>.NativeClassPtr, 100665733);
      ForgeSubMenu_MagicCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForgeSubMenu_MagicCircle>.NativeClassPtr, 100665734);
    }

    public ForgeSubMenu_MagicCircle(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image ForegroundImage
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_ForegroundImage));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_ForegroundImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Motion2DBinding Motion
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_Motion));
        return pointer == IntPtr.Zero ? (Motion2DBinding) null : new Motion2DBinding(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_Motion), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_T06
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_Icon_T06));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_Icon_T06), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sprite Icon_T08
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_Icon_T08));
        return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForgeSubMenu_MagicCircle.NativeFieldInfoPtr_Icon_T08), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
