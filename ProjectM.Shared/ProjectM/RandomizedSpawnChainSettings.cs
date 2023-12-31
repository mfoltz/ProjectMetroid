// Decompiled with JetBrains decompiler
// Type: ProjectM.RandomizedSpawnChainSettings
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
  public struct RandomizedSpawnChainSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BlobAsset;
    [FieldOffset(0)]
    public BlobAssetReference<RandomizedSpawnChainSettingsBlobAsset> BlobAsset;

    static RandomizedSpawnChainSettings()
    {
      Il2CppClassPointerStore<RandomizedSpawnChainSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (RandomizedSpawnChainSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainSettings>.NativeClassPtr);
      RandomizedSpawnChainSettings.NativeFieldInfoPtr_BlobAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainSettings>.NativeClassPtr, nameof (BlobAsset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
