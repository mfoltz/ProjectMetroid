// Decompiled with JetBrains decompiler
// Type: ProjectM.SubSceneSpawnChainPrefab
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SubSceneSpawnChainPrefab
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabType;
    [FieldOffset(0)]
    public PrefabGUID GUID;
    [FieldOffset(4)]
    public SubSceneSpawnChainPrefabType PrefabType;

    static SubSceneSpawnChainPrefab()
    {
      Il2CppClassPointerStore<SubSceneSpawnChainPrefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SubSceneSpawnChainPrefab));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubSceneSpawnChainPrefab>.NativeClassPtr);
      SubSceneSpawnChainPrefab.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSceneSpawnChainPrefab>.NativeClassPtr, nameof (GUID));
      SubSceneSpawnChainPrefab.NativeFieldInfoPtr_PrefabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubSceneSpawnChainPrefab>.NativeClassPtr, nameof (PrefabType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubSceneSpawnChainPrefab>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
