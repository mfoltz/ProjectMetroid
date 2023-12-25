// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.FadeOutObstacles
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Presentation
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FadeOutObstacles
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeightDifference;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_DepthOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;
    [FieldOffset(0)]
    public half Radius;
    [FieldOffset(2)]
    public half MaxHeightDifference;
    [FieldOffset(4)]
    public half HeightOffset;
    [FieldOffset(6)]
    public half DepthOffset;
    [FieldOffset(8)]
    public ModifiableBool Enabled;

    static FadeOutObstacles()
    {
      Il2CppClassPointerStore<FadeOutObstacles>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (FadeOutObstacles));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeOutObstacles>.NativeClassPtr);
      FadeOutObstacles.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOutObstacles>.NativeClassPtr, nameof (Radius));
      FadeOutObstacles.NativeFieldInfoPtr_MaxHeightDifference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOutObstacles>.NativeClassPtr, nameof (MaxHeightDifference));
      FadeOutObstacles.NativeFieldInfoPtr_HeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOutObstacles>.NativeClassPtr, nameof (HeightOffset));
      FadeOutObstacles.NativeFieldInfoPtr_DepthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOutObstacles>.NativeClassPtr, nameof (DepthOffset));
      FadeOutObstacles.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeOutObstacles>.NativeClassPtr, nameof (Enabled));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FadeOutObstacles>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
