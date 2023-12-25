// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VOIPMenu
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
  public class VOIPMenu : HUDMenu
  {
    private static readonly IntPtr NativeFieldInfoPtr_ConnectButton;
    private static readonly IntPtr NativeFieldInfoPtr_DisconnectButton;
    private static readonly IntPtr NativeFieldInfoPtr_Status;
    private static readonly IntPtr NativeFieldInfoPtr_Coordinates;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VOIPMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VOIPMenu>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VOIPMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VOIPMenu()
    {
      Il2CppClassPointerStore<VOIPMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VOIPMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VOIPMenu>.NativeClassPtr);
      VOIPMenu.NativeFieldInfoPtr_ConnectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenu>.NativeClassPtr, nameof (ConnectButton));
      VOIPMenu.NativeFieldInfoPtr_DisconnectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenu>.NativeClassPtr, nameof (DisconnectButton));
      VOIPMenu.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenu>.NativeClassPtr, nameof (Status));
      VOIPMenu.NativeFieldInfoPtr_Coordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VOIPMenu>.NativeClassPtr, nameof (Coordinates));
      VOIPMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VOIPMenu>.NativeClassPtr, 100669665);
    }

    public VOIPMenu(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SimpleStunButton ConnectButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenu.NativeFieldInfoPtr_ConnectButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenu.NativeFieldInfoPtr_ConnectButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton DisconnectButton
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenu.NativeFieldInfoPtr_DisconnectButton));
        return pointer == IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenu.NativeFieldInfoPtr_DisconnectButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Status
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenu.NativeFieldInfoPtr_Status));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenu.NativeFieldInfoPtr_Status), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText Coordinates
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenu.NativeFieldInfoPtr_Coordinates));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VOIPMenu.NativeFieldInfoPtr_Coordinates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
