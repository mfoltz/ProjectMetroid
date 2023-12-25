// Decompiled with JetBrains decompiler
// Type: ProjectM.NetworkEventConvertOnDemand
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class NetworkEventConvertOnDemand : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertNetworkEventReferencesOnDemand_Public_Static_Void_EntityManager_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ConvertNetworkEventReferencesOnDemand(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkEventConvertOnDemand.NativeMethodInfoPtr_ConvertNetworkEventReferencesOnDemand_Public_Static_Void_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkEventConvertOnDemand()
    {
      Il2CppClassPointerStore<NetworkEventConvertOnDemand>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (NetworkEventConvertOnDemand));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkEventConvertOnDemand>.NativeClassPtr);
      NetworkEventConvertOnDemand.NativeMethodInfoPtr_ConvertNetworkEventReferencesOnDemand_Public_Static_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEventConvertOnDemand>.NativeClassPtr, 100675630);
    }

    public NetworkEventConvertOnDemand(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
