// Decompiled with JetBrains decompiler
// Type: ObjectPrivateAbstractSealedInVo10
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
[ObfuscatedName("$BurstDirectCallInitializer")]
public static class ObjectPrivateAbstractSealedInVo10 : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292225, XrefRangeEnd = 1292301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Initialize()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ObjectPrivateAbstractSealedInVo10.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ObjectPrivateAbstractSealedInVo10()
  {
    Il2CppClassPointerStore<ObjectPrivateAbstractSealedInVo10>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", "$BurstDirectCallInitializer");
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPrivateAbstractSealedInVo10>.NativeClassPtr);
    ObjectPrivateAbstractSealedInVo10.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPrivateAbstractSealedInVo10>.NativeClassPtr, 100670007);
  }

  public ObjectPrivateAbstractSealedInVo10(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
