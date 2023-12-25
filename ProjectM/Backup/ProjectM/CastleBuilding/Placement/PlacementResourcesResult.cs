// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.PlacementResourcesResult
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlacementResourcesResult
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceRequirements;
    private static readonly System.IntPtr NativeFieldInfoPtr_DismantleResources;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public NativeHashMap<PrefabGUID, int> ResourceRequirements;
    [FieldOffset(16)]
    public NativeHashMap<PrefabGUID, int> DismantleResources;

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 1131495, RefRangeEnd = 1131504, XrefRangeStart = 1131485, XrefRangeEnd = 1131495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PlacementResourcesResult.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlacementResourcesResult()
    {
      Il2CppClassPointerStore<PlacementResourcesResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding.Placement", nameof (PlacementResourcesResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacementResourcesResult>.NativeClassPtr);
      PlacementResourcesResult.NativeFieldInfoPtr_ResourceRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResourcesResult>.NativeClassPtr, nameof (ResourceRequirements));
      PlacementResourcesResult.NativeFieldInfoPtr_DismantleResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementResourcesResult>.NativeClassPtr, nameof (DismantleResources));
      PlacementResourcesResult.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementResourcesResult>.NativeClassPtr, 100689826);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlacementResourcesResult>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
