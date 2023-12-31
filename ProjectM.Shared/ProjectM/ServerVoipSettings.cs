// Decompiled with JetBrains decompiler
// Type: ProjectM.ServerVoipSettings
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
  public class ServerVoipSettings : SettingsBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultPath;
    private static readonly IntPtr NativeFieldInfoPtr_LocalPath;
    private static readonly IntPtr NativeFieldInfoPtr_VOIPEnabled;
    private static readonly IntPtr NativeFieldInfoPtr_VOIPIssuer;
    private static readonly IntPtr NativeFieldInfoPtr_VOIPSecret;
    private static readonly IntPtr NativeFieldInfoPtr_VOIPVivoxDomain;
    private static readonly IntPtr NativeFieldInfoPtr_VOIPAPIEndpoint;
    private static readonly IntPtr NativeFieldInfoPtr_VOIPConversationalDistance;
    private static readonly IntPtr NativeFieldInfoPtr_VOIPAudibleDistance;
    private static readonly IntPtr NativeFieldInfoPtr_VOIPFadeIntensity;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749416, XrefRangeEnd = 749430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerVoipSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerVoipSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServerVoipSettings()
    {
      Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServerVoipSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr);
      ServerVoipSettings.NativeFieldInfoPtr_DefaultPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr, nameof (DefaultPath));
      ServerVoipSettings.NativeFieldInfoPtr_LocalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr, nameof (LocalPath));
      ServerVoipSettings.NativeFieldInfoPtr_VOIPEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr, nameof (VOIPEnabled));
      ServerVoipSettings.NativeFieldInfoPtr_VOIPIssuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr, nameof (VOIPIssuer));
      ServerVoipSettings.NativeFieldInfoPtr_VOIPSecret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr, nameof (VOIPSecret));
      ServerVoipSettings.NativeFieldInfoPtr_VOIPVivoxDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr, nameof (VOIPVivoxDomain));
      ServerVoipSettings.NativeFieldInfoPtr_VOIPAPIEndpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr, nameof (VOIPAPIEndpoint));
      ServerVoipSettings.NativeFieldInfoPtr_VOIPConversationalDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr, nameof (VOIPConversationalDistance));
      ServerVoipSettings.NativeFieldInfoPtr_VOIPAudibleDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr, nameof (VOIPAudibleDistance));
      ServerVoipSettings.NativeFieldInfoPtr_VOIPFadeIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr, nameof (VOIPFadeIntensity));
      ServerVoipSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerVoipSettings>.NativeClassPtr, 100666008);
    }

    public ServerVoipSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string DefaultPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ServerVoipSettings.NativeFieldInfoPtr_DefaultPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerVoipSettings.NativeFieldInfoPtr_DefaultPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string LocalPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ServerVoipSettings.NativeFieldInfoPtr_LocalPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServerVoipSettings.NativeFieldInfoPtr_LocalPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool VOIPEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPEnabled)) = value;
      }
    }

    public unsafe string VOIPIssuer
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPIssuer)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPIssuer), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string VOIPSecret
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPSecret)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPSecret), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string VOIPVivoxDomain
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPVivoxDomain)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPVivoxDomain), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string VOIPAPIEndpoint
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPAPIEndpoint)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPAPIEndpoint), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int VOIPConversationalDistance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPConversationalDistance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPConversationalDistance)) = value;
      }
    }

    public unsafe int VOIPAudibleDistance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPAudibleDistance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPAudibleDistance)) = value;
      }
    }

    public unsafe float VOIPFadeIntensity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPFadeIntensity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerVoipSettings.NativeFieldInfoPtr_VOIPFadeIntensity)) = value;
      }
    }
  }
}
