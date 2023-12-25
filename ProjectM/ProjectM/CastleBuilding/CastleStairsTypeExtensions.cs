// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleStairsTypeExtensions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public static class CastleStairsTypeExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsTopFloor_Public_Static_Boolean_CastleStairsType_0;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1128970, RefRangeEnd = 1128976, XrefRangeStart = 1128970, XrefRangeEnd = 1128970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsTopFloor(this CastleStairsType castleStairs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &castleStairs;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleStairsTypeExtensions.NativeMethodInfoPtr_IsTopFloor_Public_Static_Boolean_CastleStairsType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CastleStairsTypeExtensions()
    {
      Il2CppClassPointerStore<CastleStairsTypeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleStairsTypeExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleStairsTypeExtensions>.NativeClassPtr);
      CastleStairsTypeExtensions.NativeMethodInfoPtr_IsTopFloor_Public_Static_Boolean_CastleStairsType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleStairsTypeExtensions>.NativeClassPtr, 100689710);
    }

    public CastleStairsTypeExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
