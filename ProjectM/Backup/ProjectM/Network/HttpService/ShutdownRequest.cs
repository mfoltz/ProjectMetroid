// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.HttpService.ShutdownRequest
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network.HttpService
{
  public class ShutdownRequest : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_shutdown;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShutdownRequest()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShutdownRequest>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShutdownRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShutdownRequest()
    {
      Il2CppClassPointerStore<ShutdownRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network.HttpService", nameof (ShutdownRequest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShutdownRequest>.NativeClassPtr);
      ShutdownRequest.NativeFieldInfoPtr_shutdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShutdownRequest>.NativeClassPtr, nameof (shutdown));
      ShutdownRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShutdownRequest>.NativeClassPtr, 100691899);
    }

    public ShutdownRequest(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool shutdown
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShutdownRequest.NativeFieldInfoPtr_shutdown));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShutdownRequest.NativeFieldInfoPtr_shutdown)) = value;
      }
    }
  }
}
