// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientHostSettings
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
  public class ClientHostSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Port;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryPort;
    private static readonly System.IntPtr NativeFieldInfoPtr_Secure;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748713, XrefRangeEnd = 748714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientHostSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientHostSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientHostSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientHostSettings()
    {
      Il2CppClassPointerStore<ClientHostSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ClientHostSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientHostSettings>.NativeClassPtr);
      ClientHostSettings.NativeFieldInfoPtr_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientHostSettings>.NativeClassPtr, nameof (Port));
      ClientHostSettings.NativeFieldInfoPtr_QueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientHostSettings>.NativeClassPtr, nameof (QueryPort));
      ClientHostSettings.NativeFieldInfoPtr_Secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientHostSettings>.NativeClassPtr, nameof (Secure));
      ClientHostSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientHostSettings>.NativeClassPtr, 100665922);
    }

    public ClientHostSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int Port
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientHostSettings.NativeFieldInfoPtr_Port));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientHostSettings.NativeFieldInfoPtr_Port)) = value;
      }
    }

    public unsafe int QueryPort
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientHostSettings.NativeFieldInfoPtr_QueryPort));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientHostSettings.NativeFieldInfoPtr_QueryPort)) = value;
      }
    }

    public unsafe bool Secure
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientHostSettings.NativeFieldInfoPtr_Secure));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientHostSettings.NativeFieldInfoPtr_Secure)) = value;
      }
    }
  }
}
