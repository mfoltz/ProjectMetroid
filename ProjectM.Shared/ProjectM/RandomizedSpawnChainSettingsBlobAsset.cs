// Decompiled with JetBrains decompiler
// Type: ProjectM.RandomizedSpawnChainSettingsBlobAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RandomizedSpawnChainSettingsBlobAsset
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Groups;
    private static readonly System.IntPtr NativeFieldInfoPtr_TotalGroupWeight;
    [FieldOffset(0)]
    public BlobArray<RandomizedSpawnChainSettingsBlobAsset.Group> Groups;
    [FieldOffset(8)]
    public float TotalGroupWeight;

    static RandomizedSpawnChainSettingsBlobAsset()
    {
      Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RandomizedSpawnChainSettingsBlobAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset>.NativeClassPtr);
      RandomizedSpawnChainSettingsBlobAsset.NativeFieldInfoPtr_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset>.NativeClassPtr, nameof (Groups));
      RandomizedSpawnChainSettingsBlobAsset.NativeFieldInfoPtr_TotalGroupWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset>.NativeClassPtr, nameof (TotalGroupWeight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Group
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Chains;
      private static readonly System.IntPtr NativeFieldInfoPtr_GroupWeight;
      private static readonly System.IntPtr NativeFieldInfoPtr_TotalChainWeight;
      [FieldOffset(0)]
      public BlobArray<RandomizedSpawnChainSettingsBlobAsset.SpawnChain> Chains;
      [FieldOffset(8)]
      public float GroupWeight;
      [FieldOffset(12)]
      public float TotalChainWeight;

      static Group()
      {
        Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset.Group>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset>.NativeClassPtr, nameof (Group));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset.Group>.NativeClassPtr);
        RandomizedSpawnChainSettingsBlobAsset.Group.NativeFieldInfoPtr_Chains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset.Group>.NativeClassPtr, nameof (Chains));
        RandomizedSpawnChainSettingsBlobAsset.Group.NativeFieldInfoPtr_GroupWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset.Group>.NativeClassPtr, nameof (GroupWeight));
        RandomizedSpawnChainSettingsBlobAsset.Group.NativeFieldInfoPtr_TotalChainWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset.Group>.NativeClassPtr, nameof (TotalChainWeight));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset.Group>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SpawnChain
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
      [FieldOffset(0)]
      public PrefabGUID Prefab;
      [FieldOffset(4)]
      public float Weight;

      static SpawnChain()
      {
        Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset.SpawnChain>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset>.NativeClassPtr, nameof (SpawnChain));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset.SpawnChain>.NativeClassPtr);
        RandomizedSpawnChainSettingsBlobAsset.SpawnChain.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset.SpawnChain>.NativeClassPtr, nameof (Prefab));
        RandomizedSpawnChainSettingsBlobAsset.SpawnChain.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset.SpawnChain>.NativeClassPtr, nameof (Weight));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainSettingsBlobAsset.SpawnChain>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
