// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.InterCardinalDirectionExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public static class InterCardinalDirectionExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBlockDirection_Public_Static_int3_InterCardinalDirection_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794207, RefRangeEnd = 794209, XrefRangeStart = 794205, XrefRangeEnd = 794207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int3 GetBlockDirection(this InterCardinalDirection interCardinalDirection)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &interCardinalDirection;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InterCardinalDirectionExtensions.NativeMethodInfoPtr_GetBlockDirection_Public_Static_int3_InterCardinalDirection_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int3*) IL2CPP.il2cpp_object_unbox(num);
    }

    static InterCardinalDirectionExtensions()
    {
      Il2CppClassPointerStore<InterCardinalDirectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (InterCardinalDirectionExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterCardinalDirectionExtensions>.NativeClassPtr);
      InterCardinalDirectionExtensions.NativeMethodInfoPtr_GetBlockDirection_Public_Static_int3_InterCardinalDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterCardinalDirectionExtensions>.NativeClassPtr, 100670020);
    }

    public InterCardinalDirectionExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
