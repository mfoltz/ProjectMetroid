// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.LightningStormTypeBlob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.LightningStorm
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LightningStormTypeBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Gameplay;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ambience;
    private static readonly System.IntPtr NativeFieldInfoPtr_OwnerPrefab;
    [FieldOffset(0)]
    public LightningStormStrikeSettings Gameplay;
    [FieldOffset(44)]
    public LightningStormStrikeSettings Ambience;
    [FieldOffset(88)]
    public PrefabGUID OwnerPrefab;

    static LightningStormTypeBlob()
    {
      Il2CppClassPointerStore<LightningStormTypeBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (LightningStormTypeBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightningStormTypeBlob>.NativeClassPtr);
      LightningStormTypeBlob.NativeFieldInfoPtr_Gameplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeBlob>.NativeClassPtr, nameof (Gameplay));
      LightningStormTypeBlob.NativeFieldInfoPtr_Ambience = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeBlob>.NativeClassPtr, nameof (Ambience));
      LightningStormTypeBlob.NativeFieldInfoPtr_OwnerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightningStormTypeBlob>.NativeClassPtr, nameof (OwnerPrefab));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightningStormTypeBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
