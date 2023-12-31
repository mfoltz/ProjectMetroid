// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilitySpawnPrefabOnCast
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilitySpawnPrefabOnCast
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoverDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoverCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_HoverMaxDistance;
    [FieldOffset(0)]
    public PrefabGUID SpawnPrefab;
    [FieldOffset(4)]
    public AbilitySpawnTarget Target;
    [FieldOffset(8)]
    public Entity TargetEntity;
    [FieldOffset(16)]
    public float HoverDistance;
    [FieldOffset(24)]
    public BlobAssetReference<ConditionBlob> HoverCondition;
    [FieldOffset(32)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(40)]
    public float HoverMaxDistance;

    static AbilitySpawnPrefabOnCast()
    {
      Il2CppClassPointerStore<AbilitySpawnPrefabOnCast>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilitySpawnPrefabOnCast));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilitySpawnPrefabOnCast>.NativeClassPtr);
      AbilitySpawnPrefabOnCast.NativeFieldInfoPtr_SpawnPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnCast>.NativeClassPtr, nameof (SpawnPrefab));
      AbilitySpawnPrefabOnCast.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnCast>.NativeClassPtr, nameof (Target));
      AbilitySpawnPrefabOnCast.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnCast>.NativeClassPtr, nameof (TargetEntity));
      AbilitySpawnPrefabOnCast.NativeFieldInfoPtr_HoverDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnCast>.NativeClassPtr, nameof (HoverDistance));
      AbilitySpawnPrefabOnCast.NativeFieldInfoPtr_HoverCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnCast>.NativeClassPtr, nameof (HoverCondition));
      AbilitySpawnPrefabOnCast.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnCast>.NativeClassPtr, nameof (Condition));
      AbilitySpawnPrefabOnCast.NativeFieldInfoPtr_HoverMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnCast>.NativeClassPtr, nameof (HoverMaxDistance));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilitySpawnPrefabOnCast>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
