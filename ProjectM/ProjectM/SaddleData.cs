// Decompiled with JetBrains decompiler
// Type: ProjectM.SaddleData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SaddleData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MountBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;
    [FieldOffset(0)]
    public PrefabGUID MountBuff;
    [FieldOffset(4)]
    public float MaxSpeed;
    [FieldOffset(8)]
    public float RotationSpeed;
    [FieldOffset(12)]
    public float Acceleration;

    static SaddleData()
    {
      Il2CppClassPointerStore<SaddleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SaddleData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaddleData>.NativeClassPtr);
      SaddleData.NativeFieldInfoPtr_MountBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaddleData>.NativeClassPtr, nameof (MountBuff));
      SaddleData.NativeFieldInfoPtr_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaddleData>.NativeClassPtr, nameof (MaxSpeed));
      SaddleData.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaddleData>.NativeClassPtr, nameof (RotationSpeed));
      SaddleData.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaddleData>.NativeClassPtr, nameof (Acceleration));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SaddleData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
