﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.TileModelBlockReasonData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TileModelBlockReasonData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockReason;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockReasonEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockRequirements;
    [FieldOffset(0)]
    public BlockReason BlockReason;
    [FieldOffset(4)]
    public Nullable_Unboxed<Entity> BlockReasonEntity;
    [FieldOffset(16)]
    public Nullable_Unboxed<PlacementTypeData> BlockRequirements;

    static TileModelBlockReasonData()
    {
      Il2CppClassPointerStore<TileModelBlockReasonData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding.Placement", nameof (TileModelBlockReasonData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelBlockReasonData>.NativeClassPtr);
      TileModelBlockReasonData.NativeFieldInfoPtr_BlockReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelBlockReasonData>.NativeClassPtr, nameof (BlockReason));
      TileModelBlockReasonData.NativeFieldInfoPtr_BlockReasonEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelBlockReasonData>.NativeClassPtr, nameof (BlockReasonEntity));
      TileModelBlockReasonData.NativeFieldInfoPtr_BlockRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelBlockReasonData>.NativeClassPtr, nameof (BlockRequirements));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileModelBlockReasonData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
