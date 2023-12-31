// Decompiled with JetBrains decompiler
// Type: ProjectM.PlacementDestroyData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.CastleBuilding.Placement;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlacementDestroyData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyReason;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsBeingDestroyed_Public_get_Boolean_0;
    [FieldOffset(0)]
    public TileModelDestroyReason DestroyReason;

    public unsafe bool IsBeingDestroyed
    {
      [CallerCount(38), CachedScanResults(RefRangeStart = 723758, RefRangeEnd = 723796, XrefRangeStart = 723758, XrefRangeEnd = 723758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlacementDestroyData.NativeMethodInfoPtr_get_IsBeingDestroyed_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static PlacementDestroyData()
    {
      Il2CppClassPointerStore<PlacementDestroyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PlacementDestroyData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlacementDestroyData>.NativeClassPtr);
      PlacementDestroyData.NativeFieldInfoPtr_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlacementDestroyData>.NativeClassPtr, nameof (DestroyReason));
      PlacementDestroyData.NativeMethodInfoPtr_get_IsBeingDestroyed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlacementDestroyData>.NativeClassPtr, 100663988);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlacementDestroyData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
