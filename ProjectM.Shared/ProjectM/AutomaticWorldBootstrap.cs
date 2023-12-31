// Decompiled with JetBrains decompiler
// Type: ProjectM.AutomaticWorldBootstrap
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM
{
  public static class AutomaticWorldBootstrap : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720242, XrefRangeEnd = 720246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Initialize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AutomaticWorldBootstrap.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AutomaticWorldBootstrap()
    {
      Il2CppClassPointerStore<AutomaticWorldBootstrap>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AutomaticWorldBootstrap));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutomaticWorldBootstrap>.NativeClassPtr);
      AutomaticWorldBootstrap.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticWorldBootstrap>.NativeClassPtr, 100663663);
    }

    public AutomaticWorldBootstrap(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
