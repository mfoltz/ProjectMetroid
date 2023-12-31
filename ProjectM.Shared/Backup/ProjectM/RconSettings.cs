// Decompiled with JetBrains decompiler
// Type: ProjectM.RconSettings
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
  public class RconSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_BindAddress;
    private static readonly System.IntPtr NativeFieldInfoPtr_Port;
    private static readonly System.IntPtr NativeFieldInfoPtr_Password;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeoutSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPasswordTries;
    private static readonly System.IntPtr NativeFieldInfoPtr_BanMinutes;
    private static readonly System.IntPtr NativeFieldInfoPtr_SendAuthImmediately;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxConnectionsPerIp;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxConnections;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 749414, RefRangeEnd = 749416, XrefRangeStart = 749413, XrefRangeEnd = 749414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RconSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RconSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RconSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RconSettings()
    {
      Il2CppClassPointerStore<RconSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RconSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RconSettings>.NativeClassPtr);
      RconSettings.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconSettings>.NativeClassPtr, nameof (Enabled));
      RconSettings.NativeFieldInfoPtr_BindAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconSettings>.NativeClassPtr, nameof (BindAddress));
      RconSettings.NativeFieldInfoPtr_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconSettings>.NativeClassPtr, nameof (Port));
      RconSettings.NativeFieldInfoPtr_Password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconSettings>.NativeClassPtr, nameof (Password));
      RconSettings.NativeFieldInfoPtr_TimeoutSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconSettings>.NativeClassPtr, nameof (TimeoutSeconds));
      RconSettings.NativeFieldInfoPtr_MaxPasswordTries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconSettings>.NativeClassPtr, nameof (MaxPasswordTries));
      RconSettings.NativeFieldInfoPtr_BanMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconSettings>.NativeClassPtr, nameof (BanMinutes));
      RconSettings.NativeFieldInfoPtr_SendAuthImmediately = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconSettings>.NativeClassPtr, nameof (SendAuthImmediately));
      RconSettings.NativeFieldInfoPtr_MaxConnectionsPerIp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconSettings>.NativeClassPtr, nameof (MaxConnectionsPerIp));
      RconSettings.NativeFieldInfoPtr_MaxConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RconSettings>.NativeClassPtr, nameof (MaxConnections));
      RconSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RconSettings>.NativeClassPtr, 100666007);
    }

    public RconSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool Enabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_Enabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_Enabled)) = value;
      }
    }

    public unsafe string BindAddress
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_BindAddress)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_BindAddress), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int Port
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_Port));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_Port)) = value;
      }
    }

    public unsafe string Password
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_Password)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_Password), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int TimeoutSeconds
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_TimeoutSeconds));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_TimeoutSeconds)) = value;
      }
    }

    public unsafe int MaxPasswordTries
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_MaxPasswordTries));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_MaxPasswordTries)) = value;
      }
    }

    public unsafe int BanMinutes
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_BanMinutes));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_BanMinutes)) = value;
      }
    }

    public unsafe bool SendAuthImmediately
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_SendAuthImmediately));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_SendAuthImmediately)) = value;
      }
    }

    public unsafe int MaxConnectionsPerIp
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_MaxConnectionsPerIp));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_MaxConnectionsPerIp)) = value;
      }
    }

    public unsafe int MaxConnections
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_MaxConnections));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RconSettings.NativeFieldInfoPtr_MaxConnections)) = value;
      }
    }
  }
}
