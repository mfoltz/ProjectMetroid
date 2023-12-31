// Decompiled with JetBrains decompiler
// Type: ProjectM.RandomHelper
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class RandomHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SeedCounter;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Random_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSeed_Private_Static_UInt32_0;

    [CallerCount(103)]
    [CachedScanResults(RefRangeStart = 765016, RefRangeEnd = 765119, XrefRangeStart = 765001, XrefRangeEnd = 765016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Unity.Mathematics.Random Create()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomHelper.NativeMethodInfoPtr_Create_Public_Static_Random_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Unity.Mathematics.Random*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765119, XrefRangeEnd = 765124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe uint GetSeed()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomHelper.NativeMethodInfoPtr_GetSeed_Private_Static_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RandomHelper()
    {
      Il2CppClassPointerStore<RandomHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RandomHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomHelper>.NativeClassPtr);
      RandomHelper.NativeFieldInfoPtr__SeedCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomHelper>.NativeClassPtr, nameof (_SeedCounter));
      RandomHelper.NativeMethodInfoPtr_Create_Public_Static_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomHelper>.NativeClassPtr, 100667576);
      RandomHelper.NativeMethodInfoPtr_GetSeed_Private_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomHelper>.NativeClassPtr, 100667577);
    }

    public RandomHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe uint _SeedCounter
    {
      get
      {
        uint seedCounter;
        IL2CPP.il2cpp_field_static_get_value(RandomHelper.NativeFieldInfoPtr__SeedCounter, (void*) &seedCounter);
        return seedCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RandomHelper.NativeFieldInfoPtr__SeedCounter, (void*) &value);
      }
    }
  }
}
