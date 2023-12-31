// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ClientSettings : SettingsBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultPath;
    private static readonly IntPtr NativeFieldInfoPtr_LocalPath;
    private static readonly IntPtr NativeFieldInfoPtr_General;
    private static readonly IntPtr NativeFieldInfoPtr_Sound;
    private static readonly IntPtr NativeFieldInfoPtr_Interface;
    private static readonly IntPtr NativeFieldInfoPtr_Controls;
    private static readonly IntPtr NativeFieldInfoPtr_GameClient;
    private static readonly IntPtr NativeFieldInfoPtr_HostSettings;
    private static readonly IntPtr NativeFieldInfoPtr_GraphicSettings;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 748653, RefRangeEnd = 748655, XrefRangeStart = 748613, XrefRangeEnd = 748653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientSettings()
    {
      Il2CppClassPointerStore<ClientSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ClientSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr);
      ClientSettings.NativeFieldInfoPtr_DefaultPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr, nameof (DefaultPath));
      ClientSettings.NativeFieldInfoPtr_LocalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr, nameof (LocalPath));
      ClientSettings.NativeFieldInfoPtr_General = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr, nameof (General));
      ClientSettings.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr, nameof (Sound));
      ClientSettings.NativeFieldInfoPtr_Interface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr, nameof (Interface));
      ClientSettings.NativeFieldInfoPtr_Controls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr, nameof (Controls));
      ClientSettings.NativeFieldInfoPtr_GameClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr, nameof (GameClient));
      ClientSettings.NativeFieldInfoPtr_HostSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr, nameof (HostSettings));
      ClientSettings.NativeFieldInfoPtr_GraphicSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr, nameof (GraphicSettings));
      ClientSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientSettings>.NativeClassPtr, 100665913);
    }

    public ClientSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string DefaultPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ClientSettings.NativeFieldInfoPtr_DefaultPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientSettings.NativeFieldInfoPtr_DefaultPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string LocalPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ClientSettings.NativeFieldInfoPtr_LocalPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClientSettings.NativeFieldInfoPtr_LocalPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe GeneralSettings General
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_General));
        return pointer == IntPtr.Zero ? (GeneralSettings) null : new GeneralSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_General), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SoundSettings Sound
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_Sound));
        return pointer == IntPtr.Zero ? (SoundSettings) null : new SoundSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InterfaceSettings Interface
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_Interface));
        return pointer == IntPtr.Zero ? (InterfaceSettings) null : new InterfaceSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_Interface), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ControlsSettings Controls
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_Controls));
        return pointer == IntPtr.Zero ? (ControlsSettings) null : new ControlsSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_Controls), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameClientSettings GameClient
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_GameClient));
        return pointer == IntPtr.Zero ? (GameClientSettings) null : new GameClientSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_GameClient), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClientHostSettings HostSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_HostSettings));
        return pointer == IntPtr.Zero ? (ClientHostSettings) null : new ClientHostSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_HostSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GraphicsSettings GraphicSettings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_GraphicSettings));
        return pointer == IntPtr.Zero ? (GraphicsSettings) null : new GraphicsSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientSettings.NativeFieldInfoPtr_GraphicSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
