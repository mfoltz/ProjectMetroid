// Decompiled with JetBrains decompiler
// Type: ProjectM.Hybrid.AnimationLayerToAnimatorLayerBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Hybrid
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AnimationLayerToAnimatorLayerBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimationLayer;
    private static readonly System.IntPtr NativeFieldInfoPtr_AnimatorLayer;
    [FieldOffset(0)]
    public AnimationLayerEnum AnimationLayer;
    [FieldOffset(4)]
    public int AnimatorLayer;

    static AnimationLayerToAnimatorLayerBuffer()
    {
      Il2CppClassPointerStore<AnimationLayerToAnimatorLayerBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Hybrid", nameof (AnimationLayerToAnimatorLayerBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationLayerToAnimatorLayerBuffer>.NativeClassPtr);
      AnimationLayerToAnimatorLayerBuffer.NativeFieldInfoPtr_AnimationLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerToAnimatorLayerBuffer>.NativeClassPtr, nameof (AnimationLayer));
      AnimationLayerToAnimatorLayerBuffer.NativeFieldInfoPtr_AnimatorLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationLayerToAnimatorLayerBuffer>.NativeClassPtr, nameof (AnimatorLayer));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationLayerToAnimatorLayerBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
