// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.BlockedTileModelData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BlockedTileModelData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExistingEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewRotation;
    [FieldOffset(0)]
    public Entity Prefab;
    [FieldOffset(8)]
    public Entity ExistingEntity;
    [FieldOffset(16)]
    public Translation OldTranslation;
    [FieldOffset(28)]
    public Rotation OldRotation;
    [FieldOffset(44)]
    public Translation NewTranslation;
    [FieldOffset(56)]
    public Rotation NewRotation;

    static BlockedTileModelData()
    {
      Il2CppClassPointerStore<BlockedTileModelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding.Placement", nameof (BlockedTileModelData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockedTileModelData>.NativeClassPtr);
      BlockedTileModelData.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedTileModelData>.NativeClassPtr, nameof (Prefab));
      BlockedTileModelData.NativeFieldInfoPtr_ExistingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedTileModelData>.NativeClassPtr, nameof (ExistingEntity));
      BlockedTileModelData.NativeFieldInfoPtr_OldTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedTileModelData>.NativeClassPtr, nameof (OldTranslation));
      BlockedTileModelData.NativeFieldInfoPtr_OldRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedTileModelData>.NativeClassPtr, nameof (OldRotation));
      BlockedTileModelData.NativeFieldInfoPtr_NewTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedTileModelData>.NativeClassPtr, nameof (NewTranslation));
      BlockedTileModelData.NativeFieldInfoPtr_NewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockedTileModelData>.NativeClassPtr, nameof (NewRotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlockedTileModelData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
