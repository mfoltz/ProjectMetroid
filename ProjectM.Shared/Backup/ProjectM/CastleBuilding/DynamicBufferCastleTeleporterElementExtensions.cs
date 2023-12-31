// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.DynamicBufferCastleTeleporterElementExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public static class DynamicBufferCastleTeleporterElementExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNumberOfTeleportersInGroup_Public_Static_Int32_DynamicBuffer_1_CastleTeleporterElement_Byte_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 794361, RefRangeEnd = 794363, XrefRangeStart = 794344, XrefRangeEnd = 794361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetNumberOfTeleportersInGroup(
      this DynamicBuffer<CastleTeleporterElement> teleporterElements,
      byte group)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &teleporterElements;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &group;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicBufferCastleTeleporterElementExtensions.NativeMethodInfoPtr_GetNumberOfTeleportersInGroup_Public_Static_Int32_DynamicBuffer_1_CastleTeleporterElement_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DynamicBufferCastleTeleporterElementExtensions()
    {
      Il2CppClassPointerStore<DynamicBufferCastleTeleporterElementExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (DynamicBufferCastleTeleporterElementExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicBufferCastleTeleporterElementExtensions>.NativeClassPtr);
      DynamicBufferCastleTeleporterElementExtensions.NativeMethodInfoPtr_GetNumberOfTeleportersInGroup_Public_Static_Int32_DynamicBuffer_1_CastleTeleporterElement_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBufferCastleTeleporterElementExtensions>.NativeClassPtr, 100670040);
    }

    public DynamicBufferCastleTeleporterElementExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
