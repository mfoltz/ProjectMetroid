// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleRailingPrefabsCollection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleRailingPrefabsCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RailingPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_CornerPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_WallsRequiringRailings;
    [FieldOffset(0)]
    public PrefabGUID RailingPrefab;
    [FieldOffset(4)]
    public PrefabGUID CornerPrefab;
    [FieldOffset(8)]
    public FixedList32<PrefabGUID> WallsRequiringRailings;

    static CastleRailingPrefabsCollection()
    {
      Il2CppClassPointerStore<CastleRailingPrefabsCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleRailingPrefabsCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRailingPrefabsCollection>.NativeClassPtr);
      CastleRailingPrefabsCollection.NativeFieldInfoPtr_RailingPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingPrefabsCollection>.NativeClassPtr, nameof (RailingPrefab));
      CastleRailingPrefabsCollection.NativeFieldInfoPtr_CornerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingPrefabsCollection>.NativeClassPtr, nameof (CornerPrefab));
      CastleRailingPrefabsCollection.NativeFieldInfoPtr_WallsRequiringRailings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRailingPrefabsCollection>.NativeClassPtr, nameof (WallsRequiringRailings));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRailingPrefabsCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
