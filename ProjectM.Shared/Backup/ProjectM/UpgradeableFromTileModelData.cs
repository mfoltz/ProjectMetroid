// Decompiled with JetBrains decompiler
// Type: ProjectM.UpgradeableFromTileModelData
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
  public struct UpgradeableFromTileModelData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RequireUpgradingToBuild;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefabs;
    [FieldOffset(0)]
    public bool RequireUpgradingToBuild;
    [FieldOffset(4)]
    public BlobArray<PrefabGUID> Prefabs;

    static UpgradeableFromTileModelData()
    {
      Il2CppClassPointerStore<UpgradeableFromTileModelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UpgradeableFromTileModelData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeableFromTileModelData>.NativeClassPtr);
      UpgradeableFromTileModelData.NativeFieldInfoPtr_RequireUpgradingToBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeableFromTileModelData>.NativeClassPtr, nameof (RequireUpgradingToBuild));
      UpgradeableFromTileModelData.NativeFieldInfoPtr_Prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeableFromTileModelData>.NativeClassPtr, nameof (Prefabs));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpgradeableFromTileModelData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
