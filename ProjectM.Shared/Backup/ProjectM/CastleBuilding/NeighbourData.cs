// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.NeighbourData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NeighbourData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_MatchingFilter;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_NeighbourFilter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public NeighbourFilter MatchingFilter;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 794226, RefRangeEnd = 794227, XrefRangeStart = 794226, XrefRangeEnd = 794226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NeighbourData(Entity entity, NeighbourFilter matchingFilter)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &matchingFilter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NeighbourData.NativeMethodInfoPtr__ctor_Public_Void_Entity_NeighbourFilter_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794227, XrefRangeEnd = 794236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NeighbourData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static NeighbourData()
    {
      Il2CppClassPointerStore<NeighbourData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (NeighbourData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NeighbourData>.NativeClassPtr);
      NeighbourData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeighbourData>.NativeClassPtr, nameof (Entity));
      NeighbourData.NativeFieldInfoPtr_MatchingFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeighbourData>.NativeClassPtr, nameof (MatchingFilter));
      NeighbourData.NativeMethodInfoPtr__ctor_Public_Void_Entity_NeighbourFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeighbourData>.NativeClassPtr, 100670027);
      NeighbourData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeighbourData>.NativeClassPtr, 100670028);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NeighbourData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
