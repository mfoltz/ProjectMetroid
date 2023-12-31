// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldTypeExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class WorldTypeExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsServer_Public_Static_Boolean_WorldType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsClient_Public_Static_Boolean_WorldType_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 722421, RefRangeEnd = 722422, XrefRangeStart = 722421, XrefRangeEnd = 722421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsServer(this WorldType worldType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldTypeExtensions.NativeMethodInfoPtr_IsServer_Public_Static_Boolean_WorldType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe bool IsClient(this WorldType worldType)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &worldType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldTypeExtensions.NativeMethodInfoPtr_IsClient_Public_Static_Boolean_WorldType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WorldTypeExtensions()
    {
      Il2CppClassPointerStore<WorldTypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WorldTypeExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldTypeExtensions>.NativeClassPtr);
      WorldTypeExtensions.NativeMethodInfoPtr_IsServer_Public_Static_Boolean_WorldType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeExtensions>.NativeClassPtr, 100663796);
      WorldTypeExtensions.NativeMethodInfoPtr_IsClient_Public_Static_Boolean_WorldType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeExtensions>.NativeClassPtr, 100663797);
    }

    public WorldTypeExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
