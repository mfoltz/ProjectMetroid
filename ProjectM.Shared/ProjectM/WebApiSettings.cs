// Decompiled with JetBrains decompiler
// Type: ProjectM.WebApiSettings
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
  public class WebApiSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_BindAddress;
    private static readonly System.IntPtr NativeFieldInfoPtr_BindPort;
    private static readonly System.IntPtr NativeFieldInfoPtr_BasePath;
    private static readonly System.IntPtr NativeFieldInfoPtr_AccessList;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrometheusDelay;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 749411, RefRangeEnd = 749413, XrefRangeStart = 749401, XrefRangeEnd = 749411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WebApiSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebApiSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WebApiSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WebApiSettings()
    {
      Il2CppClassPointerStore<WebApiSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WebApiSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebApiSettings>.NativeClassPtr);
      WebApiSettings.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebApiSettings>.NativeClassPtr, nameof (Enabled));
      WebApiSettings.NativeFieldInfoPtr_BindAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebApiSettings>.NativeClassPtr, nameof (BindAddress));
      WebApiSettings.NativeFieldInfoPtr_BindPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebApiSettings>.NativeClassPtr, nameof (BindPort));
      WebApiSettings.NativeFieldInfoPtr_BasePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebApiSettings>.NativeClassPtr, nameof (BasePath));
      WebApiSettings.NativeFieldInfoPtr_AccessList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebApiSettings>.NativeClassPtr, nameof (AccessList));
      WebApiSettings.NativeFieldInfoPtr_PrometheusDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebApiSettings>.NativeClassPtr, nameof (PrometheusDelay));
      WebApiSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebApiSettings>.NativeClassPtr, 100666006);
    }

    public WebApiSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool Enabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_Enabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_Enabled)) = value;
      }
    }

    public unsafe string BindAddress
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_BindAddress)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_BindAddress), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int BindPort
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_BindPort));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_BindPort)) = value;
      }
    }

    public unsafe string BasePath
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_BasePath)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_BasePath), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string AccessList
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_AccessList)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_AccessList), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int PrometheusDelay
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_PrometheusDelay));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WebApiSettings.NativeFieldInfoPtr_PrometheusDelay)) = value;
      }
    }
  }
}
