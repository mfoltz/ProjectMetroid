// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.CurrentFadingDataSingleton
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Presentation
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CurrentFadingDataSingleton
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CameraFadingRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFadingRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetDepthOffset;
    [FieldOffset(0)]
    public float CameraFadingRadius;
    [FieldOffset(4)]
    public float TargetFadingRadius;
    [FieldOffset(8)]
    public float TargetDepthOffset;

    static CurrentFadingDataSingleton()
    {
      Il2CppClassPointerStore<CurrentFadingDataSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (CurrentFadingDataSingleton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurrentFadingDataSingleton>.NativeClassPtr);
      CurrentFadingDataSingleton.NativeFieldInfoPtr_CameraFadingRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentFadingDataSingleton>.NativeClassPtr, nameof (CameraFadingRadius));
      CurrentFadingDataSingleton.NativeFieldInfoPtr_TargetFadingRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentFadingDataSingleton>.NativeClassPtr, nameof (TargetFadingRadius));
      CurrentFadingDataSingleton.NativeFieldInfoPtr_TargetDepthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurrentFadingDataSingleton>.NativeClassPtr, nameof (TargetDepthOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurrentFadingDataSingleton>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
