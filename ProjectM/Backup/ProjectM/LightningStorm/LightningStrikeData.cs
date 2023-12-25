// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningStrikeData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.LightningStorm
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LightningStrikeData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prediction;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScatterRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreTileCollisionCheck;
    [FieldOffset(0)]
    public float Weight;
    [FieldOffset(4)]
    public float Prediction;
    [FieldOffset(8)]
    public float ScatterRadius;
    [FieldOffset(12)]
    public PrefabGUID Prefab;
    [FieldOffset(16)]
    public bool IgnoreTileCollisionCheck;

    static LightningStrikeData()
    {
      Il2CppClassPointerStore<LightningStrikeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningStrikeData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStrikeData>.NativeClassPtr);
      LightningStrikeData.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStrikeData>.NativeClassPtr, nameof (Weight));
      LightningStrikeData.NativeFieldInfoPtr_Prediction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStrikeData>.NativeClassPtr, nameof (Prediction));
      LightningStrikeData.NativeFieldInfoPtr_ScatterRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStrikeData>.NativeClassPtr, nameof (ScatterRadius));
      LightningStrikeData.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStrikeData>.NativeClassPtr, nameof (Prefab));
      LightningStrikeData.NativeFieldInfoPtr_IgnoreTileCollisionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStrikeData>.NativeClassPtr, nameof (IgnoreTileCollisionCheck));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStrikeData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
