// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBlockCollection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleBlockCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Floors;
    private static readonly System.IntPtr NativeFieldInfoPtr_Walls;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pillars;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CastleFloorBlockCollection_CastleWallBlockCollection_CastlePillarBlockCollection_0;
    [FieldOffset(0)]
    public readonly CastleFloorBlockCollection Floors;
    [FieldOffset(16)]
    public readonly CastleWallBlockCollection Walls;
    [FieldOffset(32)]
    public readonly CastlePillarBlockCollection Pillars;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 260668, RefRangeEnd = 260671, XrefRangeStart = 260668, XrefRangeEnd = 260671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBlockCollection(
      CastleFloorBlockCollection floors,
      CastleWallBlockCollection walls,
      CastlePillarBlockCollection pillars)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &floors;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &walls;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pillars;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBlockCollection.NativeMethodInfoPtr__ctor_Internal_Void_CastleFloorBlockCollection_CastleWallBlockCollection_CastlePillarBlockCollection_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleBlockCollection()
    {
      Il2CppClassPointerStore<CastleBlockCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleBlockCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBlockCollection>.NativeClassPtr);
      CastleBlockCollection.NativeFieldInfoPtr_Floors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockCollection>.NativeClassPtr, nameof (Floors));
      CastleBlockCollection.NativeFieldInfoPtr_Walls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockCollection>.NativeClassPtr, nameof (Walls));
      CastleBlockCollection.NativeFieldInfoPtr_Pillars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBlockCollection>.NativeClassPtr, nameof (Pillars));
      CastleBlockCollection.NativeMethodInfoPtr__ctor_Internal_Void_CastleFloorBlockCollection_CastleWallBlockCollection_CastlePillarBlockCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBlockCollection>.NativeClassPtr, 100689499);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBlockCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
