// Decompiled with JetBrains decompiler
// Type: ProjectM.GeneralSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class GeneralSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlatformNotificationPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewsURL;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerInfoURL;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerPartnerURL;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServerInstructionsURL;
    private static readonly System.IntPtr NativeFieldInfoPtr_BranchOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnableConsole;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConfineCursorToWindow;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 748674, RefRangeEnd = 748675, XrefRangeStart = 748655, XrefRangeEnd = 748674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GeneralSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GeneralSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GeneralSettings()
    {
      Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GeneralSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr);
      GeneralSettings.NativeFieldInfoPtr_ServerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr, nameof (ServerPath));
      GeneralSettings.NativeFieldInfoPtr_PlatformNotificationPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr, nameof (PlatformNotificationPosition));
      GeneralSettings.NativeFieldInfoPtr_NewsURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr, nameof (NewsURL));
      GeneralSettings.NativeFieldInfoPtr_ServerInfoURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr, nameof (ServerInfoURL));
      GeneralSettings.NativeFieldInfoPtr_ServerPartnerURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr, nameof (ServerPartnerURL));
      GeneralSettings.NativeFieldInfoPtr_ServerInstructionsURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr, nameof (ServerInstructionsURL));
      GeneralSettings.NativeFieldInfoPtr_BranchOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr, nameof (BranchOverride));
      GeneralSettings.NativeFieldInfoPtr_EnableConsole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr, nameof (EnableConsole));
      GeneralSettings.NativeFieldInfoPtr_ConfineCursorToWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr, nameof (ConfineCursorToWindow));
      GeneralSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralSettings>.NativeClassPtr, 100665915);
    }

    public GeneralSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string ServerPath
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_ServerPath)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_ServerPath), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe NotificationPosition PlatformNotificationPosition
    {
      get
      {
        return *(NotificationPosition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_PlatformNotificationPosition));
      }
      [param: In] set
      {
        *(NotificationPosition*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_PlatformNotificationPosition)) = value;
      }
    }

    public unsafe string NewsURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_NewsURL)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_NewsURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ServerInfoURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_ServerInfoURL)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_ServerInfoURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ServerPartnerURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_ServerPartnerURL)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_ServerPartnerURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ServerInstructionsURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_ServerInstructionsURL)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_ServerInstructionsURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string BranchOverride
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_BranchOverride)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_BranchOverride), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool EnableConsole
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_EnableConsole));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_EnableConsole)) = value;
      }
    }

    public unsafe bool ConfineCursorToWindow
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_ConfineCursorToWindow));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneralSettings.NativeFieldInfoPtr_ConfineCursorToWindow)) = value;
      }
    }
  }
}
