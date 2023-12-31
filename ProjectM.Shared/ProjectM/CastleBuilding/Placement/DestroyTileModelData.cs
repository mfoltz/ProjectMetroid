// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.DestroyTileModelData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DestroyTileModelData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityToDestroy;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShouldDismantle;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityCausedDestruction;
    [FieldOffset(0)]
    public Entity EntityToDestroy;
    [FieldOffset(8)]
    public TileModelDestroyReason DestroyReason;
    [FieldOffset(12)]
    public bool ShouldDismantle;
    [FieldOffset(16)]
    public Nullable_Unboxed<PlacementEntityId> EntityCausedDestruction;

    static DestroyTileModelData()
    {
      Il2CppClassPointerStore<DestroyTileModelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding.Placement", nameof (DestroyTileModelData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyTileModelData>.NativeClassPtr);
      DestroyTileModelData.NativeFieldInfoPtr_EntityToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyTileModelData>.NativeClassPtr, nameof (EntityToDestroy));
      DestroyTileModelData.NativeFieldInfoPtr_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyTileModelData>.NativeClassPtr, nameof (DestroyReason));
      DestroyTileModelData.NativeFieldInfoPtr_ShouldDismantle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyTileModelData>.NativeClassPtr, nameof (ShouldDismantle));
      DestroyTileModelData.NativeFieldInfoPtr_EntityCausedDestruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyTileModelData>.NativeClassPtr, nameof (EntityCausedDestruction));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyTileModelData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
