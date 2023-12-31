// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitCompositionActiveUnit
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitCompositionActiveUnit
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_RespawnTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_FormationOffsetIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_FollowedModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_FollowModeModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Despawning;
    [FieldOffset(0)]
    public Entity UnitEntity;
    [FieldOffset(8)]
    public Entity UnitPrefab;
    [FieldOffset(16)]
    public Nullable_Unboxed<double> RespawnTime;
    [FieldOffset(32)]
    public int FormationOffsetIndex;
    [FieldOffset(36)]
    public ModificationId FollowedModId;
    [FieldOffset(40)]
    public ModificationId FollowModeModId;
    [FieldOffset(44)]
    public bool Despawning;

    static UnitCompositionActiveUnit()
    {
      Il2CppClassPointerStore<UnitCompositionActiveUnit>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitCompositionActiveUnit));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionActiveUnit>.NativeClassPtr);
      UnitCompositionActiveUnit.NativeFieldInfoPtr_UnitEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionActiveUnit>.NativeClassPtr, nameof (UnitEntity));
      UnitCompositionActiveUnit.NativeFieldInfoPtr_UnitPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionActiveUnit>.NativeClassPtr, nameof (UnitPrefab));
      UnitCompositionActiveUnit.NativeFieldInfoPtr_RespawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionActiveUnit>.NativeClassPtr, nameof (RespawnTime));
      UnitCompositionActiveUnit.NativeFieldInfoPtr_FormationOffsetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionActiveUnit>.NativeClassPtr, nameof (FormationOffsetIndex));
      UnitCompositionActiveUnit.NativeFieldInfoPtr_FollowedModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionActiveUnit>.NativeClassPtr, nameof (FollowedModId));
      UnitCompositionActiveUnit.NativeFieldInfoPtr_FollowModeModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionActiveUnit>.NativeClassPtr, nameof (FollowModeModId));
      UnitCompositionActiveUnit.NativeFieldInfoPtr_Despawning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionActiveUnit>.NativeClassPtr, nameof (Despawning));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionActiveUnit>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
