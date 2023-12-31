// Decompiled with JetBrains decompiler
// Type: ProjectM.RandomizedSpawnChain
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
  public struct RandomizedSpawnChain
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Settings;
    private static readonly System.IntPtr NativeFieldInfoPtr_Random;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChainInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastChildSurplusAutoChainTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Initialized;
    [FieldOffset(0)]
    public PrefabGUID Settings;
    [FieldOffset(4)]
    public Unity.Mathematics.Random Random;
    [FieldOffset(8)]
    public Entity SpawnChainInstance;
    [FieldOffset(16)]
    public double LastChildSurplusAutoChainTime;
    [FieldOffset(24)]
    public bool Initialized;

    static RandomizedSpawnChain()
    {
      Il2CppClassPointerStore<RandomizedSpawnChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RandomizedSpawnChain));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChain>.NativeClassPtr);
      RandomizedSpawnChain.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChain>.NativeClassPtr, nameof (Settings));
      RandomizedSpawnChain.NativeFieldInfoPtr_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChain>.NativeClassPtr, nameof (Random));
      RandomizedSpawnChain.NativeFieldInfoPtr_SpawnChainInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChain>.NativeClassPtr, nameof (SpawnChainInstance));
      RandomizedSpawnChain.NativeFieldInfoPtr_LastChildSurplusAutoChainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChain>.NativeClassPtr, nameof (LastChildSurplusAutoChainTime));
      RandomizedSpawnChain.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChain>.NativeClassPtr, nameof (Initialized));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChain>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
