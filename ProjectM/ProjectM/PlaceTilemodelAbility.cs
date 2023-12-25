// Decompiled with JetBrains decompiler
// Type: ProjectM.PlaceTilemodelAbility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PlaceTilemodelAbility
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransformedTileModel;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnTileRotation;
    [FieldOffset(0)]
    public float3 SpawnTranslation;
    [FieldOffset(12)]
    public NetworkedEntity TransformedTileModel;
    [FieldOffset(24)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(28)]
    public TileRotation SpawnTileRotation;

    static PlaceTilemodelAbility()
    {
      Il2CppClassPointerStore<PlaceTilemodelAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PlaceTilemodelAbility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceTilemodelAbility>.NativeClassPtr);
      PlaceTilemodelAbility.NativeFieldInfoPtr_SpawnTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTilemodelAbility>.NativeClassPtr, nameof (SpawnTranslation));
      PlaceTilemodelAbility.NativeFieldInfoPtr_TransformedTileModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTilemodelAbility>.NativeClassPtr, nameof (TransformedTileModel));
      PlaceTilemodelAbility.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTilemodelAbility>.NativeClassPtr, nameof (PrefabGuid));
      PlaceTilemodelAbility.NativeFieldInfoPtr_SpawnTileRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceTilemodelAbility>.NativeClassPtr, nameof (SpawnTileRotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlaceTilemodelAbility>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
