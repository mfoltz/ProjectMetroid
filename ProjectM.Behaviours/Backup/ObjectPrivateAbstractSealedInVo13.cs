// Decompiled with JetBrains decompiler
// Type: ObjectPrivateAbstractSealedInVo13
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
[ObfuscatedName("$BurstDirectCallInitializer")]
public static class ObjectPrivateAbstractSealedInVo13 : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1347928, XrefRangeEnd = 1348061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Initialize()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ObjectPrivateAbstractSealedInVo13.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ObjectPrivateAbstractSealedInVo13()
  {
    Il2CppClassPointerStore<ObjectPrivateAbstractSealedInVo13>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "", "$BurstDirectCallInitializer");
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPrivateAbstractSealedInVo13>.NativeClassPtr);
    ObjectPrivateAbstractSealedInVo13.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPrivateAbstractSealedInVo13>.NativeClassPtr, 100665699);
  }

  public ObjectPrivateAbstractSealedInVo13(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
