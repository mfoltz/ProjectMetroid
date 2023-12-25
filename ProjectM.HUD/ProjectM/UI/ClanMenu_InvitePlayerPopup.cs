// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ClanMenu_InvitePlayerPopup
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;

#nullable disable
namespace ProjectM.UI
{
  public class ClanMenu_InvitePlayerPopup : GenericPopup
  {
    private static readonly IntPtr NativeFieldInfoPtr_PlayerNameInputField;
    private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232453, XrefRangeEnd = 1232457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnShow()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClanMenu_InvitePlayerPopup.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClanMenu_InvitePlayerPopup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanMenu_InvitePlayerPopup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanMenu_InvitePlayerPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClanMenu_InvitePlayerPopup()
    {
      Il2CppClassPointerStore<ClanMenu_InvitePlayerPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ClanMenu_InvitePlayerPopup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanMenu_InvitePlayerPopup>.NativeClassPtr);
      ClanMenu_InvitePlayerPopup.NativeFieldInfoPtr_PlayerNameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_InvitePlayerPopup>.NativeClassPtr, nameof (PlayerNameInputField));
      ClanMenu_InvitePlayerPopup.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanMenu_InvitePlayerPopup>.NativeClassPtr, 100665456);
      ClanMenu_InvitePlayerPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanMenu_InvitePlayerPopup>.NativeClassPtr, 100665457);
    }

    public ClanMenu_InvitePlayerPopup(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TMP_InputField PlayerNameInputField
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_InvitePlayerPopup.NativeFieldInfoPtr_PlayerNameInputField));
        return pointer == IntPtr.Zero ? (TMP_InputField) null : new TMP_InputField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_InvitePlayerPopup.NativeFieldInfoPtr_PlayerNameInputField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
