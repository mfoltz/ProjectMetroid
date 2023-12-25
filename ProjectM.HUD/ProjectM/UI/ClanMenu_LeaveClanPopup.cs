// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ClanMenu_LeaveClanPopup
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class ClanMenu_LeaveClanPopup : GenericPopup<string>
  {
    private static readonly IntPtr NativeFieldInfoPtr_ClanNameText;
    private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232457, XrefRangeEnd = 1232463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnShow(string clanName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(clanName);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClanMenu_LeaveClanPopup.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232463, XrefRangeEnd = 1232466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClanMenu_LeaveClanPopup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanMenu_LeaveClanPopup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanMenu_LeaveClanPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClanMenu_LeaveClanPopup()
    {
      Il2CppClassPointerStore<ClanMenu_LeaveClanPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ClanMenu_LeaveClanPopup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanMenu_LeaveClanPopup>.NativeClassPtr);
      ClanMenu_LeaveClanPopup.NativeFieldInfoPtr_ClanNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanMenu_LeaveClanPopup>.NativeClassPtr, nameof (ClanNameText));
      ClanMenu_LeaveClanPopup.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanMenu_LeaveClanPopup>.NativeClassPtr, 100665458);
      ClanMenu_LeaveClanPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanMenu_LeaveClanPopup>.NativeClassPtr, 100665459);
    }

    public ClanMenu_LeaveClanPopup(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText ClanNameText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_LeaveClanPopup.NativeFieldInfoPtr_ClanNameText));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanMenu_LeaveClanPopup.NativeFieldInfoPtr_ClanNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
