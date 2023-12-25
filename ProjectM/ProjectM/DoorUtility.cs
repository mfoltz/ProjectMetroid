// Decompiled with JetBrains decompiler
// Type: ProjectM.DoorUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  public static class DoorUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldOpenLeft_Public_Static_Boolean_float3_float3_TileRotation_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1012075, RefRangeEnd = 1012077, XrefRangeStart = 1012074, XrefRangeEnd = 1012075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ShouldOpenLeft(
      float3 interactFromPosition,
      float3 doorPosition,
      TileRotation doorRotation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &interactFromPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &doorPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &doorRotation;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DoorUtility.NativeMethodInfoPtr_ShouldOpenLeft_Public_Static_Boolean_float3_float3_TileRotation_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DoorUtility()
    {
      Il2CppClassPointerStore<DoorUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DoorUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorUtility>.NativeClassPtr);
      DoorUtility.NativeMethodInfoPtr_ShouldOpenLeft_Public_Static_Boolean_float3_float3_TileRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorUtility>.NativeClassPtr, 100678796);
    }

    public DoorUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
