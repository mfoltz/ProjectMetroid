﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilitySpawnPrefabOnStartCast
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilitySpawnPrefabOnStartCast
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    [FieldOffset(0)]
    public PrefabGUID SpawnPrefab;
    [FieldOffset(4)]
    public float BuffDuration;
    [FieldOffset(8)]
    public BlobAssetReference<ConditionBlob> Condition;

    static AbilitySpawnPrefabOnStartCast()
    {
      Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbilitySpawnPrefabOnStartCast));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast>.NativeClassPtr);
      AbilitySpawnPrefabOnStartCast.NativeFieldInfoPtr_SpawnPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast>.NativeClassPtr, nameof (SpawnPrefab));
      AbilitySpawnPrefabOnStartCast.NativeFieldInfoPtr_BuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast>.NativeClassPtr, nameof (BuffDuration));
      AbilitySpawnPrefabOnStartCast.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast>.NativeClassPtr, nameof (Condition));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilitySpawnPrefabOnStartCast>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
